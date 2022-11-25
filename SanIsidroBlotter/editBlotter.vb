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
                updates("UPDATE incidentBlotter SET reportDate = '" & reportDate.Value.Date.ToString("yyyy/MM/dd") & "', incidentType = '" & incidentType.Text _
                & "', incidentDT =  '" & incidentDT.Value.Date.ToString("yyyy/MM/dd") & "', incidentLocation = '" & incidentLocation.Text _
                & "', incidentDetails = '" & incidentDetails.Text & "', numberCall = '" & numberCall.Text & "' where id = '" & id.SelectedItem & "'")

                updates("UPDATE complainantBlotter SET fullname = '" & cFullname.Text & "', Citizenship = '" & cCitizenship.Text & "', gender ='" & cGender.Text _
                & "', bDay = '" & cbDay.Value.Date.ToString("yyyy/MM/dd") & "', contactNumber = '" & cContactNumber.Text & "', address = '" & cAddress.Text & "'")

                updates("UPDATE victimBlotter SET fullname = '" & vFullname.Text & "', Citizenship = '" & vCitizenship.Text & "', gender ='" & vGender.Text _
                & "', bDay = '" & vBday.Value.Date.ToString("yyyy/MM/dd") & "', contactNumber = '" & vContactNumber.Text & "', address = '" & vAddress.Text & "'")

                updates("UPDATE suspectBlotter SET fullname = '" & sFullname.Text & "', Citizenship = '" & sCitizenship.Text & "', gender ='" & sGender.Text _
                & "', bDay = '" & sBday.Value.Date.ToString("yyyy/MM/dd") & "', contactNumber = '" & sContactNumber.Text & "', address = '" & sAddress.Text & "'")


                MessageBox.Show("Blotter Updated!")

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

        'for incident Blotter table
        Try
            dbConn.Open()
            Dim query As String
            query = "Select reportDate, incidentType, incidentDT, incidentLocation, incidentDetails, numberCall from incidentBlotter where id = '" & id.SelectedItem & "'"
            'query = "Select * FROM complainantblotter, incidentblotter, suspectblotter, victimblotter Where complainantblotter.id = '" & id.SelectedItem _
            '    & "' and incidentblotter.id = '" & id.SelectedItem & "' and suspectblotter.id = '" & id.SelectedItem & "' and victimblotter.id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                reportDate.Text = READER.GetString("reportDate")
                incidentType.Text = READER.GetString("incidentType")
                incidentDT.Text = READER.GetString("incidentDT")
                incidentLocation.Text = READER.GetString("incidentLocation")
                incidentDetails.Text = READER.GetString("incidentDetails")
                numberCall.Text = READER.GetInt32("numberCall")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'for complainant blotter table

        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from complainantBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read

                'for complainant table
                cFullname.Text = READER.GetString("fullname")
                cCitizenship.Text = READER.GetString("Citizenship")
                cGender.Text = READER.GetString("gender")
                cbDay.Text = READER.GetString("bDay")
                cContactNumber.Text = READER.GetString("contactNumber")
                cAddress.Text = READER.GetString("address")

            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'for for victim table
        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from victimBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read

                'for victim table
                vFullname.Text = READER.GetString("fullname")
                vCitizenship.Text = READER.GetString("Citizenship")
                vGender.Text = READER.GetString("gender")
                vBday.Text = READER.GetString("bDay")
                vContactNumber.Text = READER.GetString("contactNumber")
                vAddress.Text = READER.GetString("address")

            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'for for suspect table
        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from suspectBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read

                'for suspect table
                sFullname.Text = READER.GetString("fullname")
                sCitizenship.Text = READER.GetString("Citizenship")
                sGender.Text = READER.GetString("gender")
                sBday.Text = READER.GetString("bDay")
                sContactNumber.Text = READER.GetString("contactNumber")
                sAddress.Text = READER.GetString("address")

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