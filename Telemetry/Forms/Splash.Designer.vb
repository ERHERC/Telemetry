<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.AppNameLabel = New System.Windows.Forms.Label()
        Me.ScanBar = New System.Windows.Forms.ProgressBar()
        Me.LeftPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.LeftPanel.Controls.Add(Me.VersionLabel)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Padding = New System.Windows.Forms.Padding(8, 16, 8, 16)
        Me.LeftPanel.Size = New System.Drawing.Size(170, 298)
        Me.LeftPanel.TabIndex = 0
        '
        'VersionLabel
        '
        Me.VersionLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VersionLabel.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(8, 259)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(154, 23)
        Me.VersionLabel.TabIndex = 2
        Me.VersionLabel.Text = "Version 1.2.3"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightPanel
        '
        Me.RightPanel.Controls.Add(Me.AppNameLabel)
        Me.RightPanel.Controls.Add(Me.ScanBar)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightPanel.Location = New System.Drawing.Point(170, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Padding = New System.Windows.Forms.Padding(16)
        Me.RightPanel.Size = New System.Drawing.Size(340, 298)
        Me.RightPanel.TabIndex = 1
        '
        'AppNameLabel
        '
        Me.AppNameLabel.AutoSize = True
        Me.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNameLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AppNameLabel.Location = New System.Drawing.Point(16, 16)
        Me.AppNameLabel.Name = "AppNameLabel"
        Me.AppNameLabel.Size = New System.Drawing.Size(225, 37)
        Me.AppNameLabel.TabIndex = 1
        Me.AppNameLabel.Text = "CHARGEMENT ..."
        '
        'ScanBar
        '
        Me.ScanBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ScanBar.Location = New System.Drawing.Point(16, 259)
        Me.ScanBar.MarqueeAnimationSpeed = 1
        Me.ScanBar.Name = "ScanBar"
        Me.ScanBar.Size = New System.Drawing.Size(308, 23)
        Me.ScanBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ScanBar.TabIndex = 0
        '
        'SplashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.LeftPanel.ResumeLayout(False)
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents RightPanel As Panel
    Friend WithEvents ScanBar As ProgressBar
    Friend WithEvents AppNameLabel As Label
    Friend WithEvents VersionLabel As Label
End Class
