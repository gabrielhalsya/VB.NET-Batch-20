Imports System.Globalization

Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()
            'create object w/ encapsulation
            'Dim emp1 As New Employee(1, "Gabriel", "Halsya", DateTime.Now, 5_000)
            'Console.WriteLine(emp1.ToString)

            'emp1.BasicSalary = 6_0000
            'emp1.LastName = emp1.LastName + " Surya Darma"
            'Console.WriteLine(emp1.ToString)

            'Dim emp2 As New Employee("Gabriel", "Halsya", DateTime.Now, 5_000)
            'Console.WriteLine(emp2.ToString)

            'creating object programmer
            Dim pmr As New Programmer("Hafiz", "Murfid", DateTime.Now, 5_000, 500)
            pmr.BasicSalary = 5_000

            Console.WriteLine(pmr.BasicSalary)
            Console.WriteLine(pmr.ToString)

        End Sub
    End Module
End Namespace