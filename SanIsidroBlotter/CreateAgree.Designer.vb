<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAgree
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbCname = New System.Windows.Forms.TextBox()
        Me.tbAgreement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbVname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOffice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tbDate = New System.Windows.Forms.DateTimePicker()
        Me.id = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'tbCname
        '
        Me.tbCname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCname.Location = New System.Drawing.Point(41, 213)
        Me.tbCname.Name = "tbCname"
        Me.tbCname.Size = New System.Drawing.Size(236, 22)
        Me.tbCname.TabIndex = 13
        '
        'tbAgreement
        '
        Me.tbAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAgreement.Location = New System.Drawing.Point(41, 330)
        Me.tbAgreement.Multiline = True
        Me.tbAgreement.Name = "tbAgreement"
        Me.tbAgreement.Size = New System.Drawing.Size(1047, 358)
        Me.tbAgreement.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Agreement "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Complainant Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Victim Name"
        '
        'tbVname
        '
        Me.tbVname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbVname.Location = New System.Drawing.Point(325, 213)
        Me.tbVname.Name = "tbVname"
        Me.tbVname.Size = New System.Drawing.Size(236, 22)
        Me.tbVname.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(616, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Suspect Name"
        '
        'tbSname
        '
        Me.tbSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSname.Location = New System.Drawing.Point(608, 213)
        Me.tbSname.Name = "tbSname"
        Me.tbSname.Size = New System.Drawing.Size(236, 22)
        Me.tbSname.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(880, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Witness name"
        '
        'tbWname
        '
        Me.tbWname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbWname.Location = New System.Drawing.Point(874, 213)
        Me.tbWname.Name = "tbWname"
        Me.tbWname.Size = New System.Drawing.Size(236, 22)
        Me.tbWname.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(878, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Office Name"
        '
        'tbOffice
        '
        Me.tbOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOffice.Location = New System.Drawing.Point(874, 104)
        Me.tbOffice.Name = "tbOffice"
        Me.tbOffice.Size = New System.Drawing.Size(236, 22)
        Me.tbOffice.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(616, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Agreement Location"
        '
        'tbLocation
        '
        Me.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbLocation.Location = New System.Drawing.Point(608, 104)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(236, 22)
        Me.tbLocation.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(332, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Agreement Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Blotter Entry Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Incident Details"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(995, 735)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(93, 33)
        Me.btnSubmit.TabIndex = 82
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tbDate
        '
        Me.tbDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.tbDate.CustomFormat = "yyyy/MM/dd"
        Me.tbDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tbDate.Location = New System.Drawing.Point(325, 105)
        Me.tbDate.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDate.MaxDate = New Date(2050, 12, 12, 0, 0, 0, 0)
        Me.tbDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(242, 24)
        Me.tbDate.TabIndex = 83
        Me.tbDate.Value = New Date(2022, 11, 24, 14, 55, 43, 0)
        '
        'id
        '
        Me.id.FormattingEnabled = True
        Me.id.Location = New System.Drawing.Point(41, 109)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(233, 24)
        Me.id.TabIndex = 84
        '
        'CreateAgree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 823)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbOffice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbLocation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbVname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAgreement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateAgree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Create New Agreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub BTsubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Report Submitted!", "Success")



    End Sub
    Friend WithEvents tbCname As TextBox
    Friend WithEvents tbAgreement As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbVname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbWname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbOffice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tbDate As DateTimePicker
    Friend WithEvents id As ComboBox
End Class
