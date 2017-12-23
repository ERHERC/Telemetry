Imports System.Reflection
Imports System.Reflection.Context

Partial Public NotInheritable Class UnitTestsMenu : Inherits ConsoleMenu
    Public Overrides Property MenuEntries As Dictionary(Of String, String)
    Public Overrides Property MenuEntry As Integer = 0

    Public Overrides Sub Create()
        MyBase.Create()
        MenuEntries = New Dictionary(Of String, String)
        For Each Test As Type In GetType(UnitTests.SampleUnitTest).Assembly.GetTypes().Where(Function(x) (x.IsPublic AndAlso x.BaseType.IsAssignableFrom(GetType(UnitTest)) AndAlso Not x = GetType(UnitTests.SampleUnitTest)))
            With Test
                'Console.WriteLine(.FullName)
                MenuEntries.Add(.FullName, .Name)
            End With
        Next
    End Sub

    Public Overrides Sub Run()
        While True
            Draw()
            Input()
        End While
    End Sub

    Public Overrides Sub Draw()
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.White
        Console.Clear()
        Console.WriteLine("Veuillez sélectionner une commande avec [ " & Chr(30) & " et " & Chr(31) & " ] et appuyez sur [ ENTER ] pour valider .")

        Dim Index As Integer = 0
        For Each Entry As KeyValuePair(Of String, String) In MenuEntries
            If Index = MenuEntry Then



            End If

        Next
    End Sub

    Public Overrides Sub Input()

    End Sub
End Class
