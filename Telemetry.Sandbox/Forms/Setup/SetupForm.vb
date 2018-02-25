Public Class SetupForm
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Dim LastTask As String = ""
        Try
            LastTask = "ServiceAddress"
            API.HostAddress = New Uri(ServiceAddressBox.Text)
            Globals.MainForm.DATA_VALIDATED = True
            Me.Close()
        Catch ErrorCode As Exception
            Me.DialogResult = DialogResult.None
            Select Case LastTask
                Case "ServiceAddress"
                    KryptonMessageBox.Show("Erreur : l'adresse de service n'est pas correcte , vérifiez qu'elle correspond au modèle suivant :" & vbCrLf & "net.tcp://<ip>:<port>/<service>", "Erreur", MessageBoxButtons.OK)
            End Select
        End Try
    End Sub
End Class
