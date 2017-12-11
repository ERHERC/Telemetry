<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
    Inherits Telemetry.Reusable.StyledDialog

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.HeaderPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormDescription
        '
        Me.FormDescription.Size = New System.Drawing.Size(325, 18)
        Me.FormDescription.Text = "Veuillez configurer le logiciel avant son utilisation"
        '
        'FormTitle
        '
        Me.FormTitle.ForeColor = System.Drawing.Color.White
        Me.FormTitle.Size = New System.Drawing.Size(230, 24)
        Me.FormTitle.Text = "Assistant de mise en route"
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.QuitBtn)
        Me.BottomPanel.Controls.Add(Me.OkBtn)
        '
        'QuitBtn
        '
        Me.QuitBtn.AutoSize = True
        Me.QuitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.QuitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.QuitBtn.FlatAppearance.BorderSize = 0
        Me.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBtn.ForeColor = System.Drawing.Color.White
        Me.QuitBtn.Location = New System.Drawing.Point(12, 12)
        Me.QuitBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(66, 24)
        Me.QuitBtn.TabIndex = 5
        Me.QuitBtn.Text = "QUITTER"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.AutoSize = True
        Me.OkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBtn.ForeColor = System.Drawing.Color.White
        Me.OkBtn.Location = New System.Drawing.Point(978, 12)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(65, 24)
        Me.OkBtn.TabIndex = 4
        Me.OkBtn.Text = "VALIDER"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.QuitBtn
        Me.ClientSize = New System.Drawing.Size(1055, 554)
        Me.Name = "SetupForm"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuitBtn As Button
    Friend WithEvents OkBtn As Button
End Class
