Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class ContentFile
        <XmlAttribute>
        Public Replace As FileRepleceMethod

        <XmlAttribute>
        Public Path As String

        <XmlAttribute>
        Public Name As String

        '<XmlAttribute>
        'Public SHA256 As String

    End Class
End Namespace