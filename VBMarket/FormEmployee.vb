Imports System.Data.SqlClient

Public Class FormEmployee
    Private editMode As Boolean = False
    Private editId As String

    Private Function isInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The 'Name' Field is required")
            Return False
        End If

        If FieldEmail.Text.Equals("") Then
            MsgBox("The 'Email' Field is required")
            Return False
        End If

        If FieldUsername.Text.Equals("") Then
            MsgBox("The 'Username' Field is required")
            Return False
        End If

        If FieldPassword.Text.Equals("") And Not editMode Then
            MsgBox("The 'Password' Field is required")
            Return False
        End If

        If FieldConfirmPassword.Text.Equals("") And Not editMode Then
            MsgBox("The 'Confirm Password' Field is required")
            Return False
        End If

        If Not FieldPassword.Text.Equals(FieldConfirmPassword.Text) Then
            MsgBox("The password confirmation password is not the same as the password")
            Return False
        End If

        If FieldAddress.Text.Equals("") Then
            MsgBox("The 'Address' Field is required")
            Return False
        End If

        If FieldRole.Text.Equals("") Then
            MsgBox("The 'Role' Field is required")
            Return False
        End If

        If dtpDOB.Value >= Date.Now Then
            MsgBox("Please enter a valid date")
            Return False
        End If

        Return True
    End Function

    Friend Sub Add()
        editMode = False
        editId = ""
        Name = "Add new Employee"
        btnCreate.Text = "CREATE"

        Clear()
        Show()
    End Sub

    Friend Sub Clear()
        FieldAddress.Clear()
        FieldConfirmPassword.Clear()
        FieldEmail.Clear()
        FieldName.Clear()
        FieldPassword.Clear()
        FieldRole.Clear()
        FieldUsername.Clear()
        dtpDOB.Value = Date.Now
    End Sub

    Friend Sub Edit(id As String)
        editMode = True
        editId = id
        Name = "Edit Employee"
        btnCreate.Text = "SAVE"

        FieldPassword.Enabled = False
        FieldConfirmPassword.Enabled = False

        Clear()

        Try
            AppConnection.Open()

            SqlQuery = "SELECT * FROM Employee WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.Read() Then
                FieldName.Text = DataReader.Item("Name")
                FieldUsername.Text = DataReader.Item("Username")
                FieldEmail.Text = DataReader.Item("Email")
                FieldAddress.Text = DataReader.Item("Address")
                FieldRole.Text = DataReader.Item("Role")
                dtpDOB.Value = DataReader.Item("DOB")
            End If
        Catch ex As Exception
            MsgBox("Failed to get employee data by ID: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try

        Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub CheckShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckShowPassword.CheckedChanged
        If CheckShowPassword.Checked Then
            FieldPassword.PasswordChar = ""
            FieldConfirmPassword.PasswordChar = ""
        Else
            FieldPassword.PasswordChar = "•"
            FieldConfirmPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If isInputValid() Then
            Dim name As String = FieldName.Text
            Dim email As String = FieldEmail.Text
            Dim username As String = FieldUsername.Text
            Dim password As String = FieldPassword.Text
            Dim address As String = FieldAddress.Text
            Dim role As String = FieldRole.Text
            Dim dateOfBirth As String = dtpDOB.Value.ToString("yyyy-MM-dd")

            Try
                AppConnection.Open()

                If Not editMode Then
                    Dim salt As String = SecurityHelper.GenerateSalt(70)
                    Dim hashedPassword As String = SecurityHelper.HashPassword(password, salt, 10101, 70)
                    SqlQuery = "INSERT INTO Employee (ID, Name, Email, Username, Password, Salt, Address, Role, DOB, CreatedAt, UpdatedAt) VALUES (NEWID(), '" & name & "', '" & email & "', '" & username & "', '" & hashedPassword & "', '" & salt & "', '" & address & "', '" & role & "', '" & dateOfBirth & "', GETDATE(), GETDATE())"
                    Command = New SqlCommand(SqlQuery, AppConnection.Connection)
                Else
                    SqlQuery = "UPDATE Employee SET Name='" + name + "', Email='" + email + "', Username='" + username + "', Address='" + address + "', Role='" + role + "', DOB='" + dateOfBirth + "', UpdatedAt=GETDATE() WHERE ID='" + editId + "';"
                    Command = New SqlCommand(SqlQuery, AppConnection.Connection)
                End If

                Command.ExecuteNonQuery()

                Hide()
                FormAdmin.ReloadEmployeesTable("")
            Catch ex As Exception
                MsgBox("Couldn't perform INSERT operation: " & ex.Message)
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub

    Private Sub FieldName_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldName.KeyUp, FieldUsername.KeyUp, FieldEmail.KeyUp, FieldPassword.KeyUp, FieldConfirmPassword.KeyUp, FieldRole.KeyUp, CheckShowPassword.KeyUp, dtpDOB.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class