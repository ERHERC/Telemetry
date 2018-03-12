Imports ComponentFactory.Krypton.Toolkit

Namespace UnitTests
    Public Class ThemesExtractImages : Inherits UnitTest : Implements IUnitTest
        Public Overrides Property Name As String = "" Implements IUnitTest.Name
        Public Overrides Property Category As String = "" Implements IUnitTest.Category

        Public Overrides Sub Run(AppStartPath As String) Implements IUnitTest.Run
            On Error Resume Next
            Dim Palette As KryptonPalette = New KryptonPalette()
            Palette.Import(Themes.UserInterface.RoyalBlue)
            If Not Directory.Exists(AppStartPath & "\Data") Then Directory.CreateDirectory(AppStartPath & "\Data")
            With Palette.ButtonSpecs
                .FormClose.Image.Save(AppStartPath & "\Data\FormClose.png", Imaging.ImageFormat.Png)
                .FormMax.Image.Save(AppStartPath & "\Data\FormMax.png", Imaging.ImageFormat.Png)
                .FormMin.Image.Save(AppStartPath & "\Data\FormMin.png", Imaging.ImageFormat.Png)
                .FormRestore.Image.Save(AppStartPath & "\Data\FormRestore.png", Imaging.ImageFormat.Png)
            End With
        End Sub
    End Class
End Namespace