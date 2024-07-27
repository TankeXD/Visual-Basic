Imports MySql.Data.MySqlClient
Imports System.IO
Public Class groupfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub groupfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub savegroup()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tblprogroup`(`progroup`) VALUES (@progroup)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@progroup", txt_productcode.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Group Save Successfully !", vbInformation)
            Else
                MsgBox("New Group Save Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_productcode.Clear()
        txt_productcode.Focus()
        manageProduct.progroupload()
    End Sub
    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        savegroup()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub
End Class