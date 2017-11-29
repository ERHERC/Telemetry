Imports Telemetry

Public Class Intercom : Implements IntercomInterface
    Public Sub SendMessage(Command As String, Parameter As String) Implements IntercomInterface.SendMessage


    End Sub

    Public Sub SetBatteryPercentage(Value As Integer) Implements IntercomInterface.SetBatteryPercentage

    End Sub

    Public Sub SetMaxSpeed(Value As Double) Implements IntercomInterface.SetMaxSpeed

    End Sub

    Public Sub SetPing(Value As Integer) Implements IntercomInterface.SetPing

    End Sub

    Public Sub SetSpeed(Value As Double) Implements IntercomInterface.SetSpeed

    End Sub

    Public Sub ShowSignalLost(Visible As Boolean) Implements IntercomInterface.ShowSignalLost

    End Sub

    Public Sub ShowSlowDown(Visible As Boolean) Implements IntercomInterface.ShowSlowDown

    End Sub
End Class
