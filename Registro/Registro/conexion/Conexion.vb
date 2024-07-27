
Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient


Module Conexion
    Public conn As New MySqlConnection("server = localhost; database = agenciaviajes; user = root; password = ")
    Sub abrir_conexion()
        If conn.State = 0 Then
            conn.Open()

        End If
    End Sub

    Sub cerrar_conexion()
        If conn.State = 1 Then
            conn.Close()

        End If
    End Sub
End Module
