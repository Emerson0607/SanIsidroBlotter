Public Class CreateBlotter

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'If String.IsNullOrWhiteSpace(id.Text) Or String.IsNullOrWhiteSpace(reportDate.Text) Or String.IsNullOrWhiteSpace(incidentType.Text) Or String.IsNullOrWhiteSpace(incidentDT.Text) _
        '    Or String.IsNullOrWhiteSpace(incidentLocation.Text) Or String.IsNullOrWhiteSpace(incidentDetails.Text) Or String.IsNullOrWhiteSpace(numberCall.Text) _
        '   Or String.IsNullOrWhiteSpace(cFullname.Text) Or String.IsNullOrWhiteSpace(cCitizenship.Text) Or String.IsNullOrWhiteSpace(cGender.Text) Or String.IsNullOrWhiteSpace(cBday.Text) _
        '   Or String.IsNullOrWhiteSpace(cContactNumber.Text) Or String.IsNullOrWhiteSpace(cAddress.Text) _
        '   Or String.IsNullOrWhiteSpace(vFullname.Text) Or String.IsNullOrWhiteSpace(vCitizenship.Text) Or String.IsNullOrWhiteSpace(vGender.Text) Or String.IsNullOrWhiteSpace(vBday.Text) _
        '   Or String.IsNullOrWhiteSpace(vContactNumber.Text) Or String.IsNullOrWhiteSpace(vAddress.Text) _
        '   Or String.IsNullOrWhiteSpace(sFullname.Text) Or String.IsNullOrWhiteSpace(sCitizenship.Text) Or String.IsNullOrWhiteSpace(sGender.Text) Or String.IsNullOrWhiteSpace(sBday.Text) _
        '   Or String.IsNullOrWhiteSpace(sContactNumber.Text) Or String.IsNullOrWhiteSpace(sAddress.Text) Then

        If String.IsNullOrWhiteSpace(id.Text) Or String.IsNullOrWhiteSpace(reportDate.Text) Or String.IsNullOrWhiteSpace(incidentType.Text) Or String.IsNullOrWhiteSpace(incidentDT.Text) _
            Or String.IsNullOrWhiteSpace(incidentLocation.Text) Or String.IsNullOrWhiteSpace(incidentDetails.Text) Or String.IsNullOrWhiteSpace(numberCall.Text) Then

            MessageBox.Show("Enter complete data first!")
        ElseIf numberCall.Text >= 4 Then
                MessageBox.Show("Only have 3 call")
            Else
                Try
                create("INSERT INTO incidentBlotter (`id`, `reportDate`, `incidentType`, `incidentDT`, `incidentLocation`, `incidentDetails`, `numberCall`) VALUES('" & id.Text _
                  & "','" & reportDate.Value.Date.ToString("yyyy/MM/dd") & "','" & incidentType.Text & "', '" & incidentDT.Value.Date.ToString("yyyy/MM/dd") & "', '" & incidentLocation.Text & "', '" & incidentDetails.Text & "', '" & numberCall.Text & "')")

                MessageBox.Show(reportDate.Value.Date.ToString("yyyy/MM/dd"))


                '  create("INSERT INTO complainantBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
                '& "','" & cFullname.Text & "','" & cCitizenship.Text & "', '" & cGender.Text & "', '" & cBday.Value.Date & "', '" & cContactNumber.Text & "', '" & cAddress.Text & "')")

                '  create("INSERT INTO victimBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
                '& "','" & vFullname.Text & "','" & vCitizenship.Text & "', '" & vGender.Text & "', '" & vBday.Value.Date & "', '" & vContactNumber.Text & "', '" & vAddress.Text & "')")

                '  create("INSERT INTO suspectBlotter (id, fullname, Citizenship, gender, bDay, contactNumber, address) VALUES('" & id.Text _
                '& "','" & sFullname.Text & "','" & sCitizenship.Text & "', '" & sGender.Text & "', '" & sBday.Value.Date & "', '" & sContactNumber.Text & "', '" & sAddress.Text & "')")


                MessageBox.Show("Completed! New Blotter Recorded")

                Catch ex As Exception
                    MessageBox.Show("Error, you must complete details" & ex.Message.ToString)
                Finally

                End Try
            End If

    End Sub

  
End Class