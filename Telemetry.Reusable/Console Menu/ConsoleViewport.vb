Public Class ConsoleViewport
    Public Start As Integer = 0
    Public Size As Integer = 0
    Public Position As Integer = 0

    Public Sub New(start As Integer, size As Integer, Optional position As Integer = 0)
        Me.Start = start
        Me.Size = size
        Me.Position = position
    End Sub
End Class
