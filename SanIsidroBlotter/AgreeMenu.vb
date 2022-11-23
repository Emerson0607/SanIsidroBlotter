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
End Class