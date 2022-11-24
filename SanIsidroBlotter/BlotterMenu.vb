Imports System.ComponentModel

Public Class BlotterMenu

    Private Sub BlotterMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPage.Show()

    End Sub


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me.Hide()
        Dim MainForm As New viewBlotter
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim MainForm As New CreateBlotter
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        Dim MainForm As New editBlotter
        MainForm.ShowDialog()
        Me.Show()
    End Sub



    Private Sub BlotterMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id ORDER BY incidentBlotter.id;  ", DataGridView1)
        Dim FontSize As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font.Size, 9)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontSize

        Dim FontBold As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontBold
    End Sub
End Class