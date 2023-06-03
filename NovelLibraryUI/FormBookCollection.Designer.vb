<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookCollection
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
        Me.dgvcollection = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.bId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvcollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvcollection)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 321)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgvcollection
        '
        Me.dgvcollection.AllowUserToAddRows = False
        Me.dgvcollection.AllowUserToDeleteRows = False
        Me.dgvcollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcollection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bId, Me.bName, Me.cTime})
        Me.dgvcollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcollection.Location = New System.Drawing.Point(3, 17)
        Me.dgvcollection.MultiSelect = False
        Me.dgvcollection.Name = "dgvcollection"
        Me.dgvcollection.ReadOnly = True
        Me.dgvcollection.RowTemplate.Height = 23
        Me.dgvcollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcollection.Size = New System.Drawing.Size(444, 301)
        Me.dgvcollection.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(453, 295)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "移除"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'bId
        '
        Me.bId.DataPropertyName = "bId"
        Me.bId.HeaderText = "编号"
        Me.bId.Name = "bId"
        Me.bId.ReadOnly = True
        '
        'bName
        '
        Me.bName.DataPropertyName = "bName"
        Me.bName.HeaderText = "书名"
        Me.bName.Name = "bName"
        Me.bName.ReadOnly = True
        Me.bName.Width = 150
        '
        'cTime
        '
        Me.cTime.DataPropertyName = "cTime"
        Me.cTime.HeaderText = "时间"
        Me.cTime.Name = "cTime"
        Me.cTime.ReadOnly = True
        Me.cTime.Width = 150
        '
        'FormBookCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 321)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBookCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "书架"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvcollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvcollection As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents bId As DataGridViewTextBoxColumn
    Friend WithEvents bName As DataGridViewTextBoxColumn
    Friend WithEvents cTime As DataGridViewTextBoxColumn
End Class
