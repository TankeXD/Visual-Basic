Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode

Public Class managecustomer
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub managecustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingcustomer()
    End Sub
    Sub clear()
        txt_custID.Clear()
        txt_custname.Clear()
        txt_address.Clear()
        txt_pincode.Clear()
        txt_phone.Clear()
        txt_gstno.Clear()
        txt_panno.Clear()
        pic_barcode.Image = Nothing
    End Sub
    Sub loadingcustomer()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblcustomer", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("custid"), dr.Item("custname"), dr.Item("address"), dr.Item("pincode"), dr.Item("phone"), dr.Item("gst"), dr.Item("pan"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tblcustomer`(`custid`, `custname`, `address`, `pincode`, `phone`, `gst`, `pan`, `barcode`) VALUES (@custid,@custname,@address,@pincode, @phone,@gst,@pan,@barcode)", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@custid", txt_custID.Text)
            cmd.Parameters.AddWithValue("@custname", txt_custname.Text)
            cmd.Parameters.AddWithValue("@address", txt_address.Text)
            cmd.Parameters.AddWithValue("@pincode", txt_pincode.Text)
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text)
            cmd.Parameters.AddWithValue("@gst", txt_gstno.Text)
            cmd.Parameters.AddWithValue("@pan", txt_panno.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@barcode", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Customer Save Successfully !", vbInformation)
            Else
                MsgBox("New Customer Save Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcustomer()
        clear()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        save()
    End Sub

    Private Sub txt_custID_TextChanged(sender As Object, e As EventArgs) Handles txt_custID.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 6, FontStyle.Regular)
        Generator.IncludeLabel = True
        Try
            pic_barcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_custID.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try

    End Sub

    
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_custID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_custname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_address.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_pincode.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_phone.Text = DataGridView1.CurrentRow.Cells(5).Value
        txt_gstno.Text = DataGridView1.CurrentRow.Cells(6).Value
        txt_panno.Text = DataGridView1.CurrentRow.Cells(7).Value

        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(8).Value
        Dim ms As New MemoryStream(bytes)
        pic_barcode.Image = Image.FromStream(ms)
    End Sub

    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tblcustomer` SET`custid`=@custid,`custname`=@custname,`address`=@address,`pincode`=@pincode,`phone`=@phone,`gst`=@gst,`pan`=@pan,`barcode`=@barcode WHERE ID=@ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
            cmd.Parameters.AddWithValue("@custid", txt_custID.Text)
            cmd.Parameters.AddWithValue("@custname", txt_custname.Text)
            cmd.Parameters.AddWithValue("@address", txt_address.Text)
            cmd.Parameters.AddWithValue("@pincode", txt_pincode.Text)
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text)
            cmd.Parameters.AddWithValue("@gst", txt_gstno.Text)
            cmd.Parameters.AddWithValue("@pan", txt_panno.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@barcode", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Edit Successfully !", vbInformation)
            Else
                MsgBox("Edit Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingcustomer()
        clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit()
    End Sub
    Sub delete()
        If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("delete from tblcustomer where ID=@ID", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Customer Delete Success !", vbInformation)
                Else
                    MsgBox("Customer Delete Failed !", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
        loadingcustomer()
        clear()

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

  
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblcustomer where custid like '%" & txt_search.Text & "%' or custname like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("custid"), dr.Item("custname"), dr.Item("address"), dr.Item("pincode"), dr.Item("phone"), dr.Item("gst"), dr.Item("pan"), dr.Item("barcode"))
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
End Class