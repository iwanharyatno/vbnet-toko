Imports System.Data.SqlClient

Public Class FormLogin
    Private Function IsInputValid()
        If FieldUsername.Text.Equals("") Then
            MsgBox("The field Username is required", vbObjectError, "Warning")
            Return False
        End If

        If FieldPassword.Text.Equals("") Then
            MsgBox("The field Password is required", vbObjectError, "Warning")
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dispose()
        Application.Exit()
    End Sub

    Private Sub FieldUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            FieldPassword.Select()
        End If
    End Sub

    Private Sub FieldPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonLogin.PerformClick()
        End If
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then
            FieldPassword.PasswordChar = ""
        Else
            FieldPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = Trim(FieldUsername.Text)
        Dim password As String = Trim(FieldPassword.Text)
        Dim userRole As String = ""

        If IsInputValid() Then
            Try
                AppConnection.Open()
                SqlQuery = "SELECT * FROM Employee WHERE Username='" & username & "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)
                DataReader = Command.ExecuteReader

                If DataReader.HasRows Then
                    While (DataReader.Read())
                        Dim salt As String = DataReader.Item("Salt")
                        Dim hashedPassword As String = SecurityHelper.HashPassword(password, salt, 10101, 70)
                        If hashedPassword = DataReader.Item("Password") Then
                            MsgBox("Login success!", vbInformation, "Info")

                            EmployeeID = DataReader.Item("ID").ToString()
                            userRole = DataReader.Item("Role").ToString()

                            Hide()
                        Else
                            MsgBox("Password doesn't match", vbOKOnly, "Error")
                        End If
                    End While
                Else
                    MsgBox("The specified employee with username '" & username & "' not found", vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox("Failed to run login operations: " & ex.Message)
            Finally
                AppConnection.Close()
            End Try
        End If

        If userRole = "admin" Then
            FormAdmin.Show()
            FormAdmin.GetAdminInfo()
        ElseIf userRole = "cashier" Then
            FormCashier.Show()
            FormCashier.GetCashierData()
        End If
    End Sub
End Class