Module StopwatchController
    Public Sub SetState(Action As PanelToggleArguments)
        Select Case Action
            Case PanelToggleArguments.Toggle
                If FormsManager.Stopwatch Is Nothing OrElse FormsManager.Stopwatch.IsDisposed Then FormsManager.Stopwatch = New StopwatchPopup()
                Select Case Not FormsManager.Stopwatch.Visible
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
            If Not FormsManager.Stopwatch Is Nothing AndAlso Not FormsManager.Stopwatch.IsDisposed Then
                FormsManager.Stopwatch.Visible = True
            Else
                If Tries - 1 > 0 Then
                    FormsManager.Stopwatch = New StopwatchPopup()
                    PopPanel(Tries - 1)
                End If
            End If
        Catch ErrorCode As ObjectDisposedException
            If Tries - 1 > 0 Then
                FormsManager.Stopwatch = New StopwatchPopup()
                PopPanel(Tries - 1)
            End If
        End Try
    End Sub

    Private Sub RehostPanel(Tries As Integer)
        Try
            FormsManager.Stopwatch.Close()
        Catch ErrorCode As Exception
            MsgBox(ErrorCode.Message & vbCrLf & vbCrLf & ErrorCode.StackTrace, , ErrorCode.HResult)
            If Tries - 1 > 0 Then
                RehostPanel(Tries - 1)
            End If
        End Try
    End Sub
End Module
