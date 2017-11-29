Public Interface IntercomInterface
    Sub SendMessage(Command As String, ParamArray Parameters() As String)
    Sub ShowSlowDown(Value As Boolean)
    Sub ShowSignalLost(Value As Boolean)
    Sub SetBatteryPercentage(Value As Integer)
    Sub SetMaxSpeed(Value As Double)
    Sub SetSpeed(Value As Double)
    Sub SetPing(Value As Integer)
End Interface
