<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KlsCalistung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KlsCalistung))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbtingkatan = New System.Windows.Forms.ComboBox()
        Me.cbkehadiran = New System.Windows.Forms.ComboBox()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblkelas = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 149)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.AxCrystalReport1)
        Me.Panel2.Controls.Add(Me.lblwaktu)
        Me.Panel2.Controls.Add(Me.lbltanggal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cbtingkatan)
        Me.Panel2.Controls.Add(Me.cbkehadiran)
        Me.Panel2.Controls.Add(Me.cbnama)
        Me.Panel2.Controls.Add(Me.txtnim)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(13, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 188)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(579, 141)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(124, 34)
        Me.Panel4.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox1.Location = New System.Drawing.Point(2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 22)
        Me.TextBox1.TabIndex = 0
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(548, 5)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 12
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktu.Location = New System.Drawing.Point(318, 162)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(0, 19)
        Me.lblwaktu.TabIndex = 11
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.Location = New System.Drawing.Point(214, 162)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(0, 19)
        Me.lbltanggal.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DATA ABSENSI SISWA"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnedit)
        Me.Panel3.Controls.Add(Me.btnhapus)
        Me.Panel3.Controls.Add(Me.btnlaporan)
        Me.Panel3.Controls.Add(Me.btnsimpan)
        Me.Panel3.Location = New System.Drawing.Point(579, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 134)
        Me.Panel3.TabIndex = 9
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnedit.Location = New System.Drawing.Point(3, 69)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(58, 64)
        Me.btnedit.TabIndex = 3
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.BackgroundImage = CType(resources.GetObject("btnhapus.BackgroundImage"), System.Drawing.Image)
        Me.btnhapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnhapus.Location = New System.Drawing.Point(62, 69)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(58, 64)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnlaporan
        '
        Me.btnlaporan.BackgroundImage = CType(resources.GetObject("btnlaporan.BackgroundImage"), System.Drawing.Image)
        Me.btnlaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlaporan.Location = New System.Drawing.Point(62, 1)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(58, 64)
        Me.btnlaporan.TabIndex = 1
        Me.btnlaporan.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImage = CType(resources.GetObject("btnsimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsimpan.Location = New System.Drawing.Point(2, 1)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(58, 64)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(729, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 179)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'cbtingkatan
        '
        Me.cbtingkatan.BackColor = System.Drawing.Color.Teal
        Me.cbtingkatan.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtingkatan.ForeColor = System.Drawing.SystemColors.Window
        Me.cbtingkatan.FormattingEnabled = True
        Me.cbtingkatan.Items.AddRange(New Object() {"LEVEL 1 (KURANG)", "LEVEL 2 (CUKUP)", "LEVEL 3 (BAIK)"})
        Me.cbtingkatan.Location = New System.Drawing.Point(214, 98)
        Me.cbtingkatan.Name = "cbtingkatan"
        Me.cbtingkatan.Size = New System.Drawing.Size(261, 27)
        Me.cbtingkatan.TabIndex = 7
        '
        'cbkehadiran
        '
        Me.cbkehadiran.BackColor = System.Drawing.Color.Teal
        Me.cbkehadiran.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkehadiran.ForeColor = System.Drawing.SystemColors.Window
        Me.cbkehadiran.FormattingEnabled = True
        Me.cbkehadiran.Items.AddRange(New Object() {"HADIR", "IZIN", "SAKIT", "ALPHA"})
        Me.cbkehadiran.Location = New System.Drawing.Point(214, 130)
        Me.cbkehadiran.Name = "cbkehadiran"
        Me.cbkehadiran.Size = New System.Drawing.Size(261, 27)
        Me.cbkehadiran.TabIndex = 6
        '
        'cbnama
        '
        Me.cbnama.BackColor = System.Drawing.Color.Teal
        Me.cbnama.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnama.ForeColor = System.Drawing.SystemColors.Window
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(214, 66)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(261, 27)
        Me.cbnama.TabIndex = 5
        '
        'txtnim
        '
        Me.txtnim.BackColor = System.Drawing.Color.Teal
        Me.txtnim.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnim.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnim.Location = New System.Drawing.Point(214, 31)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(80, 27)
        Me.txtnim.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "KEHADIRAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "TINGKATAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIM"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Turquoise
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkeluar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(831, 594)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(95, 27)
        Me.btnkeluar.TabIndex = 14
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 381)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(914, 209)
        Me.dgv.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(644, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tahun ajaran 2020/2021"
        '
        'lblkelas
        '
        Me.lblkelas.AutoSize = True
        Me.lblkelas.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkelas.Location = New System.Drawing.Point(12, 163)
        Me.lblkelas.Name = "lblkelas"
        Me.lblkelas.Size = New System.Drawing.Size(93, 18)
        Me.lblkelas.TabIndex = 5
        Me.lblkelas.Text = "CALISTUNG"
        '
        'Timer1
        '
        '
        'btncetak
        '
        Me.btncetak.BackColor = System.Drawing.Color.Turquoise
        Me.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncetak.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.Location = New System.Drawing.Point(13, 594)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(95, 27)
        Me.btncetak.TabIndex = 15
        Me.btncetak.Text = "CETAK"
        Me.btncetak.UseVisualStyleBackColor = False
        '
        'KlsCalistung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(938, 623)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.lblkelas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "KlsCalistung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "KlsCalistung"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbtingkatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbkehadiran As System.Windows.Forms.ComboBox
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblwaktu As System.Windows.Forms.Label
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblkelas As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btncetak As System.Windows.Forms.Button
End Class
