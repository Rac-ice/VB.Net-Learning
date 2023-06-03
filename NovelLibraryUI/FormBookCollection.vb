Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormBookCollection

    Private bc As New BookCollection
    Private bcBll As New BookCollectionBll

    Private Sub FormBookCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCollection()
    End Sub

    Private Sub GetCollection()
        Dim list As List(Of BookCollection) = bcBll.GetCollection(Tag(1))
        dgvcollection.AutoGenerateColumns = False
        dgvcollection.DataSource = list
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim result As DialogResult = MessageBox.Show("确定要移除吗？", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If bcBll.RemoveCollection(Tag(1), dgvcollection.SelectedRows(0).Cells(0).Value) Then
                MessageBox.Show("OK")
                GetCollection()
            End If
        End If
    End Sub

    Private Sub dgvcollection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcollection.CellDoubleClick
        Dim formBookInfo As New FormBookInfo
        Tag = {
            Tag(0),
            Tag(1),
            Tag(2),
            dgvcollection.SelectedRows(0).Cells(0).Value,
            dgvcollection.SelectedRows(0).Cells(1).Value
        }
        formBookInfo.Tag = Tag
        formBookInfo.ShowDialog()
    End Sub
End Class