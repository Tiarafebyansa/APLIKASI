Public Class HalUtama

    Private Sub KELASCALISTUNGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELASCALISTUNGToolStripMenuItem.Click
        KlsCalistung.Show()
    End Sub

    Private Sub KELASENGLISHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELASENGLISHToolStripMenuItem.Click
        KlsEnglish.Show()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Dim konfirmasi As String
        konfirmasi = MsgBox("Anda Yakin ingin keluar?", vbQuestion + vbYesNo, "konfirmasi")
        If konfirmasi = vbYes Then
            Application.Exit()
        End If
        Form1.Show()
    End Sub

    Private Sub ABSENSIGURUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABSENSIGURUToolStripMenuItem.Click
        ABSENGURU.Show()
    End Sub

    Private Sub INPUTDATASISWAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTDATASISWAToolStripMenuItem.Click
        INPUTSISWA.Show()
    End Sub
End Class