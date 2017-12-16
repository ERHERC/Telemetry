Partial Public Class SillyClass
    Public ScrabbleScore As Dictionary(Of Char, Integer) = New Dictionary(Of Char, Integer) From {
        {"A"c, 1},
        {"B"c, 3},
        {"C"c, 3},
        {"D"c, 2},
        {"E"c, 1},
        {"F"c, 4},
        {"G"c, 2},
        {"H"c, 4},
        {"I"c, 1},
        {"J"c, 8},
        {"K"c, 10},
        {"L"c, 1},
        {"M"c, 2},
        {"N"c, 1},
        {"O"c, 1},
        {"P"c, 3},
        {"Q"c, 8},
        {"R"c, 1},
        {"S"c, 1},
        {"T"c, 1},
        {"U"c, 1},
        {"V"c, 4},
        {"W"c, 10},
        {"X"c, 10},
        {"Y"c, 10},
        {"Z"c, 10}
    }

    Public Values As List(Of String) = New List(Of String) From {"Tange",
        "Jange",
        "jaaj",
        "Souge",
        "Jouge",
        "SOOS",
        "MICHEL",
        "Poige",
        "Des tensions nai",
        "AaA",
        "Parebrise de chez carcasse",
        "Kim tongue oune",
        "Paucisse",
        "Pédiluve",
        "Sarrrasin",
        "Oupe"
    }

    Public Function GetScore(ByVal Word As String) As Integer
        Dim Score As Integer = 0
        For Each Letter As Char In Word.ToUpper()
            Try
                If ScrabbleScore.Keys.Contains(Letter) AndAlso Not ScrabbleScore.Item(Letter) = Nothing Then
                    Score += ScrabbleScore.Item(Letter)
                End If
            Catch ErrorCode As Exception
            End Try
        Next
        Return Score
    End Function
End Class
