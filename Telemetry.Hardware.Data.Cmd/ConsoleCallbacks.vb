Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices

Partial Module ConsoleCallbacks
    Public Sub LogCommand(ByVal Parameters As String())
        Write("[" & DateTime.Now.ToString() & "] ", Color.Yellow, FontStyle.Bold)
        Write("User sent command : ", Color.Teal, FontStyle.Bold)
        Write(Parameters(0), Color.White, FontStyle.Regular)
        Write(vbCrLf, Color.Transparent, FontStyle.Regular)
    End Sub


End Module

Partial Module ConsoleCallbacks
    Private Sub Write(ByVal Text As String, ByVal Color As Color, ByVal Style As FontStyle)
        Globals.CommandPrompt.Output.Write(Text, Color, Style)
    End Sub
End Module
