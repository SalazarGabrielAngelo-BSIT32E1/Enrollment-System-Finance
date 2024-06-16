Imports System.Data.OleDb

Public Class frmListOfStudents
    Public SelectedStudent As String
    Private Sub dgvListofStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListofStudents.CellContentClick
        SelectedStudent = dgvListofStudents.Rows(e.RowIndex).Cells(0).Value.ToString
        frmPayment.ShowDialog()
    End Sub

    Public Sub ReloadStudent() Handles txtSearch.OnValueChanged
        connection()
        sql = "SELECT * FROM [qryStudent] WHERE ([StudentNo] LIKE '" & txtSearch.Text & "%' AND [Status] = 'To Pay') OR ([LName] LIKE '" & txtSearch.Text & "%' AND [Status] = 'To Pay') OR ([FName] LIKE '" & txtSearch.Text & "%' AND [Status] = 'To Pay') OR ([StudentNo] LIKE '" & txtSearch.Text & "%' AND [Status] = 'Partially Enrolled') OR ([LName] LIKE '" & txtSearch.Text & "%' AND [Status] = 'Partially Enrolled') OR ([FName] LIKE '" & txtSearch.Text & "%' AND [Status] = 'Partially Enrolled')"

        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        dgvListofStudents.Rows.Clear()
        Do While dr.Read()
            Dim row As New DataGridViewRow
            row.CreateCells(dgvListofStudents)
            row.Cells(0).Value = dr("StudentID").ToString
            row.Cells(1).Value = dr("StudentNo").ToString
            row.Cells(2).Value = dr("LName").ToString + ", " + dr("FName").ToString + ", " + dr("MI").ToString
            row.Cells(3).Value = dr("ContactNo").ToString
            row.Cells(4).Value = dr("BDate").ToString
            row.Cells(5).Value = dr("SchoolYear").ToString
            row.Cells(6).Value = dr("Semester").ToString
            row.Cells(7).Value = dr("Course").ToString
            row.Cells(8).Value = dr("Department").ToString
            row.Cells(9).Value = dr("Section").ToString
            row.Cells(10).Value = dr("Status").ToString
            dgvListofStudents.Rows.Add(row)
        Loop
    End Sub

    Private Sub frmListOfStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        ReloadStudent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmFinance.Show()
    End Sub
End Class