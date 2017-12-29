Imports System.Reflection
Imports System.Reflection.Context
Imports System.Text

Partial Public NotInheritable Class UnitTestsMenu : Inherits ConsoleMenu
    Public Overrides Property MenuEntries As Dictionary(Of String, String)
    Public Overrides Property MenuEntry As Integer = 0

    Public Overrides Sub Create()
        MyBase.Create()
        MenuEntries = New Dictionary(Of String, String)
        For Each Test As Type In GetType(UnitTests.SampleUnitTest).Assembly.GetTypes().Where(Function(x) (x.IsPublic AndAlso x.BaseType.IsAssignableFrom(GetType(UnitTest)) AndAlso Not x = GetType(UnitTests.SampleUnitTest)))
            With Test
                MenuEntries.Add(.FullName, "UnitTest")
            End With
        Next
        MenuEntries.Add("[ Quitter ]", "MenuCommand")
    End Sub

    Public Overrides Sub Run()
        While True
            Draw()
            Input()
            If MenuEntry = Integer.MinValue Then Exit While
        End While
    End Sub

    Public Overrides Sub Draw()
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.White
        Console.Clear()
        Console.BackgroundColor = ConsoleColor.DarkGray
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Veuillez sélectionner une commande avec [ " & Chr(30) & " et " & Chr(31) & " ] et appuyez sur [ ENTER ] pour valider .")
        Console.WriteLine("Appuyez sur S pour effectuer une recherche dans la liste des tests disponibles .          ")
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.White

        'Skip 3 Lines
        For I = 0 To 3
            Console.WriteLine()
        Next

        Dim Index As Integer = 0
        For Each Entry As KeyValuePair(Of String, String) In MenuEntries
            Dim Prefix As String = "    "
            If Index = MenuEntry Then
                Prefix = "  " & Chr(16) & " "
                Select Case Entry.Value
                    Case "UnitTest"
                        Console.BackgroundColor = ConsoleColor.DarkCyan
                        Console.ForegroundColor = ConsoleColor.White
                    Case "MenuCommand"
                        Console.BackgroundColor = ConsoleColor.DarkRed
                        Console.ForegroundColor = ConsoleColor.White
                End Select

            Else
                Console.BackgroundColor = ConsoleColor.Black
                Console.ForegroundColor = ConsoleColor.White
            End If
            Console.Write(Prefix & Entry.Key)
            Dim Spaces As StringBuilder = New StringBuilder
            Spaces.Append(" "c, CInt(Clamp(Console.WindowWidth - (Entry.Key.Length + Prefix.Length), 0, Console.WindowWidth)))
            Console.WriteLine(Spaces.ToString())
            Index += 1
        Next
    End Sub

    Public Overrides Sub Input()
        Select Case Console.ReadKey().Key
            Case ConsoleKey.Escape
                MenuEntry = Integer.MinValue
            Case ConsoleKey.Enter

            Case ConsoleKey.UpArrow
                MenuEntry -= 1
                If MenuEntry < 0 Then MenuEntry = MenuEntries.Count - 1
            Case ConsoleKey.DownArrow
                MenuEntry += 1
                If MenuEntry > MenuEntries.Count - 1 Then MenuEntry = 0
        End Select
    End Sub
End Class
