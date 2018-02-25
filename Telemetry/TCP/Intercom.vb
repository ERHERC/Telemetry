Imports System.ServiceModel
Imports Telemetry

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Intercom : Implements IntercomInterface

    Public Sub SetBattery(Value As Double) Implements IntercomInterface.SetBattery
        FormsManager.MainForm.BatteryBarResizer.RowStyles(0).SizeType = SizeType.Percent
        FormsManager.MainForm.BatteryBarResizer.RowStyles(1).SizeType = SizeType.Percent
        FormsManager.MainForm.BatteryBarResizer.RowStyles(0).Height = 100 - Value
        FormsManager.MainForm.BatteryBarResizer.RowStyles(1).Height = Value
    End Sub

    Public Sub SetPing(Value As Integer) Implements IntercomInterface.SetPing
        FormsManager.MainForm.PingLabel.Text = CStr(Value) & " ms"
    End Sub

    Public Sub SetSpeed(ByVal Value As Double) Implements IntercomInterface.SetSpeed
        FormsManager.MainForm.SpeedLabel.Text = CStr(Value) & " KM/h"
    End Sub
End Class
