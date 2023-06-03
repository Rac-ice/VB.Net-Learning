<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChapterContent
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbWordCount = New System.Windows.Forms.Label()
        Me.lbPTime = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbChapter = New System.Windows.Forms.Label()
        Me.lbCName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbPTime)
        Me.GroupBox1.Controls.Add(Me.lbWordCount)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 641)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1264, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lbWordCount
        '
        Me.lbWordCount.AutoSize = True
        Me.lbWordCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbWordCount.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbWordCount.ForeColor = System.Drawing.Color.Red
        Me.lbWordCount.Location = New System.Drawing.Point(3, 19)
        Me.lbWordCount.Name = "lbWordCount"
        Me.lbWordCount.Size = New System.Drawing.Size(35, 14)
        Me.lbWordCount.TabIndex = 0
        Me.lbWordCount.Text = "test"
        '
        'lbPTime
        '
        Me.lbPTime.AutoSize = True
        Me.lbPTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbPTime.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbPTime.ForeColor = System.Drawing.Color.Blue
        Me.lbPTime.Location = New System.Drawing.Point(1226, 19)
        Me.lbPTime.Name = "lbPTime"
        Me.lbPTime.Size = New System.Drawing.Size(35, 14)
        Me.lbPTime.TabIndex = 1
        Me.lbPTime.Text = "test"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbCName)
        Me.GroupBox2.Controls.Add(Me.lbChapter)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1264, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lbChapter
        '
        Me.lbChapter.AutoSize = True
        Me.lbChapter.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbChapter.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbChapter.ForeColor = System.Drawing.Color.Blue
        Me.lbChapter.Location = New System.Drawing.Point(3, 17)
        Me.lbChapter.Name = "lbChapter"
        Me.lbChapter.Size = New System.Drawing.Size(75, 19)
        Me.lbChapter.TabIndex = 0
        Me.lbChapter.Text = "Label1"
        '
        'lbCName
        '
        Me.lbCName.AutoSize = True
        Me.lbCName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbCName.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCName.ForeColor = System.Drawing.Color.Black
        Me.lbCName.Location = New System.Drawing.Point(78, 17)
        Me.lbCName.Name = "lbCName"
        Me.lbCName.Size = New System.Drawing.Size(75, 19)
        Me.lbCName.TabIndex = 1
        Me.lbCName.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(1149, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "发布时间："
        '
        'txtContent
        '
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtContent.Location = New System.Drawing.Point(0, 50)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = True
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(1264, 591)
        Me.txtContent.TabIndex = 50
        '
        'FormChapterContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChapterContent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "内容"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbWordCount As Label
    Friend WithEvents lbPTime As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbCName As Label
    Friend WithEvents lbChapter As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContent As TextBox
End Class
