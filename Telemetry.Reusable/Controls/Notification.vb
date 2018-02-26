Imports System.ComponentModel
Imports System.ComponentModel.Design

Public Class Notification
    Private _Title As String = "TITRE"
    <Category("Appearance")>
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(Value As String)
            _Title = Value
            TitleLbl.Text = Value
        End Set
    End Property

    Private _Message As String = "MESSAGE"
    <Category("Appearance"), EditorAttribute(GetType(MultilineStringEditor), GetType(System.Drawing.Design.UITypeEditor))>
    Public Property Message As String
        Get
            Return _Message
        End Get
        Set(Value As String)
            _Message = Value
            MessageLbl.Text = Value.ToString()
        End Set
    End Property
End Class
