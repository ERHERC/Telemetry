Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <XmlInclude(GetType(Version))>
    <Serializable>
    Public Class Versions
        <XmlElement>
        Public Versions As List(Of Version)

    End Class
End Namespace