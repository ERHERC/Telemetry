Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
'Namespace Libraries
Partial Public NotInheritable Class Tools
        Public Shared Sub Wait(ByVal Seconds As Single)
            Static Start As Single
            Start = CSng(VB.Timer())
            Do While VB.Timer() < Start + Seconds
                System.Windows.Forms.Application.DoEvents()
            Loop
        End Sub

        Public Shared Function FileName(ByVal FilePath As String) As String
            Dim FolderCut As String() = FilePath.Split("\"c)
            Dim FileCut As String() = FolderCut(FolderCut.Length - 1).Split("."c)
            Dim Result As System.Text.StringBuilder = New System.Text.StringBuilder()
            If (FileCut.Length > 1) Then
                Dim Count As Integer = 0
                For Count = 0 To FileCut.Length - 2
                    If (Count = 0) Then
                        Result.Append(FileCut(Count))
                    Else
                        Result.Append(".")
                        Result.Append(FileCut(Count))
                    End If
                Next
            Else
                Result.Append(FileCut(0))
            End If
            Return Result.ToString()
        End Function

        Public Shared Function GetPath(ByVal FilePath As String) As String
            Dim FolderCut As String() = FilePath.Split("\"c)
            Dim Result As System.Text.StringBuilder = New System.Text.StringBuilder()
            If (FolderCut.Length > 1) Then
                Dim Count As Integer = 0
                For Count = 0 To FolderCut.Length - 2
                    If (Count = 0) Then
                        Result.Append(FolderCut(Count))
                    Else
                        Result.Append("\")
                        Result.Append(FolderCut(Count))
                    End If
                Next
            End If
            Return Result.ToString()
        End Function

        Public Shared Function SplitSourceImage(ByVal SourceImage As Image, ByVal ImageCount As Integer, ByVal ImageSize As Size) As Image()
            Dim Result(ImageCount) As Image
            Dim PictureBoxContainer = New PictureBox
            With PictureBoxContainer
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Image = SourceImage
                For Count As Integer = 0 To ImageCount - 1
                    Dim OutputImage As Bitmap = New Bitmap(ImageSize.Width, ImageSize.Height)
                    .DrawToBitmap(CType(Result(Count), Bitmap), New Rectangle(0, Count * ImageSize.Height, ImageSize.Width, ImageSize.Height))
                    Result(Count) = CType(OutputImage, Image)
                Next
            End With
            Return Result
        End Function

        Public Shared Function TrimStart(ByVal Input As String, ByVal Text As String) As String
            Dim Output As String = Input
            For Each Letter As Char In Text
                Output.TrimStart(Letter)
            Next
            Return Output
        End Function

        Public Shared Function TrimEnd(ByVal Input As String, ByVal Text As String) As String
            Dim Output As String = Input
            For Each Letter As Char In Text.Reverse
                Output.TrimEnd(Letter)
            Next
            Return Output
        End Function

        Public Shared Function ArrayHasLength(Array As Object(), Length As Integer) As Boolean
            If Array.Length >= Length Then Return True Else Return False
        End Function
    End Class
'End Namespace

Partial Public NotInheritable Class MathHelper
    Public Shared Function Constrain(Value As Double, Min As Double, Max As Double) As Double
        Return Math.Min(Max, Math.Max(Value, Min))
    End Function

    Public Shared Function Map(Value As Double, From_A As Double, To_A As Double, From_B As Double, TO_B As Double) As Double
        Return From_B + (Value - From_A) * (TO_B - From_B) / (To_A - From_A)
    End Function

    Public Shared Function MapConstrain(Value As Double, From_A As Double, To_A As Double, From_B As Double, TO_B As Double) As Double
        Return Map(Constrain(Value, From_A, To_A), From_A, To_A, From_B, TO_B)
    End Function
End Class