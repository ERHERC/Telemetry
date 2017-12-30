Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Crimson)
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        KryptonMessageBox.Show("Message", "Title", MessageBoxButtons.YesNo)
    End Sub
End Class