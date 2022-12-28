Namespace PartTwo

    Public Class HR
        Implements IHR

        Public Sub DisplayEmployee(listEms As List(Of Employee)) Implements IHR.DisplayEmployee
            For Each listEmp In listEms
                Console.WriteLine(listEmp)
            Next

        End Sub

        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee
            Dim listEmps As New List(Of Employee) From {
            New Employee(1, "Gabriel", "Halsya", DateTime.Now, 5_000),
            New Employee(1, "Gabriel", "Halsya", Date.Now, 5_000),
            New Programmer("GabrielH", "Halsya", DateTime.Now, 5_600, 2_00)
            }
            Return listEmps
        End Function

        Public Function FindEmployeeById(id As Integer, listEmps As List(Of Employee)) As Employee Implements IHR.FindEmployeeById
            Dim empById As Employee = Nothing 'If tryin to

            For Each listEmp In listEmps
                If listEmp.EmpId = (id) Then
                    empById = listEmp
                End If
             Next
            Return empById
        End Function

        Public Function TotalSalaryAll(listEmps As List(Of Employee)) As Double Implements IHR.TotalSalaryAll
            Dim total As Double
            For Each list In listEmps
                total = total + list.TotalSalary
            Next
            Return total
        End Function

        Public Function TotalSalaryByRole(role As String, listEmps As List(Of Employee)) As Object Implements IHR.TotalSalaryByRole
            Dim totSal As Double
            For Each list In listEmps
                If TypeName(listEmps) Is role Then
                    totSal = totSal + list.TotalSalary
                End If
            Next
        End Function

        Public Function TotalEmployeeByRole(role As String, listEmps As List(Of Employee)) As Object Implements IHR.TotalEmployeeByRole
            Dim totEmp As Int16
            For Each list In listEmps
                If TypeName(listEmps) Is role Then
                    totEmp = totEmp + 1
                End If
            Next
            Return totEmp
        End Function
    End Class
End Namespace
