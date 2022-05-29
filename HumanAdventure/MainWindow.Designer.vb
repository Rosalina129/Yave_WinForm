<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JSONFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CDLabel = New System.Windows.Forms.Label()
        Me.CharNameStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SELabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Spe1 = New System.Windows.Forms.Label()
        Me.DEFLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ATKLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HEALTHLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CharName = New System.Windows.Forms.Label()
        Me.XPBar = New System.Windows.Forms.ProgressBar()
        Me.XPMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XPMenuStrip1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.SaveDataDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.CharNameStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.XPMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ShowDebugToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(557, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaveToolStripMenuItem, Me.SaveDataToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.LoadDataToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewSaveToolStripMenuItem
        '
        Me.NewSaveToolStripMenuItem.Name = "NewSaveToolStripMenuItem"
        Me.NewSaveToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.NewSaveToolStripMenuItem.Text = "New Save"
        '
        'SaveDataToolStripMenuItem
        '
        Me.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        Me.SaveDataToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveDataToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SaveDataToolStripMenuItem.Text = "Save Data..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFormatToolStripMenuItem, Me.ToolStripSeparator1, Me.JSONFormatToolStripMenuItem})
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'JSONFormatToolStripMenuItem
        '
        Me.JSONFormatToolStripMenuItem.Enabled = False
        Me.JSONFormatToolStripMenuItem.Name = "JSONFormatToolStripMenuItem"
        Me.JSONFormatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JSONFormatToolStripMenuItem.Text = "JSON Format"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.LoadDataToolStripMenuItem.Text = "Load Data..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemListToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ItemListToolStripMenuItem
        '
        Me.ItemListToolStripMenuItem.Name = "ItemListToolStripMenuItem"
        Me.ItemListToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ItemListToolStripMenuItem.Text = "Item List"
        '
        'ShowDebugToolStripMenuItem
        '
        Me.ShowDebugToolStripMenuItem.Name = "ShowDebugToolStripMenuItem"
        Me.ShowDebugToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ShowDebugToolStripMenuItem.Text = "Experimental"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutsToolStripMenuItem
        '
        Me.AboutsToolStripMenuItem.Name = "AboutsToolStripMenuItem"
        Me.AboutsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutsToolStripMenuItem.Text = "About Software"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 84)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 529)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CDLabel)
        Me.Panel3.Controls.Add(Me.CRLabel)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.SELabel)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Spe1)
        Me.Panel3.Controls.Add(Me.DEFLabel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ATKLabel)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.HEALTHLabel)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(3, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(219, 224)
        Me.Panel3.TabIndex = 7
        '
        'CDLabel
        '
        Me.CDLabel.AutoSize = True
        Me.CDLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CDLabel.Location = New System.Drawing.Point(113, 125)
        Me.CDLabel.Name = "CDLabel"
        Me.CDLabel.Size = New System.Drawing.Size(38, 20)
        Me.CDLabel.TabIndex = 18
        Me.CDLabel.Text = "+0.5"
        Me.CDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CharNameStrip
        '
        Me.CharNameStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharNameStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeNameToolStripMenuItem})
        Me.CharNameStrip.Name = "ContextMenuStrip1"
        Me.CharNameStrip.Size = New System.Drawing.Size(151, 26)
        '
        'ChangeNameToolStripMenuItem
        '
        Me.ChangeNameToolStripMenuItem.Name = "ChangeNameToolStripMenuItem"
        Me.ChangeNameToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ChangeNameToolStripMenuItem.Text = "Change Name"
        '
        'CRLabel
        '
        Me.CRLabel.AutoSize = True
        Me.CRLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CRLabel.Location = New System.Drawing.Point(113, 105)
        Me.CRLabel.Name = "CRLabel"
        Me.CRLabel.Size = New System.Drawing.Size(36, 20)
        Me.CRLabel.TabIndex = 17
        Me.CRLabel.Text = "0.01"
        Me.CRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(3, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Crit Damage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Crit Rate"
        '
        'SELabel
        '
        Me.SELabel.AutoSize = True
        Me.SELabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.SELabel.Location = New System.Drawing.Point(113, 85)
        Me.SELabel.Name = "SELabel"
        Me.SELabel.Size = New System.Drawing.Size(25, 20)
        Me.SELabel.TabIndex = 14
        Me.SELabel.Text = "50"
        Me.SELabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Star Energy"
        '
        'Spe1
        '
        Me.Spe1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Spe1.Location = New System.Drawing.Point(6, 23)
        Me.Spe1.Name = "Spe1"
        Me.Spe1.Size = New System.Drawing.Size(206, 2)
        Me.Spe1.TabIndex = 8
        '
        'DEFLabel
        '
        Me.DEFLabel.AutoSize = True
        Me.DEFLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DEFLabel.Location = New System.Drawing.Point(113, 65)
        Me.DEFLabel.Name = "DEFLabel"
        Me.DEFLabel.Size = New System.Drawing.Size(17, 20)
        Me.DEFLabel.TabIndex = 12
        Me.DEFLabel.Text = "4"
        Me.DEFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Defense"
        '
        'ATKLabel
        '
        Me.ATKLabel.AutoSize = True
        Me.ATKLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ATKLabel.Location = New System.Drawing.Point(113, 45)
        Me.ATKLabel.Name = "ATKLabel"
        Me.ATKLabel.Size = New System.Drawing.Size(17, 20)
        Me.ATKLabel.TabIndex = 10
        Me.ATKLabel.Text = "8"
        Me.ATKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Attack"
        '
        'HEALTHLabel
        '
        Me.HEALTHLabel.AutoSize = True
        Me.HEALTHLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.HEALTHLabel.Location = New System.Drawing.Point(113, 25)
        Me.HEALTHLabel.Name = "HEALTHLabel"
        Me.HEALTHLabel.Size = New System.Drawing.Size(63, 20)
        Me.HEALTHLabel.TabIndex = 8
        Me.HEALTHLabel.Text = "100/100"
        Me.HEALTHLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Health"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Properties"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CharName)
        Me.Panel2.Controls.Add(Me.XPBar)
        Me.Panel2.Controls.Add(Me.LabelLevel)
        Me.Panel2.Controls.Add(Me.Level)
        Me.Panel2.Location = New System.Drawing.Point(81, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 84)
        Me.Panel2.TabIndex = 6
        '
        'CharName
        '
        Me.CharName.AutoSize = True
        Me.CharName.ContextMenuStrip = Me.CharNameStrip
        Me.CharName.Location = New System.Drawing.Point(3, 9)
        Me.CharName.Name = "CharName"
        Me.CharName.Size = New System.Drawing.Size(86, 15)
        Me.CharName.TabIndex = 2
        Me.CharName.Text = "charactername"
        '
        'XPBar
        '
        Me.XPBar.ContextMenuStrip = Me.XPMenu
        Me.XPBar.Location = New System.Drawing.Point(3, 57)
        Me.XPBar.MarqueeAnimationSpeed = 1
        Me.XPBar.Maximum = 400
        Me.XPBar.Name = "XPBar"
        Me.XPBar.Size = New System.Drawing.Size(132, 23)
        Me.XPBar.Step = 1
        Me.XPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.XPBar.TabIndex = 5
        '
        'XPMenu
        '
        Me.XPMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XPMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XPMenuStrip1})
        Me.XPMenu.Name = "ContextMenuStrip1"
        Me.XPMenu.Size = New System.Drawing.Size(104, 26)
        '
        'XPMenuStrip1
        '
        Me.XPMenuStrip1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpgradeToolStripMenuItem})
        Me.XPMenuStrip1.Enabled = False
        Me.XPMenuStrip1.Name = "XPMenuStrip1"
        Me.XPMenuStrip1.Size = New System.Drawing.Size(180, 22)
        Me.XPMenuStrip1.Text = "0/100"
        '
        'LabelLevel
        '
        Me.LabelLevel.AutoSize = True
        Me.LabelLevel.Location = New System.Drawing.Point(3, 36)
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(34, 15)
        Me.LabelLevel.TabIndex = 3
        Me.LabelLevel.Text = "Level"
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Level.Location = New System.Drawing.Point(43, 24)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(25, 30)
        Me.Level.TabIndex = 4
        Me.Level.Text = "1"
        Me.Level.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SaveDataDialog
        '
        Me.SaveDataDialog.Filter = "Binary Data Files|*.dat"
        Me.SaveDataDialog.InitialDirectory = "%username%/Documents/Unreal_Neo/Word games collection/Human Adventure"
        Me.SaveDataDialog.Title = "Save Data Files..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 16
        '
        'UpgradeToolStripMenuItem
        '
        Me.UpgradeToolStripMenuItem.Name = "UpgradeToolStripMenuItem"
        Me.UpgradeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpgradeToolStripMenuItem.Text = "Upgrade"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'TextFormatToolStripMenuItem
        '
        Me.TextFormatToolStripMenuItem.Name = "TextFormatToolStripMenuItem"
        Me.TextFormatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextFormatToolStripMenuItem.Text = "Text Format"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(557, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainWindow"
        Me.Text = "Yave's Tours"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.CharNameStrip.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.XPMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CharName As Label
    Friend WithEvents ShowDebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelLevel As Label
    Friend WithEvents Level As Label
    Friend WithEvents XPBar As ProgressBar
    Friend WithEvents CharNameStrip As ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ChangeNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveDataDialog As SaveFileDialog
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JSONFormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HEALTHLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ATKLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DEFLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Spe1 As Label
    Friend WithEvents SELabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CDLabel As Label
    Friend WithEvents CRLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents XPMenu As ContextMenuStrip
    Friend WithEvents XPMenuStrip1 As ToolStripMenuItem
    Friend WithEvents UpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextFormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
