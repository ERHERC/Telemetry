Imports System.IO
Imports System.Text

Partial Public NotInheritable Class UserInterface
    Public Shared ReadOnly RoyalBlue As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(UIThemes.Themes.RoyalBlue))
    Public Shared ReadOnly Gold As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(UIThemes.Themes.Gold))
    Public Shared ReadOnly Crimson As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(UIThemes.Themes.Crimson))
    Public Shared ReadOnly OliveDrab As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(UIThemes.Themes.OliveDrab))
    Public Shared ReadOnly Black As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(UIThemes.Themes.Black))
End Class
