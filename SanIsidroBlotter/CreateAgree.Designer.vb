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
        Me.GBinci = New System.Windows.Forms.GroupBox()
        Me.GBwitness = New System.Windows.Forms.GroupBox()
        Me.TBwitness = New System.Windows.Forms.TextBox()
        Me.GBsuspect = New System.Windows.Forms.GroupBox()
        Me.TBsuspect = New System.Windows.Forms.TextBox()
        Me.GBvictim = New System.Windows.Forms.GroupBox()
        Me.TBvictim = New System.Windows.Forms.TextBox()
        Me.GBcomp = New System.Windows.Forms.GroupBox()
        Me.TBcomp = New System.Windows.Forms.TextBox()
        Me.GBloc = New System.Windows.Forms.GroupBox()
        Me.TBloc = New System.Windows.Forms.TextBox()
        Me.GBoffice = New System.Windows.Forms.GroupBox()
        Me.TBoffice = New System.Windows.Forms.TextBox()
        Me.GBdate = New System.Windows.Forms.GroupBox()
        Me.DTagreement = New System.Windows.Forms.DateTimePicker()
        Me.GBid = New System.Windows.Forms.GroupBox()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GBvicdetail = New System.Windows.Forms.GroupBox()
        Me.GBagree = New System.Windows.Forms.GroupBox()
        Me.TBagree = New System.Windows.Forms.TextBox()
        Me.GBinci.SuspendLayout()
        Me.GBwitness.SuspendLayout()
        Me.GBsuspect.SuspendLayout()
        Me.GBvictim.SuspendLayout()
        Me.GBcomp.SuspendLayout()
        Me.GBloc.SuspendLayout()
        Me.GBoffice.SuspendLayout()
        Me.GBdate.SuspendLayout()
        Me.GBid.SuspendLayout()
        Me.GBvicdetail.SuspendLayout()
        Me.GBagree.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBinci
        '
        Me.GBinci.BackColor = System.Drawing.Color.White
        Me.GBinci.Controls.Add(Me.GBwitness)
        Me.GBinci.Controls.Add(Me.GBsuspect)
        Me.GBinci.Controls.Add(Me.GBvictim)
        Me.GBinci.Controls.Add(Me.GBcomp)
        Me.GBinci.Controls.Add(Me.GBloc)
        Me.GBinci.Controls.Add(Me.GBoffice)
        Me.GBinci.Controls.Add(Me.GBdate)
        Me.GBinci.Controls.Add(Me.GBid)
        Me.GBinci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBinci.Location = New System.Drawing.Point(12, 12)
        Me.GBinci.Name = "GBinci"
        Me.GBinci.Size = New System.Drawing.Size(1095, 221)
        Me.GBinci.TabIndex = 10
        Me.GBinci.TabStop = False
        Me.GBinci.Text = "Incident Details"
        '
        'GBwitness
        '
        Me.GBwitness.Controls.Add(Me.TBwitness)
        Me.GBwitness.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBwitness.Location = New System.Drawing.Point(828, 131)
        Me.GBwitness.Name = "GBwitness"
        Me.GBwitness.Size = New System.Drawing.Size(248, 74)
        Me.GBwitness.TabIndex = 24
        Me.GBwitness.TabStop = False
        Me.GBwitness.Text = "Witness Name"
        '
        'TBwitness
        '
        Me.TBwitness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBwitness.Location = New System.Drawing.Point(6, 34)
        Me.TBwitness.Name = "TBwitness"
        Me.TBwitness.Size = New System.Drawing.Size(236, 25)
        Me.TBwitness.TabIndex = 13
        '
        'GBsuspect
        '
        Me.GBsuspect.Controls.Add(Me.TBsuspect)
        Me.GBsuspect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBsuspect.Location = New System.Drawing.Point(557, 131)
        Me.GBsuspect.Name = "GBsuspect"
        Me.GBsuspect.Size = New System.Drawing.Size(248, 74)
        Me.GBsuspect.TabIndex = 23
        Me.GBsuspect.TabStop = False
        Me.GBsuspect.Text = "Suspect Name"
        '
        'TBsuspect
        '
        Me.TBsuspect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBsuspect.Location = New System.Drawing.Point(6, 34)
        Me.TBsuspect.Name = "TBsuspect"
        Me.TBsuspect.Size = New System.Drawing.Size(236, 25)
        Me.TBsuspect.TabIndex = 13
        '
        'GBvictim
        '
        Me.GBvictim.Controls.Add(Me.TBvictim)
        Me.GBvictim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBvictim.Location = New System.Drawing.Point(286, 131)
        Me.GBvictim.Name = "GBvictim"
        Me.GBvictim.Size = New System.Drawing.Size(248, 74)
        Me.GBvictim.TabIndex = 22
        Me.GBvictim.TabStop = False
        Me.GBvictim.Text = "Victim Name"
        '
        'TBvictim
        '
        Me.TBvictim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBvictim.Location = New System.Drawing.Point(6, 34)
        Me.TBvictim.Name = "TBvictim"
        Me.TBvictim.Size = New System.Drawing.Size(236, 25)
        Me.TBvictim.TabIndex = 13
        '
        'GBcomp
        '
        Me.GBcomp.Controls.Add(Me.TBcomp)
        Me.GBcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBcomp.Location = New System.Drawing.Point(17, 131)
        Me.GBcomp.Name = "GBcomp"
        Me.GBcomp.Size = New System.Drawing.Size(248, 74)
        Me.GBcomp.TabIndex = 21
        Me.GBcomp.TabStop = False
        Me.GBcomp.Text = "Complainant Name"
        '
        'TBcomp
        '
        Me.TBcomp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBcomp.Location = New System.Drawing.Point(6, 34)
        Me.TBcomp.Name = "TBcomp"
        Me.TBcomp.Size = New System.Drawing.Size(236, 25)
        Me.TBcomp.TabIndex = 13
        '
        'GBloc
        '
        Me.GBloc.Controls.Add(Me.TBloc)
        Me.GBloc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBloc.Location = New System.Drawing.Point(557, 42)
        Me.GBloc.Name = "GBloc"
        Me.GBloc.Size = New System.Drawing.Size(248, 74)
        Me.GBloc.TabIndex = 20
        Me.GBloc.TabStop = False
        Me.GBloc.Text = "Agreement Location"
        '
        'TBloc
        '
        Me.TBloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBloc.Location = New System.Drawing.Point(6, 34)
        Me.TBloc.Name = "TBloc"
        Me.TBloc.Size = New System.Drawing.Size(236, 25)
        Me.TBloc.TabIndex = 13
        '
        'GBoffice
        '
        Me.GBoffice.Controls.Add(Me.TBoffice)
        Me.GBoffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoffice.Location = New System.Drawing.Point(828, 42)
        Me.GBoffice.Name = "GBoffice"
        Me.GBoffice.Size = New System.Drawing.Size(248, 74)
        Me.GBoffice.TabIndex = 18
        Me.GBoffice.TabStop = False
        Me.GBoffice.Text = "Office Name"
        '
        'TBoffice
        '
        Me.TBoffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBoffice.Location = New System.Drawing.Point(6, 34)
        Me.TBoffice.Name = "TBoffice"
        Me.TBoffice.Size = New System.Drawing.Size(236, 25)
        Me.TBoffice.TabIndex = 13
        '
        'GBdate
        '
        Me.GBdate.BackColor = System.Drawing.Color.White
        Me.GBdate.Controls.Add(Me.DTagreement)
        Me.GBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBdate.Location = New System.Drawing.Point(286, 42)
        Me.GBdate.Name = "GBdate"
        Me.GBdate.Size = New System.Drawing.Size(248, 74)
        Me.GBdate.TabIndex = 17
        Me.GBdate.TabStop = False
        Me.GBdate.Text = "Agreement Date and Time"
        '
        'DTagreement
        '
        Me.DTagreement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTagreement.Location = New System.Drawing.Point(0, 34)
        Me.DTagreement.Name = "DTagreement"
        Me.DTagreement.Size = New System.Drawing.Size(246, 25)
        Me.DTagreement.TabIndex = 11
        Me.DTagreement.Value = New Date(2022, 11, 19, 0, 0, 0, 0)
        '
        'GBid
        '
        Me.GBid.Controls.Add(Me.TBid)
        Me.GBid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBid.Location = New System.Drawing.Point(17, 42)
        Me.GBid.Name = "GBid"
        Me.GBid.Size = New System.Drawing.Size(248, 74)
        Me.GBid.TabIndex = 15
        Me.GBid.TabStop = False
        Me.GBid.Text = "Blotter Entry Number"
        '
        'TBid
        '
        Me.TBid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBid.Location = New System.Drawing.Point(6, 34)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(236, 25)
        Me.TBid.TabIndex = 13
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.10084!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(1010, 693)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 50)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GBvicdetail
        '
        Me.GBvicdetail.BackColor = System.Drawing.Color.White
        Me.GBvicdetail.Controls.Add(Me.GBagree)
        Me.GBvicdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.28571!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBvicdetail.Location = New System.Drawing.Point(12, 252)
        Me.GBvicdetail.Name = "GBvicdetail"
        Me.GBvicdetail.Size = New System.Drawing.Size(1095, 435)
        Me.GBvicdetail.TabIndex = 13
        Me.GBvicdetail.TabStop = False
        Me.GBvicdetail.Text = "Victim Details"
        '
        'GBagree
        '
        Me.GBagree.Controls.Add(Me.TBagree)
        Me.GBagree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.07563!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBagree.Location = New System.Drawing.Point(17, 42)
        Me.GBagree.Name = "GBagree"
        Me.GBagree.Size = New System.Drawing.Size(1059, 387)
        Me.GBagree.TabIndex = 15
        Me.GBagree.TabStop = False
        Me.GBagree.Text = "Ageement Details"
        '
        'TBagree
        '
        Me.TBagree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBagree.Location = New System.Drawing.Point(6, 23)
        Me.TBagree.Multiline = True
        Me.TBagree.Name = "TBagree"
        Me.TBagree.Size = New System.Drawing.Size(1047, 358)
        Me.TBagree.TabIndex = 13
        '
        'CreateAgree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 753)
        Me.Controls.Add(Me.GBvicdetail)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GBinci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateAgree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay San Isidro Blotter System - Create New Agreement"
        Me.GBinci.ResumeLayout(False)
        Me.GBwitness.ResumeLayout(False)
        Me.GBwitness.PerformLayout()
        Me.GBsuspect.ResumeLayout(False)
        Me.GBsuspect.PerformLayout()
        Me.GBvictim.ResumeLayout(False)
        Me.GBvictim.PerformLayout()
        Me.GBcomp.ResumeLayout(False)
        Me.GBcomp.PerformLayout()
        Me.GBloc.ResumeLayout(False)
        Me.GBloc.PerformLayout()
        Me.GBoffice.ResumeLayout(False)
        Me.GBoffice.PerformLayout()
        Me.GBdate.ResumeLayout(False)
        Me.GBid.ResumeLayout(False)
        Me.GBid.PerformLayout()
        Me.GBvicdetail.ResumeLayout(False)
        Me.GBagree.ResumeLayout(False)
        Me.GBagree.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBinci As GroupBox
    Friend WithEvents DTagreement As DateTimePicker
    Friend WithEvents btnSubmit As Button

    Private Sub BTsubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Report Submitted!", "Success")



    End Sub

    Friend WithEvents GBvictim As GroupBox
    Friend WithEvents TBvictim As TextBox
    Friend WithEvents GBcomp As GroupBox
    Friend WithEvents TBcomp As TextBox
    Friend WithEvents GBloc As GroupBox
    Friend WithEvents TBloc As TextBox
    Friend WithEvents GBoffice As GroupBox
    Friend WithEvents TBoffice As TextBox
    Friend WithEvents GBdate As GroupBox
    Friend WithEvents GBid As GroupBox
    Friend WithEvents TBid As TextBox
    Friend WithEvents GBvicdetail As GroupBox
    Friend WithEvents GBagree As GroupBox
    Friend WithEvents TBagree As TextBox
    Friend WithEvents GBwitness As GroupBox
    Friend WithEvents TBwitness As TextBox
    Friend WithEvents GBsuspect As GroupBox
    Friend WithEvents TBsuspect As TextBox
End Class
