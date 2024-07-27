Module module1
    Public Class Reserva

        Public NombreCliente As String
        Public NumeroTelefono As String
        Public CantidadComensales As Integer
        Public NumeroMesa As Integer
        Public RutCliente As Integer
        Public ReservaCancelada As Boolean
        Public MotivoCancelacion As String

    End Class

    Sub Main(args As String())
        Dim reservas As New List(Of Reserva)()
        Dim opcion As Integer
        Dim mesasSolicitadas As New Dictionary(Of Integer, Integer)
        Dim reservasCanceladas = 0

        Do
            opcion = InputBox("---- Menú ----" & vbCrLf &
              "1. Agregar Reserva" & vbCrLf &
              "2. Mostrar Reservas" & vbCrLf &
              "3. Buscar reserva" & vbCrLf &
              "4. Eliminar o cancelar reservas" & vbCrLf &
              "5. Mostrar distribución de mesas" & vbCrLf &
              "6. Reportes" & vbCrLf &
              "7. Salir" & vbCrLf &
              "Ingrese la opción deseada: ")

            Select Case opcion
                Case 1
                    Dim nuevaReserva As New Reserva()
                    Do
                        nuevaReserva.RutCliente = InputBox("Ingrese el Rut del cliente:")
                        If Len(nuevaReserva.RutCliente) = 9 Then
                            MsgBox("Error no tiene 9 caracteres su rut")
                        End If
                    Loop While Len(nuevaReserva.RutCliente) = 9
                    nuevaReserva.NombreCliente = InputBox("Ingrese el nombre del cliente:")
                    nuevaReserva.NumeroTelefono = InputBox("Ingrese el número de teléfono:")
                    nuevaReserva.CantidadComensales = InputBox("Ingrese la cantidad de comensales:")


                    If nuevaReserva.CantidadComensales <= 4 Then
                        nuevaReserva.NumeroMesa = reservas.Count + 1
                    ElseIf nuevaReserva.CantidadComensales <= 8 Then
                        nuevaReserva.NumeroMesa = reservas.Count + 11
                    ElseIf nuevaReserva.CantidadComensales <= 12 Then
                        nuevaReserva.NumeroMesa = reservas.Count + 18
                    Else
                        MsgBox("No hay mesas disponibles para la cantidad de comensales especificada.")
                        Continue Do
                    End If
                    If mesasSolicitadas.ContainsKey(nuevaReserva.NumeroMesa) Then
                        mesasSolicitadas(nuevaReserva.NumeroMesa) += 1
                    Else
                        mesasSolicitadas(nuevaReserva.NumeroMesa) = 1
                    End If
                    MsgBox("Registrado con Exito")
                    reservas.Add(nuevaReserva)

                Case 2
                    Dim mensaje As String = "-------------Listado de Reservas--------------" & vbCrLf
                    For Each res In reservas
                        mensaje &= $"|Rut: {res.RutCliente}| |Nombre: {res.NombreCliente}| |Teléfono: {res.NumeroTelefono}| |Comensales: {res.CantidadComensales}| |Mesa N°: {res.NumeroMesa}|" & vbCrLf
                    Next
                    Console.WriteLine(mensaje)

                Case 3
                    Dim rutBusqueda As Integer = InputBox("Ingrese el RUT del cliente para buscar:")
                    Dim reservaEncontrada As Reserva = reservas.Find(Function(r) r.RutCliente = rutBusqueda)
                    If reservaEncontrada IsNot Nothing Then
                        Dim mensaje As String = $"Reserva encontrada:{vbCrLf}" &
                            $"Nombre: {reservaEncontrada.NombreCliente}{vbCrLf}" &
                            $"Teléfono: {reservaEncontrada.NumeroTelefono}{vbCrLf}" &
                            $"Comensales: {reservaEncontrada.CantidadComensales}{vbCrLf}" &
                            $"Mesa N°: {reservaEncontrada.NumeroMesa}"
                        MsgBox(mensaje)
                    Else
                        MsgBox("No se encontró la reserva.")
                    End If

                Case 4

                    Dim rutEliminacion As Integer = CInt(InputBox("Ingrese el RUT del cliente cuya reserva desea eliminar:"))
                    Dim reservaEliminar As Reserva = reservas.Find(Function(r) r.RutCliente = rutEliminacion)
                    If reservaEliminar IsNot Nothing Then
                        Dim motivoEliminacion As String = InputBox("Ingrese el motivo de la eliminación:")
                        reservaEliminar.ReservaCancelada = True
                        reservaEliminar.MotivoCancelacion = motivoEliminacion
                        reservasCanceladas += 1
                        MsgBox("Reserva eliminada con éxito. Motivo: " & motivoEliminacion)
                    Else
                        MsgBox("No se encontró la reserva para eliminar.")
                    End If

                Case 5
                    MostrarDistribucionMesas(reservas)

                Case 6
                    Dim opcionReporte As Integer

                    Do
                        opcionReporte = InputBox("Reportes" & vbCrLf &
                                                 "1. Reservas canceladas" & vbCrLf &
                                                 "2. Reporte de mesas más solicitadas" & vbCrLf &
                                                 "3. Reporte de clientes" & vbCrLf &
                                                 "4. Volver al menú principal" & vbCrLf &
                                                 "Seleccione el reporte que desea generar: ")

                        Select Case opcionReporte
                            Case 1
                                Console.WriteLine("-----------Informe de reservas canceladas:----------")
                                Console.WriteLine("El número de mesas canceladas fueron: " & reservasCanceladas)

                            Case 2
                                Console.WriteLine("Informe de mesas más solicitadas:")
                                MostrarMesasMasSolicitadas(mesasSolicitadas)


                            Case 3
                                Console.WriteLine("Motivos de cancelación:")

                                For Each reserva In reservas
                                    If reserva.ReservaCancelada Then
                                        Console.WriteLine($"|Rut: {reserva.RutCliente}|, |Nombre: {reserva.NombreCliente}|, |Motivo de cancelación: {reserva.MotivoCancelacion}|")
                                    End If
                                Next
                            Case 4
                                Exit Do
                            Case Else
                                Console.WriteLine("Opción no válida. Intente nuevamente.")
                        End Select

                    Loop

                Case 7
                    Exit Do

                Case Else
                    Console.WriteLine("Opción no válida. Intente nuevamente.")
            End Select

        Loop
    End Sub




    Sub MostrarDistribucionMesas(reservas As List(Of Reserva))
        Dim estadoMesas(20) As String

        For mesa As Integer = 1 To 20
            estadoMesas(mesa) = mesa.ToString("00")
        Next

        For Each reserva In reservas
            estadoMesas(reserva.NumeroMesa) = "XX"
        Next

        Console.WriteLine("--- Distribución de Mesas ---")

        Dim filas As Integer = 4
        Dim columnas As Integer = 5

        For fila As Integer = 0 To filas - 1
            For columna As Integer = 0 To columnas - 1
                Dim mesa = fila * columnas + columna + 1
                Dim estado = estadoMesas(mesa)

                If estado = "XX" Then
                    Console.ForegroundColor = ConsoleColor.Red
                Else
                    Console.ForegroundColor = ConsoleColor.Green
                End If

                Console.Write("|" & estado & "| ")

                Console.ResetColor()
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub MostrarMesasMasSolicitadas(mesasSolicitadas As Dictionary(Of Integer, Integer))
        Dim mesasOrdenadas = mesasSolicitadas.OrderByDescending(Function(kv) kv.Value)

        For Each mesa In mesasOrdenadas
            Console.WriteLine($"Mesa N°{mesa.Key}: {mesa.Value} veces solicitada")
        Next
    End Sub
End Module