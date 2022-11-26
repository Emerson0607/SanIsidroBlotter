Public Class MenuPage

    Private Sub BTNblotter_Click(sender As Object, e As EventArgs) Handles BTNblotter.Click

        Me.Hide()
        Dim MainForm As New BlotterMenu
        MainForm.ShowDialog()
        Me.Show()




    End Sub
    Private Sub BTNagree_Click(sender As Object, e As EventArgs) Handles BTNagree.Click
        Me.Hide()
        Dim MainForm As New AgreeMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub



    Private Sub MenuPage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginPage.Close()
    End Sub





    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginPage.Show()
    End Sub
End Class