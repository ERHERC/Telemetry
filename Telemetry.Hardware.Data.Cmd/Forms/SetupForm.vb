Public Class SetupForm
    Private Sub ServiceAddressLbl_Click(sender As Object, e As EventArgs) Handles ServiceAddressLbl.Click

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComPortCBox
            .Items.Clear()
            For Each Port As String In My.Computer.Ports.SerialPortNames
                .Items.Add(Port)
            Next
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
    End Sub
End Class