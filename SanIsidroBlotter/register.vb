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

            '    Try
            '        strcon.Open()
            '        cmd.Connection = strcon
            '        cmd.CommandText = "SELECT password FROM users WHERE password = '" & tbOldPassword.Text & "'"

            '        da.SelectCommand = cmd
            '        da.Fill(dt)
            '        strcon.Close()

            '        If dt.Rows.Count = 0 Then
            '            MessageBox.Show("Invalid Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '            tbOldPassword.Text = ""
            '        Else

            '            updates("UPDATE users SET password = '" & tbNewPassword.Text & "' WHERE password = '" & tbOldPassword.Text & "'")
            '            MessageBox.Show("New Password Created!")
            '            Me.Refresh()
            '            Dim MainForm As New LoginPage
            '            MainForm.Show()
            '            Me.Close()
            '        End If

            '        'MainForm.Show()    '//it shows the parent form also


            '    Catch ex As Exception
            '        MessageBox.Show("Error" & ex.Message.ToString)
            '    Finally
            '        cmd.Parameters.Clear()
            'End Try
        End If

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class