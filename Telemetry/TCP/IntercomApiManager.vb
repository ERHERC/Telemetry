Imports System.Data
Imports System.ComponentModel
Imports System.ServiceModel

Module IntercomApiManager
    Private ServiceRunning As Boolean = False
    Public ServiceInstance As ServiceHost = Nothing
    Public ServiceAddress As Uri = New Uri("net.tcp://localhost:2202/TelemetrySvc")
    Public Binding As NetTcpBinding


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
                'Finally
                'FormsManager.MainForm.TaskDialog.Close()
            End Try
        End If
    End Sub

    Public Sub StopAPI()
        If ServiceRunning Then
            Try
                ServiceRunning = False
                ServiceInstance.Abort()
                ServiceInstance.Close()
                'KryptonMessageBox.Show("Arret du service TCP terminé", "Service TCP", MessageBoxButtons.OK)
            Catch ErrorCode As Exception

            Finally

            End Try
        End If
    End Sub

    Public Function APIState() As Boolean
        Return ServiceRunning
    End Function
End Module
