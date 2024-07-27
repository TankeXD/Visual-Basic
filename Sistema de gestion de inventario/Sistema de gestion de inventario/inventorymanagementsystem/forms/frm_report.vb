Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frm_report
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Private Sub dtglistreports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglistreports.CellContentClick
        Try
            If dtglistreports.SelectedRows.Count > 0 Then
                Dim stockinID As String = dtglistreports.SelectedRows(0).Cells(1).Value.ToString()

                Dim sql As String = "SELECT t.`TRANSACTIONDATE`, t.`TYPE`, t.`ClienteID`, i.`Categoria`, i.`Marca`, i.`Precio` " &
                                "FROM `tbltransaction` t " &
                                "JOIN `tblitems` i ON t.`STOCKINID` = i.`ITEMID` " &
                                "WHERE t.`STOCKINID` = @StockinID " &
                                "ORDER BY t.`TRANSACTIONDATE` ASC"

                ' Assuming you have a method named 'reloadtxt' that executes the SQL query
                Dim parameters As New Dictionary(Of String, Object)()
                parameters.Add("@StockinID", stockinID)

                ' Execute the SQL query and fill the DataTable
                Dim dt As DataTable = ExecuteQuery(sql, parameters)

                ' Check if there is data in the DataTable
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        Dim dataGridViewRow As New DataGridViewRow()
                        dataGridViewRow.CreateCells(dtglistreports)

                        ' Set the cell values based on your DataTable columns
                        dataGridViewRow.Cells(0).Value = row("TRANSACTIONDATE").ToString()
                        dataGridViewRow.Cells(1).Value = row("TYPE").ToString()
                        dataGridViewRow.Cells(2).Value = row("ClienteID").ToString()
                        dataGridViewRow.Cells(3).Value = row("Categoria").ToString()
                        dataGridViewRow.Cells(4).Value = row("Marca").ToString()
                        dataGridViewRow.Cells(5).Value = row("Precio").ToString()

                        ' Add the DataGridViewRow to the DataGridView
                        dtglistreports.Rows.Add(dataGridViewRow)
                    Next
                Else
                    MsgBox("No data found.", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ExecuteQuery(sql As String, parameters As Dictionary(Of String, Object)) As DataTable
        con.Open()
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dt = New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then

            con.Open()
            With cmd
                .Connection = con
                .CommandText = edit
                result = cmd.ExecuteNonQuery

            End With
            con.Close()
        Else
            con.Open()
            With cmd
                .Connection = con
                .CommandText = add
                result = cmd.ExecuteNonQuery

            End With
        End If
        con.Close()
    End Function

End Class