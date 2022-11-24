Public Class CreateBlotter
    Private Sub CreateBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(id.Text) Or String.IsNullOrWhiteSpace(reportDate.Text) Or String.IsNullOrWhiteSpace(incidentType.Text) Or String.IsNullOrWhiteSpace(incidentDT.Text) _
            Or String.IsNullOrWhiteSpace(incidentLocation.Text) Or String.IsNullOrWhiteSpace(incidentDetails.Text) Or String.IsNullOrWhiteSpace(numberCall.Text) Then
            MessageBox.Show("Enter complete data first!")
        ElseIf numberCall.Text >= 4 Then
            MessageBox.Show("Only have 3 call")
        Else
            Try
                create("INSERT INTO incidentBlotter (id, reportDate, incidentDate, incidentType, incidentDT, incidentLocation, incidentDetails, numberCall) VALUES('" & id.Text _
              & "','" & reportDate.Value.Date & "','" & incidentType.Text & "', '" & incidentDT.Value.Date & "', '" & incidentLocation.Text & "', '" & incidentDetails.Text & "', '" & numberCall.Text & "')")

                MessageBox.Show("Report Submitted!", "Success")

            Catch ex As Exception
                MessageBox.Show("Error, you must complete incident details" & ex.Message.ToString)
            Finally

            End Try
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class