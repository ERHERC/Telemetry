Module Application
    Private MainMenu As ConsoleMenu
    Sub Main()
        Try
            Console.WindowWidth = 90
            MainMenu = New UnitTestsMenu()
            MainMenu.Run()
            'Call New UnitTests.ThemesExtractImages().Run(System.Windows.Forms.Application.StartupPath)
            Call New UnitTestsMenu().Run()
        Catch ErrorCode As Exception
            With ErrorCode
                Console.WriteLine("===== Error caught =====")
                Console.WriteLine(.Source)
                Console.WriteLine(.StackTrace)
                Console.WriteLine(.HResult)
                Console.WriteLine(.Message)
                Console.WriteLine(.TargetSite)
            End With
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
