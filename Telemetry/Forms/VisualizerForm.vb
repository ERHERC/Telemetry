Imports VB = Microsoft.VisualBasic

Public Class VisualizerForm
    Public SecretCode As Queue(Of Keys)
    Private LastKeyStroke As Double = 0

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (VB.Timer - LastKeyStroke) > 1D Then SecretCode.Clear()
        LastKeyStroke = VB.Timer
        SecretCode.Enqueue(keyData)
        EasterEggCipher.Scan(SecretCode)

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        PanelManager.VideoOutput = Me.VideoOutputPanel
        PanelManager.Messages = Me.MessagesContent
        PanelManager.Battery = Me.BatteryPanel

        FormsManager.Messages = New MessagesPopup()

        SecretCode = New Queue(Of Keys)
    End Sub
    Private Sub VisualizerForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.Visible Then MessagesPanel.Visible = Not Me.Width < 700
        If Not PanelManager.Battery Is Nothing Then PanelManager.Battery.Visible = Not Me.Width < 440
        'MessagesPopupBtn.Visible = Me.Width < 700
    End Sub

    Private Sub VisualizerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MessagesPopupBtn_Click(sender As Object, e As EventArgs) Handles MessagesPopupBtn.Click
        Togglemessages(PanelToggleArguments.NoSet)
        FormsManager.Messages.Visible = Not FormsManager.Messages.Visible
    End Sub

    Private Sub Togglemessages(Action As PanelToggleArguments)
        Select Case Not FormsManager.Messages.Visible
            Case True
                FormsManager.Messages.MainPanel.Controls.Add(PanelManager.Messages)
                If MessagesPanel.Visible Then Libraries.Tools.Wait(1)
                MessagesPanel.Visible = False
            Case False
                Me.MessagesPanel.Controls.Add(PanelManager.Messages)
                PanelManager.Messages.BringToFront()
                MessagesPanel.Visible = Not Me.Width < 700
        End Select
    End Sub

    Private Sub VisualizerForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'MsgBox(e.KeyCode.ToString())
    End Sub
End Class