<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewAgree
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.id = New System.Windows.Forms.ComboBox()
        Me.tbDate = New System.Windows.Forms.DateTimePicker()
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
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.FormattingEnabled = True
        Me.id.Location = New System.Drawing.Point(42, 107)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(236, 26)
        Me.id.TabIndex = 124
        '
        'tbDate
        '
        Me.tbDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.tbDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbDate.CustomFormat = "yyyy/MM/dd"
        Me.tbDate.Enabled = False
        Me.tbDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tbDate.Location = New System.Drawing.Point(312, 108)
        Me.tbDate.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDate.MaxDate = New Date(2050, 12, 12, 0, 0, 0, 0)
        Me.tbDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(236, 24)
        Me.tbDate.TabIndex = 123
        Me.tbDate.Value = New Date(2022, 11, 24, 14, 55, 43, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 28)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Incident Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(856, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Office Name"
        '
        'tbOffice
        '
        Me.tbOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOffice.Enabled = False
        Me.tbOffice.Location = New System.Drawing.Point(852, 104)
        Me.tbOffice.Multiline = True
        Me.tbOffice.Name = "tbOffice"
        Me.tbOffice.Size = New System.Drawing.Size(236, 27)
        Me.tbOffice.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(595, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 17)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Agreement Location"
        '
        'tbLocation
        '
        Me.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbLocation.Enabled = False
        Me.tbLocation.Location = New System.Drawing.Point(587, 104)
        Me.tbLocation.Multiline = True
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(236, 27)
        Me.tbLocation.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(319, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 17)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Agreement Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(46, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 17)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Blotter Entry Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(858, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Witness name"
        '
        'tbWname
        '
        Me.tbWname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbWname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbWname.Enabled = False
        Me.tbWname.Location = New System.Drawing.Point(852, 213)
        Me.tbWname.Multiline = True
        Me.tbWname.Name = "tbWname"
        Me.tbWname.Size = New System.Drawing.Size(236, 27)
        Me.tbWname.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(595, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Suspect Name"
        '
        'tbSname
        '
        Me.tbSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSname.Enabled = False
        Me.tbSname.Location = New System.Drawing.Point(587, 213)
        Me.tbSname.Multiline = True
        Me.tbSname.Name = "tbSname"
        Me.tbSname.Size = New System.Drawing.Size(236, 27)
        Me.tbSname.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(319, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Victim Name"
        '
        'tbVname
        '
        Me.tbVname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbVname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbVname.Enabled = False
        Me.tbVname.Location = New System.Drawing.Point(312, 213)
        Me.tbVname.Multiline = True
        Me.tbVname.Name = "tbVname"
        Me.tbVname.Size = New System.Drawing.Size(236, 27)
        Me.tbVname.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(46, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Complainant Name"
        '
        'tbCname
        '
        Me.tbCname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCname.Enabled = False
        Me.tbCname.Location = New System.Drawing.Point(41, 213)
        Me.tbCname.Multiline = True
        Me.tbCname.Name = "tbCname"
        Me.tbCname.Size = New System.Drawing.Size(236, 27)
        Me.tbCname.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Agreement "
        '
        'tbAgreement
        '
        Me.tbAgreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAgreement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbAgreement.Enabled = False
        Me.tbAgreement.Location = New System.Drawing.Point(41, 330)
        Me.tbAgreement.Multiline = True
        Me.tbAgreement.Name = "tbAgreement"
        Me.tbAgreement.Size = New System.Drawing.Size(1047, 392)
        Me.tbAgreement.TabIndex = 105
        '
        'viewAgree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 753)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.tbDate)
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
        Me.Name = "viewAgree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id As ComboBox
    Friend WithEvents tbDate As DateTimePicker
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
