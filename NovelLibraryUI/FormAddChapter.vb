Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormAddChapter

    Private ciBll As New ChapterInfoBll
    Private result As DialogResult = DialogResult.Cancel
    Private Sub FormAddChapter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbCount.Text = txtContent.Text.Length
        If Tag(5) = "add" Then

        Else
            btnAdd.Text = "修改"
            GetEditInfo()
        End If
    End Sub

    Private Sub GetEditInfo()
        Dim list As List(Of ChapterInfo) = ciBll.GetEditChapterInfo(Convert.ToInt32(Tag(5)))
        txtTitle.Text = list(0).cName
        txtContent.Text = list(0).cText
        lbCount.Text = list(0).wCount
    End Sub

    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        lbCount.Text = txtContent.Text.Length
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Tag(5) = "add" Then
            Dim title As String = txtTitle.Text
            Dim txt As String = txtContent.Text
            If ciBll.AddChapterAndContent(Tag(3), title, Convert.ToInt32(lbCount.Text), txt) Then
                MessageBox.Show("Ok")
                Close()
            End If
        Else
            Dim title As String = txtTitle.Text
            Dim txt As String = txtContent.Text
            If ciBll.UpdateChapterContent(Tag(5), title, Convert.ToInt32(lbCount.Text), txt, Tag(3)) Then
                MessageBox.Show("Ok")
                Close()
            End If
        End If
        result = DialogResult.OK
    End Sub

    Private Sub FormAddChapter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DialogResult = result
    End Sub
End Class