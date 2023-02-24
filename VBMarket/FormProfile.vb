Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormProfile
    Friend Sub ShowById(id As String)
        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name, Username, Email, Address, Role, DOB FROM Employee WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    LabelName.Text = DataReader.Item("Name")
                    LabelEmail.Text = DataReader.Item("Email")
                    LabelUsername.Text = DataReader.Item("Username")
                    LabelAddress.Text = DataReader.Item("Address")
                    LabelRole.Text = DataReader.Item("Role")
                    LabelDOB.Text = DataReader.GetDateTime("DOB").ToLongDateString()
                End If
            End If
        Catch ex As Exception
            MsgBox("Couldn't get Employee detail" + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try

        Show()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        FormChangePassword.ChangeById(EmployeeID)
    End Sub
End Class