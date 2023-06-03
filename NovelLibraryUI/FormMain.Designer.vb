<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.dgvBookList = New System.Windows.Forms.DataGridView()
        Me.tsIndex = New System.Windows.Forms.ToolStripButton()
        Me.tsUserManager = New System.Windows.Forms.ToolStripButton()
        Me.tsCategory = New System.Windows.Forms.ToolStripButton()
        Me.tsBookManager = New System.Windows.Forms.ToolStripButton()
        Me.tsUserInfo = New System.Windows.Forms.ToolStripButton()
        Me.tsCollection = New System.Windows.Forms.ToolStripButton()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsIndex, Me.ToolStripSeparator1, Me.tsUserManager, Me.ToolStripSeparator4, Me.tsCategory, Me.ToolStripSeparator6, Me.tsBookManager, Me.ToolStripSeparator2, Me.tsUserInfo, Me.ToolStripSeparator3, Me.tsCollection})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1904, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lb1.Location = New System.Drawing.Point(3, 17)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(41, 12)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "编号："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb2)
        Me.GroupBox1.Controls.Add(Me.lbId)
        Me.GroupBox1.Controls.Add(Me.lb3)
        Me.GroupBox1.Controls.Add(Me.lbName)
        Me.GroupBox1.Controls.Add(Me.lbType)
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1006)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1904, 35)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb2.Location = New System.Drawing.Point(1819, 17)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(41, 12)
        Me.lb2.TabIndex = 11
        Me.lb2.Text = "编号："
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbId.ForeColor = System.Drawing.Color.Blue
        Me.lbId.Location = New System.Drawing.Point(1860, 17)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(0, 12)
        Me.lbId.TabIndex = 10
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb3.Location = New System.Drawing.Point(1860, 17)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(41, 12)
        Me.lb3.TabIndex = 9
        Me.lb3.Text = "名称："
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbName.ForeColor = System.Drawing.Color.Blue
        Me.lbName.Location = New System.Drawing.Point(1901, 17)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 12)
        Me.lbName.TabIndex = 8
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbType.ForeColor = System.Drawing.Color.Red
        Me.lbType.Location = New System.Drawing.Point(44, 17)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(0, 12)
        Me.lbType.TabIndex = 7
        '
        'dgvBookList
        '
        Me.dgvBookList.AllowUserToAddRows = False
        Me.dgvBookList.AllowUserToDeleteRows = False
        Me.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookId, Me.bookName, Me.authorName, Me.categoryName, Me.updateTime})
        Me.dgvBookList.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvBookList.Location = New System.Drawing.Point(0, 28)
        Me.dgvBookList.MultiSelect = False
        Me.dgvBookList.Name = "dgvBookList"
        Me.dgvBookList.ReadOnly = True
        Me.dgvBookList.RowTemplate.Height = 23
        Me.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookList.Size = New System.Drawing.Size(543, 978)
        Me.dgvBookList.TabIndex = 9
        '
        'tsIndex
        '
        Me.tsIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsIndex.Enabled = False
        Me.tsIndex.Image = CType(resources.GetObject("tsIndex.Image"), System.Drawing.Image)
        Me.tsIndex.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsIndex.Name = "tsIndex"
        Me.tsIndex.Size = New System.Drawing.Size(46, 25)
        Me.tsIndex.Text = "首页"
        '
        'tsUserManager
        '
        Me.tsUserManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsUserManager.Image = CType(resources.GetObject("tsUserManager.Image"), System.Drawing.Image)
        Me.tsUserManager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUserManager.Name = "tsUserManager"
        Me.tsUserManager.Size = New System.Drawing.Size(78, 25)
        Me.tsUserManager.Text = "用户管理"
        '
        'tsCategory
        '
        Me.tsCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsCategory.Image = CType(resources.GetObject("tsCategory.Image"), System.Drawing.Image)
        Me.tsCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCategory.Name = "tsCategory"
        Me.tsCategory.Size = New System.Drawing.Size(78, 25)
        Me.tsCategory.Text = "作品分类"
        '
        'tsBookManager
        '
        Me.tsBookManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBookManager.Image = CType(resources.GetObject("tsBookManager.Image"), System.Drawing.Image)
        Me.tsBookManager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBookManager.Name = "tsBookManager"
        Me.tsBookManager.Size = New System.Drawing.Size(78, 25)
        Me.tsBookManager.Text = "作品管理"
        '
        'tsUserInfo
        '
        Me.tsUserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsUserInfo.Image = CType(resources.GetObject("tsUserInfo.Image"), System.Drawing.Image)
        Me.tsUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUserInfo.Name = "tsUserInfo"
        Me.tsUserInfo.Size = New System.Drawing.Size(78, 25)
        Me.tsUserInfo.Text = "用户信息"
        '
        'tsCollection
        '
        Me.tsCollection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsCollection.Image = CType(resources.GetObject("tsCollection.Image"), System.Drawing.Image)
        Me.tsCollection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCollection.Name = "tsCollection"
        Me.tsCollection.Size = New System.Drawing.Size(46, 25)
        Me.tsCollection.Text = "书架"
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
        Me.bookName.HeaderText = "书名"
        Me.bookName.Name = "bookName"
        Me.bookName.ReadOnly = True
        '
        'authorName
        '
        Me.authorName.DataPropertyName = "uName"
        Me.authorName.HeaderText = "作者"
        Me.authorName.Name = "authorName"
        Me.authorName.ReadOnly = True
        '
        'categoryName
        '
        Me.categoryName.DataPropertyName = "cName"
        Me.categoryName.HeaderText = "分类"
        Me.categoryName.Name = "categoryName"
        Me.categoryName.ReadOnly = True
        '
        'updateTime
        '
        Me.updateTime.DataPropertyName = "uTime"
        Me.updateTime.HeaderText = "最近更新"
        Me.updateTime.Name = "updateTime"
        Me.updateTime.ReadOnly = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.dgvBookList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "主页"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsIndex As ToolStripButton
    Friend WithEvents tsUserManager As ToolStripButton
    Friend WithEvents tsBookManager As ToolStripButton
    Friend WithEvents tsUserInfo As ToolStripButton
    Friend WithEvents tsCollection As ToolStripButton
    Friend WithEvents tsCategory As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents lb1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbType As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lbId As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lbName As Label
    Friend WithEvents dgvBookList As DataGridView
    Friend WithEvents bookId As DataGridViewTextBoxColumn
    Friend WithEvents bookName As DataGridViewTextBoxColumn
    Friend WithEvents authorName As DataGridViewTextBoxColumn
    Friend WithEvents categoryName As DataGridViewTextBoxColumn
    Friend WithEvents updateTime As DataGridViewTextBoxColumn
End Class
