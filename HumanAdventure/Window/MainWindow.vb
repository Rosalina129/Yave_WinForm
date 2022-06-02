
Imports System.IO
Public Class MainWindow

    Public Shared progress As Boolean               'Make public share
    Dim a As Integer                                'XP Auto generation :)
    Dim amax As Integer = 60                        'Max Auto values
    Public Language As Byte = 0                     '0 = English (US), 1 = Chinese Simplified (PRC)
    Public NewSaveWindowProgress As Boolean

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
            ATKLabel.Text = .ATK1
            DEFLabel.Text = .DEF1
            SELabel.Text = .SE1
            CRLabel.Text = .CRate1 * 100 & "%"
            CDLabel.Text = .CDMG1 * 100 & "%"
            XPLabel.Text = .XP1 & "/" & .XPNeed1
            XPMenuStrip1.Text = .XP1 & "/" & .XPNeed1
            XPBar.Maximum = .XPNeed1
            XPBar.Value = .XP1
            CoinsToolStripMenuItem.Text = .Coins1
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
    Public Function GetElement(a)
        Select Case a
            Case 0
                Return "Ice"          '冰
            Case 1
                Return "Fire"         '火
            Case 2
                Return "Water"        '水
            Case 3
                Return "Earth"        '草
            Case 4
                Return "Star"         '星
            Case 5
                Return "Metal"        '钢铁
            Case 6
                Return "Electric"     '雷电
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewSaveWindowProgress = False
        Dim InitDatas As New InitData
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        NewSave.ShowDialog()
        NewSaveWindowProgress = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1r = r1.NextDouble
        If NewSaveWindowProgress = True Then
            NewSaveWindowProgress = False
            With NewSave
                PlayerData = New InitPlayer(.Skin, .Element, .CName, .Level, .XP, .XPNeed, .HPM, .HP, .ATK, .DEF, .SE, .CRate, .CDMG, .Coins)
            End With
            progress = True
        End If
        If progress = True Then
            RefreshData()
            a += 1
            If a >= amax Then
                a = 0
                amax = 10 + r1.Next(0, 30)
                PlayerData.XP1 += 1
            End If
            CheckXP()
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

    Public Sub LanguageChange(a As Byte)
        Language = a
        Select Case a
            Case 0

            Case 1

        End Select
    End Sub
End Class