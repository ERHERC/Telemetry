Public MustInherit Class ConsoleMenu

    Public Sub New()
        Create()
    End Sub
    Public Overridable Sub Create() : End Sub
    Public MustOverride Sub Run()
    Public MustOverride Sub Draw()
    Public MustOverride Sub Input()

    Public MustOverride Property MenuEntries As Dictionary(Of String, String)
    Public MustOverride Property MenuEntry As Integer
    Public Overridable Property EntriesRangeStart As Integer
    Public Overridable Property EntriesRangeEnd As Integer
End Class
