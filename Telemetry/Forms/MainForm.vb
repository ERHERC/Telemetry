Public Class MainForm
    Public SpeedBar_Background_Pencil As Pen
    Public SpeedBar_Foreground_Pencil As Pen
    Public SpeedBar_Circle_Pencil As Pen

    Public Running As Boolean

    Public Sub New()
        Control.CheckForIllegalCrossThreadCalls = False
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        SpeedBar_Circle_Pencil = New Pen(Color.FromArgb(128, 192, 192, 192), 16)
        SpeedBar_Background_Pencil = New Pen(Color.FromArgb(192, 192, 192, 192), 24)
        SpeedBar_Foreground_Pencil = New Pen(Color.FromArgb(255, 255, 255, 255), 16)

        For Each HudElement As Control In MainPanel.Controls
            If HudElement.GetType.FullName = "System.Windows.Forms.Panel" Then
                HudElement.BackColor = Color.Transparent
            End If
        Next
    End Sub


    Private Sub SpeedLbl_Paint(sender As Object, Paintbrush As PaintEventArgs) Handles SpeedLbl.Paint
        Paintbrush.Graphics.DrawArc(SpeedBar_Circle_Pencil, 16, 16, 224, 224, 135, 270)
        Paintbrush.Graphics.DrawArc(SpeedBar_Background_Pencil, 16, 16, 224, 224, 135, 135)
        Paintbrush.Graphics.DrawArc(SpeedBar_Foreground_Pencil, 16, 16, 224, 224, 135, 135)
    End Sub

    Private Sub BatteryBarPanel_Paint(sender As Object, e As PaintEventArgs) Handles BatteryBarPanel.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles AlertBox.Click

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Running = True
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
                    Libraries.Tools.Wait(0.75)
                Case False
                    Libraries.Tools.Wait(0.25)
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
            Libraries.Tools.Wait(0.5)
        End While
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Running = False
    End Sub
End Class