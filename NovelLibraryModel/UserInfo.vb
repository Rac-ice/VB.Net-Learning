Partial Public Class UserInfo

    Private userId As Integer
    Property uId() As Integer
        Get
            Return userId
        End Get
        Set(value As Integer)
            userId = value
        End Set
    End Property

    Private userName As String
    Property uName() As String
        Get
            Return userName
        End Get
        Set(value As String)
            userName = value
        End Set
    End Property

    Private userPwd As String
    Property uPwd() As String
        Get
            Return userPwd
        End Get
        Set(value As String)
            userPwd = value
        End Set
    End Property

    Private userType As Boolean
    Property uType() As Boolean
        Get
            Return userType
        End Get
        Set(value As Boolean)
            userType = value
        End Set
    End Property

    Private adminId As Integer
    Property aId() As Integer
        Get
            Return adminId
        End Get
        Set(value As Integer)
            adminId = value
        End Set
    End Property

    Private adminName As String
    Property aName() As String
        Get
            Return adminName
        End Get
        Set(value As String)
            adminName = value
        End Set
    End Property

    Private adminPwd As String
    Property aPwd() As String
        Get
            Return adminPwd
        End Get
        Set(value As String)
            adminPwd = value
        End Set
    End Property

End Class
