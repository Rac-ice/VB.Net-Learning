Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormCategory

    Private ciBll As New CategoryInfoBll

    Private Sub FormCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub LoadList()
        dgvCategoryList.AutoGenerateColumns = False
        dgvCategoryList.DataSource = ciBll.GetList()
    End Sub

    Private Sub TxtAddCancel()
        txtAddName.Text = String.Empty
    End Sub

    Private Sub btnAddCancel_Click(sender As Object, e As EventArgs) Handles btnAddCancel.Click
        TxtAddCancel()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ci As New CategoryInfo
        ci.cName = txtAddName.Text
        If ciBll.Add(ci) Then
            LoadList()
        End If
        TxtAddCancel()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim ci As New CategoryInfo
        ci.cId = txtEditId.Text
        ci.cName = txtEditName.Text
        If ciBll.Edit(ci) Then
            LoadList()
        End If
        TxtEditCancel()
    End Sub

    Private Sub TxtEditCancel()
        txtEditId.Text = String.Empty
        txtEditName.Text = String.Empty
    End Sub

    Private Sub btnEditCancel_Click(sender As Object, e As EventArgs) Handles btnEditCancel.Click
        TxtEditCancel()
    End Sub

    Private Sub dgvCategoryList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoryList.CellDoubleClick
        Dim row = dgvCategoryList.Rows(e.RowIndex)
        txtEditId.Text = row.Cells(0).Value.ToString
        txtEditName.Text = row.Cells(1).Value.ToString
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim id As Integer = Convert.ToInt32(dgvCategoryList.SelectedRows(0).Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("确认要删除", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If ciBll.Remove(id) Then
                LoadList()
            End If
        End If
    End Sub

End Class