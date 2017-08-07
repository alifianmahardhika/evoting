<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.registerVoterButton = New System.Windows.Forms.Button()
        Me.verifyVoterButton = New System.Windows.Forms.Button()
        Me.registerCandidateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'registerVoterButton
        '
        Me.registerVoterButton.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.registerVoterButton.Location = New System.Drawing.Point(12, 12)
        Me.registerVoterButton.Name = "registerVoterButton"
        Me.registerVoterButton.Size = New System.Drawing.Size(260, 61)
        Me.registerVoterButton.TabIndex = 0
        Me.registerVoterButton.Text = "Register Voter"
        Me.registerVoterButton.UseVisualStyleBackColor = True
        '
        'verifyVoterButton
        '
        Me.verifyVoterButton.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.verifyVoterButton.Location = New System.Drawing.Point(12, 146)
        Me.verifyVoterButton.Name = "verifyVoterButton"
        Me.verifyVoterButton.Size = New System.Drawing.Size(260, 68)
        Me.verifyVoterButton.TabIndex = 1
        Me.verifyVoterButton.Text = "Verify and Vote!"
        Me.verifyVoterButton.UseVisualStyleBackColor = True
        '
        'registerCandidateButton
        '
        Me.registerCandidateButton.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.registerCandidateButton.Location = New System.Drawing.Point(12, 79)
        Me.registerCandidateButton.Name = "registerCandidateButton"
        Me.registerCandidateButton.Size = New System.Drawing.Size(260, 61)
        Me.registerCandidateButton.TabIndex = 2
        Me.registerCandidateButton.Text = "Register Candidate"
        Me.registerCandidateButton.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 233)
        Me.Controls.Add(Me.registerCandidateButton)
        Me.Controls.Add(Me.verifyVoterButton)
        Me.Controls.Add(Me.registerVoterButton)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents registerVoterButton As Button
    Friend WithEvents verifyVoterButton As Button
    Friend WithEvents registerCandidateButton As Button
End Class
