Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormBookInfo

    Private biBll As New BookInfoBll
    Private ciBll As New ChapterInfoBll
    Private categoryInfoBll As New CategoryInfoBll
    Private result As DialogResult = DialogResult.Cancel

    Private Sub FormBookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetInfo()
        GetList()
        If Tag(0) = 0 Or Tag(0) = 999 Then
            btnSave.Visible = False
            AddToolStripMenuItem.Visible = False
            UpdateToolStripMenuItem.Visible = False
        End If
        If Tag(1) = lbAuthorId.Text Then

        Else
            btnSave.Visible = False
            AddToolStripMenuItem.Visible = False
            UpdateToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub GetInfo()
        Dim list As List(Of BookInfo) = biBll.GetBookInfoByBookId(Tag(3))
        Dim chapterList As List(Of ChapterInfo) = ciBll.GetNewChapterById(Tag(3))
        txtName.Text = list(0).bName
        lbName.Text = list(0).uName
        lbType.Text = list(0).cName
        lbAuthorId.Text = list(0).aId
        If chapterList.Count > 0 Then
            llbNewChapter.Text = chapterList(0).cName
            lbNewTime.Text = chapterList(0).pTime
        Else
            lbNewTime.Text = "暂无最新章节"
        End If
        txt.Text = list(0).bookIntroduction
    End Sub

    Private Sub GetList()
        Dim list As List(Of ChapterInfo) = ciBll.GetList(Tag(3))
        dgvChapterList.AutoGenerateColumns = False
        If list.Count > 0 Then
            dgvChapterList.DataSource = list
        End If
    End Sub

    Private Sub GetCategoryList()
        Dim list As List(Of CategoryInfo) = categoryInfoBll.GetList()
        ccbType.DataSource = list
        Dim ci As New CategoryInfo
        ci.cId = 0
        ci.cName = "全部"
        list.Insert(0, ci)
        ccbType.ValueMember = "cId"
        ccbType.DisplayMember = "cName"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "修改" Then
            txt.ReadOnly = False
            txtName.ReadOnly = False
            lbType.Visible = False
            ccbType.Visible = True
            btnSave.Text = "保存"
            GetCategoryList()
        Else
            If biBll.UpdateBookInfo(txtName.Text, ccbType.SelectedValue, txt.Text, Tag(3)) Then
                GetInfo()
                txt.ReadOnly = True
                txtName.ReadOnly = True
                lbType.Visible = True
                ccbType.Visible = False
                btnSave.Text = "修改"
                MessageBox.Show("OK")
            End If
            result = DialogResult.OK
        End If
    End Sub

    Private bcBll As New BookCollectionBll

    Private Sub FormBookInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If bcBll.SelectCollection(Tag(1), Tag(3)) Then
        Else
            DialogResult = result
            Dim res As DialogResult = MessageBox.Show("是否要加入书架", "提示", MessageBoxButtons.OKCancel)
            If res = DialogResult.OK Then
                If bcBll.Insert(Tag(1), Tag(3)) Then
                    MessageBox.Show("OK")
                End If
            End If
        End If
    End Sub

    Private Sub dgvChapterList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChapterList.CellDoubleClick
        Dim formChapterContent As New FormChapterContent
        Tag = {
            Tag(0),
            Tag(1),
            Tag(2),
            Tag(3),
            Tag(4),
            dgvChapterList.SelectedRows(0).Cells(0).Value,
            dgvChapterList.SelectedRows(0).Cells(1).Value,
            dgvChapterList.SelectedRows(0).Cells(2).Value
        }
        formChapterContent.Tag = Tag
        formChapterContent.ShowDialog()
    End Sub

    Private Sub dgvChapterList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvChapterList.CellFormatting
        If e.ColumnIndex = 1 Then
            e.Value = "第" + e.Value + "章"
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim formAddChapter As New FormAddChapter
        Tag = {
                Tag(0),
                Tag(1),
                Tag(2),
                Tag(3),
                Tag(4),
                "add"
            }
        formAddChapter.Tag = Tag
        formAddChapter.ShowDialog()

        GetList()

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If dgvChapterList.SelectedRows.Count > 0 Then
            Dim formAddChapter As New FormAddChapter
            Tag = {
                Tag(0),
                Tag(1),
                Tag(2),
                Tag(3),
                Tag(4),
                dgvChapterList.SelectedRows(0).Cells(0).Value.ToString
            }
            formAddChapter.Tag = Tag
            formAddChapter.ShowDialog()

            GetList()

            Else
            MessageBox.Show("请选择要修改的章节")
        End If
    End Sub

    Private Sub llbNewChapter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbNewChapter.LinkClicked
        Dim row As New Integer
        row = dgvChapterList.RowCount - 1
        Dim formChapterContent As New FormChapterContent
        Tag = {
            Tag(0),
            Tag(1),
            Tag(2),
            Tag(3),
            Tag(4),
            dgvChapterList.Rows(row).Cells(0).Value,
            dgvChapterList.Rows(row).Cells(1).Value,
            dgvChapterList.Rows(row).Cells(2).Value
        }
        formChapterContent.Tag = Tag
        formChapterContent.ShowDialog()
    End Sub
End Class