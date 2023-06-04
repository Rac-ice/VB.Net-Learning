Imports MySql.Data.MySqlClient
Imports NovelLibraryModel

Partial Public Class BookInfoDal

    Private sqlHelper As New MySqlHelper

    Public Function GetListById(id As Integer) As List(Of BookInfo)
        Dim sqlText = "select bookId,bookName,authorId,ui.userName,bi.categoryId,
            ci.categoryName,cover,introduction,createTime,updateTime,bi.isDelete from bookinfo as bi 
            inner join userinfo as ui on bi.authorId=ui.userId 
            inner join categoryinfo as ci on bi.categoryId=ci.categoryId 
            where authorId=@id "
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of BookInfo)
        For Each row As DataRow In dt.Rows
            Dim bi As New BookInfo
            bi.bId = Convert.ToInt32(row("bookId"))
            bi.bName = row("bookName")
            bi.aId = Convert.ToInt32(row("authorId"))
            bi.uName = row("userName")
            bi.cId = Convert.ToInt32(row("categoryId"))
            bi.cName = row("categoryName")
            bi.cTime = Convert.ToDateTime(row("createTime"))
            bi.uTime = Convert.ToDateTime(row("updateTime"))
            bi.iDelete = Convert.ToBoolean(row("isDelete"))
            list.Add(bi)
        Next
        Return list
    End Function

    Public Function GetBookList() As List(Of BookInfo)
        Dim sqlText = "select bookId,bookName,authorId,ui.userName,bi.categoryId,
            ci.categoryName,cover,introduction,createTime,updateTime,bi.isDelete from bookinfo as bi 
            inner join userinfo as ui on bi.authorId=ui.userId 
            inner join categoryinfo as ci on bi.categoryId=ci.categoryId
						where bi.isDelete=0"
        Dim listP As MySqlParameter() = {}
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of BookInfo)
        For Each row As DataRow In dt.Rows
            Dim bi As New BookInfo
            bi.bId = Convert.ToInt32(row("bookId"))
            bi.bName = row("bookName")
            bi.aId = Convert.ToInt32(row("authorId"))
            bi.uName = row("userName")
            bi.cId = Convert.ToInt32(row("categoryId"))
            bi.cName = row("categoryName")
            bi.cTime = Convert.ToDateTime(row("createTime"))
            bi.uTime = Convert.ToDateTime(row("updateTime"))
            bi.iDelete = Convert.ToBoolean(row("isDelete"))
            list.Add(bi)
        Next
        Return list
    End Function

    Public Function EditDelete(id As Integer) As Integer
        Dim sqlText = "update bookinfo set isDelete=1 where bookid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function EditUpdate(id As Integer) As Integer
        Dim sqlText = "update bookinfo set isDelete=0 where bookid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function CreateBook(name As String, aid As Integer, cid As Integer, txt As String) As Integer
        Dim sqlText = "insert into bookinfo(bookName,authorId,categoryId,introduction,createTime,updateTime) 
            values(@name,@aid,@cid,@txt,NOW(),NOW())"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@name", name),
            New MySqlParameter("@aid", aid),
            New MySqlParameter("@cid", cid),
            New MySqlParameter("@txt", txt)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function CreateBookCover(name As String, aid As Integer, cid As Integer, txt As String, cover As String) As Integer
        Dim sqlText = "insert into bookinfo(bookName,authorId,categoryId,cover,introduction,createTime,updateTime) 
            values(@name,@aid,@cid,@cover,@txt,NOW(),NOW())"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@name", name),
            New MySqlParameter("@aid", aid),
            New MySqlParameter("@cid", cid),
            New MySqlParameter("@cover", cover),
            New MySqlParameter("@txt", txt)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function GetBookInfoByBookId(id As Integer) As List(Of BookInfo)
        Dim sqlText = "select bookId,bookName,authorId,ui.userName,bi.categoryId,
            ci.categoryName,cover,introduction,createTime,updateTime,bi.isDelete from bookinfo as bi 
            inner join userinfo as ui on bi.authorId=ui.userId 
            inner join categoryinfo as ci on bi.categoryId=ci.categoryId 
            where bookId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of BookInfo)
        For Each row As DataRow In dt.Rows
            Dim bi As New BookInfo
            bi.bId = Convert.ToInt32(row("bookId"))
            bi.bName = row("bookName")
            bi.aId = Convert.ToInt32(row("authorId"))
            bi.uName = row("userName")
            bi.cId = Convert.ToInt32(row("categoryId"))
            bi.cName = row("categoryName")
            bi.cTime = Convert.ToDateTime(row("createTime"))
            bi.uTime = Convert.ToDateTime(row("updateTime"))
            bi.bookIntroduction = row("introduction")
            bi.iDelete = Convert.ToBoolean(row("isDelete"))
            bi.coverAddress = row("cover").ToString
            list.Add(bi)
        Next
        Return list
    End Function

    Public Function UpdateBookInfo(name As String, cid As Integer, txt As String, bid As Integer) As Integer
        Dim sqlText = "update bookinfo set bookName=@bname, categoryId=@cid, introduction=@txt where bookId=@bid"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@bname", name),
            New MySqlParameter("@cid", cid),
            New MySqlParameter("@txt", txt),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

    Public Function UpdateBookInfoAndCover(name As String, cid As Integer, txt As String, bid As Integer, cover As String) As Integer
        Dim sqlText = "update bookinfo set bookName=@bname, categoryId=@cid,cover=@cover, introduction=@txt where bookId=@bid"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@bname", name),
            New MySqlParameter("@cid", cid),
            New MySqlParameter("@cover", cover),
            New MySqlParameter("@txt", txt),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

End Class
