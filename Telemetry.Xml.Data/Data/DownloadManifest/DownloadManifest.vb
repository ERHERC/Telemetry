Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <XmlInclude(GetType(ContentFile))>
    <Serializable>
    Public Class DownloadManifest
        <XmlAttribute>
        Public ContentDir As String

        <XmlElement>
        Public Files As List(Of ContentFile)

    End Class
End Namespace