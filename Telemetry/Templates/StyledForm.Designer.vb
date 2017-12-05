<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StyledForm
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.FormDescription = New System.Windows.Forms.Label()
        Me.FormTitle = New System.Windows.Forms.Label()
        Me.SplitPanel_01 = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 65)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(16)
        Me.MainPanel.Size = New System.Drawing.Size(1055, 489)
        Me.MainPanel.TabIndex = 0
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
        Me.HeaderPanel.TabIndex = 1
        '
        'FormDescription
        '
        Me.FormDescription.AutoSize = True
        Me.FormDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormDescription.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormDescription.Location = New System.Drawing.Point(12, 33)
        Me.FormDescription.Name = "FormDescription"
        Me.FormDescription.Size = New System.Drawing.Size(83, 18)
        Me.FormDescription.TabIndex = 0
        Me.FormDescription.Text = "Description"
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = True
        Me.FormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormTitle.ForeColor = System.Drawing.Color.Orange
        Me.FormTitle.Location = New System.Drawing.Point(12, 9)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(45, 24)
        Me.FormTitle.TabIndex = 0
        Me.FormTitle.Text = "Title"
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
        Me.SplitPanel_01.TabIndex = 2
        '
        'StyledForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 554)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SplitPanel_01)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "StyledForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StyledForm"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitPanel_01 As Panel
    Public WithEvents MainPanel As Panel
    Public WithEvents HeaderPanel As Panel
    Protected WithEvents FormTitle As Label
    Protected WithEvents FormDescription As Label
End Class
