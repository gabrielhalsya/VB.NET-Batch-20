Namespace PartTwo
    Public Class Sales
        Inherits Employee
        Private _commision As Double
        Private _bonus As Double

        Public Sub New(empId As Short, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional commision As Double = Nothing, Optional bonus As Double = Nothing)
            MyBase.New(empId, firstName, lastName, joinDate, basicSalary)
            commision = _commision
            bonus = _bonus
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, tjCommision : {_commision}, tjBonus : {_bonus}"
        End Function

        Public Property Commision As Double
            Get
                Return _commision
            End Get
            Set(value As Double)
                _commision = value
            End Set
        End Property

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
            End Set
        End Property
    End Class
End Namespace
