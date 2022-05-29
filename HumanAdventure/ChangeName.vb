Public Class ChangeName
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            InitData.CName = TextBox1.Text
            Close()
        Else
            MsgBox("Please Input your name!", vbYes, MainWindow.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rand As New Random
        TextBox1.Text = InitData.Name_Dictionary(Rand.Next(0, InitData.Name_Dictionary.Length))
    End Sub
End Class