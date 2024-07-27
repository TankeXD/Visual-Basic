Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Dashboardfrm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stockdb")
    Dim dr As MySqlDataReader


    Private Sub Dashboardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalcustomer()
        totalproduct()
        totaluser()
        LOADZEROSTOCK()
        negativestock()
        todayinbound()
        Timer1.Start()
    End Sub

    Sub totalcustomer()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`custid`) from tblcustomer ", conn)
            lbl_totalcustomer.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totalproduct()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`procode`) from tblproduct ", conn)
            lbl_totalProduct.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totaluser()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`empid`) from tbluser ", conn)
            lbl_totalusers.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub todayinbound()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`inbno`) from tblinbound ", conn)
            lbl_todayinbound.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub LOADZEROSTOCK()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where stock<0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("stock"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub negativestock()
        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tblproduct where stock=0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("procode"), dr.Item("proname"), dr.Item("stock"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub
End Class