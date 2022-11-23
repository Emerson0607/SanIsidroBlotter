<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.tbOldPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(376, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(350, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Old Password"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(344, 214)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(112, 18)
        Me.Password.TabIndex = 27
        Me.Password.Text = "New Password"
        '
        'tbOldPassword
        '
        Me.tbOldPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOldPassword.Location = New System.Drawing.Point(467, 161)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.Size = New System.Drawing.Size(163, 22)
        Me.tbOldPassword.TabIndex = 33
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Location = New System.Drawing.Point(467, 110)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.ReadOnly = True
        Me.tbUsername.Size = New System.Drawing.Size(163, 22)
        Me.tbUsername.TabIndex = 34
        Me.tbUsername.Text = "admin"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewPassword.Location = New System.Drawing.Point(467, 214)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(163, 22)
        Me.tbNewPassword.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(420, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Change Password"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegister.Location = New System.Drawing.Point(555, 265)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 37)
        Me.btnRegister.TabIndex = 38
        Me.btnRegister.Text = "Submit"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SanIsidroBlotter.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox1.Location = New System.Drawing.Point(34, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SanIsidroBlotter.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox2.Location = New System.Drawing.Point(40, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(277, 249)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 383)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNewPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.tbOldPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As Label
    Friend WithEvents tbOldPassword As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
