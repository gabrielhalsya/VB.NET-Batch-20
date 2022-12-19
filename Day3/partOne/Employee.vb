Namespace PartOne
    Public Class Employee
        Public empId As Int16
        Public firstName As String
        Public lastName As String
        Public joinDate As DateTime
        Public basicSalary As Double

        Public Overrides Function ToString() As String
            Return $"
                EmpId :{empId},
                firstname :{firstName},
                lastName : {lastName},
                joinDate : {joinDate},
                basicSalary: {basicSalary}
                "
        End Function
    End Class
End Namespace
