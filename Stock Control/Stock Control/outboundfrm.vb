Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Public Class outboundfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader

    Private Sub outboundfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime_picker.Value = Now
        txt_outbound.Enabled = False
        txt_outbound.Text = getTransno()
        autocomplete()

    End Sub
    Function getTransno() As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tbloutbound where outno order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getTransno = CLng(dr.Item("outno").ToString) + 1
            Else
                getTransno = "1"
            End If

            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
    Sub autocomplete()
        Try
            conn.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New MySqlDataAdapter("Select proname from tblproduct", conn)
            da.Fill(dt)
            Dim r As DataRow
            txt_proname.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt_proname.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub addtolist()

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM tblproduct where proname = '" & txt_proname.Text & "'", conn)
            conn.Open()
            dr = cmd.ExecuteReader
            While dr.Read()
                If txt_proname.Text = "" Then

                Else
                    ' Create the new row.
                    Dim procode As String = dr("procode")
                    Dim proname As String = dr("proname")
                    Dim progroup As String = dr("progroup")
                    Dim uom As String = dr("uom")
                    Dim stock As Decimal = dr("stock")
                    ' Dim qty As Decimal = dr("qty")
                    'Dim balance As Decimal = dr("balance")

                    DataGridView1.Rows.Add(procode, proname, progroup, uom, stock, txt_qty.Text, stock - txt_qty.Text)

                    txt_proname.Clear()
                    txt_qty.Clear()
                    txt_proname.Focus()
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txt_qty_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qty.KeyDown
       

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            addtolist()
            txt_proname.Clear()
            txt_qty.Clear()
            txt_proname.Focus()

        End If
    End Sub

    Private Sub txt_proname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proname.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_qty.Focus()
        End If
    End Sub

    Sub save()
        Try
            Dim i As New Integer
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New MySqlCommand("INSERT INTO `tbloutbound`(`outno`, `outdate`, `procode`, `proname`, `progroup`, `uom`, `stock`, `qty`, `balance`) VALUES (@outno, @outdate, @procode, @proname, @progroup, @uom, @stock, @qty, @balance)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@outno", txt_outbound.Text)
                cmd.Parameters.AddWithValue("@outdate", CDate(datetime_picker.Value))
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(0).Value.ToString)
                cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(2).Value.ToString)
                cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(3).Value.ToString)
                cmd.Parameters.AddWithValue("@stock", DataGridView1.Rows(j).Cells(4).Value.ToString)
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(5).Value.ToString)
                cmd.Parameters.AddWithValue("@balance", DataGridView1.Rows(j).Cells(6).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
        
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub updatestock()
        Try
            Dim i As New Integer
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New MySqlCommand("update tblproduct set stock=stock-@stock where procode=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(0).Value.ToString)
                cmd.Parameters.AddWithValue("@stock", DataGridView1.Rows(j).Cells(5).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub clear()
        DataGridView1.Rows.Clear()
        txt_outbound.Text = getTransno()
        txt_qty.Clear()
        txt_proname.Clear()
    End Sub
    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        save()
        updatestock()
        clear()
        txt_proname.Focus()
    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        searchfrm.ShowDialog()
        searchfrm.txt_outbound.Focus()
    End Sub

    Sub delete()
        If MsgBox("Are you Sure Delete this Record", vbInformation + vbYesNo) = vbYes Then
            Try
                Dim i As New Integer
                conn.Open()

                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    Dim cmd As New MySqlCommand("DELETE FROM `tbloutbound` WHERE `outno`=@outno", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@outno", txt_outbound.Text)
                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Delete Successfully", vbInformation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        clear()
    End Sub
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        delete()
    End Sub

    Sub edit()
        DataGridView1.Enabled = True
        Try
            Dim i As New Integer
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New MySqlCommand("UPDATE `tbloutbound` SET `outdate`=@outdate,`qty`=@qty WHERE `outno`=@outno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@outno", txt_outbound.Text)
                cmd.Parameters.AddWithValue("@outdate", CDate(datetime_picker.Value))
                cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(5).Value.ToString)

                i = cmd.ExecuteNonQuery
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        edit()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        frmoutbound.ShowDialog()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class