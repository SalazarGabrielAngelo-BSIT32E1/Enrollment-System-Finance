Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class frmPayment
    Dim remainingB As Integer
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TransID As New Random
        txtTransactionID.Text = "TRANS" + TransID.Next(100000000).ToString
        txtStudentID.Text = frmListOfStudents.SelectedStudent
        Timer1.Start()

        RemainingBalance()
    End Sub

    Private Sub RemainingBalance()
        'remainingB = txtFP.Text
        txtRB.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "RemainingBalance")
    End Sub

    Private Sub UpdateRemainingBalance(paymentAmount As Integer)
        ' Update remaining balance by subtracting payment amount
        Dim remainingBalance As Integer = Convert.ToInt32(txtRB.Text)
        remainingBalance -= paymentAmount

        ' Ensure remaining balance is not negative
        If remainingBalance < 0 Then
            remainingBalance = 0
        End If

        ' Update remaining balance display
        txtRB.Text = remainingBalance.ToString()

        ' If remaining balance becomes zero, change status to Enrolled
        If remainingBalance = 0 Then
            sql = "UPDATE [tblStudents] SET [Status] = 'Enrolled' WHERE [StudentID] = '" & txtStudentID.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
        End If

        ' Update remaining balance in tblAssessment
        sql = "UPDATE [tblAssessment] SET [RemainingBalance] = " & remainingBalance & " WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
    End Sub


    Private Sub cbMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMethod.SelectedIndexChanged
        If cbMethod.Text = "Full Payment" Then
            txtFP.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "RemainingBalance")
        ElseIf cbMethod.Text = "Prelim" Then
            txtFP.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "Prelim")
        ElseIf cbMethod.Text = "Midterm" Then
            txtFP.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "Midterm")
        ElseIf cbMethod.Text = "Pre-Final" Then
            txtFP.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "PreFinal")
        ElseIf cbMethod.Text = "Final" Then
            txtFP.Text = getID("SELECT * FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'", "Final")
        Else
            txtFP.Text = "5000"
        End If
    End Sub
    Function getID(theSql As String, ItemColumn As String)
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        cmd = New OleDbCommand(theSql, cn)
        dr = cmd.ExecuteReader
        dr.Read()
        Return dr(ItemColumn).ToString
    End Function

    Private Sub txtPaymentAmount_OnValueChanged(sender As Object, e As EventArgs) Handles txtPaymentAmount.OnValueChanged
        If txtPaymentAmount.Text = "" Then
            txtChange.Text = "-" + txtFP.Text
            Return
        End If
        txtChange.Text = Int(txtPaymentAmount.Text) - Int(txtFP.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtOR.Text = "" Or cbMethod.Text = "" Or txtPaymentAmount.Text = "" Then
            MsgBox("Empty Field!", MsgBoxStyle.Exclamation)
            Return
        End If
        If Int(txtPaymentAmount.Text) < Int(txtFP.Text) Then
            MsgBox("Payment is Less Than Price!", MsgBoxStyle.Exclamation)
            Return
        End If
        If CheckORNoExists(txtOR.Text) Then
            MsgBox("ORNo Already Exists!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Check if assessment is already paid for the selected student
        Dim assessmentType As String = ""
        Select Case cbMethod.Text
            Case "Prelim"
                assessmentType = "SPrelim"
            Case "Midterm"
                assessmentType = "SMidterm"
            Case "Pre-Final"
                assessmentType = "SPreFinal"
            Case "Final"
                assessmentType = "SFinal"
            Case "Installment"
                assessmentType = "SInstallment"
        End Select

        If assessmentType <> "" AndAlso CheckAlreadyPaid(assessmentType) Then
            MsgBox("Already Paid!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' If assessment is not paid, proceed with printing the receipt
        printDocument.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Paper Size Name", 500, 400)
        PrintPreviewDialog.Document = printDocument
        PrintPreviewDialog.ShowDialog()

        Dim status As String
        Dim updateAssessmentColumn As Boolean = False

        If cbMethod.Text = "Full Payment" Then
            status = "Enrolled"
        ElseIf cbMethod.Text = "Installment" Then
            status = "Partially Enrolled"
            updateAssessmentColumn = True
        Else
            status = "Partially Enrolled"
            updateAssessmentColumn = True
        End If

        ' Update transactions table
        sql = "Insert Into [tblTransactions] ([TransactionID],[StudentID], [ORNo], [PaymentMethod], [PaymentAmount], [DateTime], [RemainingAmount])VALUES('" & txtTransactionID.Text & "','" & txtStudentID.Text & "','" & txtOR.Text & "','" & cbMethod.Text & "','" & txtPaymentAmount.Text & "', '" & lblDate.Text & "','" & txtRB.Text & "')"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()

        ' Update students table with status
        sql = "UPDATE [tblStudents] SET [Status] = '" & status & "', [StudentID] = '" & txtStudentID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()

        ' Update remaining balance in tblAssessment
        UpdateRemainingBalance(Convert.ToInt32(txtPaymentAmount.Text))

        ' Update corresponding columns in tblAssessment based on payment method
        If updateAssessmentColumn Then
            UpdateAssessmentColumns(cbMethod.Text)
        End If

        ' Reload student list
        frmListOfStudents.ReloadStudent()
        Me.Close()
    End Sub

    Private Function CheckAlreadyPaid(columnName As String) As Boolean
        ' Check if the specified column is True for the selected student
        sql = "SELECT [" & columnName & "] FROM [tblAssessment] WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            Return Convert.ToBoolean(result)
        End If
        Return False
    End Function

    Private Sub UpdateAssessmentColumns(paymentMethod As String)
        Dim columnName As String = ""

        ' Determine which column to update based on payment method
        Select Case paymentMethod
            Case "Prelim"
                columnName = "SPrelim"
            Case "Midterm"
                columnName = "SMidterm"
            Case "Pre-Final"
                columnName = "SPreFinal"
            Case "Final"
                columnName = "SFinal"
            Case "Installment"
                columnName = "SInstallment"
        End Select

        If columnName <> "" Then
            ' Update specified column in tblAssessment
            sql = "UPDATE [tblAssessment] SET [" & columnName & "] = True WHERE [StudentID] = '" & frmListOfStudents.SelectedStudent & "'"
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Function CheckORNoExists(ORNo As String) As Boolean
        ' Check if the specified ORNo already exists in the database
        sql = "SELECT COUNT(*) FROM [tblTransactions] WHERE [ORNo] = '" & ORNo & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument.PrintPage
        e.Graphics.DrawString("Lyceum of Alabang", printingFontHead.Font, Brushes.Black, 5, 5)
        e.Graphics.DrawString("Enrollment Fee.", printingFontSmall.Font, Brushes.Black, 350, 20)
        e.Graphics.DrawString("------------------------------------------------------------------------", printingFontHead.Font, Brushes.Black, -5, 27)
        e.Graphics.DrawString("Date: " & Now & "", printingFontHead2.Font, Brushes.Black, 5, 75)
        e.Graphics.DrawString("TransID: " & txtTransactionID.Text & " ", printingFontHead2.Font, Brushes.Black, 250, 75)
        e.Graphics.DrawString("------------------------------------------------------------------------", printingFontHead.Font, Brushes.Black, -5, 80)
        e.Graphics.DrawString("OR Number", printingFontSmall.Font, Brushes.Black, 5, 120)
        e.Graphics.DrawString(txtOR.Text, printingFontSmall.Font, Brushes.Black, 5, 150)
        e.Graphics.DrawString("Payment Method", printingFontSmall.Font, Brushes.Black, 5, 220)
        e.Graphics.DrawString(cbMethod.Text, printingFontSmall.Font, Brushes.Black, 5, 250)
        e.Graphics.DrawString("Payment Amount", printingFontSmall.Font, Brushes.Black, 5, 320)
        e.Graphics.DrawString(txtPaymentAmount.Text, printingFontSmall.Font, Brushes.Black, 5, 350)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now
    End Sub

    Private Sub NumbersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaymentAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmListOfStudents.Show()
    End Sub
End Class