Public Class MainWindow
    'Function StartNameReturn() As String
    'Dim a As Integer
    'Dim b(InitData.Name_Dictionary.Length) As String
    'For a = 0 To InitData.Name_Dictionary.Length Step 1
    'b(a)
    'Next
    'End Function
    Shared progress As Double
    Public Class Properties
        Public Shared HP As Double = 0
        Public Shared HPM As Double = 0
        Public Shared ATK As Double = 0
        Public Shared DEF As Double = 0
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
        CharName.Text = InitData.CName
        HEALTHLabel.Text = Properties.HP & " / " & Properties.HPM
        ATKLabel.Text = Properties.ATK
        DEFLabel.Text = Properties.DEF
        progress += 1
        If progress >= Properties.HPM Then
            progress = 200
        End If
        XPMenuStrip1.Text = progress & "/" & XPBar.Maximum
        XPBar.Value = progress
    End Sub
    Private Sub AboutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutsToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub TextFormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFormatToolStripMenuItem.Click

        SaveDataDialog.ShowDialog()
    End Sub

End Class