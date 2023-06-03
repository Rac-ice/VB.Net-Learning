Imports System.Net.Http.Headers

Partial Public Class BookInfo

    Private bookId As Integer
    Private bookName As String
    Private authorId As Integer
    Private categoryId As Integer
    Private cover As String
    Private introduction As String
    Private createTime As DateTime
    Private updateTime As DateTime
    Private isDelete As Boolean

    Property bId() As Integer
        Get
            Return bookId
        End Get
        Set(value As Integer)
            bookId = value
        End Set
    End Property

    Property bName() As String
        Get
            Return bookName
        End Get
        Set(value As String)
            bookName = value
        End Set
    End Property

    Property aId() As Integer
        Get
            Return authorId
        End Get
        Set(value As Integer)
            authorId = value
        End Set
    End Property

    Property cId As Integer
        Get
            Return categoryId
        End Get
        Set(value As Integer)
            categoryId = value
        End Set
    End Property

    Property coverAddress() As String
        Get
            Return cover
        End Get
        Set(value As String)
            cover = value
        End Set
    End Property

    Property bookIntroduction() As String
        Get
            Return introduction
        End Get
        Set(value As String)
            introduction = value
        End Set
    End Property

    Property cTime() As DateTime
        Get
            Return createTime
        End Get
        Set(value As DateTime)
            createTime = value
        End Set
    End Property

    Property uTime() As DateTime
        Get
            Return updateTime
        End Get
        Set(value As DateTime)
            updateTime = value
        End Set
    End Property

    Property iDelete() As Boolean
        Get
            Return isDelete
        End Get
        Set(value As Boolean)
            isDelete = value
        End Set
    End Property

End Class
