Public Class MainForm
    Public DATA_VALIDATED As Boolean = False

    Private Sub PingWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PingWorker.DoWork
        While Me.Visible
            Try
                API.Instance.DoNothing()
            Catch ErrorCode As Exception
                KryptonMessageBox.Show("Info : le service sur l'adresse """ & API.HostAddress.ToString() & """ à cessé d'emmettre , fermeture ...", "Service", MessageBoxButtons.OK)
                Application.Restart()
            End Try
            Tools.Wait(0.25)
        End While
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        StylePalette.Import(Themes.UserInterface.Crimson)
        Globals.MainForm = Me
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim Setup As SetupForm = New SetupForm
        Setup.BringToFront()
        Setup.Select()
        Setup.ShowDialog()
        If DATA_VALIDATED Then
            Me.Visible = True
            Me.Opacity = 1
            Me.ShowInTaskbar = True
            API.Init(True)
            PingWorker.RunWorkerAsync()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BatteryBtn_Click(sender As Object, e As EventArgs) Handles BatteryBtn.Click
        If API.Init(True) Then
            API.Instance.SetBattery(CDbl(BatteryUD.Value))
        End If
    End Sub

    Private Sub PingBtn_Click(sender As Object, e As EventArgs) Handles PingBtn.Click
        If API.Init(True) Then
            API.Instance.SetPing(CInt(PingUD.Value))
        End If
    End Sub

    Private Sub SpeedBtn_Click(sender As Object, e As EventArgs) Handles SpeedBtn.Click
        If API.Init(True) Then
            API.Instance.SetSpeed(CDbl(SpeedUD.Value))
        End If
    End Sub

    Private Sub DistanceBtn_Click(sender As Object, e As EventArgs) Handles DistanceBtn.Click
        If API.Init(True) Then
            API.Instance.SetDistance(CDbl(DistanceUD.Value))
        End If
    End Sub
End Class