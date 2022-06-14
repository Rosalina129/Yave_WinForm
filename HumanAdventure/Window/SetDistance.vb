Public Class SetDistance
    Private Sub SetDistance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With MainForm
            Text = LangStr.s_string(154, .langID)
            title.Text = LangStr.s_string(154, .langID)
            Button1.Text = LangStr.s_string(111, .langID)
            currentdistance.Text = LangStr.s_string(155, .langID) & " " & .TourDist(.RegionID)
            currentregion.Text = LangStr.s_string(156, .langID) & " " & LangStr.s_string(48 + .RegionID, .langID)
        End With
    End Sub
    Private Sub only_digit(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            With MainForm
                .TourDist(.RegionID) = TextBox1.Text
            End With
        End If
        Close()
    End Sub
End Class