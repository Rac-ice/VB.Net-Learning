Imports NovelLibraryCommon
Imports NovelLibraryDal
Imports NovelLibraryModel

Partial Public Class UserInfoBll

    Private uiDal As New UserInfoDal

    Private md5Helper As New Md5Helper

    Public Function LoginUser(name As String, pwd As String, ByRef uiRef As UserInfo, ByRef type As Integer) As LoginState
        Dim ui As UserInfo = uiDal.GetByUserName(name)
        uiRef = ui
        If ui.uPwd Is Nothing Then
            Return LoginState.NameError
        Else
            If ui.uPwd.Equals(md5Helper.EncryptString(pwd)) Then
                type = ui.uType
                Return LoginState.Ok
            Else
                Return LoginState.PwdError
            End If
        End If
    End Function

    Public Function LoginAdmin(name As String, pwd As String, ByRef uiRef As UserInfo) As LoginState
        Dim ui As UserInfo = uiDal.GetByAdminName(name)
        uiRef = ui
        If ui.aPwd Is Nothing Then
            Return LoginState.NameError
        Else
            If ui.aPwd.Equals(md5Helper.EncryptString(pwd)) Then
                Return LoginState.Ok
            Else
                Return LoginState.PwdError
            End If
        End If
    End Function

    Public Function GetList(dic As Dictionary(Of String, String)) As List(Of UserInfo)
        Return uiDal.GetList(dic)
    End Function

    Public Function Remove(id As Integer) As Boolean
        Return uiDal.Delete(id) > 0
    End Function

    Public Function EditType(id As Integer) As Boolean
        Return uiDal.EditType(id) > 0
    End Function

    Public Function EditName(name As String, id As Integer) As Boolean
        Return uiDal.EditName(name, id) > 0
    End Function

    Public Function GetPwdById(id As Integer) As String
        Return uiDal.GetPwdById(id)
    End Function

    Public Function EditPwd(pwd As String, id As Integer) As Boolean
        Return uiDal.EditPwd(pwd, id) > 0
    End Function

End Class
