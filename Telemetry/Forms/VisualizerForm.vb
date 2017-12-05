Imports VB = Microsoft.VisualBasic

Public Class VisualizerForm
    Public DATA_VALIDATED As Boolean = False

    Public SecretCode As Queue(Of Keys)
    Private LastKeyStroke As Double = 0

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (VB.Timer - LastKeyStroke) > 1D Then SecretCode.Clear()
        LastKeyStroke = VB.Timer
        SecretCode.Enqueue(keyData)
        EasterEggCipher.Scan(SecretCode)

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' .Add any initialization after the InitializeComponent() call.
        SecretCode = New Queue(Of Keys)
    End Sub
    Private Sub VisualizerForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.Visible Then MessagesPanel.Visible = Not Me.Width < 700
        If Not PanelManager.Battery Is Nothing Then PanelManager.Battery.Visible = Not Me.Width < 440
        If Me.Width < 980 Then
            Me.BottomBarLayoutManager.ColumnStyles(2).SizeType = SizeType.Absolute
            Me.BottomBarLayoutManager.ColumnStyles(2).Width = 0
        Else
            Me.BottomBarLayoutManager.ColumnStyles(2).SizeType = SizeType.Percent
            Me.BottomBarLayoutManager.ColumnStyles(2).Width = 50%
        End If

        If Me.Height < 500 Then
            BatteryIcon.Visible = False
            BatteryPanel.SetRow(BatteryBarOutterBorder, 0)
            BatteryPanel.SetRowSpan(BatteryBarOutterBorder, 3)
        Else
            BatteryIcon.Visible = True
            BatteryPanel.SetRow(BatteryBarOutterBorder, 1)
            BatteryPanel.SetRowSpan(BatteryBarOutterBorder, 1)
        End If
        'MessagesPopupBtn.Visible = Me.Width < 700
    End Sub

    Private Sub VisualizerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelManager.VideoOutput = Me.VideoOutputPanel
        PanelManager.Messages = Me.MessagesContent
        PanelManager.Battery = Me.BatteryPanel
        FormsManager.MainForm = Me
        FormsManager.Messages = New MessagesPopup()
        FormsManager.Startup = New StartupForm()
        FormsManager.Startup.ShowDialog()

        If DATA_VALIDATED Then
            Me.Opacity = 1
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
        Else
            Me.Close()
        End If


    End Sub

    Private Sub MessagesPopupBtn_Click(sender As Object, e As EventArgs) Handles MessagesPopupBtn.Click
        Togglemessages(PanelToggleArguments.NoSet)
        FormsManager.Messages.Visible = Not FormsManager.Messages.Visible
    End Sub

    Private Sub Togglemessages(Action As PanelToggleArguments)
        Select Case Not FormsManager.Messages.Visible
            Case True
                FormsManager.Messages.MainPanel.Controls.Add(PanelManager.Messages)
                If MessagesPanel.Visible Then Libraries.Tools.Wait(1)
                MessagesPanel.Visible = False
            Case False
                Me.MessagesPanel.Controls.Add(PanelManager.Messages)
                PanelManager.Messages.BringToFront()
                MessagesPanel.Visible = Not Me.Width < 700
        End Select
    End Sub

    Private Sub VisualizerForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'MsgBox(e.KeyCode.ToString())
    End Sub

    Private Sub VisualizerForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'My.Computer.Audio.Play(My.Resources.Startup, AudioPlayMode.Background)

    End Sub

    Private Sub VisualizerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'My.Computer.Audio.Play(My.Resources._Exit, AudioPlayMode.Background)
        If DATA_VALIDATED Then
            If MsgBox("Voulez-vous vraiment quitter ?", MessageBoxButtons.YesNo, "Quitter ?").ToString = "Yes" Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class