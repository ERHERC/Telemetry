Module MessagesController
    Public Sub SetState(Action As PanelToggleArguments)
        Select Case Action
            Case PanelToggleArguments.Toggle
                If FormsManager.Messages Is Nothing OrElse FormsManager.Messages.IsDisposed Then FormsManager.Messages = New MessagesPopup()
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

    Private Sub PopPanel(Tries As Integer)
        Try
            If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.IsDisposed Then
                FormsManager.Messages.Visible = True
                FormsManager.Messages.MainPanel.Controls.Add(PanelManager.Messages)
                'If FormsManager.MainForm.MessagesPanel.Visible Then Libraries.Tools.Wait(1)
                FormsManager.MainForm.MessagesPanel.Visible = False
            Else
                If Tries - 1 > 0 Then
                    FormsManager.Messages = New MessagesPopup()
                    PopPanel(Tries - 1)
                End If
            End If
        Catch ErrorCode As ObjectDisposedException
            If Tries - 1 > 0 Then
                FormsManager.Messages = New MessagesPopup()
                PopPanel(Tries - 1)
            End If
        End Try
    End Sub

    Private Sub RehostPanel(Tries As Integer)
        Try
            FormsManager.MainForm.MessagesPanel.Controls.Add(PanelManager.Messages)
            PanelManager.Messages.BringToFront()
            FormsManager.MainForm.MessagesPanel.Visible = Not FormsManager.MainForm.Width < 700
            FormsManager.Messages.Close()
        Catch ErrorCode As Exception
            MsgBox(ErrorCode.Message & vbCrLf & vbCrLf & ErrorCode.StackTrace, , ErrorCode.HResult)
            If Tries - 1 > 0 Then
                RehostPanel(Tries - 1)
            End If
        End Try
    End Sub
End Module
