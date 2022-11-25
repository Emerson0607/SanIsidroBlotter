Imports MySql.Data.MySqlClient
Public Class register

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click


        If String.IsNullOrWhiteSpace(tbOldPassword.Text) Or String.IsNullOrWhiteSpace(tbNewPassword.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else

            reloadData("SELECT * FROM users WHERE password = '" & tbOldPassword.Text & "'")
            If dt.Rows.Count = 0 Then

                MessageBox.Show("Wrong Old Password", "failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Try
                    updates("UPDATE users SET password = '" & tbNewPassword.Text & "' WHERE password = '" & tbOldPassword.Text & "'")
                    MessageBox.Show("New Password Created!")
                    Dim MainForm As New LoginPage
                    MainForm.Show()
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                Finally

                End Try
            End If

        End If

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class