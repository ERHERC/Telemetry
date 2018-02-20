Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Crimson)
        API.Init(True)
    End Sub

    Private Sub BatteryBtn_Click(sender As Object, e As EventArgs) Handles BatteryBtn.Click
        API.Instance.SetBatteryPercentage(CInt(BatteryUD.Value))
    End Sub
End Class