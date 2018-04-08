Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <XmlInclude(GetType(Key))>
    <XmlInclude(GetType(HelpKeys))>
    <XmlInclude(GetType(Value))>
    <XmlInclude(GetType(HelpValues))>
    <Serializable>
    Public Class HelpFile
        <XmlElement>
        Public HelpKeys As HelpKeys

        <XmlElement>
        Public HelpValues As HelpValues
    End Class

    <XmlInclude(GetType(Key))>
    <Serializable>
    Public Class HelpKeys
        <XmlElement>
        Public Key As List(Of Key)
    End Class

    <Serializable>
    Public Class Key
        <XmlAttribute>
        Public entry As String

        <XmlAttribute>
        Public value As String
    End Class

    <XmlInclude(GetType(Value))>
    <Serializable>
    Public Class HelpValues
        <XmlElement>
        Public Value As List(Of Value)
    End Class

    <Serializable>
    Public Class Value
        <XmlAttribute>
        Public name As String

        <XmlElement>
        Public Line As List(Of String)
    End Class
End Namespace
