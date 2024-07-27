Module Module1

    Sub Main()
        'variables
        Dim PrimerNumero As Integer
        Dim SegundoNumero As Integer


        'calculadora
        PrimerNumero = InputBox("Ingrese Primer Numero: ")
        SegundoNumero = InputBox("Ingrese Primer Numero: ")
        'Variable con ejecucion
        Dim Suma As Integer = PrimerNumero + SegundoNumero
        Dim Resta As Integer = PrimerNumero - SegundoNumero
        Dim Multiplicacion As Integer = PrimerNumero * SegundoNumero
        Dim Division As Integer = PrimerNumero / SegundoNumero
        MsgBox(Suma)
        MsgBox(Resta)
        MsgBox(Multiplicacion)
        MsgBox(Division)





    End Sub

End Module
