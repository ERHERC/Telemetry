<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashForm
    Inherits Telemetry.Reusable.StyledSplash

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
        Me.RightPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppNameLabel
        '
        Me.AppNameLabel.ForeColor = System.Drawing.Color.Crimson
        Me.AppNameLabel.Size = New System.Drawing.Size(143, 37)
        Me.AppNameLabel.Text = "SANDBOX"
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.Crimson
        '
        'LoadLabel
        '
        Me.LoadLabel.ForeColor = System.Drawing.Color.Crimson
        '
        'SplashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(512, 300)
        Me.Name = "SplashForm"
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
