Imports System.Runtime.CompilerServices

Module RandomExtension
    <Extension()>
    Public Function NextSingle(ByVal Min As Single, ByVal Max As Single, ByVal Decimals As Integer) As Single
        Return Math.Round(Globals.RNG.NextDouble() * (Max - Min) + Min, Decimals)
    End Function
End Module
