Module trestres
    Dim a As Int16 = 1

    Sub main()
        Console.WriteLine("Ingrese 0 para terminar.")

        Do While a <> 0
            potenciado()
        Loop

    End Sub

    Private Function potenciado() As Integer
        Console.WriteLine("Ingrese un numero a potenciar: ")
        a = Console.ReadLine()
        Console.WriteLine("{0}^2={1} {0}^3={2} {0}^4={3} {0}^5={4} {0}^6={5}", a, a ^ 2, a ^ 3, a ^ 4, a ^ 5, a ^ 6)
        Return potenciado
    End Function

End Module
