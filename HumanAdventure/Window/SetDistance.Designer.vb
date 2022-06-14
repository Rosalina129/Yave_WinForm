<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetDistance
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
        Me.currentdistance = New System.Windows.Forms.Label()
        Me.currentregion = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'currentdistance
        '
        Me.currentdistance.AutoSize = True
        Me.currentdistance.Location = New System.Drawing.Point(15, 62)
        Me.currentdistance.Name = "currentdistance"
        Me.currentdistance.Size = New System.Drawing.Size(51, 15)
        Me.currentdistance.TabIndex = 0
        Me.currentdistance.Text = "distance"
        '
        'currentregion
        '
        Me.currentregion.AutoSize = True
        Me.currentregion.Location = New System.Drawing.Point(15, 42)
        Me.currentregion.Name = "currentregion"
        Me.currentregion.Size = New System.Drawing.Size(41, 15)
        Me.currentregion.TabIndex = 1
        Me.currentregion.Text = "region"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.title.Location = New System.Drawing.Point(12, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(44, 25)
        Me.title.TabIndex = 2
        Me.title.Text = "title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SetDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(168, 144)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.currentregion)
        Me.Controls.Add(Me.currentdistance)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetDistance"
        Me.ShowIcon = False
        Me.Text = "SetDistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents currentdistance As Label
    Friend WithEvents currentregion As Label
    Friend WithEvents title As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
