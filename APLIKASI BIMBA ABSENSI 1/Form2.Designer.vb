<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxCrystalReport3 = New AxCrystal.AxCrystalReport()
        Me.AxCrystalReport2 = New AxCrystal.AxCrystalReport()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.AxCrystalReport3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.AxCrystalReport3)
        Me.Panel1.Controls.Add(Me.AxCrystalReport2)
        Me.Panel1.Controls.Add(Me.AxCrystalReport1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 197)
        Me.Panel1.TabIndex = 1
        '
        'AxCrystalReport3
        '
        Me.AxCrystalReport3.Enabled = True
        Me.AxCrystalReport3.Location = New System.Drawing.Point(666, 11)
        Me.AxCrystalReport3.Name = "AxCrystalReport3"
        Me.AxCrystalReport3.OcxState = CType(resources.GetObject("AxCrystalReport3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport3.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport3.TabIndex = 5
        '
        'AxCrystalReport2
        '
        Me.AxCrystalReport2.Enabled = True
        Me.AxCrystalReport2.Location = New System.Drawing.Point(700, 11)
        Me.AxCrystalReport2.Name = "AxCrystalReport2"
        Me.AxCrystalReport2.OcxState = CType(resources.GetObject("AxCrystalReport2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport2.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport2.TabIndex = 4
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(734, 11)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(548, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 117)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LAPORAN HARIAN GURU"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(63, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CETAK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 117)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LAPORAN HARIAN ENGLISH"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(65, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CETAK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LAPORAN HARIAN CALISTUNG"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CETAK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 197)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxCrystalReport3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AxCrystalReport3 As AxCrystal.AxCrystalReport
    Friend WithEvents AxCrystalReport2 As AxCrystal.AxCrystalReport
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
