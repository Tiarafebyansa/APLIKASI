Imports System.Data.Odbc
Public Class ABSENGURU
    Dim x As String
    Sub kosongkan()
        cbpelajaran.Text = ""
        cbkehadiran.Text = ""
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub
    Sub tampilkan()
        da = New OdbcDataAdapter("select * from dataguru", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DGV.DataSource = (ds.Tables(0))
    End Sub
    Sub aturDGV()
        dgv.Columns(0).Width = 200
        dgv.Columns(1).Width = 130
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 100
        dgv.Columns(4).Width = 85

        DGV.RowsDefaultCellStyle.BackColor = Color.Beige
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine

        DGV.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub ABSENGURU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilkan()
        aturDGV()
        Timer1.Enabled = True
        cmd = New OdbcCommand("select * from dataguru", conn)
        SetWatermark(TextBox1, "CARI DATA")
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        TextBox1.Text = dgv.Rows.Item(0).Cells(0).Value
        cbpelajaran.Text = dgv.Rows.Item(0).Cells(1).Value
        cbkehadiran.Text = dgv.Rows.Item(0).Cells(2).Value
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If TextBox2.Text = "" Or cbpelajaran.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
            Exit Sub
        Else
            koneksi()
            cmd = New OdbcCommand("select * from dataguru where NAMA = '" & TextBox1.Text & "'", conn)
            Dim str As String
            str = "insert into dataguru values('" & TextBox2.Text & "','" & cbpelajaran.Text & "','" & cbkehadiran.Text & "','" & lbltanggal.Text & "','" & lblwaktu.Text & "')"
            cmd = New OdbcCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Input Data Berhasil")
            kosongkan()
            tampilkan()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        koneksi()
        Dim hapusdata As String = "delete from dataguru where NAMA ='" & TextBox1.Text & "'"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Hapus Data Berhasil")
        tampilkan()
        kosongkan()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        koneksi()
        Dim updatedata As String = "update dataguru set PELAJARAN = '" & cbpelajaran.Text & "', KEHADIRAN = '" & cbkehadiran.Text & "' where NAMA = '" & TextBox1.Text & "'"
        cmd = New OdbcCommand(updatedata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil")
        tampilkan()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        koneksi()
        str = "select * from dataguru where NAMA like '" & TextBox1.Text & "%'"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltanggal.Text = Format(Now, "dd/MM/yyyy")
        lblwaktu.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btnkeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
        HalUtama.Show()
    End Sub

    Private Sub btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        LapHarianGuru.Show()
    End Sub

    Private Sub btnlaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporan.Click
        AxCrystalReport1.ReportFileName = "lapharianguru.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class