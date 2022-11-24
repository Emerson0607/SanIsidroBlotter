Imports MySql.Data.MySqlClient
Public Class editBlotter
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(id.Text) Or String.IsNullOrWhiteSpace(reportDate.Value.Date) Or String.IsNullOrWhiteSpace(incidentType.Text) Or String.IsNullOrWhiteSpace(incidentDT.Value.Date) _
           Or String.IsNullOrWhiteSpace(incidentLocation.Text) Or String.IsNullOrWhiteSpace(incidentDetails.Text) Or String.IsNullOrWhiteSpace(numberCall.Text) _
          Or String.IsNullOrWhiteSpace(cFullname.Text) Or String.IsNullOrWhiteSpace(cCitizenship.Text) Or String.IsNullOrWhiteSpace(cGender.Text) Or String.IsNullOrWhiteSpace(cbDay.Value.Date) _
          Or String.IsNullOrWhiteSpace(cContactNumber.Text) Or String.IsNullOrWhiteSpace(cAddress.Text) _
          Or String.IsNullOrWhiteSpace(vFullname.Text) Or String.IsNullOrWhiteSpace(vCitizenship.Text) Or String.IsNullOrWhiteSpace(vGender.Text) Or String.IsNullOrWhiteSpace(vBday.Value.Date) _
          Or String.IsNullOrWhiteSpace(vContactNumber.Text) Or String.IsNullOrWhiteSpace(vAddress.Text) _
          Or String.IsNullOrWhiteSpace(sFullname.Text) Or String.IsNullOrWhiteSpace(sCitizenship.Text) Or String.IsNullOrWhiteSpace(sGender.Text) Or String.IsNullOrWhiteSpace(sBday.Value.Date) _
          Or String.IsNullOrWhiteSpace(sContactNumber.Text) Or String.IsNullOrWhiteSpace(sAddress.Text) Then

            MessageBox.Show("Enter complete data first!")
        ElseIf numberCall.Text >= 4 Then
            MessageBox.Show("Only have 3 call")
        Else
            Try
                create("INSERT INTO incidentBlotter (id, reportDate, incidentType, incidentDT, incidentLocation, incidentDetails, numberCall) VALUES('" & id.Text _
              & "','" & reportDate.Value.Date & "','" & incidentType.Text & "', '" & incidentDT.Value.Date & "', '" & incidentLocation.Text & "', '" & incidentDetails.Text & "', '" & numberCall.Text & "')")

                create("INSERT INTO complainantBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
              & "','" & cFullname.Text & "','" & cCitizenship.Text & "', '" & cGender.Text & "', '" & cbDay.Value.Date & "', '" & cContactNumber.Text & "', '" & cAddress.Text & "')")

                create("INSERT INTO victimBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
              & "','" & vFullname.Text & "','" & vCitizenship.Text & "', '" & vGender.Text & "', '" & vBday.Value.Date & "', '" & vContactNumber.Text & "', '" & vAddress.Text & "')")

                create("INSERT INTO suspectBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
              & "','" & sFullname.Text & "','" & sCitizenship.Text & "', '" & sGender.Text & "', '" & sBday.Value.Date & "', '" & sContactNumber.Text & "', '" & sAddress.Text & "')")


                MessageBox.Show("Completed! New Blotter Recorded")

            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)
            Finally

            End Try
        End If
    End Sub

    Private Sub id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id.SelectedIndexChanged

        dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter ;Persist Security Info=True;Convert Zero Datetime=True"

        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand



        Try
            dbConn.Open()
            Dim query As String
            query = "Select reportDate, incidentType, incidentDT, incidentLocation, incidentDetails, numberCall from incidentBlotter  where id = '" & id.SelectedItem & "'"
            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read

                reportDate.Text = READER.Item("reportDate").ToString()
                incidentType.Text = READER.GetString("incidentType")
                incidentDT.Text = READER.Item("incidentDT").ToString()
                incidentLocation.Text = READER.GetString("incidentLocation")
                incidentDetails.Text = READER.GetString("incidentDetails")
                numberCall.Text = READER.GetInt32("numberCall")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub editBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter;Persist Security Info=True;Convert Zero Datetime=True "

        Try
            dbConn.Open()
            Dim sql1 = String.Format("Select id from incidentBlotter where id > 0")

            adapter = New MySqlDataAdapter(sql1, dbConn)

            ds = New DataSet

            adapter.Fill(ds, "incidentBlotter")
            adapter.Dispose()

            If ds.Tables("incidentBlotter").Rows.Count > 0 Then
                Me.id.Items.Clear()
                Dim i As Integer
                For i = 0 To ds.Tables("incidentBlotter").Rows.Count - 1
                    With Me.id
                        .Items.Add(ds.Tables("incidentBlotter").Rows(i).Item("id"))
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
    End Sub


End Class