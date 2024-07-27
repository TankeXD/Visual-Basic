Imports MySql.Data.MySqlClient
Imports System.IO
Public Class inboundsearchfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub inboundsearchfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_inboundno.Focus()
    End Sub

    Private Sub txt_inboundno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_inboundno.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvsearch()

        End If

    End Sub

    Sub dgvsearch()
        inboundfm.DataGridView1.Rows.Clear()

        conn.Open()

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM `tblinbound` WHERE `inbno` = '" & txt_inboundno.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read()

                Dim inbdate As Date = dr("inbdate")
                Dim inbboundno As Char = dr("inbno")
                Dim customername As Char = dr("custname")
                inboundfm.txt_inboundno.Text = inbboundno
                inboundfm.datetime_picker.Value = inbdate

                inboundfm.txt_customer.Text = customername
                inboundfm.DataGridView1.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("price"), dr.Item("qty"), dr.Item("uom"))

                ' Next
            End While


            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_inboundno.Clear()
    End Sub


    Private Sub txt_inboundno_TextChanged(sender As Object, e As EventArgs) Handles txt_inboundno.TextChanged

    End Sub

    Private Sub lbl_exit_Click(sender As Object, e As EventArgs) Handles lbl_exit.Click
        Me.Dispose()
    End Sub
End Class