Module ModuleDateTime

    'Menampilkan Date
    Sub ShowDate()
        Dim date1 As Date = Today
        Console.WriteLine("date : " & Today)
        Console.WriteLine(date1.ToString("f"))

        Dim lusa As Date
        lusa = date1.AddDays(2)
        Console.WriteLine("lusa " & lusa)



    End Sub
End Module
