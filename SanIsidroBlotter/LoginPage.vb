Imports MySql.Data.MySqlClient
Public Class LoginPage

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(tbPassword.Text) Or String.IsNullOrWhiteSpace(tbUsername.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()

            Try

                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM users WHERE username = @user and password = @pass;"

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = tbUsername.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                strcon.Close()
                da.Dispose()

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    tbUsername.Text = ""
                    tbPassword.Text = ""
                Else
                    MessageBox.Show("Login Success", "Welcome to SAN ISIDRO BLOTTER SYSTEM!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbUsername.Clear()
                    tbPassword.Clear()

                    Me.Hide()
                    Dim MainForm As New MenuPage
                    MainForm.Show()
                    'MainForm.Show()    '//it shows the parent form also

                End If

            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
            End Try
        End If
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbUsername.Text = ""
        tbPassword.Text = ""

    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        Me.Hide()
        Dim MainForm As New register
        MainForm.ShowDialog()
        'MainForm.Show()    '//it shows the parent form also
        Me.Show()
    End Sub
End Class