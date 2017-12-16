<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    'Inherits System.Windows.Forms.Form
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.MainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DisplayGroup = New System.Windows.Forms.GroupBox()
        Me.DisplayLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.WindowedBtn = New System.Windows.Forms.Button()
        Me.FullscreenBtn = New System.Windows.Forms.Button()
        Me.StyleManager = New ComponentFactory.Krypton.Toolkit.KryptonManager()
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette()
        Me.MainPanel.SuspendLayout()
        Me.DisplayGroup.SuspendLayout()
        Me.DisplayLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.ColumnCount = 3
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainPanel.Controls.Add(Me.DisplayGroup, 0, 0)
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
        'DisplayGroup
        '
        Me.DisplayGroup.Controls.Add(Me.DisplayLayout)
        Me.DisplayGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayGroup.Location = New System.Drawing.Point(3, 3)
        Me.DisplayGroup.Name = "DisplayGroup"
        Me.DisplayGroup.Size = New System.Drawing.Size(358, 141)
        Me.DisplayGroup.TabIndex = 0
        Me.DisplayGroup.TabStop = False
        Me.DisplayGroup.Text = "Affichage"
        '
        'DisplayLayout
        '
        Me.DisplayLayout.ColumnCount = 1
        Me.DisplayLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DisplayLayout.Controls.Add(Me.WindowedBtn, 0, 1)
        Me.DisplayLayout.Controls.Add(Me.FullscreenBtn, 0, 0)
        Me.DisplayLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayLayout.Location = New System.Drawing.Point(3, 16)
        Me.DisplayLayout.Name = "DisplayLayout"
        Me.DisplayLayout.RowCount = 2
        Me.DisplayLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DisplayLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DisplayLayout.Size = New System.Drawing.Size(352, 122)
        Me.DisplayLayout.TabIndex = 0
        '
        'WindowedBtn
        '
        Me.WindowedBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowedBtn.Location = New System.Drawing.Point(3, 64)
        Me.WindowedBtn.Name = "WindowedBtn"
        Me.WindowedBtn.Size = New System.Drawing.Size(346, 55)
        Me.WindowedBtn.TabIndex = 1
        Me.WindowedBtn.Text = "Mode fenêtré"
        Me.WindowedBtn.UseVisualStyleBackColor = True
        '
        'FullscreenBtn
        '
        Me.FullscreenBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FullscreenBtn.Location = New System.Drawing.Point(3, 3)
        Me.FullscreenBtn.Name = "FullscreenBtn"
        Me.FullscreenBtn.Size = New System.Drawing.Size(346, 55)
        Me.FullscreenBtn.TabIndex = 0
        Me.FullscreenBtn.Text = "Mode plein écran"
        Me.FullscreenBtn.UseVisualStyleBackColor = True
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
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
        Me.DisplayGroup.ResumeLayout(False)
        Me.DisplayLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As TableLayoutPanel
    Friend WithEvents DisplayGroup As GroupBox
    Friend WithEvents DisplayLayout As TableLayoutPanel
    Friend WithEvents WindowedBtn As Button
    Friend WithEvents FullscreenBtn As Button
    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
End Class
