Imports System.ComponentModel

Public Class DesktopWindow
#Region "Form Header Navigation"
#Region "Pin Button"
    <Category("Navigation")>
    Public Event PinButtonClicked(sender As Object, e As EventArgs)

    Private _FormPin As Boolean = False
    <Category("Window Style"), Description("Determines whether a form has a pin button in the upper-right of its caption bar.")>
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
                FormPinBtn.Checked = ButtonCheckState.Checked
            Else
                FormPinBtn.Type = PaletteButtonSpecStyle.PinVertical
                FormPinBtn.Checked = ButtonCheckState.Unchecked
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
#Region "Navigation"
#Region "Home Button"
    <Category("Navigation")>
    Public Event HomeButtonClicked(sender As Object, e As EventArgs)
    Private Sub FormHomeBtn_Click(sender As Object, e As EventArgs) Handles FormHomeBtn.Click
        RaiseEvent HomeButtonClicked(sender, e)
    End Sub
    Private _FormHome As Boolean = False
    <Category("Window Navigation"), Description("Determines whether a form has a home button in the upper-left of its caption bar.")>
    Public Property FormHome As Boolean
        Get
            Return _FormHome
        End Get
        Set(Value As Boolean)
            _FormHome = Value
            FormHomeBtn.Visible = Value
        End Set
    End Property
    Private _FormHomeEnabled As Boolean = False
    <Category("Window Navigation"), Description("Determines whether the home button is enabled or not.")>
    Public Property FormHomeEnabled As Boolean
        Get
            Return _FormHomeEnabled
        End Get
        Set(Value As Boolean)
            _FormHomeEnabled = Value
            If Value Then
                FormHomeBtn.Enabled = ButtonEnabled.True
            Else
                FormHomeBtn.Enabled = ButtonEnabled.False
            End If
        End Set
    End Property
#End Region
#Region "Back Button"
    <Category("Navigation")>
    Public Event BackButtonClicked(sender As Object, e As EventArgs)
    Private Sub FormBackBtn_Click(sender As Object, e As EventArgs) Handles FormBackBtn.Click
        RaiseEvent BackButtonClicked(sender, e)
    End Sub
    Private _FormBack As Boolean = False
    <Category("Window Navigation"), Description("Determines whether a form has a back button in the upper-left of its caption bar.")>
    Public Property FormBack As Boolean
        Get
            Return _FormBack
        End Get
        Set(Value As Boolean)
            _FormBack = Value
            FormBackBtn.Visible = Value
        End Set
    End Property
    Private _FormBackEnabled As Boolean = False
    <Category("Window Navigation"), Description("Determines whether the back button is enabled or not.")>
    Public Property FormBackEnabled As Boolean
        Get
            Return _FormBackEnabled
        End Get
        Set(Value As Boolean)
            _FormBackEnabled = Value
            If Value Then
                FormBackBtn.Enabled = ButtonEnabled.True
            Else
                FormBackBtn.Enabled = ButtonEnabled.False
            End If
        End Set
    End Property
#End Region
#Region "Next Button"
    <Category("Navigation")>
    Public Event NextButtonClicked(sender As Object, e As EventArgs)
    Private Sub FormNextBtn_Click(sender As Object, e As EventArgs) Handles FormNextBtn.Click
        RaiseEvent NextButtonClicked(sender, e)
    End Sub
    Private _FormNext As Boolean = False
    <Category("Window Navigation"), Description("Determines whether a form has a next button in the upper-left of its caption bar.")>
    Public Property FormNext As Boolean
        Get
            Return _FormNext
        End Get
        Set(Value As Boolean)
            _FormNext = Value
            FormNextBtn.Visible = Value
        End Set
    End Property
    Private _FormNextEnabled As Boolean = False
    <Category("Window Navigation"), Description("Determines whether the next button is enabled or not.")>
    Public Property FormNextEnabled As Boolean
        Get
            Return _FormNextEnabled
        End Get
        Set(Value As Boolean)
            _FormNextEnabled = Value
            If Value Then
                FormNextBtn.Enabled = ButtonEnabled.True
            Else
                FormNextBtn.Enabled = ButtonEnabled.False
            End If
        End Set
    End Property
#End Region
#End Region
#End Region
End Class