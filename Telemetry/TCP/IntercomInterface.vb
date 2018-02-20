Imports System.ServiceModel

<ServiceContract()>
Public Interface IntercomInterface
    <OperationContract()>
    Sub SendMessage(Command As String, ParamArray Parameters() As String)

    <OperationContract()>
    Sub SetBatteryPercentage(Value As Integer)

    <OperationContract()>
    Sub SetSpeed(Value As Double)

    <OperationContract()>
    Sub SetPing(Value As Integer)

    <OperationContract()>
    Function GetMainForm() As VisualizerForm
End Interface
