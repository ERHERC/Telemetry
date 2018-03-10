Imports System.Diagnostics
Imports System.Threading
Imports Telemetry.Hardware.Data.Cmd

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Gold)
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MDIManager.Console = New ConsoleWindow
        With MDIManager.Console
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
End Class