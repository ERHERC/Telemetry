Imports System.ServiceModel
Imports Telemetry

Module API
    Public Endpoint As EndpointAddress
    Public ServiceAddress As NetTcpBinding
    Public Factory As ChannelFactory(Of IntercomInterface)
    Public ServiceInstance As IntercomInterface
    Public Initiated As Boolean = False

    Public Function Init(ShowError As Boolean) As Boolean
        Try
            Endpoint = New EndpointAddress(New Uri("net.tcp://localhost:2202/TelemetrySvc"))
            ServiceAddress = New NetTcpBinding()
            Factory = New ChannelFactory(Of IntercomInterface)(ServiceAddress, Endpoint)
            ServiceInstance = Factory.CreateChannel()
            Initiated = True
            Return True
        Catch ErrorCode As Exception
            If ShowError Then MsgBox(ErrorCode.Message & vbCrLf & vbCrLf & ErrorCode.StackTrace, , ErrorCode.HResult)
            Initiated = False
            Return False
        End Try
    End Function

    Public Function Instance() As IntercomInterface
        If Initiated Then Return ServiceInstance Else Throw New Exception("Aucune instance de l'API n'est actuellement démarrée ...") : Return Nothing
    End Function
End Module
