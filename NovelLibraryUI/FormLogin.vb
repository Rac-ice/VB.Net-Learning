Imports NovelLibraryBll
Imports NovelLibraryModel

Public Class FormLogin

    Private uiBll As New UserInfoBll

    Private loginState As New LoginState

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim name As String = txtName.Text.Trim
        Dim pwd As String = txtPwd.Text.Trim
        Dim type As Integer
        Dim uiRef As New UserInfo
        If cbAdmin.Checked Then
            loginState = uiBll.LoginAdmin(name, pwd, uiRef)
            Select Case loginState
                Case LoginState.Ok
                    type = 999
                    Dim main As New FormMain
                    main.Tag = {
                        type,
                        uiRef.aId,
                        uiRef.aName
                    }
                    main.Show()
                    Hide()
                Case LoginState.NameError
                    MsgBox("用户名错误")
                    txtName.Text = String.Empty
                    txtPwd.Text = String.Empty
                    cbAdmin.Checked = False
                Case LoginState.PwdError
                    MsgBox("密码错误")
                    txtPwd.Text = String.Empty
            End Select
        Else
            loginState = uiBll.LoginUser(name, pwd, uiRef, type)
            Select Case loginState
                Case LoginState.Ok
                    Dim main As New FormMain
                    main.Tag = {
                        type,
                        uiRef.uId,
                        uiRef.uName
                    }
                    main.Show()
                    Hide()
                Case LoginState.NameError
                    MsgBox("用户名错误")
                    txtName.Text = String.Empty
                    txtPwd.Text = String.Empty
                    cbAdmin.Checked = False
                Case LoginState.PwdError
                    MsgBox("密码错误")
                    txtPwd.Text = String.Empty
            End Select
        End If
    End Sub
End Class
