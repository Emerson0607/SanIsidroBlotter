Imports System.ComponentModel

Public Class AgreeMenu

    Private Sub AgreeMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPage.Show()

    End Sub


    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        Dim MainForm As New editAgree
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        Me.Hide()
        Dim MainForm As New viewAgree
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim MainForm As New CreateAgree
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AgreeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadAgreement("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT,  agreement.agreementDate, agreement.complainant FROM incidentBlotter INNER JOIN agreement ON incidentBlotter.id = agreement.id ORDER BY incidentBlotter.id;  ", DataGridView1)
        Dim FontSize As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font.Size, 9)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontSize

        Dim FontBold As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontBold
    End Sub
End Class