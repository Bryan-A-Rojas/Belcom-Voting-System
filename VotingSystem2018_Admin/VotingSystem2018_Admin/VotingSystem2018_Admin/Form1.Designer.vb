<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnVotingResults = New System.Windows.Forms.Button
        Me.btnBusinessStudentsList = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnVotingResults
        '
        Me.btnVotingResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVotingResults.Location = New System.Drawing.Point(62, 33)
        Me.btnVotingResults.Name = "btnVotingResults"
        Me.btnVotingResults.Size = New System.Drawing.Size(145, 82)
        Me.btnVotingResults.TabIndex = 0
        Me.btnVotingResults.Text = "Get Voting Results in Excel"
        Me.btnVotingResults.UseVisualStyleBackColor = True
        '
        'btnBusinessStudentsList
        '
        Me.btnBusinessStudentsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusinessStudentsList.Location = New System.Drawing.Point(62, 121)
        Me.btnBusinessStudentsList.Name = "btnBusinessStudentsList"
        Me.btnBusinessStudentsList.Size = New System.Drawing.Size(145, 82)
        Me.btnBusinessStudentsList.TabIndex = 1
        Me.btnBusinessStudentsList.Text = "Get list of Business Students"
        Me.btnBusinessStudentsList.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 261)
        Me.Controls.Add(Me.btnBusinessStudentsList)
        Me.Controls.Add(Me.btnVotingResults)
        Me.Name = "Form1"
        Me.Text = "Voting_System Admin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVotingResults As System.Windows.Forms.Button
    Friend WithEvents btnBusinessStudentsList As System.Windows.Forms.Button

End Class
