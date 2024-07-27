Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Public Class manageProduct
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_productcode.Text = getTransno()
        loadingproduct()

        progroupload()
        prouomload()
    End Sub
    Sub clear()
        txt_productcode.Clear()
        txt_productname.Clear()
        txt_price.Clear()
        txt_location.Clear()
        combo_productGroup.ResetText()
        combo_UOM.Text = ""

    End Sub
    Sub loadingproduct()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("price"), dr.Item("location"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Function getTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyy")
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where procode like '" & sdate & "%' order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getTransno = CLng(dr.Item("procode").ToString) + 1
            Else
                getTransno = sdate & "0001"
            End If

            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
    Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tblproduct`(`procode`, `proname`, `progroup`, `uom`, `price`, `location`, `barcode`) VALUES (@procode, @proname,@progroup, @uom,@price,@location,@barcode)", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@procode", txt_productcode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_productname.Text)
            cmd.Parameters.AddWithValue("@progroup", combo_productGroup.Text)
            cmd.Parameters.AddWithValue("@uom", combo_UOM.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
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
                MsgBox("New Product Save Successfully !", vbInformation)
            Else
                MsgBox("New Product Save Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingproduct()
        clear()
    End Sub
    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        save()
    End Sub

    Private Sub txt_productcode_TextChanged(sender As Object, e As EventArgs) Handles txt_productcode.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 6, FontStyle.Regular)
        Generator.IncludeLabel = True
        Try
            pic_barcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_productcode.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_productcode.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_productname.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_productGroup.Text = DataGridView1.CurrentRow.Cells(3).Value
        combo_UOM.Text = DataGridView1.CurrentRow.Cells(4).Value
        txt_price.Text = DataGridView1.CurrentRow.Cells(5).Value
        txt_location.Text = DataGridView1.CurrentRow.Cells(6).Value

        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(7).Value
        Dim ms As New MemoryStream(bytes)
        pic_barcode.Image = Image.FromStream(ms)
    End Sub
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tblproduct` SET `procode`=@procode,`proname`=@proname,`progroup`=@progroup,`uom`=@uom,`price`=@price,`location`=@location,`barcode`=@barcode WHERE ID=@ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
            cmd.Parameters.AddWithValue("@procode", txt_productcode.Text)
            cmd.Parameters.AddWithValue("@proname", txt_productname.Text)
            cmd.Parameters.AddWithValue("@progroup", combo_productGroup.Text)
            cmd.Parameters.AddWithValue("@uom", combo_UOM.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
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
                MsgBox(" Product Edit Successfully !", vbInformation)
            Else
                MsgBox(" Product Edit Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingproduct()
        clear()
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit()
    End Sub
    Sub delete()
        If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("delete from tblproduct where ID=@ID", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)

                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product Delete Success !", vbInformation)
                Else
                    MsgBox("Product Delete Failed !", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
        loadingproduct()
        clear()
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where procode like '%" & txt_search.Text & "%' or proname like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("price"), dr.Item("location"), dr.Item("barcode"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btm_addproductgroup_Click(sender As Object, e As EventArgs) Handles btm_addproductgroup.Click
        groupfrm.ShowDialog()

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

    Sub prouomload()
        combo_UOM.Items.Clear()
        conn.Open()
        Dim cmd As New MySqlCommand("select * from tblprouom", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            combo_UOM.Items.Add(dr.GetString(1))
        End While
        dr.Close()

        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        uomfrm.ShowDialog()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub
End Class