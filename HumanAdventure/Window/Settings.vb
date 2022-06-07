Public Class Settings
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Select Case TreeView1.SelectedNode.Tag
            Case 1
                GameWorkPanel.Visible = True
                LanguagePanel.Visible = False
                OtherPanel.Visible = False
            Case 2
                GameWorkPanel.Visible = False
                LanguagePanel.Visible = True
                OtherPanel.Visible = False
            Case 3
                LanguagePanel.Visible = False
                GameWorkPanel.Visible = False
                OtherPanel.Visible = True
            Case Else
                LanguagePanel.Visible = False
                GameWorkPanel.Visible = False
                OtherPanel.Visible = False
        End Select
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainWindow.WorkUserPath = "" Then
            TextBox1.Text = MainWindow.WorkDefaultPath
        Else
            TextBox1.Text = MainWindow.WorkUserPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LoadPath = New FolderBrowserDialog
        LoadPath.Description = "Select a new location where you want to set Game work location..."
        LoadPath.ShowDialog()
        If LoadPath.SelectedPath = "" Then
        Else
            MsgBox("You selected: " & LoadPath.SelectedPath & Chr(13) & "Are you sure to set this location?", vbYesNo, MainWindow.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = MainWindow.WorkDefaultPath
    End Sub
End Class