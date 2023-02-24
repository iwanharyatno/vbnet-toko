Imports System.Data.SqlClient

Public Class FormSupplier
    Private editMode As Boolean = False
    Private editId As String = ""

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Or FieldEmail.Text.Equals("") Or FieldPhone.Text.Equals("") Or FieldAddress.Text.Equals("") Then
            MsgBox("Please fill all fields", vbOKOnly, "Error")
            Return False
        End If

        Return True
    End Function

    Private Sub Clear()
        FieldName.Clear()
        FieldEmail.Clear()
        FieldPhone.Clear()
        FieldAddress.Clear()
    End Sub

    Friend Sub Add()
        editMode = False
        editId = ""
        Show()
        Clear()
    End Sub

    Friend Sub Edit(id As String)
        editMode = True
        editId = id

        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name, Email, Phone, Address FROM Supplier WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    FieldName.Text = DataReader.Item("Name")
                    FieldEmail.Text = DataReader.Item("Email")
                    FieldPhone.Text = DataReader.Item("Phone")
                    FieldAddress.Text = DataReader.Item("Address")
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed to get supplier's detail", vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try

        Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Dim name As String = FieldName.Text
            Dim phone As String = FieldPhone.Text
            Dim email As String = FieldEmail.Text
            Dim address As String = FieldAddress.Text

            Try
                AppConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Supplier (ID, Name, Email, Phone, Address, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + name + "', '" + email + "', '" + phone + "', '" + address + "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Supplier SET Name='" + name + "', Email='" + email + "', Phone='" + phone + "', Address='" + address + "', UpdatedAt=GETDATE() WHERE ID='" + editId + "'"
                End If
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
                Hide()
                FormAdmin.ReloadSuppliersTable("")
            Catch ex As Exception
                MsgBox("Couldn't perform INSERT operation: " + ex.Message, vbOKOnly, "Error")
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub
End Class