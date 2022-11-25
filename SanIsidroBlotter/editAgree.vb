Imports MySql.Data.MySqlClient
Public Class editAgree
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet


    Private Sub editAgree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter;Persist Security Info=True;Convert Zero Datetime=True "

        Try
            dbConn.Open()
            Dim sql1 = String.Format("Select id from agreement where id > 0")

            adapter = New MySqlDataAdapter(sql1, dbConn)

            ds = New DataSet

            adapter.Fill(ds, "agreement")
            adapter.Dispose()

            If ds.Tables("agreement").Rows.Count > 0 Then
                Me.id.Items.Clear()
                Dim i As Integer
                For i = 0 To ds.Tables("agreement").Rows.Count - 1
                    With Me.id
                        .Items.Add(ds.Tables("agreement").Rows(i).Item("id"))
                    End With
                Next
            Else
                MessageBox.Show("No data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        Finally
            dbConn.Close()
        End Try


        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter ;Persist Security Info=True;Convert Zero Datetime=True"

        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        'for incident Blotter table
        Try
            dbConn.Open()
            Dim query As String
            query = "SELECT `id`, `agreementDate`, `complainant`, `victim`, `suspect`, `witness`, `agreement`, `agreementLocation`, `officeName` from agreement where id = '" & selectedIDagree & "'"
            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                id.Text = READER.GetString("id")
                tbDate.Text = READER.GetString("agreementDate")
                tbCname.Text = READER.GetString("complainant")
                tbVname.Text = READER.GetString("victim")
                tbSname.Text = READER.GetString("suspect")
                tbWname.Text = READER.GetString("witness")
                tbAgreement.Text = READER.GetString("agreement")
                tbOffice.Text = READER.GetString("officeName")
                tbLocation.Text = READER.GetString("agreementLocation")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class