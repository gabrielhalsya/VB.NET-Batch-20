Namespace TestAbstract

    Public MustInherit Class AbstractEmployee
        Private _empId As Int16
        Private _firstName As String
        Private _lastName As String
        Private _joinDate As DateTime
        Private _role As String
        Private _basicSalary As Double
        'Private _id As Integer = New Random().NextInt64(1, 11)
        Private _totalSalary As Double

        Public MustOverride Function nett() As Double
        Public MustOverride Function gross() As Double

        Protected Sub New()

        End Sub

        Protected Sub New(empId As Short, firstName As String, lastName As String, joinDate As Date, role As String, basicSalary As Double, totalSalary As Double)
            _empId = empId
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _role = role
            _basicSalary = basicSalary
            _totalSalary = totalSalary
        End Sub

        Protected Sub New(firstName As String, lastName As String, joinDate As Date, role As String, basicSalary As Double, id As Integer, totalSalary As Double)
            _empId = New Random().NextInt64(1, 11)
            _firstName = firstName
            _lastName = lastName
            _joinDate = joinDate
            _role = role
            _basicSalary = basicSalary
            _totalSalary = basicSalary
        End Sub

        Public Property EmpId As Short
            Get
                Return _empId
            End Get
            Set(value As Short)
                _empId = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Public Property JoinDate As Date
            Get
                Return _joinDate
            End Get
            Set(value As Date)
                _joinDate = value
            End Set
        End Property

        Public Property Role As String
            Get
                Return _role
            End Get
            Set(value As String)
                _role = value
            End Set
        End Property

        Public Overridable Property BasicSalary As Double
            Get
                Return _basicSalary
            End Get
            Set(value As Double)
                _basicSalary = value
            End Set
        End Property

        Public Property TotalSalary As Double
            Get
                Return _totalSalary
            End Get
            Set(value As Double)
                _totalSalary = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $"EmpId : {Me.EmpId}
                     firstname : {_firstName},
                     lastName : {_lastName},
                     joinDate : {_joinDate},
                     role : {_role},
                     basicSalary : {_basicSalary},
                     totalSalary : {_totalSalary}"
        End Function
    End Class
End Namespace
