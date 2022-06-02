Public Class Upgrade
    Dim Levels As Integer              'Level
    Dim HPMs As Double                 'Max Health
    Dim ATKs As Double                 'Attack
    Dim DEFs As Double                 'Defense
    Public Shared Levela As Integer              'Level
    Public Shared HPMa As Double                 'Max Health
    Public Shared ATKa As Double                 'Attack
    Public Shared DEFa As Double                 'Defense

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MainWindow.Properties.Level = Levela
        'MainWindow.Properties.HPM = HPMa
        'MainWindow.Properties.HP = MainWindow.Properties.HPM
        'MainWindow.Properties.ATK = ATKa
        'MainWindow.Properties.DEF = DEFa
        'MainWindow.Properties.XP = 0
        MsgBox("Upgrade Successful!", vbYes, MainWindow.Text)
        InitData.isUpgrade = True
        Close()
    End Sub

    Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Levels = MainWindow.Properties.Level
        'HPMs = MainWindow.Properties.HPM
        'ATKs = MainWindow.Properties.ATK
        'DEFs = MainWindow.Properties.DEF
        Levela = Levels + 1
        Select Case Levels
            Case 0 To 20
                HPMa = HPMs + 76 + MainWindow.r1.Next(0, 10)
                ATKa = ATKs + 3 + MainWindow.r1.Next(0, 2)
                DEFa = DEFs + 3 + MainWindow.r1.Next(0, 2)
            Case 21 To 40
                HPMa = HPMs + 56 + MainWindow.r1.Next(6, 18)
                ATKa = ATKs + 4 + MainWindow.r1.Next(0, 3)
                DEFa = DEFs + 4 + MainWindow.r1.Next(0, 3)
            Case 41 To 50
                HPMa = HPMs + MainWindow.r1.Next(79, 105)
                ATKa = ATKs + 7 + MainWindow.r1.Next(0, 5)
                DEFa = DEFs + 7 + MainWindow.r1.Next(0, 5)
            Case 51 To 60
                HPMa = HPMs + MainWindow.r1.Next(112, 184)
                ATKa = ATKs + 9 + MainWindow.r1.Next(0, 6)
                DEFa = DEFs + 9 + MainWindow.r1.Next(0, 6)
            Case 61 To 70
                HPMa = HPMs + 62 + MainWindow.r1.Next(0, 10)
                ATKa = ATKs + 6 + MainWindow.r1.Next(0, 4)
                DEFa = DEFs + 6 + MainWindow.r1.Next(0, 4)
            Case 71 To 80
                HPMa = HPMs + 49 + MainWindow.r1.Next(0, 10)
                ATKa = ATKs + 3 + MainWindow.r1.Next(0, 3)
                DEFa = DEFs + 3 + MainWindow.r1.Next(0, 3)
            Case 81 To 99
                HPMa = HPMs + 16 + MainWindow.r1.Next(0, 10)
                ATKa = ATKs + 1 + MainWindow.r1.Next(0, 4)
                DEFa = DEFs + 1 + MainWindow.r1.Next(0, 4)
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