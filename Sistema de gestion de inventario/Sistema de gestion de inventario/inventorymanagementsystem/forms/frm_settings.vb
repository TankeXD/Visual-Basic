Public Class frm_settings
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0
    Dim Brandid As Integer = 0

    'se modifica y inserta el ID toma segun el largo de la categoria para hacer el codigo id en este caso 0,3 para que tome desde la posicion 0
    'hasta la 3 letra'
    'boton de guardar categoria
    Private Sub btnTypesave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTypesave.Click
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtCategory.Text & "','Categoria')"
        create(sql, txtCategory.Text, txtCategory.Text)

        sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" &
           " VALUES ('" & txtCategory.Text.Substring(0, 3) & "-000" & "',1,1,'" & txtCategory.Text & "')"
        createNoMsg(sql)

        txtCategory.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Categoria' FROM tblsettings WHERE PARA='Categoria'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
    End Sub

    'boton de recargar lista de categoria
    Private Sub btntypeLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntypeLoad.Click
        sql = "SELECT ID, DESCRIPTION as 'Categoria' FROM tblsettings WHERE PARA='Categoria'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False

        txtCategory.Clear()


    End Sub
    'lista de categoria
    Private Sub dtgtypelist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgtypelist.DoubleClick
        txtCategory.Text = dtgtypelist.CurrentRow.Cells(1).Value
        typeid = dtgtypelist.CurrentRow.Cells(0).Value
    End Sub
    'boton de actulizar categoria
    Private Sub btntypeupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntypeupdate.Click
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtCategory.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtCategory.Text, txtCategory.Text)
        sql = "SELECT ID, DESCRIPTION as 'Categoria' FROM tblsettings WHERE PARA='Categoria'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
        txtCategory.Clear()
    End Sub

    'boton de eliminar categoria
    Private Sub btncdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncdel.Click
        sql = "DELETE FROM `tblautonumber` WHERE `ID`='" & dtgtypelist.CurrentRow.Cells(0).Value & "'"
        createNoMsg(sql)
        sql = "DELETE FROM `tblsettings` WHERE `ID`='" & dtgtypelist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
    End Sub



    'boton de guardar unidad
    Private Sub btnusave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusave.Click
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtunit.Text & "','Unidad')"
        create(sql, txtunit.Text, txtunit.Text)
        txtunit.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Unidad' FROM tblsettings WHERE PARA='Unidad'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
    End Sub
    'boton de actualizar unidad
    Private Sub btnuupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuupdate.Click
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtCategory.Text & "' WHERE ID ='" & unitid & "'"
        updates(sql, txtunit.Text, txtunit.Text)
        sql = "SELECT ID, DESCRIPTION as 'Unidad' FROM tblsettings WHERE PARA='Unidad'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtunit.Clear()
    End Sub
    'boton de recargar lista de unidad
    Private Sub btnuload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuload.Click
        sql = "SELECT ID, DESCRIPTION as 'Categoria' FROM tblsettings WHERE PARA='Unidad'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtunit.Clear()
    End Sub
    'lista de unidad
    Private Sub dtgulist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgulist.DoubleClick
        txtunit.Text = dtgulist.CurrentRow.Cells(1).Value
        unitid = dtgulist.CurrentRow.Cells(0).Value
    End Sub
    'recargar listas con color negro
    Private Sub frm_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtgtypelist.DefaultCellStyle.ForeColor = Color.Black
        dtgulist.DefaultCellStyle.ForeColor = Color.Black
        dtglistbrand.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    'boton de eliminar unidad
    Private Sub btnunit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunit.Click
        sql = "DELETE FROM `tblsettings` WHERE `ID`='" & dtgulist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
    End Sub


    'aqui empiezan las marcas
    Private Sub btnsavebrand_Click(sender As Object, e As EventArgs) Handles btnsavebrand.Click
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtbrand.Text & "','Marca')"
        create(sql, txtbrand.Text, txtbrand.Text)
        txtunit.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Marca' FROM tblsettings WHERE PARA='Marca'"
        reloadDtg(sql, dtglistbrand)
        dtglistbrand.Columns(0).Visible = False
    End Sub

    Private Sub btnupdatebrand_Click(sender As Object, e As EventArgs) Handles btnupdatebrand.Click
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtCategory.Text & "' WHERE ID ='" & Brandid & "'"
        updates(sql, txtbrand.Text, txtbrand.Text)
        sql = "SELECT ID, DESCRIPTION as 'Marca' FROM tblsettings WHERE PARA='Marca'"
        reloadDtg(sql, dtglistbrand)
        dtglistbrand.Columns(0).Visible = False
        txtbrand.Clear()
    End Sub

    Private Sub btndeletebrand_Click(sender As Object, e As EventArgs) Handles btndeletebrand.Click
        sql = "DELETE FROM `tblsettings` WHERE `ID`='" & dtglistbrand.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
    End Sub

    Private Sub btnloadbrand_Click(sender As Object, e As EventArgs) Handles btnloadbrand.Click
        sql = "SELECT ID, DESCRIPTION as 'Categoria' FROM tblsettings WHERE PARA='Marca'"
        reloadDtg(sql, dtglistbrand)
        dtglistbrand.Columns(0).Visible = False
        txtbrand.Clear()
    End Sub
    Private Sub dtglistbrand_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglistbrand.DoubleClick
        txtbrand.Text = dtglistbrand.CurrentRow.Cells(1).Value
        Brandid = dtglistbrand.CurrentRow.Cells(0).Value
    End Sub


End Class