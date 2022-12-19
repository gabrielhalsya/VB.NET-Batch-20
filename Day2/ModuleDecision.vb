Module ModuleDecision
    'Random number
    Sub WhoIsTheGreatest()
        Dim num As Integer
        Dim rnd As New Random()

        Console.Write("Enger value betewwn (1-10)")
        num = Console.ReadLine()

        If (num > 10) Or (num < 0) Then
            Console.Write("Out of range")
        Else
            Dim guess As Integer = rnd.NextInt64(1, 11)
            Console.WriteLine("your input :" & num & vbCrLf & "Computer : " & guess)
            If num > guess Then
                Console.WriteLine("You Win")
            ElseIf num = guess Then
                Console.WriteLine("Draw")
            Else
                Console.WriteLine("You lose")
            End If
        End If
    End Sub
End Module
