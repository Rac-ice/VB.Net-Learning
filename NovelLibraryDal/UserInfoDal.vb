Imports MySql.Data.MySqlClient
Imports NovelLibraryModel

Partial Public Class UserInfoDal

    Private sqlHelper As New MySqlHelper

    Public Function GetByUserName(name As String) As UserInfo
        Dim ui As New UserInfo
        Dim sqlText As String = "select userId,userName,userPwd,userType from userinfo where userName=@name"
        Dim listP As New List(Of MySqlParameter)
        listP.Add(New MySqlParameter("@name", name))
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP.ToArray)
        If dt.Rows.Count > 0 Then
            ui.uId = Convert.ToInt32(dt.Rows(0)(0))
            ui.uName = name
            ui.uPwd = dt.Rows(0)(2)
            ui.uType = Convert.ToBoolean(dt.Rows(0)(3))
        End If
        Return ui
    End Function

    Public Function GetByAdminName(name As String) As UserInfo
        Dim ui As New UserInfo
        Dim sqlText As String = "select adminId,adminName,adminPwd from admininfo where adminName=@name"
        Dim listP As New List(Of MySqlParameter)
        listP.Add(New MySqlParameter("@name", name))
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP.ToArray)
        If dt.Rows.Count > 0 Then
            ui.aId = Convert.ToInt32(dt.Rows(0)(0))
            ui.aName = name
            ui.aPwd = dt.Rows(0)(2)
        End If
        Return ui
    End Function

    Public Function GetList(dic As Dictionary(Of String, String)) As List(Of UserInfo)
        Dim sqlText = "select userId,userName,userType from userinfo where isDelete=0"

        Dim listP As MySqlParameter() = {}
        If dic.Count > 0 Then
            For Each pair As KeyValuePair(Of String, String) In dic
                sqlText += " and " + pair.Key + " =" + pair.Value
                listP = {
                    New MySqlParameter("@" + pair.Key, pair.Value)
                }
            Next
        End If

        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of UserInfo)
        For Each row As DataRow In dt.Rows
            Dim ui As New UserInfo
            ui.uId = Convert.ToInt32(row("userId"))
            ui.uName = row("userName")
            ui.uType = Convert.ToBoolean(row("userType"))
            list.Add(ui)
        Next
        Return list
    End Function

    Public Function Delete(id As Integer) As Integer
        Dim sqlText = "update userInfo set isDelete=1 where userId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function EditType(id As Integer) As Integer
        Dim sqlText = "update userinfo set userType=1 where userid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function EditName(name As String, id As Integer) As String
        Dim sqlText = "update userinfo set username=@name where userid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@name", name),
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function GetPwdById(id As Integer) As String
        Dim sqlText = "select userPwd from userinfo where userid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteScalar(sqlText, listP)
    End Function

    Public Function EditPwd(pwd As String, id As Integer) As Integer
        Dim sqlText = "update userinfo set userpwd=@pwd where userid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@pwd", pwd),
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

End Class
