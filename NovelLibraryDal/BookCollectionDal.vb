Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports MySql.Data.MySqlClient
Imports NovelLibraryModel

Partial Public Class BookCollectionDal

    Private sqlHelper As New MySqlHelper

    Public Function Insert(uid As Integer, bid As Integer) As Integer
        Dim sqlText = "insert into bookcollection(userId,bookId,collectionTime) values(@uid,@bid,now())"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@uid", uid),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function SelectCollection(uid As Integer, bid As Integer) As Integer
        Dim sqlText = "select count(*) from bookcollection where userId=@uid and bookId=@bid"
        Dim lisp As MySqlParameter() = {
            New MySqlParameter("@uid", uid),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteScalar(sqlText, lisp)
    End Function

    Public Function GetCollection(uid As Integer) As List(Of BookCollection)
        Dim sqlText = "select collectionId,userId,bc.bookId,collectionTime,bi.bookName from bookcollection as bc
inner join bookinfo as bi on bc.bookId=bi.bookId
where bc.userId=@uid "
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@uid", uid)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of BookCollection)
        For Each row As DataRow In dt.Rows
            Dim bc As New BookCollection
            bc.uId = row("userId")
            bc.bId = row("bookId")
            bc.cTime = Convert.ToDateTime(row("collectionTime"))
            bc.bName = row("bookName")
            list.Add(bc)
        Next
        Return list
    End Function

    Public Function RemoveCollection(uid As Integer, bid As Integer) As Integer
        Dim sqlText = "delete from bookcollection where userid=@uid and bookid=@bid"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@uid", uid),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

End Class
