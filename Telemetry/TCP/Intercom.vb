Imports System.ServiceModel
Imports Telemetry

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Intercom : Implements IntercomInterface
    Public Sub SendMessage(Command As String, ParamArray Parameters() As String) Implements IntercomInterface.SendMessage


    End Sub

    Public Sub SetBatteryPercentage(Value As Integer) Implements IntercomInterface.SetBatteryPercentage

    End Sub

    Public Sub SetMaxSpeed(Value As Double) Implements IntercomInterface.SetMaxSpeed
        Globals.MainForm.MaxSpeed = Value
        SetSpeed(Globals.MainForm.Speed)
        'Globals.Mainform.SpeedLbl.Invalidate
    End Sub

    Public Sub SetPing(Value As Integer) Implements IntercomInterface.SetPing

    End Sub

    Public Sub SetSpeed(Value As Double) Implements IntercomInterface.SetSpeed
        Globals.MainForm.Speed = Value
        Dim SpeedKMH = Math.Floor(Math.Max(Math.Min(Math.Ceiling((Globals.MainForm.Speed / Globals.MainForm.MaxSpeed)), Globals.MainForm.MaxSpeed), 0) * 10) / 10
        Dim SpeedMS = Math.Floor((SpeedKMH / 3.6D) * 10) / 10
        Globals.MainForm.SpeedLbl.Text = SpeedKMH & " Km/H" & vbCrLf & "(" & SpeedMS & " M/S)"
        Globals.MainForm.SpeedLbl.Invalidate()
    End Sub

    Public Sub ShowSignalLost(Value As Boolean) Implements IntercomInterface.ShowSignalLost
        Globals.MainForm.LostSignalPanel.Visible = Value
    End Sub

    Public Sub ShowSlowDown(Value As Boolean) Implements IntercomInterface.ShowSlowDown
        Globals.MainForm.SlowDownAlertBox.Visible = Value
    End Sub
End Class
