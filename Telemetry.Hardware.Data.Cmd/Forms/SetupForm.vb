Imports System.Windows.Forms
Imports ComponentFactory.Krypton.Toolkit

Public Class SetupForm
    Private Sub ServiceAddressLbl_Click(sender As Object, e As EventArgs) Handles ServiceAddressLbl.Click

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshComPorts()
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Dim LastTask As String = ""
        Try
            LastTask = "ServiceAddress"
            API.HostAddress = New Uri(ServiceAddressBox.Text)
            LastTask = "ServiceConnect"
            API.Init(False)
            API.Instance.DoNothing()
            Me.Close()
        Catch ErrorCode As Exception
            'Me.DialogResult = DialogResult.None
            Select Case LastTask
                Case "ServiceAddress"
                    KryptonMessageBox.Show("Erreur : l'adresse de service n'est pas correcte , vérifiez qu'elle correspond au modèle suivant :" & vbCrLf & "net.tcp://<ip>:<port>/<service>", "Erreur", MessageBoxButtons.OK)
                Case "ServiceConnect"
                    KryptonMessageBox.Show("Erreur : impossible de se connecter au service via l'adresse """ & ServiceAddressBox.Text & """", "Erreur", MessageBoxButtons.OK)
            End Select
        End Try




        Try
            Globals.CommandPrompt.Arduino.Close()
        Catch ErrorCode As Exception
            MsgBox("Erreur")
        End Try
        Globals.CommandPrompt.Arduino.PortName = ComPortCBox.SelectedItem
        Globals.CommandPrompt.SerialWorker.RunWorkerAsync()
        Globals.DATA_VALIDATED = True
        Me.Close()
    End Sub

    Private Sub ComPortRefresh_Click(sender As Object, e As EventArgs) Handles ComPortRefresh.Click
        RefreshComPorts()
    End Sub

    Private Sub RefreshComPorts()
        With ComPortCBox
            .Items.Clear()
            For Each Port As String In My.Computer.Ports.SerialPortNames
                .Items.Add(Port)
            Next
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
    End Sub
End Class