Imports NovelLibraryDal
Imports NovelLibraryModel

Partial Public Class BookCollectionBll

    Private bcDal As New BookCollectionDal

    Public Function Insert(uid As Integer, bid As Integer) As Boolean
        Return bcDal.Insert(uid, bid) > 0
    End Function

    Public Function SelectCollection(uid As Integer, bid As Integer) As Boolean
        Return bcDal.SelectCollection(uid, bid) > 0
    End Function

    Public Function GetCollection(uid As Integer) As List(Of BookCollection)
        Return bcDal.GetCollection(uid)
    End Function

    Public Function RemoveCollection(uid As Integer, bid As Integer) As Boolean
        Return bcDal.RemoveCollection(uid, bid) > 0
    End Function

End Class
