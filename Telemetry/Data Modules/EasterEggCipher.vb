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

        If Code.Contains("DENIS") OrElse Code.Contains("AH") Then
            'Code DENIS ?!
            My.Computer.Audio.Play(My.Resources.AH, AudioPlayMode.Background)
            Keys.Clear()
        End If

        If Code.Contains("GHOST") Then
            'Code GNOST
            For I = 1 To 0.5D Step -0.025D
                FormsManager.MainForm.Opacity = I
                Tools.Wait(0.0125)
            Next
            Tools.Wait(2)
            For I = 0.5D To 1 Step +0.025D
                FormsManager.MainForm.Opacity = I
                Tools.Wait(0.0125)

            Next
            Keys.Clear()
        End If


        If Code.Contains("ROSESSpaceARESpaceRED") Then
            'Code ROSES ARE RED
            KryptonMessageBox.Show("Roses are red" & vbCrLf & "Violets are blue" & vbCrLf & "Omae wa" & vbCrLf & "Mou shindeiru !", "Important message", MessageBoxButtons.OK)
        End If
    End Sub
End Module
