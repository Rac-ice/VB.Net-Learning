
Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormCreateBook

    Private ciBll As New CategoryInfoBll
    Private biBll As New BookInfoBll
    Private result As DialogResult = DialogResult.Cancel

    Private Sub FormCreateBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbName.Text = Tag(2)
        GetCategoryList()
    End Sub

    Private Sub GetCategoryList()
        Dim list As List(Of CategoryInfo) = ciBll.GetList()
        Dim ci As New CategoryInfo
        ci.cId = 0
        ci.cName = "全部"
        list.Insert(0, ci)
        cbbType.DataSource = list
        cbbType.ValueMember = "cId"
        cbbType.DisplayMember = "cName"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bname As String = txtName.Text
        Dim aid As Integer = Tag(1)
        'Dim aname As String = lbName.Text
        Dim cid As Integer = cbbType.SelectedValue
        'Dim type As String = cbbType.Text
        Dim txt As String = txtIntroduction.Text
        If biBll.CreateBook(bname, aid, cid, txt) Then
            MessageBox.Show("OK")
        End If
        result = DialogResult.OK
        Close()
    End Sub

    Private Sub FormCreateBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DialogResult = result
    End Sub
End Class