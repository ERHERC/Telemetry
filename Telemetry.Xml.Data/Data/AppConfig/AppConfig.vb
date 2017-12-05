Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class AppConfig
        <XmlElement>
        Public AutoUpdate As Boolean

        <XmlElement>
        Public Repository As String

        <XmlElement>
        Public DisplayManifest As String

        <XmlElement>
        Public UpdateManifest As String

        <XmlElement>
        Public CurrentVersion As Integer

        <XmlElement>
        Public VersionName As String
    End Class
End Namespace