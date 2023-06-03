Imports NovelLibraryDal
Imports NovelLibraryModel

Partial Public Class BookInfoBll

    Private biDal As New BookInfoDal

    Public Function GetListById(id As Integer) As List(Of BookInfo)
        Return biDal.GetListById(id)
    End Function

    Public Function GetBookList() As List(Of BookInfo)
        Return biDal.GetBookList()
    End Function

    Public Function EditDelete(id As Integer) As Boolean
        Return biDal.EditDelete(id) > 0
    End Function

    Public Function EditUpdate(id As Integer) As Boolean
        Return biDal.EditUpdate(id) > 0
    End Function

    Public Function CreateBook(name As String, aid As Integer, cid As Integer, txt As String) As Boolean
        Return biDal.CreateBook(name, aid, cid, txt) > 0
    End Function

    Public Function GetBookInfoByBookId(id As Integer) As List(Of BookInfo)
        Return biDal.GetBookInfoByBookId(id)
    End Function

    Public Function UpdateBookInfo(name As String, cid As Integer, txt As String, bid As Integer) As Boolean
        Return biDal.UpdateBookInfo(name, cid, txt, bid) > 0
    End Function

End Class
