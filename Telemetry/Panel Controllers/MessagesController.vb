Module MessagesController
    Public Sub SetState(Action As PanelToggleArguments)
        Select Case Action
            Case PanelToggleArguments.Toggle
                Select Case Not FormsManager.Messages.Visible
                    Case True
                        PopPanel(2)
                    Case False
                        RehostPanel(2)
                End Select
            Case PanelToggleArguments.Popup
                PopPanel(2)
            Case PanelToggleArguments.Rehost
                RehostPanel(2)
        End Select
    End Sub

    Private Sub pPopPanel(Tries As Integer)
        Try

        Catch ErrorCode As ObjectDisposedException
            If Tries - 1 > 0 Then
                FormsManager.Messages = New MessagesPopup()
                Libraries.Tools.Wait(0.5D)
                PopPanel(Tries - 1)
            End If
        End Try
    End Sub

    Private Sub PopPanel(Tries As Integer)
        If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.IsDisposed Then
            FormsManager.Messages.MainPanel.Controls.Add(PanelManager.Messages)
            If FormsManager.MainForm.MessagesPanel.Visible Then Libraries.Tools.Wait(1)
            FormsManager.MainForm.MessagesPanel.Visible = False
            FormsManager.Messages.Visible = True
        Else
            If Tries - 1 > 0 Then
                FormsManager.Messages = New MessagesPopup()
                Libraries.Tools.Wait(0.5D)
                PopPanel(Tries - 1)
            End If
        End If

    End Sub

    Private Sub RehostPanel(Tries As Integer)
        Try
            FormsManager.Messages.Visible = False
            FormsManager.MainForm.MessagesPanel.Controls.Add(PanelManager.Messages)
            PanelManager.Messages.BringToFront()
            FormsManager.MainForm.MessagesPanel.Visible = Not FormsManager.MainForm.Width < 700
        Catch ErrorCode As Exception
            If Tries - 1 > 0 Then
                Libraries.Tools.Wait(0.5D)
                RehostPanel(Tries - 1)
            End If
        End Try
    End Sub
End Module
