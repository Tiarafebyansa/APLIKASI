Imports System.Data.Odbc
Module Module2
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public str As String

    Sub koneksi()
        Dim str As String = "driver={Mysql ODBC 3.51 Driver};Database=bimbaptb;server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
