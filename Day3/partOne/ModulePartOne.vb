Namespace PartOne
    Module ModulePartOne
        Sub InitEmployee()
            'create object
            Dim empl As New Employee With {
                .empId = 1,
                .firstName = "Gabi",
                .lastName = "harusa",
                .joinDate = DateTime.Now,
                .basicSalary = 2_0000
            }
            Console.WriteLine(empl.ToString)
        End Sub
    End Module
End Namespace