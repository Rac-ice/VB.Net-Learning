Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormChapterContent

    Private ciBll As New ChapterInfoBll
    Private Sub FormChapterContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbChapter.Text = "第" + Tag(6) + "章  "
        lbCName.Text = Tag(7)
        LoadInfo()
    End Sub

    Private Sub LoadInfo()
        Dim list As List(Of ChapterInfo) = ciBll.GetChapterContentById(Tag(5))
        lbWordCount.Text = "字数： " + list(0).wCount.ToString
        lbPTime.Text = list(0).pTime
        txtContent.Text = list(0).cText.ToString
    End Sub

End Class