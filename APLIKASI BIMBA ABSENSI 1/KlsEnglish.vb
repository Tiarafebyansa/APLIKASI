Imports System.Data.Odbc
Public Class KlsEnglish
    Dim x As String
    Sub kosongkan()
        txtnim.Text = ""
        cbkehadiran.Text = ""
        cbtingkatan.Text = ""
        cbnama.Text = ""
        txtnim.Focus()
    End Sub
    Sub tampilkan()
        da = New OdbcDataAdapter("select * from dataenglish", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DGV.DataSource = (ds.Tables(0))
    End Sub
    Sub aturDGV()
        dgv.Columns(0).Width = 50
        dgv.Columns(1).Width = 160
        dgv.Columns(2).Width = 160
        dgv.Columns(3).Width = 80
        dgv.Columns(4).Width = 75
        dgv.Columns(5).Width = 65
        dgv.Columns(6).Width = 80

        DGV.RowsDefaultCellStyle.BackColor = Color.Beige
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine

        DGV.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub KlsEnglish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilkan()
        aturDGV()
        Timer1.Enabled = True
        cmd = New OdbcCommand("select * from dataenglish", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbnama.Items.Add(rd.Item(1))
        Loop
        SetWatermark(TextBox1, "CARI DATA")
    End Sub

    Private Sub dgv_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        dgv.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub cbnama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbnama.SelectedIndexChanged
        cmd = New OdbcCommand("select * from dataenglish where NAMA = '" & cbnama.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnim.Text = rd.Item(0)
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtnim.Text = "" Or cbnama.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
            Exit Sub
        Else
            koneksi()
            cmd = New OdbcCommand("select * from dataenglish where Nama = '" & cbnama.Text & "'", conn)
            Dim str As String
            str = "insert into dataenglish values('" & txtnim.Text & "','" & cbnama.Text & "','" & cbtingkatan.Text & "','" & cbkehadiran.Text & "','" & lbltanggal.Text & "','" & lblwaktu.Text & "', '" & lblkelas.Text & "')"
            cmd = New OdbcCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Input Data Berhasil")
            kosongkan()
            tampilkan()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        koneksi()
        Dim hapusdata As String = "delete from dataenglish where NIM ='" & txtnim.Text & "'"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Hapus Data Berhasil")
        tampilkan()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        koneksi()
        Dim updatedata As String = "update dataenglish set NAMA = '" & cbnama.Text & "', TINGKATAN = '" & cbtingkatan.Text & "', KEHADIRAN = '" & cbkehadiran.Text & "', WAKTU = '" & lblwaktu.Text & "', where NIM = '" & txtnim.Text & "'"
        cmd = New OdbcCommand(updatedata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil")
        tampilkan()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        koneksi()
        str = "select * from dataenglish where NIM like '" & TextBox1.Text & "%'"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnkeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltanggal.Text = Format(Now, "dd/MM/yyyy")
        lblwaktu.Text = Format(Now, "HH:mm")
    End Sub

    Private Sub btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        LapHarianEng.Show()
    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        txtnim.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        cbnama.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        cbtingkatan.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        cbkehadiran.Text = dgv.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btnlaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporan.Click
        AxCrystalReport1.ReportFileName = "lapharianenglish.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class