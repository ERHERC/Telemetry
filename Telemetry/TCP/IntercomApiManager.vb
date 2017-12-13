Imports System.Data
Imports System.ComponentModel
Imports System.ServiceModel

Module IntercomApiManager
    Public ServiceRunning As Boolean = False
    Public ServiceInstance As ServiceHost = Nothing
    Public ServiceAddress As Uri = New Uri("net.tcp://localhost:2202/TelemetryService")
    Public Binding As NetTcpBinding


    Public Sub StartAPI()
        If Not ServiceRunning Then
            Try
                With FormsManager.MainForm.TaskDialog
                    '.Show()
                    Binding = New NetTcpBinding()
                    ServiceInstance = New ServiceHost(GetType(Intercom), ServiceAddress)
                    ServiceInstance.AddServiceEndpoint(GetType(IntercomInterface), Binding, ServiceAddress)
                    ServiceInstance.Open()
                    ServiceRunning = True
                End With
            Catch ErrorCode As Exception
                MsgBox(ErrorCode.Message & vbCrLf & vbCrLf & ErrorCode.StackTrace, , ErrorCode.HResult)
            Finally
                'FormsManager.MainForm.TaskDialog.Close()
            End Try
        End If
    End Sub

    Public Sub StopAPI()
        If ServiceRunning Then
            Try
                With FormsManager.MainForm.TaskDialog
                    '.Show()
                    ServiceRunning = False
                    ServiceInstance.Close()
                    '.Close()
                End With
            Catch ErrorCode As Exception

            Finally
                'FormsManager.MainForm.TaskDialog.Close()
            End Try
        End If
    End Sub



    Public Function APIState() As Boolean
        Return ServiceRunning
    End Function
End Module
