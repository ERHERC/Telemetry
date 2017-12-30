Public Class StyledSplash
    Private Sub SplashForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        VersionLabel.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
    End Sub
End Class