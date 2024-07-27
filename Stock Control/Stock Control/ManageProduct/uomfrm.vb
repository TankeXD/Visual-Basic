Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uomfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub uomfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub uomsave()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tblprouom`( `prouom`) VALUES (@prouom)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@prouom", txt_productcode.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New UOM Save Successfully !", vbInformation)
            Else
                MsgBox("New UOM Save Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_productcode.Clear()
        txt_productcode.Focus()
        manageProduct.prouomload()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        uomsave()
    End Sub
End Class