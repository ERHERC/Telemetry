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
        Me.VideoOutput = New System.Windows.Forms.PictureBox()
        Me.VideoOutputHeader = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.VideoOutputPanel = New System.Windows.Forms.Panel()
        Me.VideoOutputHeaderPanel = New System.Windows.Forms.Panel()
        Me.PingPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PingLabel = New System.Windows.Forms.Label()
        Me.PingIcon = New System.Windows.Forms.PictureBox()
        Me.MessagesPanel = New System.Windows.Forms.Panel()
        Me.MessagesPopupTransmittedLbl = New System.Windows.Forms.Label()
        Me.MessagesHeader = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.MessagesPopupBtn = New System.Windows.Forms.Button()
        Me.MessagesContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlertBox = New System.Windows.Forms.Panel()
        Me.AlertContent = New System.Windows.Forms.Panel()
        Me.AlertBoxClose = New System.Windows.Forms.Button()
        Me.AlertBoxContent = New System.Windows.Forms.Label()
        Me.BatteryBarOutterBorder = New System.Windows.Forms.Panel()
        Me.BatteryBarInnerBorder = New System.Windows.Forms.Panel()
        Me.BatteryBarResizer = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryBarProgress = New System.Windows.Forms.Panel()
        Me.BatteryIcon = New System.Windows.Forms.PictureBox()
        Me.BatteryPanel = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.VideoOutputPanel.SuspendLayout()
        Me.VideoOutputHeaderPanel.SuspendLayout()
        Me.PingPanel.SuspendLayout()
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagesPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.MessagesContent.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.AlertBox.SuspendLayout()
        Me.AlertContent.SuspendLayout()
        Me.BatteryBarOutterBorder.SuspendLayout()
        Me.BatteryBarInnerBorder.SuspendLayout()
        Me.BatteryBarResizer.SuspendLayout()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BatteryPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoOutput
        '
        Me.VideoOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.VideoOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutput.Image = Global.Telemetry.My.Resources.Resources.animated_loader
        Me.VideoOutput.Location = New System.Drawing.Point(0, 37)
        Me.VideoOutput.Name = "VideoOutput"
        Me.VideoOutput.Size = New System.Drawing.Size(685, 380)
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
        Me.VideoOutputHeader.Size = New System.Drawing.Size(559, 37)
        Me.VideoOutputHeader.TabIndex = 1
        Me.VideoOutputHeader.Text = "SIGNAL VIDEO"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.Controls.Add(Me.VideoOutputPanel)
        Me.MainPanel.Controls.Add(Me.BatteryPanel)
        Me.MainPanel.Controls.Add(Me.MessagesPanel)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(24)
        Me.MainPanel.Size = New System.Drawing.Size(1037, 513)
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
        Me.VideoOutputPanel.Size = New System.Drawing.Size(685, 417)
        Me.VideoOutputPanel.TabIndex = 1
        '
        'VideoOutputHeaderPanel
        '
        Me.VideoOutputHeaderPanel.Controls.Add(Me.VideoOutputHeader)
        Me.VideoOutputHeaderPanel.Controls.Add(Me.PingPanel)
        Me.VideoOutputHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoOutputHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoOutputHeaderPanel.Name = "VideoOutputHeaderPanel"
        Me.VideoOutputHeaderPanel.Size = New System.Drawing.Size(685, 37)
        Me.VideoOutputHeaderPanel.TabIndex = 2
        '
        'PingPanel
        '
        Me.PingPanel.AutoSize = True
        Me.PingPanel.ColumnCount = 2
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingPanel.Controls.Add(Me.PingLabel, 1, 0)
        Me.PingPanel.Controls.Add(Me.PingIcon, 0, 0)
        Me.PingPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PingPanel.Location = New System.Drawing.Point(559, 0)
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
        'PingIcon
        '
        Me.PingIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingIcon.Image = Global.Telemetry.My.Resources.Resources.Signal
        Me.PingIcon.Location = New System.Drawing.Point(4, 4)
        Me.PingIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.PingIcon.Name = "PingIcon"
        Me.PingIcon.Size = New System.Drawing.Size(29, 29)
        Me.PingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        Me.BottomPanel.Size = New System.Drawing.Size(989, 48)
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
        'MessagesContent
        '
        Me.MessagesContent.Controls.Add(Me.Panel4)
        Me.MessagesContent.Controls.Add(Me.Panel1)
        Me.MessagesContent.Controls.Add(Me.AlertBox)
        Me.MessagesContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesContent.Location = New System.Drawing.Point(0, 37)
        Me.MessagesContent.Name = "MessagesContent"
        Me.MessagesContent.Padding = New System.Windows.Forms.Padding(8, 16, 8, 16)
        Me.MessagesContent.Size = New System.Drawing.Size(256, 380)
        Me.MessagesContent.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(16, 20)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 100)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel5.Size = New System.Drawing.Size(224, 100)
        Me.Panel5.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(150, 0)
        Me.Button2.MaximumSize = New System.Drawing.Size(74, 29)
        Me.Button2.MinimumSize = New System.Drawing.Size(74, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "FERMER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(224, 100)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BATTERIE FAIBLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(16, 128)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 100)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(224, 100)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(150, 0)
        Me.Button1.MaximumSize = New System.Drawing.Size(74, 29)
        Me.Button1.MinimumSize = New System.Drawing.Size(74, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "FERMER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(224, 100)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RALENTIR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlertBox
        '
        Me.AlertBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.AlertBox.Controls.Add(Me.AlertContent)
        Me.AlertBox.Location = New System.Drawing.Point(16, 236)
        Me.AlertBox.Margin = New System.Windows.Forms.Padding(8, 4, 8, 4)
        Me.AlertBox.Name = "AlertBox"
        Me.AlertBox.Size = New System.Drawing.Size(224, 100)
        Me.AlertBox.TabIndex = 3
        '
        'AlertContent
        '
        Me.AlertContent.Controls.Add(Me.AlertBoxClose)
        Me.AlertContent.Controls.Add(Me.AlertBoxContent)
        Me.AlertContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertContent.Location = New System.Drawing.Point(0, 0)
        Me.AlertContent.Name = "AlertContent"
        Me.AlertContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AlertContent.Size = New System.Drawing.Size(224, 100)
        Me.AlertContent.TabIndex = 1
        '
        'AlertBoxClose
        '
        Me.AlertBoxClose.AutoSize = True
        Me.AlertBoxClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.AlertBoxClose.FlatAppearance.BorderSize = 0
        Me.AlertBoxClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.AlertBoxClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.AlertBoxClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AlertBoxClose.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertBoxClose.ForeColor = System.Drawing.Color.White
        Me.AlertBoxClose.Location = New System.Drawing.Point(150, 0)
        Me.AlertBoxClose.MaximumSize = New System.Drawing.Size(74, 29)
        Me.AlertBoxClose.MinimumSize = New System.Drawing.Size(74, 29)
        Me.AlertBoxClose.Name = "AlertBoxClose"
        Me.AlertBoxClose.Size = New System.Drawing.Size(74, 29)
        Me.AlertBoxClose.TabIndex = 3
        Me.AlertBoxClose.Text = "FERMER"
        Me.AlertBoxClose.UseVisualStyleBackColor = True
        '
        'AlertBoxContent
        '
        Me.AlertBoxContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertBoxContent.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertBoxContent.ForeColor = System.Drawing.Color.DimGray
        Me.AlertBoxContent.Location = New System.Drawing.Point(0, 0)
        Me.AlertBoxContent.Name = "AlertBoxContent"
        Me.AlertBoxContent.Size = New System.Drawing.Size(224, 100)
        Me.AlertBoxContent.TabIndex = 2
        Me.AlertBoxContent.Text = "SIGNAL PERDU"
        Me.AlertBoxContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BatteryBarOutterBorder
        '
        Me.BatteryBarOutterBorder.BackColor = System.Drawing.Color.White
        Me.BatteryBarOutterBorder.Controls.Add(Me.BatteryBarInnerBorder)
        Me.BatteryBarOutterBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarOutterBorder.Location = New System.Drawing.Point(4, 41)
        Me.BatteryBarOutterBorder.Margin = New System.Windows.Forms.Padding(4)
        Me.BatteryBarOutterBorder.Name = "BatteryBarOutterBorder"
        Me.BatteryBarOutterBorder.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarOutterBorder.Size = New System.Drawing.Size(40, 324)
        Me.BatteryBarOutterBorder.TabIndex = 1
        '
        'BatteryBarInnerBorder
        '
        Me.BatteryBarInnerBorder.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryBarInnerBorder.Controls.Add(Me.BatteryBarResizer)
        Me.BatteryBarInnerBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarInnerBorder.Location = New System.Drawing.Point(4, 4)
        Me.BatteryBarInnerBorder.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBarInnerBorder.Name = "BatteryBarInnerBorder"
        Me.BatteryBarInnerBorder.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarInnerBorder.Size = New System.Drawing.Size(32, 316)
        Me.BatteryBarInnerBorder.TabIndex = 0
        '
        'BatteryBarResizer
        '
        Me.BatteryBarResizer.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryBarResizer.ColumnCount = 1
        Me.BatteryBarResizer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BatteryBarResizer.Controls.Add(Me.BatteryBarProgress, 0, 1)
        Me.BatteryBarResizer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarResizer.Location = New System.Drawing.Point(4, 4)
        Me.BatteryBarResizer.Name = "BatteryBarResizer"
        Me.BatteryBarResizer.RowCount = 2
        Me.BatteryBarResizer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BatteryBarResizer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BatteryBarResizer.Size = New System.Drawing.Size(24, 308)
        Me.BatteryBarResizer.TabIndex = 0
        '
        'BatteryBarProgress
        '
        Me.BatteryBarProgress.BackColor = System.Drawing.Color.White
        Me.BatteryBarProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarProgress.Location = New System.Drawing.Point(0, 154)
        Me.BatteryBarProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBarProgress.Name = "BatteryBarProgress"
        Me.BatteryBarProgress.Size = New System.Drawing.Size(24, 154)
        Me.BatteryBarProgress.TabIndex = 0
        '
        'BatteryIcon
        '
        Me.BatteryIcon.Image = Global.Telemetry.My.Resources.Resources.Energy
        Me.BatteryIcon.Location = New System.Drawing.Point(8, 377)
        Me.BatteryIcon.Margin = New System.Windows.Forms.Padding(8)
        Me.BatteryIcon.Name = "BatteryIcon"
        Me.BatteryIcon.Size = New System.Drawing.Size(32, 32)
        Me.BatteryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatteryIcon.TabIndex = 0
        Me.BatteryIcon.TabStop = False
        '
        'BatteryPanel
        '
        Me.BatteryPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryPanel.ColumnCount = 1
        Me.BatteryPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryPanel.Controls.Add(Me.BatteryIcon, 0, 2)
        Me.BatteryPanel.Controls.Add(Me.BatteryBarOutterBorder, 0, 1)
        Me.BatteryPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BatteryPanel.Location = New System.Drawing.Point(965, 24)
        Me.BatteryPanel.Name = "BatteryPanel"
        Me.BatteryPanel.RowCount = 3
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.BatteryPanel.Size = New System.Drawing.Size(48, 417)
        Me.BatteryPanel.TabIndex = 4
        '
        'VisualizerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 513)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "VisualizerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Télémétrie [Fenêtre principale]"
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.VideoOutputPanel.ResumeLayout(False)
        Me.VideoOutputHeaderPanel.ResumeLayout(False)
        Me.VideoOutputHeaderPanel.PerformLayout()
        Me.PingPanel.ResumeLayout(False)
        Me.PingPanel.PerformLayout()
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagesPanel.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.MessagesContent.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.AlertBox.ResumeLayout(False)
        Me.AlertContent.ResumeLayout(False)
        Me.AlertContent.PerformLayout()
        Me.BatteryBarOutterBorder.ResumeLayout(False)
        Me.BatteryBarInnerBorder.ResumeLayout(False)
        Me.BatteryBarResizer.ResumeLayout(False)
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BatteryPanel.ResumeLayout(False)
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
    Friend WithEvents PingIcon As PictureBox
    Friend WithEvents PingLabel As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MessagesPopupBtn As Button
    Friend WithEvents MessagesPopupTransmittedLbl As Label
    Friend WithEvents MessagesContent As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AlertBox As Panel
    Friend WithEvents AlertContent As Panel
    Friend WithEvents AlertBoxClose As Button
    Friend WithEvents AlertBoxContent As Label
    Friend WithEvents BatteryPanel As TableLayoutPanel
    Friend WithEvents BatteryIcon As PictureBox
    Friend WithEvents BatteryBarOutterBorder As Panel
    Friend WithEvents BatteryBarInnerBorder As Panel
    Friend WithEvents BatteryBarResizer As TableLayoutPanel
    Friend WithEvents BatteryBarProgress As Panel
End Class
