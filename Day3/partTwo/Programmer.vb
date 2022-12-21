Namespace PartTwo
    Public Class Programmer
        Inherits Employee

        Private _transportasi As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, role As String, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, role, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.BasicSalary + transportasi
        End Sub


        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + BasicSalary
            End Set
        End Property
        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
tjTransport: {_transportasi}"
        End Function

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Transportasi
            End Set
        End Property
    End Class
End Namespace
