Public Class OldSaveDiff
    Public Diff As Integer
    Private Sub OldSaveDiff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DifficultySelect.SelectedIndex = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.OldSaveProgress = True
        Diff = DifficultySelect.SelectedIndex
        Close()
    End Sub
End Class