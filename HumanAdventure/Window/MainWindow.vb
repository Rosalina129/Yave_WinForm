
Imports System.IO
Public Class MainWindow

    Public Shared progress As Boolean               'Make public share
    Dim a As Integer                                'XP Auto generation :)
    Dim amax As Integer = 60                        'Max Auto values
    Public Language As Byte = 0                     '0 = English (US), 1 = Chinese Simplified (PRC)
    Public NewSaveWindowProgress As Boolean
    'Place ID.
    Dim RegionID As Integer
    Dim RegionName As String() = {
        "Emerald Plains",
        "Drip Forest"
    }
    Dim TourDistance(2) As Double

    Dim Touring As Boolean

    Dim AutoBattle As Boolean
    Dim isBattle As Boolean

    Public Class Cache
        Public Shared SettingID As Integer
    End Class
    Dim ccc
    Public Shared r1 As New Random
    Public Shared r1r As Double
    'Init PlayerData Class
    Public DefaultPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\WinFormGame\Yave's Tours"
    Public PlayerData As InitPlayer
    Public ItemData As InitItem
    Public EnemyData As InitEnemy
    Public Skill As InitSkill
    Public Basic As InitBasic
    '726, 601
    Private Sub ErrorOccurred()
        MsgBox("An unknown error occurred while attempting to perform this function.", vbYes, Me.Text)
        Application.Exit()
    End Sub
    Private Sub RefreshData()
        With PlayerData
            PictureBox1.Image = InitData.SkinGallery(.Sk)
            CharName.ForeColor = Color.FromArgb(InitData.ECR(.element1), InitData.ECG(.element1), InitData.ECB(.element1))
            CharName.Text = "[" & GetElement(.element1) & "] " & .CName1
            HEALTHLabel.Text = .HP1 & "/" & .HPM1
            Level.Text = .Level1
            ATKLabel.Text = .ATK1
            DEFLabel.Text = .DEF1
            SELabel.Text = .SE1
            CRLabel.Text = .CRate1 * 100 & "%"
            CDLabel.Text = (1 + .CDMG1) * 100 & "%"
            XPLabel.Text = .XP1 & "/" & .XPNeed1
            XPMenuStrip1.Text = .XP1 & "/" & .XPNeed1
            PlaceLabel.Text = RegionName(RegionID)
            TourDistanceLabel.Text = Math.Round(TourDistance(RegionID), 3) & "Km"
            CheckXP()
            XPBar.Maximum = .XPNeed1
            XPBar.Value = .XP1
            CoinsToolStripMenuItem.Text = .Coins1

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
    Private Sub Simulate_Damage()
        Dim health(2) As Integer
        health(0) = PlayerData.HP1
        health(1) = EnemyData.HP1
        PlayerData.HP1 = Calculate.ADCount(PlayerData.HP1, EnemyData.ATK1, PlayerData.DEF1, EnemyData.CRate1, EnemyData.CDMG1)
        EnemyData.HP1 = Calculate.ADCount(EnemyData.HP1, PlayerData.ATK1, EnemyData.DEF1, PlayerData.CRate1, PlayerData.CDMG1)
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
    Public Function GetElement(a)
        Select Case a
            Case 1
                Return "Ice"          '冰
            Case 2
                Return "Fire"         '火
            Case 3
                Return "Water"        '水
            Case 4
                Return "Earth"        '草
            Case 5
                Return "Star"         '星
            Case 6
                Return "Metal"        '钢铁
            Case 7
                Return "Electric"     '雷电
            Case Else
                Return "Common"
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewSaveWindowProgress = False
        Dim InitDatas As New InitData

        PlayerData = New InitPlayer()
        EnemyData = New InitEnemy()
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim a As Integer
        If progress <> True Then
            a = MsgBox("You must to have a Game Thread in Progress, Would you like open a Game Saves?", vbYesNo, Me.Text)
            If a = vbYes Then
                MsgBox("Open")
            End If
        End If
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        NewSave.ShowDialog()
        NewSaveWindowProgress = True
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
            progress = True
        End If
        If progress = True Then
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
            RefreshData()
            Panel5.Visible = False
        Else
            Panel5.Visible = True
            Panel5.Location = New Point(0, 23)
        End If
    End Sub
    Private Sub AboutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutsToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub TextFormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFormatToolStripMenuItem.Click
        SaveDataDialog.ShowDialog()
    End Sub

    Private Sub UpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeToolStripMenuItem.Click
        Upgrade.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewSave.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Simulate_Damage()
    End Sub

    Private Sub HealHPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HealHPToolStripMenuItem.Click
        PlayerData.HP1 = PlayerData.HPM1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        a += 1
        TourDistance(RegionID) += 0.00001
        Dim b As Double
        b = r1.NextDouble()
        Select Case b
            Case 0 To 0.01
                PlayerData.XP1 += 1
        End Select
        Select Case b
            Case 0 To 0.0001
                Touring = False
                isBattle = True
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Touring Then
            Touring = False
        Else
            Touring = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AutoBattle = True
        Else
            AutoBattle = False
        End If
    End Sub
End Class
