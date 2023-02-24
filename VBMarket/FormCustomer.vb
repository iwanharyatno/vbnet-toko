Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FormCustomer
    Private editMode As Boolean = False
    Private editId As String

    Private Sub Clear()
        FieldName.Clear()
        FieldAddress.Clear()
        FieldEmail.Clear()
        FieldPhone.Clear()
    End Sub

    Friend Sub Add()
        editMode = False
        editId = ""

        Clear()
        Show()
    End Sub

    Friend Sub Edit(id As String)
        editMode = True
        editId = id

        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name, Email, Phone, Address FROM Customer"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    FieldName.Text = DataReader.Item("Name")
                    FieldPhone.Text = DataReader.Item("Phone")
                    FieldEmail.Text = DataReader.Item("Email")
                    FieldAddress.Text = DataReader.Item("Address")
                End If
            End If
        Catch ex As Exception
            MsgBox("Couldn't get customer detail to edit: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try

        Show()
    End Sub

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The 'name' field is required")
            Return False
        End If

        If FieldPhone.Text.Equals("") Then
            MsgBox("The 'phone' field is required")
            Return False
        End If

        If Not Regex.IsMatch(FieldPhone.Text, "^\d+$") Then
            MsgBox("The 'phone' must be a number in format of 08xx")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Try
                AppConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Customer (ID, Name, Phone, Email, Address, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + FieldName.Text + "', '" + FieldPhone.Text + "', '" + FieldEmail.Text + "', '" + FieldAddress.Text + "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Customer SET Name='" + FieldName.Text + "', Phone='" + FieldPhone.Text + "', Email='" + FieldEmail.Text + "', Address='" + FieldAddress.Text + "', UpdatedAt=GETDATE() WHERE ID='" + editId + "'"
                End If
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()

                Hide()
                FormCashier.ReloadCustomerTable("")
            Catch ex As Exception
                MsgBox("Couldn't perform the INSERT statement: " + ex.Message)
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub
End Class