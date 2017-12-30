Imports System.ComponentModel

Public Class DesktopWindow
#Region "Form Pin Button"
    <Category("Window Style")>
    Public Event PinButtonClicked(sender As Object, e As EventArgs)

    Private _FormPin As Boolean = False
    <Category("Window Style")>
    Public Property FormPin As Boolean
        Get
            Return _FormPin
        End Get
        Set(Value As Boolean)
            _FormPin = Value
            FormPinBtn.Visible = Value
        End Set
    End Property

    Private _TopMost As Boolean = False
    Public Shadows Property TopMost As Boolean
        Get
            Return _TopMost
        End Get
        Set(Value As Boolean)
            _TopMost = Value
            MyBase.TopMost = Value
            If Value Then
                FormPinBtn.Type = PaletteButtonSpecStyle.PinHorizontal
            Else
                FormPinBtn.Type = PaletteButtonSpecStyle.PinVertical
            End If
        End Set
    End Property

    Private Sub FormPinBtn_Click(sender As Object, e As EventArgs) Handles FormPinBtn.Click
        Select Case FormPinBtn.Checked
            Case ButtonCheckState.Checked
                Me.TopMost = True
            Case ButtonCheckState.Unchecked
                Me.TopMost = False
        End Select
        RaiseEvent PinButtonClicked(sender, e)
    End Sub
#End Region
End Class