Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Telemetry.Reusable
Imports System.Threading

Partial Module ConsoleCallbacks
    Public Sub LogCommand(ByVal Parameters As String())
        TimeStamp()
        Write("User sent command : ", Color.Teal, FontStyle.Bold)
        Write(Assemble(Parameters, " "), Color.White, FontStyle.Regular)
        Write(vbCrLf, Color.Transparent, FontStyle.Regular)
    End Sub

    Public Sub LogMessage(ByVal Parameters As String())
        TimeStamp()
        Write("Arduino sent command : ", Color.Teal, FontStyle.Bold)
        Write(Assemble(Parameters, " "), Color.White, FontStyle.Regular)
    End Sub

    Public Sub CommandError(ByVal Parameters As String())
        TimeStamp()
        Write("<ERROR> : ", Color.Red, FontStyle.Bold)
        Write("""" & Assemble(Parameters, " ") & """", Color.White, FontStyle.Bold)
        Write(" is not an internal command !" & vbCrLf, Color.White, FontStyle.Regular)
        TimeStamp()
        Write("Use the ""help"" command to get a list of all available commands" & vbCrLf, Color.YellowGreen, FontStyle.Bold)
    End Sub



    Public Sub Init(ByVal Parameters As String())
        Write("Loading ""Telemetry.Hardware.Data.Exchange""", Color.YellowGreen, FontStyle.Bold)
        Write(" [Done !]" & vbCrLf, Color.White, FontStyle.Regular)
        Write("Loading ""Telemetry.Hardware.Data.Cmd""", Color.YellowGreen, FontStyle.Bold)
        Write(" [Done !]", Color.White, FontStyle.Regular)
        For i = 0 To 2
            Write(vbCrLf, Color.Transparent, FontStyle.Underline)
        Next
        Write("Telemetry | https://github.com/NawakCreations/Telemetry" & vbCrLf, Color.GreenYellow, FontStyle.Regular)
        For i = 0 To 2
            Write(vbCrLf, Color.Transparent, FontStyle.Underline)
        Next
    End Sub

    Public Sub Restart(ByVal Parameters As String())
        TimeStamp()
        Write("<WARNING> : ", Color.Orange, FontStyle.Bold)
        Write("User attempting to restart telemetry session with command """ & Assemble(Parameters, " ") & """ !", Color.White, FontStyle.Regular)
        Write(vbCrLf, Color.White, FontStyle.Regular)
    End Sub

    Public Sub Shutdown(ByVal Parameters As String())
        TimeStamp()
        Write("<WARNING> : ", Color.Orange, FontStyle.Bold)
        Write("User attempting to shutdown telemetry session with command """ & Assemble(Parameters, " ") & """ !", Color.White, FontStyle.Regular)
        Write(vbCrLf, Color.White, FontStyle.Regular)
    End Sub

    Public Sub TimeStamp()
        Write("[" & DateTime.Now.ToString() & "] ", Color.Yellow, FontStyle.Bold)
    End Sub


End Module

Partial Module ConsoleCallbacks
    Private Sub Write(ByVal Text As String, ByVal Color As Color, ByVal Style As FontStyle)
        Globals.CommandPrompt.Output.Write(Text, Color, Style)
    End Sub

    Public Function Assemble(parameters() As String, Separator As String) As Object
        Dim Command As String = ""
        With Parameters
            If .Count > 0 Then
                Command = parameters(0)
            End If
            If .Count > 1 Then
                For I As Integer = 1 To .Count - 1
                    Command = Command & Separator & parameters(I)
                Next
            End If
        End With
        Return Command
    End Function
End Module
