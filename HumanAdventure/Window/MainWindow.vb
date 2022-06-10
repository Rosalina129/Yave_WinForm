
Imports System.IO
Imports System.Threading
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
    'IMPORTANT!!! This save version determines which version you play the save on,
    'and whether it is compatible with the current version!
    Const SaveVersion As Integer = 1
    Const CompatibleVersion As Integer = 1

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
    Dim DES As Integer                      'Disable Enemy Spawn
    Dim DeathCount As Integer
    Dim ABP As Byte
    Dim CacheSaveFileName As String
    Dim AutoSaving As Boolean
    Dim AutoSavingCooldown As Integer
    Dim SavedLabelShowTime As Integer

    Public Shared UpgradePoint As Integer

    Public Shared r1 As New Random
    Public Shared r1r As Double
    'Init PlayerData Class
    'Public ReadOnly OldPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame"
    '这就是来自傻逼开发者的自信 :) That's confidence from a stupid developer :)
    Public ReadOnly DefaultFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\WinFormGame\Yave's Tours"
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
                    Case 0 To 5
                        a = r1.Next(0, 5)
                        CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                    Case 6 To 19
                        a = r1.Next(5, 11)
                        CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                    Case 20 To 35
                        a = r1.Next(11, 13)
                        CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
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
            CharName.Text = "[" & Strings.s_string(80 + .element1, Language) & "] " & .CName1
            HEALTHLabel.Text = .HP1 & "/" & .HPM1
            Level.Text = .Level1
            ATKLabel.Text = .ATK1
            DEFLabel.Text = .DEF1
            SELabel.Text = .SE1
            CRLabel.Text = Math.Round(.CRate1 * 100, 1) & "%"
            CDLabel.Text = Math.Round(.CDMG1 * 100, 1) & "%"
            XPLabel.Text = .XP1 & "/" & .XPNeed1
            XPMenuStrip1.Text = .XP1 & "/" & .XPNeed1
            RegionLabel.Text = Strings.s_string(42, Language) & " " & Strings.s_string(48 + RegionID, Language)
            If TourDistanceCache >= 100000 Then
                Label24.Text = Strings.s_string(63, Language) & " " & Math.Round(TourDistanceCache / 10 ^ 5, 2) & "km"
            Else
                Label24.Text = Strings.s_string(63, Language) & " " & Math.Round(TourDistanceCache / 10 ^ 2, 2) & "m"
            End If
            CheckXP()
            XPBar.Maximum = .XPNeed1
            XPBar.Value = .XP1
            Label31.Text = Strings.s_string(37, Language) & " " & UpgradePoint
            CoinsToolStripMenuItem.Text = .Coins1
            If isBattleDisplay Then
                With CurrentEnemy
                    CurEnemyData1.Text = "[" & Strings.s_string(80 + .ID1, Language) & "] " & .Name1
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
            If UpgradePoint >= 1 Then
                UpgradeBut1.Visible = True
                UpgradeBut2.Visible = True
                UpgradeBut3.Visible = True
                UpgradeBut6.Visible = True
            Else
                UpgradeBut1.Visible = False
                UpgradeBut2.Visible = False
                UpgradeBut3.Visible = False
                UpgradeBut6.Visible = False
            End If
            If UpgradePoint >= 2 Then
                UpgradeBut4.Visible = True
                UpgradeBut5.Visible = True
            Else
                UpgradeBut4.Visible = False
                UpgradeBut5.Visible = False
            End If
        End With
    End Sub
    Private Sub CheckXP()
        If PlayerData.XP1 >= PlayerData.XPNeed1 Then
            UpgradeProp()
            PlayerData.XP1 = 0
        End If
    End Sub
    Private Sub UpgradeProp()
        With PlayerData
            .Level1 += 1
            UpgradePoint += 1 + r1.Next(0, 3)
            Select Case .Level1
                Case 0 To 20
                    .HPM1 += 30 + MainWindow.r1.Next(0, 10)
                    Thread.Sleep(1)
                    .ATK1 += 2 + MainWindow.r1.Next(0, 4)
                    Thread.Sleep(1)
                    .DEF1 += 1 + MainWindow.r1.Next(0, 3)
                Case 21 To 40
                    .HPM1 += 45 + MainWindow.r1.Next(0, 29)
                    Thread.Sleep(1)
                    .ATK1 += 4 + MainWindow.r1.Next(0, 8)
                    Thread.Sleep(1)
                    .DEF1 += 4 + MainWindow.r1.Next(0, 7)
                Case 41 To 50
                    .HPM1 += 50 + MainWindow.r1.Next(0, 48)
                    Thread.Sleep(1)
                    .ATK1 += 3 + MainWindow.r1.Next(0, 16)
                    Thread.Sleep(1)
                    .DEF1 += 3 + MainWindow.r1.Next(0, 9)
                Case 51 To 60
                    .HPM1 += 42 + MainWindow.r1.Next(0, 36)
                    Thread.Sleep(1)
                    .ATK1 += 3 + MainWindow.r1.Next(0, 12)
                    Thread.Sleep(1)
                    .DEF1 += 3 + MainWindow.r1.Next(0, 7)
                Case 61 To 70
                    .HPM1 += 30 + MainWindow.r1.Next(0, 29)
                    Thread.Sleep(1)
                    .ATK1 += 2 + MainWindow.r1.Next(0, 7)
                    Thread.Sleep(1)
                    .DEF1 += 2 + MainWindow.r1.Next(0, 6)
                Case 71 To 80
                    .HPM1 += 24 + MainWindow.r1.Next(0, 16)
                    Thread.Sleep(1)
                    .ATK1 += 1 + MainWindow.r1.Next(0, 9)
                    Thread.Sleep(1)
                    .DEF1 += 1 + MainWindow.r1.Next(0, 8)
                Case 81 To 99
                    .HPM1 += 18 + MainWindow.r1.Next(0, 10)
                    Thread.Sleep(1)
                    .ATK1 += 0 + MainWindow.r1.Next(0, 6)
                    Thread.Sleep(1)
                    .DEF1 += 0 + MainWindow.r1.Next(0, 4)
            End Select
            .XPNeed1 += 65 + MainWindow.r1.Next(20, 100)
            .XP1 = 0
            .HP1 = .HPM1
        End With
    End Sub

    Public Function DebugShow(pstring As String)
        MsgBox(pstring, vbYes, Me.Text)
        Return Nothing
    End Function
    Private Sub Simulate_Damage()
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = EnemyData.HP1
        EnemyData.HP1 = Calculate.ADCount(EnemyData.HP1, PlayerData.ATK1, EnemyData.DEF1, PlayerData.CRate1, PlayerData.CDMG1)
        DamageCountBox.Text = Strings.s_string(96, Language) & (health(0) - PlayerData.HP1) & " Damages" & Chr(13) & "Enemy Taked " & (health(1) - EnemyData.HP1) & " Damages"
        Thread.Sleep(1)
        If EnemyData.HP1 > 0 Then
            PlayerData.HP1 = Calculate.ADCount(PlayerData.HP1, EnemyData.ATK1, PlayerData.DEF1, EnemyData.CRate1, EnemyData.CDMG1)
            DamageCountBox.Text = DamageCountBox.Text & vbCrLf & Strings.s_string(96, Language) & (health(0) - PlayerData.HP1) & Strings.s_string(98, Language)
        End If
        Thread.Sleep(1)
        If PlayerData.HP1 <= 0 Then
            PlayerData.HP1 = PlayerData.HPM1
            DamageCountBox.Text = DamageCountBox.Text & vbCrLf & Strings.s_string(102, Language)
        End If
        If EnemyData.HP1 <= 0 Then
            PlayerData.XP1 += EnemyData.EXP1
            DamageCountBox.Text = DamageCountBox.Text & vbCrLf & Strings.s_string(103, Language) & " " & CurrentEnemy.Coins1 & Strings.s_string(104, Language) & CurrentEnemy.EXP1 & " " & Strings.s_string(105, Language)
            EnemyData = New InitEnemy()
        End If
    End Sub

    Private Sub Battle_Damage()
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = CurrentEnemy.HP1
        CurrentEnemy.HP1 = Calculate.ADCount(CurrentEnemy.HP1, PlayerData.ATK1, CurrentEnemy.DEF1, PlayerData.CRate1, PlayerData.CDMG1)
        BattleMessage.Text = Strings.s_string(97, Language) & (health(1) - CurrentEnemy.HP1) & Strings.s_string(98, Language)
        Thread.Sleep(1)
        If (health(1) - CurrentEnemy.HP1) = 1 Then
            If Language = 0 Then
                BattleMessage.Text = BattleMessage.Text & "s"
            End If
        End If
        Thread.Sleep(1)
        If CurrentEnemy.HP1 > 0 Then
            PlayerData.HP1 = Calculate.ADCount(PlayerData.HP1, CurrentEnemy.ATK1, PlayerData.DEF1, CurrentEnemy.CRate1, CurrentEnemy.CDMG1)
            BattleMessage.Text = BattleMessage.Text & vbCrLf & Strings.s_string(96, Language) & (health(0) - PlayerData.HP1) & Strings.s_string(98, Language)
            If (health(0) - PlayerData.HP1) = 1 Then
                If Language = 0 Then
                    BattleMessage.Text = BattleMessage.Text & "s"
                End If
            End If
        End If
        If PlayerData.HP1 <= 0 Then
            PlayerData.HP1 = PlayerData.HPM1
            BattleMessage.Text = BattleMessage.Text & vbCrLf & Strings.s_string(102, Language)
        End If
        If CurrentEnemy.HP1 <= 0 Then
            DES = 5000 + r1.Next(50, 2501)
            PlayerData.XP1 += CurrentEnemy.EXP1
            PlayerData.Coins1 += CurrentEnemy.Coins1
            BattleMessage.Text = BattleMessage.Text & vbCrLf & Strings.s_string(103, Language) & " " & CurrentEnemy.Coins1 & " " & Strings.s_string(104, Language) & ", " & CurrentEnemy.EXP1 & " " & Strings.s_string(105, Language)
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
        CacheSaveFileName = SaveFileName
        Dim fs As New FileStream(SaveFileName, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        bw.Write(SaveVersion)
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
        bw.Write(UpgradePoint)
        bw.Write(RegionID)
        bw.Write(TourDistance_1)
        bw.Write(TourDistance_2)
        bw.Close()
        fs.Close()
        SavedLabelShowTime = 180
    End Sub
    Private Sub OpenFileDialog()
        Dim a As New OpenFileDialog
        CheckDirectory()
        If WorkUserPath <> "" Then
            a.InitialDirectory = WorkDefaultPath
        Else
            a.InitialDirectory = WorkUserPath
        End If
        a.Filter = Strings.s_string(106, Language) & "|*.yts" '|Yave's Tours Text File|*.txt|Yave's Tours Json File|*.json
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadData(a.FileName)
        End If
    End Sub
    Private Sub LoadData(LoadFileName)
        CacheSaveFileName = LoadFileName
        PlayerData = New InitPlayer
        Dim SaveVer As Integer
        'MsgBox(LoadFileName, vbYes, Me.Text)
        Dim fs As New FileStream(LoadFileName, FileMode.Open)
        Dim br As New BinaryReader(fs)
        SaveVer = br.ReadInt32
        If SaveVer = 1 Then
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
            UpgradePoint = br.ReadInt32
            RegionID = br.ReadInt32
            TourDistance_1 = br.ReadUInt64
            TourDistance_2 = br.ReadUInt64
            progress = True
        Else
            DebugShow(Strings.s_string(73, Language) & vbCrLf &
                      Strings.s_string(56, Language) & ":" & SaveVersion & vbCrLf &
                      Strings.s_string(57, Language) & ":" & SaveVer & vbCrLf &
                      Strings.s_string(58, Language) & ":" & CompatibleVersion
                      )
        End If
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
        'End If
    End Sub
    Private Function CalibrationData(a As Object)
        If a = Nothing Then
            Return Nothing
        Else
            Return a
        End If
    End Function

    ''Program Start!!!
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame") Then
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame\Yave's Tours\Config.ini")
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame\Yave's Tours")
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame")
        End If
        If Not Directory.Exists(DefaultFolderPath) Then
            Directory.CreateDirectory(DefaultFolderPath)
        End If
        If Not File.Exists(DefaultINIPath) Then
            Dim a As Stream
            a = File.Create(DefaultINIPath)
            a.Close()
            writeINI(DefaultINIPath, "Options", "Language", "en_us")
            writeINI(DefaultINIPath, "Options", "Autosave", "false")
        Else
            Dim a As String
            Dim b As Boolean
            a = sGetINI(DefaultINIPath, "Options", "Language", "en_us")
            Select Case a
                Case "en_us"
                    Language = 0
                Case "zh_cn"
                    Language = 1
            End Select
            b = sGetINI(DefaultINIPath, "Options", "Autosave", "false")
            CheckBox2.Checked = b
            AutoSaving = b
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
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        Select Case Language
            Case 0
                RadioButton5.Checked = True
            Case 1
                RadioButton6.Checked = True
        End Select
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim a As Integer
        If progress <> True Then
            a = MsgBox(Strings.s_string(38, Language), vbYesNo, Me.Text)
            If a = vbYes Then
                OpenFileDialog()
            End If
        Else
            If CacheSaveFileName = "" Then
                Dim b As New SaveFileDialog
                CheckDirectory()
                If WorkUserPath <> "" Then
                    b.InitialDirectory = WorkDefaultPath
                Else
                    b.InitialDirectory = WorkUserPath
                End If
                b.Filter = Strings.s_string(106, Language) & "|*.yts"
                If b.ShowDialog = Windows.Forms.DialogResult.OK Then
                    SaveData(b.FileName)
                End If
            Else
                SaveData(CacheSaveFileName)
            End If
        End If
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        If Not isBattle Then
            NewSave.ShowDialog()
        End If
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
                Button7.Text = Strings.s_string(61, Language)
                Timer2.Enabled = True
            Else
                Button7.Text = Strings.s_string(60, Language)
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
            If isBattle Or Touring Or AutoBattle Then
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
            Else
                RadioButton1.Enabled = True
                RadioButton2.Enabled = True
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
                Panel10.Enabled = False
                DAB = True
                isBattle = False
                Button7.Enabled = True
            Else
                Panel10.Enabled = True
            End If
            If PlayerData.HP1 > PlayerData.HPM1 Then
                PlayerData.HP1 = PlayerData.HPM1
            End If
            If AutoSaving Then
                If Not isBattle Then
                    AutoSavingCooldown += 1
                    If AutoSavingCooldown = 100 * 60 Then
                        If Not CacheSaveFileName = "" Then
                            SaveData(CacheSaveFileName)
                            SavedLabelShowTime = 180
                        End If
                        AutoSavingCooldown = 0
                    End If
                End If
            Else
                Label37.Visible = False
            End If
            If SavedLabelShowTime > 0 Then
                SavedLabelShowTime -= 1
                Label37.Visible = True
            Else
                Label37.Visible = False
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
        With PlayerData
            Select Case b
                Case 0 To 0.01
                    .XP1 += 1
                Case 0.01 To 0.013
                    .HP1 += .HPM1 / 100
            End Select
        End With
        If DES <= 0 Then
            Select Case b
                Case 0 To 0.005
                    SelectEnemy()
                    isBattleDisplay = True
                    Panel10.Visible = True
                    Touring = False
                    isBattle = True
                    BattleMessage.Text = Strings.s_string(93, Language) & " " & CurrentEnemy.Name1 & " " & Strings.s_string(94, Language)
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
        If Not isBattle Then
            NewSave.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not isBattle Then
            OpenFileDialog()
        End If
    End Sub
    Private Sub UpgradeLabel_Click(sender As Object, e As EventArgs)
        Upgrade.Show()
    End Sub


    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Rosalina129/abattlegame/issues")
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub CPPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CPPToolStripMenuItem.Click
        If progress Then
            CPP.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        With ComboBox1
            If .SelectedIndex = 1 Then
                ComboBox2.Enabled = True
            Else
                ComboBox2.Enabled = False
            End If
        End With
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Language = 0
        writeINI(DefaultINIPath, "Options", "Language", "en_us")
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Language = 1
        writeINI(DefaultINIPath, "Options", "Language", "zh_cn")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Select Case CheckBox2.Checked
            Case True
                writeINI(DefaultINIPath, "Options", "Autosave", "true")
                AutoSaving = True
            Case False
                writeINI(DefaultINIPath, "Options", "Autosave", "false")
                AutoSaving = False
        End Select
    End Sub
    Private Sub UpgradeBut1_Click(sender As Object, e As EventArgs) Handles UpgradeBut1.Click
        With PlayerData
            Select Case .Level1
                Case 0 To 20
                    .HPM1 += 48 + MainWindow.r1.Next(0, 30)
                Case 21 To 40
                    .HPM1 += 72 + MainWindow.r1.Next(0, 56)
                Case 41 To 50
                    .HPM1 += 114 + MainWindow.r1.Next(0, 109)
                Case 51 To 60
                    .HPM1 += 76 + MainWindow.r1.Next(0, 80)
                Case 61 To 70
                    .HPM1 += 52 + MainWindow.r1.Next(0, 56)
                Case 71 To 80
                    .HPM1 += 34 + MainWindow.r1.Next(0, 32)
                Case 81 To 99
                    .HPM1 += 28 + MainWindow.r1.Next(0, 19)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut2_Click(sender As Object, e As EventArgs) Handles UpgradeBut2.Click
        With PlayerData
            Select Case .Level1
                Case 0 To 20
                    .ATK1 += 3 + MainWindow.r1.Next(0, 3)
                Case 21 To 40
                    .ATK1 += 5 + MainWindow.r1.Next(0, 8)
                Case 41 To 50
                    .ATK1 += 7 + MainWindow.r1.Next(0, 16)
                Case 51 To 60
                    .ATK1 += 4 + MainWindow.r1.Next(0, 12)
                Case 61 To 70
                    .ATK1 += 3 + MainWindow.r1.Next(0, 10)
                Case 71 To 80
                    .ATK1 += 2 + MainWindow.r1.Next(0, 8)
                Case 81 To 99
                    .ATK1 += 1 + MainWindow.r1.Next(0, 5)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut3_Click(sender As Object, e As EventArgs) Handles UpgradeBut3.Click
        With PlayerData
            Select Case .Level1
                Case 0 To 20
                    .DEF1 += 3 + MainWindow.r1.Next(0, 3)
                Case 21 To 40
                    .DEF1 += 5 + MainWindow.r1.Next(0, 8)
                Case 41 To 50
                    .DEF1 += 7 + MainWindow.r1.Next(0, 16)
                Case 51 To 60
                    .DEF1 += 4 + MainWindow.r1.Next(0, 12)
                Case 61 To 70
                    .DEF1 += 3 + MainWindow.r1.Next(0, 10)
                Case 71 To 80
                    .DEF1 += 2 + MainWindow.r1.Next(0, 8)
                Case 81 To 99
                    .DEF1 += 1 + MainWindow.r1.Next(0, 5)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut4_Click(sender As Object, e As EventArgs) Handles UpgradeBut4.Click
        With PlayerData
            .SE1 += 1 + MainWindow.r1.Next(0, 3)
            UpgradePoint -= 2
        End With
    End Sub
    Private Sub UpgradeBut5_Click(sender As Object, e As EventArgs) Handles UpgradeBut5.Click
        With PlayerData
            .CRate1 += MainWindow.r1.NextDouble() * 0.01
            UpgradePoint -= 2
        End With
    End Sub
    Private Sub UpgradeBut6_Click(sender As Object, e As EventArgs) Handles UpgradeBut6.Click
        With PlayerData
            .CDMG1 += 0.01 + MainWindow.r1.NextDouble() * 0.01
            UpgradePoint -= 1
        End With
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ABP = ComboBox3.SelectedIndex
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim b As New SaveFileDialog
        CheckDirectory()
        If WorkUserPath <> "" Then
            b.InitialDirectory = WorkDefaultPath
        Else
            b.InitialDirectory = WorkUserPath
        End If
        b.Filter = Strings.s_string(106, Language) & "|*.yts"
        If b.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveData(b.FileName)
        End If
    End Sub
End Class
