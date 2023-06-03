Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormMain

    Private biBll As New BookInfoBll

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInfo()
        LoadBookList()
    End Sub

    Private Sub LoadBookList()
        Dim list As List(Of BookInfo) = biBll.GetBookList()
        dgvBookList.AutoGenerateColumns = False
        dgvBookList.DataSource = list
    End Sub

    Private Sub LoadInfo()
        Dim type As Integer = Convert.ToInt32(Tag(0))
        Dim no As Integer = Convert.ToInt32(Tag(1))
        Dim title As String = Tag(2)
        If type = 999 Then
            lbType.Text = "管理员"
            tsBookManager.Visible = False
            ToolStripSeparator2.Visible = False
        ElseIf type = -1 Then
            lbType.Text = "作者"
            tsUserManager.Visible = False
            ToolStripSeparator1.Visible = False
            tsCategory.Visible = False
            ToolStripSeparator6.Visible = False
        ElseIf type = 0 Then
            lbType.Text = "读者"
            tsUserManager.Visible = False
            tsBookManager.Visible = False
            ToolStripSeparator1.Visible = False
            ToolStripSeparator2.Visible = False
            tsCategory.Visible = False
            ToolStripSeparator6.Visible = False
        End If
        lbId.Text = no
        lbName.Text = title
    End Sub

    Private Sub tsCategory_Click(sender As Object, e As EventArgs) Handles tsCategory.Click
        Dim formCategory As New FormCategory
        formCategory.ShowDialog()
    End Sub

    Private Sub tsUserManager_Click(sender As Object, e As EventArgs) Handles tsUserManager.Click
        Dim formUserManager As New FormUserManager
        formUserManager.ShowDialog()
    End Sub

    Private Sub tsUserInfo_Click(sender As Object, e As EventArgs) Handles tsUserInfo.Click
        Dim formUserInfo As New FormUserInfo
        formUserInfo.Tag = Tag
        formUserInfo.ShowDialog()
        LoadInfo()
    End Sub

    Private Sub tsBookManager_Click(sender As Object, e As EventArgs) Handles tsBookManager.Click
        Dim formBookInfo As New FormBookManager
        formBookInfo.Tag = Tag
        formBookInfo.ShowDialog()
    End Sub

    Private Sub dgvBookList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookList.CellDoubleClick
        Dim formBookInfo As New FormBookInfo
        Tag = {
            Tag(0),
            Tag(1),
            Tag(2),
            dgvBookList.SelectedRows(0).Cells(0).Value,
            dgvBookList.SelectedRows(0).Cells(1).Value
        }
        formBookInfo.Tag = Tag
        formBookInfo.ShowDialog()
    End Sub

    Private Sub tsCollection_Click(sender As Object, e As EventArgs) Handles tsCollection.Click
        Dim formBookCollection As New FormBookCollection
        formBookCollection.Tag = Tag
        formBookCollection.ShowDialog()
    End Sub
End Class