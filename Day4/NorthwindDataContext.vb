Imports System.Data.Linq
Imports LinqToDB
Imports LinqToDB.Configuration
Imports LinqToDB.DataProvider

Public Class NorthwindDataContext
    Inherits DataContext

    Public Sub New()
    End Sub

    Public Sub New(configurationString As String)
        MyBase.New(configurationString)
    End Sub

    Public Sub New(options As LinqToDBConnectionOptions)
        MyBase.New(options)
    End Sub

    Public Sub New(dataProvider As IDataProvider, connectionString As String)
        MyBase.New(dataProvider, connectionString)
    End Sub

    Public Sub New(providerName As String, connectionString As String)
        MyBase.New(providerName, connectionString)
    End Sub
End Class
