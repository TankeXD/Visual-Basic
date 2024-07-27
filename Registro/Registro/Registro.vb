Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir_conexion()
        MsgBox("conexion exitosa", vbOKOnly + vbInformation, "Sistema de Registros")
    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        Dim cmd As New MySqlCommand
        If TextUser.Text <> "" And TextPassword.Text <> "" Then
            Try
                abrir_conexion()
                cmd = New MySqlCommand("INSERT INTO `users`(`username`, `password`, `email`, `fecha_nac`, `rol`) VALUES (@username,@password,@email,@fecha_nac,@rol)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", TextUser.Text)
                cmd.Parameters.AddWithValue("@password", TextPassword.Text)
                cmd.Parameters.AddWithValue("@email", TextEmail.Text)
                cmd.Parameters.AddWithValue("@fecha_nac", TextFecha.Text)
                cmd.Parameters.AddWithValue("@rol", TextTipo.Text)
                cmd.ExecuteNonQuery()
                limpiar()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cerrar_conexion()
            End Try
        Else
            MsgBox("los campos de Usuario y Password, son obligatorios", vbInformation + vbOKOnly, "Sistema de Registro")

        End If

    End Sub

    Private Sub limpiar()
        TextUser.Clear()
        TextPassword.Clear()
        TextEmail.Clear()
        TextFecha.Clear()
        TextTipo.Clear()

    End Sub

    Sub mostrar()
        abrir_conexion()
        Dim cmd As New MySqlDataAdapter
        Dim table As New DataTable
        cmd = New MySqlDataAdapter("SELECT `id`, `username`, `password`, `email`, `fecha_nac`, `rol` FROM `users`", conn)
        cmd.Fill(table)
        TableUsers. = table


    End Sub


End Class