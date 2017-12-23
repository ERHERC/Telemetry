Public Interface IUnitTest
    Property Name As String
    Property Category As String
    Sub Run(AppStartPath As String)
End Interface