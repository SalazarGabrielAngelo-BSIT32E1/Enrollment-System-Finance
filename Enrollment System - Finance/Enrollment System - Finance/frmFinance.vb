Public Class frmFinance
    Private Sub btnStudentPayment_Click(sender As Object, e As EventArgs) Handles btnStudentPayment.Click
        frmListOfStudents.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
        Form1.txtPassword.Text = ""
    End Sub
End Class