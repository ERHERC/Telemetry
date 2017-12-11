Imports Telemetry.Reusable

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.AnimationWorker = New System.ComponentModel.BackgroundWorker()
        Me.LostSignalFlicker = New System.Windows.Forms.Timer(Me.components)
        Me.AppHaltedLbl = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.PingPanel = New TransparentControl()
        Me.PingLbl = New System.Windows.Forms.Label()
        Me.SignalIconPanel = New System.Windows.Forms.Panel()
        Me.SignalIcon = New System.Windows.Forms.PictureBox()
        Me.LostSignalPanel = New TransparentControl()
        Me.LostSignalLabel = New System.Windows.Forms.Label()
        Me.SlowDownAlertBox = New TransparentControl()
        Me.AlertLabel = New System.Windows.Forms.Label()
        Me.AlertIconPanel = New TransparentControl()
        Me.AlertIcon = New System.Windows.Forms.Panel()
        Me.AlertBox = New System.Windows.Forms.PictureBox()
        Me.TimerPanel = New System.Windows.Forms.Panel()
        Me.TimerLbl = New System.Windows.Forms.Label()
        Me.StopwatchIconPanel = New System.Windows.Forms.Panel()
        Me.StopwatchIcon = New System.Windows.Forms.PictureBox()
        Me.BatteryPanel = New System.Windows.Forms.Panel()
        Me.BatteryBarPanel = New System.Windows.Forms.Panel()
        Me.BatteryBarBackground = New System.Windows.Forms.Panel()
        Me.BatteryProgress = New System.Windows.Forms.Panel()
        Me.BatteryIconPanel = New System.Windows.Forms.Panel()
        Me.BatteryIcon = New System.Windows.Forms.PictureBox()
        Me.SpeedIndicatorPanel = New System.Windows.Forms.Panel()
        Me.SpeedLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MainPanel.SuspendLayout()
        Me.PingPanel.SuspendLayout()
        Me.SignalIconPanel.SuspendLayout()
        CType(Me.SignalIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LostSignalPanel.SuspendLayout()
        Me.SlowDownAlertBox.SuspendLayout()
        Me.AlertIconPanel.SuspendLayout()
        Me.AlertIcon.SuspendLayout()
        CType(Me.AlertBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimerPanel.SuspendLayout()
        Me.StopwatchIconPanel.SuspendLayout()
        CType(Me.StopwatchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BatteryPanel.SuspendLayout()
        Me.BatteryBarPanel.SuspendLayout()
        Me.BatteryBarBackground.SuspendLayout()
        Me.BatteryIconPanel.SuspendLayout()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpeedIndicatorPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimationWorker
        '
        Me.AnimationWorker.WorkerSupportsCancellation = True
        '
        'LostSignalFlicker
        '
        Me.LostSignalFlicker.Enabled = True
        Me.LostSignalFlicker.Interval = 250
        '
        'AppHaltedLbl
        '
        Me.AppHaltedLbl.BackColor = System.Drawing.Color.White
        Me.AppHaltedLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppHaltedLbl.Font = New System.Drawing.Font("Segoe UI Mono", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppHaltedLbl.ForeColor = System.Drawing.Color.Blue
        Me.AppHaltedLbl.Location = New System.Drawing.Point(0, 0)
        Me.AppHaltedLbl.Name = "AppHaltedLbl"
        Me.AppHaltedLbl.Size = New System.Drawing.Size(1117, 527)
        Me.AppHaltedLbl.TabIndex = 3
        Me.AppHaltedLbl.Text = "Initializing internal service ..."
        Me.AppHaltedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.DarkGray
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Controls.Add(Me.PingPanel)
        Me.MainPanel.Controls.Add(Me.LostSignalPanel)
        Me.MainPanel.Controls.Add(Me.SlowDownAlertBox)
        Me.MainPanel.Controls.Add(Me.TimerPanel)
        Me.MainPanel.Controls.Add(Me.SpeedIndicatorPanel)
        Me.MainPanel.Controls.Add(Me.PictureBox1)
        Me.MainPanel.Controls.Add(Me.BatteryPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(16)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(16)
        Me.MainPanel.Size = New System.Drawing.Size(1117, 527)
        Me.MainPanel.TabIndex = 2
        Me.MainPanel.Visible = False
        '
        'PingPanel
        '
        Me.PingPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PingPanel.Controls.Add(Me.PingLbl)
        Me.PingPanel.Controls.Add(Me.SignalIconPanel)
        Me.PingPanel.Location = New System.Drawing.Point(970, 19)
        Me.PingPanel.MinimumSize = New System.Drawing.Size(128, 32)
        Me.PingPanel.Name = "PingPanel"
        Me.PingPanel.Opacity = 0.5R
        Me.PingPanel.Size = New System.Drawing.Size(128, 32)
        Me.PingPanel.TabIndex = 5
        Me.PingPanel.TransparentColor = System.Drawing.Color.Transparent
        '
        'PingLbl
        '
        Me.PingLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingLbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingLbl.ForeColor = System.Drawing.Color.White
        Me.PingLbl.Location = New System.Drawing.Point(32, 0)
        Me.PingLbl.Name = "PingLbl"
        Me.PingLbl.Size = New System.Drawing.Size(96, 32)
        Me.PingLbl.TabIndex = 0
        Me.PingLbl.Text = "145 ms"
        Me.PingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SignalIconPanel
        '
        Me.SignalIconPanel.Controls.Add(Me.SignalIcon)
        Me.SignalIconPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SignalIconPanel.Location = New System.Drawing.Point(0, 0)
        Me.SignalIconPanel.Name = "SignalIconPanel"
        Me.SignalIconPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.SignalIconPanel.Size = New System.Drawing.Size(32, 32)
        Me.SignalIconPanel.TabIndex = 3
        '
        'SignalIcon
        '
        Me.SignalIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SignalIcon.Image = Global.Telemetry.My.Resources.Resources.Signal
        Me.SignalIcon.Location = New System.Drawing.Point(4, 4)
        Me.SignalIcon.Name = "SignalIcon"
        Me.SignalIcon.Size = New System.Drawing.Size(24, 24)
        Me.SignalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SignalIcon.TabIndex = 0
        Me.SignalIcon.TabStop = False
        '
        'LostSignalPanel
        '
        Me.LostSignalPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LostSignalPanel.Controls.Add(Me.LostSignalLabel)
        Me.LostSignalPanel.Location = New System.Drawing.Point(302, 199)
        Me.LostSignalPanel.MinimumSize = New System.Drawing.Size(100, 75)
        Me.LostSignalPanel.Name = "LostSignalPanel"
        Me.LostSignalPanel.Opacity = 0.25R
        Me.LostSignalPanel.Size = New System.Drawing.Size(512, 128)
        Me.LostSignalPanel.TabIndex = 4
        Me.LostSignalPanel.Tag = "True"
        Me.LostSignalPanel.Transparent = True
        Me.LostSignalPanel.TransparentColor = System.Drawing.Color.Red
        '
        'LostSignalLabel
        '
        Me.LostSignalLabel.BackColor = System.Drawing.Color.Transparent
        Me.LostSignalLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LostSignalLabel.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LostSignalLabel.ForeColor = System.Drawing.Color.White
        Me.LostSignalLabel.Location = New System.Drawing.Point(0, 0)
        Me.LostSignalLabel.Name = "LostSignalLabel"
        Me.LostSignalLabel.Size = New System.Drawing.Size(512, 128)
        Me.LostSignalLabel.TabIndex = 1
        Me.LostSignalLabel.Tag = "0"
        Me.LostSignalLabel.Text = "SIGNAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PERDU"
        Me.LostSignalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SlowDownAlertBox
        '
        Me.SlowDownAlertBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SlowDownAlertBox.Controls.Add(Me.AlertLabel)
        Me.SlowDownAlertBox.Controls.Add(Me.AlertIconPanel)
        Me.SlowDownAlertBox.Location = New System.Drawing.Point(302, 0)
        Me.SlowDownAlertBox.MinimumSize = New System.Drawing.Size(100, 75)
        Me.SlowDownAlertBox.Name = "SlowDownAlertBox"
        Me.SlowDownAlertBox.Opacity = 0.5R
        Me.SlowDownAlertBox.Size = New System.Drawing.Size(512, 128)
        Me.SlowDownAlertBox.TabIndex = 3
        Me.SlowDownAlertBox.Transparent = True
        Me.SlowDownAlertBox.TransparentColor = System.Drawing.Color.White
        '
        'AlertLabel
        '
        Me.AlertLabel.BackColor = System.Drawing.Color.Transparent
        Me.AlertLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertLabel.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertLabel.ForeColor = System.Drawing.Color.White
        Me.AlertLabel.Location = New System.Drawing.Point(128, 0)
        Me.AlertLabel.Name = "AlertLabel"
        Me.AlertLabel.Size = New System.Drawing.Size(384, 128)
        Me.AlertLabel.TabIndex = 5
        Me.AlertLabel.Text = "RALENTIR !"
        Me.AlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlertIconPanel
        '
        Me.AlertIconPanel.Controls.Add(Me.AlertIcon)
        Me.AlertIconPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AlertIconPanel.Location = New System.Drawing.Point(0, 0)
        Me.AlertIconPanel.MinimumSize = New System.Drawing.Size(100, 75)
        Me.AlertIconPanel.Name = "AlertIconPanel"
        Me.AlertIconPanel.Opacity = 0R
        Me.AlertIconPanel.Padding = New System.Windows.Forms.Padding(8)
        Me.AlertIconPanel.Size = New System.Drawing.Size(128, 128)
        Me.AlertIconPanel.TabIndex = 4
        Me.AlertIconPanel.Text = "TransparentControl1"
        Me.AlertIconPanel.Transparent = True
        Me.AlertIconPanel.TransparentColor = System.Drawing.Color.White
        '
        'AlertIcon
        '
        Me.AlertIcon.Controls.Add(Me.AlertBox)
        Me.AlertIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertIcon.Location = New System.Drawing.Point(0, 0)
        Me.AlertIcon.Name = "AlertIcon"
        Me.AlertIcon.Padding = New System.Windows.Forms.Padding(8)
        Me.AlertIcon.Size = New System.Drawing.Size(128, 128)
        Me.AlertIcon.TabIndex = 1
        '
        'AlertBox
        '
        Me.AlertBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertBox.Image = Global.Telemetry.My.Resources.Resources.Warning
        Me.AlertBox.Location = New System.Drawing.Point(8, 8)
        Me.AlertBox.Name = "AlertBox"
        Me.AlertBox.Size = New System.Drawing.Size(112, 112)
        Me.AlertBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AlertBox.TabIndex = 0
        Me.AlertBox.TabStop = False
        '
        'TimerPanel
        '
        Me.TimerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TimerPanel.BackColor = System.Drawing.Color.DimGray
        Me.TimerPanel.Controls.Add(Me.TimerLbl)
        Me.TimerPanel.Controls.Add(Me.StopwatchIconPanel)
        Me.TimerPanel.Location = New System.Drawing.Point(396, 444)
        Me.TimerPanel.Name = "TimerPanel"
        Me.TimerPanel.Size = New System.Drawing.Size(325, 64)
        Me.TimerPanel.TabIndex = 1
        '
        'TimerLbl
        '
        Me.TimerLbl.BackColor = System.Drawing.Color.Transparent
        Me.TimerLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimerLbl.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLbl.ForeColor = System.Drawing.Color.White
        Me.TimerLbl.Location = New System.Drawing.Point(64, 0)
        Me.TimerLbl.Name = "TimerLbl"
        Me.TimerLbl.Size = New System.Drawing.Size(261, 64)
        Me.TimerLbl.TabIndex = 0
        Me.TimerLbl.Text = "00:01:24.87"
        Me.TimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StopwatchIconPanel
        '
        Me.StopwatchIconPanel.Controls.Add(Me.StopwatchIcon)
        Me.StopwatchIconPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.StopwatchIconPanel.Location = New System.Drawing.Point(0, 0)
        Me.StopwatchIconPanel.Name = "StopwatchIconPanel"
        Me.StopwatchIconPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.StopwatchIconPanel.Size = New System.Drawing.Size(64, 64)
        Me.StopwatchIconPanel.TabIndex = 1
        '
        'StopwatchIcon
        '
        Me.StopwatchIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StopwatchIcon.Image = Global.Telemetry.My.Resources.Resources.Stopwatch
        Me.StopwatchIcon.Location = New System.Drawing.Point(4, 4)
        Me.StopwatchIcon.Name = "StopwatchIcon"
        Me.StopwatchIcon.Size = New System.Drawing.Size(56, 56)
        Me.StopwatchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StopwatchIcon.TabIndex = 3
        Me.StopwatchIcon.TabStop = False
        '
        'BatteryPanel
        '
        Me.BatteryPanel.BackColor = System.Drawing.Color.DimGray
        Me.BatteryPanel.Controls.Add(Me.BatteryBarPanel)
        Me.BatteryPanel.Controls.Add(Me.BatteryIconPanel)
        Me.BatteryPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BatteryPanel.Location = New System.Drawing.Point(16, 16)
        Me.BatteryPanel.Name = "BatteryPanel"
        Me.BatteryPanel.Size = New System.Drawing.Size(48, 495)
        Me.BatteryPanel.TabIndex = 1
        '
        'BatteryBarPanel
        '
        Me.BatteryBarPanel.BackColor = System.Drawing.Color.White
        Me.BatteryBarPanel.Controls.Add(Me.BatteryBarBackground)
        Me.BatteryBarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.BatteryBarPanel.Name = "BatteryBarPanel"
        Me.BatteryBarPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarPanel.Size = New System.Drawing.Size(48, 431)
        Me.BatteryBarPanel.TabIndex = 3
        '
        'BatteryBarBackground
        '
        Me.BatteryBarBackground.BackColor = System.Drawing.Color.Black
        Me.BatteryBarBackground.Controls.Add(Me.BatteryProgress)
        Me.BatteryBarBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarBackground.Location = New System.Drawing.Point(4, 4)
        Me.BatteryBarBackground.Name = "BatteryBarBackground"
        Me.BatteryBarBackground.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarBackground.Size = New System.Drawing.Size(40, 423)
        Me.BatteryBarBackground.TabIndex = 0
        '
        'BatteryProgress
        '
        Me.BatteryProgress.BackColor = System.Drawing.Color.White
        Me.BatteryProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BatteryProgress.Location = New System.Drawing.Point(4, 273)
        Me.BatteryProgress.Name = "BatteryProgress"
        Me.BatteryProgress.Size = New System.Drawing.Size(32, 146)
        Me.BatteryProgress.TabIndex = 0
        '
        'BatteryIconPanel
        '
        Me.BatteryIconPanel.Controls.Add(Me.BatteryIcon)
        Me.BatteryIconPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BatteryIconPanel.Location = New System.Drawing.Point(0, 431)
        Me.BatteryIconPanel.Name = "BatteryIconPanel"
        Me.BatteryIconPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.BatteryIconPanel.Size = New System.Drawing.Size(48, 64)
        Me.BatteryIconPanel.TabIndex = 3
        '
        'BatteryIcon
        '
        Me.BatteryIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryIcon.Image = Global.Telemetry.My.Resources.Resources.Energy
        Me.BatteryIcon.Location = New System.Drawing.Point(2, 2)
        Me.BatteryIcon.Name = "BatteryIcon"
        Me.BatteryIcon.Size = New System.Drawing.Size(44, 60)
        Me.BatteryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatteryIcon.TabIndex = 2
        Me.BatteryIcon.TabStop = False
        '
        'SpeedIndicatorPanel
        '
        Me.SpeedIndicatorPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpeedIndicatorPanel.BackColor = System.Drawing.Color.DimGray
        Me.SpeedIndicatorPanel.Controls.Add(Me.SpeedLbl)
        Me.SpeedIndicatorPanel.Location = New System.Drawing.Point(842, 252)
        Me.SpeedIndicatorPanel.Name = "SpeedIndicatorPanel"
        Me.SpeedIndicatorPanel.Size = New System.Drawing.Size(256, 256)
        Me.SpeedIndicatorPanel.TabIndex = 0
        '
        'SpeedLbl
        '
        Me.SpeedLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLbl.ForeColor = System.Drawing.Color.White
        Me.SpeedLbl.Location = New System.Drawing.Point(0, 0)
        Me.SpeedLbl.Name = "SpeedLbl"
        Me.SpeedLbl.Size = New System.Drawing.Size(256, 256)
        Me.SpeedLbl.TabIndex = 0
        Me.SpeedLbl.Text = "3,6 Km/H" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1 M/S)"
        Me.SpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Telemetry.My.Resources.Resources.animated_loader
        Me.PictureBox1.Location = New System.Drawing.Point(64, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1037, 495)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 527)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.AppHaltedLbl)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROSALIE - Télémétrie"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainPanel.ResumeLayout(False)
        Me.PingPanel.ResumeLayout(False)
        Me.SignalIconPanel.ResumeLayout(False)
        CType(Me.SignalIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LostSignalPanel.ResumeLayout(False)
        Me.SlowDownAlertBox.ResumeLayout(False)
        Me.AlertIconPanel.ResumeLayout(False)
        Me.AlertIcon.ResumeLayout(False)
        CType(Me.AlertBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimerPanel.ResumeLayout(False)
        Me.StopwatchIconPanel.ResumeLayout(False)
        CType(Me.StopwatchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BatteryPanel.ResumeLayout(False)
        Me.BatteryBarPanel.ResumeLayout(False)
        Me.BatteryBarBackground.ResumeLayout(False)
        Me.BatteryIconPanel.ResumeLayout(False)
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpeedIndicatorPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SpeedIndicatorPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SpeedLbl As Label
    Friend WithEvents BatteryPanel As Panel
    Friend WithEvents TimerPanel As Panel
    Friend WithEvents TimerLbl As Label
    Friend WithEvents BatteryBarPanel As Panel
    Friend WithEvents BatteryIconPanel As Panel
    Friend WithEvents BatteryIcon As PictureBox
    Friend WithEvents PingLbl As Label
    Friend WithEvents BatteryBarBackground As Panel
    Friend WithEvents BatteryProgress As Panel
    Friend WithEvents StopwatchIconPanel As Panel
    Friend WithEvents StopwatchIcon As PictureBox
    Friend WithEvents SignalIconPanel As Panel
    Friend WithEvents SignalIcon As PictureBox
    Friend WithEvents SlowDownAlertBox As TransparentControl
    Friend WithEvents AlertIconPanel As TransparentControl
    Friend WithEvents AlertBox As PictureBox
    Friend WithEvents AlertIcon As Panel
    Friend WithEvents LostSignalPanel As TransparentControl
    Friend WithEvents LostSignalLabel As Label
    Friend WithEvents AlertLabel As Label
    Friend WithEvents PingPanel As TransparentControl
    Friend WithEvents AnimationWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LostSignalFlicker As Timer
    Friend WithEvents AppHaltedLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
