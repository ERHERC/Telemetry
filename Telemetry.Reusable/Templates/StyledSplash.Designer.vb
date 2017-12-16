<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StyledSplash
    Inherits System.Windows.Forms.Form
    'Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.LoadLabel = New System.Windows.Forms.Label()
        Me.AppNameLabel = New System.Windows.Forms.Label()
        Me.ScanBar = New System.Windows.Forms.ProgressBar()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.RightPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RightPanel
        '
        Me.RightPanel.Controls.Add(Me.LoadLabel)
        Me.RightPanel.Controls.Add(Me.AppNameLabel)
        Me.RightPanel.Controls.Add(Me.ScanBar)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightPanel.Location = New System.Drawing.Point(170, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Padding = New System.Windows.Forms.Padding(16)
        Me.RightPanel.Size = New System.Drawing.Size(342, 300)
        Me.RightPanel.TabIndex = 3
        '
        'LoadLabel
        '
        Me.LoadLabel.AutoSize = True
        Me.LoadLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadLabel.ForeColor = System.Drawing.Color.Gray
        Me.LoadLabel.Location = New System.Drawing.Point(167, 233)
        Me.LoadLabel.Name = "LoadLabel"
        Me.LoadLabel.Size = New System.Drawing.Size(159, 25)
        Me.LoadLabel.TabIndex = 2
        Me.LoadLabel.Text = "CHARGEMENT ..."
        '
        'AppNameLabel
        '
        Me.AppNameLabel.AutoSize = True
        Me.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNameLabel.ForeColor = System.Drawing.Color.Gray
        Me.AppNameLabel.Location = New System.Drawing.Point(16, 16)
        Me.AppNameLabel.Name = "AppNameLabel"
        Me.AppNameLabel.Size = New System.Drawing.Size(187, 37)
        Me.AppNameLabel.TabIndex = 1
        Me.AppNameLabel.Text = "APPLICATION"
        '
        'ScanBar
        '
        Me.ScanBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ScanBar.Location = New System.Drawing.Point(16, 261)
        Me.ScanBar.MarqueeAnimationSpeed = 1
        Me.ScanBar.Name = "ScanBar"
        Me.ScanBar.Size = New System.Drawing.Size(310, 23)
        Me.ScanBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ScanBar.TabIndex = 0
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.Gray
        Me.LeftPanel.Controls.Add(Me.VersionLabel)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Padding = New System.Windows.Forms.Padding(8, 16, 8, 16)
        Me.LeftPanel.Size = New System.Drawing.Size(170, 300)
        Me.LeftPanel.TabIndex = 2
        '
        'VersionLabel
        '
        Me.VersionLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VersionLabel.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(8, 261)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(154, 23)
        Me.VersionLabel.TabIndex = 2
        Me.VersionLabel.Text = "Version 1.2.3"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StyledSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StyledSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents RightPanel As Windows.Forms.Panel
    Public WithEvents AppNameLabel As Windows.Forms.Label
    Public WithEvents ScanBar As Windows.Forms.ProgressBar
    Public WithEvents LeftPanel As Windows.Forms.Panel
    Public WithEvents VersionLabel As Windows.Forms.Label
    Public WithEvents LoadLabel As Windows.Forms.Label
End Class
