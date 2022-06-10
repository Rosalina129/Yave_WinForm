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
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HealHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProBasic = New System.Windows.Forms.TabPage()
        Me.SkillBasic = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UpgradeBut6 = New System.Windows.Forms.Button()
        Me.UpgradeBut5 = New System.Windows.Forms.Button()
        Me.UpgradeBut4 = New System.Windows.Forms.Button()
        Me.UpgradeBut3 = New System.Windows.Forms.Button()
        Me.UpgradeBut2 = New System.Windows.Forms.Button()
        Me.UpgradeBut1 = New System.Windows.Forms.Button()
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
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.XPLabel = New System.Windows.Forms.Label()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.CharName = New System.Windows.Forms.Label()
        Me.CharNameStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XPBar = New System.Windows.Forms.ProgressBar()
        Me.XPMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XPMenuStrip1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Tour = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CurEnemyData6 = New System.Windows.Forms.Label()
        Me.CurEnemyData5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BattleMessage = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CurEnemyData4 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CurEnemyData3 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CurEnemyData2 = New System.Windows.Forms.Label()
        Me.CurEnemyData1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.Equipment = New System.Windows.Forms.TabPage()
        Me.Options = New System.Windows.Forms.TabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.EasterEgg = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Experimental = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DamageCountBox = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EnemyXPBox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.EnemyHealthBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EnemyDefenseBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EnemyAttackBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AttributeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AutoBattleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BattleTime = New System.Windows.Forms.Timer(Me.components)
        Me.BattleCooldown = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CharNameStrip.SuspendLayout()
        Me.XPMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Tour.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Options.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Experimental.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ShowDebugToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CoinsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaveToolStripMenuItem, Me.LoadDataToolStripMenuItem, Me.SaveDataToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewSaveToolStripMenuItem
        '
        Me.NewSaveToolStripMenuItem.Name = "NewSaveToolStripMenuItem"
        Me.NewSaveToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NewSaveToolStripMenuItem.Text = "New Save"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LoadDataToolStripMenuItem.Text = "Load Game..."
        '
        'SaveDataToolStripMenuItem
        '
        Me.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem"
        Me.SaveDataToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveDataToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SaveDataToolStripMenuItem.Text = "Save Game..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemListToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ViewToolStripMenuItem.Text = "Options"
        '
        'ItemListToolStripMenuItem
        '
        Me.ItemListToolStripMenuItem.Name = "ItemListToolStripMenuItem"
        Me.ItemListToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ItemListToolStripMenuItem.Text = "Item List"
        '
        'ShowDebugToolStripMenuItem
        '
        Me.ShowDebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HealHPToolStripMenuItem, Me.CPPToolStripMenuItem})
        Me.ShowDebugToolStripMenuItem.Name = "ShowDebugToolStripMenuItem"
        Me.ShowDebugToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ShowDebugToolStripMenuItem.Text = "Experimental"
        '
        'HealHPToolStripMenuItem
        '
        Me.HealHPToolStripMenuItem.Name = "HealHPToolStripMenuItem"
        Me.HealHPToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.HealHPToolStripMenuItem.Text = "Heal HP"
        '
        'CPPToolStripMenuItem
        '
        Me.CPPToolStripMenuItem.Name = "CPPToolStripMenuItem"
        Me.CPPToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CPPToolStripMenuItem.Text = "Custom Player Properties"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutsToolStripMenuItem, Me.FeedbackToolStripMenuItem})
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
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'CoinsToolStripMenuItem
        '
        Me.CoinsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CoinsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemShopToolStripMenuItem, Me.UpgradeShopToolStripMenuItem})
        Me.CoinsToolStripMenuItem.Image = Global.HumanAdventure.My.Resources.Resources.spr_coin_0
        Me.CoinsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CoinsToolStripMenuItem.Name = "CoinsToolStripMenuItem"
        Me.CoinsToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.CoinsToolStripMenuItem.ToolTipText = "Test"
        '
        'ItemShopToolStripMenuItem
        '
        Me.ItemShopToolStripMenuItem.Name = "ItemShopToolStripMenuItem"
        Me.ItemShopToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ItemShopToolStripMenuItem.Text = "Item Shop"
        '
        'UpgradeShopToolStripMenuItem
        '
        Me.UpgradeShopToolStripMenuItem.Name = "UpgradeShopToolStripMenuItem"
        Me.UpgradeShopToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.UpgradeShopToolStripMenuItem.Text = "Upgrade Shop"
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 275)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(239, 252)
        Me.TabControl1.TabIndex = 8
        '
        'ProBasic
        '
        Me.ProBasic.Location = New System.Drawing.Point(4, 24)
        Me.ProBasic.Name = "ProBasic"
        Me.ProBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.ProBasic.Size = New System.Drawing.Size(231, 224)
        Me.ProBasic.TabIndex = 0
        Me.ProBasic.Text = "Basic"
        Me.ProBasic.UseVisualStyleBackColor = True
        '
        'SkillBasic
        '
        Me.SkillBasic.Location = New System.Drawing.Point(4, 24)
        Me.SkillBasic.Name = "SkillBasic"
        Me.SkillBasic.Padding = New System.Windows.Forms.Padding(3)
        Me.SkillBasic.Size = New System.Drawing.Size(231, 224)
        Me.SkillBasic.TabIndex = 1
        Me.SkillBasic.Text = "Skill"
        Me.SkillBasic.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UpgradeBut6)
        Me.Panel3.Controls.Add(Me.UpgradeBut5)
        Me.Panel3.Controls.Add(Me.UpgradeBut4)
        Me.Panel3.Controls.Add(Me.UpgradeBut3)
        Me.Panel3.Controls.Add(Me.UpgradeBut2)
        Me.Panel3.Controls.Add(Me.UpgradeBut1)
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
        Me.Panel3.Location = New System.Drawing.Point(5, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 160)
        Me.Panel3.TabIndex = 7
        '
        'UpgradeBut6
        '
        Me.UpgradeBut6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut6.Location = New System.Drawing.Point(208, 138)
        Me.UpgradeBut6.Name = "UpgradeBut6"
        Me.UpgradeBut6.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut6.TabIndex = 24
        Me.UpgradeBut6.Tag = "upgradebutton"
        Me.UpgradeBut6.Text = "+"
        Me.UpgradeBut6.UseVisualStyleBackColor = True
        '
        'UpgradeBut5
        '
        Me.UpgradeBut5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut5.Location = New System.Drawing.Point(208, 118)
        Me.UpgradeBut5.Name = "UpgradeBut5"
        Me.UpgradeBut5.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut5.TabIndex = 23
        Me.UpgradeBut5.Tag = "upgradebutton"
        Me.UpgradeBut5.Text = "+"
        Me.UpgradeBut5.UseVisualStyleBackColor = True
        '
        'UpgradeBut4
        '
        Me.UpgradeBut4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut4.Location = New System.Drawing.Point(208, 98)
        Me.UpgradeBut4.Name = "UpgradeBut4"
        Me.UpgradeBut4.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut4.TabIndex = 22
        Me.UpgradeBut4.Tag = "upgradebutton"
        Me.UpgradeBut4.Text = "+"
        Me.UpgradeBut4.UseVisualStyleBackColor = True
        '
        'UpgradeBut3
        '
        Me.UpgradeBut3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut3.Location = New System.Drawing.Point(208, 78)
        Me.UpgradeBut3.Name = "UpgradeBut3"
        Me.UpgradeBut3.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut3.TabIndex = 21
        Me.UpgradeBut3.Tag = "upgradebutton"
        Me.UpgradeBut3.Text = "+"
        Me.UpgradeBut3.UseVisualStyleBackColor = True
        '
        'UpgradeBut2
        '
        Me.UpgradeBut2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut2.Location = New System.Drawing.Point(208, 58)
        Me.UpgradeBut2.Name = "UpgradeBut2"
        Me.UpgradeBut2.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut2.TabIndex = 20
        Me.UpgradeBut2.Tag = "upgradebutton"
        Me.UpgradeBut2.Text = "+"
        Me.UpgradeBut2.UseVisualStyleBackColor = True
        '
        'UpgradeBut1
        '
        Me.UpgradeBut1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UpgradeBut1.Location = New System.Drawing.Point(208, 38)
        Me.UpgradeBut1.Name = "UpgradeBut1"
        Me.UpgradeBut1.Size = New System.Drawing.Size(18, 18)
        Me.UpgradeBut1.TabIndex = 19
        Me.UpgradeBut1.Tag = "upgradebutton"
        Me.UpgradeBut1.Text = "+"
        Me.UpgradeBut1.UseVisualStyleBackColor = True
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
        Me.AttributeToolTip.SetToolTip(Me.CDLabel, "Crit damage is the percentage of damage done based on a percentage of health.")
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
        Me.AttributeToolTip.SetToolTip(Me.CRLabel, "Crit rate determines chance you have to make a Critical hit if you take to damage" &
        " for enemy.")
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
        Me.AttributeToolTip.SetToolTip(Me.SELabel, "Star Energy is an attribute used to use skills.")
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
        Me.AttributeToolTip.SetToolTip(Me.DEFLabel, "Defense can block some of the damage done by the enemy.")
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
        Me.AttributeToolTip.SetToolTip(Me.ATKLabel, "Your attack determines how much damage is take to the enemy.")
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
        Me.AttributeToolTip.SetToolTip(Me.HEALTHLabel, "Your Health.")
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
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.XPLabel)
        Me.Panel2.Controls.Add(Me.LabelLevel)
        Me.Panel2.Controls.Add(Me.Level)
        Me.Panel2.Controls.Add(Me.CharName)
        Me.Panel2.Controls.Add(Me.XPBar)
        Me.Panel2.Location = New System.Drawing.Point(36, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 103)
        Me.Panel2.TabIndex = 6
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(141, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 15)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Saved!"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 81)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 15)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Upgrade Points"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HumanAdventure.My.Resources.Resources.yave_1
        Me.PictureBox1.Location = New System.Drawing.Point(4, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 66)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(255, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(452, 529)
        Me.Panel4.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 334)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Workspace"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.Tour)
        Me.TabControl2.Controls.Add(Me.Inventory)
        Me.TabControl2.Controls.Add(Me.Equipment)
        Me.TabControl2.Controls.Add(Me.Options)
        Me.TabControl2.Controls.Add(Me.Experimental)
        Me.TabControl2.Location = New System.Drawing.Point(6, 20)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(431, 308)
        Me.TabControl2.TabIndex = 1
        '
        'Tour
        '
        Me.Tour.Controls.Add(Me.CheckBox1)
        Me.Tour.Controls.Add(Me.Label24)
        Me.Tour.Controls.Add(Me.Panel9)
        Me.Tour.Controls.Add(Me.Button7)
        Me.Tour.Location = New System.Drawing.Point(4, 24)
        Me.Tour.Name = "Tour"
        Me.Tour.Size = New System.Drawing.Size(423, 280)
        Me.Tour.TabIndex = 3
        Me.Tour.Text = "Tour"
        Me.Tour.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(232, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 19)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Auto Battle"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 258)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 15)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Tour Distance: "
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Label25)
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(417, 249)
        Me.Panel9.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.CurEnemyData6)
        Me.Panel10.Controls.Add(Me.CurEnemyData5)
        Me.Panel10.Controls.Add(Me.GroupBox5)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label30)
        Me.Panel10.Controls.Add(Me.Label28)
        Me.Panel10.Controls.Add(Me.Label29)
        Me.Panel10.Controls.Add(Me.CurEnemyData4)
        Me.Panel10.Controls.Add(Me.Label27)
        Me.Panel10.Controls.Add(Me.CurEnemyData3)
        Me.Panel10.Controls.Add(Me.Label26)
        Me.Panel10.Controls.Add(Me.CurEnemyData2)
        Me.Panel10.Controls.Add(Me.CurEnemyData1)
        Me.Panel10.Location = New System.Drawing.Point(-1, -1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(417, 249)
        Me.Panel10.TabIndex = 1
        '
        'CurEnemyData6
        '
        Me.CurEnemyData6.AutoSize = True
        Me.CurEnemyData6.Location = New System.Drawing.Point(97, 114)
        Me.CurEnemyData6.Name = "CurEnemyData6"
        Me.CurEnemyData6.Size = New System.Drawing.Size(38, 15)
        Me.CurEnemyData6.TabIndex = 12
        Me.CurEnemyData6.Text = "cdmg"
        '
        'CurEnemyData5
        '
        Me.CurEnemyData5.AutoSize = True
        Me.CurEnemyData5.Location = New System.Drawing.Point(97, 94)
        Me.CurEnemyData5.Name = "CurEnemyData5"
        Me.CurEnemyData5.Size = New System.Drawing.Size(33, 15)
        Me.CurEnemyData5.TabIndex = 11
        Me.CurEnemyData5.Text = "crate"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(11, 132)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(191, 113)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Skills"
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Button11)
        Me.Panel11.Controls.Add(Me.Button10)
        Me.Panel11.Controls.Add(Me.Button9)
        Me.Panel11.Controls.Add(Me.Button8)
        Me.Panel11.Controls.Add(Me.BattleMessage)
        Me.Panel11.Location = New System.Drawing.Point(208, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(206, 241)
        Me.Panel11.TabIndex = 9
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(105, 214)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(98, 23)
        Me.Button11.TabIndex = 17
        Me.Button11.Text = "Run"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(3, 214)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 23)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "Block"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(105, 185)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 23)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Ele. Attack"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(3, 185)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Attack"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'BattleMessage
        '
        Me.BattleMessage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BattleMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BattleMessage.Location = New System.Drawing.Point(-1, -2)
        Me.BattleMessage.Multiline = True
        Me.BattleMessage.Name = "BattleMessage"
        Me.BattleMessage.ReadOnly = True
        Me.BattleMessage.Size = New System.Drawing.Size(206, 181)
        Me.BattleMessage.TabIndex = 14
        Me.BattleMessage.Text = "battlemessage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(9, 114)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 15)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Crit Damage"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 15)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Crit Rate"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 74)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 15)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Defense"
        '
        'CurEnemyData4
        '
        Me.CurEnemyData4.AutoSize = True
        Me.CurEnemyData4.Location = New System.Drawing.Point(97, 74)
        Me.CurEnemyData4.Name = "CurEnemyData4"
        Me.CurEnemyData4.Size = New System.Drawing.Size(48, 15)
        Me.CurEnemyData4.TabIndex = 5
        Me.CurEnemyData4.Text = "defense"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 15)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Attack"
        '
        'CurEnemyData3
        '
        Me.CurEnemyData3.AutoSize = True
        Me.CurEnemyData3.Location = New System.Drawing.Point(97, 54)
        Me.CurEnemyData3.Name = "CurEnemyData3"
        Me.CurEnemyData3.Size = New System.Drawing.Size(39, 15)
        Me.CurEnemyData3.TabIndex = 3
        Me.CurEnemyData3.Text = "attack"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 34)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 15)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Health"
        '
        'CurEnemyData2
        '
        Me.CurEnemyData2.AutoSize = True
        Me.CurEnemyData2.Location = New System.Drawing.Point(97, 34)
        Me.CurEnemyData2.Name = "CurEnemyData2"
        Me.CurEnemyData2.Size = New System.Drawing.Size(40, 15)
        Me.CurEnemyData2.TabIndex = 1
        Me.CurEnemyData2.Text = "health"
        '
        'CurEnemyData1
        '
        Me.CurEnemyData1.AutoSize = True
        Me.CurEnemyData1.Location = New System.Drawing.Point(8, 10)
        Me.CurEnemyData1.Name = "CurEnemyData1"
        Me.CurEnemyData1.Size = New System.Drawing.Size(73, 15)
        Me.CurEnemyData1.TabIndex = 0
        Me.CurEnemyData1.Text = "enemyname"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(173, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "No Mobs..."
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(323, 254)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 23)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Go Forward"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.Inventory.Location = New System.Drawing.Point(4, 24)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory.Size = New System.Drawing.Size(423, 280)
        Me.Inventory.TabIndex = 0
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'Equipment
        '
        Me.Equipment.Location = New System.Drawing.Point(4, 24)
        Me.Equipment.Name = "Equipment"
        Me.Equipment.Padding = New System.Windows.Forms.Padding(3)
        Me.Equipment.Size = New System.Drawing.Size(423, 280)
        Me.Equipment.TabIndex = 1
        Me.Equipment.Text = "Equipment"
        Me.Equipment.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Controls.Add(Me.Panel12)
        Me.Options.Location = New System.Drawing.Point(4, 24)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(423, 280)
        Me.Options.TabIndex = 4
        Me.Options.Text = "Options"
        Me.Options.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.Controls.Add(Me.TextBox3)
        Me.Panel12.Controls.Add(Me.ComboBox3)
        Me.Panel12.Controls.Add(Me.Label36)
        Me.Panel12.Controls.Add(Me.EasterEgg)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.Label35)
        Me.Panel12.Controls.Add(Me.CheckBox2)
        Me.Panel12.Controls.Add(Me.Label34)
        Me.Panel12.Controls.Add(Me.ComboBox2)
        Me.Panel12.Controls.Add(Me.Label33)
        Me.Panel12.Controls.Add(Me.ComboBox1)
        Me.Panel12.Controls.Add(Me.Label32)
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(417, 274)
        Me.Panel12.TabIndex = 0
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Use normal damage first", "Use elemental damage first"})
        Me.ComboBox3.Location = New System.Drawing.Point(7, 87)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox3.TabIndex = 10
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(4, 69)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(148, 15)
        Me.Label36.TabIndex = 9
        Me.Label36.Text = "Automatic combat priority"
        '
        'EasterEgg
        '
        Me.EasterEgg.Location = New System.Drawing.Point(7, 282)
        Me.EasterEgg.Name = "EasterEgg"
        Me.EasterEgg.Size = New System.Drawing.Size(75, 23)
        Me.EasterEgg.TabIndex = 8
        Me.EasterEgg.Text = "Easter Egg"
        Me.EasterEgg.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.RadioButton6)
        Me.Panel13.Controls.Add(Me.RadioButton5)
        Me.Panel13.Location = New System.Drawing.Point(7, 181)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(171, 54)
        Me.Panel13.TabIndex = 7
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(5, 28)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(156, 19)
        Me.RadioButton6.TabIndex = 1
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Chinese Simplified (PRC)"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(5, 3)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(88, 19)
        Me.RadioButton5.TabIndex = 0
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "English (US)"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label35.Location = New System.Drawing.Point(4, 158)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(74, 20)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "Language"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 136)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(117, 19)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Enable Auto Save"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label34.Location = New System.Drawing.Point(3, 113)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 20)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Auto Save"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Default", "item1", "item2", "item3", "item4", "item5", "item6"})
        Me.ComboBox2.Location = New System.Drawing.Point(134, 43)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox2.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(4, 27)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(169, 15)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Coins shop purchasing priority"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"No any", "Player prop.", "Equipment"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label32.Location = New System.Drawing.Point(3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(93, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Auto priority"
        '
        'Experimental
        '
        Me.Experimental.Controls.Add(Me.Panel8)
        Me.Experimental.Controls.Add(Me.Label22)
        Me.Experimental.Controls.Add(Me.GroupBox4)
        Me.Experimental.Controls.Add(Me.GroupBox3)
        Me.Experimental.Controls.Add(Me.Label11)
        Me.Experimental.Location = New System.Drawing.Point(4, 24)
        Me.Experimental.Name = "Experimental"
        Me.Experimental.Size = New System.Drawing.Size(423, 280)
        Me.Experimental.TabIndex = 2
        Me.Experimental.Text = "Experimental"
        Me.Experimental.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.Controls.Add(Me.DamageCountBox)
        Me.Panel8.Location = New System.Drawing.Point(3, 212)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(417, 72)
        Me.Panel8.TabIndex = 26
        '
        'DamageCountBox
        '
        Me.DamageCountBox.AutoSize = True
        Me.DamageCountBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DamageCountBox.Location = New System.Drawing.Point(3, 0)
        Me.DamageCountBox.Name = "DamageCountBox"
        Me.DamageCountBox.Size = New System.Drawing.Size(49, 15)
        Me.DamageCountBox.TabIndex = 25
        Me.DamageCountBox.Text = "Defense"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label22.Location = New System.Drawing.Point(3, 191)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 20)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Damage Count"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(211, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 160)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enemy Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 15)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Start Simulaton"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 122)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Damage Once"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(65, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "defense"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(7, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Defense"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(65, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 15)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "attack"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(7, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 15)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Health"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(65, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 15)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "health / maxhealth"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(7, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Attack"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EnemyXPBox)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.EnemyHealthBox)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.EnemyDefenseBox)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.EnemyAttackBox)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 160)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enemy Propetries"
        '
        'EnemyXPBox
        '
        Me.EnemyXPBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EnemyXPBox.Location = New System.Drawing.Point(96, 101)
        Me.EnemyXPBox.MaxLength = 5
        Me.EnemyXPBox.Name = "EnemyXPBox"
        Me.EnemyXPBox.Size = New System.Drawing.Size(100, 23)
        Me.EnemyXPBox.TabIndex = 8
        Me.EnemyXPBox.Tag = "EnemyData4"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 15)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Give XPs:"
        '
        'EnemyHealthBox
        '
        Me.EnemyHealthBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EnemyHealthBox.Location = New System.Drawing.Point(96, 17)
        Me.EnemyHealthBox.MaxLength = 9
        Me.EnemyHealthBox.Name = "EnemyHealthBox"
        Me.EnemyHealthBox.Size = New System.Drawing.Size(100, 23)
        Me.EnemyHealthBox.TabIndex = 2
        Me.EnemyHealthBox.Tag = "EnemyData1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(121, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Set"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Health:"
        '
        'EnemyDefenseBox
        '
        Me.EnemyDefenseBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EnemyDefenseBox.Location = New System.Drawing.Point(96, 73)
        Me.EnemyDefenseBox.MaxLength = 5
        Me.EnemyDefenseBox.Name = "EnemyDefenseBox"
        Me.EnemyDefenseBox.Size = New System.Drawing.Size(100, 23)
        Me.EnemyDefenseBox.TabIndex = 7
        Me.EnemyDefenseBox.Tag = "EnemyData3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Attack:"
        '
        'EnemyAttackBox
        '
        Me.EnemyAttackBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EnemyAttackBox.Location = New System.Drawing.Point(96, 44)
        Me.EnemyAttackBox.MaxLength = 5
        Me.EnemyAttackBox.Name = "EnemyAttackBox"
        Me.EnemyAttackBox.Size = New System.Drawing.Size(100, 23)
        Me.EnemyAttackBox.TabIndex = 6
        Me.EnemyAttackBox.Tag = "EnemyData2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Defense:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Damage Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.RegionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 180)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Region"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Introduction"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.RadioButton1)
        Me.Panel7.Controls.Add(Me.RadioButton4)
        Me.Panel7.Controls.Add(Me.RadioButton2)
        Me.Panel7.Controls.Add(Me.RadioButton3)
        Me.Panel7.Location = New System.Drawing.Point(9, 37)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(428, 131)
        Me.Panel7.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "More Region Coming soon..."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "regionname1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(3, 83)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(95, 19)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "regionname4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(3, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "regionname2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(3, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(95, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "regionname3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Location = New System.Drawing.Point(9, 37)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(428, 131)
        Me.Panel6.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(158, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Level 15 to Unlock"
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.Location = New System.Drawing.Point(6, 19)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(90, 15)
        Me.RegionLabel.TabIndex = 0
        Me.RegionLabel.Text = "Current Region:"
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
        'AttributeToolTip
        '
        Me.AttributeToolTip.IsBalloon = True
        Me.AttributeToolTip.ToolTipTitle = "Properties"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'AutoBattleTimer
        '
        Me.AutoBattleTimer.Interval = 1500
        '
        'BattleTime
        '
        Me.BattleTime.Interval = 1500
        '
        'BattleCooldown
        '
        Me.BattleCooldown.Interval = 1000
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.CausesValidation = False
        Me.TextBox3.Location = New System.Drawing.Point(7, 241)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ShortcutsEnabled = False
        Me.TextBox3.Size = New System.Drawing.Size(387, 35)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = "qwq"
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CharNameStrip.ResumeLayout(False)
        Me.XPMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.Tour.ResumeLayout(False)
        Me.Tour.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Options.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Experimental.ResumeLayout(False)
        Me.Experimental.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HealHPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CPPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoinsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradeShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents RegionLabel As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Inventory As TabPage
    Friend WithEvents Equipment As TabPage
    Friend WithEvents AttributeToolTip As ToolTip
    Friend WithEvents Tour As TabPage
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label25 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AutoBattleTimer As Timer
    Friend WithEvents BattleTime As Timer
    Friend WithEvents Panel10 As Panel
    Friend WithEvents CurEnemyData1 As Label
    Friend WithEvents CurEnemyData2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CurEnemyData3 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents CurEnemyData4 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CurEnemyData6 As Label
    Friend WithEvents CurEnemyData5 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BattleCooldown As Timer
    Friend WithEvents BattleMessage As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Experimental As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DamageCountBox As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EnemyXPBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents EnemyHealthBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents EnemyDefenseBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents EnemyAttackBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Options As TabPage
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Label35 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents UpgradeBut6 As Button
    Friend WithEvents UpgradeBut5 As Button
    Friend WithEvents UpgradeBut4 As Button
    Friend WithEvents UpgradeBut3 As Button
    Friend WithEvents UpgradeBut2 As Button
    Friend WithEvents UpgradeBut1 As Button
    Friend WithEvents EasterEgg As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
