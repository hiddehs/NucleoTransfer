Public Class setup
    Private Sub setup_Load(sender As Object, e As EventArgs) Handles Me.Load
        progfiledir.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        If (FolderBrowserDialog1.SelectedPath <> "") Then progfiledir.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.bindir = progfiledir.Text
        Panel2.Hide()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.transferremove = transferremovecheck.CheckState
        Panel3.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.setup = True
        My.Settings.version = My.Application.Info.Version.ToString
        My.Settings.Save()
        main.Show()
        Me.Close()
    End Sub


End Class