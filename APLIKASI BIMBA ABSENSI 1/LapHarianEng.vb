Public Class LapHarianEng

    Private Sub LapHarianEng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "totext({dataenglish.TANGGAL})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        AxCrystalReport1.ReportFileName = "Lapharianenglish.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class