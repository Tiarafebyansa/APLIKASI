<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATASISWAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABSENSIGURUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABSENSISISWAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELASCALISTUNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELASENGLISHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELESAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INPUTDATASISWAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATASISWAToolStripMenuItem, Me.SELESAIToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATASISWAToolStripMenuItem
        '
        Me.DATASISWAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABSENSIGURUToolStripMenuItem, Me.ABSENSISISWAToolStripMenuItem, Me.INPUTDATASISWAToolStripMenuItem})
        Me.DATASISWAToolStripMenuItem.Name = "DATASISWAToolStripMenuItem"
        Me.DATASISWAToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.DATASISWAToolStripMenuItem.Text = "DATA SISWA"
        '
        'ABSENSIGURUToolStripMenuItem
        '
        Me.ABSENSIGURUToolStripMenuItem.Name = "ABSENSIGURUToolStripMenuItem"
        Me.ABSENSIGURUToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.ABSENSIGURUToolStripMenuItem.Text = "ABSENSI GURU"
        '
        'ABSENSISISWAToolStripMenuItem
        '
        Me.ABSENSISISWAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KELASCALISTUNGToolStripMenuItem, Me.KELASENGLISHToolStripMenuItem})
        Me.ABSENSISISWAToolStripMenuItem.Name = "ABSENSISISWAToolStripMenuItem"
        Me.ABSENSISISWAToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.ABSENSISISWAToolStripMenuItem.Text = "ABSENSI SISWA"
        '
        'KELASCALISTUNGToolStripMenuItem
        '
        Me.KELASCALISTUNGToolStripMenuItem.Name = "KELASCALISTUNGToolStripMenuItem"
        Me.KELASCALISTUNGToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.KELASCALISTUNGToolStripMenuItem.Text = "KELAS CALISTUNG"
        '
        'KELASENGLISHToolStripMenuItem
        '
        Me.KELASENGLISHToolStripMenuItem.Name = "KELASENGLISHToolStripMenuItem"
        Me.KELASENGLISHToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.KELASENGLISHToolStripMenuItem.Text = "KELAS ENGLISH"
        '
        'SELESAIToolStripMenuItem
        '
        Me.SELESAIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KELUARToolStripMenuItem})
        Me.SELESAIToolStripMenuItem.Name = "SELESAIToolStripMenuItem"
        Me.SELESAIToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SELESAIToolStripMenuItem.Text = "SELESAI"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        '
        'INPUTDATASISWAToolStripMenuItem
        '
        Me.INPUTDATASISWAToolStripMenuItem.Name = "INPUTDATASISWAToolStripMenuItem"
        Me.INPUTDATASISWAToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.INPUTDATASISWAToolStripMenuItem.Text = "INPUT DATA SISWA"
        '
        'HalUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(713, 535)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HalUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HalUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DATASISWAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABSENSIGURUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABSENSISISWAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELASCALISTUNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELASENGLISHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELESAIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INPUTDATASISWAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
