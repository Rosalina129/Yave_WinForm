Public Class ChangePlayerProp
    Private Sub CPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = LangStr.s_string(110, MainForm.langID)
        Label1.Text = LangStr.s_string(110, MainForm.langID)
        Label2.Text = LangStr.s_string(27, MainForm.langID)
        Label3.Text = LangStr.s_string(28, MainForm.langID)
        Label4.Text = LangStr.s_string(29, MainForm.langID)
        Label5.Text = LangStr.s_string(30, MainForm.langID)
        Label6.Text = LangStr.s_string(31, MainForm.langID)
        Label7.Text = LangStr.s_string(32, MainForm.langID)
        Label8.Text = LangStr.s_string(33, MainForm.langID)
        Button1.Text = LangStr.s_string(111, MainForm.langID)
        With MainForm
            TextBox1.Text = .PlayerData.HPM1
            TextBox2.Text = .PlayerData.ATK1
            TextBox3.Text = .PlayerData.DEF1
            TextBox4.Text = .PlayerData.SE1
            TextBox5.Text = .PlayerData.CRate1
            TextBox6.Text = .PlayerData.CDMG1
            TextBox7.Text = .PlayerData.Level1
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox6.Text <> "" And TextBox5.Text <> "" Then
            With MainForm.PlayerData
                .HPM1 = TextBox1.Text
                .ATK1 = TextBox2.Text
                .DEF1 = TextBox3.Text
                .SE1 = TextBox4.Text
                .CRate1 = TextBox5.Text
                .CDMG1 = TextBox6.Text
                .Level1 = TextBox7.Text
            End With
            Close()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress, TextBox6.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(CType(sender, TextBox).Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class