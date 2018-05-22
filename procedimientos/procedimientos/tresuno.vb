Module tresuno

    Private fecha As Date = Now

    Sub Main()
        fechaactual()
        horaactual()
        Console.ReadKey()
    End Sub



    Private Sub fechaactual()
        Console.WriteLine("Fecha Actual: " & fecha.Day & "/" & fecha.Month & "/" & fecha.Year)
    End Sub



    Private Function horaactual() As Date
        Console.WriteLine("Hora Actual: " & fecha.Hour & ":" & fecha.Minute)
        Return horaactual
    End Function
End Module
