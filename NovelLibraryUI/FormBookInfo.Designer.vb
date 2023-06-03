<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBookInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.llbNewChapter = New System.Windows.Forms.LinkLabel()
        Me.lbNewTime = New System.Windows.Forms.Label()
        Me.ccbType = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvChapterList = New System.Windows.Forms.DataGridView()
        Me.chapterId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chapterNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chapterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbType = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbAuthorId = New System.Windows.Forms.Label()
        CType(Me.dgvChapterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名称："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "作者："
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.ForeColor = System.Drawing.Color.Blue
        Me.lbName.Location = New System.Drawing.Point(70, 70)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 12)
        Me.lbName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "分类："
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(70, 215)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(285, 78)
        Me.txt.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "简介："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "最新章节："
        '
        'llbNewChapter
        '
        Me.llbNewChapter.AutoSize = True
        Me.llbNewChapter.Location = New System.Drawing.Point(100, 170)
        Me.llbNewChapter.Name = "llbNewChapter"
        Me.llbNewChapter.Size = New System.Drawing.Size(0, 12)
        Me.llbNewChapter.TabIndex = 9
        '
        'lbNewTime
        '
        Me.lbNewTime.AutoSize = True
        Me.lbNewTime.ForeColor = System.Drawing.Color.Lime
        Me.lbNewTime.Location = New System.Drawing.Point(263, 170)
        Me.lbNewTime.Name = "lbNewTime"
        Me.lbNewTime.Size = New System.Drawing.Size(41, 12)
        Me.lbNewTime.TabIndex = 10
        Me.lbNewTime.Text = "Label9"
        '
        'ccbType
        '
        Me.ccbType.FormattingEnabled = True
        Me.ccbType.Location = New System.Drawing.Point(70, 110)
        Me.ccbType.Name = "ccbType"
        Me.ccbType.Size = New System.Drawing.Size(150, 20)
        Me.ccbType.TabIndex = 11
        Me.ccbType.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(150, 21)
        Me.txtName.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(130, 315)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "修改"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvChapterList
        '
        Me.dgvChapterList.AllowUserToAddRows = False
        Me.dgvChapterList.AllowUserToDeleteRows = False
        Me.dgvChapterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChapterList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chapterId, Me.chapterNum, Me.chapterName})
        Me.dgvChapterList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChapterList.Location = New System.Drawing.Point(3, 17)
        Me.dgvChapterList.MultiSelect = False
        Me.dgvChapterList.Name = "dgvChapterList"
        Me.dgvChapterList.ReadOnly = True
        Me.dgvChapterList.RowTemplate.Height = 23
        Me.dgvChapterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChapterList.Size = New System.Drawing.Size(344, 293)
        Me.dgvChapterList.TabIndex = 15
        '
        'chapterId
        '
        Me.chapterId.DataPropertyName = "cId"
        Me.chapterId.HeaderText = "编号"
        Me.chapterId.Name = "chapterId"
        Me.chapterId.ReadOnly = True
        '
        'chapterNum
        '
        Me.chapterNum.DataPropertyName = "cNum"
        Me.chapterNum.HeaderText = "章节"
        Me.chapterNum.Name = "chapterNum"
        Me.chapterNum.ReadOnly = True
        '
        'chapterName
        '
        Me.chapterName.DataPropertyName = "cName"
        Me.chapterName.HeaderText = "名称"
        Me.chapterName.Name = "chapterName"
        Me.chapterName.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvChapterList)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 313)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "章节列表"
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.ForeColor = System.Drawing.Color.Red
        Me.lbType.Location = New System.Drawing.Point(70, 115)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(0, 12)
        Me.lbType.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(265, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 120)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'lbAuthorId
        '
        Me.lbAuthorId.AutoSize = True
        Me.lbAuthorId.Location = New System.Drawing.Point(171, 70)
        Me.lbAuthorId.Name = "lbAuthorId"
        Me.lbAuthorId.Size = New System.Drawing.Size(0, 12)
        Me.lbAuthorId.TabIndex = 18
        Me.lbAuthorId.Visible = False
        '
        'FormBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 361)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lbAuthorId)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.ccbType)
        Me.Controls.Add(Me.lbNewTime)
        Me.Controls.Add(Me.llbNewChapter)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBookInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "详细信息"
        CType(Me.dgvChapterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents llbNewChapter As LinkLabel
    Friend WithEvents lbNewTime As Label
    Friend WithEvents ccbType As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvChapterList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbType As Label
    Friend WithEvents chapterId As DataGridViewTextBoxColumn
    Friend WithEvents chapterNum As DataGridViewTextBoxColumn
    Friend WithEvents chapterName As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbAuthorId As Label
End Class
