Imports MySql.Data.MySqlClient
Imports System.IO
Public Class searchfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader

    Private Sub searchfrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Dispose()
            txt_outbound.Clear()

        End If
    End Sub

    Private Sub searchfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub dgvsearch()
        outboundfrm.DataGridView1.Rows.Clear()
        conn.Open()

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM `tbloutbound` WHERE `outno` = '" & txt_outbound.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read()

                Dim outdate As Date = dr("outdate")
                Dim outboundno As Char = dr("outno")
                outboundfrm.txt_outbound.Text = outboundno
                outboundfrm.datetime_picker.Value = outdate
                outboundfrm.DataGridView1.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("stock"), dr.Item("qty"), dr.Item("balance"))

                ' Next
            End While


            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_outbound.Focus()
        txt_outbound.Clear()
    End Sub

    Private Sub txt_outbound_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_outbound.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvsearch()
            ' Dispose()
            txt_outbound.Clear()

        End If
    End Sub

    Private Sub txt_outbound_TextChanged(sender As Object, e As EventArgs) Handles txt_outbound.TextChanged

    End Sub
End Class