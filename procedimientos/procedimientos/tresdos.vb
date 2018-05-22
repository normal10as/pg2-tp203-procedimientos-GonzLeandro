Module tresdos
    Dim fechaact = Date.Now
    Dim entero As Int16
    Sub main()

        Console.WriteLine(recibir(fechaact, entero))

        Console.ReadKey()
    End Sub

    Private Function recibir(fechaact As Date, entero As Int16) As Date

        Console.WriteLine(fechaact.Day)
        Console.WriteLine("Ingrese los dias a sumar: ")
        entero = Console.ReadLine()
        fechaact.AddDays(entero)
        Return fechaact
    End Function

End Module
