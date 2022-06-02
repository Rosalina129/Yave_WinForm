<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.JSONFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAttackTo9999ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDefenseTo999ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProBasic = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SkillBasic = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CDLabel = New System.Windows.Forms.Label()
        Me.CRLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SELabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DEFLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ATKLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HEALTHLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UpgradeLabel = New System.Windows.Forms.Label()
        Me.XPLabel = New System.Windows.Forms.Label()
        Me.CharName = New System.Windows.Forms.Label()
        Me.CharNameStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XPBar = New System.Windows.Forms.ProgressBar()
        Me.XPMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XPMenuStrip1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.SaveDataDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CoinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ProBasic.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CharNameStrip.SuspendLayout()
        Me.XPMenu.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ShowDebugToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CoinsToolStripMenuItem, Me.ToolStripTextBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaveToolStripMenuItem, Me.SaveDataToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.LoadDataToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 23)
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
        'TextFormatToolStripMenuItem
        '
        Me.TextFormatToolStripMenuItem.Name = "TextFormatToolStripMenuItem"
        Me.TextFormatToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TextFormatToolStripMenuItem.Text = "Text Format"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'JSONFormatToolStripMenuItem
        '
        Me.JSONFormatToolStripMenuItem.Enabled = False
        Me.JSONFormatToolStripMenuItem.Name = "JSONFormatToolStripMenuItem"
        Me.JSONFormatToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemListToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.ViewToolStripMenuItem.Text = "Options"
        '
        'ItemListToolStripMenuItem
        '
        Me.ItemListToolStripMenuItem.Name = "ItemListToolStripMenuItem"
        Me.ItemListToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ItemListToolStripMenuItem.Text = "Item List"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ShowDebugToolStripMenuItem
        '
        Me.ShowDebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HealHPToolStripMenuItem, Me.SetAttackTo9999ToolStripMenuItem, Me.SetDefenseTo999ToolStripMenuItem})
        Me.ShowDebugToolStripMenuItem.Name = "ShowDebugToolStripMenuItem"
        Me.ShowDebugToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.ShowDebugToolStripMenuItem.Text = "Experimental"
        '
        'HealHPToolStripMenuItem
        '
        Me.HealHPToolStripMenuItem.Name = "HealHPToolStripMenuItem"
        Me.HealHPToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HealHPToolStripMenuItem.Text = "Heal HP"
        '
        'SetAttackTo9999ToolStripMenuItem
        '
        Me.SetAttackTo9999ToolStripMenuItem.Name = "SetAttackTo9999ToolStripMenuItem"
        Me.SetAttackTo9999ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SetAttackTo9999ToolStripMenuItem.Text = "Set Attack to 9999"
        '
        'SetDefenseTo999ToolStripMenuItem
        '
        Me.SetDefenseTo999ToolStripMenuItem.Name = "SetDefenseTo999ToolStripMenuItem"
        Me.SetDefenseTo999ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SetDefenseTo999ToolStripMenuItem.Text = "Set Defense to 999"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutsToolStripMenuItem, Me.FeedbackToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutsToolStripMenuItem
        '
        Me.AboutsToolStripMenuItem.Name = "AboutsToolStripMenuItem"
        Me.AboutsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutsToolStripMenuItem.Text = "About Software"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 529)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ProBasic)
        Me.TabControl1.Controls.Add(Me.SkillBasic)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 256)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(239, 271)
        Me.TabControl1.TabIndex = 8
        '
        'ProBasic
        '
        Me.ProBasic.Controls.Add(Me.TextBox2)
        Me.ProBasic.Location = New System.Drawing.Point(4, 24)
        Me.ProBasic.Name = "ProBasic"
        Me.ProBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.ProBasic.Size = New System.Drawing.Size(231, 243)
        Me.ProBasic.TabIndex = 0
        Me.ProBasic.Text = "Basic"
        Me.ProBasic.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(4, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 257)
        Me.TextBox2.TabIndex = 16
        '
        'SkillBasic
        '
        Me.SkillBasic.Location = New System.Drawing.Point(4, 24)
        Me.SkillBasic.Name = "SkillBasic"
        Me.SkillBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.SkillBasic.Size = New System.Drawing.Size(231, 243)
        Me.SkillBasic.TabIndex = 1
        Me.SkillBasic.Text = "Skill"
        Me.SkillBasic.UseVisualStyleBackColor = True
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
        Me.Panel3.Controls.Add(Me.DEFLabel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ATKLabel)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.HEALTHLabel)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(4, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 160)
        Me.Panel3.TabIndex = 7
        '
        'CDLabel
        '
        Me.CDLabel.AutoSize = True
        Me.CDLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CDLabel.Location = New System.Drawing.Point(115, 138)
        Me.CDLabel.Name = "CDLabel"
        Me.CDLabel.Size = New System.Drawing.Size(38, 15)
        Me.CDLabel.TabIndex = 18
        Me.CDLabel.Text = "cdmg"
        Me.CDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CRLabel
        '
        Me.CRLabel.AutoSize = True
        Me.CRLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CRLabel.Location = New System.Drawing.Point(115, 118)
        Me.CRLabel.Name = "CRLabel"
        Me.CRLabel.Size = New System.Drawing.Size(33, 15)
        Me.CRLabel.TabIndex = 17
        Me.CRLabel.Text = "crate"
        Me.CRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(5, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Crit Damage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(5, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Crit Rate"
        '
        'SELabel
        '
        Me.SELabel.AutoSize = True
        Me.SELabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SELabel.Location = New System.Drawing.Point(115, 98)
        Me.SELabel.Name = "SELabel"
        Me.SELabel.Size = New System.Drawing.Size(48, 15)
        Me.SELabel.TabIndex = 14
        Me.SELabel.Text = "senergy"
        Me.SELabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(5, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Star Energy"
        '
        'DEFLabel
        '
        Me.DEFLabel.AutoSize = True
        Me.DEFLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DEFLabel.Location = New System.Drawing.Point(115, 78)
        Me.DEFLabel.Name = "DEFLabel"
        Me.DEFLabel.Size = New System.Drawing.Size(48, 15)
        Me.DEFLabel.TabIndex = 12
        Me.DEFLabel.Text = "defense"
        Me.DEFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(5, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Defense"
        '
        'ATKLabel
        '
        Me.ATKLabel.AutoSize = True
        Me.ATKLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ATKLabel.Location = New System.Drawing.Point(115, 58)
        Me.ATKLabel.Name = "ATKLabel"
        Me.ATKLabel.Size = New System.Drawing.Size(39, 15)
        Me.ATKLabel.TabIndex = 10
        Me.ATKLabel.Text = "attack"
        Me.ATKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Attack"
        '
        'HEALTHLabel
        '
        Me.HEALTHLabel.AutoSize = True
        Me.HEALTHLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HEALTHLabel.Location = New System.Drawing.Point(115, 38)
        Me.HEALTHLabel.Name = "HEALTHLabel"
        Me.HEALTHLabel.Size = New System.Drawing.Size(107, 15)
        Me.HEALTHLabel.TabIndex = 8
        Me.HEALTHLabel.Text = "health / maxhealth"
        Me.HEALTHLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(5, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Health"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Properties"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UpgradeLabel)
        Me.Panel2.Controls.Add(Me.XPLabel)
        Me.Panel2.Controls.Add(Me.CharName)
        Me.Panel2.Controls.Add(Me.XPBar)
        Me.Panel2.Controls.Add(Me.LabelLevel)
        Me.Panel2.Controls.Add(Me.Level)
        Me.Panel2.Location = New System.Drawing.Point(36, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 81)
        Me.Panel2.TabIndex = 6
        '
        'UpgradeLabel
        '
        Me.UpgradeLabel.AutoSize = True
        Me.UpgradeLabel.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.UpgradeLabel.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.UpgradeLabel.Location = New System.Drawing.Point(127, 30)
        Me.UpgradeLabel.Name = "UpgradeLabel"
        Me.UpgradeLabel.Size = New System.Drawing.Size(68, 15)
        Me.UpgradeLabel.TabIndex = 7
        Me.UpgradeLabel.Text = "Upgradable"
        Me.UpgradeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'XPLabel
        '
        Me.XPLabel.AutoSize = True
        Me.XPLabel.Location = New System.Drawing.Point(3, 61)
        Me.XPLabel.Name = "XPLabel"
        Me.XPLabel.Size = New System.Drawing.Size(20, 15)
        Me.XPLabel.TabIndex = 6
        Me.XPLabel.Text = "xp"
        Me.XPLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'XPBar
        '
        Me.XPBar.ContextMenuStrip = Me.XPMenu
        Me.XPBar.Location = New System.Drawing.Point(6, 48)
        Me.XPBar.MarqueeAnimationSpeed = 1
        Me.XPBar.Maximum = 400
        Me.XPBar.Name = "XPBar"
        Me.XPBar.Size = New System.Drawing.Size(189, 10)
        Me.XPBar.Step = 1
        Me.XPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.XPBar.TabIndex = 5
        '
        'XPMenu
        '
        Me.XPMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XPMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XPMenuStrip1})
        Me.XPMenu.Name = "ContextMenuStrip1"
        Me.XPMenu.Size = New System.Drawing.Size(88, 26)
        '
        'XPMenuStrip1
        '
        Me.XPMenuStrip1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpgradeToolStripMenuItem})
        Me.XPMenuStrip1.Enabled = False
        Me.XPMenuStrip1.Name = "XPMenuStrip1"
        Me.XPMenuStrip1.Size = New System.Drawing.Size(87, 22)
        Me.XPMenuStrip1.Text = "xp"
        '
        'UpgradeToolStripMenuItem
        '
        Me.UpgradeToolStripMenuItem.Name = "UpgradeToolStripMenuItem"
        Me.UpgradeToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UpgradeToolStripMenuItem.Text = "Upgrade"
        '
        'LabelLevel
        '
        Me.LabelLevel.AutoSize = True
        Me.LabelLevel.Location = New System.Drawing.Point(3, 30)
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(34, 15)
        Me.LabelLevel.TabIndex = 3
        Me.LabelLevel.Text = "Level"
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level.Location = New System.Drawing.Point(36, 24)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(19, 21)
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
        Me.Timer1.Interval = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(255, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(452, 529)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(713, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(710, 542)
        Me.Panel5.TabIndex = 8
        Me.Panel5.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(582, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "New Game"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Load Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Yave's Tours"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.HumanAdventure.My.Resources.Resources.YaveYuFamily
        Me.PictureBox2.Location = New System.Drawing.Point(247, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(228, 217)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HumanAdventure.My.Resources.Resources.yave_1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 66)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CoinsToolStripMenuItem
        '
        Me.CoinsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CoinsToolStripMenuItem.Image = Global.HumanAdventure.My.Resources.Resources.spr_coin_0
        Me.CoinsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CoinsToolStripMenuItem.Name = "CoinsToolStripMenuItem"
        Me.CoinsToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.CoinsToolStripMenuItem.Text = "coins"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "0"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(713, 562)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Yave's Tours"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ProBasic.ResumeLayout(False)
        Me.ProBasic.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CharNameStrip.ResumeLayout(False)
        Me.XPMenu.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XPLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ProBasic As TabPage
    Friend WithEvents SkillBasic As TabPage
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents UpgradeLabel As Label
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HealHPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetAttackTo9999ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetDefenseTo999ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoinsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
