<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsoleWindow
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
        Me.ConsoleMenu = New System.Windows.Forms.MenuStrip()
        Me.OuvrirLesLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffacerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenirÀLaDernièreLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.Output = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.BottomPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CommandPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CommandBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ExecuteBtn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.ConsoleMenu.SuspendLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.BottomPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        CType(Me.CommandPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommandPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConsoleMenu
        '
        Me.ConsoleMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ConsoleMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirLesLogsToolStripMenuItem, Me.EffacerToutToolStripMenuItem, Me.AideToolStripMenuItem, Me.RevenirÀLaDernièreLigneToolStripMenuItem, Me.ParamètresToolStripMenuItem})
        Me.ConsoleMenu.Location = New System.Drawing.Point(0, 0)
        Me.ConsoleMenu.Name = "ConsoleMenu"
        Me.ConsoleMenu.Size = New System.Drawing.Size(976, 24)
        Me.ConsoleMenu.TabIndex = 0
        Me.ConsoleMenu.Visible = False
        '
        'OuvrirLesLogsToolStripMenuItem
        '
        Me.OuvrirLesLogsToolStripMenuItem.Name = "OuvrirLesLogsToolStripMenuItem"
        Me.OuvrirLesLogsToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.OuvrirLesLogsToolStripMenuItem.Text = "Ouvrir les logs"
        '
        'EffacerToutToolStripMenuItem
        '
        Me.EffacerToutToolStripMenuItem.Name = "EffacerToutToolStripMenuItem"
        Me.EffacerToutToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.EffacerToutToolStripMenuItem.Text = "Effacer tout"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'RevenirÀLaDernièreLigneToolStripMenuItem
        '
        Me.RevenirÀLaDernièreLigneToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RevenirÀLaDernièreLigneToolStripMenuItem.Name = "RevenirÀLaDernièreLigneToolStripMenuItem"
        Me.RevenirÀLaDernièreLigneToolStripMenuItem.Size = New System.Drawing.Size(154, 20)
        Me.RevenirÀLaDernièreLigneToolStripMenuItem.Text = "Revenir à la dernière ligne"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Output)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 24)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(976, 400)
        Me.MainPanel.TabIndex = 1
        '
        'Output
        '
        Me.Output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Output.Location = New System.Drawing.Point(0, 0)
        Me.Output.Margin = New System.Windows.Forms.Padding(0)
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.Size = New System.Drawing.Size(976, 400)
        Me.Output.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Output.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Output.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Output.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Output.StateCommon.Content.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.TabIndex = 0
        Me.Output.Text = ""
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.CommandPanel)
        Me.BottomPanel.Controls.Add(Me.ExecuteBtn)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 424)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(976, 24)
        Me.BottomPanel.TabIndex = 0
        '
        'CommandPanel
        '
        Me.CommandPanel.Controls.Add(Me.CommandBox)
        Me.CommandPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandPanel.Location = New System.Drawing.Point(0, 0)
        Me.CommandPanel.Name = "CommandPanel"
        Me.CommandPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.CommandPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.CommandPanel.Size = New System.Drawing.Size(886, 24)
        Me.CommandPanel.TabIndex = 0
        '
        'CommandBox
        '
        Me.CommandBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandBox.Location = New System.Drawing.Point(2, 2)
        Me.CommandBox.Name = "CommandBox"
        Me.CommandBox.Size = New System.Drawing.Size(882, 20)
        Me.CommandBox.StateCommon.Content.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBox.TabIndex = 0
        '
        'ExecuteBtn
        '
        Me.ExecuteBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExecuteBtn.Location = New System.Drawing.Point(886, 0)
        Me.ExecuteBtn.Name = "ExecuteBtn"
        Me.ExecuteBtn.Size = New System.Drawing.Size(90, 24)
        Me.ExecuteBtn.TabIndex = 1
        Me.ExecuteBtn.Values.Text = "Exécuter"
        '
        'ConsoleWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.ConsoleMenu)
        Me.MainMenuStrip = Me.ConsoleMenu
        Me.Name = "ConsoleWindow"
        Me.ShowIcon = False
        Me.Text = "Console"
        Me.ConsoleMenu.ResumeLayout(False)
        Me.ConsoleMenu.PerformLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.BottomPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        CType(Me.CommandPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommandPanel.ResumeLayout(False)
        Me.CommandPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsoleMenu As Windows.Forms.MenuStrip
    Friend WithEvents MainPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents BottomPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CommandBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ExecuteBtn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CommandPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents Output As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents OuvrirLesLogsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EffacerToutToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevenirÀLaDernièreLigneToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Serial As System.IO.Ports.SerialPort
    Friend WithEvents ParamètresToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
