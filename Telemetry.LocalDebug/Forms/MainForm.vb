Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Crimson)
        API.Init(True)
    End Sub

    Private Sub FullscreenBtn_Click(sender As Object, e As EventArgs) Handles FullscreenBtn.Click
        If API.Initiated Then API.Instance.SetFullscreen(True)
    End Sub

    Private Sub WindowedBtn_Click(sender As Object, e As EventArgs) Handles WindowedBtn.Click
        If API.Initiated Then API.Instance.SetFullscreen(False)
    End Sub
End Class