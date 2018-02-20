Imports System.ServiceModel
Imports Telemetry

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Intercom : Implements IntercomInterface
    Public Sub SendMessage(Command As String, ParamArray Parameters() As String) Implements IntercomInterface.SendMessage

    End Sub

    Public Sub SetBatteryPercentage(Value As Integer) Implements IntercomInterface.SetBatteryPercentage
        Globals.MainForm.BatteryBarResizer.ColumnStyles(1).SizeType = SizeType.Percent
        Globals.MainForm.BatteryBarResizer.ColumnStyles(1).Width = Value
    End Sub

    Public Sub SetPing(Value As Integer) Implements IntercomInterface.SetPing

    End Sub

    Public Sub SetSpeed(Value As Double) Implements IntercomInterface.SetSpeed

    End Sub

    Public Function GetMainForm() As VisualizerForm Implements IntercomInterface.GetMainForm
        Return Globals.MainForm
    End Function
End Class
