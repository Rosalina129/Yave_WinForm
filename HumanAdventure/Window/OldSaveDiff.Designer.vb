<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldSaveDiff
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
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.DifficultySelect = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.Location = New System.Drawing.Point(12, 9)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(234, 15)
        Me.Title1.TabIndex = 0
        Me.Title1.Text = "Looks like you're still using the old version?"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.Location = New System.Drawing.Point(12, 24)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(349, 15)
        Me.Title2.TabIndex = 1
        Me.Title2.Text = "So choose a difficulty and continue your adventure from scratch!"
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(139, 42)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 20
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'DifficultySelect
        '
        Me.DifficultySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DifficultySelect.FormattingEnabled = True
        Me.DifficultySelect.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.DifficultySelect.Location = New System.Drawing.Point(12, 42)
        Me.DifficultySelect.Name = "DifficultySelect"
        Me.DifficultySelect.Size = New System.Drawing.Size(121, 23)
        Me.DifficultySelect.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Start Your Adventure!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OldSaveDiff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 76)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.DifficultySelect)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.Title1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OldSaveDiff"
        Me.Text = "OldSaveDiff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title1 As Label
    Friend WithEvents Title2 As Label
    Friend WithEvents HelpButton As Button
    Friend WithEvents DifficultySelect As ComboBox
    Friend WithEvents Button1 As Button
End Class
