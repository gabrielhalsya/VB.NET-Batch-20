Imports System.Security.Cryptography.X509Certificates

Namespace TestAbstract
    Public Class Programmers
        Inherits AbstractEmployee
        Implements ITunjangan

        Private _makan As Double

        Public Sub New(empId As Short, firstName As String, lastName As String, joinDate As Date, role As String, basicSalary As Double, totalSalary As Double)
            MyBase.New(empId, firstName, lastName, joinDate, role, basicSalary, totalSalary)
        End Sub

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
            End Set
        End Property

        Public Overrides Function nett() As Double
            Return BasicSalary
        End Function
        Public Overrides Function gross() As Double
            Dim makan, tunjangan, bonus, transport As Double
            MyBase.TotalSalary = BasicSalary + makan + tunjangan + bonus + transport
        End Function

        Public Sub TunjanganTransport(transportasi As Double) Implements ITunjangan.TunjanganTransport
            Me.TotalSalary = transportasi + BasicSalary
        End Sub

        Public Sub Bonus(bonus As Double) Implements ITunjangan.Bonus
            Throw New NotImplementedException()
        End Sub

        Public Sub Commision(commision As Double) Implements ITunjangan.Commision
            Throw New NotImplementedException()
        End Sub

        Public Function TunjanganMakan() As Double Implements ITunjangan.TunjanganMakan
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
