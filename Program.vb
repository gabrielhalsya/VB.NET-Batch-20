Imports System
'Imports VBConsoleApp1.PartOne
Imports VBConsoleApp1.PartTwo


Module Program
    Sub Main(args As String())
        Console.WriteLine("Day 3")
        'ModuleDecision.WhoIsTheGreatest()
        'ModuleDateTime.ShowDate()
        'ModuleIteration.DoWhile(10)
        'ModuleIteration.DoWhileExit(10)
        'ModuleIteration.ForLoop()
        'ModuleIteration.KotakBintang()
        'ModuleIteration.Quiz8()
        'ModuleIteration.Quiz9()
        'QuizVb.No1()
        'QuizVb.No2()
        'QuizVb.No3()
        'QuizVb.No4()
        'QuizVb.No5()
        'QuizVb.No6()
        'QuizVb.No7()
        'QuizVb.No8()
        'QuizVb.showPrimeNumber()
        'QuizVb.10()
        'QuizVb.No11()
        'QuizVb.No12()
        'QuizVb.No13()
        'ModulePartTwo.InitEmployee()
        'ModuleArray.DisplayArray()
        'ModuleArray.InitListGeneric()

        'Calling Interface
        Dim interfacehr As IHR = New HR  'declare variable with interface datatype as object classimplement
        Dim listemp = interfacehr.InitEmployee  'storing initiating employee into variable
        interfacehr.DisplayEmployee(listemp)
        Console.WriteLine()
        Dim id As Integer = 1

        Dim emp = interfacehr.FindEmployeeById(1, listemp)
        'console.write(emp)

        If emp IsNot Nothing Then
            Console.WriteLine($"employee found : {emp}")
        Else
            Console.WriteLine($"cannot found employee with id {id}")
        End If
    End Sub
End Module
