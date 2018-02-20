Public Class MainForm
    Public SpeedBar_Background_Pencil As Pen
    Public SpeedBar_Foreground_Pencil As Pen
    Public SpeedBar_Circle_Pencil As Pen

    Public Running As Boolean

    'API Visible Fields
    Public MaxSpeed As Double = 100D
    Public Speed As Double = 25D

    Public Sub New()
        Control.CheckForIllegalCrossThreadCalls = False
        ' This call is required by the designer.
        InitializeComponent()

        ' .Add any initialization after the InitializeComponent() call.

        SpeedBar_Circle_Pencil = New Pen(Color.FromArgb(128, 192, 192, 192), 16)
        SpeedBar_Background_Pencil = New Pen(Color.FromArgb(192, 192, 192, 192), 24)
        SpeedBar_Foreground_Pencil = New Pen(Color.FromArgb(255, 255, 255, 255), 16)

        For Each HudElement As Control In MainPanel.Controls
            If HudElement.GetType.FullName = "System.Windows.Forms.Panel" Then
                HudElement.BackColor = Color.Transparent
            End If
        Next

        'Globals.Mainform = Me
    End Sub


    Private Sub SpeedLbl_Paint(sender As Object, Paintbrush As PaintEventArgs) Handles SpeedLbl.Paint
        Dim BarAngle = CInt(Math.Max(Math.Min(Math.Ceiling((Speed / MaxSpeed) * 270), 270), 0))

        Paintbrush.Graphics.DrawArc(SpeedBar_Circle_Pencil, 16, 16, 224, 224, 135, 270)

        Paintbrush.Graphics.DrawArc(SpeedBar_Background_Pencil, 16, 16, 224, 224, 135, BarAngle)
        Paintbrush.Graphics.DrawArc(SpeedBar_Foreground_Pencil, 16, 16, 224, 224, 135, BarAngle)
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Running = True
        IntercomApiManager.StartAPI()
        Tools.Wait(0.5D)
        MainPanel.Visible = True
        'Dim BackgroundTask As Task = New Task(AddressOf ParalelSub)
        'BackgroundTask.Start()
        Call SlowDown()

    End Sub

    Private Sub SlowDown()
        While Running
            AlertLabel.Visible = Not AlertLabel.Visible
            AlertBox.Visible = AlertLabel.Visible

            Select Case AlertLabel.Visible
                Case True
                    Tools.Wait(0.75)
                Case False
                    Tools.Wait(0.25)
            End Select

        End While
    End Sub

    Private Sub LostSignal()
        While Running
            With LostSignalLabel
                Select Case CInt(.Tag)
                    Case 0
                        .Text = "SIGNAL" & vbCrLf
                        .Tag = 1
                    Case 1
                        .Text = vbCrLf & "PERDU"
                        .Tag = 0
                End Select
            End With
            Tools.Wait(0.5)
        End While
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Running = False
        AppHaltedLbl.Text = "Shutting down internal service ..."
        MainPanel.Visible = False

        IntercomApiManager.StopAPI()

    End Sub

    Private Sub LostSignalFlicker_Tick(sender As Object, e As EventArgs) Handles LostSignalFlicker.Tick
        'LostSignalPanel.Transparent = Not LostSignalPanel.Transparent
        With LostSignalPanel
            Select Case CBool(.Tag)
                Case True
                    .Opacity = 0.25
                    .Tag = False
                Case False
                    .Opacity = 0.5
                    .Tag = True
            End Select
        End With
    End Sub
End Class