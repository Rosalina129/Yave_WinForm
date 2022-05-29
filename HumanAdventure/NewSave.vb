Public Class NewSave
    Dim e As Integer
    Private Sub NewSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rand As New Random
        TextBox1.Text = InitData.Name_Dictionary(Rand.Next(0, InitData.Name_Dictionary.Length))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim a As Integer = Me.ListBox1.SelectedIndex
        Dim b As Object
        Select Case a
            Case 0
                b = HumanAdventure.My.Resources.Resources.yave_1
            Case 1
                b = HumanAdventure.My.Resources.Resources.yave_2
            Case 2
                b = HumanAdventure.My.Resources.Resources.yave_3
            Case 3
                b = HumanAdventure.My.Resources.Resources.yave_4
            Case 4
                b = HumanAdventure.My.Resources.Resources.yave_5
            Case 5
                b = HumanAdventure.My.Resources.Resources.yave_6
            Case 6
                b = HumanAdventure.My.Resources.Resources.yave_7
        End Select
        PictureBox1.Image = b
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim InitName As New Random
        Dim a As Integer = InitName.Next(0, InitData.BasicStartData.Length)
        Label5.Text = InitData.BasicStartData(a)
        TextBox2.Text = InitData.BasicStartDescribe(a)
        MainWindow.TextBox2.Text = InitData.BasicStartData(a)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            Dim Rand As New Random
            InitData.CName = TextBox1.Text
            MainWindow.Properties.HPM = Int(150 + Rand.Next(0, 72))
            MainWindow.Properties.HP = MainWindow.Properties.HPM
            MainWindow.Properties.ATK = Int(4 + Rand.Next(0, 3))
            MainWindow.Properties.DEF = Int(3 + Rand.Next(0, 4))
            MainWindow.Properties.SE = 10
            MainWindow.Properties.CRate = 5
            MainWindow.Properties.CDMG = 50
            MainWindow.Properties.Level = 1
            MainWindow.Properties.XPNeed = Int(200 + Rand.Next(0, 12))
            MainWindow.progress = True
            Close()
        Else
            MsgBox("Please Input your name!", vbYes, MainWindow.Text)
        End If
    End Sub
End Class