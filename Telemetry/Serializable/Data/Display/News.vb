Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class News
        <XmlAttribute>
        Public Url As String
    End Class
End Namespace