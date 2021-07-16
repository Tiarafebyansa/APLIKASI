Imports System.Data.Odbc
Public Class Form1
    Sub kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetWatermark(TextBox1, "Username")
        SetWatermark(TextBox2, "Password")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Isi Username dan Password terlebih dahulu!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                koneksi()
                cmd = New OdbcCommand("select * from formlogin where username ='" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    If rd("status").ToString = "ADMIN" Then
                        Me.Hide()
                        MessageBox.Show("ADMIN BERHASIL MASUK")
                        HalUtama.Show()
                        kosongkan()
                    End If

                    End If
                End If
        Catch ex As Exception
        End Try
    End Sub
End Class
