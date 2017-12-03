Module EasterEggCipher
    Public Sub Scan(ByRef Keys As Queue(Of Keys))
        Dim Code As String = ""
        For Each Element As Keys In Keys
            Code = Code & Element.ToString()
        Next

        If Code.Contains("UpUpDownDownLeftRightLeftRightBA") Then
            'Konami code
            My.Computer.Audio.Play(My.Resources.Wtf, AudioPlayMode.Background)
            Keys.Clear()
        End If

        If Code.Contains("NANI") Then
            'Code NANI ?!
            My.Computer.Audio.Play(My.Resources.NANI, AudioPlayMode.Background)
            Keys.Clear()
        End If

        If Code.Contains("GHOST") Then
            For I = 1 To 0.5D Step -0.025D
                FormsManager.MainForm.Opacity = I
                Libraries.Tools.Wait(0.0125)
            Next
            Libraries.Tools.Wait(2)
            For I = 0.5D To 1 Step +0.025D
                FormsManager.MainForm.Opacity = I
                Libraries.Tools.Wait(0.0125)
            Next
            Keys.Clear()
        End If
    End Sub
End Module