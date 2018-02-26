Public Class SetupForm
    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.Select()
        Me.Visible = True
        FormsManager.MainForm.Hide()
        FormsManager.MainForm.ShowInTaskbar = False
    End Sub


    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        FormsManager.MainForm.DATA_VALIDATED = True
        Dim LastTask As String = ""
        Try
            LastTask = "ServiceAddress"
            IntercomApiManager.ServiceAddress = New Uri(ServiceAddressBox.Text)
            Me.Close()
        Catch ErrorCode As Exception
            Me.DialogResult = DialogResult.None
            Select Case LastTask
                Case "ServiceAddress"
                    KryptonMessageBox.Show("Erreur : l'adresse de service n'est pas correcte , vérifiez qu'elle correspond au modèle suivant :" & vbCrLf & "net.tcp://<ip>:<port>/<service>", "Erreur", MessageBoxButtons.OK)
            End Select
        End Try
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Me.Close()
    End Sub
End Class
