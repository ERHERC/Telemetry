Imports System.Diagnostics
Imports System.Threading

Public Class MainForm
    Declare Function ShowWindow Lib "user32" (ByVal hWnd As System.IntPtr, ByVal nCmdShow As Integer) As Boolean
    Private Const SW_MINIMIZE As Integer = 6
    Private Const SW_MAXIMIZE As Integer = 3
    Private Const SW_RESTORE As Integer = 9

    Declare Function SetParent Lib "user32" (ByVal hWndChild As System.IntPtr, ByVal hWndNewParent As System.IntPtr) As System.IntPtr
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Gold)
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


    End Sub
End Class