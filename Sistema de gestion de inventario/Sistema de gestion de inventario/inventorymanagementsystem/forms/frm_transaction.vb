Public Class frm_transaction
    Dim returnid As Integer
    Dim stockinID As Integer = 0
    Dim stockoutID As Integer = 0
    Dim stockreturnID As Integer = 0



    Private Sub frm_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `ITEMID` as 'Item Id', `Marca` as 'Marca', `Descripcion` as 'Descripcion', `Precio` as 'Precio', `Cantidad` as 'Cantidad Disponible ' FROM `tblitems`"
        reloadDtg(sql, dtgCus_itemlist)

        sql = "SELECT ITEMID FROM tblitems"


        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")

        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        stockoutID = dt.Rows(0).Item(0)

        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
        stockreturnID = dt.Rows(0).Item(0)



    End Sub


    Private Sub txt_cusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cusid.TextChanged
        Try
            sql = "SELECT * FROM `tblperson` WHERE `ClienteID`='" & txt_cusid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtCus_fname.Text = dt.Rows(0).Item("Nombre")
                txtCus_lname.Text = dt.Rows(0).Item("Apellido")
            Else
                txtCus_fname.Clear()
                txtCus_lname.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `ITEMID` as 'ID Producto', `Marca` as 'Marca', `Descripcion` as 'Descripcion', `Precio` as 'Precio', `Cantidad` as 'Cantidad Disponible' FROM `tblitems` WHERE  `Marca` like '%" & txtsearch.Text & "%' or `ITEMID` = '" & txtsearch.Text & "'"
        reloadDtg(sql, dtgCus_itemlist)
    End Sub




    Private Sub btnCus_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_add.Click
        Try
            If dtCus_addedlist.RowCount = 0 Then
                With dtgCus_itemlist.CurrentRow
                    dtCus_addedlist.ColumnCount = 6
                    dtCus_addedlist.Columns(0).Name = "Item Id"
                    dtCus_addedlist.Columns(1).Name = "Marca"
                    dtCus_addedlist.Columns(2).Name = "Descripcion"
                    dtCus_addedlist.Columns(3).Name = "Precio"
                    dtCus_addedlist.Columns(4).Name = "Cantidad"
                    dtCus_addedlist.Columns(5).Name = "Precio Total"

                    Dim tot As Double = Double.Parse(.Cells(3).Value) * 1

                    Dim row As String() = New String() { .Cells(0).Value,
                                                    .Cells(1).Value,
                                                   .Cells(2).Value,
                                                   .Cells(3).Value,
                                                   1,
                                                   tot}
                    dtCus_addedlist.Rows.Add(row)

                End With
            Else
                For Each r As DataGridViewRow In dtCus_addedlist.Rows
                    If dtgCus_itemlist.CurrentRow.Cells(0).Value = r.Cells(0).Value Then
                        MsgBox("El artículo ya está en el carrito.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Next
                If dtCus_addedlist.CurrentRow.Cells(0).Value <> dtgCus_itemlist.CurrentRow.Cells(0).Value Then
                    With dtgCus_itemlist.CurrentRow
                        dtCus_addedlist.ColumnCount = 6
                        dtCus_addedlist.Columns(0).Name = "Item Id"
                        dtCus_addedlist.Columns(1).Name = "Marca"
                        dtCus_addedlist.Columns(2).Name = "Descripcion"
                        dtCus_addedlist.Columns(3).Name = "Precio"
                        dtCus_addedlist.Columns(4).Name = "Cantidad"
                        dtCus_addedlist.Columns(5).Name = "Precio Total"
                        Dim tot As Double = Double.Parse(.Cells(3).Value) * 1
                        Dim row As String() = New String() { .Cells(0).Value,
                                                        .Cells(1).Value,
                                                        .Cells(2).Value,
                                                       .Cells(3).Value,
                                                      1,
                                                       tot}
                        dtCus_addedlist.Rows.Add(row)

                    End With


                Else
                    MsgBox("El artículo ya está en el carrito.", MsgBoxStyle.Exclamation)
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCus_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_Remove.Click
        Try
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCus_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_clear.Click
        dtCus_addedlist.Rows.Clear()
    End Sub

    Private Sub btnCus_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_save.Click

        If txt_cusid.Text = "" Then
            MsgBox("¡Quedan campos vacíos que hay que rellenar!", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtCus_addedlist.RowCount = 0 Then
            MsgBox("¡El carrito esta vacío!", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT ITEMID,`Cantidad` FROM `tblitems`"
        reloadtxt(sql)
        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dtCus_addedlist.Rows.Count - 1
                If dtCus_addedlist.Rows(i).Cells(0).Value = row.Item(0) Then

                    If dtCus_addedlist.Rows(i).Cells(4).Value > row.Item(1) Then
                        MsgBox("La cantidad del artículo ( " & dtCus_addedlist.Rows(i).Cells(1).Value & " ) es mayor que la cantidad disponible del mismo.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If

            Next
        Next

        For Each r As DataGridViewRow In dtCus_addedlist.Rows
            sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `Cantidad`, `TOTALPRICE`, `ClienteID`,REMARKS)" &
            " VALUES ('" & stockoutID & "','" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & txt_cusid.Text & "','StockOut')"
            createNoMsg(sql)

            sql = "UPDATE `tblitems`  SET `Cantidad`= Cantidad - '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)
        Next

        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `ClienteID`)" &
       " VALUES ('" & stockoutID & "','" & Format(Now, "yyyy-MM-dd") & "','Vendido','" & txt_cusid.Text & "')"
        createNoMsg(sql)

        createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5")

        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        stockoutID = dt.Rows(0).Item(0)

        MsgBox("Productos Guardados En La Base De Datos.")

        cleartext(Panel1)
        dtCus_addedlist.Rows.Clear()

        sql = "SELECT `ITEMID` as 'ID Producto', `Marca` as 'Marca', `Descripcion` as 'Description', `Precio` as 'Precio', `Cantidad` as 'Cantidad Disponible' FROM `tblitems`"
        reloadDtg(sql, dtgCus_itemlist)
    End Sub

    Private Sub txttransactionid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttransactionid.TextChanged
        Try

            If txttransactionid.Text <> "" Then

                sql = "SELECT p.ClienteID, `Nombre`, `Apellido` ,`Direccion` FROM  `tbltransaction` t, `tblperson`  p  WHERE t.`ClienteID`=p.`ClienteID` AND `TRANSACTIONNUMBER`='" & txttransactionid.Text & "'"
                reloadtxt(sql)
                returnid = dt.Rows(0).Item("ClienteID")
                txtreturn_name.Text = dt.Rows(0).Item("Nombre") & " " & dt.Rows(0).Item("Apellido")
                txtreturn_address.Text = dt.Rows(0).Item("Direccion")

                sql = "SELECT   i.`ITEMID`, `Marca`, `Descripcion`, `Precio`,`TRANSACTIONDATE`, o.`Cantidad`, `TOTALPRICE`,`STOCKOUTID` FROM  `tblitems` i , `tblstock_in_out` o WHERE i.`ITEMID`=o.`ITEMID` AND `TRANSACTIONNUMBER`='" & txttransactionid.Text & "'"
                reloadDtg(sql, dtgreturn_itemlist)
                dtgreturn_itemlist.Columns(7).Visible = False
            Else
                txtreturn_name.Clear()
                txtreturn_address.Clear()
                dtgreturn_itemlist.Columns.Clear()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturnadd.Click
        Try


            If dtgreturn_cart.RowCount = 0 Then
                With dtgreturn_itemlist.CurrentRow
                    dtgreturn_cart.ColumnCount = 7
                    dtgreturn_cart.Columns(0).Name = "Item Id"
                    dtgreturn_cart.Columns(1).Name = "Marca"
                    dtgreturn_cart.Columns(2).Name = "Descripcion"
                    dtgreturn_cart.Columns(3).Name = "Precio"
                    dtgreturn_cart.Columns(4).Name = "Cantidad"
                    dtgreturn_cart.Columns(5).Name = "Precio Total"
                    Dim row As String() = New String() { .Cells(0).Value,
                                                   .Cells(1).Value,
                                                       .Cells(2).Value,
                                                       .Cells(3).Value,
                                                       .Cells(5).Value,
                                                       .Cells(6).Value,
                                                        .Cells(7).Value}
                    dtgreturn_cart.Rows.Add(row)

                End With

            Else
                If dtgreturn_cart.CurrentRow.Cells(0).Value <> dtgreturn_itemlist.CurrentRow.Cells(0).Value Then
                    With dtgreturn_itemlist.CurrentRow
                        dtgreturn_cart.ColumnCount = 7
                        dtgreturn_cart.Columns(0).Name = "Item Id"
                        dtgreturn_cart.Columns(1).Name = "Marca"
                        dtgreturn_cart.Columns(2).Name = "Descripcion"
                        dtgreturn_cart.Columns(3).Name = "Precio"
                        dtgreturn_cart.Columns(4).Name = "Cantidad"
                        dtgreturn_cart.Columns(5).Name = "Precio Total"
                        Dim row As String() = New String() { .Cells(0).Value,
                                                        .Cells(1).Value,
                                                       .Cells(2).Value,
                                                       .Cells(3).Value,
                                                       .Cells(5).Value,
                                                       .Cells(6).Value,
                                                       .Cells(7).Value}
                        dtgreturn_cart.Rows.Add(row)

                    End With


                Else
                    MsgBox("El artículo ya está en el carrito.", MsgBoxStyle.Exclamation)
                End If
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_remove.Click
        Try
            dtgreturn_cart.Rows.Remove(dtgreturn_cart.CurrentRow)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnreturn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_clear.Click
        dtgreturn_cart.Columns.Clear()
    End Sub

    Private Sub btnreturn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_save.Click
        If txttransactionid.Text = "" Then
            MsgBox("¡Quedan campos vacíos que hay que rellenar!", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtgreturn_cart.RowCount = 0 Then
            MsgBox("carrito vacio!", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT `ITEMID`, `Cantidad` FROM `tblstock_in_out` WHERE  `TRANSACTIONNUMBER` ='" & txttransactionid.Text & "'"
        reloadtxt(sql)
        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dtgreturn_cart.Rows.Count - 1
                If dtgreturn_cart.Rows(i).Cells(0).Value = row.Item(0) Then

                    If dtgreturn_cart.Rows(i).Cells(4).Value > row.Item(1) Then
                        MsgBox("La cantidad del artículo ( " & dtgreturn_cart.Rows(i).Cells(1).Value & " ) es mayor que la cantidad disponible del mismo.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If

            Next
        Next



        For Each r As DataGridViewRow In dtgreturn_cart.Rows
            sql = "INSERT INTO `tblstock_return` (  `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `Cantidad`, `TOTALPRICE`, `OWNER_CUS_ID`)" &
            " VALUES ('" & stockreturnID & "','" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & returnid & "')"
            createNoMsg(sql)

            sql = "UPDATE `tblitems`  SET `Cantidad`=`Cantidad` + '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)

            sql = "UPDATE `tblstock_in_out` SET  `Cantidad`=`Cantidad`-'" & r.Cells(4).Value & "', `TOTALPRICE`=`TOTALPRICE`-'" & r.Cells(5).Value & "'  WHERE `STOCKOUTID` ='" & r.Cells(6).Value & "'"
            createNoMsg(sql)

        Next

        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `ClienteID`)" &
                " VALUES ('" & txttransactionid.Text & "','" & Format(Now, "yyyy-MM-dd") & "','Devuelto','" & returnid & "')"
        createNoMsg(sql)

        createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 6")

        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
        stockreturnID = dt.Rows(0).Item(0)

        MsgBox("Los Productos han sido devueltos.")

        cleartext(Panel6)
        dtgreturn_cart.Columns.Clear()
    End Sub


    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        Try

            sql = "SELECT `ITEMID` as 'ID Producto', `Marca` as 'Marca', `Descripcion` as 'Descripcion', `Precio` as 'Precio', `Cantidad` as 'Cantidad Disponible' FROM `tblitems`"
            reloadDtg(sql, dtgCus_itemlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dtCus_addedlist_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtCus_addedlist.CellBeginEdit
        Try
            Dim total As Double
            For Each row As DataGridViewRow In dtCus_addedlist.Rows
                total = row.Cells(4).Value * row.Cells(3).Value
                row.Cells(5).Value = total
            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dtCus_addedlist_CellMouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellMouseLeave
        Try
            If dtCus_addedlist.Rows.Count > 0 Then
                If dtCus_addedlist.CurrentCell.ColumnIndex = 4 Then
                    Dim total As Double
                    For Each row As DataGridViewRow In dtCus_addedlist.Rows
                        total = row.Cells(4).Value * row.Cells(3).Value
                        row.Cells(5).Value = total
                    Next
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCus_addedlist_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellValueChanged
        Try
            If dtCus_addedlist.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtCus_addedlist.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgreturn_cart_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgreturn_cart.CellValueChanged
        Try
            If dtgreturn_cart.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtgreturn_cart.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class