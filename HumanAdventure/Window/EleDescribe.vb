Public Class EleDescribe
    Dim selectindex As Integer
    Private Sub ElementCalc(ele As Integer)
        Dim a As Integer
        For a = 0 To 8 Step 1
            Label1.Text = Label1.Text & LangStr.s_string(169, MainForm.langID) & LangStr.s_string(80 + a, MainForm.langID) & ": x" & ElementRates.Multi(ele, a) & vbCrLf
        Next
    End Sub
    Private Sub EleDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label2.Text = LangStr.s_string(158, MainForm.langID)
        Dim a As Integer
        For a = 0 To 8 Step 1
            ListBox1.Items(a) = LangStr.s_string(80 + a, MainForm.langID)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ""
        ElementCalc(ListBox1.SelectedIndex)
    End Sub
End Class