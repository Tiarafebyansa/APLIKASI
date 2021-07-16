Imports System.Data.Odbc
Imports excel = Microsoft.Office.Interop.Excel
Public Class INPUTSISWA
    Sub kosongkan()
        txtnama.Text = ""
        cbkelas.Text = ""
        cbthajaran.Text = ""
        cbpengajar.Text = ""
        cbkeaktivan.Text = ""
    End Sub
    Sub tampilkan()
        da = New OdbcDataAdapter("select * from inputdata", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        dgv.DataSource = (ds.Tables(0))
    End Sub
    Sub aturDGV()
        dgv.Columns(0).Width = 180
        dgv.Columns(1).Width = 120
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 100
        dgv.Columns(4).Width = 80

        dgv.RowsDefaultCellStyle.BackColor = Color.Beige
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine


        dgv.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub INPUTSISWA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilkan()
        aturDGV()
        cmd = New OdbcCommand("select * from inputdata", conn)
        SetWatermark(TextBox1, "CARI DATA")
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        txtnama.Text = dgv.Rows.Item(0).Cells(0).Value
        cbkelas.Text = dgv.Rows.Item(0).Cells(1).Value
        cbthajaran.Text = dgv.Rows.Item(0).Cells(2).Value
        cbpengajar.Text = dgv.Rows.Item(0).Cells(3).Value
        cbkeaktivan.Text = dgv.Rows.Item(0).Cells(4).Value
    End Sub
    Private Sub dgv_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        dgv.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtnama.Text = "" Or cbkelas.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
            Exit Sub
        Else
            koneksi()
            cmd = New OdbcCommand("select * from inputdata where Kelas = '" & cbkelas.Text & "'", conn)
            Dim str As String
            str = "insert into inputdata values('" & txtnama.Text & "','" & cbkelas.Text & "','" & cbthajaran.Text & "','" & cbpengajar.Text & "','" & cbkeaktivan.Text & "')"
            cmd = New OdbcCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Input Data Berhasil")
            kosongkan()
            tampilkan()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        koneksi()
        Dim hapusdata As String = "delete from inputdata where NAMA = '" & txtnama.Text & "'"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Hapus Data Berhasil")
        tampilkan()
        kosongkan()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        koneksi()
        Dim updatedata As String = "update inputdata set KELAS = '" & cbkelas.Text & "', TAHUNAJARAN = '" & cbthajaran.Text & "', PENGAJAR = '" & cbpengajar.Text & "' , Status = '" & cbkeaktivan.Text & "' where NAMA = '" & txtnama.Text & "'"
        cmd = New OdbcCommand(updatedata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil")
        tampilkan()
        kosongkan()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        koneksi()
        str = "select * from inputdata where NAMA like '" & TextBox1.Text & "%'"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        SetWatermark(TextBox1, "Cari Data")
        kosongkan()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
        HalUtama.Show()
    End Sub

    Private Sub btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        AxCrystalReport1.ReportFileName = "laporansiswa.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btnlaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporan.Click
        AxCrystalReport1.ReportFileName = "laphariandatasiswa.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class