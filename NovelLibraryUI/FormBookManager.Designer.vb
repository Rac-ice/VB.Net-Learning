<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookManager
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
        Me.dgvBookList = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvBookList)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "列表"
        '
        'dgvBookList
        '
        Me.dgvBookList.AllowUserToAddRows = False
        Me.dgvBookList.AllowUserToDeleteRows = False
        Me.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookId, Me.bookName, Me.userName, Me.categoryName, Me.createTime, Me.updateTime, Me.isDelete})
        Me.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBookList.Location = New System.Drawing.Point(3, 17)
        Me.dgvBookList.MultiSelect = False
        Me.dgvBookList.Name = "dgvBookList"
        Me.dgvBookList.ReadOnly = True
        Me.dgvBookList.RowTemplate.Height = 23
        Me.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookList.Size = New System.Drawing.Size(744, 416)
        Me.dgvBookList.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(785, 418)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "下架"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(785, 375)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "上架"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(785, 330)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "发布新书"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'bookId
        '
        Me.bookId.DataPropertyName = "bId"
        Me.bookId.HeaderText = "编号"
        Me.bookId.Name = "bookId"
        Me.bookId.ReadOnly = True
        '
        'bookName
        '
        Me.bookName.DataPropertyName = "bName"
        Me.bookName.HeaderText = "名称"
        Me.bookName.Name = "bookName"
        Me.bookName.ReadOnly = True
        '
        'userName
        '
        Me.userName.DataPropertyName = "uName"
        Me.userName.HeaderText = "作者"
        Me.userName.Name = "userName"
        Me.userName.ReadOnly = True
        '
        'categoryName
        '
        Me.categoryName.DataPropertyName = "cName"
        Me.categoryName.HeaderText = "类别"
        Me.categoryName.Name = "categoryName"
        Me.categoryName.ReadOnly = True
        '
        'createTime
        '
        Me.createTime.DataPropertyName = "cTime"
        Me.createTime.HeaderText = "创建时间"
        Me.createTime.Name = "createTime"
        Me.createTime.ReadOnly = True
        '
        'updateTime
        '
        Me.updateTime.DataPropertyName = "uTime"
        Me.updateTime.HeaderText = "更新时间"
        Me.updateTime.Name = "updateTime"
        Me.updateTime.ReadOnly = True
        '
        'isDelete
        '
        Me.isDelete.DataPropertyName = "iDelete"
        Me.isDelete.HeaderText = "状态"
        Me.isDelete.Name = "isDelete"
        Me.isDelete.ReadOnly = True
        '
        'FormBookManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBookManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "作品列表"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvBookList As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents bookId As DataGridViewTextBoxColumn
    Friend WithEvents bookName As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents categoryName As DataGridViewTextBoxColumn
    Friend WithEvents createTime As DataGridViewTextBoxColumn
    Friend WithEvents updateTime As DataGridViewTextBoxColumn
    Friend WithEvents isDelete As DataGridViewTextBoxColumn
End Class
