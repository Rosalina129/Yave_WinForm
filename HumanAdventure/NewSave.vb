Public Class NewSave
    Private Sub NewSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rand As New Random
        TextBox1.Text = InitData.Name_Dictionary(Rand.Next(0, InitData.Name_Dictionary.Length))
    End Sub
End Class