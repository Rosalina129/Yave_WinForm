﻿Public Class Upgrade
    Dim Levels As Integer              'Level
    Dim HPMs As Double                 'Max Health
    Dim ATKs As Double                 'Attack
    Dim DEFs As Double                 'Defense
    Public Shared Levela As Integer              'Level
    Public Shared HPMa As Double                 'Max Health
    Public Shared ATKa As Double                 'Attack
    Public Shared DEFa As Double                 'Defense

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With MainForm.PlayerData
            If RadioButton1.Checked Then
                .HPM1 = HPMa
                .HP1 = .HPM1
            End If
            If RadioButton2.Checked Then
                .ATK1 = ATKa
            End If
            If RadioButton3.Checked Then
                .DEF1 = DEFa
            End If
        End With
        MainForm.UpgradePoint -= 1
        MsgBox("Upgrade Successful!", vbYes, MainForm.Text)
        InitData.isUpgrade = True
        Close()
    End Sub

    Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case MainForm.r1.NextDouble()
            Case 0 To 0.33
                RadioButton1.Checked = True
            Case 0 To 0.67
                RadioButton2.Checked = True
            Case 0 To 0.1
                RadioButton3.Checked = True
        End Select
        With MainForm.PlayerData
            Levels = .Level1
            HPMs = .HPM1
            ATKs = .ATK1
            DEFs = .DEF1
        End With
        Levela = Levels + 1
        Select Case Levels
            Case 0 To 20
                HPMa = HPMs + 16 + MainForm.r1.Next(0, 10)
                ATKa = ATKs + 1 + MainForm.r1.Next(0, 2)
                DEFa = DEFs + 1 + MainForm.r1.Next(0, 2)
            Case 21 To 40
                HPMa = HPMs + 36 + MainForm.r1.Next(6, 18)
                ATKa = ATKs + 2 + MainForm.r1.Next(0, 4)
                DEFa = DEFs + 2 + MainForm.r1.Next(0, 3)
            Case 41 To 50
                HPMa = HPMs + MainForm.r1.Next(39, 55)
                ATKa = ATKs + 4 + MainForm.r1.Next(0, 5)
                DEFa = DEFs + 3 + MainForm.r1.Next(0, 3)
            Case 51 To 60
                HPMa = HPMs + MainForm.r1.Next(52, 74)
                ATKa = ATKs + 5 + MainForm.r1.Next(0, 6)
                DEFa = DEFs + 3 + MainForm.r1.Next(0, 4)
            Case 61 To 70
                HPMa = HPMs + 32 + MainForm.r1.Next(0, 10)
                ATKa = ATKs + 6 + MainForm.r1.Next(0, 4)
                DEFa = DEFs + 4 + MainForm.r1.Next(0, 2)
            Case 71 To 80
                HPMa = HPMs + 10 + MainForm.r1.Next(0, 10)
                ATKa = ATKs + 3 + MainForm.r1.Next(0, 3)
                DEFa = DEFs + 1 + MainForm.r1.Next(0, 2)
            Case 81 To 99
                HPMa = HPMs + 8 + MainForm.r1.Next(0, 10)
                ATKa = ATKs + 1 + MainForm.r1.Next(0, 2)
                DEFa = DEFs + 1 + MainForm.r1.Next(0, 1)
        End Select
        lvl.Text = Levels
        mh.Text = HPMs
        atk.Text = ATKs
        def.Text = DEFs
        lvlafter.Text = Levela
        mhafter.Text = HPMa
        atkafter.Text = ATKa
        defafter.Text = DEFa
    End Sub
End Class