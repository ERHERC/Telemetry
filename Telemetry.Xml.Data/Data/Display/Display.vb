Imports System.Runtime.Serialization
Imports System.Xml.Serialization

Namespace Data
    <XmlInclude(GetType(News))>
    <XmlInclude(GetType(InterfaceColor))>
    <XmlInclude(GetType(Product))>
    <Serializable>
    Public Class Display
        <XmlElement>
        Public News As News

        <XmlElement>
        Public Colors As List(Of InterfaceColor)

        <XmlElement>
        Public Product As Product

    End Class
End Namespace