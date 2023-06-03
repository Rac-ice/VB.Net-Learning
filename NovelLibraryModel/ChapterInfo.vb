Partial Public Class ChapterInfo
    Private chapterId As Integer
    Private bookId As Integer
    Private chapterName As String
    Private chapterNum As String
    Private wordCount As Integer
    Private publishTime As DateTime

    Property cId As Integer
        Get
            Return chapterId
        End Get
        Set(value As Integer)
            chapterId = value
        End Set
    End Property

    Property bId As Integer
        Get
            Return bookId
        End Get
        Set(value As Integer)
            bookId = value
        End Set
    End Property

    Property cName As String
        Get
            Return chapterName
        End Get
        Set(value As String)
            chapterName = value
        End Set
    End Property

    Property cNum As String
        Get
            Return chapterNum
        End Get
        Set(value As String)
            chapterNum = value
        End Set
    End Property

    Property wCount As Integer
        Get
            Return wordCount
        End Get
        Set(value As Integer)
            wordCount = value
        End Set
    End Property

    Property pTime As DateTime
        Get
            Return publishTime
        End Get
        Set(value As DateTime)
            publishTime = value
        End Set
    End Property
End Class
