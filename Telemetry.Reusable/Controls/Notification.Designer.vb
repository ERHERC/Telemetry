<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.messageLbl = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.White
        Me.TitleLbl.Location = New System.Drawing.Point(0, 0)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TitleLbl.Size = New System.Drawing.Size(72, 30)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "TITRE"
        Me.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainPanel.Controls.Add(Me.messageLbl)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 30)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(16, 8, 8, 8)
        Me.MainPanel.Size = New System.Drawing.Size(224, 70)
        Me.MainPanel.TabIndex = 5
        '
        'messageLbl
        '
        Me.messageLbl.AutoSize = True
        Me.messageLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.messageLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.messageLbl.ForeColor = System.Drawing.Color.DimGray
        Me.messageLbl.Location = New System.Drawing.Point(16, 8)
        Me.messageLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.messageLbl.Name = "messageLbl"
        Me.messageLbl.Size = New System.Drawing.Size(72, 19)
        Me.messageLbl.TabIndex = 0
        Me.messageLbl.Text = "MESSAGE"
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TitleLbl)
        Me.Margin = New System.Windows.Forms.Padding(8, 4, 0, 16)
        Me.MaximumSize = New System.Drawing.Size(224, 0)
        Me.MinimumSize = New System.Drawing.Size(224, 100)
        Me.Name = "Notification"
        Me.Size = New System.Drawing.Size(224, 100)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainPanel As Windows.Forms.Panel
    Private WithEvents TitleLbl As Windows.Forms.Label
    Friend WithEvents messageLbl As Windows.Forms.Label
End Class
