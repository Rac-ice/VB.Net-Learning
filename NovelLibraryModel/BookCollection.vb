Partial Public Class BookCollection

    Private userId As Integer
    Private bookId As Integer
    Private collectionTime As DateTime

    Property uId As Integer
        Get
            Return userId
        End Get
        Set(value As Integer)
            userId = value
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

    Property cTime As DateTime
        Get
            Return collectionTime
        End Get
        Set(value As DateTime)
            collectionTime = value
        End Set
    End Property

End Class
