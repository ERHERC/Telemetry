Imports System.IO
Imports System.Xml.Serialization

Namespace Serializer
    Public NotInheritable Class GenericSerializer(Of SERIALIZER_TYPE As {Class, New})
        Public Sub Serialize(ByVal DATA As SERIALIZER_TYPE, ByVal FilePath As String)
            If File.Exists(FilePath) Then
                File.Delete(FilePath)
            End If
            Dim SERIALIZER As XmlSerializer = New XmlSerializer(DATA.GetType)
            Using FILE_STREAM As FileStream = New FileStream(FilePath, FileMode.Create)
                SERIALIZER.Serialize(FILE_STREAM, DATA)
            End Using
        End Sub

        Public Function Deserialize(ByVal FilePath As String) As SERIALIZER_TYPE
            If Not (File.Exists(FilePath)) Then
                Throw New FileNotFoundException
            End If
            Dim DESERIALIZED_OBJECT As SERIALIZER_TYPE = New SERIALIZER_TYPE

            Dim SERIALIZED_TEXT As String = ""

            Using READER As StreamReader = New StreamReader(FilePath)
                SERIALIZED_TEXT = READER.ReadToEnd
            End Using

            Dim SERIALIZER As XmlSerializer = New XmlSerializer(DESERIALIZED_OBJECT.GetType)

            Using READER As TextReader = New StringReader(SERIALIZED_TEXT)
                DESERIALIZED_OBJECT = CType(SERIALIZER.Deserialize(READER), SERIALIZER_TYPE)
            End Using

            Return DESERIALIZED_OBJECT
        End Function
    End Class
End Namespace
