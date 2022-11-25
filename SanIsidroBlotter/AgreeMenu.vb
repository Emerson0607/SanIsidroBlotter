Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class AgreeMenu
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub AgreeMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPage.Show()

    End Sub


    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dim MainForm As New editAgree
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dim MainForm As New viewAgree
        MainForm.ShowDialog()
        Me.Show()
    End Sub



    Private Sub AgreeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadAgreement("SELECT `id`, `agreementDate`, `complainant`, `victim`, `suspect`, `witness` from agreement", DataGridView1)
        Dim FontSize As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font.Size, 9)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontSize

        Dim FontBold As New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = FontBold

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

        Me.Refresh()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        Dim MainForm As New CreateAgree
        MainForm.ShowDialog()
        Me.Show()
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

            delete("DELETE FROM agreement Where id = '" & id.SelectedItem & "'")
            MessageBox.Show("Deleted Successfully")
            Me.id.Items.Clear()

            reloadAgreement("SELECT id, agreementDate, complainant, victim, suspect, witness FROM agreement where id > 0 ORDER BY id;  ", DataGridView1)


        End If
    End Sub

    Private Sub id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id.SelectedIndexChanged
        reloadAgreement("SELECT  id, agreementDate, complainant, victim, suspect, witness FROM agreement where id > 0 ORDER BY id;  ", DataGridView1)


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reloadAgreement("SELECT  id,  agreementDate, complainant, victim, suspect, witness FROM agreement where id > 0 ORDER BY id;  ", DataGridView1)
        search.Clear()
        id.SelectedIndex = -1
        Me.Refresh()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        reloadAgreement("SELECT  id,  agreementDate, complainant, victim, suspect, witness FROM agreement where id LIKE '%" & search.Text _
               & "%' Or  agreementDate LIKE '%" & search.Text & "%' Or complainant LIKE '%" & search.Text _
               & "%' Or  victim LIKE '%" & search.Text & "%' Or suspect LIKE '%" & search.Text & "%'  Or witness LIKE '%" & search.Text & "%'", DataGridView1)


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        selectedIDagree = id.SelectedItem
        If String.IsNullOrWhiteSpace(selectedIDagree) Then
            MessageBox.Show("Select ID to edit!")
        Else Me.Hide()
            Dim MainForm As New editAgree
            MainForm.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        selectedIDagree = id.SelectedItem
        If String.IsNullOrWhiteSpace(selectedIDagree) Then
            MessageBox.Show("Select ID to view!")
        Else
            Me.Hide()
            Dim MainForm As New viewAgree
            MainForm.ShowDialog()
            Me.Show()
        End If
    End Sub
End Class