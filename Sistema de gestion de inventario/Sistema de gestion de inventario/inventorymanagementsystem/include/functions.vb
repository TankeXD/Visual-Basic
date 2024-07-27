Module functions
    Public Sub cleartext(ByVal obj As Object)
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = "----Seleccionar-----"
            End If
        Next
    End Sub
    Public Sub dtgcolor(ByVal dtg As DataGridView, ByVal value As Integer)
        Try

            Dim rw As DataGridViewRow
            dtg.RowHeadersVisible = False
            dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            For Each c As DataGridViewColumn In dtg.Columns
                c.SortMode = DataGridViewColumnSortMode.Programmatic
            Next


            For Each rw In dtg.Rows
                'bajo los 20 sera de color rojo 
                If rw.Cells(value).Value < 20 Then
                    rw.DefaultCellStyle.BackColor = Color.Red
                    rw.DefaultCellStyle.SelectionBackColor = Color.Red
                    rw.DefaultCellStyle.SelectionForeColor = Color.White
                    'entre los 20 y 50 sera de color naranjo
                ElseIf rw.Cells(value).Value > 20 And rw.Cells(value).Value < 50 Then
                    rw.DefaultCellStyle.BackColor = Color.Orange
                    rw.DefaultCellStyle.SelectionBackColor = Color.Orange
                    rw.DefaultCellStyle.SelectionForeColor = Color.White
                    'sobre los 50 sera de color verde
                ElseIf rw.Cells(value).Value > 50 Then
                    rw.DefaultCellStyle.BackColor = Color.Green
                    rw.DefaultCellStyle.SelectionBackColor = Color.Green
                    rw.DefaultCellStyle.SelectionForeColor = Color.White

                End If
            Next





        Catch ex As Exception

        End Try
    End Sub
    Public Sub enable_disable(result As Boolean)
        With Form1
            .ts_Customer.Enabled = result
            .ts_Transaction.Enabled = result
            .ts_StockMaster.Enabled = result
            .ts_Setting.Enabled = result
            .ts_ManageUser.Enabled = result
            .ts_Report.Enabled = result
        End With
    End Sub
End Module
