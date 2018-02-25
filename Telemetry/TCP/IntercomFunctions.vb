Module IntercomFunctions
    Public MessageCount As Integer = 0
    Public Messages As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Public Sub DisplayMessage(Id As String, Message As String)
        MessageCount += 1
        Messages.Add(Id, Message)
        UpdateMessages()
        FormsManager.MainForm.MainPanel.Visible = False

    End Sub

    Public Sub CloseMessage(Id As String)
        Try
            Messages.Remove(Messages.Item(Id))
            MessageCount -= 1
            If MessageCount <= 0 Then FormsManager.MainForm.MainPanel.Visible = True : UpdateMessages()
        Catch ErrorCode As Exception

        End Try
    End Sub

    Public Sub UpdateMessages()
       'Globals.MainForm.AppHaltedLbl.Text = vbCrLf
        For Each Element As KeyValuePair(Of String, String) In Messages
            'Globals.MainForm.AppHaltedLbl.Text = Globals.MainForm.AppHaltedLbl.Text & Element.Value & vbCrLf
        Next
    End Sub

    Public Sub CloseAllMessages()
        Messages.Clear()
        MessageCount = 0
        FormsManager.MainForm.MainPanel.Visible = True
    End Sub
End Module
