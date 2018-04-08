Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports Telemetry.Reusable
Imports Telemetry.Xml.Data.Data
Imports Telemetry.Xml.Data
Imports Telemetry.Xml
Imports Telemetry.Xml.Serializer

Public Class ConsoleWindow
    Public AllowClose As Boolean = False

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
        CommandBox.Select()
        CommandBox.Focus()
    End Sub

    Public Delegate Sub OutputCallback(ByVal Parameters As String())

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

        Append(AddressOf ConsoleCallbacks.LogCommand, {Command})

        CommandParser.Parse(Command)
    End Sub

    Public Sub Append(ByVal WriteCallback As OutputCallback, ParamArray Parameters() As String)
        Dim Scroll As SCROLLINFO
        Scroll.cbSize = Marshal.SizeOf(GetType(SCROLLINFO))
        Scroll.fMask = SIF_RANGE Or SIF_PAGE Or SIF_POS
        GetScrollInfo(Output.RichTextBox.Handle, SB_VERT, Scroll)

        WriteCallback(Parameters)

        If Scroll.nPos >= Scroll.nMax - Scroll.nPage Then
            Output.SelectionStart = Output.TextLength
            Output.ScrollToCaret()
        End If
    End Sub

    Private Sub ConsoleWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Buffer = New List(Of String) : Buffer.Clear()
        Globals.CommandPrompt = Me
        Dim SERIALIZER As GenericSerializer(Of HelpFile) = New GenericSerializer(Of HelpFile)()
        Dim HelpFilePath As String = Application.StartupPath & "\Help\Hardware.xml"
        If File.Exists(HelpFilePath) Then
            Globals.Help = SERIALIZER.Deserialize(HelpFilePath)
        Else
            Globals.Help = Nothing
        End If
        Append(AddressOf ConsoleCallbacks.Init, {""})
    End Sub

    Private Sub EffacerToutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EffacerToutToolStripMenuItem.Click
        CommandParser.Parse("clear")
    End Sub

    Private Sub RevenirÀLaDernièreLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevenirÀLaDernièreLigneToolStripMenuItem.Click
        Output.SelectionStart = Output.TextLength
        Output.ScrollToCaret()
    End Sub

    Private Sub OuvrirLesLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLesLogsToolStripMenuItem.Click
        CommandParser.Parse("log")
    End Sub

    Public Buffer As List(Of String)

    Private Sub SerialWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SerialWorker.DoWork
        Arduino.Open()
        While Me.Visible
            For Each Element As String In New List(Of String)(Buffer)
                Buffer.Remove(Element)
                Append(AddressOf ConsoleCallbacks.LogMessage, Element)
            Next
            Tools.Wait(0.1)
        End While
        Arduino.Close()
    End Sub

    Private Sub Arduino_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Arduino.DataReceived
        Buffer.Add(Arduino.ReadLine)
    End Sub

    Private Sub ConsoleWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub ConsoleWindow_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub MiseEnRouteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseEnRouteToolStripMenuItem.Click
        Parse("setup")
    End Sub

    Private Sub AideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideToolStripMenuItem.Click
        Parse("help")
    End Sub
End Class