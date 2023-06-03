Partial Public Class CategoryInfo

    Private categoryId As Integer
    Private categoryName As String

    Property cId() As Integer
        Get
            Return categoryId
        End Get
        Set(value As Integer)
            categoryId = value
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
