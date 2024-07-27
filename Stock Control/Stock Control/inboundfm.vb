Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode

Public Class inboundfm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub inboundfm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime_picker.Value = Now
        txt_inboundno.Text = getTransno()
        txt_inboundno.Enabled = False
        autocomplete()
        customerload()
    End Sub
    Sub customerload()
        Try
            conn.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New MySqlDataAdapter("Select custname from tblcustomer", conn)
            da.Fill(dt)
            Dim r As DataRow
            txt_customer.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt_customer.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
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
    Function getTransno() As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblinbound where inbno order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getTransno = CLng(dr.Item("inbno").ToString) + 1
            Else
                getTransno = "1"
            End If

            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
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
                    Dim price As Decimal = dr("price")
                    Dim uom As String = dr("uom")

                    DataGridView1.Rows.Add(procode, proname, progroup, price, txt_qty.Text, uom)

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

    Private Sub txt_customer_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_proname.Focus()
        End If
    End Sub

    Sub dgvsave()
        Try
            Dim i As New Integer
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New MySqlCommand("INSERT INTO `tblinbound`(`inbno`, `inbdate`, `custname`, `procode`, `proname`, `progroup`, `price`, `qty`, `uom`) VALUES (@inbno, @inbdate, @custname, @procode, @proname, @progroup, @price, @qty, @uom)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@inbno", txt_inboundno.Text)
                cmd.Parameters.AddWithValue("@inbdate", CDate(datetime_picker.Value))
                cmd.Parameters.AddWithValue("@custname", txt_customer.Text)
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(0).Value.ToString)
                cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(2).Value.ToString)
                cmd.Parameters.AddWithValue("@price", CDec(DataGridView1.Rows(j).Cells(3).Value.ToString))
                cmd.Parameters.AddWithValue("@qty", CDec(DataGridView1.Rows(j).Cells(4).Value.ToString))
                cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(5).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("Save Success ")
            Else
                MsgBox("Failed")
            End If

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
                Dim cmd As New MySqlCommand("update tblproduct set stock=stock+@stock where procode=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(0).Value.ToString)
                cmd.Parameters.AddWithValue("@stock", DataGridView1.Rows(j).Cells(4).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        dgvsave()
        updatestock()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Sub delete()
        If MsgBox("Are you Sure Delete this Record", vbInformation + vbYesNo) = vbYes Then
            Try
                Dim i As New Integer
                conn.Open()

                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    Dim cmd As New MySqlCommand("DELETE FROM `tblinbound` WHERE `inbno`=@inbno", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@inbno", txt_inboundno.Text)
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

    End Sub
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        delete()
    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        inboundsearchfrm.ShowDialog()
    End Sub
    Sub edit()
        Try
            Dim i As New Integer
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim cmd As New MySqlCommand("UPDATE `tblinbound` SET `inbdate`=@inbdate,`custname`=@custname,`procode`=@procode,`proname`=@proname,`progroup`=@progroup,`price`=@price,`qty`=@qty,`uom`=@uom WHERE `inbno`=@inbno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@inbno", txt_inboundno.Text)
                cmd.Parameters.AddWithValue("@inbdate", CDate(datetime_picker.Value))
                ' cmd.Parameters.AddWithValue("@custname", txt_customer.Text)
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(0).Value.ToString)
                cmd.Parameters.AddWithValue("@proname", DataGridView1.Rows(j).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@progroup", DataGridView1.Rows(j).Cells(2).Value.ToString)
                cmd.Parameters.AddWithValue("@price", CDec(DataGridView1.Rows(j).Cells(3).Value.ToString))
                cmd.Parameters.AddWithValue("@qty", CDec(DataGridView1.Rows(j).Cells(4).Value.ToString))
                cmd.Parameters.AddWithValue("@uom", DataGridView1.Rows(j).Cells(5).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("update Success ")
            Else
                MsgBox("Failed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        edit()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        inboundReport.ShowDialog()
    End Sub
End Class