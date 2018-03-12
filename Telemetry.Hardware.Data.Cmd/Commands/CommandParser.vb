Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports Telemetry.Reusable

Module CommandParser
    Public Sub Parse(ByVal Command As String)
        Dim Commands() As String = Command.Split(" "c)
        If Commands.Count > 0 Then
            Select Case Commands(0).ToLower
                Case "clear", "cls"
                    Execute.Clear()
                Case "log", "logs"
                    Execute.Log()
                Case "setup"
                    Call New SetupForm().ShowDialog()
            End Select
        End If
    End Sub
End Module

Module Execute
    Public Sub Clear()
        Globals.CommandPrompt.Output.Rtf = ""
    End Sub

    Public Sub Log()
        Globals.CommandPrompt.OuvrirLesLogsToolStripMenuItem.Enabled = False
        If Not (Directory.Exists(Application.StartupPath & "\Logs")) Then
            Directory.CreateDirectory(Application.StartupPath & "\Logs")
        End If
        Dim Tries As Integer = 1
FileName:
        Dim FileName = DateTime.Now.ToString().Replace(":"c, "-").Replace("/"c, "-") & ".html"
        If File.Exists(Application.StartupPath & "\Logs\" & FileName) Then
            If Tries > 5 Then GoTo GiveUp
            Tools.Wait(1)
            Tries += 1
            GoTo FileName
        End If
        Using File As StreamWriter = New StreamWriter(Application.StartupPath & "\Logs\" & FileName, False, Encoding.UTF8)
            File.WriteLine("<style>")
            File.WriteLine("body,html {background-color: darkgray;color: white;}")
            File.WriteLine("</style>")
            File.WriteLine("<h3>Fichier """ & FileName & """</h3>")
            For Each Line As String In Globals.CommandPrompt.Output.Lines
                File.Write("<p>")
                File.Write(Line)
                File.WriteLine("</p>")
            Next
        End Using
        Process.Start("""" & Application.StartupPath & "\Logs\" & FileName & """")
GiveUp:
        Globals.CommandPrompt.OuvrirLesLogsToolStripMenuItem.Enabled = True
    End Sub


End Module
