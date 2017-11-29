Imports System.Data
Imports System.ComponentModel
Imports System.ServiceModel

Module IntercomApiManager
    Private ServiceRunning As Boolean = False
    Private ServiceInstance As ServiceHost = Nothing
    Private ServiceAddress As Uri = New Uri("net.tcp://localhost:2202/TelemetryService")
    Private Binding As NetTcpBinding


    Public Sub StartAPI()
        If Not ServiceRunning Then
            Try
                Binding = New NetTcpBinding()
                ServiceInstance = New ServiceHost(GetType(Intercom), ServiceAddress)
                ServiceInstance.AddServiceEndpoint(GetType(IntercomInterface), Binding, ServiceAddress)

                ServiceInstance.Open()

                ServiceRunning = True
            Catch ErrorCode As Exception
                MsgBox(ErrorCode.Message & vbCrLf & vbCrLf & ErrorCode.StackTrace, , ErrorCode.HResult)
            End Try
        End If
    End Sub

    Public Sub StopAPI()
        If ServiceRunning Then
            ServiceRunning = False
            ServiceInstance.Close()
        End If
    End Sub

    Public Function APIState() As Boolean
        Return ServiceRunning
    End Function
End Module
