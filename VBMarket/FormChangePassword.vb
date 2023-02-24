Imports System.Data.SqlClient

Public Class FormChangePassword
    Private userID As String

    Friend Sub ChangeById(id As String)
        userID = id

        Show()
    End Sub

    Private Function IsInputValid()
        If FieldOldPassword.Text.Equals("") Then
            MsgBox("Please enter your old password", vbOKOnly, "Error")
            Return False
        End If

        If Not IsMatchOldPassword() Then
            MsgBox("The old password doesn't match", vbOKOnly, "Error")
            Return False
        End If

        If FieldNewPassword.Text.Equals("") Then
            MsgBox("Please enter your new password", vbOKOnly, "Error")
            Return False
        End If

        If FieldConfirmNewPassword.Text.Equals("") Then
            MsgBox("Please re-type your new password", vbOKOnly, "Error")
            Return False
        End If

        If Not FieldNewPassword.Text.Equals(FieldConfirmNewPassword.Text) Then
            MsgBox("The password and password confirmation doesn't match", vbOKOnly, "Error")
            Return False
        End If

        Return True
    End Function

    Private Function IsMatchOldPassword()
        Dim result As Boolean = False

        Try
            AppConnection.Open()

            SqlQuery = "SELECT Password, Salt FROM Employee WHERE ID='" + userID + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    Dim salt As String = DataReader.Item("Salt")
                    Dim hashedPassword As String = SecurityHelper.HashPassword(FieldOldPassword.Text, salt, 10101, 70)

                    If hashedPassword.Equals(DataReader.Item("Password")) Then
                        result = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed to fetch employee information: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try

        Return result
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Try
                AppConnection.Open()

                Dim salt As String = SecurityHelper.GenerateSalt(70)
                Dim hashedPassword As String = SecurityHelper.HashPassword(FieldNewPassword.Text, salt, 10101, 70)
                SqlQuery = "UPDATE Employee SET Password='" + hashedPassword + "', Salt='" + salt + "' WHERE ID='" + userID + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()

                MsgBox("Password updated successfully!", vbOKOnly, "Error")
                Hide()
            Catch ex As Exception
                MsgBox("Couldn't execute UPDATE operation: " + ex.Message, vbOKOnly, "Error")
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPassword.CheckedChanged
        If ChkShowPassword.Checked Then
            FieldOldPassword.PasswordChar = ""
            FieldNewPassword.PasswordChar = ""
            FieldConfirmNewPassword.PasswordChar = ""
        Else
            FieldOldPassword.PasswordChar = "•"
            FieldNewPassword.PasswordChar = "•"
            FieldConfirmNewPassword.PasswordChar = "•"
        End If
    End Sub
End Class