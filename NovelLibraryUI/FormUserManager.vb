
Imports NovelLibraryBll

Public Class FormUserManager

    Private uiBll As New UserInfoBll

    Private Sub FormUserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub LoadList()
        Dim dic As New Dictionary(Of String, String)
        If rbAll.Checked Then

        ElseIf rbReader.Checked Then
            dic.Add("userType", "0")
        ElseIf rbAuthor.Checked Then
            dic.Add("userType", "1")
        End If
        dgvUserList.AutoGenerateColumns = False
        dgvUserList.DataSource = uiBll.GetList(dic)
    End Sub

    Private Sub dgvUserList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUserList.CellFormatting
        If e.ColumnIndex = 2 Then
            If Convert.ToBoolean(e.Value) Then
                e.Value = "作者"
            Else
                e.Value = "读者"
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadList()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = Convert.ToInt32(dgvUserList.SelectedRows(0).Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("确认要删除", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If uiBll.Remove(id) Then
                LoadList()
            End If
        End If
    End Sub
End Class