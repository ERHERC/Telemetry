Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Imports Telemetry.Reusable
Imports ComponentFactory.Krypton.Toolkit

Module CommandParser
    Public Sub Parse(ByVal Command As String)
        Dim Commands() As String = Command.Split(" "c)
        If Commands.Count > 0 Then
            Select Case Commands(0).ToLower
                Case "clear", "cls"
                    Execute.Clear()
                Case "log", "logs"
                    Execute.Log()
                Case "setup", "init", "initialize"
                    Execute.Setup()
                Case "restart", "reboot"
                    Execute.Restart({Command})
                Case "stop", "quit", "exit", "shutdown"
                    Execute.Shutdown({Command})
                Case "help"
                    If Commands.Count > 1 Then
                        Select Case Commands(1)
                            Case ""
                        End Select
                    Else
                        Parse("help $all")
                    End If
                Case Else
                    Execute.CommandError({Command})
            End Select
        End If
    End Sub
End Module

Partial Module Execute
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

    Public Sub Setup()
        Call New SetupForm().ShowDialog()
    End Sub

    Public Sub Restart(ByVal Parameters As String())
        Write(AddressOf ConsoleCallbacks.Restart, {Parameters(0)})
        If KryptonMessageBox.Show("Voulez-vous vraiment redémarrer ?", "Redémarrer ?", MessageBoxButtons.YesNo).ToString = "Yes" Then
            Globals.CommandPrompt.AllowClose = True
            Application.Restart()
        End If
    End Sub

    Public Sub Shutdown(ByVal Parameters As String())
        Write(AddressOf ConsoleCallbacks.Shutdown, {Parameters(0)})
        If KryptonMessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter ?", MessageBoxButtons.YesNo).ToString = "Yes" Then
            Globals.CommandPrompt.AllowClose = True
            Application.Exit()
        End If
    End Sub

    Public Sub CommandError(ByVal Parameters As String())
        Write(AddressOf ConsoleCallbacks.CommandError, {Parameters(0)})
    End Sub
End Module

Partial Module Execute
    Public Sub Write(Callback As ConsoleWindow.OutputCallback, Parameters As String())
        Callback(Parameters)
    End Sub
End Module