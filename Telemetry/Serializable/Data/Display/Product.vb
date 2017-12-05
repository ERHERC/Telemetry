Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class Product
        <XmlElement>
        Public Name As String

        <XmlElement>
        Public Description As String

        <XmlElement>
        Public LogoUrl As String
    End Class
End Namespace