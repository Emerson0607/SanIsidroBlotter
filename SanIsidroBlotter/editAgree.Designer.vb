<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editAgree
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.id = New System.Windows.Forms.ComboBox()
        Me.tbDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbOffice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbVname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAgreement = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.Gainsboro
        Me.id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.id.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.FormattingEnabled = True
        Me.id.Location = New System.Drawing.Point(29, 85)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(235, 26)
        Me.id.TabIndex = 104
        '
        'tbDate
        '
        Me.tbDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.tbDate.CustomFormat = "yyyy/MM/dd"
        Me.tbDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tbDate.Location = New System.Drawing.Point(312, 83)
        Me.tbDate.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDate.MaxDate = New Date(2050, 12, 12, 0, 0, 0, 0)
        Me.tbDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(242, 24)
        Me.tbDate.TabIndex = 103
        Me.tbDate.Value = New Date(2022, 11, 24, 14, 55, 43, 0)
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.865546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(982, 713)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 33)
        Me.btnSave.TabIndex = 102
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Incident Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(865, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Office Name"
        '
        'tbOffice
        '
        Me.tbOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOffice.Location = New System.Drawing.Point(861, 82)
        Me.tbOffice.Name = "tbOffice"
        Me.tbOffice.Size = New System.Drawing.Size(236, 22)
        Me.tbOffice.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(603, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Agreement Location"
        '
        'tbLocation
        '
        Me.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbLocation.Location = New System.Drawing.Point(595, 82)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(236, 22)
        Me.tbLocation.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Agreement Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Blotter Entry Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(867, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Witness name"
        '
        'tbWname
        '
        Me.tbWname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbWname.Location = New System.Drawing.Point(861, 191)
        Me.tbWname.Name = "tbWname"
        Me.tbWname.Size = New System.Drawing.Size(236, 22)
        Me.tbWname.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Suspect Name"
        '
        'tbSname
        '
        Me.tbSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSname.Enabled = False
        Me.tbSname.Location = New System.Drawing.Point(595, 191)
        Me.tbSname.Name = "tbSname"
        Me.tbSname.Size = New System.Drawing.Size(236, 22)
        Me.tbSname.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Victim Name"
        '
        'tbVname
        '
        Me.tbVname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbVname.Enabled = False
        Me.tbVname.Location = New System.Drawing.Point(312, 191)
        Me.tbVname.Name = "tbVname"
        Me.tbVname.Size = New System.Drawing.Size(236, 22)
        Me.tbVname.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Complainant Name"
        '
        'tbCname
        '
        Me.tbCname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCname.Enabled = False
        Me.tbCname.Location = New System.Drawing.Point(28, 191)
        Me.tbCname.Name = "tbCname"
        Me.tbCname.Size = New System.Drawing.Size(236, 22)
        Me.tbCname.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Agreement "
        '
        'tbAgreement
        '
        Me.tbAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAgreement.Location = New System.Drawing.Point(28, 308)
        Me.tbAgreement.Multiline = True
        Me.tbAgreement.Name = "tbAgreement"
        Me.tbAgreement.Size = New System.Drawing.Size(1047, 358)
        Me.tbAgreement.TabIndex = 85
        '
        'editAgree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 753)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.btnSave)
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
        Me.Name = "editAgree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Aggreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id As ComboBox
    Friend WithEvents tbDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbOffice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbWname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbVname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAgreement As TextBox
End Class
