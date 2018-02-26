Imports System.ServiceModel

<ServiceContract()>
Public Interface IntercomInterface
    <OperationContract()>
    Sub DoNothing()
    <OperationContract()>
    Sub SetBattery(ByVal Value As Double)
    <OperationContract()>
    Sub SetPing(ByVal Value As Integer)
    <OperationContract()>
    Sub SetSpeed(ByVal Value As Double)
End Interface
