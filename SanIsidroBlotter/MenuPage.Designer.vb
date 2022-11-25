Imports System.Windows

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPage
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
        Me.BTNblotter = New System.Windows.Forms.Button()
        Me.BTNagree = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNblotter
        '
        Me.BTNblotter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTNblotter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNblotter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNblotter.Location = New System.Drawing.Point(284, 139)
        Me.BTNblotter.Name = "BTNblotter"
        Me.BTNblotter.Size = New System.Drawing.Size(230, 60)
        Me.BTNblotter.TabIndex = 0
        Me.BTNblotter.Text = "Blotter Record"
        Me.BTNblotter.UseVisualStyleBackColor = False
        '
        'BTNagree
        '
        Me.BTNagree.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTNagree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNagree.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNagree.Location = New System.Drawing.Point(284, 238)
        Me.BTNagree.Name = "BTNagree"
        Me.BTNagree.Size = New System.Drawing.Size(230, 60)
        Me.BTNagree.TabIndex = 2
        Me.BTNagree.Text = "Agreement Record"
        Me.BTNagree.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SanIsidroBlotter.My.Resources.Resources.SanIsidroLogo
        Me.PictureBox1.Location = New System.Drawing.Point(28, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.btnLogout.Location = New System.Drawing.Point(677, 386)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 40)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MenuPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNagree)
        Me.Controls.Add(Me.BTNblotter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "MenuPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNblotter As Button
    Friend WithEvents BTNagree As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
End Class
