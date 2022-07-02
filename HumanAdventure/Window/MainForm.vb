
Imports System.IO
Imports System.Threading
Public Class MainForm

    Public Shared progress As Boolean               'Make public share
    Public langID As Byte = 0                     '0 = English (US), 1 = Chinese Simplified (PRC)
    Public NewSaveWindowProgress As Boolean
    'Place ID.
    Dim RegionID As Integer
    'IMPORTANT!!! This save version determines which version you play the save on,
    'and whether it is compatible with the current version!
    Const SaveVersion As Integer = 3
    Const CompatibleVersion As Integer = 2

    Public Shared ReadOnly SaveDefaultPath As String = Environment.CurrentDirectory & "\Save"
    Public Shared SaveUserPath As String
    Dim CacheSaveFileName As String

    Dim TourDist(2) As UInt64                '100 = 1 Meters
    Dim Touring As Boolean                  'Detect is in Tour mode.

    Dim Debug As Boolean = 0

    'IO Variables
    Dim isAutoBattle As Boolean               'Detect Auto battle is enabled.
    Dim isBattle As Boolean                 'Detect is in Battle mode.
    Dim isBattleDisplay As Boolean
    Dim isBattleComplete As Boolean
    Dim isBoss As Boolean
    Dim isRun As Integer
    Dim isautoEquip As Boolean

    Dim AutoPurchase As Integer
    Dim DAB As Boolean                      'Disable Action Buttons
    Dim DES As Integer                      'Disable Enemy Spawn
    Dim ABP As Byte
    Dim AutoSaving As Boolean
    Dim AutoSavingCD As Integer
    Dim SavedLabelShowTime As Integer

    Public Shared UpgradePoint As Integer
    Dim Blockadd As Double
    Dim BlockCD As Double

    Dim lostCoins As Integer
    Dim lostTourDis As UInt64

    Dim DeathCount As Integer

    Public Shared r1 As New Random
    Public Shared r1r As Double
    'Init PlayerData Class
    'Public ReadOnly OldPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame"
    'That's confidence from a stupid developer :)
    Public ReadOnly DefaultFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\WinFormGame\Yave's Tours"
    Public ReadOnly DefaultINIPath As String = DefaultFolderPath & "\Config.ini"
    Public PlayerData As InitPlayer
    Public ItemData As InitItem
    Public EnemyData As InitEnemy
    Public CurrentEnemy As InitEnemy
    Public Skill As InitSkill
    Public Basic As InitBasic

    Public UseItem(8) As Int16
    Public Material(8) As Int16
    '726, 601
    Private Sub ErrorOccurred()
        MsgBox("An unknown error occurred while attempting to perform this function.", vbYes, Me.Text)
        Application.Exit()
    End Sub
    Private Function km(a As Double)
        Return a * 100 * 1000
    End Function
    Private Sub SelectEnemy(type As Byte, enemyid As Integer)
        Dim a As Integer
        Select Case type
            Case 0
                Select Case RegionID
                    Case 0
                        Select Case TourDist(0)
                            Case 0 To km(2)
                                a = r1.Next(0, 5)
                                CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                            Case km(2) + 1 To km(5)
                                a = r1.Next(5, 11)
                                CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                            Case km(5) + 1 To km(10)
                                a = r1.Next(11, 22)
                                CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                            Case km(10) + 1 To km(20)
                                a = r1.Next(11, 22)
                                CurrentEnemy = New InitEnemy(Enemies.Enemy(a).ID1, Enemies.Enemy(a).Name1, Enemies.Enemy(a).HP1, Enemies.Enemy(a).HPM1, Enemies.Enemy(a).ATK1, Enemies.Enemy(a).DEF1, Enemies.Enemy(a).CRate1, Enemies.Enemy(a).CDMG1, Enemies.Enemy(a).EXP1, Enemies.Enemy(a).Coins1)
                        End Select
                End Select
            Case 1
                isBoss = True
                Select Case RegionID
                    Case 0
                        CurrentEnemy = New InitEnemy(Enemies.Boss_R1(enemyid).ID1,
                                                     Enemies.Boss_R1(enemyid).Name1,
                                                     Enemies.Boss_R1(enemyid).HP1,
                                                     Enemies.Boss_R1(enemyid).HPM1,
                                                     Enemies.Boss_R1(enemyid).ATK1,
                                                     Enemies.Boss_R1(enemyid).DEF1,
                                                     Enemies.Boss_R1(enemyid).CRate1,
                                                     Enemies.Boss_R1(enemyid).CDMG1,
                                                     Enemies.Boss_R1(enemyid).EXP1,
                                                     Enemies.Boss_R1(enemyid).Coins1)
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
    Private Sub start_battle(type As Byte)
        isBattleDisplay = True
        Panel10.Visible = True
        Touring = False
        isBattle = True
        Select Case type
            Case 0
                BattleMessage.Text = LangStr.s_string(93, langID) & " " & CurrentEnemy.Name1 & " " & LangStr.s_string(94, langID)
            Case 1
                BattleMessage.Text = LangStr.s_string(154, langID) & " " & CurrentEnemy.Name1 & " !"
        End Select
    End Sub
    Private Sub RefreshData()
        With PlayerData
            PictureBox1.Image = InitData.SkinGallery(.Sk)
            CharName.ForeColor = Color.FromArgb(InitData.ECR(.element1), InitData.ECG(.element1), InitData.ECB(.element1))
            CharName.Text = "[" & LangStr.s_string(80 + .element1, langID) & "] " & .CName1
            HEALTHLabel.Text = .HP1 & "/" & .HPM1
            Level.Text = .Level1
            ATKLabel.Text = .ATK1
            DEFLabel.Text = .DEF1
            SELabel.Text = .SE1 & "/100"
            CRLabel.Text = Math.Round(.CRate1 * 100, 1) & "%"
            CDLabel.Text = Math.Round(.CDMG1 * 100, 1) & "%"
            XPLabel.Text = .XP1 & "/" & .XPNeed1
            XPMenuStrip1.Text = .XP1 & "/" & .XPNeed1
            RegionLabel.Text = LangStr.s_string(42, langID) & " " & LangStr.s_string(48 + RegionID, langID)
            If TourDist(RegionID) >= 100000 Then
                Label24.Text = LangStr.s_string(63, langID) & " " & Math.Round(TourDist(RegionID) / 10 ^ 5, 2) & "km" '& "  " & DES
                Label41.Text = LangStr.s_string(63, langID) & " " & Math.Round(TourDist(RegionID) / 10 ^ 5, 2) & "km"
            Else
                Label24.Text = LangStr.s_string(63, langID) & " " & Math.Round(TourDist(RegionID) / 10 ^ 2, 2) & "m" '& "  " & DES
                Label41.Text = LangStr.s_string(63, langID) & " " & Math.Round(TourDist(RegionID) / 10 ^ 2, 2) & "m"
            End If
            XPBar.Maximum = .XPNeed1
            If .XP1 >= XPBar.Maximum Then
                XPBar.Value = XPBar.Maximum
            End If
            CheckXP()
            Label31.Text = LangStr.s_string(37, langID) & " " & UpgradePoint
            CoinsToolStripMenuItem.Text = .Coins1
            If isBattleDisplay Then
                With CurrentEnemy
                    CurEnemyData1.Text = "[" & LangStr.s_string(80 + .ID1, langID) & "] " & .Name1
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
            useitem1count.Text = UseItem(0)
            useitem2count.Text = UseItem(1)
            useitem3count.Text = UseItem(2)
            useitem4count.Text = UseItem(3)
            useitem5count.Text = UseItem(4)
            useitem6count.Text = UseItem(5)
            useitem7count.Text = UseItem(6)
            useitem8count.Text = UseItem(7)
            If UseItem(0) = 0 Then
                useitemaction1.Enabled = False
                useitemaction2.Enabled = False
                useitemaction3.Enabled = False
            Else
                useitemaction1.Enabled = True
                useitemaction2.Enabled = True
                useitemaction3.Enabled = True
            End If
            If UseItem(1) = 0 Then
                useitemaction4.Enabled = False
                useitemaction5.Enabled = False
                useitemaction6.Enabled = False
            Else
                useitemaction4.Enabled = True
                useitemaction5.Enabled = True
                useitemaction6.Enabled = True
            End If
            If UseItem(2) = 0 Then
                useitemaction7.Enabled = False
                useitemaction8.Enabled = False
                useitemaction9.Enabled = False
            Else
                useitemaction7.Enabled = True
                useitemaction8.Enabled = True
                useitemaction9.Enabled = True
            End If
            If UseItem(3) = 0 Then
                useitemaction10.Enabled = False
                useitemaction11.Enabled = False
                useitemaction12.Enabled = False
            Else
                useitemaction10.Enabled = True
                useitemaction11.Enabled = True
                useitemaction12.Enabled = True
            End If
            If UseItem(4) = 0 Then
                useitemaction13.Enabled = False
                useitemaction14.Enabled = False
                useitemaction15.Enabled = False
            Else
                useitemaction13.Enabled = True
                useitemaction14.Enabled = True
                useitemaction15.Enabled = True
            End If
            If UseItem(5) = 0 Then
                useitemaction16.Enabled = False
                useitemaction17.Enabled = False
                useitemaction18.Enabled = False
            Else
                useitemaction16.Enabled = True
                useitemaction17.Enabled = True
                useitemaction18.Enabled = True
            End If
            If UseItem(6) = 0 Then
                useitemaction19.Enabled = False
                useitemaction20.Enabled = False
                useitemaction21.Enabled = False
            Else
                useitemaction19.Enabled = True
                useitemaction20.Enabled = True
                useitemaction21.Enabled = True
            End If
            If UseItem(7) = 0 Then
                useitemaction22.Enabled = False
                useitemaction23.Enabled = False
                useitemaction24.Enabled = False
            Else
                useitemaction22.Enabled = True
                useitemaction23.Enabled = True
                useitemaction24.Enabled = True
            End If
        End With
    End Sub
    Private Function CheckUseItem(itemID As Integer)
        If UseItem(itemID) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Use_Item(acode As Integer)
        Dim a As Integer 'Item Array
        Dim b As Integer 'Item Count

        Select Case acode
            Case 0 To 2
                a = 0
            Case 3 To 5
                a = 1
            Case 6 To 8
                a = 2
            Case 9 To 11
                a = 3
            Case 12 To 14
                a = 4
            Case 15 To 17
                a = 5
            Case 18 To 20
                a = 6
            Case 21 To 23
                a = 7
        End Select

        Select Case acode
            Case 0, 3, 6, 9, 12, 15, 18, 21
                b = 1
            Case 1, 4, 7, 10, 13, 16, 19, 22
                b = 10
            Case 2, 5, 8, 11, 14, 17, 20, 23
                b = UseItem(a)
        End Select

        If CheckUseItem(a) Then
            Dim c As Integer 'Count
            For c = 0 To b - 1 Step 1
                If UseItem(a) <= 0 Then
                    Exit For
                End If
                UseItem(a) -= 1
                With PlayerData
                    Select Case a
                        Case 0
                            .XP1 += 100
                            CheckXP()
                        Case 1
                            .XP1 += 2500
                            CheckXP()
                        Case 2
                            .XP1 += 50000
                            CheckXP()
                        Case 3
                            .HP1 += 1000
                        Case 4
                            .HP1 += .HPM1 * 0.1
                        Case 5
                            .HP1 += .HPM1 * 0.25
                        Case 6
                            .HP1 += .HPM1 * 0.5
                        Case 7
                            .HP1 += .HPM1
                    End Select
                End With
            Next
        End If
    End Sub
    Private Sub CheckXP()
        If PlayerData.XP1 >= PlayerData.XPNeed1 Then
            UpgradeProp()
        End If
    End Sub
    Private Sub debugswitch()
        Label38.Visible = Debug
        Panel15.Visible = Debug
        Panel14.Visible = Debug
        ShowDebugToolStripMenuItem.Visible = Debug
    End Sub
    Private Sub UpgradeProp()

        With PlayerData
            .Level1 += 1
            UpgradePoint += 1 + r1.Next(0, 5)
            Select Case .Level1
                Case 0 To 20
                    .HPM1 += 30 + MainForm.r1.Next(0, 10)
                    Thread.Sleep(1)
                    .ATK1 += 2 + MainForm.r1.Next(0, 4)
                    Thread.Sleep(1)
                    .DEF1 += 1 + MainForm.r1.Next(0, 3)
                Case 21 To 40
                    .HPM1 += 45 + MainForm.r1.Next(0, 29)
                    Thread.Sleep(1)
                    .ATK1 += 4 + MainForm.r1.Next(0, 8)
                    Thread.Sleep(1)
                    .DEF1 += 4 + MainForm.r1.Next(0, 7)
                Case 41 To 50
                    .HPM1 += 50 + MainForm.r1.Next(0, 48)
                    Thread.Sleep(1)
                    .ATK1 += 3 + MainForm.r1.Next(0, 16)
                    Thread.Sleep(1)
                    .DEF1 += 3 + MainForm.r1.Next(0, 9)
                Case 51 To 60
                    .HPM1 += 42 + MainForm.r1.Next(0, 36)
                    Thread.Sleep(1)
                    .ATK1 += 3 + MainForm.r1.Next(0, 12)
                    Thread.Sleep(1)
                    .DEF1 += 3 + MainForm.r1.Next(0, 7)
                Case 61 To 70
                    .HPM1 += 30 + MainForm.r1.Next(0, 29)
                    Thread.Sleep(1)
                    .ATK1 += 2 + MainForm.r1.Next(0, 7)
                    Thread.Sleep(1)
                    .DEF1 += 2 + MainForm.r1.Next(0, 6)
                Case 71 To 80
                    .HPM1 += 24 + MainForm.r1.Next(0, 16)
                    Thread.Sleep(1)
                    .ATK1 += 1 + MainForm.r1.Next(0, 9)
                    Thread.Sleep(1)
                    .DEF1 += 1 + MainForm.r1.Next(0, 8)
                Case 81 To 99
                    .HPM1 += 18 + MainForm.r1.Next(0, 10)
                    Thread.Sleep(1)
                    .ATK1 += 0 + MainForm.r1.Next(0, 6)
                    Thread.Sleep(1)
                    .DEF1 += 0 + MainForm.r1.Next(0, 4)
            End Select
            .XP1 -= .XPNeed1
            .XPNeed1 += 65 + MainForm.r1.Next(20, 100)
            .HP1 = .HPM1
        End With
    End Sub
    Public Function DebugShow(pstring As String)
        MsgBox(pstring, vbYes, Me.Text)
        Return Nothing
    End Function
    Private Sub Battle_Damage(type As Byte)
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = CurrentEnemy.HP1
        Select Case type
            Case 0
                BattleMessage.Text = LangStr.s_string(135, langID) & LangStr.s_string(137, langID)
                CurrentEnemy.HP1 = Calculate.ADCount(CurrentEnemy.HP1, PlayerData.ATK1, CurrentEnemy.DEF1, PlayerData.CRate1, PlayerData.CDMG1)
                BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(97, langID) & (health(1) - CurrentEnemy.HP1) & LangStr.s_string(98, langID)
            Case 1
                BattleMessage.Text = LangStr.s_string(135, langID) & LangStr.s_string(107, langID)
                If PlayerData.SE1 <> 0 Then
                    Select Case r1.NextDouble()
                        Case 0 To 0.8
                            PlayerData.SE1 -= 1
                    End Select
                    CurrentEnemy.HP1 = Calculate.EleCount(CurrentEnemy.HP1, PlayerData.ATK1, CurrentEnemy.DEF1, PlayerData.CRate1, PlayerData.CDMG1, PlayerData.element1, CurrentEnemy.ID1)
                    BattleMessage.Text = BattleMessage.Text & Calculate.EleMessage(PlayerData.element1, CurrentEnemy.ID1, langID)
                    BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(97, langID) & (health(1) - CurrentEnemy.HP1) & LangStr.s_string(98, langID)
                Else
                    BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(141, langID)
                End If
            Case 2
                BattleMessage.Text = LangStr.s_string(135, langID) & LangStr.s_string(108, langID)
                Thread.Sleep(2)
                Select Case r1.NextDouble()
                    Case 0 To 0.5
                        Thread.Sleep(2)
                        Blockadd = Math.Round(1 + (r1.NextDouble() * 0.5), 2)
                        BlockCD = 3
                        BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(146, langID) & " +" & Blockadd * 100 & "% " & LangStr.s_string(29, langID)
                    Case 0.5 To 1
                        BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(147, langID)
                End Select
            Case 3
                BattleMessage.Text = LangStr.s_string(135, langID) & LangStr.s_string(109, langID)
                Thread.Sleep(2)
                Select Case r1.NextDouble()
                    Case 0 To 0.5
                        Thread.Sleep(2)
                        BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(144, langID)
                    Case 0.5 To 1
                        BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(145, langID) & " " & lostCoins & " " & LangStr.s_string(104, langID) & ", " & lostTourDis \ 100 & "m " & LangStr.s_string(63, langID)
                        CurrentEnemy.HP1 = 0
                        TourDist(RegionID) -= lostTourDis
                        PlayerData.Coins1 -= lostCoins
                        isRun = True
                End Select
        End Select
        Thread.Sleep(1)
        If (health(1) - CurrentEnemy.HP1) = 1 Then
            If langID = 0 Then
                BattleMessage.Text = BattleMessage.Text & "s"
            End If
        End If
        Thread.Sleep(5)
        Select Case r1.NextDouble()
            Case 0 To 0.18
                PlayerData.SE1 += r1.Next(0, 4)
        End Select
        If CurrentEnemy.HP1 > 0 Then
            BattleMessage.Text = BattleMessage.Text & vbCrLf & vbCrLf & LangStr.s_string(136, langID) & LangStr.s_string(137, langID)
            PlayerData.HP1 = Calculate.EleCount(PlayerData.HP1, CurrentEnemy.ATK1, PlayerData.DEF1 + PlayerData.DEF1 * Blockadd, CurrentEnemy.CRate1, CurrentEnemy.CDMG1, CurrentEnemy.ID1, PlayerData.element1)
            BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(96, langID) & (health(0) - PlayerData.HP1) & LangStr.s_string(98, langID)
            If (health(0) - PlayerData.HP1) = 1 Then
                If langID = 0 Then
                    BattleMessage.Text = BattleMessage.Text & "s"
                End If
            End If
        End If
        BlockCD -= 1
        If BlockCD < 0 Then
            BlockCD = 0
            Blockadd = 0
        End If
        If CurrentEnemy.HP1 <= 0 Then
            DES = 5000 + r1.Next(50, 2501)
            If isRun <> True Then
                PlayerData.SE1 += 10 + r1.Next(0, 7)
                PlayerData.XP1 += CurrentEnemy.EXP1
                PlayerData.Coins1 += CurrentEnemy.Coins1
                BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(103, langID) & " " & CurrentEnemy.Coins1 & " " & LangStr.s_string(104, langID) & ", " & CurrentEnemy.EXP1 & " " & LangStr.s_string(105, langID)
                Thread.Sleep(5)
                Dim a As Integer = r1.NextDouble()
                Select Case a
                    Case 0 To 0.05
                        Thread.Sleep(5)
                        Dim itemID As Integer = r1.Next(0, 8)
                        Thread.Sleep(5)
                        Dim itemCount As Integer = r1.Next(1, 4)
                        BattleMessage.Text = BattleMessage.Text & vbCrLf & LangStr.s_string(183, langID) & LangStr.s_item(1 + itemID, langID) & " x" & itemCount
                        UseItem(itemID) += itemCount
                End Select
            End If
            isRun = False
            isBoss = False
            isBattleComplete = True
            CurrentEnemy = New InitEnemy()
        End If
        If PlayerData.HP1 <= 0 Then
            PlayerData.HP1 = PlayerData.HPM1
            DeathCount += 1
            If Not isBoss Then
                BattleMessage.Text = BattleMessage.Text & vbCrLf & vbCrLf & LangStr.s_string(102, langID)
                TourDist(RegionID) -= lostTourDis
            Else
                BattleMessage.Text = BattleMessage.Text & vbCrLf & vbCrLf & LangStr.s_string(155, langID)
                TourDist(RegionID) \= 2
                isBoss = False
                isBattleComplete = True
                CurrentEnemy = New InitEnemy()
            End If
        End If
    End Sub
    Private Sub CheckDirectory()
        If Directory.Exists(SaveDefaultPath) Then
            Directory.CreateDirectory(SaveDefaultPath)
        End If
    End Sub
    Private Sub SaveData(SaveFileName As String)
        CacheSaveFileName = SaveFileName
        Dim fs As New FileStream(SaveFileName, FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        Dim b_redunant As Byte = 0
        Dim a As Integer
        bw.Write(SaveVersion)
        bw.Write(b_redunant)
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
        For a = 0 To UseItem.Length - 1 Step 1
            bw.Write(UseItem(a))
        Next
        bw.Write(UpgradePoint)
        bw.Write(DeathCount)
        bw.Write(RegionID)
        For a = 0 To TourDist.Length - 1 Step 1
            bw.Write(TourDist(a))
        Next
        bw.Close()
        fs.Close()
        SavedLabelShowTime = 180
    End Sub
    Private Sub OpenFileDialog()
        Dim a As New OpenFileDialog
        CheckDirectory()
        a.Filter = LangStr.s_string(106, langID) & "|*.yts" '|Yave's Tours Text File|*.txt|Yave's Tours Json File|*.json
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadData(a.FileName)
        End If
    End Sub
    Private Sub LoadData(LoadFileName)
        CacheSaveFileName = LoadFileName
        PlayerData = New InitPlayer
        Dim SaveVer As Integer
        Dim fs As New FileStream(LoadFileName, FileMode.Open)
        Dim br As New BinaryReader(fs)
        Dim c As Byte
        SaveVer = br.ReadInt32
        Select Case SaveVer
            Case 3
                Dim b As Integer
                c = br.ReadByte
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
                For b = 0 To UseItem.Length - 1 Step 1
                    UseItem(b) = br.ReadInt16
                Next
                UpgradePoint = br.ReadInt32
                DeathCount = br.ReadInt32
                RegionID = br.ReadInt32
                For b = 0 To TourDist.Length - 1 Step 1
                    TourDist(b) = br.ReadUInt64
                Next
                CurrentEnemy = New InitEnemy()
                isBattle = False
                Panel10.Visible = False
                progress = True
            Case 2
                If MsgBox(LangStr.s_string(134, langID), vbYesNo, Me.Text) = vbYes Then
                    Dim b As Integer
                    c = br.ReadByte
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
                    DeathCount = br.ReadInt32
                    RegionID = br.ReadInt32
                    For b = 0 To TourDist.Length - 1 Step 1
                        TourDist(b) = br.ReadUInt64
                    Next
                    CurrentEnemy = New InitEnemy()
                    isBattle = False
                    Panel10.Visible = False
                    progress = True
                End If
            Case Else
                DebugShow(LangStr.s_string(73, langID) & vbCrLf &
                              LangStr.s_string(56, langID) & ":" & SaveVersion & vbCrLf &
                              LangStr.s_string(57, langID) & ":" & SaveVer & vbCrLf &
                              LangStr.s_string(58, langID) & ":" & CompatibleVersion
                              )
        End Select
        br.Close()
        fs.Close()
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
            writeINI(DefaultINIPath, "Options", "langID", "en_us")
            writeINI(DefaultINIPath, "Options", "Autosave", "false")
        Else
            Dim a As String
            Dim b As Boolean
            a = sGetINI(DefaultINIPath, "Options", "langID", "en_us")
            Select Case a
                Case "en_us"
                    langID = 0
                Case "zh_cn"
                    langID = 1
            End Select
            b = sGetINI(DefaultINIPath, "Options", "Autosave", "false")
            CheckBox2.Checked = b
            AutoSaving = b
        End If
        Lang.setstr(langID)
        Panel10.Visible = False
        NewSaveWindowProgress = False

        Dim InitDatas As New InitData

        PlayerData = New InitPlayer()
        EnemyData = New InitEnemy()
        CurrentEnemy = New InitEnemy()

        CheckDirectory()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        Select Case langID
            Case 0
                RadioButton5.Checked = True
            Case 1
                RadioButton6.Checked = True
        End Select

        debugswitch()
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim a As Boolean
        If progress <> True Then
            a = MsgBox(LangStr.s_string(38, langID), vbYesNo, Me.Text)
            If a = vbYes Then
                OpenFileDialog()
            End If
        Else
            If Not isBoss Then
                If CacheSaveFileName = "" Then
                    Dim b As New SaveFileDialog
                    CheckDirectory()
                    b.Filter = LangStr.s_string(106, langID) & "|*.yts"
                    If b.ShowDialog = Windows.Forms.DialogResult.OK Then
                        SaveData(b.FileName)
                    End If
                Else
                    SaveData(CacheSaveFileName)
                End If
            End If
        End If
    End Sub

    Private Sub ChangeName_Open(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub
    Dim saveFilename As String
    Private Sub NewSave_Open(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click, Button2.Click
        Dim a As New SaveFileDialog
        a.Filter = LangStr.s_string(106, langID) & "|*.yts"
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            progress = False
            saveFilename = a.FileName
            NewSave.ShowDialog()
        End If
    End Sub
    Private Sub GameThread_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1r = r1.NextDouble
        If NewSaveWindowProgress = True Then
            NewSaveWindowProgress = False
            DES = 7500 + r1.Next(0, 5001)
            With NewSave
                PlayerData = New InitPlayer(.Skin, .Element, .CName, .Level, .XP, .XPNeed, .HPM, .HP, .ATK, .DEF, .SE, .CRate, .CDMG, .Coins)
            End With
            RegionID = NewSave.PlaceID
            Dim a As Integer
            For a = 0 To TourDist.Length - 1 Step 1
                TourDist(a) = 0
            Next
            isBattle = False
            Panel10.Visible = False
            SaveData(saveFilename)
            progress = True
        End If
        If progress = True Then
            If Touring Then
                Button7.Text = LangStr.s_string(61, langID)
                Timer2.Enabled = True
            Else
                Button7.Text = LangStr.s_string(60, langID)
                Timer2.Enabled = False
            End If
            If PlayerData.SE1 > 100 Then
                PlayerData.SE1 = 100
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
            If isBattle Or Touring Or isAutoBattle Then
                RegionButton1.Enabled = False
            Else
                RegionButton1.Enabled = True
            End If
            If isAutoBattle Then
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
            End If
            If isBattleComplete Then
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
                If Not isBattle And Not isBoss Then
                    AutoSavingCD += 1
                    If AutoSavingCD = 100 * 60 Then
                        If Not CacheSaveFileName = "" Then
                            SaveData(CacheSaveFileName)
                            SavedLabelShowTime = 180
                        End If
                        AutoSavingCD = 0
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
            If isBattle Or Touring Then
                Panel14.Enabled = False
            Else
                Panel14.Enabled = True
            End If
            With PlayerData
                lostCoins = .Coins1 \ 100
                lostTourDis = TourDist(RegionID) \ 10
            End With
            If BlockCD > 0 Or isAutoBattle Then
                Button10.Enabled = False
            Else
                Button10.Enabled = True
            End If
            If isBoss Or isAutoBattle Then
                Button11.Enabled = False
            Else
                Button11.Enabled = True
            End If
            RefreshData()
            Panel5.Visible = False
        Else
            Panel5.Visible = True
            Panel5.Location = New Point(0, 23)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        TourDist(RegionID) += 2
        DES -= (2)
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
        Select Case TourDist(RegionID)
            Case km(2) To km(2) + 1
                SelectEnemy(1, 0)
                start_battle(1)
            Case km(10) To km(10) + 1
                SelectEnemy(1, 1)
                start_battle(1)
            Case km(15) To km(15) + 1
                SelectEnemy(1, 2)
                start_battle(1)
            Case km(20) To km(20) + 1
                SelectEnemy(1, 3)
                start_battle(1)
            Case km(25) To km(25) + 1
                SelectEnemy(1, 4)
                start_battle(1)
        End Select
        If DES <= 0 Then
            Select Case b
                Case 0 To 0.005
                    SelectEnemy(0, 0)
                    start_battle(0)
            End Select
        End If
    End Sub
    Private Sub aboutDialog(sender As Object, e As EventArgs) Handles AboutsToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub openIssuesURL(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Rosalina129/abattlegame/issues")
    End Sub
    Private Sub EmeraldPlains_Changed(sender As Object, e As EventArgs) Handles RegionButton1.CheckedChanged
        RegionID = 0
    End Sub
    Private Sub DripForest_Changed(sender As Object, e As EventArgs) Handles RegionButton2.CheckedChanged
        RegionID = 1
    End Sub
    Private Sub DigitOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Heal(sender As Object, e As EventArgs) Handles HealHPToolStripMenuItem.Click
        PlayerData.HP1 = PlayerData.HPM1
    End Sub
    Private Sub TourButton(sender As Object, e As EventArgs) Handles Button7.Click
        If Touring Then
            Touring = False
        Else
            Touring = True
        End If
        If isBattleComplete Then
            Panel10.Visible = False
            isBattleDisplay = False
            Touring = True
            isBattleComplete = False
        End If
    End Sub

    Private Sub AutoBattle(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            isAutoBattle = True
        Else
            isAutoBattle = False
        End If
    End Sub

    Private Sub BattleTime_Tick(sender As Object, e As EventArgs) Handles BattleTime.Tick
        If isBattleComplete Then
            Panel10.Visible = False
            isBattleDisplay = False
            Touring = True
            isBattleComplete = False
        End If
        If isBattle Then
            Select Case ABP
                Case 0
                    Thread.Sleep(5)
                    Select Case r1.NextDouble()
                        Case 0 To 0.85
                            Battle_Damage(0)
                        Case 0.85 To 1
                            Battle_Damage(1)
                    End Select
                Case 1
                    Thread.Sleep(5)
                    Select Case r1.NextDouble()
                        Case 0 To 0.85
                            If ElementRates.Multi(PlayerData.element1, CurrentEnemy.ID1) < 1 Then
                                Thread.Sleep(5)
                                Select Case r1.NextDouble()
                                    Case 0 To 0.85
                                        Battle_Damage(0)
                                    Case 0.85 To 1
                                        Battle_Damage(1)
                                End Select
                            Else
                                Battle_Damage(1)
                            End If
                        Case 0.85 To 1
                            Battle_Damage(0)
                    End Select
            End Select
        End If
    End Sub
    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click, Button1.Click
        OpenFileDialog()
    End Sub
    Private Sub CPPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CPPToolStripMenuItem.Click
        If progress Then
            ChangePlayerProp.Show()
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
        langID = 0
        writeINI(DefaultINIPath, "Options", "langID", "en_us")
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        langID = 1
        writeINI(DefaultINIPath, "Options", "langID", "zh_cn")
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
                    .HPM1 += 48 + MainForm.r1.Next(0, 30)
                Case 21 To 40
                    .HPM1 += 72 + MainForm.r1.Next(0, 56)
                Case 41 To 50
                    .HPM1 += 114 + MainForm.r1.Next(0, 109)
                Case 51 To 60
                    .HPM1 += 76 + MainForm.r1.Next(0, 80)
                Case 61 To 70
                    .HPM1 += 52 + MainForm.r1.Next(0, 56)
                Case 71 To 80
                    .HPM1 += 34 + MainForm.r1.Next(0, 32)
                Case 81 To 99
                    .HPM1 += 28 + MainForm.r1.Next(0, 19)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut2_Click(sender As Object, e As EventArgs) Handles UpgradeBut2.Click
        With PlayerData
            Select Case .Level1
                Case 0 To 20
                    .ATK1 += 3 + MainForm.r1.Next(0, 3)
                Case 21 To 40
                    .ATK1 += 5 + MainForm.r1.Next(0, 8)
                Case 41 To 50
                    .ATK1 += 7 + MainForm.r1.Next(0, 16)
                Case 51 To 60
                    .ATK1 += 4 + MainForm.r1.Next(0, 12)
                Case 61 To 70
                    .ATK1 += 3 + MainForm.r1.Next(0, 10)
                Case 71 To 80
                    .ATK1 += 2 + MainForm.r1.Next(0, 8)
                Case 81 To 99
                    .ATK1 += 1 + MainForm.r1.Next(0, 5)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut3_Click(sender As Object, e As EventArgs) Handles UpgradeBut3.Click
        With PlayerData
            Select Case .Level1
                Case 0 To 20
                    .DEF1 += 3 + MainForm.r1.Next(0, 3)
                Case 21 To 40
                    .DEF1 += 5 + MainForm.r1.Next(0, 8)
                Case 41 To 50
                    .DEF1 += 7 + MainForm.r1.Next(0, 16)
                Case 51 To 60
                    .DEF1 += 4 + MainForm.r1.Next(0, 12)
                Case 61 To 70
                    .DEF1 += 3 + MainForm.r1.Next(0, 10)
                Case 71 To 80
                    .DEF1 += 2 + MainForm.r1.Next(0, 8)
                Case 81 To 99
                    .DEF1 += 1 + MainForm.r1.Next(0, 5)
            End Select
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut4_Click(sender As Object, e As EventArgs) Handles UpgradeBut4.Click
        With PlayerData
            .SE1 += 100
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub UpgradeBut5_Click(sender As Object, e As EventArgs) Handles UpgradeBut5.Click
        With PlayerData
            .CRate1 += MainForm.r1.NextDouble() * 0.01
            UpgradePoint -= 2
        End With
    End Sub
    Private Sub UpgradeBut6_Click(sender As Object, e As EventArgs) Handles UpgradeBut6.Click
        With PlayerData
            .CDMG1 += 0.01 + MainForm.r1.NextDouble() * 0.01
            UpgradePoint -= 1
        End With
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ABP = ComboBox3.SelectedIndex
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If Not isBoss Then
            Dim b As New SaveFileDialog
            CheckDirectory()
            b.Filter = LangStr.s_string(106, langID) & "|*.yts"
            If b.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveData(b.FileName)
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox(
            LangStr.s_string(123, langID) & ": " & vbCrLf &
            LangStr.s_string(139, langID) & vbCrLf & vbCrLf &
            LangStr.s_string(124, langID) & ": " & vbCrLf &
            LangStr.s_string(140, langID) & vbCrLf & vbCrLf &
            LangStr.s_string(142, langID) & ": " & vbCrLf &
            LangStr.s_string(150, langID) & ": " & vbCrLf &
            LangStr.s_string(143, langID) & vbCrLf &
            LangStr.s_string(151, langID) & vbCrLf &
            LangStr.s_string(152, langID),
            vbYes, Me.Text
            )
    End Sub
    Private Sub attack(sender As Object, e As EventArgs) Handles Button8.Click
        Battle_Damage(0)
    End Sub
    Private Sub ele_attack(sender As Object, e As EventArgs) Handles Button9.Click
        Battle_Damage(1)
    End Sub
    Private Sub block(sender As Object, e As EventArgs) Handles Button10.Click
        Battle_Damage(2)
    End Sub
    Private Sub run(sender As Object, e As EventArgs) Handles Button11.Click
        Battle_Damage(3)
    End Sub
    Private Sub EasterEgg_Click(sender As Object, e As EventArgs) Handles EasterEgg.Click
        Dim a As Integer
        a = MsgBox(LangStr.s_string(149, langID), vbYesNo, LangStr.s_string(148, langID))
        If a = vbYes Then
            a = MsgBox("Thanks!", vbYes, Me.Text)
        End If
    End Sub
    Private Sub set_Distance(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text <> "" Then
            TourDist(RegionID) = TextBox1.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EleDescribe.Show()
    End Sub
    Private Sub UseItem_Button(sender As Object, e As EventArgs) Handles useitemaction1.Click, useitemaction2.Click, useitemaction3.Click, useitemaction4.Click, useitemaction5.Click, useitemaction6.Click, useitemaction7.Click, useitemaction8.Click, useitemaction9.Click, useitemaction10.Click, useitemaction11.Click, useitemaction12.Click, useitemaction13.Click, useitemaction14.Click, useitemaction15.Click, useitemaction16.Click, useitemaction17.Click, useitemaction18.Click, useitemaction19.Click, useitemaction20.Click, useitemaction21.Click, useitemaction22.Click, useitemaction23.Click, useitemaction24.Click
        Use_Item(sender.TabIndex - 59)
        Tag = "UseItem"
    End Sub
End Class
