Imports Telemetry.Reusable

Public MustInherit Class UnitTest : Implements IUnitTest
    MustOverride Property Category As String Implements IUnitTest.Category
    MustOverride Property Name As String Implements IUnitTest.Name
    MustOverride Sub Run(AppStartPath As String) Implements IUnitTest.Run
End Class
