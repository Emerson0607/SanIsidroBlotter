<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBlotter
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
        Me.GBinci = New System.Windows.Forms.GroupBox()
        Me.incidentDT = New System.Windows.Forms.DateTimePicker()
        Me.reportDate = New System.Windows.Forms.DateTimePicker()
        Me.numberCall = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.incidentDetails = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.incidentLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.incidentType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cContactNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cBday = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cGender = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cCitizenship = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cFullname = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.vContactNumber = New System.Windows.Forms.TextBox()
        Me.vAddress = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.vBday = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.vGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.vCitizenship = New System.Windows.Forms.TextBox()
        Me.vFullname = New System.Windows.Forms.TextBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.sContactNumber = New System.Windows.Forms.TextBox()
        Me.sAddress = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.sBday = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.sGender = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.sCitizenship = New System.Windows.Forms.TextBox()
        Me.sFullname = New System.Windows.Forms.TextBox()
        Me.GBinci.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBinci
        '
        Me.GBinci.BackColor = System.Drawing.Color.White
        Me.GBinci.Controls.Add(Me.incidentDT)
        Me.GBinci.Controls.Add(Me.reportDate)
        Me.GBinci.Controls.Add(Me.numberCall)
        Me.GBinci.Controls.Add(Me.Label7)
        Me.GBinci.Controls.Add(Me.incidentDetails)
        Me.GBinci.Controls.Add(Me.Label6)
        Me.GBinci.Controls.Add(Me.incidentLocation)
        Me.GBinci.Controls.Add(Me.Label5)
        Me.GBinci.Controls.Add(Me.Label4)
        Me.GBinci.Controls.Add(Me.incidentType)
        Me.GBinci.Controls.Add(Me.Label3)
        Me.GBinci.Controls.Add(Me.Label2)
        Me.GBinci.Controls.Add(Me.Label1)
        Me.GBinci.Controls.Add(Me.id)
        Me.GBinci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBinci.Location = New System.Drawing.Point(12, 12)
        Me.GBinci.Name = "GBinci"
        Me.GBinci.Size = New System.Drawing.Size(1095, 177)
        Me.GBinci.TabIndex = 10
        Me.GBinci.TabStop = False
        Me.GBinci.Text = "Incident Details"
        '
        'incidentDT
        '
        Me.incidentDT.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incidentDT.CalendarMonthBackground = System.Drawing.Color.White
        Me.incidentDT.CustomFormat = "yyyy/MM/dd"
        Me.incidentDT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incidentDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.incidentDT.Location = New System.Drawing.Point(828, 75)
        Me.incidentDT.Margin = New System.Windows.Forms.Padding(4)
        Me.incidentDT.MaxDate = New Date(2022, 12, 25, 23, 59, 59, 0)
        Me.incidentDT.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.incidentDT.Name = "incidentDT"
        Me.incidentDT.Size = New System.Drawing.Size(242, 24)
        Me.incidentDT.TabIndex = 33
        Me.incidentDT.Value = New Date(2022, 11, 24, 14, 55, 43, 0)
        '
        'reportDate
        '
        Me.reportDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.reportDate.CustomFormat = "yyyy/MM/dd"
        Me.reportDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.reportDate.Location = New System.Drawing.Point(290, 75)
        Me.reportDate.Margin = New System.Windows.Forms.Padding(4)
        Me.reportDate.MaxDate = New Date(2050, 12, 12, 0, 0, 0, 0)
        Me.reportDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.reportDate.Name = "reportDate"
        Me.reportDate.Size = New System.Drawing.Size(242, 24)
        Me.reportDate.TabIndex = 32
        Me.reportDate.Value = New Date(2022, 11, 24, 14, 55, 43, 0)
        '
        'numberCall
        '
        Me.numberCall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberCall.Location = New System.Drawing.Point(561, 136)
        Me.numberCall.Name = "numberCall"
        Me.numberCall.Size = New System.Drawing.Size(236, 27)
        Me.numberCall.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(561, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Number of Call"
        '
        'incidentDetails
        '
        Me.incidentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.incidentDetails.Location = New System.Drawing.Point(287, 136)
        Me.incidentDetails.Name = "incidentDetails"
        Me.incidentDetails.Size = New System.Drawing.Size(244, 27)
        Me.incidentDetails.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Incident Details"
        '
        'incidentLocation
        '
        Me.incidentLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.incidentLocation.Location = New System.Drawing.Point(26, 136)
        Me.incidentLocation.Name = "incidentLocation"
        Me.incidentLocation.Size = New System.Drawing.Size(236, 27)
        Me.incidentLocation.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Incident Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(827, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Incident Date"
        '
        'incidentType
        '
        Me.incidentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.incidentType.Location = New System.Drawing.Point(561, 72)
        Me.incidentType.Name = "incidentType"
        Me.incidentType.Size = New System.Drawing.Size(236, 27)
        Me.incidentType.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(559, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Incident Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 22)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Report Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Blotter Entry Number"
        '
        'id
        '
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id.Location = New System.Drawing.Point(26, 72)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(236, 27)
        Me.id.TabIndex = 13
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.10084!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(1007, 755)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 50)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.cAddress)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.cContactNumber)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.cBday)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.cGender)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.cCitizenship)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.cFullname)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1095, 177)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Report Person / Complainant Details"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(285, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 22)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Address"
        '
        'cAddress
        '
        Me.cAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cAddress.Location = New System.Drawing.Point(286, 131)
        Me.cAddress.Name = "cAddress"
        Me.cAddress.Size = New System.Drawing.Size(776, 27)
        Me.cAddress.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 22)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Contact Number"
        '
        'cContactNumber
        '
        Me.cContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cContactNumber.Location = New System.Drawing.Point(26, 131)
        Me.cContactNumber.Name = "cContactNumber"
        Me.cContactNumber.Size = New System.Drawing.Size(236, 27)
        Me.cContactNumber.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(826, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 22)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Date of Birth"
        '
        'cBday
        '
        Me.cBday.CustomFormat = "yyyy/MM/dd"
        Me.cBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cBday.Location = New System.Drawing.Point(829, 64)
        Me.cBday.Name = "cBday"
        Me.cBday.Size = New System.Drawing.Size(246, 25)
        Me.cBday.TabIndex = 11
        Me.cBday.Value = New Date(2022, 11, 24, 14, 12, 27, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(562, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 22)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Gender"
        '
        'cGender
        '
        Me.cGender.FormattingEnabled = True
        Me.cGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cGender.Location = New System.Drawing.Point(564, 63)
        Me.cGender.Name = "cGender"
        Me.cGender.Size = New System.Drawing.Size(235, 28)
        Me.cGender.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(284, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Citizenship"
        '
        'cCitizenship
        '
        Me.cCitizenship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cCitizenship.Location = New System.Drawing.Point(287, 64)
        Me.cCitizenship.Name = "cCitizenship"
        Me.cCitizenship.Size = New System.Drawing.Size(245, 27)
        Me.cCitizenship.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 22)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Fullname"
        '
        'cFullname
        '
        Me.cFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cFullname.Location = New System.Drawing.Point(26, 64)
        Me.cFullname.Name = "cFullname"
        Me.cFullname.Size = New System.Drawing.Size(236, 27)
        Me.cFullname.TabIndex = 13
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.vContactNumber)
        Me.GroupBox9.Controls.Add(Me.vAddress)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.vBday)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.vGender)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.vCitizenship)
        Me.GroupBox9.Controls.Add(Me.vFullname)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1095, 177)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Victim Details"
        '
        'vContactNumber
        '
        Me.vContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vContactNumber.Location = New System.Drawing.Point(23, 131)
        Me.vContactNumber.Name = "vContactNumber"
        Me.vContactNumber.Size = New System.Drawing.Size(236, 27)
        Me.vContactNumber.TabIndex = 13
        '
        'vAddress
        '
        Me.vAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vAddress.Location = New System.Drawing.Point(286, 131)
        Me.vAddress.Name = "vAddress"
        Me.vAddress.Size = New System.Drawing.Size(776, 27)
        Me.vAddress.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(284, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 22)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Address"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(154, 22)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Contact Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(825, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 22)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Date of Birth"
        '
        'vBday
        '
        Me.vBday.CustomFormat = "yyyy/MM/dd"
        Me.vBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.vBday.Location = New System.Drawing.Point(828, 59)
        Me.vBday.Name = "vBday"
        Me.vBday.Size = New System.Drawing.Size(246, 25)
        Me.vBday.TabIndex = 11
        Me.vBday.Value = New Date(2022, 11, 24, 14, 12, 27, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(557, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 22)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Gender"
        '
        'vGender
        '
        Me.vGender.FormattingEnabled = True
        Me.vGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.vGender.Location = New System.Drawing.Point(561, 57)
        Me.vGender.Name = "vGender"
        Me.vGender.Size = New System.Drawing.Size(238, 28)
        Me.vGender.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(285, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 22)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Citizenship"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 22)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Fullname"
        '
        'vCitizenship
        '
        Me.vCitizenship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vCitizenship.Location = New System.Drawing.Point(286, 57)
        Me.vCitizenship.Name = "vCitizenship"
        Me.vCitizenship.Size = New System.Drawing.Size(246, 27)
        Me.vCitizenship.TabIndex = 13
        '
        'vFullname
        '
        Me.vFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vFullname.Location = New System.Drawing.Point(23, 57)
        Me.vFullname.Name = "vFullname"
        Me.vFullname.Size = New System.Drawing.Size(236, 27)
        Me.vFullname.TabIndex = 13
        '
        'GroupBox22
        '
        Me.GroupBox22.BackColor = System.Drawing.Color.White
        Me.GroupBox22.Controls.Add(Me.Label24)
        Me.GroupBox22.Controls.Add(Me.Label25)
        Me.GroupBox22.Controls.Add(Me.sContactNumber)
        Me.GroupBox22.Controls.Add(Me.sAddress)
        Me.GroupBox22.Controls.Add(Me.Label20)
        Me.GroupBox22.Controls.Add(Me.sBday)
        Me.GroupBox22.Controls.Add(Me.Label21)
        Me.GroupBox22.Controls.Add(Me.sGender)
        Me.GroupBox22.Controls.Add(Me.Label22)
        Me.GroupBox22.Controls.Add(Me.Label23)
        Me.GroupBox22.Controls.Add(Me.sCitizenship)
        Me.GroupBox22.Controls.Add(Me.sFullname)
        Me.GroupBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(12, 561)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(1095, 177)
        Me.GroupBox22.TabIndex = 14
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Suspect Details"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(283, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 22)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 108)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(154, 22)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Contact Number"
        '
        'sContactNumber
        '
        Me.sContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sContactNumber.Location = New System.Drawing.Point(23, 133)
        Me.sContactNumber.Name = "sContactNumber"
        Me.sContactNumber.Size = New System.Drawing.Size(236, 27)
        Me.sContactNumber.TabIndex = 13
        '
        'sAddress
        '
        Me.sAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sAddress.Location = New System.Drawing.Point(286, 133)
        Me.sAddress.Name = "sAddress"
        Me.sAddress.Size = New System.Drawing.Size(776, 27)
        Me.sAddress.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(824, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 22)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Date of Birth"
        '
        'sBday
        '
        Me.sBday.CustomFormat = "yyyy/MM/dd"
        Me.sBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sBday.Location = New System.Drawing.Point(828, 67)
        Me.sBday.Name = "sBday"
        Me.sBday.Size = New System.Drawing.Size(246, 25)
        Me.sBday.TabIndex = 11
        Me.sBday.Value = New Date(2022, 11, 24, 14, 12, 27, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(556, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 22)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Gender"
        '
        'sGender
        '
        Me.sGender.FormattingEnabled = True
        Me.sGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.sGender.Location = New System.Drawing.Point(561, 66)
        Me.sGender.Name = "sGender"
        Me.sGender.Size = New System.Drawing.Size(238, 28)
        Me.sGender.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(284, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 22)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Citizenship"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(21, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 22)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Fullname"
        '
        'sCitizenship
        '
        Me.sCitizenship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sCitizenship.Location = New System.Drawing.Point(286, 67)
        Me.sCitizenship.Name = "sCitizenship"
        Me.sCitizenship.Size = New System.Drawing.Size(246, 27)
        Me.sCitizenship.TabIndex = 13
        '
        'sFullname
        '
        Me.sFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sFullname.Location = New System.Drawing.Point(23, 67)
        Me.sFullname.Name = "sFullname"
        Me.sFullname.Size = New System.Drawing.Size(236, 27)
        Me.sFullname.TabIndex = 13
        '
        'CreateBlotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 823)
        Me.Controls.Add(Me.GroupBox22)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GBinci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateBlotter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Create New Report"
        Me.GBinci.ResumeLayout(False)
        Me.GBinci.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBinci As GroupBox
    Friend WithEvents btnSubmit As Button


    Friend WithEvents numberCall As TextBox
    Friend WithEvents incidentDetails As TextBox
    Friend WithEvents incidentLocation As TextBox
    Friend WithEvents incidentType As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cCitizenship As TextBox
    Friend WithEvents cBday As DateTimePicker
    Friend WithEvents cAddress As TextBox
    Friend WithEvents cContactNumber As TextBox
    Friend WithEvents cGender As ComboBox
    Friend WithEvents cFullname As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents vCitizenship As TextBox
    Friend WithEvents vBday As DateTimePicker
    Friend WithEvents vAddress As TextBox
    Friend WithEvents vContactNumber As TextBox
    Friend WithEvents vFullname As TextBox
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents sCitizenship As TextBox
    Friend WithEvents sAddress As TextBox
    Friend WithEvents sGender As ComboBox
    Friend WithEvents sFullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents vGender As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents sBday As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents sContactNumber As TextBox
    Friend WithEvents incidentDT As DateTimePicker
    Friend WithEvents reportDate As DateTimePicker
End Class
