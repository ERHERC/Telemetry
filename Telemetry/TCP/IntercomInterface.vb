Imports System.ServiceModel

<ServiceContract()>
Public Interface IntercomInterface
    <OperationContract()>
    Sub SendMessage(Command As String, ParamArray Parameters() As String)

    <OperationContract()>
    Sub ShowSlowDown(Value As Boolean)

    <OperationContract()>
    Sub ShowSignalLost(Value As Boolean)

    <OperationContract()>
    Sub SetBatteryPercentage(Value As Integer)

    <OperationContract()>
    Sub SetMaxSpeed(Value As Double)

    <OperationContract()>
    Sub SetSpeed(Value As Double)

    <OperationContract()>
    Sub SetPing(Value As Integer)

    <OperationContract()>
    Sub SetFullscreen(Value As Boolean)

    <OperationContract()>
    Function GetMainForm() As MainForm
End Interface
