Imports MySql.Data.MySqlClient
Module selects
    Public con As MySqlConnection = mysqldb()
    'procedimiento de su autoappend y autosugest
    Public Sub autocompletetxt(ByVal sql As String, ByVal txt As TextBox)
        Try
            dt = New DataTable
            'ABRIR LA CONEXIÓN
            con.Open()

            'CONTIENE LOS DATOS A EJECUTAR
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            'LLENA LOS DATOS EN LA TABLA DE DATOS
            da.SelectCommand = cmd
            da.Fill(dt)

            'ESTABLECE UNA VARIABLE EN LA BD
            Dim r As DataRow
            'BORRA LA FUENTE AUTOCOMPLETADO DEL CUADRO DE TEXTO
            txt.AutoCompleteCustomSource.Clear()
            'HACE UN BUCLE EN LA FILA DE LA BD
            For Each r In dt.Rows
                'AGREGA LOS DATOS A LA FUENTE DE AUTOCOMPLETAR El CUADRO DE TEXTO
                txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'CIERRA CONEXIÓN
        con.Close()
        da.Dispose()
    End Sub
    Public Sub auto_sugestAll(ByVal sql As String, ByVal txt As Object)
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dt = New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        Dim r As DataRow
        txt.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            txt.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            txt.AutoCompleteCustomSource.Add(r.Item(2).ToString)
        Next
    End Sub
    Public Sub fillcbo(ByVal sql As String, ByVal cbo As ComboBox)
        Try
            dt = New DataTable
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            With cbo
                .DataSource = dt
                .DisplayMember = "DESCRIPTION"
                .DisplayMember = "DEPARTMENT"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
        da.Dispose()
    End Sub

    Public Sub loadautonumber(ByVal desc As String, ByVal txt As Object)
        Try
            sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" & desc & "'"
            reloadtxt(sql)
            txt.Text = dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub updateautonumber(ByVal desc As String)
        Try
            sql = "UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" & desc & "'"
            createNoMsg(sql)
        Catch ex As Exception

        End Try
    End Sub
    Public inc As Integer
    Public maxrows As Integer

    Public Sub select_navigation(ByVal sql As String)
        Try
            reloadtxt(sql)
            maxrows = dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub navagate_records(ByVal txt As Object)
        Try
            txt.text = dt.Rows(inc).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub colorgrid(ByVal sql As String, ByVal dtg As DataGridView)
        dt = New DataTable
        con.Open()

        With cmd
            .Connection = con
            .CommandText = sql
        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        dtg.DataSource = dt
        For Each r As DataRow In dt.Rows
            If r.Item(0) < 20 Then
                dtg.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

#Region "Report"
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\reports\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                ' .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False

                .ReportSource = reportdoc
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        End Try
        con.Close()
        da.Dispose()
    End Sub
#End Region
     
End Module
