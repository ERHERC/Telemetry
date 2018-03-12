<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
    Inherits Reusable.StyledDialog

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.ParametersLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ComPortLbl = New System.Windows.Forms.Label()
        Me.ServiceAddressPanel = New System.Windows.Forms.Panel()
        Me.ServiceAddressLbl = New System.Windows.Forms.Label()
        Me.ServiceAddressBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ComPortCBox = New System.Windows.Forms.ComboBox()
        Me.HeaderPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.ParametersLayout.SuspendLayout()
        Me.ServiceAddressPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Goldenrod
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
        Me.QuitBtn.TabIndex = 5
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
        Me.OkBtn.TabIndex = 4
        Me.OkBtn.Text = "VALIDER"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'ParametersLayout
        '
        Me.ParametersLayout.ColumnCount = 2
        Me.ParametersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ParametersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ParametersLayout.Controls.Add(Me.ComPortLbl, 0, 1)
        Me.ParametersLayout.Controls.Add(Me.ServiceAddressPanel, 0, 0)
        Me.ParametersLayout.Controls.Add(Me.ServiceAddressBox, 1, 0)
        Me.ParametersLayout.Controls.Add(Me.ComPortCBox, 1, 1)
        Me.ParametersLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParametersLayout.Location = New System.Drawing.Point(16, 16)
        Me.ParametersLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.ParametersLayout.Name = "ParametersLayout"
        Me.ParametersLayout.RowCount = 3
        Me.ParametersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ParametersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ParametersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ParametersLayout.Size = New System.Drawing.Size(1023, 408)
        Me.ParametersLayout.TabIndex = 2
        '
        'ComPortLbl
        '
        Me.ComPortLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortLbl.ForeColor = System.Drawing.Color.White
        Me.ComPortLbl.Location = New System.Drawing.Point(0, 22)
        Me.ComPortLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.ComPortLbl.Name = "ComPortLbl"
        Me.ComPortLbl.Size = New System.Drawing.Size(200, 22)
        Me.ComPortLbl.TabIndex = 4
        Me.ComPortLbl.Text = "Port série :"
        Me.ComPortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'ComPortCBox
        '
        Me.ComPortCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortCBox.FormattingEnabled = True
        Me.ComPortCBox.Location = New System.Drawing.Point(203, 25)
        Me.ComPortCBox.Name = "ComPortCBox"
        Me.ComPortCBox.Size = New System.Drawing.Size(817, 21)
        Me.ComPortCBox.TabIndex = 5
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 554)
        Me.Name = "SetupForm"
        Me.Text = "SetupForm"
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

    Friend WithEvents QuitBtn As Windows.Forms.Button
    Friend WithEvents OkBtn As Windows.Forms.Button
    Friend WithEvents ParametersLayout As Windows.Forms.TableLayoutPanel
    Friend WithEvents ServiceAddressPanel As Windows.Forms.Panel
    Friend WithEvents ServiceAddressLbl As Windows.Forms.Label
    Friend WithEvents ServiceAddressBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ComPortLbl As Windows.Forms.Label
    Friend WithEvents ComPortCBox As Windows.Forms.ComboBox
End Class
