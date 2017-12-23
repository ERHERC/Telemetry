Module Application
    Private MainMenu As ConsoleMenu
    Sub Main()
        Try
            Console.WindowWidth = 90
            MainMenu = New UnitTestsMenu()
            MainMenu.Run()
            Call New UnitTestsMenu().Run()
        Catch ErrorCode As Exception
            With ErrorCode
                Console.WriteLine("===== Error caught =====")
                Console.WriteLine(.Source)
                Console.WriteLine(.StackTrace)
                Console.WriteLine(.HResult)
                Console.WriteLine(.Message)
                Console.WriteLine(.TargetSite)
                Console.ReadKey()
            End With
        Finally

        End Try
    End Sub
End Module
