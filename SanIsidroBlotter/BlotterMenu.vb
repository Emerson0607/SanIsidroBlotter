Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class BlotterMenu
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub BlotterMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPage.Show()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        selectedID = id.SelectedItem
        If String.IsNullOrWhiteSpace(selectedID) Then
            MessageBox.Show("Select ID to view!")
        Else
            Me.Hide()
            Dim MainForm As New viewBlotter
            MainForm.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim MainForm As New CreateBlotter
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(selectedID) Then
            MessageBox.Show("Select ID to view!")
        Else Me.Hide()
            Dim MainForm As New editBlotter
            MainForm.ShowDialog()
            Me.Show()
        End If
    End Sub



    Private Sub BlotterMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id ORDER BY incidentBlotter.id;  ", DataGridView1)
        Dim FontSize As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font.Size, 9)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontSize

        Dim FontBold As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontBold


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
        Me.Refresh()

    End Sub

    Private Sub id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id.SelectedIndexChanged
        reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id where incidentBlotter.id = '" & id.SelectedItem & "'", DataGridView1)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id ORDER BY incidentBlotter.id;  ", DataGridView1)
        search.Clear()
        id.SelectedIndex = -1
        Me.Refresh()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged

        reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id where incidentBlotter.id LIKE '%" & search.Text _
               & "%' Or incidentBlotter.incidentType LIKE '%" & search.Text & "%' Or incidentBlotter.incidentLocation LIKE '%" & search.Text _
               & "%' Or  incidentBlotter.incidentDT LIKE '%" & search.Text & "%' Or complainantBlotter.fullname LIKE '%" & search.Text & "%'", DataGridView1)



    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        Dim i As Integer

        For i = -1 To DataGridView1.Columns.Count
            If e.ColumnIndex = i And e.RowIndex = -1 Then
                e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
            End If
        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(id.SelectedItem) Then
            MessageBox.Show("Select ID to delete!")
        Else

            delete("DELETE FROM complainantBlotter Where id = '" & id.SelectedItem & "'")
            delete("DELETE FROM incidentBlotter Where id = '" & id.SelectedItem & "'")
            delete("DELETE FROM victimBlotter Where id = '" & id.SelectedItem & "'")
            delete("DELETE FROM suspectBlotter Where id = '" & id.SelectedItem & "'")
            MessageBox.Show("Deleted Successfully")
            Me.id.Items.Clear()

            reload("SELECT incidentBlotter.id, incidentBlotter.incidentType, incidentBlotter.incidentLocation, incidentBlotter.incidentDT, complainantBlotter.fullname FROM incidentBlotter INNER JOIN complainantBlotter ON incidentBlotter.id = complainantBlotter.id ORDER BY incidentBlotter.id;  ", DataGridView1)


        End If
    End Sub
End Class