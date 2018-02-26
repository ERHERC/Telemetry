<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    'Inherits System.Windows.Forms.Form
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.BatteryGroup = New System.Windows.Forms.GroupBox()
        Me.BatteryLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BatteryPanel = New System.Windows.Forms.Panel()
        Me.BatteryUD = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.BatteryLbl = New System.Windows.Forms.Label()
        Me.StyleManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette()
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.MainPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.PingGroup = New System.Windows.Forms.GroupBox()
        Me.PingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.PingBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.PingPanel = New System.Windows.Forms.Panel()
        Me.PingUD = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.PingLbl = New System.Windows.Forms.Label()
        Me.SpeedGroup = New System.Windows.Forms.GroupBox()
        Me.SpeedLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SpeedBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SpeedPanel = New System.Windows.Forms.Panel()
        Me.SpeedUD = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.SpeedLbl = New System.Windows.Forms.Label()
        Me.DistanceGroup = New System.Windows.Forms.GroupBox()
        Me.DistanceLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.DistanceBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DistancePanel = New System.Windows.Forms.Panel()
        Me.DistanceUD = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.DistanceLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PingWorker = New System.ComponentModel.BackgroundWorker()
        Me.BatteryGroup.SuspendLayout()
        Me.BatteryLayout.SuspendLayout()
        Me.BatteryPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.PingGroup.SuspendLayout()
        Me.PingLayout.SuspendLayout()
        Me.PingPanel.SuspendLayout()
        Me.SpeedGroup.SuspendLayout()
        Me.SpeedLayout.SuspendLayout()
        Me.SpeedPanel.SuspendLayout()
        Me.DistanceGroup.SuspendLayout()
        Me.DistanceLayout.SuspendLayout()
        Me.DistancePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BatteryGroup
        '
        Me.BatteryGroup.Controls.Add(Me.BatteryLayout)
        Me.BatteryGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatteryGroup.ForeColor = System.Drawing.Color.DimGray
        Me.BatteryGroup.Location = New System.Drawing.Point(24, 24)
        Me.BatteryGroup.Margin = New System.Windows.Forms.Padding(8)
        Me.BatteryGroup.Name = "BatteryGroup"
        Me.BatteryGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.BatteryGroup.Size = New System.Drawing.Size(350, 150)
        Me.BatteryGroup.TabIndex = 0
        Me.BatteryGroup.TabStop = False
        Me.BatteryGroup.Text = "Batterie"
        '
        'BatteryLayout
        '
        Me.BatteryLayout.ColumnCount = 1
        Me.BatteryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryLayout.Controls.Add(Me.BatteryBtn, 0, 1)
        Me.BatteryLayout.Controls.Add(Me.BatteryPanel, 0, 0)
        Me.BatteryLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryLayout.Location = New System.Drawing.Point(0, 22)
        Me.BatteryLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryLayout.Name = "BatteryLayout"
        Me.BatteryLayout.RowCount = 2
        Me.BatteryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.BatteryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BatteryLayout.Size = New System.Drawing.Size(350, 128)
        Me.BatteryLayout.TabIndex = 0
        '
        'BatteryBtn
        '
        Me.BatteryBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBtn.Location = New System.Drawing.Point(0, 32)
        Me.BatteryBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBtn.Name = "BatteryBtn"
        Me.BatteryBtn.Size = New System.Drawing.Size(350, 96)
        Me.BatteryBtn.TabIndex = 1
        Me.BatteryBtn.Values.Text = "Appliquer"
        '
        'BatteryPanel
        '
        Me.BatteryPanel.Controls.Add(Me.BatteryUD)
        Me.BatteryPanel.Controls.Add(Me.BatteryLbl)
        Me.BatteryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryPanel.Location = New System.Drawing.Point(0, 0)
        Me.BatteryPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryPanel.Name = "BatteryPanel"
        Me.BatteryPanel.Size = New System.Drawing.Size(350, 32)
        Me.BatteryPanel.TabIndex = 2
        '
        'BatteryUD
        '
        Me.BatteryUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryUD.Location = New System.Drawing.Point(0, 0)
        Me.BatteryUD.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryUD.Name = "BatteryUD"
        Me.BatteryUD.Size = New System.Drawing.Size(286, 32)
        Me.BatteryUD.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatteryUD.TabIndex = 0
        Me.BatteryUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BatteryUD.ThousandsSeparator = True
        Me.BatteryUD.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'BatteryLbl
        '
        Me.BatteryLbl.BackColor = System.Drawing.Color.Crimson
        Me.BatteryLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.BatteryLbl.Font = New System.Drawing.Font("Impact", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatteryLbl.ForeColor = System.Drawing.Color.White
        Me.BatteryLbl.Location = New System.Drawing.Point(286, 0)
        Me.BatteryLbl.Name = "BatteryLbl"
        Me.BatteryLbl.Size = New System.Drawing.Size(64, 32)
        Me.BatteryLbl.TabIndex = 5
        Me.BatteryLbl.Text = "%"
        Me.BatteryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.Controls.Add(Me.BatteryGroup)
        Me.MainPanel.Controls.Add(Me.PingGroup)
        Me.MainPanel.Controls.Add(Me.SpeedGroup)
        Me.MainPanel.Controls.Add(Me.DistanceGroup)
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(16, 16, 16, 6)
        Me.MainPanel.Size = New System.Drawing.Size(1133, 443)
        Me.MainPanel.TabIndex = 1
        '
        'PingGroup
        '
        Me.PingGroup.Controls.Add(Me.PingLayout)
        Me.PingGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingGroup.ForeColor = System.Drawing.Color.DimGray
        Me.PingGroup.Location = New System.Drawing.Point(390, 24)
        Me.PingGroup.Margin = New System.Windows.Forms.Padding(8)
        Me.PingGroup.Name = "PingGroup"
        Me.PingGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.PingGroup.Size = New System.Drawing.Size(350, 150)
        Me.PingGroup.TabIndex = 0
        Me.PingGroup.TabStop = False
        Me.PingGroup.Text = "Ping"
        '
        'PingLayout
        '
        Me.PingLayout.ColumnCount = 1
        Me.PingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingLayout.Controls.Add(Me.PingBtn, 0, 1)
        Me.PingLayout.Controls.Add(Me.PingPanel, 0, 0)
        Me.PingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingLayout.Location = New System.Drawing.Point(0, 22)
        Me.PingLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.PingLayout.Name = "PingLayout"
        Me.PingLayout.RowCount = 2
        Me.PingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.PingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PingLayout.Size = New System.Drawing.Size(350, 128)
        Me.PingLayout.TabIndex = 0
        '
        'PingBtn
        '
        Me.PingBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingBtn.Location = New System.Drawing.Point(0, 32)
        Me.PingBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.PingBtn.Name = "PingBtn"
        Me.PingBtn.Size = New System.Drawing.Size(350, 96)
        Me.PingBtn.TabIndex = 1
        Me.PingBtn.Values.Text = "Appliquer"
        '
        'PingPanel
        '
        Me.PingPanel.Controls.Add(Me.PingUD)
        Me.PingPanel.Controls.Add(Me.PingLbl)
        Me.PingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingPanel.Location = New System.Drawing.Point(0, 0)
        Me.PingPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PingPanel.Name = "PingPanel"
        Me.PingPanel.Size = New System.Drawing.Size(350, 32)
        Me.PingPanel.TabIndex = 2
        '
        'PingUD
        '
        Me.PingUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingUD.Location = New System.Drawing.Point(0, 0)
        Me.PingUD.Margin = New System.Windows.Forms.Padding(0)
        Me.PingUD.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.PingUD.Name = "PingUD"
        Me.PingUD.Size = New System.Drawing.Size(286, 32)
        Me.PingUD.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingUD.TabIndex = 2
        Me.PingUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PingUD.ThousandsSeparator = True
        Me.PingUD.Value = New Decimal(New Integer() {145, 0, 0, 0})
        '
        'PingLbl
        '
        Me.PingLbl.BackColor = System.Drawing.Color.Crimson
        Me.PingLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PingLbl.Font = New System.Drawing.Font("Impact", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingLbl.ForeColor = System.Drawing.Color.White
        Me.PingLbl.Location = New System.Drawing.Point(286, 0)
        Me.PingLbl.Name = "PingLbl"
        Me.PingLbl.Size = New System.Drawing.Size(64, 32)
        Me.PingLbl.TabIndex = 4
        Me.PingLbl.Text = "ms"
        Me.PingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpeedGroup
        '
        Me.SpeedGroup.Controls.Add(Me.SpeedLayout)
        Me.SpeedGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedGroup.ForeColor = System.Drawing.Color.DimGray
        Me.SpeedGroup.Location = New System.Drawing.Point(756, 24)
        Me.SpeedGroup.Margin = New System.Windows.Forms.Padding(8)
        Me.SpeedGroup.Name = "SpeedGroup"
        Me.SpeedGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.SpeedGroup.Size = New System.Drawing.Size(350, 150)
        Me.SpeedGroup.TabIndex = 1
        Me.SpeedGroup.TabStop = False
        Me.SpeedGroup.Text = "Vitesse"
        '
        'SpeedLayout
        '
        Me.SpeedLayout.ColumnCount = 1
        Me.SpeedLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SpeedLayout.Controls.Add(Me.SpeedBtn, 0, 1)
        Me.SpeedLayout.Controls.Add(Me.SpeedPanel, 0, 0)
        Me.SpeedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedLayout.Location = New System.Drawing.Point(0, 22)
        Me.SpeedLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.SpeedLayout.Name = "SpeedLayout"
        Me.SpeedLayout.RowCount = 2
        Me.SpeedLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.SpeedLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SpeedLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SpeedLayout.Size = New System.Drawing.Size(350, 128)
        Me.SpeedLayout.TabIndex = 0
        '
        'SpeedBtn
        '
        Me.SpeedBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedBtn.Location = New System.Drawing.Point(0, 32)
        Me.SpeedBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SpeedBtn.Name = "SpeedBtn"
        Me.SpeedBtn.Size = New System.Drawing.Size(350, 96)
        Me.SpeedBtn.TabIndex = 1
        Me.SpeedBtn.Values.Text = "Appliquer"
        '
        'SpeedPanel
        '
        Me.SpeedPanel.Controls.Add(Me.SpeedUD)
        Me.SpeedPanel.Controls.Add(Me.SpeedLbl)
        Me.SpeedPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedPanel.Location = New System.Drawing.Point(0, 0)
        Me.SpeedPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.Size = New System.Drawing.Size(350, 32)
        Me.SpeedPanel.TabIndex = 4
        '
        'SpeedUD
        '
        Me.SpeedUD.DecimalPlaces = 2
        Me.SpeedUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedUD.Location = New System.Drawing.Point(0, 0)
        Me.SpeedUD.Margin = New System.Windows.Forms.Padding(0)
        Me.SpeedUD.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SpeedUD.Name = "SpeedUD"
        Me.SpeedUD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpeedUD.Size = New System.Drawing.Size(286, 32)
        Me.SpeedUD.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedUD.TabIndex = 2
        Me.SpeedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SpeedUD.ThousandsSeparator = True
        Me.SpeedUD.Value = New Decimal(New Integer() {36, 0, 0, 65536})
        '
        'SpeedLbl
        '
        Me.SpeedLbl.BackColor = System.Drawing.Color.Crimson
        Me.SpeedLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.SpeedLbl.Font = New System.Drawing.Font("Impact", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLbl.ForeColor = System.Drawing.Color.White
        Me.SpeedLbl.Location = New System.Drawing.Point(286, 0)
        Me.SpeedLbl.Name = "SpeedLbl"
        Me.SpeedLbl.Size = New System.Drawing.Size(64, 32)
        Me.SpeedLbl.TabIndex = 3
        Me.SpeedLbl.Text = "KM/h"
        Me.SpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DistanceGroup
        '
        Me.DistanceGroup.Controls.Add(Me.DistanceLayout)
        Me.DistanceGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceGroup.ForeColor = System.Drawing.Color.DimGray
        Me.DistanceGroup.Location = New System.Drawing.Point(24, 190)
        Me.DistanceGroup.Margin = New System.Windows.Forms.Padding(8)
        Me.DistanceGroup.Name = "DistanceGroup"
        Me.DistanceGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.DistanceGroup.Size = New System.Drawing.Size(350, 150)
        Me.DistanceGroup.TabIndex = 2
        Me.DistanceGroup.TabStop = False
        Me.DistanceGroup.Text = "Distance"
        '
        'DistanceLayout
        '
        Me.DistanceLayout.ColumnCount = 1
        Me.DistanceLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DistanceLayout.Controls.Add(Me.DistanceBtn, 0, 1)
        Me.DistanceLayout.Controls.Add(Me.DistancePanel, 0, 0)
        Me.DistanceLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistanceLayout.Location = New System.Drawing.Point(0, 22)
        Me.DistanceLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.DistanceLayout.Name = "DistanceLayout"
        Me.DistanceLayout.RowCount = 2
        Me.DistanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.DistanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DistanceLayout.Size = New System.Drawing.Size(350, 128)
        Me.DistanceLayout.TabIndex = 0
        '
        'DistanceBtn
        '
        Me.DistanceBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistanceBtn.Location = New System.Drawing.Point(0, 32)
        Me.DistanceBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.DistanceBtn.Name = "DistanceBtn"
        Me.DistanceBtn.Size = New System.Drawing.Size(350, 96)
        Me.DistanceBtn.TabIndex = 1
        Me.DistanceBtn.Values.Text = "Appliquer"
        '
        'DistancePanel
        '
        Me.DistancePanel.Controls.Add(Me.DistanceUD)
        Me.DistancePanel.Controls.Add(Me.DistanceLbl)
        Me.DistancePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistancePanel.Location = New System.Drawing.Point(0, 0)
        Me.DistancePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DistancePanel.Name = "DistancePanel"
        Me.DistancePanel.Size = New System.Drawing.Size(350, 32)
        Me.DistancePanel.TabIndex = 2
        '
        'DistanceUD
        '
        Me.DistanceUD.DecimalPlaces = 1
        Me.DistanceUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistanceUD.Location = New System.Drawing.Point(0, 0)
        Me.DistanceUD.Margin = New System.Windows.Forms.Padding(0)
        Me.DistanceUD.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DistanceUD.Name = "DistanceUD"
        Me.DistanceUD.Size = New System.Drawing.Size(286, 32)
        Me.DistanceUD.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceUD.TabIndex = 0
        Me.DistanceUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DistanceUD.ThousandsSeparator = True
        Me.DistanceUD.Value = New Decimal(New Integer() {134, 0, 0, 0})
        '
        'DistanceLbl
        '
        Me.DistanceLbl.BackColor = System.Drawing.Color.Crimson
        Me.DistanceLbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.DistanceLbl.Font = New System.Drawing.Font("Impact", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceLbl.ForeColor = System.Drawing.Color.White
        Me.DistanceLbl.Location = New System.Drawing.Point(286, 0)
        Me.DistanceLbl.Name = "DistanceLbl"
        Me.DistanceLbl.Size = New System.Drawing.Size(64, 32)
        Me.DistanceLbl.TabIndex = 5
        Me.DistanceLbl.Text = "m"
        Me.DistanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(390, 190)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(716, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Distance"
        '
        'PingWorker
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 443)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "MainForm"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telemetry [Bac à sable]"
        Me.BatteryGroup.ResumeLayout(False)
        Me.BatteryLayout.ResumeLayout(False)
        Me.BatteryPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.PingGroup.ResumeLayout(False)
        Me.PingLayout.ResumeLayout(False)
        Me.PingPanel.ResumeLayout(False)
        Me.SpeedGroup.ResumeLayout(False)
        Me.SpeedLayout.ResumeLayout(False)
        Me.SpeedPanel.ResumeLayout(False)
        Me.DistanceGroup.ResumeLayout(False)
        Me.DistanceLayout.ResumeLayout(False)
        Me.DistancePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BatteryGroup As GroupBox
    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
    Friend WithEvents BatteryLayout As TableLayoutPanel
    Friend WithEvents BatteryUD As KryptonNumericUpDown
    Friend WithEvents BatteryBtn As KryptonButton
    Friend WithEvents MainPanel As FlowLayoutPanel
    Friend WithEvents PingGroup As GroupBox
    Friend WithEvents PingLayout As TableLayoutPanel
    Friend WithEvents PingBtn As KryptonButton
    Friend WithEvents PingUD As KryptonNumericUpDown
    Friend WithEvents SpeedGroup As GroupBox
    Friend WithEvents SpeedLayout As TableLayoutPanel
    Friend WithEvents SpeedUD As KryptonNumericUpDown
    Friend WithEvents SpeedBtn As KryptonButton
    Friend WithEvents SpeedLbl As Label
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents PingPanel As Panel
    Friend WithEvents PingLbl As Label
    Friend WithEvents BatteryPanel As Panel
    Friend WithEvents BatteryLbl As Label
    Friend WithEvents PingWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistanceGroup As GroupBox
    Friend WithEvents DistanceLayout As TableLayoutPanel
    Friend WithEvents DistanceBtn As KryptonButton
    Friend WithEvents DistancePanel As Panel
    Friend WithEvents DistanceUD As KryptonNumericUpDown
    Friend WithEvents DistanceLbl As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
