Imports MySql.Data.MySqlClient
Imports System.IO
Public Class stockadjustmentfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader

    Private Sub stockadjustmentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_procode.Enabled = False
        txt_productname.Enabled = False

    End Sub
    Sub edit()
        'UPDATE `tblproduct` SET `stock`="10" WHERE `procode`="20210003"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tblproduct` SET `stock`=@stock WHERE `procode`=@procode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@procode", txt_procode.Text)
            cmd.Parameters.AddWithValue("@stock", txt_stockqty.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(" Stock Adjustment Successfully !", vbInformation)
            Else
                MsgBox(" Stock Adjustment Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_stockqty.Clear()
        txt_stockqty.Focus()
        managestock.loadstock()
    End Sub
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        edit()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Me.Dispose()

    End Sub
End Class