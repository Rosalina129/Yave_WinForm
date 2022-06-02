<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game Work")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Language")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Common", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SettingPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OtherPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LanguagePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LanguagesEN = New System.Windows.Forms.RadioButton()
        Me.LanguagesCH = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GameWorkPanel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AutosaveButton = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Labela3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Labela1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        Me.SettingPanel.SuspendLayout()
        Me.OtherPanel.SuspendLayout()
        Me.LanguagePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GameWorkPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode13.Name = "GameWork"
        TreeNode13.Tag = "1"
        TreeNode13.Text = "Game Work"
        TreeNode14.Name = "Language"
        TreeNode14.Tag = "2"
        TreeNode14.Text = "Language"
        TreeNode15.Name = "Other"
        TreeNode15.Tag = "3"
        TreeNode15.Text = "Other"
        TreeNode16.Checked = True
        TreeNode16.Name = "Common"
        TreeNode16.Tag = "0"
        TreeNode16.Text = "Common"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.TreeView1.Size = New System.Drawing.Size(187, 318)
        Me.TreeView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Settings"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SettingPanel)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 318)
        Me.Panel1.TabIndex = 2
        '
        'SettingPanel
        '
        Me.SettingPanel.AutoScroll = True
        Me.SettingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SettingPanel.Controls.Add(Me.Label2)
        Me.SettingPanel.Location = New System.Drawing.Point(193, 0)
        Me.SettingPanel.Name = "SettingPanel"
        Me.SettingPanel.Size = New System.Drawing.Size(348, 318)
        Me.SettingPanel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select a Root."
        '
        'OtherPanel
        '
        Me.OtherPanel.Controls.Add(Me.Label6)
        Me.OtherPanel.Controls.Add(Me.Label5)
        Me.OtherPanel.Location = New System.Drawing.Point(205, 361)
        Me.OtherPanel.Name = "OtherPanel"
        Me.OtherPanel.Size = New System.Drawing.Size(346, 316)
        Me.OtherPanel.TabIndex = 6
        Me.OtherPanel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "In Progress..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Other"
        '
        'LanguagePanel
        '
        Me.LanguagePanel.Controls.Add(Me.Label7)
        Me.LanguagePanel.Controls.Add(Me.Panel2)
        Me.LanguagePanel.Controls.Add(Me.TextBox2)
        Me.LanguagePanel.Controls.Add(Me.Label4)
        Me.LanguagePanel.Location = New System.Drawing.Point(579, 37)
        Me.LanguagePanel.Name = "LanguagePanel"
        Me.LanguagePanel.Size = New System.Drawing.Size(346, 316)
        Me.LanguagePanel.TabIndex = 5
        Me.LanguagePanel.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LanguagesEN)
        Me.Panel2.Controls.Add(Me.LanguagesCH)
        Me.Panel2.Location = New System.Drawing.Point(8, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 50)
        Me.Panel2.TabIndex = 6
        '
        'LanguagesEN
        '
        Me.LanguagesEN.AutoSize = True
        Me.LanguagesEN.Location = New System.Drawing.Point(3, 3)
        Me.LanguagesEN.Name = "LanguagesEN"
        Me.LanguagesEN.Size = New System.Drawing.Size(88, 19)
        Me.LanguagesEN.TabIndex = 4
        Me.LanguagesEN.TabStop = True
        Me.LanguagesEN.Text = "English (US)"
        Me.LanguagesEN.UseVisualStyleBackColor = True
        '
        'LanguagesCH
        '
        Me.LanguagesCH.AutoSize = True
        Me.LanguagesCH.Location = New System.Drawing.Point(3, 28)
        Me.LanguagesCH.Name = "LanguagesCH"
        Me.LanguagesCH.Size = New System.Drawing.Size(156, 19)
        Me.LanguagesCH.TabIndex = 5
        Me.LanguagesCH.TabStop = True
        Me.LanguagesCH.Text = "Chinese Simplified (PRC)"
        Me.LanguagesCH.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(8, 31)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(335, 34)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "Currently the program is not perfect, the subsequent open language configuration " &
    "file system."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Language"
        '
        'GameWorkPanel
        '
        Me.GameWorkPanel.Controls.Add(Me.Button3)
        Me.GameWorkPanel.Controls.Add(Me.Label8)
        Me.GameWorkPanel.Controls.Add(Me.AutosaveButton)
        Me.GameWorkPanel.Controls.Add(Me.Button2)
        Me.GameWorkPanel.Controls.Add(Me.Labela3)
        Me.GameWorkPanel.Controls.Add(Me.Button1)
        Me.GameWorkPanel.Controls.Add(Me.TextBox1)
        Me.GameWorkPanel.Controls.Add(Me.Labela1)
        Me.GameWorkPanel.Controls.Add(Me.Label3)
        Me.GameWorkPanel.Location = New System.Drawing.Point(579, 359)
        Me.GameWorkPanel.Name = "GameWorkPanel"
        Me.GameWorkPanel.Size = New System.Drawing.Size(346, 316)
        Me.GameWorkPanel.TabIndex = 4
        Me.GameWorkPanel.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = ".."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Auto Save"
        '
        'AutosaveButton
        '
        Me.AutosaveButton.AutoSize = True
        Me.AutosaveButton.Location = New System.Drawing.Point(8, 153)
        Me.AutosaveButton.Name = "AutosaveButton"
        Me.AutosaveButton.Size = New System.Drawing.Size(128, 19)
        Me.AutosaveButton.TabIndex = 8
        Me.AutosaveButton.Text = "Enable Auto Saving"
        Me.AutosaveButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Set"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Labela3
        '
        Me.Labela3.AutoSize = True
        Me.Labela3.Location = New System.Drawing.Point(5, 46)
        Me.Labela3.Name = "Labela3"
        Me.Labela3.Size = New System.Drawing.Size(94, 15)
        Me.Labela3.TabIndex = 2
        Me.Labela3.Text = "Choose the path"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(306, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Labela1
        '
        Me.Labela1.AutoSize = True
        Me.Labela1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Labela1.Location = New System.Drawing.Point(4, 25)
        Me.Labela1.Name = "Labela1"
        Me.Labela1.Size = New System.Drawing.Size(151, 21)
        Me.Labela1.TabIndex = 1
        Me.Labela1.Text = "Game Work Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Game Work"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(277, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Your Settings will be changed when program starts."
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 645)
        Me.Controls.Add(Me.OtherPanel)
        Me.Controls.Add(Me.GameWorkPanel)
        Me.Controls.Add(Me.LanguagePanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.SettingPanel.ResumeLayout(False)
        Me.SettingPanel.PerformLayout()
        Me.OtherPanel.ResumeLayout(False)
        Me.OtherPanel.PerformLayout()
        Me.LanguagePanel.ResumeLayout(False)
        Me.LanguagePanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GameWorkPanel.ResumeLayout(False)
        Me.GameWorkPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SettingPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GameWorkPanel As Panel
    Friend WithEvents LanguagePanel As Panel
    Friend WithEvents OtherPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Labela3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AutosaveButton As CheckBox
    Friend WithEvents Labela1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LanguagesCH As RadioButton
    Friend WithEvents LanguagesEN As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
