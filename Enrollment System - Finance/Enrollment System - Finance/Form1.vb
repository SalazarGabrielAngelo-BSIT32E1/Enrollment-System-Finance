Imports System.Data.OleDb

Public Class Form1
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim attempts As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MsgBox("Enter Username", MsgBoxStyle.Exclamation)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter Password", MsgBoxStyle.Exclamation)
        ElseIf txtPassword.Text = "" And txtUsername.Text = "" Then
            MsgBox("Enter Username and Password", MsgBoxStyle.Exclamation)
        Else
            Call CheckAccount()
        End If
    End Sub

    Private Sub CheckAccount()
        cn.Close()
        cn.Open()
        sql = "SELECT [Username], [Password], [AccountStatus], [Attempts] FROM tblUsers WHERE [Username] = '" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read() Then
            Dim username As String = dr("Username").ToString()
            Dim accountStatus As String = dr("AccountStatus").ToString()
            Dim Password As String = dr("Password").ToString()
            Dim currentAttempts As Integer = CInt(dr("Attempts"))

            If accountStatus = "Inactive" Then
                MsgBox("Your account is inactive. Please contact an administrator.", MsgBoxStyle.Critical)
            ElseIf Password = txtPassword.Text Then
                attempts = 0
                UpdateAttempts(username, 0)
                cn.Close()
                Login(username)
            Else
                attempts += 1
                currentAttempts += 1
                MsgBox("Invalid password. Attempts remaining: " & (3 - currentAttempts), MsgBoxStyle.Exclamation)
                If currentAttempts = 3 Then
                    UpdateAccountStatus(username, "Inactive")
                    MsgBox("You have reached the maximum number of login attempts. Your account has been set to inactive.", MsgBoxStyle.Critical)
                    currentAttempts = 0
                End If
                UpdateAttempts(username, currentAttempts)
            End If
        Else
            MsgBox("There's no such account exist!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Login(username As String)
        Call connection()
        cn.Close()
        cn.Open()
        da = New OleDbDataAdapter("SELECT * FROM [tblUsers] WHERE [Username] ='" & username & "' AND [AccountStatus] = 'Active'", cn)
        dset = New DataSet
        da.Fill(dset, "tblUser")

        If dset.Tables("tblUser").Rows.Count > 0 Then
            Dim position As String = dset.Tables("tblUser").Rows(0)("Role").ToString()

            Select Case position
                Case "Finance"
                    frmFinance.Show()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
            End Select
        End If
        cn.Close()
    End Sub
    Private Sub UpdateAttempts(username As String, attempts As Integer)
        sql = "UPDATE tblUsers SET [Attempts] = " & attempts & " WHERE [Username] = '" & username & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateAccountStatus(username As String, accountStatus As String)
        sql = "UPDATE tblUsers SET [AccountStatus] = '" & accountStatus & "' WHERE [Username] = '" & username & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
