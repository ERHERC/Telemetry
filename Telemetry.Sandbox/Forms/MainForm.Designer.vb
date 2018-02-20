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
        Me.MainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryGroup = New System.Windows.Forms.GroupBox()
        Me.StyleManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.BatteryLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryUD = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.BatteryBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.MainPanel.SuspendLayout()
        Me.BatteryGroup.SuspendLayout()
        Me.BatteryLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.ColumnCount = 3
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainPanel.Controls.Add(Me.BatteryGroup, 0, 0)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.RowCount = 3
        Me.MainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainPanel.Size = New System.Drawing.Size(1094, 443)
        Me.MainPanel.TabIndex = 0
        '
        'BatteryGroup
        '
        Me.BatteryGroup.Controls.Add(Me.BatteryLayout)
        Me.BatteryGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryGroup.Location = New System.Drawing.Point(3, 3)
        Me.BatteryGroup.Name = "BatteryGroup"
        Me.BatteryGroup.Size = New System.Drawing.Size(358, 141)
        Me.BatteryGroup.TabIndex = 0
        Me.BatteryGroup.TabStop = False
        Me.BatteryGroup.Text = "Batterie"
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'BatteryLayout
        '
        Me.BatteryLayout.ColumnCount = 1
        Me.BatteryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryLayout.Controls.Add(Me.BatteryUD, 0, 0)
        Me.BatteryLayout.Controls.Add(Me.BatteryBtn, 0, 1)
        Me.BatteryLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryLayout.Location = New System.Drawing.Point(3, 16)
        Me.BatteryLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryLayout.Name = "BatteryLayout"
        Me.BatteryLayout.RowCount = 2
        Me.BatteryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.BatteryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BatteryLayout.Size = New System.Drawing.Size(352, 122)
        Me.BatteryLayout.TabIndex = 0
        '
        'BatteryUD
        '
        Me.BatteryUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryUD.Location = New System.Drawing.Point(0, 0)
        Me.BatteryUD.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryUD.Name = "BatteryUD"
        Me.BatteryUD.Size = New System.Drawing.Size(352, 22)
        Me.BatteryUD.TabIndex = 0
        Me.BatteryUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BatteryUD.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'BatteryBtn
        '
        Me.BatteryBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBtn.Location = New System.Drawing.Point(0, 22)
        Me.BatteryBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBtn.Name = "BatteryBtn"
        Me.BatteryBtn.Size = New System.Drawing.Size(352, 100)
        Me.BatteryBtn.TabIndex = 1
        Me.BatteryBtn.Values.Text = "Appliquer"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 443)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telemetry [Bac à sable]"
        Me.MainPanel.ResumeLayout(False)
        Me.BatteryGroup.ResumeLayout(False)
        Me.BatteryLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As TableLayoutPanel
    Friend WithEvents BatteryGroup As GroupBox
    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
    Friend WithEvents BatteryLayout As TableLayoutPanel
    Friend WithEvents BatteryUD As KryptonNumericUpDown
    Friend WithEvents BatteryBtn As KryptonButton
End Class
