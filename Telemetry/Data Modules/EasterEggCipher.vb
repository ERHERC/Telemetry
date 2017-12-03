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
    End Sub
End Module
