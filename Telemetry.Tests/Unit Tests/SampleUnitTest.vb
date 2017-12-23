Namespace UnitTests
    Public Class SampleUnitTest : Inherits UnitTest : Implements IUnitTest

        Public Overrides Property Category As String Implements IUnitTest.Category
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Overrides Property Name As String Implements IUnitTest.Name
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Overrides Sub Run(AppStartPath As String) Implements IUnitTest.Run
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace