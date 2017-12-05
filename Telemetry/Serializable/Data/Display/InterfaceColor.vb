Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <Serializable>
    Public Class InterfaceColor
        <XmlAttribute>
        Public Name As String

        <XmlAttribute>
        Public R As Integer

        <XmlAttribute>
        Public G As Integer

        <XmlAttribute>
        Public B As Integer

        <XmlAttribute>
        Public A As Integer

    End Class
End Namespace