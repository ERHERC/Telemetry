Public Class StartupForm
#Region "CP_NOCLOSE_BUTTON"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Params.ClassStyle = Params.ClassStyle Or CP_NOCLOSE_BUTTON
            Return Params
        End Get
    End Property
#End Region
End Class
