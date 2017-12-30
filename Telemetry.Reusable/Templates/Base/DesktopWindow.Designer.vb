<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DesktopWindow
    Inherits KryptonForm

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
        Me.FormPinBtn = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.FormBackBtn = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.FormNextBtn = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.FormHomeBtn = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.SuspendLayout()
        '
        'FormPinBtn
        '
        Me.FormPinBtn.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.FormPinBtn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.FormPinBtn.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical
        Me.FormPinBtn.UniqueName = "7DF8AF4A17F34E49B7B0B2BBD348C84B"
        Me.FormPinBtn.Visible = False
        '
        'FormBackBtn
        '
        Me.FormBackBtn.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.FormBackBtn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.FormBackBtn.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous
        Me.FormBackBtn.UniqueName = "9F3B0CCC55C54F9BBE96DC35521EF61A"
        '
        'FormNextBtn
        '
        Me.FormNextBtn.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.FormNextBtn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.FormNextBtn.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.[Next]
        Me.FormNextBtn.UniqueName = "491CF5ACFA7443C39AAAD7B95C85BECA"
        '
        'FormHomeBtn
        '
        Me.FormHomeBtn.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.FormHomeBtn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.FormHomeBtn.UniqueName = "A0224482580744858CA07639B30A3812"
        '
        'DesktopWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.FormPinBtn, Me.FormNextBtn, Me.FormBackBtn, Me.FormHomeBtn})
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "DesktopWindow"
        Me.Text = "DesktopWindow"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents FormPinBtn As ButtonSpecAny
    Public WithEvents FormBackBtn As ButtonSpecAny
    Public WithEvents FormNextBtn As ButtonSpecAny
    Public WithEvents FormHomeBtn As ButtonSpecAny
End Class
