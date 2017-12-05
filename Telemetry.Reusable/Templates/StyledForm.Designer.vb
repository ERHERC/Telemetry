Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StyledForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StyledForm))
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
        resources.ApplyResources(Me.MainPanel, "MainPanel")
        Me.MainPanel.Name = "MainPanel"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.FormDescription)
        Me.HeaderPanel.Controls.Add(Me.FormTitle)
        resources.ApplyResources(Me.HeaderPanel, "HeaderPanel")
        Me.HeaderPanel.Name = "HeaderPanel"
        '
        'FormDescription
        '
        resources.ApplyResources(Me.FormDescription, "FormDescription")
        Me.FormDescription.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormDescription.Name = "FormDescription"
        '
        'FormTitle
        '
        resources.ApplyResources(Me.FormTitle, "FormTitle")
        Me.FormTitle.ForeColor = System.Drawing.Color.Orange
        Me.FormTitle.Name = "FormTitle"
        '
        'SplitPanel_01
        '
        Me.SplitPanel_01.BackColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.SplitPanel_01, "SplitPanel_01")
        Me.SplitPanel_01.Name = "SplitPanel_01"
        '
        'StyledForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SplitPanel_01)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "StyledForm"
        Me.ShowIcon = False
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
