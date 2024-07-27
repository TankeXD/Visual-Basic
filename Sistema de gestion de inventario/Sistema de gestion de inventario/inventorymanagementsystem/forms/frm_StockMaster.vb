Public Class frm_StockMaster
    Dim itemid As Integer
    Dim maxcolumn As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        For Each obj As Control In pnl_stockmaster.Controls
            If TypeOf obj Is TextBox Then
                If obj.Text = "" Then
                    MsgBox("No se puede realizar la acción. Todos los campos son obligatorios para ser completados.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
            If TypeOf obj Is ComboBox Then
                If obj.Text = "----Seleccionar-----" Or obj.Text = "" Then
                    MsgBox("No se puede realizar la acción. Todos los campos son obligatorios para ser completados.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next


        sql = "INSERT INTO  `tblstock_in_out` (`ITEMID`, `Cantidad`,`TRANSACTIONDATE`, `TOTALPRICE`, `REMARKS`)" &
           " VALUES ('" & txtitemid.Text & "','" & txtqty.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & txtprice.Text &
           "','StockIn')"
        createNoMsg(sql)


        sql = "SELECT ITEMID FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
        reloadtxt(sql)
        If dt.Rows.Count > 0 Then
            sql = "UPDATE tblitems SET Cantidad = Cantidad + '" & txtqty.Text & "' WHERE ITEMID ='" & txtitemid.Text & "'"
            createNoMsg(sql)

            MsgBox(cbobrand.Text & "Se ha guardado en la base de datos.")

        Else
            sql = "insert into tblitems  (ITEMID,`Marca`, `Descripcion`, `Categoria`, `Precio`, `Cantidad`,Unidad)" &
           "VALUES ('" & txtitemid.Text & "','" & cbobrand.Text & "','" & txtdescription.Text & "','" & cbotype.Text _
           & "','" & txtprice.Text & "','" & txtqty.Text & "','" & cbounit.Text & "' )"
            create(sql, cbobrand.Text, cbobrand.Text)
            updateautonumber(cbotype.Text)
        End If



        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        dtgcolor(dtglist, 5)

    End Sub

    'se seleccionan categoria y unidad de la tabla settings'
    Private Sub frm_stockmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)

        dtgcolor(dtglist, 5)

        fillcbo("SELECT * FROM `tblsettings` WHERE `PARA`='Categoria'", cbotype)
        fillcbo("SELECT * FROM `tblsettings` WHERE `PARA`='Unidad'", cbounit)
        fillcbo("SELECT * FROM `tblsettings` WHERE `PARA`='Marca'", cbobrand)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        btnadd.Visible = False

        select_navigation("SELECT ITEMID FROM tblitems")
        lblmax.Text = maxrows
        lblinc.Text = inc
    End Sub
    'se eliminan por id del articulo '
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            deletes(sql, "Item", "Item")

            sql = "SELECT * FROM tblitems"
            reloadDtg(sql, dtglist)

            cleartext(pnl_stockmaster)

            maxcolumn = dtglist.Columns.Count - 1
            dtglist.Columns(maxcolumn).Visible = False

        Catch ex As Exception
            MsgBox("Acción Invalida.", MsgBoxStyle.Exclamation)
        End Try


    End Sub
    ' se actualizan los datos del articulo ya guardado'
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblitems SET `Marca`='" & cbobrand.Text & "', `Descripcion`='" & txtdescription.Text & "', `Categoria`='" & cbotype.Text & "', `Precio`='" & txtprice.Text & "'" &
            ",`Unidad`='" & cbounit.Text & "' WHERE ITEMID='" & txtitemid.Text & "'"
        updates(sql, cbobrand.Text, cbobrand.Text)

        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        dtgcolor(dtglist, 5)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)

        dtgcolor(dtglist, 5)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

    End Sub
    'Mostrar la lista con los datos desde la tabla items'
    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try

            sql = "SELECT * FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            reloadtxt(sql)
            txtitemid.Text = dt.Rows(0).Item("ITEMID")
            cbobrand.Text = dt.Rows(0).Item("Marca")
            txtdescription.Text = dt.Rows(0).Item("Descripcion")
            txtprice.Text = dt.Rows(0).Item("Precio")
            cbotype.Text = dt.Rows(0).Item("Categoria")
            txtqty.Text = dt.Rows(0).Item("Cantidad")
            cbounit.Text = dt.Rows(0).Item("Unidad")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT * FROM tblitems WHERE ITEMID LIKE '%" & txtsearch.Text & "%' OR Marca LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False



    End Sub



    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        sql = "SELECT ITEMID FROM tblitems"
        select_navigation(sql)
        inc = 0
        lblinc.Text = inc + 1
        navagate_records(txtitemid)
    End Sub
    'boton para marcar la primera pagina o retrocer hasta llegar a la primera'
    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc > 0 Then
                inc = inc - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
            Else
                If inc - 1 Then
                    MsgBox("primeros registro", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = inc + 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)

            Else
                If inc = maxrows - 1 Then
                    MsgBox("No Hay Filas", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    'boton para correr la paginas en la lista'
    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtitemid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemid.TextChanged
        Try
            sql = "SELECT * FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                cbobrand.Text = dt.Rows(0).Item(1)
                txtdescription.Text = dt.Rows(0).Item(2)
                txtprice.Text = dt.Rows(0).Item(4)
                cbotype.Text = dt.Rows(0).Item(3)
                txtqty.Text = dt.Rows(0).Item("Cantidad")
                cbounit.Text = dt.Rows(0).Item("Unidad")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Private Sub cbotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotype.SelectedIndexChanged

        Try
            sql = "SELECT * FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                cbobrand.Text = dt.Rows(0).Item(1)
            Else
                loadautonumber(cbotype.Text, txtitemid)

            End If
        Catch ex As Exception

        End Try


    End Sub


End Class