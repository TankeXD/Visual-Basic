Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Public Class managestock
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub managestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstock()
        progroupload()
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
    Sub loadstock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("stock"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where procode like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("stock"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub combo_productGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_productGroup.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where progroup like '%" & combo_productGroup.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("stock"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With stockadjustmentfrm
            .txt_procode.Text = DataGridView1.CurrentRow.Cells(1).Value
            .txt_productname.Text = DataGridView1.CurrentRow.Cells(2).Value
            .txt_stockqty.Text = DataGridView1.CurrentRow.Cells(4).Value

            .ShowDialog()

            
        End With

    End Sub

    Private Sub btm_Print_Click(sender As Object, e As EventArgs) Handles btm_Print.Click

        managestockReport.ShowDialog()

    End Sub
End Class