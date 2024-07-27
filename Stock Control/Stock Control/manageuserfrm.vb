Imports MySql.Data.MySqlClient
Imports System.IO
Public Class manageuserfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Private Sub manageuserfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdataloading()
    End Sub
    Sub clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_password.Clear()
        txt_username.Clear()
        combo_role.Text = ""
        pic_box.Image = Nothing
    End Sub
    Sub userdataloading()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select * from tbluser", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("empid").ToString, dr.Item("firstname").ToString, dr.Item("lastname").ToString, dr.Item("username").ToString, dr.Item("password").ToString, dr.Item("role").ToString, dr.Item("pic"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbluser`(`firstname`, `lastname`, `username`, `password`, `role`, `pic`) VALUES (@firstname,@lastname,@username,@password,@role,@pic)", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", combo_role.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_box.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@pic", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Register Success !", vbInformation)
            Else
                MsgBox("New User Register Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        userdataloading()
        clear()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        save()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.Filter = "Choose Images(*.JPG,*.PNG,*.JPEG,*.GIF)|*.JPG;*.PNG;*.JPEG*.GIF|ALL FILES(*.*)|*.*"

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pic_box.Image = Image.FromFile(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = OpenFileDialog1.FileName


        End If
    End Sub

    Private Sub Check_showpass_Click(sender As Object, e As EventArgs) Handles Check_showpass.Click
        If Check_showpass.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

   
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Btn_Save.Enabled = False
    
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_firstname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_lastname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_username.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_password.Text = DataGridView1.CurrentRow.Cells(4).Value
        combo_role.Text = DataGridView1.CurrentRow.Cells(5).Value

        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(6).Value
        Dim ms As New MemoryStream(bytes)
        pic_box.Image = Image.FromStream(ms)



        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colDelete" Then
            conn.Open()

            If MsgBox("Are you Sure Delete This Record !", vbQuestion + vbYesNo) = vbYes Then
                Try
                    Dim cmd As New MySqlCommand("delete from tbluser where empid=@empid", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@empid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("User Delete Success !", vbInformation)
                    Else
                        MsgBox("Failed !", vbCritical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            conn.Close()
            userdataloading()
            clear()
        End If

       
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        conn.Open()
        Try
            Dim cmd As New MySqlCommand("UPDATE `tbluser` SET `firstname`=@firstname,`lastname`=@lastname,`username`=@username,`password`=@password,`role`=@role,`pic`=@pic WHERE `empid`=@empid", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@empid", DataGridView1.CurrentRow.Cells("Column1").Value.ToString)
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", combo_role.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_box.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@pic", picture)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Edit Successfully !", vbInformation)
            Else
                MsgBox("Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        userdataloading()
        clear()

    End Sub
End Class