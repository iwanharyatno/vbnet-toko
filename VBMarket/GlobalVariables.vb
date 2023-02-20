Imports System.Data.SqlClient

Module GlobalVariables
    Public AppConnection As New DBConnection()
    Public Command As SqlCommand
    Public DataAdapter As New SqlDataAdapter()
    Public DataReader As SqlDataReader
    Public SqlQuery As String
    Public DataSet As New DataSet
    Public DataTable As DataTable
    Public EmployeeID As String
End Module