Imports NovelLibraryDal
Imports NovelLibraryModel

Partial Public Class ChapterInfoBll

    Private ciDal As New ChapterInfoDal

    Public Function GetNewChapterById(id As Integer) As List(Of ChapterInfo)
        Return ciDal.GetNewChapterById(id)
    End Function

    Public Function GetList(id As Integer) As List(Of ChapterInfo)
        Return ciDal.GetList(id)
    End Function

    Public Function GetChapterContentById(id As Integer) As List(Of ChapterInfo)
        Return ciDal.GetChapterContentById(id)
    End Function

    Public Function AddChapterAndContent(bid As Integer, title As String, count As Integer, txt As String) As Boolean
        Return ciDal.AddChapterAndContent(bid, title, count, txt) > 0
    End Function

    Public Function GetEditChapterInfo(id As Integer) As List(Of ChapterInfo)
        Return ciDal.GetEditChapterInfo(id)
    End Function

    Public Function UpdateChapterContent(cid As Integer, title As String, count As Integer, txt As String, bid As Integer) As Boolean
        Return ciDal.UpdateChapterContent(cid, title, count, txt, bid) > 0
    End Function

End Class
