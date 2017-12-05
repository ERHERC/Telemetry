Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class Version
        <XmlAttribute>
        Public Name As String

        <XmlAttribute>
        Public SubRepository As String

        <XmlAttribute>
        Public DownloadManifest As String

        <XmlAttribute>
        Public VersionId As Integer
    End Class
End Namespace