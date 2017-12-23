Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic

Partial Public NotInheritable Class Tools
    Public Shared Function RandomText(ByVal Length As Integer) As String
        Dim Output As StringBuilder = New StringBuilder
        For I = 1 To Length
            Output.Append(Chr(Globals.RNG.Next(0, 200)))
        Next
        Return Output.ToString
    End Function

    Public Function RandomNumbers(ByVal Length As Integer) As String
        Dim Output As StringBuilder = New StringBuilder
        For I = 1 To Length
            Output.Append(Globals.HEX(Globals.RNG.Next(0, 15)))
        Next
        Return Output.ToString
    End Function

    Public Sub WriteSlow(ByVal Text As String, ByVal Delay As Double)
        For Each Symbol As Char In Text
            Console.Write(Symbol)
            Wait(Delay)
        Next
    End Sub

    Public Sub WriteWordSlow(ByVal Text As String, ByVal Delay As Double)
        For Each Word As Char In Text.Split(" "c)
            Console.Write(Word)
            Wait(Delay)
        Next
    End Sub

    Public Shared Sub WriteFull(ByVal Text As String)
        Dim Spaces As StringBuilder = New StringBuilder
        Spaces.Append(" "c, CInt(Clamp((Console.BufferWidth - 1) - (Text.Length + Console.CursorLeft), 0, 100)))
        Console.ForegroundColor = Globals.FRGDCOL
        Console.BackgroundColor = Globals.BCKGDCOL
        Console.Write(Text)
        Console.ForegroundColor = Globals.ALTFRGDCOL
        Console.BackgroundColor = Globals.ALTBCKGDCOL
        Console.Write(Spaces)
    End Sub

    Public Shared Sub WriteMultiline(ByVal Text As String)
        Dim Left = Console.CursorLeft
        For Each Line As String In Text.Split(vbCrLf)
            Console.CursorLeft = Left
            Console.WriteLine(Line)
        Next
    End Sub

    Public Shared Sub WriteMultilineSkipSpaces(ByVal Text As String)
        Dim Left = Console.CursorLeft
        For Each Line As String In Text.Split(vbCrLf)
            Console.CursorLeft = Left
            For Each Letter As Char In Line
                If Not (Letter = " "c) Then
                    Console.Write(Letter)
                Else
                    Console.CursorLeft += 1
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Shared Sub WriteMultilineSkipSpacesFull(ByVal Text As String)
        Console.ForegroundColor = Globals.FRGDCOL
        Console.BackgroundColor = Globals.FRGDCOL
        Dim Left = Console.CursorLeft
        For Each Line As String In Text.Split(vbCrLf)
            Console.CursorLeft = Left
            For Each Letter As Char In Line
                If Not (Letter = " "c) Then

                    Console.Write(Letter)
                Else
                    Console.CursorLeft += 1

                End If
            Next
            Console.WriteLine()
        Next
        Console.ForegroundColor = Globals.FRGDCOL
        Console.BackgroundColor = Globals.BCKGDCOL
    End Sub

    Public Shared Sub WritePixel(ByVal Color As ConsoleColor)
        Dim BCKG As ConsoleColor = Console.BackgroundColor
        Dim FRG As ConsoleColor = Console.ForegroundColor
        Console.BackgroundColor = Color
        Console.ForegroundColor = Color
        Console.Write(" "c)
        Console.BackgroundColor = BCKG
        Console.ForegroundColor = FRG
    End Sub
End Class