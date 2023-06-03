Imports NovelLibraryDal
Imports NovelLibraryModel

Partial Public Class CategoryInfoBll

    Dim ciDal As New CategoryInfoDal

    Public Function GetList() As List(Of CategoryInfo)
        Return ciDal.GetList()
    End Function

    Public Function Add(ci As CategoryInfo) As Boolean
        Return ciDal.Insert(ci) > 0
    End Function

    Public Function Edit(ci As CategoryInfo) As Boolean
        Return ciDal.Update(ci) > 0
    End Function

    Public Function Remove(id As Integer) As Boolean
        Return ciDal.Delete(id) > 0
    End Function

End Class
