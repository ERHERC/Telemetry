Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class Updater
        <XmlElement>
        Public OnlineVersion As Integer

        <XmlElement>
        Public VersionListManifest As String

    End Class
End Namespace