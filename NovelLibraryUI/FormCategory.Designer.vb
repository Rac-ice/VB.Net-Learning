<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategory
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
        Me.dgvCategoryList = New System.Windows.Forms.DataGridView()
        Me.categoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEditCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEditId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCategoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCategoryList)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "分类"
        '
        'dgvCategoryList
        '
        Me.dgvCategoryList.AllowUserToAddRows = False
        Me.dgvCategoryList.AllowUserToDeleteRows = False
        Me.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoryList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.categoryID, Me.categoryName})
        Me.dgvCategoryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCategoryList.Location = New System.Drawing.Point(3, 17)
        Me.dgvCategoryList.MultiSelect = False
        Me.dgvCategoryList.Name = "dgvCategoryList"
        Me.dgvCategoryList.ReadOnly = True
        Me.dgvCategoryList.RowTemplate.Height = 23
        Me.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategoryList.Size = New System.Drawing.Size(244, 280)
        Me.dgvCategoryList.TabIndex = 0
        '
        'categoryID
        '
        Me.categoryID.DataPropertyName = "cId"
        Me.categoryID.HeaderText = "编号"
        Me.categoryID.Name = "categoryID"
        Me.categoryID.ReadOnly = True
        '
        'categoryName
        '
        Me.categoryName.DataPropertyName = "cName"
        Me.categoryName.HeaderText = "名称"
        Me.categoryName.Name = "categoryName"
        Me.categoryName.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddCancel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtAddName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 85)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "添加"
        '
        'btnAddCancel
        '
        Me.btnAddCancel.Location = New System.Drawing.Point(110, 50)
        Me.btnAddCancel.Name = "btnAddCancel"
        Me.btnAddCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCancel.TabIndex = 3
        Me.btnAddCancel.Text = "取消"
        Me.btnAddCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtAddName
        '
        Me.txtAddName.Location = New System.Drawing.Point(55, 20)
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(120, 21)
        Me.txtAddName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名称："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEditCancel)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.txtEditName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtEditId)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 115)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "修改"
        '
        'btnEditCancel
        '
        Me.btnEditCancel.Location = New System.Drawing.Point(110, 80)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnEditCancel.TabIndex = 7
        Me.btnEditCancel.Text = "取消"
        Me.btnEditCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(15, 80)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "修改"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtEditName
        '
        Me.txtEditName.Location = New System.Drawing.Point(55, 50)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(120, 21)
        Me.txtEditName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "名称："
        '
        'txtEditId
        '
        Me.txtEditId.Location = New System.Drawing.Point(55, 20)
        Me.txtEditId.Name = "txtEditId"
        Me.txtEditId.ReadOnly = True
        Me.txtEditId.Size = New System.Drawing.Size(120, 21)
        Me.txtEditId.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "编号："
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(269, 280)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(200, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "删除选中的行数据"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(280, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "提示：双击表格项进行修改"
        '
        'FormCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 326)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "分类管理"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCategoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCategoryList As DataGridView
    Friend WithEvents categoryID As DataGridViewTextBoxColumn
    Friend WithEvents categoryName As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAddName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEditId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddCancel As Button
    Friend WithEvents btnEditCancel As Button
End Class
