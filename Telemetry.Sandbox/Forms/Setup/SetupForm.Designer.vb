<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
    Inherits Telemetry.Reusable.StyledDialog

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.ParametersLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ServiceAddressPanel = New System.Windows.Forms.Panel()
        Me.ServiceAddressLbl = New System.Windows.Forms.Label()
        Me.ServiceAddressBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.HeaderPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.ParametersLayout.SuspendLayout()
        Me.ServiceAddressPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Crimson
        '
        'FormDescription
        '
        Me.FormDescription.Size = New System.Drawing.Size(325, 18)
        Me.FormDescription.Text = "Veuillez configurer le logiciel avant son utilisation"
        '
        'FormTitle
        '
        Me.FormTitle.ForeColor = System.Drawing.Color.White
        Me.FormTitle.Size = New System.Drawing.Size(230, 24)
        Me.FormTitle.Text = "Assistant de mise en route"
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.ParametersLayout)
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.QuitBtn)
        Me.BottomPanel.Controls.Add(Me.OkBtn)
        '
        'QuitBtn
        '
        Me.QuitBtn.AutoSize = True
        Me.QuitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.QuitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.QuitBtn.FlatAppearance.BorderSize = 0
        Me.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBtn.ForeColor = System.Drawing.Color.White
        Me.QuitBtn.Location = New System.Drawing.Point(12, 12)
        Me.QuitBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(66, 24)
        Me.QuitBtn.TabIndex = 3
        Me.QuitBtn.Text = "QUITTER"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.AutoSize = True
        Me.OkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBtn.ForeColor = System.Drawing.Color.White
        Me.OkBtn.Location = New System.Drawing.Point(978, 12)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(65, 24)
        Me.OkBtn.TabIndex = 2
        Me.OkBtn.Text = "VALIDER"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'ParametersLayout
        '
        Me.ParametersLayout.ColumnCount = 2
        Me.ParametersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ParametersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ParametersLayout.Controls.Add(Me.ServiceAddressPanel, 0, 0)
        Me.ParametersLayout.Controls.Add(Me.ServiceAddressBox, 1, 0)
        Me.ParametersLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParametersLayout.Location = New System.Drawing.Point(16, 16)
        Me.ParametersLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.ParametersLayout.Name = "ParametersLayout"
        Me.ParametersLayout.RowCount = 2
        Me.ParametersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ParametersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ParametersLayout.Size = New System.Drawing.Size(1023, 408)
        Me.ParametersLayout.TabIndex = 1
        '
        'ServiceAddressPanel
        '
        Me.ServiceAddressPanel.Controls.Add(Me.ServiceAddressLbl)
        Me.ServiceAddressPanel.Location = New System.Drawing.Point(0, 0)
        Me.ServiceAddressPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ServiceAddressPanel.Name = "ServiceAddressPanel"
        Me.ServiceAddressPanel.Size = New System.Drawing.Size(200, 22)
        Me.ServiceAddressPanel.TabIndex = 2
        '
        'ServiceAddressLbl
        '
        Me.ServiceAddressLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceAddressLbl.ForeColor = System.Drawing.Color.White
        Me.ServiceAddressLbl.Location = New System.Drawing.Point(0, 0)
        Me.ServiceAddressLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.ServiceAddressLbl.Name = "ServiceAddressLbl"
        Me.ServiceAddressLbl.Size = New System.Drawing.Size(200, 22)
        Me.ServiceAddressLbl.TabIndex = 1
        Me.ServiceAddressLbl.Text = "Adresse du service :"
        Me.ServiceAddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServiceAddressBox
        '
        Me.ServiceAddressBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceAddressBox.Location = New System.Drawing.Point(200, 0)
        Me.ServiceAddressBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ServiceAddressBox.Name = "ServiceAddressBox"
        Me.ServiceAddressBox.Size = New System.Drawing.Size(823, 20)
        Me.ServiceAddressBox.TabIndex = 3
        Me.ServiceAddressBox.Text = "net.tcp://localhost:2202/API"
        '
        'SetupForm
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.QuitBtn
        Me.ClientSize = New System.Drawing.Size(1055, 554)
        Me.Name = "SetupForm"
        Me.ShowIcon = True
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.ParametersLayout.ResumeLayout(False)
        Me.ParametersLayout.PerformLayout()
        Me.ServiceAddressPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuitBtn As Button
    Friend WithEvents OkBtn As Button
    Friend WithEvents ParametersLayout As TableLayoutPanel
    Friend WithEvents ServiceAddressPanel As Panel
    Friend WithEvents ServiceAddressLbl As Label
    Friend WithEvents ServiceAddressBox As KryptonTextBox
End Class
