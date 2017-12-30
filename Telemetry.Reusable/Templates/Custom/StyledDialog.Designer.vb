<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StyledDialog
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
        Me.SplitPanel_02 = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.SplitPanel_01 = New System.Windows.Forms.Panel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.FormDescription = New System.Windows.Forms.Label()
        Me.FormTitle = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitPanel_02
        '
        Me.SplitPanel_02.BackColor = System.Drawing.Color.Silver
        Me.SplitPanel_02.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitPanel_02.Location = New System.Drawing.Point(0, 505)
        Me.SplitPanel_02.MaximumSize = New System.Drawing.Size(0, 1)
        Me.SplitPanel_02.MinimumSize = New System.Drawing.Size(0, 1)
        Me.SplitPanel_02.Name = "SplitPanel_02"
        Me.SplitPanel_02.Size = New System.Drawing.Size(1055, 1)
        Me.SplitPanel_02.TabIndex = 6
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 506)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.BottomPanel.Size = New System.Drawing.Size(1055, 48)
        Me.BottomPanel.TabIndex = 5
        '
        'SplitPanel_01
        '
        Me.SplitPanel_01.BackColor = System.Drawing.Color.Silver
        Me.SplitPanel_01.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitPanel_01.Location = New System.Drawing.Point(0, 64)
        Me.SplitPanel_01.MaximumSize = New System.Drawing.Size(0, 1)
        Me.SplitPanel_01.MinimumSize = New System.Drawing.Size(0, 1)
        Me.SplitPanel_01.Name = "SplitPanel_01"
        Me.SplitPanel_01.Size = New System.Drawing.Size(1055, 1)
        Me.SplitPanel_01.TabIndex = 8
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.FormDescription)
        Me.HeaderPanel.Controls.Add(Me.FormTitle)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1055, 64)
        Me.HeaderPanel.TabIndex = 7
        '
        'FormDescription
        '
        Me.FormDescription.AutoSize = True
        Me.FormDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.FormDescription.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FormDescription.Location = New System.Drawing.Point(12, 33)
        Me.FormDescription.Name = "FormDescription"
        Me.FormDescription.Size = New System.Drawing.Size(83, 18)
        Me.FormDescription.TabIndex = 0
        Me.FormDescription.Text = "Description"
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = True
        Me.FormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FormTitle.ForeColor = System.Drawing.Color.Orange
        Me.FormTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FormTitle.Location = New System.Drawing.Point(12, 9)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(45, 24)
        Me.FormTitle.TabIndex = 0
        Me.FormTitle.Text = "Title"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 65)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(16)
        Me.MainPanel.Size = New System.Drawing.Size(1055, 440)
        Me.MainPanel.TabIndex = 9
        '
        'StyledDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 554)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SplitPanel_01)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.SplitPanel_02)
        Me.Controls.Add(Me.BottomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.FormPin = True
        Me.MaximizeBox = False
        Me.Name = "StyledDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitPanel_02 As Windows.Forms.Panel
    Friend WithEvents SplitPanel_01 As Windows.Forms.Panel
    Public WithEvents HeaderPanel As Windows.Forms.Panel
    Protected WithEvents FormDescription As Windows.Forms.Label
    Protected WithEvents FormTitle As Windows.Forms.Label
    Public WithEvents MainPanel As Windows.Forms.Panel
    Public WithEvents BottomPanel As Windows.Forms.Panel
End Class
