Public Class ChangeName
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            MainForm.PlayerData.CName1 = TextBox1.Text
            Close()
        Else
            MainForm.DebugShow(s_string(41, MainForm.langID))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rand As New Random
        TextBox1.Text = InitData.Name_Dictionary(Rand.Next(0, InitData.Name_Dictionary.Length))
    End Sub

    Private Sub ChangeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = s_string(40, MainForm.langID)
        Button1.Text = s_string(25, MainForm.langID)
    End Sub
End Class