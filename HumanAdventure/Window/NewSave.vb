Public Class NewSave
    Dim e As Integer
    Public Skin As Integer
    Public Element As Integer
    Public CName As String
    Public Level As Integer
    Public XP As UInt64
    Public XPNeed As UInt64
    Public HP As Integer
    Public HPM As Integer
    Public ATK As Integer
    Public DEF As Integer
    Public SE As Integer
    Public CRate As Double
    Public CDMG As Double
    Public Coins As Integer
    Public PlaceID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rand As New Random()
        TextBox1.Text = InitData.Name_Dictionary(Rand.Next(0, InitData.Name_Dictionary.Length))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = InitData.SkinGallery(Me.ListBox1.SelectedIndex)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("In Progress...", vbYes, MainForm.Text)
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            Dim Rand As New Random
            Skin = ListBox1.SelectedIndex
            Element = Rand.Next(0, 3)
            CName = TextBox1.Text
            Level = 1
            XP = 0
            XPNeed = 150 + Rand.Next(0, 75)
            HPM = 150 + Rand.Next(0, 75)
            HP = HPM
            ATK = 3 + Rand.Next(0, 2)
            DEF = 1 + Rand.Next(0, 3)
            SE = 0
            CRate = 0.05
            CDMG = 0.5
            Coins = 0
            PlaceID = 0
            MainForm.NewSaveWindowProgress = True
            Close()
        Else
            MainForm.DebugShow(Strings.s_string(41, MainForm.langID))
        End If
    End Sub
    Private Sub NewSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 0
    End Sub
End Class