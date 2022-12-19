Imports System.ComponentModel.Design.Serialization
Imports System.Data

Module QuizVb
    Sub No1()
        Console.Write("Masukkan Menit ")
        Dim num = Console.ReadLine()
        Dim jam = num / 60
        Dim hari As Integer = jam / 24
        Dim tahun As Integer = hari / 365
        Dim sisa As Integer = hari Mod 365

        Console.WriteLine("Tahun : " & tahun & ", Hari : " & sisa)
    End Sub

    Sub No2()
        Console.Write("Masukkan tahun lahir : ")
        Dim tahun = Console.ReadLine()
        Dim selisih = tahun Mod 12
        Dim shio As String
        Select Case selisih
            Case 0
                shio = "Monyet"
            Case 1
                shio = "Ayam"
            Case 2
                shio = "Anjing"
            Case 3
                shio = "Babi"
            Case 4
                shio = "Tikus"
            Case 5
                shio = "Kerbau"
            Case 6
                shio = "Harimau"
            Case 7
                shio = "Kelinci"
            Case 8
                shio = "Naga"
            Case 9
                shio = "Ular"
            Case 10
                shio = "Kuda"
            Case 11
                shio = "Kambing"
        End Select
        Console.WriteLine("Anda lahir di tahun " & shio)
    End Sub

    Sub No3()
        Dim attempt As Integer = 3
        Dim access As Integer = 1
        Do While attempt > 0 'And access > 0
            Console.WriteLine("Pin : ")
            Dim pin As Integer = Console.ReadLine()
            If pin = 123456 Then
                Console.WriteLine("Pin anda benar")
                Console.Write("Duit Mo ditarik? : ")
                Dim money As Integer = Console.ReadLine()
                Dim ten = money \ 10
                Dim mten = money Mod 10
                Dim five = mten \ 5
                Dim one = mten Mod 5
                Console.WriteLine("$10 = " & ten & " lembar")
                Console.WriteLine("$5 = " & five & " lembar")
                Console.WriteLine("$1 = " & one & " lembar")
                'access = 0
                Exit Sub
            Else
                attempt = attempt - 1
                Console.WriteLine("Pin anda salah, sisa percobaan : " & attempt & " kali")
            End If
        Loop
        Console.WriteLine("Transaksi dibatalkan")
    End Sub

    Sub No4()
        Console.WriteLine("Pilih")
        Console.WriteLine("(1) Gunting ")
        Console.WriteLine("(2) Batu")
        Console.WriteLine("(3) Kertas")
        Dim player As Integer = Console.ReadLine()

        'Console.WriteLine("Input salah")
        Dim rnd As New Random()
        Dim bot As Integer = rnd.NextInt64(1, 4)


        'Define Choice
        Dim tPlayerChoice As String
        Select Case player
            Case 1
                tPlayerChoice = "Gunting"
            Case 2
                tPlayerChoice = "Batu"
            Case 3
                tPlayerChoice = "Kertas"
        End Select

        Dim tBotChoice As String
        Select Case bot
            Case 1
                tBotChoice = "Gunting"
            Case 2
                tBotChoice = "Batu"
            Case 3
                tBotChoice = "Kertas"
        End Select

        'Define Winner
        Dim result As Integer = 2
        Select Case player
            Case 1
                If bot = 3 Then
                    result = 1
                End If
            Case 2
                If bot = 1 Then
                    result = 1
                End If
            Case 3
                If bot = 2 Then
                    result = 1
                End If
        End Select
        If player = bot Then
            result = 3
        End If

        'Define Result
        Dim tresult As String
        Select Case result
            Case 1
                tresult = "Anda menang"
            Case 2
                tresult = "Anda kalah"
            Case 3
                tresult = "Hasil seimbang"
        End Select

        'Display Result
        Console.WriteLine("Anda memilih(" & player & ")" & tPlayerChoice & " <> Komputer memilih (" & bot & ")" & tBotChoice & ". " & tresult)
    End Sub

    Sub No5()
        Console.WriteLine("User Input : ")
        Dim num As Integer = Console.Read()
        If num > 99 And num < 10 Then
            Console.WriteLine("")
            Exit Sub
        End If
        Dim num1, num2 As Integer
        Dim rnd As New Random()
        Dim comNum As Integer = rnd.NextInt64(10, 100)
        comNum = 44
        Console.WriteLine($"Computer Random : {comNum}")
        num1 = num \ 10
        num2 = num Mod 10
        Dim comNum1 As Integer = comNum \ 10
        Dim comNum2 As Integer = comNum Mod 10
        Dim checker As Integer
        If num1 = comNum1 Or num2 = comNum2 Then checker = checker + 1
        If num1 = comNum1 And num2 = comNum2 Then checker = checker + 1
        Select Case checker
            Case 0
                Console.WriteLine("You lose ")
            Case 1
                Console.WriteLine("Exact Match : you win IDR 50,000")
            Case 2
                Console.WriteLine("Exact Match : you win IDR 100,000")
        End Select
        'Console.WriteLine(num1 & num2)
    End Sub

    Sub No6()
        Console.WriteLine("Masukkan angka")
        Dim num As Integer = Console.ReadLine()
        For i = 1 To num - 1
            Dim j As Integer = i + i
            Console.Write(i - j & ", " & i & ",")
        Next
        Console.WriteLine(num * -1)
    End Sub

    Sub No7()
        Console.WriteLine("Masukkan angka")
        Dim num As Integer = Console.ReadLine()
        For i = 1 To num
            'Console.WriteLine(i)
            If i Mod 2 = 0 Then
                For j = 1 To num
                    Console.Write(j)
                Next
            Else
                For j = num To 1 Step -1
                    Console.Write(j)
                Next
            End If
            Console.WriteLine()
        Next
    End Sub

    Sub No8()
        Console.WriteLine("Input a number : ")
        Dim num As Integer = Console.ReadLine()


        Console.WriteLine("Hapiz way(Correct)")
        For i = 1 To num
            For j = 1 To num - i
                Console.Write(j)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("My way(Correct)")
        For i = 1 To num
            For j = num - i To 1 Step -1
                Console.Write(j)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("My way(Incorrect)")
        For i = 1 To num
            For j = i To num
                Console.Write(j)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("My way(Incorrect)")
        For i = 1 To num
            For j = num To i Step -1
                Console.Write(j)
            Next
            Console.WriteLine("")
        Next
    End Sub
    Sub showPrimeNumber()
        Console.WriteLine("input a number")
        Dim num As Integer = Console.ReadLine()
        Dim tmp As Integer = 0
        Dim k As Integer = 0

        For i = 1 To num
            k = 0
            For j = 1 To i
                If (i Mod j = 0) Then
                    k = k + 1
                    'Console.WriteLine(i)
                End If
            Next
            If k = 2 Then
                'Console.WriteLine(k)
                Console.Write(i & " ")
                tmp = tmp + 1
            End If
            If tmp = 5 Then
                Console.WriteLine()
                tmp = 0
            End If
        Next
    End Sub
    Sub No10()
        Console.WriteLine("Input A string")
        Dim sentence As String = Console.ReadLine()
        Dim count As Integer
        Dim c As Char
        Dim tmpc As Char
        For Each c In sentence
            tmpc = c
            For Each tmpc In sentence
                If c = tmpc Then
                    count = count + 1
                End If
            Next
        Next
        Console.WriteLine("Total : " & count)
        Console.WriteLine("Panjang : " & sentence.Length)
        Dim res As Boolean = (count = sentence.Length)
        Console.WriteLine(res)
    End Sub
    Sub No11()
        Console.WriteLine("Input sentence")
        Dim sentence As String = Console.ReadLine()
        Dim reverseSentence As String = ""
        For i = 0 To sentence.Length - 1
            reverseSentence = sentence(i) + reverseSentence
        Next
        Console.WriteLine(reverseSentence.ToLower = sentence.ToLower)
    End Sub
    Sub No12()
        Console.WriteLine("Input word")
        Dim sentence As String = Console.ReadLine()
        Dim resSentence = Split(sentence)
        Dim checker, arrayWord As Integer
        For i = 0 To resSentence.Count - 1
            If Len(resSentence(i)) > checker Then
                checker = Len(resSentence(i))
                arrayWord = i
            End If
        Next
        Console.WriteLine(resSentence(arrayWord))
    End Sub
    Sub No13()
        Console.Write("Masukkan tahun pertama: ")
        Dim tahun1 As Integer = Console.Read()
        Console.Write("Masukkan tahun kedua ")
        Dim tahun2 As Integer = Console.ReadLine()
        'Console.WriteLine(tahun1 & "," & tahun2)
        If tahun1 > tahun2 Then
            Console.WriteLine("Parameter salahv")
            Exit Sub
        End If
        Dim tot As Int16
        Dim kabisat As String = ""
        For i = tahun1 To tahun2
            If (i Mod 4 = 0) Then 'only add and count filtered
                tot = tot + 1
                kabisat = kabisat + i.ToString + " "
            End If
        Next
        Console.WriteLine($"Total tahun kabisat : {tot} tahun = {kabisat}")
    End Sub
End Module
