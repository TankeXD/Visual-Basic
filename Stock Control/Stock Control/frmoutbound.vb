Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmoutbound
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader

    Private Sub frmoutbound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
    End Sub
    Sub loadReport()
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tbloutbound where outno= " & outboundfrm.txt_outbound.Text & "", conn)
            da.SelectCommand.Parameters.Clear()
            da.Fill(ds, "DataTable2")

            Dim rpt As New CrystalReport2
            rpt.Load(Application.StartupPath & "\Report\CrystalReport2.rpt")
            rpt.SetDataSource(ds.Tables("DataTable2"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class