<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisualizerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizerForm))
        Me.VideoOutput = New System.Windows.Forms.PictureBox()
        Me.VideoOutputHeader = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.VideoOutputPanel = New System.Windows.Forms.Panel()
        Me.VideoOutputHeaderPanel = New System.Windows.Forms.Panel()
        Me.PingPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PingLabel = New System.Windows.Forms.Label()
        Me.PingIconPanel = New System.Windows.Forms.Panel()
        Me.PingIcon = New System.Windows.Forms.PictureBox()
        Me.MessagesPanel = New System.Windows.Forms.Panel()
        Me.MessagesContent = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessagesPopupTransmittedLbl = New System.Windows.Forms.Label()
        Me.MessagesHeader = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.MessagesPopupBtn = New System.Windows.Forms.Button()
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.VideoOutputPanel.SuspendLayout()
        Me.VideoOutputHeaderPanel.SuspendLayout()
        Me.PingPanel.SuspendLayout()
        Me.PingIconPanel.SuspendLayout()
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagesPanel.SuspendLayout()
        Me.MessagesContent.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoOutput
        '
        Me.VideoOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.VideoOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutput.Image = Global.Telemetry.My.Resources.Resources.animated_loader
        Me.VideoOutput.Location = New System.Drawing.Point(0, 37)
        Me.VideoOutput.Name = "VideoOutput"
        Me.VideoOutput.Size = New System.Drawing.Size(572, 380)
        Me.VideoOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VideoOutput.TabIndex = 0
        Me.VideoOutput.TabStop = False
        '
        'VideoOutputHeader
        '
        Me.VideoOutputHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutputHeader.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoOutputHeader.ForeColor = System.Drawing.Color.LightGray
        Me.VideoOutputHeader.Location = New System.Drawing.Point(0, 0)
        Me.VideoOutputHeader.Name = "VideoOutputHeader"
        Me.VideoOutputHeader.Size = New System.Drawing.Size(446, 37)
        Me.VideoOutputHeader.TabIndex = 1
        Me.VideoOutputHeader.Text = "SIGNAL VIDEO"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.Controls.Add(Me.VideoOutputPanel)
        Me.MainPanel.Controls.Add(Me.MessagesPanel)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(24)
        Me.MainPanel.Size = New System.Drawing.Size(876, 513)
        Me.MainPanel.TabIndex = 2
        '
        'VideoOutputPanel
        '
        Me.VideoOutputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.VideoOutputPanel.Controls.Add(Me.VideoOutput)
        Me.VideoOutputPanel.Controls.Add(Me.VideoOutputHeaderPanel)
        Me.VideoOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutputPanel.Location = New System.Drawing.Point(280, 24)
        Me.VideoOutputPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.VideoOutputPanel.Name = "VideoOutputPanel"
        Me.VideoOutputPanel.Size = New System.Drawing.Size(572, 417)
        Me.VideoOutputPanel.TabIndex = 1
        '
        'VideoOutputHeaderPanel
        '
        Me.VideoOutputHeaderPanel.Controls.Add(Me.VideoOutputHeader)
        Me.VideoOutputHeaderPanel.Controls.Add(Me.PingPanel)
        Me.VideoOutputHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoOutputHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoOutputHeaderPanel.Name = "VideoOutputHeaderPanel"
        Me.VideoOutputHeaderPanel.Size = New System.Drawing.Size(572, 37)
        Me.VideoOutputHeaderPanel.TabIndex = 2
        '
        'PingPanel
        '
        Me.PingPanel.AutoSize = True
        Me.PingPanel.ColumnCount = 2
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingPanel.Controls.Add(Me.PingLabel, 1, 0)
        Me.PingPanel.Controls.Add(Me.PingIconPanel, 0, 0)
        Me.PingPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PingPanel.Location = New System.Drawing.Point(446, 0)
        Me.PingPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PingPanel.Name = "PingPanel"
        Me.PingPanel.RowCount = 1
        Me.PingPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingPanel.Size = New System.Drawing.Size(126, 37)
        Me.PingPanel.TabIndex = 2
        '
        'PingLabel
        '
        Me.PingLabel.AutoSize = True
        Me.PingLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingLabel.ForeColor = System.Drawing.Color.White
        Me.PingLabel.Location = New System.Drawing.Point(40, 0)
        Me.PingLabel.Name = "PingLabel"
        Me.PingLabel.Size = New System.Drawing.Size(83, 37)
        Me.PingLabel.TabIndex = 4
        Me.PingLabel.Text = "145 ms"
        Me.PingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PingIconPanel
        '
        Me.PingIconPanel.Controls.Add(Me.PingIcon)
        Me.PingIconPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingIconPanel.Location = New System.Drawing.Point(3, 3)
        Me.PingIconPanel.Name = "PingIconPanel"
        Me.PingIconPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.PingIconPanel.Size = New System.Drawing.Size(31, 31)
        Me.PingIconPanel.TabIndex = 3
        '
        'PingIcon
        '
        Me.PingIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingIcon.Image = Global.Telemetry.My.Resources.Resources.Signal
        Me.PingIcon.Location = New System.Drawing.Point(2, 2)
        Me.PingIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.PingIcon.Name = "PingIcon"
        Me.PingIcon.Size = New System.Drawing.Size(27, 27)
        Me.PingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PingIcon.TabIndex = 0
        Me.PingIcon.TabStop = False
        '
        'MessagesPanel
        '
        Me.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MessagesPanel.Controls.Add(Me.MessagesContent)
        Me.MessagesPanel.Controls.Add(Me.MessagesPopupTransmittedLbl)
        Me.MessagesPanel.Controls.Add(Me.MessagesHeader)
        Me.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MessagesPanel.Location = New System.Drawing.Point(24, 24)
        Me.MessagesPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.MessagesPanel.Name = "MessagesPanel"
        Me.MessagesPanel.Size = New System.Drawing.Size(256, 417)
        Me.MessagesPanel.TabIndex = 2
        '
        'MessagesContent
        '
        Me.MessagesContent.AutoScroll = True
        Me.MessagesContent.AutoSize = True
        Me.MessagesContent.Controls.Add(Me.Label1)
        Me.MessagesContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesContent.Location = New System.Drawing.Point(0, 37)
        Me.MessagesContent.Name = "MessagesContent"
        Me.MessagesContent.Padding = New System.Windows.Forms.Padding(8)
        Me.MessagesContent.Size = New System.Drawing.Size(256, 380)
        Me.MessagesContent.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 364)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'MessagesPopupTransmittedLbl
        '
        Me.MessagesPopupTransmittedLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesPopupTransmittedLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesPopupTransmittedLbl.Location = New System.Drawing.Point(0, 37)
        Me.MessagesPopupTransmittedLbl.Name = "MessagesPopupTransmittedLbl"
        Me.MessagesPopupTransmittedLbl.Size = New System.Drawing.Size(256, 380)
        Me.MessagesPopupTransmittedLbl.TabIndex = 3
        Me.MessagesPopupTransmittedLbl.Text = "Le contenu à été transmis dans la fenêtre popup." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fermez la fenêtre popup pour " &
    "revenir à un affichage classique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MessagesPopupTransmittedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessagesHeader
        '
        Me.MessagesHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessagesHeader.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesHeader.ForeColor = System.Drawing.Color.DimGray
        Me.MessagesHeader.Location = New System.Drawing.Point(0, 0)
        Me.MessagesHeader.Name = "MessagesHeader"
        Me.MessagesHeader.Size = New System.Drawing.Size(256, 37)
        Me.MessagesHeader.TabIndex = 1
        Me.MessagesHeader.Text = "MESSAGES"
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.MessagesPopupBtn)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(24, 441)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BottomPanel.Size = New System.Drawing.Size(828, 48)
        Me.BottomPanel.TabIndex = 3
        '
        'MessagesPopupBtn
        '
        Me.MessagesPopupBtn.AutoSize = True
        Me.MessagesPopupBtn.BackColor = System.Drawing.Color.DimGray
        Me.MessagesPopupBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.MessagesPopupBtn.FlatAppearance.BorderSize = 0
        Me.MessagesPopupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MessagesPopupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MessagesPopupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MessagesPopupBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MessagesPopupBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MessagesPopupBtn.Location = New System.Drawing.Point(0, 4)
        Me.MessagesPopupBtn.Name = "MessagesPopupBtn"
        Me.MessagesPopupBtn.Size = New System.Drawing.Size(131, 40)
        Me.MessagesPopupBtn.TabIndex = 1
        Me.MessagesPopupBtn.Text = "MESSAGES"
        Me.MessagesPopupBtn.UseVisualStyleBackColor = False
        '
        'VisualizerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 513)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "VisualizerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualizerForm"
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.VideoOutputPanel.ResumeLayout(False)
        Me.VideoOutputHeaderPanel.ResumeLayout(False)
        Me.VideoOutputHeaderPanel.PerformLayout()
        Me.PingPanel.ResumeLayout(False)
        Me.PingPanel.PerformLayout()
        Me.PingIconPanel.ResumeLayout(False)
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagesPanel.ResumeLayout(False)
        Me.MessagesPanel.PerformLayout()
        Me.MessagesContent.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VideoOutput As PictureBox
    Friend WithEvents VideoOutputHeader As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents VideoOutputPanel As Panel
    Friend WithEvents MessagesPanel As Panel
    Friend WithEvents MessagesHeader As Label
    Friend WithEvents VideoOutputHeaderPanel As Panel
    Friend WithEvents PingPanel As TableLayoutPanel
    Friend WithEvents PingIconPanel As Panel
    Friend WithEvents PingIcon As PictureBox
    Friend WithEvents PingLabel As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MessagesPopupBtn As Button
    Friend WithEvents MessagesContent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MessagesPopupTransmittedLbl As Label
End Class
