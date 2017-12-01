Public Class MessagesPopup
#Region "CP_NOCLOSE_BUTTON"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Params.ClassStyle = Params.ClassStyle Or CP_NOCLOSE_BUTTON
            Return Params
        End Get
    End Property
#End Region

    Private Sub MessagesPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ainPanel.Controls.Add(PanelManager.Messages.Controls.Find("MessagesContent", False)(0))
    End Sub
End Class