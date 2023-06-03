Imports MySql.Data.MySqlClient
Imports NovelLibraryModel
Partial Public Class CategoryInfoDal

    Private sqlHelper As New MySqlHelper

    Public Function GetList() As List(Of CategoryInfo)
        Dim sqlText As String = "select categoryId,categoryName from categoryinfo where isDelete=0"
        Dim listP As MySqlParameter() = {}
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of CategoryInfo)
        For Each row As DataRow In dt.Rows
            Dim ci As New CategoryInfo
            ci.cId = Convert.ToInt32(row("categoryId"))
            ci.cName = row("categoryName")
            list.Add(ci)
        Next
        Return list
    End Function

    Public Function Insert(ci As CategoryInfo) As Integer
        Dim sqlText As String = "insert into categoryinfo(categoryName) values(@name)"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@name", ci.cName)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function Update(ci As CategoryInfo) As Integer
        Dim sqlText As String = "update categoryinfo set categoryName=@name where categoryId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@name", ci.cName),
            New MySqlParameter("@id", ci.cId)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function Delete(id As Integer) As Integer
        Dim sqlText As String = "update categoryinfo set isdelete=1 where categoryId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

End Class
