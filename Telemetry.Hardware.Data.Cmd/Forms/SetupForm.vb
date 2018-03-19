﻿Public Class SetupForm
    Private Sub ServiceAddressLbl_Click(sender As Object, e As EventArgs) Handles ServiceAddressLbl.Click

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshComPorts()
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Try
            Globals.CommandPrompt.Arduino.Close()
        Catch ErrorCode As Exception
            MsgBox("Erreur")
        End Try
        Globals.CommandPrompt.Arduino.PortName = ComPortCBox.SelectedItem
        Globals.CommandPrompt.SerialWorker.RunWorkerAsync()
        Me.Close()
    End Sub

    Private Sub ComPortRefresh_Click(sender As Object, e As EventArgs) Handles ComPortRefresh.Click
        RefreshComPorts()
    End Sub

    Private Sub RefreshComPorts()
        With ComPortCBox
            .Items.Clear()
            For Each Port As String In My.Computer.Ports.SerialPortNames
                .Items.Add(Port)
            Next
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
    End Sub
End Class