Public Class MessagesPopup
#Region "CP_NOCLOSE_BUTTON"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Params.ClassStyle = Params.ClassStyle 'Or CP_NOCLOSE_BUTTON
            Return Params
        End Get
    End Property
#End Region

    Private Sub MessagesPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MainPanel.Controls.Add(PanelManager.Messages.Controls.Find("MessagesContent", False)(0))
    End Sub

    Private Sub MessagesPopup_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then MessagesController.SetState(PanelToggleArguments.Toggle)
    End Sub

    Private Sub MessagesPopup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'MessagesController.SetState(PanelToggleArguments.Rehost)

        FormsManager.MainForm.MessagesPanel.Controls.Add(PanelManager.Messages)
        PanelManager.Messages.BringToFront()
        FormsManager.MainForm.MessagesPanel.Visible = Not FormsManager.MainForm.Width < 700
    End Sub
End Class