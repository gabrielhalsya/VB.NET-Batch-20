Namespace PartTwo


    Public Interface IHR

        Function InitEmployee() As List(Of Employee)

        Function FindEmployeeById(id As Integer, listEmps As List(Of Employee)) As Employee

        Sub DisplayEmployee(listEms As List(Of Employee))

        Function TotalSalaryAll(listEmps As List(Of Employee)) As Double

        Function TotalEmployeeByRole(role As String, listEmps As List(Of Employee))

        Function TotalSalaryByRole(role As String, listEmps As List(Of Employee))



    End Interface
End Namespace
