Imports System.IO
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
        If SavePath = "" Then
            Dim bname As String = txtName.Text
            Dim aid As Integer = Tag(1)
            'Dim aname As String = lbName.Text
            Dim cid As Integer = cbbType.SelectedValue
            'Dim type As String = cbbType.Text
            Dim txt As String = txtIntroduction.Text
            If biBll.CreateBook(bname, aid, cid, txt) Then
                MessageBox.Show("OK")
            End If
        Else
            Dim bname As String = txtName.Text
            Dim aid As Integer = Tag(1)
            'Dim aname As String = lbName.Text
            Dim cid As Integer = cbbType.SelectedValue
            'Dim type As String = cbbType.Text
            Dim txt As String = txtIntroduction.Text
            If biBll.CreateBookCover(bname, aid, cid, txt, SavePath) Then
                MessageBox.Show("OK")
            End If
        End If

        result = DialogResult.OK
        Close()
    End Sub

    Dim SavePath As String

    Private Sub FormCreateBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DialogResult = result
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim open As New OpenFileDialog
        open.Title = "选择图片"
        open.Filter = "图片文件（*.jpg;*.bmp;*.gif;*.rng）|*.jpg;*.bmp;*.gif;*.rng"
        open.Multiselect = False
        If open.ShowDialog() = DialogResult.OK Then
            Dim sourcePath As String = open.FileName
            Directory.SetCurrentDirectory(Application.StartupPath) ' 将当前工作目录设置为项目的根目录
            Dim fileName As String = Path.GetFileName(sourcePath)
            If Directory.Exists("upload\" + Tag(2).ToString + "\") Then
            Else
                Directory.CreateDirectory("upload\" + Tag(2).ToString + "\")
            End If
            Dim destPath As String = "upload\" + Tag(2).ToString + "\" + fileName ' 相对路径
            File.Copy(sourcePath, destPath, True) ' 复制图片到指定路径下
            PictureBox1.ImageLocation = destPath ' 显示图片
            SavePath = destPath
        End If

    End Sub
End Class