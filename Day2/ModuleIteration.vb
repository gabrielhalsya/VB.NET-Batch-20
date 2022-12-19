Module ModuleIteration
    Sub DoWhile(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            i = i + 1
        Loop
    End Sub

    Sub DoWhileExit(n As Integer)
        Dim i As Integer = 1
        Do While 1 <= n
            Console.WriteLine(i)
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub

    Sub ForLoop()
        For index = 1 To 5
            Console.WriteLine("* ")
        Next
    End Sub

    Sub KotakBintang()
        'Console.WriteLine("Masukkan Kolom")
        'Dim kolom As Integer = Console.ReadLine()

        Console.WriteLine("Masukkan Baris")
        Dim baris As Integer = Console.ReadLine()

        For i = 1 To baris
            For j = i To baris
                If i Mod j = 0 Then
                    Console.Write("")
                Else
                    Console.Write("* ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub





End Module
