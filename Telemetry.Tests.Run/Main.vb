Module Application

    Sub Main()
        Try
            LoadTests()
            'Call New UnitTests.ThemesExtractImages().Run(System.Windows.Forms.Application.StartupPath)
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

    Sub LoadTests()

    End Sub
End Module
