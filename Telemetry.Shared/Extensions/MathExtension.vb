Imports System.Runtime.CompilerServices

Module MathExtension
    <Extension()>
    Public Function Clamp(ByVal Value As Single, ByVal Min As Single, ByVal Max As Single) As Single
        If Value < Min Then
            Return Min
        End If
        If Value > Max Then
            Return Max
        End If
        Return Value
    End Function
End Module
