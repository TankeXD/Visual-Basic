Module Module1

    Sub Main()
        'vamos a realizar un conversor de monedas el usuario va a poder ingresar cierta cantidad de clp 
        'tendra que seleccionar en un menu para convertir a peso chileno son 5
        '<----------------------------------------------------------->
        'Declaración de variables
        Dim opcion As Integer
        Dim dolar As Double = 0.0012
        Dim yen As Double = 0.17
        Dim guarani As Double = 8.47
        Dim mxn As Double = 0.02
        Dim cop As Double = 4.79
        'declaración de variables que toman clp
        Dim clpdolar As Integer
        Dim clpyen As Integer
        Dim clpguarani As Integer
        Dim clpmxn As Integer
        Dim clpcop As Integer


        Console.WriteLine("1.- CLP a Dolar Estado Unidense")
        Console.WriteLine("2.- CLP a Yen Japones")
        Console.WriteLine("3.- CLP a Guarani Paraguayo")
        Console.WriteLine("4.- CLP a MXN Mexicano")
        Console.WriteLine("5.- CLP a COP Colombiano")
        Console.WriteLine("6.- Salir")

        opcion = InputBox("Ingrese Opción")

        Select Case opcion
            Case 1
                clpdolar = InputBox("Ingrese monto a convertir a Dolar")
                Dim resultado = dolar * clpdolar
                MsgBox("Su monto en Dolar es: " & resultado)

            Case 2
                clpyen = InputBox("Ingrese monto a convertir a Yen")
                Dim resultado = yen * clpyen
                MsgBox("Su monto en Yen es: " & resultado)

            Case 3
                clpguarani = InputBox("Ingrese monto a convertir a Guarani")
                Dim resultado = guarani * clpguarani
                MsgBox("Su monto en Guarani es: " & resultado)

            Case 4
                clpmxn = InputBox("Ingrese monto a convertir a Peso Mexicano")
                Dim resultado = mxn * clpmxn
                MsgBox("Su monto en Peso Mexicano es: " & resultado)

            Case 5
                clpcop = InputBox("Ingrese monto a convertir a Peso Colombiano")
                Dim resultado = guarani * clpcop
                MsgBox("Su monto en Peso Colombiano es: " & resultado)
            Case 6
                MsgBox("Adios Vuelva Pronto")

        End Select

    End Sub

End Module
