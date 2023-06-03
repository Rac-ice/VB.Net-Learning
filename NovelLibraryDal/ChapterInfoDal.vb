Imports System.Configuration
Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports NovelLibraryModel

Partial Public Class ChapterInfoDal

    Private sqlHelper As New MySqlHelper

    Public Function GetNewChapterById(id As Integer) As List(Of ChapterInfo)
        Dim sqlText = "select chapterId,chapterName,chapterNum,publishTime from chapterinfo 
            where bookid=@id order by chapterNum desc limit 1"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of ChapterInfo)
        For Each row As DataRow In dt.Rows
            Dim ci As New ChapterInfo
            ci.cId = Convert.ToInt32(row("chapterId"))
            ci.cName = row("chapterName")
            ci.cNum = Convert.ToInt32(row("chapterNum"))
            ci.pTime = Convert.ToDateTime(row("publishTime"))
            list.Add(ci)
        Next
        Return list
    End Function

    Public Function GetList(id As Integer) As List(Of ChapterInfo)
        Dim sqlText = "select chapterId,chapterName,chapterNum,publishTime from chapterinfo where bookid=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of ChapterInfo)
        For Each row As DataRow In dt.Rows
            Dim ci As New ChapterInfo
            ci.cId = Convert.ToInt32(row("chapterId"))
            ci.cName = row("chapterName")
            ci.cNum = Convert.ToInt32(row("chapterNum"))
            ci.pTime = Convert.ToDateTime(row("publishTime"))
            list.Add(ci)
        Next
        Return list
    End Function

    Public Function GetChapterContentById(id As Integer) As List(Of ChapterInfo)
        Dim sqlText = "select wordCount,publishTime,contentText from chapterinfo as ci 
            inner join chaptercontent as cc on ci.chapterId=cc.chapterId 
            where ci.chapterId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of ChapterInfo)
        For Each row As DataRow In dt.Rows
            Dim ci As New ChapterInfo
            ci.wCount = Convert.ToInt32(row("wordCount"))
            ci.pTime = Convert.ToDateTime(row("publishTime"))
            ci.cText = row("contentText")
            list.Add(ci)
        Next
        Return list
    End Function

    Public Function AddChapterAndContent(bid As Integer, title As String, count As Integer, txt As String) As Integer
        Dim sqlText = "SET @num = ((SELECT COUNT(*) FROM chapterinfo WHERE bookId=" + bid.ToString + ") + 1);
INSERT INTO chapterinfo(bookId,chapterName,chapterNum,wordCount,publishTime) 
VALUES(" + bid.ToString + ",'" + title.ToString + "',@num," + count.ToString + ",NOW());
SET @cid = (SELECT chapterId FROM chapterinfo WHERE bookId=" + bid.ToString + " ORDER BY chapterNum DESC LIMIT 1);
INSERT INTO chaptercontent(chapterId,contentText) VALUES(@cid,'" + txt.ToString + "');
update bookinfo set updateTime=NOW() where bookId=" + bid.ToString
        Return sqlHelper.ExecuteNewNonQuery(sqlText)
    End Function

    Public Function GetEditChapterInfo(id As Integer) As List(Of ChapterInfo)
        Dim sqlText = "select chapterName,cc.contentText,chapterNum,wordCount from chapterinfo as ci
inner join chaptercontent as cc on ci.chapterId=cc.chapterId
where ci.chapterId=@id"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@id", id)
        }
        Dim dt As DataTable = sqlHelper.ExecuteDataTable(sqlText, listP)
        Dim list As New List(Of ChapterInfo)
        For Each row As DataRow In dt.Rows
            Dim ci As New ChapterInfo
            ci.cName = row("chapterName")
            ci.cText = row("contentText")
            ci.cNum = Convert.ToInt32(row("chapterNum"))
            ci.wCount = Convert.ToInt32(row("wordCount"))
            list.Add(ci)
        Next
        Return list
    End Function

    Public Function UpdateChapterContent(cid As Integer, title As String, count As Integer, txt As String, bid As Integer) As Integer
        Dim sqlText = "update chapterinfo set chapterName=@name,wordCount=@count,publishTime=NOW() where chapterId=@cid;
update chaptercontent set contentText=@txt where chapterId=@cid;
update bookinfo set updateTime=NOW() where bookId=@bid"
        Dim listP As MySqlParameter() = {
            New MySqlParameter("@cid", cid),
            New MySqlParameter("@name", title),
            New MySqlParameter("@count", count),
            New MySqlParameter("@txt", txt),
            New MySqlParameter("@bid", bid)
        }
        Return sqlHelper.ExecuteNonQuery(sqlText, listP)
    End Function

End Class
