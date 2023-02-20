Imports System.Data.SqlClient

Public Class DBConnection
    Public ReadOnly Connection As New SqlConnection(My.Settings.ConnectionDB)

    Public Function Open()
        If ConnectionState.Closed Then
            Connection.Open()
        Else
            Connection.Close()
            Connection.Open()
        End If

        Return Connection
    End Function

    Public Sub Close()
        Connection.Close()
    End Sub
End Class
