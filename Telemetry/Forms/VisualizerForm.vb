Public Class VisualizerForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        PanelManager.VideoOutput = Me.VideoOutputPanel
        PanelManager.Messages = Me.MessagesContent

        FormsManager.Messages = New MessagesPopup()
    End Sub
    Private Sub VisualizerForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.Visible Then MessagesPanel.Visible = Not Me.Width < 700
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
                Libraries.Tools.Wait(2)
                MessagesPanel.Visible = False
            Case False
                Me.MessagesPanel.Controls.Add(PanelManager.Messages)
                PanelManager.Messages.BringToFront()
                MessagesPanel.Visible = Not Me.Width < 700
        End Select
    End Sub
End Class