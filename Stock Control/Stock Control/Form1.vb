Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercomboload()
    End Sub

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        If Check_showpass.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub

    Sub usercomboload()
        conn.Open()
        combo_user.Items.Clear()
        Dim cmd As New MySqlCommand("select * from tbluser", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            combo_user.Items.Add(dr.GetString(3))
        End While
        dr.Close()

        conn.Close()
    End Sub
    Sub login()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select*from tbluser where username=@username AND password=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", combo_user.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            Dim username As String = ""
            Dim password As String = ""
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                username = dr("username")
                password = dr("password")
                combo_user.Text = ""
                txt_password.Clear()
                Me.Hide()
                mainfrm.Show()
            ElseIf txt_password.Text = "" Then
                MsgBox("Pleace Fill Password", vbExclamation)
            ElseIf combo_user.Text = "" Then
                MsgBox("Pleace Select Username", vbExclamation)
            Else
                MsgBox("Worng Password !", vbCritical)
                txt_password.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub loadpic()
        Dim picture() As Byte
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select * from tbluser where username=@username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", combo_user.Text)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            'convert image to binary formate
            With mainfrm
                picture = dt.Rows(0).Item("pic")
                .lbl_user.Text = dt.Rows(0).Item("firstname") & " " & dt.Rows(0).Item("lastname")
                .lbl_role.Text = dt.Rows(0).Item("role")
                Dim mstream As New System.IO.MemoryStream(picture)
                .main_picturebox.Image = Image.FromStream(mstream)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub btm_login_Click(sender As Object, e As EventArgs) Handles btm_login.Click
        loadpic()
        login()
    End Sub

    Private Sub combo_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_user.SelectedIndexChanged

    End Sub
End Class
