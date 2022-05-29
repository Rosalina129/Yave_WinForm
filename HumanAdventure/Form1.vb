Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InitDatas As New InitData
        InitData.CName = ""
    End Sub
    Private Sub SaveDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripMenuItem.Click
        Dim SaveDataFolder As String
        SaveDataDialog.ShowDialog()
    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        Form2.ShowDialog()
        Form2.TextBox1.Text = InitData.CName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CharName.Text = InitData.CName
    End Sub
End Class
