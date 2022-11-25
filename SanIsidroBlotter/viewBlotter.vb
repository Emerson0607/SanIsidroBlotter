Imports MySql.Data.MySqlClient
Public Class viewBlotter
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub viewBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter ;Persist Security Info=True;Convert Zero Datetime=True"

        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand



        Try
            dbConn.Open()
            Dim query As String
            query = "Select id, reportDate, incidentType, incidentDT, incidentLocation, incidentDetails, numberCall from incidentBlotter where id = '" & selectedID & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                id.Text = READER.GetString("id")
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
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from complainantBlotter where id = '" & selectedID & "'"

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
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from victimBlotter where id = '" & selectedID & "'"

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
            query = "Select fullname, Citizenship, gender, bDay, contactNumber, address from suspectBlotter where id = '" & selectedID & "'"

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
End Class