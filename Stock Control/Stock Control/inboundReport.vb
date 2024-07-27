Imports MySql.Data.MySqlClient
Imports System.IO
Public Class inboundReport
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub inboundReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
    End Sub
    Sub loadReport()
       
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tblinbound where inbno= " & inboundfm.txt_inboundno.Text & "", conn)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable3")

            Dim rpt As New CrystalReport3
            rpt.Load(Application.StartupPath & "\Report\CrystalReport3.rpt")
            rpt.SetDataSource(ds.Tables("DataTable3"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class