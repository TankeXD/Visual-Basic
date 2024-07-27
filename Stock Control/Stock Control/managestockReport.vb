Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Public Class managestockReport
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub managestockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
        progroupload()
    End Sub

    Sub loadReport()
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tblproduct", conn)

            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\Report\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub progroupload()
        combo_productGroup.Items.Clear()
        conn.Open()
        Dim cmd As New MySqlCommand("select * from tblprogroup", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            combo_productGroup.Items.Add(dr.GetString(1))
        End While
        dr.Close()

        conn.Close()
    End Sub

    Private Sub combo_productGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_productGroup.SelectedIndexChanged
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tblproduct where progroup like '%" & combo_productGroup.Text & "%'", conn)

            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\Report\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Radio_ZeroStock_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_ZeroStock.CheckedChanged
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tblproduct where stock=0 ", conn)

            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\Report\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Radio_NagativeStock_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_NagativeStock.CheckedChanged
        Try
            conn.Open()
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("select * from tblproduct where stock<0", conn)

            da.Fill(ds, "DataTable1")

            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\Report\CrystalReport1.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class