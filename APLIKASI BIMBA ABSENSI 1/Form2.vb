Public Class Form2
        Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            AxCrystalReport1.SelectionFormula = "totext({datacalistung.TANGGALl})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
            AxCrystalReport1.ReportFileName = "Laphariancalistung.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            AxCrystalReport2.SelectionFormula = "totext({dataenglish.TANGGALl})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
            AxCrystalReport2.ReportFileName = "Laphariancenglish.rpt"
            AxCrystalReport2.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport2.RetrieveDataFiles()
            AxCrystalReport2.Action = 2
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            AxCrystalReport3.SelectionFormula = "totext({dataguru.TANGGALl})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
            AxCrystalReport3.ReportFileName = "Lapharianguru.rpt"
            AxCrystalReport3.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport3.RetrieveDataFiles()
            AxCrystalReport3.Action = 2
        End Sub
End Class