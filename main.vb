Imports System
Imports System.IO
Public Class main

    Dim connection As Boolean
    Dim nucleoname As String
    Dim nucleodrive As String
    Dim conntime As Integer
    Dim dirwatch As Boolean

    Function checkconnection(type)
        status.Text = "Searching for devices..."
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        driveselection.Items.Clear()
        Dim d As DriveInfo
        For Each d In allDrives.Where(Function(dd) dd.DriveType = DriveType.Removable)
            If d.IsReady = True Then driveselection.Items.Add(d.Name & " " & d.VolumeLabel)
            If d.IsReady = True And File.Exists(d.Name & "DETAILS.TXT") = True Then
                driveselection.SelectedText = d.Name & " " & d.VolumeLabel
                'nucleo te pakken
                'form to top
                If (type = "check") Then
                    Me.BringToFront()
                    Me.Activate()
                    Me.WindowState = FormWindowState.Normal
                End If
                connection = True
                nucleodrive = d.Name
                title.Text = d.VolumeLabel.Replace("NODE_", "")
            End If
        Next
        If (type.substring(0, 3) = "go-") Then
            nucleodrive = type.substring(3, 3)
            title.Text = type.substring(7).Replace("NODE_", "")
            connection = True
        End If

        If (connection = True) Then

            status.Text = "Nucleo device found!"
            conntext.Text = "Device connected"

            conncolor.BackColor = Color.DarkGreen

            desct.Text = File.ReadAllText(nucleodrive & "DETAILS.TXT")

            conntimet.Start()
            devdetailsview.Show()
            connection = True
            dirwatchtogglebut.Enabled = True
            Me.Height = 266

        End If
        If (connection <> True) Then
            If (type = "load") Then status.Text = "No devices found"

            conntext.Text = "No device connected"
            conncolor.BackColor = Color.DarkRed
            Me.Height = 111
            dirwatchtogglebut.Enabled = False
        End If

        Return True
    End Function
    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkconnection("load")
    End Sub

    'reset functionnn
    Private Sub resetbut_Click(sender As Object, e As EventArgs) Handles resetbut.Click
        Dim yesnore = MsgBox("This will reset NucleoTransfer and all your settings, are you sure?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If (yesnore = MsgBoxResult.Yes) Then
            My.Settings.setup = False
            My.Settings.bindir = ""
            My.Settings.firstdirwatchuse = False
            My.Settings.transferremove = False
            My.Settings.version = ""
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.Show()
    End Sub

    Private Sub conntimet_Tick(sender As Object, e As EventArgs) Handles conntimet.Tick
        If (connection) Then
            conntime = conntime + 1
            conntimetxt.Text = conntime & " seconds"
        End If
    End Sub

    Private Sub conncheck_Tick(sender As Object, e As EventArgs) Handles conncheck.Tick

        If (connection = True) Then
            If (File.Exists(nucleodrive & "DETAILS.TXT") = False) Then
                connection = False
                status.Text = "Device connection lost"
                conntext.Text = "No device connected"
                conncolor.BackColor = Color.DarkRed
                Me.Height = 111

                devdetailsview.Hide()
                conntimet.Stop()
                conntime = 0

                DirWatcht.Stop()
                dirwatch = False
                dirwatchtogglebut.Text = "Start DirWatch"
                dirwatchtogglebut.Enabled = False
            End If
        Else
            checkconnection("check")
        End If
    End Sub

    Private Sub driveselection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles driveselection.SelectedIndexChanged
        Dim newdevtry As String = driveselection.SelectedItem.Substring(0, 3)
        If (File.Exists(newdevtry & "DETAILS.TXT")) Then
            checkconnection("go-" & driveselection.SelectedItem)
        Else
            status.Text = "This is not a Nucleo Device"
        End If
    End Sub

    Private Sub dirwatchtogglebut_Click(sender As Object, e As EventArgs) Handles dirwatchtogglebut.Click
        If (dirwatch = True) Then
            dirwatchtogglebut.Text = "Start DirWatch"
            status.Text = "DirWatch is stopped"
            dirwatch = False
            DirWatcht.Stop()
        Else
            dirwatchtogglebut.Text = "Stop DirWatch"
            status.Text = "Directory Watcher is active!"
            DirWatcht.Start()
            dirwatch = True
        End If
    End Sub
    Dim newprogfile As String = "NucleoTransfer.exe"
    Dim oldwindowstate
    Private Sub DirWatcht_Tick(sender As Object, e As EventArgs) Handles DirWatcht.Tick
        'Dim myFile = Directory.GetFiles(My.Settings.bindir).OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()
        Dim myFile = "NucleoTransfer.exe"
        Dim lastwritetime = File.GetLastWriteTime("NucleoTransfer.exe")
        Try
            myFile = Directory.GetFiles(My.Settings.bindir).Where(Function(y) New FileInfo(y).Extension = ".bin").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()

            If (File.GetLastWriteTime(myFile) <> lastwritetime Or myFile <> newprogfile) Then
                oldwindowstate = Me.WindowState
                Console.Write(oldwindowstate)
                'something going on here
                Me.Activate()
                Me.WindowState = FormWindowState.Normal
                Me.BringToFront()

                status.Text = "Transferring a file now..."
                lasttransferd.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
                lasttransferf.Text = Path.GetFileName(myFile)
                'the most important bit
                File.Copy(myFile, nucleodrive & Path.GetFileName(myFile), True)
                If (My.Settings.transferremove = True) Then File.Delete(myFile)
                newprogfile = myFile
                lastwritetime = File.GetLastWriteTime(myFile)
            Else
                status.Text = "DirWatch = Watching"
                If oldwindowstate = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Minimized oldwindowstate = FormWindowState.Normal
            End If
        Catch ex As Exception
            status.Text = "DirWatch = Watching"
        End Try
    End Sub

    Private Sub resetbut_MouseHover(sender As Object, e As EventArgs) Handles resetbut.MouseHover
        resetbut.Text = "Reset NucleoTransfer"
        resetbut.Width = 175
    End Sub

    Private Sub resetbut_MouseLeave(sender As Object, e As EventArgs) Handles resetbut.MouseLeave
        resetbut.Text = "R"
        resetbut.Width = 20
    End Sub
End Class
