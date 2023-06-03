<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserManager
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.userId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rbAuthor = New System.Windows.Forms.RadioButton()
        Me.rbReader = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvUserList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "用户列表"
        '
        'dgvUserList
        '
        Me.dgvUserList.AllowUserToAddRows = False
        Me.dgvUserList.AllowUserToDeleteRows = False
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userId, Me.userName, Me.userType})
        Me.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserList.Location = New System.Drawing.Point(3, 17)
        Me.dgvUserList.MultiSelect = False
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.ReadOnly = True
        Me.dgvUserList.RowTemplate.Height = 23
        Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserList.Size = New System.Drawing.Size(344, 210)
        Me.dgvUserList.TabIndex = 0
        '
        'userId
        '
        Me.userId.DataPropertyName = "uId"
        Me.userId.HeaderText = "编号"
        Me.userId.Name = "userId"
        Me.userId.ReadOnly = True
        '
        'userName
        '
        Me.userName.DataPropertyName = "uName"
        Me.userName.HeaderText = "名称"
        Me.userName.Name = "userName"
        Me.userName.ReadOnly = True
        '
        'userType
        '
        Me.userType.DataPropertyName = "uType"
        Me.userType.HeaderText = "类别"
        Me.userType.Name = "userType"
        Me.userType.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.rbAuthor)
        Me.GroupBox2.Controls.Add(Me.rbReader)
        Me.GroupBox2.Controls.Add(Me.rbAll)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(10, 125)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "搜索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rbAuthor
        '
        Me.rbAuthor.AutoSize = True
        Me.rbAuthor.Location = New System.Drawing.Point(20, 95)
        Me.rbAuthor.Name = "rbAuthor"
        Me.rbAuthor.Size = New System.Drawing.Size(47, 16)
        Me.rbAuthor.TabIndex = 2
        Me.rbAuthor.Text = "作者"
        Me.rbAuthor.UseVisualStyleBackColor = True
        '
        'rbReader
        '
        Me.rbReader.AutoSize = True
        Me.rbReader.Location = New System.Drawing.Point(20, 65)
        Me.rbReader.Name = "rbReader"
        Me.rbReader.Size = New System.Drawing.Size(47, 16)
        Me.rbReader.TabIndex = 1
        Me.rbReader.Text = "读者"
        Me.rbReader.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(20, 35)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(47, 16)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "全部"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(368, 195)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "删除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'FormUserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 251)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUserManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "用户管理"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents userId As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents userType As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rbAuthor As RadioButton
    Friend WithEvents rbReader As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents btnDelete As Button
End Class
