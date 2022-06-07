
Imports System.IO
Public Class MainWindow

    Public Shared progress As Boolean               'Make public share
    Dim a As Integer
    Dim amax As Integer = 60                        'Max Auto values
    Public Language As Byte = 0                     '0 = English (US), 1 = Chinese Simplified (PRC)
    Public NewSaveWindowProgress As Boolean
    'Place ID.
    Dim RegionID As Integer
    'Beta Test
    Const Cooldown As Integer = 1500
    Const SaveVersion As Integer = 1
    Public Shared ReadOnly WorkDefaultPath As String = Environment.CurrentDirectory & "\Save"
    Public Shared WorkUserPath As String
    Dim TourDistance_1 As UInt64           '100 = 1 Meters
    Dim TourDistance_2 As UInt64            '100 = 1 Meters
    Dim TourDistanceCache As UInt64         'Display()
    Dim Touring As Boolean                  'Detect is in Tour mode.
    Dim isCooldown As Boolean               'Action Cooldown
    Dim AutoBattle As Boolean               'Detect Auto battle is enabled.
    Dim isBattle As Boolean                 'Detect is in Battle mode.
    Dim isBattleDisplay As Boolean
    Dim BattleComplete As Boolean
    Dim DAB As Boolean                      'Disable Action Buttons
    Dim ase As Integer
    Dim DES As Integer                      'Disable Enemy Spawn
    Dim DeathCount As Integer

    Public Shared r1 As New Random
    Public Shared r1r As Double
    'Init PlayerData Class
    Public ReadOnly DefaultFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame\Yave's Tours"
    Public ReadOnly DefaultINIPath As String = DefaultFolderPath & "\Config.ini"
    Public PlayerData As InitPlayer
    Public ItemData As InitItem
    Public EnemyData As InitEnemy
    Public CurrentEnemy As InitEnemy
    Public Skill As InitSkill
    Public Basic As InitBasic
    '726, 601
    Private Sub ErrorOccurred()
        MsgBox("An unknown error occurred while attempting to perform this function.", vbYes, Me.Text)
        Application.Exit()
    End Sub
    Private Sub SelectEnemy()
        Dim a As Integer
        Select Case RegionID
            Case 0
                Select Case PlayerData.Level1
                    Case 1 To 5
                        a = r1.Next(0, 2)
                        CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1,
                                                     Enemies.Enemy(a).Name1,
                                                     Enemies.Enemy(a).HP1,
                                                     Enemies.Enemy(a).HPM1,
                                                     Enemies.Enemy(a).ATK1,
                                                     Enemies.Enemy(a).DEF1,
                                                     Enemies.Enemy(a).CRate1,
                                                     Enemies.Enemy(a).CDMG1,
                                                     Enemies.Enemy(a).EXP1,
                                                     Enemies.Enemy(a).Coins1
                                                     )
                End Select
        End Select
    End Sub
    Private Function VB6String(count As Integer)
        Dim a As String = " "
        Dim b As Integer
        For b = 1 To count Step 1
            a = a & " "
        Next
        Return a
    End Function
    Private Sub RefreshData()
        With PlayerData
            PictureBox1.Image = InitData.SkinGallery(.Sk)
            CharName.ForeColor = Color.FromArgb(InitData.ECR(.element1), InitData.ECG(.element1), InitData.ECB(.element1))
            CharName.Text = "[" & InitData.Elementname(.element1) & "] " & .CName1
            HEALTHLabel.Text = .HP1 & "/" & .HPM1
            Level.Text = .Level1
            ATKLabel.Text = .ATK1
            DEFLabel.Text = .DEF1
            SELabel.Text = .SE1
            CRLabel.Text = .CRate1 * 100 & "%"
            CDLabel.Text = .CDMG1 * 100 & "%"
            XPLabel.Text = .XP1 & "/" & .XPNeed1
            XPMenuStrip1.Text = .XP1 & "/" & .XPNeed1
            RegionLabel.Text = Strings.s_string(42, Language) & ":" & " " & Strings.s_string(48 + RegionID, Language)
            If TourDistanceCache >= 100000 Then
                TourDistanceLabel.Text = Math.Round(TourDistanceCache / 10 ^ 5, 2) & "km"
            Else
                TourDistanceLabel.Text = Math.Round(TourDistanceCache / 10 ^ 2, 2) & "m"
            End If
            CheckXP()
            XPBar.Maximum = .XPNeed1
            XPBar.Value = .XP1
            CoinsToolStripMenuItem.Text = .Coins1
            If isBattleDisplay Then
                With CurrentEnemy
                    CurEnemyData1.Text = "[" & InitData.Elementname(.ID1) & "] " & .Name1
                    CurEnemyData1.ForeColor = Color.FromArgb(InitData.ECR(.ID1), InitData.ECG(.ID1), InitData.ECB(.ID1))
                    CurEnemyData2.Text = .HP1 & "/" & .HPM1
                    CurEnemyData3.Text = .ATK1
                    CurEnemyData4.Text = .DEF1
                    CurEnemyData5.Text = .CRate1 * 100 & "%"
                    CurEnemyData6.Text = .CDMG1 * 100 & "%"
                End With
            Else
                CurEnemyData1.Text = "enemyname"
                CurEnemyData1.ForeColor = Color.FromArgb(0, 0, 0)
                CurEnemyData2.Text = "health"
                CurEnemyData3.Text = "attack"
                CurEnemyData4.Text = "defense"
                CurEnemyData5.Text = "crate"
                CurEnemyData6.Text = "cdmg"
                BattleMessage.Text = "battlemessage"
            End If
            Label20.Text = EnemyData.HP1 & "/" & EnemyData.HPM1
            Label19.Text = EnemyData.ATK1
            Label18.Text = EnemyData.DEF1
        End With
    End Sub
    Private Sub CheckXP()
        If PlayerData.XP1 >= PlayerData.XPNeed1 Then
            UpgradeLabel.Visible = True
            PlayerData.XP1 = PlayerData.XPNeed1
        Else
            UpgradeLabel.Visible = False
        End If
    End Sub

    Public Function DebugShow(pstring As String)
        MsgBox(pstring, vbYes, Me.Text)
        Return Nothing
    End Function
    Private Sub Simulate_Damage()
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = EnemyData.HP1
        PlayerData.HP1 = Calculate.ADCount(PlayerData.HP1, EnemyData.ATK1, PlayerData.DEF1, EnemyData.CRate1, EnemyData.CDMG1, EnemyData.ID1, PlayerData.element1)
        EnemyData.HP1 = Calculate.ADCount(EnemyData.HP1, PlayerData.ATK1, EnemyData.DEF1, PlayerData.CRate1, PlayerData.CDMG1, PlayerData.element1, EnemyData.ID1)
        DamageCountBox.Text = "Player Taked " & (health(0) - PlayerData.HP1) & " Damages" & Chr(13) & "Enemy Taked " & (health(1) - EnemyData.HP1) & " Damages"
        If PlayerData.HP1 <= 0 Then
            PlayerData.HP1 = PlayerData.HPM1
            DamageCountBox.Text = DamageCountBox.Text & Chr(13) & "You fall down. The system heals for you."
        End If
        If EnemyData.HP1 <= 0 Then
            PlayerData.XP1 += EnemyData.EXP1
            DamageCountBox.Text = DamageCountBox.Text & Chr(13) & "You win! You Earned " & EnemyData.Coins1 & " Coins, " & EnemyData.EXP1 & " XPs."
            EnemyData = New InitEnemy()
        End If
    End Sub

    Private Sub Battle_Damage()
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = CurrentEnemy.HP1
        CurrentEnemy.HP1 = Calculate.ADCount(CurrentEnemy.HP1, PlayerData.ATK1, CurrentEnemy.DEF1, PlayerData.CRate1, PlayerData.CDMG1, PlayerData.element1, CurrentEnemy.ID1)
        BattleMessage.Text = "Enemy Taked " & (health(1) - CurrentEnemy.HP1) & " Damages"
        If CurrentEnemy.HP1 > 0 Then
            PlayerData.HP1 = Calculate.ADCount(PlayerData.HP1, CurrentEnemy.ATK1, PlayerData.DEF1, CurrentEnemy.CRate1, CurrentEnemy.CDMG1, CurrentEnemy.ID1, PlayerData.element1)
            BattleMessage.Text = BattleMessage.Text & vbCrLf & "Player Taked " & (health(0) - PlayerData.HP1) & " Damages"
        End If
        If PlayerData.HP1 <= 0 Then
            PlayerData.HP1 = PlayerData.HPM1
            Dim b As Integer
            BattleMessage.Text = BattleMessage.Text & vbCrLf & "You fall down. The system heals for you."
        End If
        If CurrentEnemy.HP1 <= 0 Then
            DES = 5000 + r1.Next(50, 2501)
            PlayerData.XP1 += CurrentEnemy.EXP1
            PlayerData.Coins1 += CurrentEnemy.Coins1
            BattleMessage.Text = BattleMessage.Text & vbCrLf & "You win! You Earned " & CurrentEnemy.Coins1 & " Coins, " & CurrentEnemy.EXP1 & " XPs."
            BattleComplete = True
            CurrentEnemy = New InitEnemy()
        End If
    End Sub
    Private Sub CheckDirectory()
        Dim a As String
        If WorkUserPath = "" Then
            a = WorkDefaultPath
        Else
            a = WorkUserPath
        End If
        If Directory.Exists(a) Then
            Directory.CreateDirectory(a)
        End If
    End Sub
    Private Sub SaveData(SaveFileName As String)
        Dim fs As New FileStream(SaveFileName, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        Dim a As Integer
        bw.Write(PlayerData.Sk)
        bw.Write(PlayerData.element1)
        bw.Write(PlayerData.Level1)
        bw.Write(PlayerData.CName1)
        bw.Write(PlayerData.XP1)
        bw.Write(PlayerData.XPNeed1)
        bw.Write(PlayerData.HP1)
        bw.Write(PlayerData.HPM1)
        bw.Write(PlayerData.ATK1)
        bw.Write(PlayerData.DEF1)
        bw.Write(PlayerData.SE1)
        bw.Write(PlayerData.CRate1)
        bw.Write(PlayerData.CDMG1)
        bw.Write(PlayerData.Coins1)
        bw.Write(RegionID)
        bw.Write(TourDistance_1)
        bw.Write(TourDistance_2)
        bw.Close()
        fs.Close()
        MsgBox("Saved!", vbYes, Me.Text)
    End Sub
    Private Sub OpenFileDialog()
        Dim a As New OpenFileDialog
        CheckDirectory()
        If WorkUserPath <> "" Then
            a.InitialDirectory = WorkDefaultPath
        Else
            a.InitialDirectory = WorkUserPath
        End If
        a.Filter = "Yave's Tours Save File|*.yts" '|Yave's Tours Text File|*.txt|Yave's Tours Json File|*.json
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadData(a.FileName)
        End If
    End Sub
    Private Sub LoadData(LoadFileName)
        PlayerData = New InitPlayer
        'MsgBox(LoadFileName, vbYes, Me.Text)
        Dim fs As New FileStream(LoadFileName, FileMode.Open)
        Dim br As New BinaryReader(fs)
        PlayerData.Sk = br.ReadInt32
        PlayerData.element1 = br.ReadInt32
        PlayerData.Level1 = br.ReadInt32
        PlayerData.CName1 = br.ReadString
        PlayerData.XP1 = br.ReadUInt64
        PlayerData.XPNeed1 = br.ReadUInt64
        PlayerData.HP1 = br.ReadInt32
        PlayerData.HPM1 = br.ReadInt32
        PlayerData.ATK1 = br.ReadInt32
        PlayerData.DEF1 = br.ReadInt32
        PlayerData.SE1 = br.ReadUInt32
        PlayerData.CRate1 = br.ReadDouble
        PlayerData.CDMG1 = br.ReadDouble
        PlayerData.Coins1 = br.ReadInt32
        RegionID = br.ReadInt32
        TourDistance_1 = br.ReadUInt64
        TourDistance_2 = br.ReadUInt64
        br.Close()
        fs.Close()
        'CalibrationData(PlayerData.Sk)
        ' CalibrationData(PlayerData.element1)
        ' CalibrationData(PlayerData.Level1)
        'CalibrationData(PlayerData.CName1)
        ' CalibrationData(PlayerData.XP1)
        ' CalibrationData(PlayerData.XPNeed1)
        ' CalibrationData(PlayerData.HP1)
        'CalibrationData(PlayerData.HPM1)
        'CalibrationData(PlayerData.ATK1)
        ' CalibrationData(PlayerData.DEF1)
        'CalibrationData(PlayerData.SE1)
        'CalibrationData(PlayerData.CRate1)
        'CalibrationData(PlayerData.CDMG1)
        'CalibrationData(PlayerData.Coins1)
        ' CalibrationData(TourDistance(RegionID))
        'CalibrationData(RegionID)
        'If PlayerData.Sk = Nothing Or PlayerData.element1 = Nothing Or PlayerData.Level1 = Nothing Or PlayerData.CName1 = Nothing Or PlayerData.XP1 = Nothing Or PlayerData.XPNeed1 = Nothing Or PlayerData.HP1 = Nothing Or PlayerData.HPM1 = Nothing Or PlayerData.ATK1 = Nothing Or PlayerData.DEF1 = Nothing Or PlayerData.SE1 = Nothing Or PlayerData.CRate1 = Nothing Or PlayerData.CDMG1 = Nothing Or PlayerData.Coins1 = Nothing Or RegionID = Nothing Or TourDistance(RegionID) = Nothing Then
        'PlayerData = New InitPlayer
        'TourDistance(RegionID) = 0
        'RegionID = 0
        'MsgBox("This save data is corrupted.", vbYes, Me.Text)
        'Else
        progress = True
        'End If
    End Sub
    Private Function CalibrationData(a As Object)
        If a = Nothing Then
            Return Nothing
        Else
            Return a
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(DefaultFolderPath) Then
            Directory.CreateDirectory(DefaultFolderPath)
        End If
        If Not File.Exists(DefaultINIPath) Then
            Dim a As Stream
            a = File.Create(DefaultINIPath)
            a.Close()
            writeINI(DefaultINIPath, "Options", "Language", "en_us")
        Else
            Dim a As String
            a = sGetINI(DefaultINIPath, "Options", "Language", "en_us")
            Select Case a
                Case "en_us"
                    Language = 0
                Case "zh_cn"
                    Language = 1
            End Select
        End If
        Lang.setstr(Language)
        Panel10.Visible = False
        DES = Cooldown
        NewSaveWindowProgress = False

        Dim InitDatas As New InitData

        PlayerData = New InitPlayer()
        EnemyData = New InitEnemy()
        CurrentEnemy = New InitEnemy()

        CheckDirectory()
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim a As Integer
        If progress <> True Then
            a = MsgBox(Strings.s_string(38, Language), vbYesNo, Me.Text)
            If a = vbYes Then
                OpenFileDialog()
            End If
        Else
            Dim b As New SaveFileDialog
            CheckDirectory()
            If WorkUserPath <> "" Then
                b.InitialDirectory = WorkDefaultPath
            Else
                b.InitialDirectory = WorkUserPath
            End If
            b.Filter = "Yave's Tours Save File|*.yts"
            If b.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveData(b.FileName)
            End If
        End If
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        NewSave.ShowDialog()
    End Sub
    Public Sub LanguageChange(a As Byte)
        Language = a
        Select Case a
            Case 0

            Case 1

        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1r = r1.NextDouble
        If NewSaveWindowProgress = True Then
            NewSaveWindowProgress = False
            With NewSave
                PlayerData = New InitPlayer(.Skin, .Element, .CName, .Level, .XP, .XPNeed, .HPM, .HP, .ATK, .DEF, .SE, .CRate, .CDMG, .Coins)
            End With
            RegionID = NewSave.PlaceID
            TourDistance_1 = 0
            TourDistance_2 = 0
            progress = True
        End If
        If progress = True Then
            Select Case RegionID
                Case 0
                    TourDistanceCache = TourDistance_1
                Case 1
                    TourDistanceCache = TourDistance_2
            End Select
            If Touring Then
                Button7.Text = "Stop"
                Timer2.Enabled = True
            Else
                Button7.Text = "Go Forward"
                Timer2.Enabled = False
            End If
            If PlayerData.Level1 >= 15 Then
                Panel7.Visible = True
            Else
                Panel7.Visible = False
            End If
            If isBattle Then
                Button7.Enabled = False
            Else
                Button7.Enabled = True
            End If
            If AutoBattle Then
                DAB = True
                BattleTime.Enabled = True
            Else
                DAB = False
                BattleTime.Enabled = False
            End If
            If DAB Then
                Button8.Enabled = False
                Button9.Enabled = False
                Button10.Enabled = False
                Button11.Enabled = False
            Else
                Button8.Enabled = True
                Button9.Enabled = True
                Button10.Enabled = True
                Button11.Enabled = True
            End If
            If BattleComplete Then
                DAB = True
                isBattle = False
                Button7.Enabled = True
            End If
            RefreshData()
            Panel5.Visible = False
        Else
            Panel5.Visible = True
            Panel5.Location = New Point(0, 23)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case RegionID
            Case 0
                TourDistance_1 += 1 + r1.Next(0, 4)
            Case 1
                TourDistance_2 += 1 + r1.Next(0, 4)
        End Select
        DES -= (1 + r1.Next(0, 4))
        Dim b As Double
        b = r1.NextDouble()
        Select Case b
            Case 0 To 0.008
                PlayerData.XP1 += 1
        End Select
        If DES <= 0 Then
            Select Case b
                Case 0 To 0.005
                    SelectEnemy()
                    isBattleDisplay = True
                    Panel10.Visible = True
                    Touring = False
                    isBattle = True
                    BattleMessage.Text = "Oh no! A wild " & CurrentEnemy.Name1 & " appear out on the road!"
            End Select
        End If
    End Sub
    Private Sub AboutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutsToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub UpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeToolStripMenuItem.Click
        Upgrade.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewSave.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog()
    End Sub
    Private Sub UpgradeLabel_Click(sender As Object, e As EventArgs) Handles UpgradeLabel.Click
        Upgrade.Show()
    End Sub


    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Rosalina129/abattlegame/issues")
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RegionID = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RegionID = 1
    End Sub

    Private Sub EnemyHealthBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnemyHealthBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub EnemyAttackBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnemyAttackBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub EnemydefenseBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnemyDefenseBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub EnemyXPBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnemyXPBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If EnemyHealthBox.Text <> "" And EnemyAttackBox.Text <> "" And EnemyDefenseBox.Text <> "" And EnemyXPBox.Text <> "" Then
            With EnemyData
                .HPM1 = EnemyHealthBox.Text
                .HP1 = .HPM1
                .ATK1 = EnemyAttackBox.Text
                .DEF1 = EnemyDefenseBox.Text
                .EXP1 = EnemyXPBox.Text
                .CRate1 = 0.05
                .CDMG1 = 0.5
                .Coins1 = .EXP1 \ 10 + r1.Next(0, 10)
            End With
        Else
            ' DebugShow()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Simulate_Damage()
    End Sub

    Private Sub HealHPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HealHPToolStripMenuItem.Click
        PlayerData.HP1 = PlayerData.HPM1
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Touring Then
            Touring = False
        Else
            Touring = True
        End If
        If BattleComplete Then
            Panel10.Visible = False
            isBattleDisplay = False
            Touring = True
            BattleComplete = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AutoBattle = True
        Else
            AutoBattle = False
        End If
    End Sub

    Private Sub BattleTime_Tick(sender As Object, e As EventArgs) Handles BattleTime.Tick
        If BattleComplete Then
            Panel10.Visible = False
            isBattleDisplay = False
            Touring = True
            BattleComplete = False
        End If
        If isBattle Then
            Battle_Damage()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Battle_Damage()
    End Sub

    Private Sub BattleCooldown_Tick(sender As Object, e As EventArgs) Handles BattleCooldown.Tick
        isCooldown = False
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        OpenFileDialog()
    End Sub

End Class
