<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.toprow = New System.Windows.Forms.Panel()
        Me.conncolor = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.resetbut = New System.Windows.Forms.Button()
        Me.conntext = New System.Windows.Forms.Label()
        Me.bottomrow = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.driveselection = New System.Windows.Forms.ComboBox()
        Me.dirwatchtogglebut = New System.Windows.Forms.Button()
        Me.conncheck = New System.Windows.Forms.Timer(Me.components)
        Me.conntimet = New System.Windows.Forms.Timer(Me.components)
        Me.DirWatcht = New System.Windows.Forms.Timer(Me.components)
        Me.devdetailsview = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lasttransferf = New System.Windows.Forms.Label()
        Me.lasttransferd = New System.Windows.Forms.Label()
        Me.conntimetxt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.desct = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.toprow.SuspendLayout()
        Me.bottomrow.SuspendLayout()
        Me.devdetailsview.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toprow
        '
        Me.toprow.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.toprow.Controls.Add(Me.conncolor)
        Me.toprow.Controls.Add(Me.Button2)
        Me.toprow.Controls.Add(Me.resetbut)
        Me.toprow.Controls.Add(Me.conntext)
        Me.toprow.Dock = System.Windows.Forms.DockStyle.Top
        Me.toprow.Location = New System.Drawing.Point(0, 0)
        Me.toprow.Name = "toprow"
        Me.toprow.Size = New System.Drawing.Size(506, 34)
        Me.toprow.TabIndex = 0
        '
        'conncolor
        '
        Me.conncolor.BackColor = System.Drawing.Color.DarkRed
        Me.conncolor.Dock = System.Windows.Forms.DockStyle.Left
        Me.conncolor.Location = New System.Drawing.Point(0, 0)
        Me.conncolor.Name = "conncolor"
        Me.conncolor.Size = New System.Drawing.Size(19, 34)
        Me.conncolor.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(424, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'resetbut
        '
        Me.resetbut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.resetbut.Dock = System.Windows.Forms.DockStyle.Right
        Me.resetbut.FlatAppearance.BorderSize = 0
        Me.resetbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetbut.Location = New System.Drawing.Point(486, 0)
        Me.resetbut.Name = "resetbut"
        Me.resetbut.Size = New System.Drawing.Size(20, 34)
        Me.resetbut.TabIndex = 1
        Me.resetbut.Text = "R"
        Me.resetbut.UseVisualStyleBackColor = False
        '
        'conntext
        '
        Me.conntext.AutoSize = True
        Me.conntext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.conntext.Location = New System.Drawing.Point(25, 7)
        Me.conntext.Name = "conntext"
        Me.conntext.Size = New System.Drawing.Size(153, 21)
        Me.conntext.TabIndex = 0
        Me.conntext.Text = "No device connected"
        '
        'bottomrow
        '
        Me.bottomrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.bottomrow.Controls.Add(Me.status)
        Me.bottomrow.Controls.Add(Me.Label2)
        Me.bottomrow.Controls.Add(Me.driveselection)
        Me.bottomrow.Controls.Add(Me.dirwatchtogglebut)
        Me.bottomrow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomrow.Location = New System.Drawing.Point(0, 193)
        Me.bottomrow.Name = "bottomrow"
        Me.bottomrow.Size = New System.Drawing.Size(506, 34)
        Me.bottomrow.TabIndex = 0
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.status.Location = New System.Drawing.Point(52, 6)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(127, 21)
        Me.status.TabIndex = 0
        Me.status.Text = "no devices found"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status:"
        '
        'driveselection
        '
        Me.driveselection.Dock = System.Windows.Forms.DockStyle.Right
        Me.driveselection.DropDownWidth = 150
        Me.driveselection.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.driveselection.FormattingEnabled = True
        Me.driveselection.Items.AddRange(New Object() {"X:\"})
        Me.driveselection.Location = New System.Drawing.Point(297, 0)
        Me.driveselection.Name = "driveselection"
        Me.driveselection.Size = New System.Drawing.Size(90, 33)
        Me.driveselection.TabIndex = 1
        '
        'dirwatchtogglebut
        '
        Me.dirwatchtogglebut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dirwatchtogglebut.Dock = System.Windows.Forms.DockStyle.Right
        Me.dirwatchtogglebut.Location = New System.Drawing.Point(387, 0)
        Me.dirwatchtogglebut.Name = "dirwatchtogglebut"
        Me.dirwatchtogglebut.Size = New System.Drawing.Size(119, 34)
        Me.dirwatchtogglebut.TabIndex = 0
        Me.dirwatchtogglebut.Text = "Start DirWatch"
        Me.dirwatchtogglebut.UseVisualStyleBackColor = True
        '
        'conncheck
        '
        Me.conncheck.Enabled = True
        Me.conncheck.Interval = 4000
        '
        'conntimet
        '
        Me.conntimet.Interval = 1000
        '
        'DirWatcht
        '
        Me.DirWatcht.Interval = 3000
        '
        'devdetailsview
        '
        Me.devdetailsview.Controls.Add(Me.PictureBox1)
        Me.devdetailsview.Controls.Add(Me.lasttransferf)
        Me.devdetailsview.Controls.Add(Me.lasttransferd)
        Me.devdetailsview.Controls.Add(Me.conntimetxt)
        Me.devdetailsview.Controls.Add(Me.Label8)
        Me.devdetailsview.Controls.Add(Me.Label6)
        Me.devdetailsview.Controls.Add(Me.desct)
        Me.devdetailsview.Controls.Add(Me.Label5)
        Me.devdetailsview.Controls.Add(Me.title)
        Me.devdetailsview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.devdetailsview.Location = New System.Drawing.Point(0, 34)
        Me.devdetailsview.Name = "devdetailsview"
        Me.devdetailsview.Size = New System.Drawing.Size(506, 159)
        Me.devdetailsview.TabIndex = 1
        Me.devdetailsview.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.NucleoTransfer.My.Resources.Resources.Tekengebied_3
        Me.PictureBox1.Location = New System.Drawing.Point(297, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lasttransferf
        '
        Me.lasttransferf.AutoSize = True
        Me.lasttransferf.Location = New System.Drawing.Point(7, 124)
        Me.lasttransferf.Name = "lasttransferf"
        Me.lasttransferf.Size = New System.Drawing.Size(0, 21)
        Me.lasttransferf.TabIndex = 0
        '
        'lasttransferd
        '
        Me.lasttransferd.AutoSize = True
        Me.lasttransferd.Location = New System.Drawing.Point(102, 103)
        Me.lasttransferd.Name = "lasttransferd"
        Me.lasttransferd.Size = New System.Drawing.Size(50, 21)
        Me.lasttransferd.TabIndex = 0
        Me.lasttransferd.Text = "Never"
        '
        'conntimetxt
        '
        Me.conntimetxt.AutoSize = True
        Me.conntimetxt.Location = New System.Drawing.Point(115, 82)
        Me.conntimetxt.Name = "conntimetxt"
        Me.conntimetxt.Size = New System.Drawing.Size(78, 21)
        Me.conntimetxt.TabIndex = 0
        Me.conntimetxt.Text = "0 seconds"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Last transfer:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Connected for:"
        '
        'desct
        '
        Me.desct.AutoSize = True
        Me.desct.Location = New System.Drawing.Point(91, 41)
        Me.desct.Name = "desct"
        Me.desct.Size = New System.Drawing.Size(0, 21)
        Me.desct.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Description:"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(3, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(62, 32)
        Me.title.TabIndex = 0
        Me.title.Text = "Title"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 227)
        Me.Controls.Add(Me.devdetailsview)
        Me.Controls.Add(Me.bottomrow)
        Me.Controls.Add(Me.toprow)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NucleoTransfer"
        Me.toprow.ResumeLayout(False)
        Me.toprow.PerformLayout()
        Me.bottomrow.ResumeLayout(False)
        Me.bottomrow.PerformLayout()
        Me.devdetailsview.ResumeLayout(False)
        Me.devdetailsview.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toprow As Panel
    Friend WithEvents conntext As Label
    Friend WithEvents bottomrow As Panel
    Friend WithEvents driveselection As ComboBox
    Friend WithEvents dirwatchtogglebut As Button
    Friend WithEvents conncheck As Timer
    Friend WithEvents conntimet As Timer
    Friend WithEvents DirWatcht As Timer
    Friend WithEvents status As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents resetbut As Button
    Friend WithEvents devdetailsview As Panel
    Friend WithEvents conntimetxt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents title As Label
    Friend WithEvents lasttransferd As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents conncolor As Panel
    Friend WithEvents desct As Label
    Friend WithEvents lasttransferf As Label
End Class
