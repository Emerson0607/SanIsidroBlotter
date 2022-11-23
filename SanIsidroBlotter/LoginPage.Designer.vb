<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.LBLuser = New System.Windows.Forms.Label()
        Me.LBLpass = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SanIsidroBlotter.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox1.Location = New System.Drawing.Point(54, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Location = New System.Drawing.Point(390, 104)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(163, 22)
        Me.tbUsername.TabIndex = 1
        '
        'LBLuser
        '
        Me.LBLuser.AutoSize = True
        Me.LBLuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLuser.Location = New System.Drawing.Point(387, 81)
        Me.LBLuser.Name = "LBLuser"
        Me.LBLuser.Size = New System.Drawing.Size(77, 18)
        Me.LBLuser.TabIndex = 2
        Me.LBLuser.Text = "Username"
        '
        'LBLpass
        '
        Me.LBLpass.AutoSize = True
        Me.LBLpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpass.Location = New System.Drawing.Point(387, 148)
        Me.LBLpass.Name = "LBLpass"
        Me.LBLpass.Size = New System.Drawing.Size(75, 18)
        Me.LBLpass.TabIndex = 3
        Me.LBLpass.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassword.Location = New System.Drawing.Point(391, 171)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(163, 22)
        Me.tbPassword.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(390, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(478, 211)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 37)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(390, 263)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(164, 35)
        Me.btnChangePassword.TabIndex = 10
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(662, 379)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.LBLpass)
        Me.Controls.Add(Me.LBLuser)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents LBLuser As Label
    Friend WithEvents LBLpass As Label
    Friend WithEvents tbPassword As TextBox





    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnChangePassword As Button
End Class
