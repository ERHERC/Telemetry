Public Class SetupForm
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        FormsManager.MainForm.DATA_VALIDATED = True
        Me.Close()
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Me.Close()
    End Sub
End Class
