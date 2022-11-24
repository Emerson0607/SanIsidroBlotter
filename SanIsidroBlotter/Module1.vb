'INVENTORY And SALES MANAGEMENT SYTEM
'MEMBER: EMERSON MARTINEZ
'        JOVILLE AVILA
'        HARISON BAGA
'        GLAIZA BAUTISTA

Imports MySql.Data.MySqlClient
Module Module1
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim dateCurrent As String
    Public profile As String


    'Public Function userProfile()
    '    Return profile
    'End Function 


    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;port=3306;database=blotter; Persist Security Info=True;Convert Zero Datetime=True ")
    End Function


    Public Sub create(ByVal sql As String)  'insert data into database
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery    'data executed
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)


            dtg.datasource = dt

            With dtg
                .datasource = dt
                .columns(0).headertext = "Entry ID"
                .columns(1).headertext = "Incident type"
                .columns(2).headertext = "Incident Location"
                .columns(3).headertext = "Incident Date"
                .columns(4).headertext = "Complainant"
                .Columns(0).Width = 40
                .Columns(1).Width = 70
                .Columns(2).Width = 70
                .Columns(3).Width = 70
                .Columns(4).Width = 100
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()

        End Try
    End Sub

    Public Sub reloadAgreement(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)


            dtg.datasource = dt

            With dtg
                .datasource = dt
                .columns(0).headertext = "Entry ID"
                .columns(1).headertext = "Incident type"
                .columns(2).headertext = "Incident Location"
                .columns(3).headertext = "Incident Date"
                .columns(4).headertext = "Agreement Date"
                .columns(5).headertext = "Complainant"
                .Columns(0).Width = 40
                .Columns(1).Width = 60
                .Columns(2).Width = 60
                .Columns(3).Width = 50
                .Columns(4).Width = 50
                .Columns(5).Width = 90
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()

        End Try
    End Sub
    'Public Sub reloadhome(ByVal sql As String, ByVal dtg As Object)
    '    Try
    '        dt = New DataTable
    '        strcon.Open()
    '        With cmd                            'call data
    '            .Connection = strcon
    '            .CommandText = sql
    '        End With
    '        da.SelectCommand = cmd
    '        da.Fill(dt)
    '        dtg.datasource = dt

    '        With dtg
    '            .datasource = dt
    '            .columns(0).headertext = "product code"
    '            .columns(1).headertext = "product name"
    '            .columns(2).headertext = "quantity"
    '            .columns(0).width = 50
    '            .columns(1).width = 75
    '            .columns(2).width = 50

    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        strcon.Close()
    '        da.Dispose()

    '    End Try
    'End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery    'data executed
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    'Public Sub delete(ByVal sql As String)
    '    Try
    '        strcon.Open()
    '        With cmd                            'call data
    '            .Connection = strcon
    '            .CommandText = sql
    '            result = cmd.ExecuteNonQuery    'data executed
    '        End With

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        strcon.Close()
    '    End Try
    'End Sub

    Public Sub reloadData(ByVal sql As String)  'insert data into database
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql

            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & "reload text")
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
                da.Dispose()
            End If
        End Try
    End Sub

End Module