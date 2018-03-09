<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits DesktopWindow

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
        Me.OutputBox = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.MainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.MainLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormPinBtn
        '
        Me.FormPinBtn.Visible = True
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'OutputBox
        '
        Me.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputBox.Location = New System.Drawing.Point(0, 0)
        Me.OutputBox.Margin = New System.Windows.Forms.Padding(0)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.ReadOnly = True
        Me.OutputBox.Size = New System.Drawing.Size(624, 221)
        Me.OutputBox.TabIndex = 0
        Me.OutputBox.Text = ""
        '
        'MainLayout
        '
        Me.MainLayout.ColumnCount = 1
        Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayout.Controls.Add(Me.OutputBox, 0, 0)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.RowCount = 2
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayout.Size = New System.Drawing.Size(624, 442)
        Me.MainLayout.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.MainLayout)
        Me.FormPin = True
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.MainLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
    Friend WithEvents OutputBox As KryptonRichTextBox
    Friend WithEvents MainLayout As TableLayoutPanel
End Class
