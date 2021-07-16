<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INPUTSISWA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INPUTSISWA))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbkeaktivan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbpengajar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbkelas = New System.Windows.Forms.ComboBox()
        Me.cbthajaran = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(0, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 149)
        Me.Panel1.TabIndex = 12
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 384)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(828, 209)
        Me.dgv.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbkeaktivan)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtnama)
        Me.Panel2.Controls.Add(Me.cbpengajar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbkelas)
        Me.Panel2.Controls.Add(Me.cbthajaran)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.AxCrystalReport1)
        Me.Panel2.Controls.Add(Me.lblwaktu)
        Me.Panel2.Controls.Add(Me.lbltanggal)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(828, 188)
        Me.Panel2.TabIndex = 13
        '
        'cbkeaktivan
        '
        Me.cbkeaktivan.BackColor = System.Drawing.Color.Teal
        Me.cbkeaktivan.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkeaktivan.ForeColor = System.Drawing.SystemColors.Window
        Me.cbkeaktivan.FormattingEnabled = True
        Me.cbkeaktivan.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbkeaktivan.Location = New System.Drawing.Point(195, 151)
        Me.cbkeaktivan.Name = "cbkeaktivan"
        Me.cbkeaktivan.Size = New System.Drawing.Size(261, 27)
        Me.cbkeaktivan.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "STATUS"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.Color.Teal
        Me.txtnama.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnama.Location = New System.Drawing.Point(194, 30)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(261, 25)
        Me.txtnama.TabIndex = 25
        '
        'cbpengajar
        '
        Me.cbpengajar.BackColor = System.Drawing.Color.Teal
        Me.cbpengajar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpengajar.ForeColor = System.Drawing.SystemColors.Window
        Me.cbpengajar.FormattingEnabled = True
        Me.cbpengajar.Items.AddRange(New Object() {"MISS NIDA", "MISS HANI"})
        Me.cbpengajar.Location = New System.Drawing.Point(195, 118)
        Me.cbpengajar.Name = "cbpengajar"
        Me.cbpengajar.Size = New System.Drawing.Size(261, 27)
        Me.cbpengajar.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "PENGAJAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Turquoise
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "INPUT DATA SISWA"
        '
        'cbkelas
        '
        Me.cbkelas.BackColor = System.Drawing.Color.Teal
        Me.cbkelas.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkelas.ForeColor = System.Drawing.SystemColors.Window
        Me.cbkelas.FormattingEnabled = True
        Me.cbkelas.Items.AddRange(New Object() {"CALISTUNG", "ENGLISH"})
        Me.cbkelas.Location = New System.Drawing.Point(194, 56)
        Me.cbkelas.Name = "cbkelas"
        Me.cbkelas.Size = New System.Drawing.Size(261, 27)
        Me.cbkelas.TabIndex = 22
        '
        'cbthajaran
        '
        Me.cbthajaran.BackColor = System.Drawing.Color.Teal
        Me.cbthajaran.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbthajaran.ForeColor = System.Drawing.SystemColors.Window
        Me.cbthajaran.FormattingEnabled = True
        Me.cbthajaran.Items.AddRange(New Object() {"2019/2020", "2020/2021"})
        Me.cbthajaran.Location = New System.Drawing.Point(194, 86)
        Me.cbthajaran.Name = "cbthajaran"
        Me.cbthajaran.Size = New System.Drawing.Size(261, 27)
        Me.cbthajaran.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TAHUN AJARAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "KELAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "NAMA"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(522, 147)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(124, 34)
        Me.Panel4.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox1.Location = New System.Drawing.Point(2, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 22)
        Me.TextBox1.TabIndex = 0
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(488, 12)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 12
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktu.Location = New System.Drawing.Point(255, 163)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(0, 19)
        Me.lblwaktu.TabIndex = 11
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.Location = New System.Drawing.Point(151, 163)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(0, 19)
        Me.lbltanggal.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnedit)
        Me.Panel3.Controls.Add(Me.btnhapus)
        Me.Panel3.Controls.Add(Me.btnlaporan)
        Me.Panel3.Controls.Add(Me.btnsimpan)
        Me.Panel3.Location = New System.Drawing.Point(522, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 134)
        Me.Panel3.TabIndex = 9
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnedit.Location = New System.Drawing.Point(61, 66)
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
        Me.btnhapus.Location = New System.Drawing.Point(2, 66)
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
        Me.PictureBox1.Location = New System.Drawing.Point(651, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 179)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Turquoise
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkeluar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(741, 595)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(100, 27)
        Me.btnkeluar.TabIndex = 16
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btncetak
        '
        Me.btncetak.BackColor = System.Drawing.Color.Turquoise
        Me.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncetak.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.Location = New System.Drawing.Point(13, 595)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(100, 27)
        Me.btncetak.TabIndex = 17
        Me.btncetak.Text = "CETAK"
        Me.btncetak.UseVisualStyleBackColor = False
        '
        'INPUTSISWA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 623)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "INPUTSISWA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUTSISWA"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbkelas As System.Windows.Forms.ComboBox
    Friend WithEvents cbthajaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents lblwaktu As System.Windows.Forms.Label
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbpengajar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents cbkeaktivan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
