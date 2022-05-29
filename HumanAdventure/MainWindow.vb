Public Class MainWindow
    'Function StartNameReturn() As String
    'Dim a As Integer
    'Dim b(InitData.Name_Dictionary.Length) As String
    'For a = 0 To InitData.Name_Dictionary.Length Step 1
    'b(a)
    'Next
    'End Function
    Shared progress As Boolean
    Dim a As Integer
    Public Class Properties
        Public Shared Level As Integer = 1              'Level
        Public Shared XP As Double = 0                  'XP
        Public Shared XPNeed As Double = 200            'Need some XPs
        Public Shared HP As Double = 0                  'Health
        Public Shared HPM As Double = 0                 'Max Health
        Public Shared ATK As Double = 0                 'Attack
        Public Shared DEF As Double = 0                 'Defense
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InitDatas As New InitData
        Dim InitName As New Random
        InitData.CName = InitData.Name_Dictionary(InitName.Next(0, InitData.Name_Dictionary.Length))
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        ChangeName.ShowDialog()
        ChangeName.TextBox1.Text = InitData.CName
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        NewSave.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progress = True Then
            Panel5.Visible = False
            CharName.Text = InitData.CName
            HEALTHLabel.Text = Properties.HP & " / " & Properties.HPM
            ATKLabel.Text = Properties.ATK
            DEFLabel.Text = Properties.DEF
            a += 1
            If a >= 6 Then
                Properties.XP += 1
                a = 0
            End If
            XPBar.Maximum = Properties.XPNeed
            UpgradeLabel.Visible = False
            XPLabel.Text = Properties.XP & "/" & Properties.XPNeed
            If Properties.XP >= Properties.XPNeed Then
                XPMenuStrip1.Enabled = True
                UpgradeLabel.Visible = True
                XPBar.Value = XPBar.Maximum
            Else
                XPMenuStrip1.Enabled = False
                XPBar.Value = Properties.XP
            End If
            XPMenuStrip1.Text = Properties.XP & "/" & Properties.XPNeed
        Else
            Panel5.Visible = True
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
End Class