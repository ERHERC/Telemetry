<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits Reusable.DesktopWindow

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
        Me.StyleManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.TopBar = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ListViewBtn = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.GridViewBtn = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.MainPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.DisplayMode = New ComponentFactory.Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.TopEdge = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        CType(Me.TopBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopBar.SuspendLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormPinBtn
        '
        Me.FormPinBtn.Visible = True
        '
        'FormBackBtn
        '
        Me.FormBackBtn.Visible = True
        '
        'FormNextBtn
        '
        Me.FormNextBtn.Visible = True
        '
        'FormHomeBtn
        '
        Me.FormHomeBtn.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[True]
        Me.FormHomeBtn.Visible = True
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'TopBar
        '
        Me.TopBar.Controls.Add(Me.ListViewBtn)
        Me.TopBar.Controls.Add(Me.GridViewBtn)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.TopBar.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.TopBar.Size = New System.Drawing.Size(624, 32)
        Me.TopBar.TabIndex = 0
        '
        'ListViewBtn
        '
        Me.ListViewBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.ListViewBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListViewBtn.Location = New System.Drawing.Point(444, 4)
        Me.ListViewBtn.Name = "ListViewBtn"
        Me.ListViewBtn.Size = New System.Drawing.Size(90, 28)
        Me.ListViewBtn.TabIndex = 1
        Me.ListViewBtn.Values.Text = "Liste"
        '
        'GridViewBtn
        '
        Me.GridViewBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.GridViewBtn.Checked = True
        Me.GridViewBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridViewBtn.Location = New System.Drawing.Point(534, 4)
        Me.GridViewBtn.Name = "GridViewBtn"
        Me.GridViewBtn.Size = New System.Drawing.Size(90, 28)
        Me.GridViewBtn.TabIndex = 0
        Me.GridViewBtn.Values.Text = "Grille"
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 33)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(624, 409)
        Me.MainPanel.TabIndex = 1
        '
        'DisplayMode
        '
        Me.DisplayMode.CheckButtons.Add(Me.GridViewBtn)
        Me.DisplayMode.CheckButtons.Add(Me.ListViewBtn)
        Me.DisplayMode.CheckedButton = Me.GridViewBtn
        '
        'TopEdge
        '
        Me.TopEdge.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate
        Me.TopEdge.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopEdge.Location = New System.Drawing.Point(0, 32)
        Me.TopEdge.Name = "TopEdge"
        Me.TopEdge.Size = New System.Drawing.Size(624, 1)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopEdge)
        Me.Controls.Add(Me.TopBar)
        Me.FormBack = True
        Me.FormHome = True
        Me.FormHomeEnabled = True
        Me.FormNext = True
        Me.FormPin = True
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.TopBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopBar.ResumeLayout(False)
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
    Friend WithEvents TopBar As KryptonPanel
    Friend WithEvents MainPanel As KryptonPanel
    Friend WithEvents DisplayMode As KryptonCheckSet
    Friend WithEvents TopEdge As KryptonBorderEdge
    Friend WithEvents ListViewBtn As KryptonCheckButton
    Friend WithEvents GridViewBtn As KryptonCheckButton
End Class
