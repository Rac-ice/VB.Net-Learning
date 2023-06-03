Imports NovelLibraryBll
Imports NovelLibraryCommon

Public Class FormUserInfo

    Private uiBll As New UserInfoBll
    Private md5 As New Md5Helper

    Private Sub FormUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tag(0) = 999 Or Tag(0) = -1 Then
            btnEditType.Visible = False
        End If
        txtId.Text = Tag(1)
        txtName.Text = Tag(2)
        lbOldPwd.Text = uiBll.GetPwdById(Tag(1))
    End Sub

    Private Sub btnEditType_Click(sender As Object, e As EventArgs) Handles btnEditType.Click
        Dim result As DialogResult = MessageBox.Show("确认要成为作者？", "提示", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If uiBll.EditType(Tag(1)) Then
                btnEditType.Visible = False
                Tag(0) = -1
                MessageBox.Show("OK")
            End If
        End If
    End Sub

    Private Sub btnEditName_Click(sender As Object, e As EventArgs) Handles btnEditName.Click
        If btnEditName.Text = "修改名称" Then
            txtName.ReadOnly = False
        Else
            Dim id As Integer = txtId.Text
            Dim name As String = txtName.Text
            If uiBll.EditName(name, id) Then
                Tag(2) = txtName.Text
                MessageBox.Show("OK")
            End If
            btnEditName.Text = "修改名称"
            txtName.ReadOnly = True
        End If

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.ReadOnly Then
        Else
            btnEditName.Text = "保存"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lbOldPwd.Text.Equals(md5.EncryptString(txtOldPwd.Text)) Then
            If txtOldPwd.Text.Equals(txtNewPwd.Text) Then
                MessageBox.Show("新旧密码相同")
                txtNewPwd.Text = String.Empty
                txtNewOk.Text = String.Empty
            Else
                If txtNewPwd.Text.Equals(txtNewOk.Text) Then
                    If uiBll.EditPwd(txtNewOk.Text, Tag(1)) Then
                        MessageBox.Show("Ok")
                        txtOldPwd.Text = String.Empty
                        txtNewPwd.Text = String.Empty
                        txtNewOk.Text = String.Empty
                    End If
                Else
                    MessageBox.Show("两次输入密码不一致")
                    txtNewPwd.Text = String.Empty
                    txtNewOk.Text = String.Empty
                End If
            End If
        Else
            MessageBox.Show("密码输入错误，请稍后修改")
            txtOldPwd.Text = String.Empty
            txtNewPwd.Text = String.Empty
            txtNewOk.Text = String.Empty
        End If

    End Sub
End Class