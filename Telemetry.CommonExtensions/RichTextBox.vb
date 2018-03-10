Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ComponentFactory.Krypton.Toolkit
Imports System.Drawing

Module RichTextBox

    <Extension()>
    Public Sub Write(ByVal Box As KryptonRichTextBox, ByVal Text As String, ByVal Color As Color, ByVal Style As FontStyle)
        Dim SelectionStart As Integer = Box.TextLength
        Box.AppendText(Text)
        Dim SelectionEnd As Integer = Box.TextLength
        Box.Select(SelectionStart, SelectionEnd - SelectionStart)
        Box.SelectionColor = Color
        Dim TextFont = CType(Box.StateCommon.Content.Font.Clone, Font)
        Box.SelectionFont = New Font(TextFont.Name, TextFont.Size, Style)
        Box.SelectionLength = 0
    End Sub
End Module
