Imports NovelLibraryBll

Public Class FormBookManager

    Private biBll As New BookInfoBll

    Private Sub FormBookManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetList()
    End Sub

    Private Sub GetList()
        dgvBookList.AutoGenerateColumns = False
        dgvBookList.DataSource = biBll.GetListById(Tag(1))
    End Sub

    Private Sub dgvBookList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookList.CellDoubleClick
        Tag = {
            Tag(0),
            Tag(1),
            Tag(2),
            dgvBookList.SelectedRows(0).Cells(0).Value,
            dgvBookList.SelectedRows(0).Cells(1).Value
        }
        Dim formBookInfo As New FormBookInfo
        formBookInfo.Tag = Tag
        formBookInfo.ShowDialog()
        GetList()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim formCreate As New FormCreateBook
        formCreate.Tag = Tag
        Dim result As DialogResult = formCreate.ShowDialog()
        If result = DialogResult.OK Then
            GetList()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer = Convert.ToInt32(dgvBookList.SelectedRows(0).Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("确认要上架吗？", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If biBll.EditUpdate(id) Then
                GetList()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Convert.ToInt32(dgvBookList.SelectedRows(0).Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("确认要下架吗？", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If biBll.EditDelete(id) Then
                GetList()
            End If
        End If
    End Sub

    Private Sub dgvBookList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBookList.CellFormatting
        If e.ColumnIndex = 6 Then
            If e.Value Then
                e.Value = "下架"
            Else
                e.Value = "上架"
            End If
        End If
    End Sub

End Class