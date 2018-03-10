Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class ConsoleWindow
    Private Const SB_VERT As Integer = &H1
    Private Const SIF_RANGE As Integer = &H1
    Private Const SIF_PAGE As Integer = &H2
    Private Const SIF_POS As Integer = &H4

    <DllImport("user32.dll", EntryPoint:="GetScrollInfo")>
    Private Shared Function GetScrollInfo(ByVal hwnd As IntPtr, ByVal nBar As Integer, ByRef lpsi As SCROLLINFO) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure SCROLLINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public nMin As Integer
        Public nMax As Integer
        Public nPage As Integer
        Public nPos As Integer
        Public nTrackPos As Integer
    End Structure

    Private Sub Output_KeyDown(sender As Object, e As KeyEventArgs) Handles Output.KeyDown
        e.Handled = True
        e.SuppressKeyPress = True
    End Sub

    Private Sub CommandBox_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles CommandBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            Command()
        End If
    End Sub

    Private Sub ExecuteBtn_Click(sender As Object, e As EventArgs) Handles ExecuteBtn.Click
        Command()
    End Sub

    Private Function Cleanup() As String
        'CommandBox text cleanup
        Dim Command As String = CommandBox.Text
        CommandBox.Text = ""
        CommandBox.Select()
        CommandBox.Focus()
        Return Command
    End Function

    Private Sub Command()
        Dim Command = Cleanup()

        Dim ScrollToBottom As Boolean = False
        ScrollToBottom = CBool(Output.)

        Output.Write("User issued command : ", Color.Teal, FontStyle.Bold)
        Output.Write(Command, Color.White, FontStyle.Regular)
        Output.Write(vbCrLf, Color.Transparent, FontStyle.Regular)
    End Sub
End Class