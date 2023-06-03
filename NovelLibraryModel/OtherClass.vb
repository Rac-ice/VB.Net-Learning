Partial Public Class BookInfo

    Private userName As String
    Private categoryName As String

    Property uName() As String
        Get
            Return userName
        End Get
        Set(value As String)
            userName = value
        End Set
    End Property

    Property cName() As String
        Get
            Return categoryName
        End Get
        Set(value As String)
            categoryName = value
        End Set
    End Property

End Class

Partial Public Class ChapterInfo

    Private contentText As String
    Property cText() As String
        Get
            Return contentText
        End Get
        Set(value As String)
            contentText = value
        End Set
    End Property

End Class

Partial Public Class BookCollection

    Private userName As String
    Private bookName As String

    Property uName As String
        Get
            Return userName
        End Get
        Set(value As String)
            userName = value
        End Set
    End Property

    Property bName As String
        Get
            Return bookName
        End Get
        Set(value As String)
            bookName = value
        End Set
    End Property

End Class