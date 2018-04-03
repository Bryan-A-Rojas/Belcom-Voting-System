<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingWindowFor2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VotingWindowFor2))
        Me.lblDateAndTime = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnVote = New System.Windows.Forms.Button
        Me.radioCandidate1 = New System.Windows.Forms.RadioButton
        Me.radioAbstain = New System.Windows.Forms.RadioButton
        Me.lblName1 = New System.Windows.Forms.Label
        Me.lblParty1 = New System.Windows.Forms.Label
        Me.radioCandidate2 = New System.Windows.Forms.RadioButton
        Me.lblParty2 = New System.Windows.Forms.Label
        Me.lblName2 = New System.Windows.Forms.Label
        Me.pictureBoxCandidate2 = New System.Windows.Forms.PictureBox
        Me.pictureBoxCandidate1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblPosition = New System.Windows.Forms.Label
        CType(Me.pictureBoxCandidate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxCandidate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateAndTime.Location = New System.Drawing.Point(649, 3)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(191, 44)
        Me.lblDateAndTime.TabIndex = 64
        Me.lblDateAndTime.Text = "Date and Time"
        Me.lblDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(107, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 28)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Voting System 2018"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "San Beda College Alabang"
        '
        'DateTimer
        '
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.Color.Lime
        Me.btnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVote.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.Location = New System.Drawing.Point(745, 567)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(143, 71)
        Me.btnVote.TabIndex = 69
        Me.btnVote.Text = "&Vote"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'radioCandidate1
        '
        Me.radioCandidate1.AutoSize = True
        Me.radioCandidate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioCandidate1.Location = New System.Drawing.Point(123, 523)
        Me.radioCandidate1.Name = "radioCandidate1"
        Me.radioCandidate1.Size = New System.Drawing.Size(190, 29)
        Me.radioCandidate1.TabIndex = 66
        Me.radioCandidate1.Text = "Candidate Name"
        Me.radioCandidate1.UseVisualStyleBackColor = True
        '
        'radioAbstain
        '
        Me.radioAbstain.AutoSize = True
        Me.radioAbstain.Checked = True
        Me.radioAbstain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAbstain.Location = New System.Drawing.Point(350, 592)
        Me.radioAbstain.Name = "radioAbstain"
        Me.radioAbstain.Size = New System.Drawing.Size(102, 29)
        Me.radioAbstain.TabIndex = 67
        Me.radioAbstain.TabStop = True
        Me.radioAbstain.Text = "Abstain"
        Me.radioAbstain.UseVisualStyleBackColor = True
        '
        'lblName1
        '
        Me.lblName1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.Location = New System.Drawing.Point(118, 451)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(334, 33)
        Me.lblName1.TabIndex = 70
        Me.lblName1.Text = "Name"
        Me.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParty1
        '
        Me.lblParty1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParty1.Location = New System.Drawing.Point(118, 484)
        Me.lblParty1.Name = "lblParty1"
        Me.lblParty1.Size = New System.Drawing.Size(334, 33)
        Me.lblParty1.TabIndex = 71
        Me.lblParty1.Text = "Party"
        Me.lblParty1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radioCandidate2
        '
        Me.radioCandidate2.AutoSize = True
        Me.radioCandidate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioCandidate2.Location = New System.Drawing.Point(485, 523)
        Me.radioCandidate2.Name = "radioCandidate2"
        Me.radioCandidate2.Size = New System.Drawing.Size(190, 29)
        Me.radioCandidate2.TabIndex = 77
        Me.radioCandidate2.Text = "Candidate Name"
        Me.radioCandidate2.UseVisualStyleBackColor = True
        '
        'lblParty2
        '
        Me.lblParty2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParty2.Location = New System.Drawing.Point(480, 484)
        Me.lblParty2.Name = "lblParty2"
        Me.lblParty2.Size = New System.Drawing.Size(315, 33)
        Me.lblParty2.TabIndex = 79
        Me.lblParty2.Text = "Party"
        Me.lblParty2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName2
        '
        Me.lblName2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.Location = New System.Drawing.Point(480, 451)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(315, 33)
        Me.lblName2.TabIndex = 78
        Me.lblName2.Text = "Name"
        Me.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBoxCandidate2
        '
        Me.pictureBoxCandidate2.BackColor = System.Drawing.Color.White
        Me.pictureBoxCandidate2.Image = CType(resources.GetObject("pictureBoxCandidate2.Image"), System.Drawing.Image)
        Me.pictureBoxCandidate2.Location = New System.Drawing.Point(485, 114)
        Me.pictureBoxCandidate2.Name = "pictureBoxCandidate2"
        Me.pictureBoxCandidate2.Size = New System.Drawing.Size(262, 308)
        Me.pictureBoxCandidate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxCandidate2.TabIndex = 73
        Me.pictureBoxCandidate2.TabStop = False
        '
        'pictureBoxCandidate1
        '
        Me.pictureBoxCandidate1.BackColor = System.Drawing.Color.White
        Me.pictureBoxCandidate1.Image = CType(resources.GetObject("pictureBoxCandidate1.Image"), System.Drawing.Image)
        Me.pictureBoxCandidate1.Location = New System.Drawing.Point(123, 114)
        Me.pictureBoxCandidate1.Name = "pictureBoxCandidate1"
        Me.pictureBoxCandidate1.Size = New System.Drawing.Size(262, 308)
        Me.pictureBoxCandidate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxCandidate1.TabIndex = 65
        Me.pictureBoxCandidate1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(846, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(249, 64)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(442, 36)
        Me.lblPosition.TabIndex = 87
        Me.lblPosition.Text = "Position to vote for"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VotingWindowFor2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblParty2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.radioCandidate2)
        Me.Controls.Add(Me.pictureBoxCandidate2)
        Me.Controls.Add(Me.lblParty1)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.radioAbstain)
        Me.Controls.Add(Me.radioCandidate1)
        Me.Controls.Add(Me.pictureBoxCandidate1)
        Me.Controls.Add(Me.lblDateAndTime)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VotingWindowFor2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VotingWindow"
        CType(Me.pictureBoxCandidate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxCandidate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDateAndTime As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVote As System.Windows.Forms.Button
    Friend WithEvents pictureBoxCandidate1 As System.Windows.Forms.PictureBox
    Friend WithEvents radioCandidate1 As System.Windows.Forms.RadioButton
    Friend WithEvents radioAbstain As System.Windows.Forms.RadioButton
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblParty1 As System.Windows.Forms.Label
    Friend WithEvents pictureBoxCandidate2 As System.Windows.Forms.PictureBox
    Friend WithEvents radioCandidate2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblParty2 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
End Class
