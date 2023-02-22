Imports System.Data.SqlClient

Public Class FormAdmin
    Friend Sub GetAdminInfo()
        Try
            AppConnection.Open()
            SqlQuery = "SELECT Name FROM Employee WHERE ID='" & EmployeeID & "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader

            If DataReader.Read() Then
                labelGreetings.Text = "Hello, " & DataReader.Item("Name") & "!"
            End If

            DataReader.Close()
        Catch ex As Exception
            MsgBox("Failed to retrieve Employee information: " & ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Friend Sub ReloadEmployeesTable()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, Name, Username, Email, Address, DOB, Role FROM Employee ORDER BY CreatedAt DESC"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            dgvEmployees.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvEmployees.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("Name").ToString(),
                        DataReader.Item("Username").ToString(),
                        DataReader.Item("Email").ToString(),
                        DataReader.Item("Address").ToString(),
                        DataReader.Item("DOB"),
                        DataReader.Item("Role").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Friend Sub ReloadFruitsTable()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, FruitName, FruitType, Stock, Unit, PurchasePrice, SellPrice FROM Fruit ORDER BY CreatedAt DESC"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            dgvFruits.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvFruits.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("FruitName").ToString(),
                        DataReader.Item("FruitType").ToString(),
                        DataReader.Item("Stock").ToString(),
                        DataReader.Item("Unit").ToString(),
                        DataReader.Item("PurchasePrice").ToString(),
                        DataReader.Item("SellPrice").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub DeleteEmployees(employeeIds() As String)
        Try
            AppConnection.Open()

            For Each id As String In employeeIds
                SqlQuery = "DELETE FROM Employee WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operation: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub DeleteFruits(fruitIds() As String)
        Try
            AppConnection.Open()

            For Each id As String In fruitIds
                SqlQuery = "DELETE FROM Fruit WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operation: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Are you sure want to logout?", vbQuestion & vbYesNoCancel)
        If result = vbYes Then
            Hide()
            EmployeeID = ""

            FormLogin.Show()
        End If
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        AdminTabs.SelectedTab = TabEmployees
    End Sub

    Private Sub btnFruits_Click(sender As Object, e As EventArgs) Handles btnFruits.Click
        AdminTabs.SelectedTab = TabFruit
    End Sub

    Private Sub dgvEmployees_Layout(sender As Object, e As LayoutEventArgs) Handles dgvEmployees.Layout
        ReloadEmployeesTable()
    End Sub

    Private Sub TabFruit_Layout(sender As Object, e As LayoutEventArgs) Handles TabFruit.Layout
        ReloadFruitsTable()
    End Sub

    Private Sub btnNewEmployee_Click(sender As Object, e As EventArgs) Handles btnNewEmployee.Click
        FormEmployee.Add()
    End Sub

    Private Sub btnRemoveEmployee_Click(sender As Object, e As EventArgs) Handles btnRemoveEmployee.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvEmployees.SelectedRows

        If selectedRows.Count > 0 Then
            Dim ids(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                ids(index) = selectedRows.Item(index).Cells.Item("ID").Value
            Next
            If Not ids.Contains(EmployeeID) Then
                Dim answer As Integer = MsgBox("Are you sure to delete these employees?", vbQuestion & vbYesNoCancel, "Alert")
                If answer = vbYes Then
                    DeleteEmployees(ids)
                    ReloadEmployeesTable()
                End If
            Else
                MsgBox("You cannot delete the currently logged in user")
            End If
        Else
                MsgBox("Please select rows to be removed")
        End If
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        If dgvEmployees.SelectedRows.Count > 1 Then
            MsgBox("Please select only one data")
            Return
        End If

        If dgvEmployees.SelectedRows.Count < 0 Then
            MsgBox("Please select a row")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvEmployees.SelectedRows.Item(0)

        FormEmployee.Edit(selectedRow.Cells.Item("ID").Value)
    End Sub

    Private Sub btnNewFruit_Click(sender As Object, e As EventArgs) Handles btnNewFruit.Click
        FormFruit.Add()
    End Sub

    Private Sub btnRemoveFruit_Click(sender As Object, e As EventArgs) Handles btnRemoveFruit.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvFruits.SelectedRows

        If selectedRows.Count > 0 Then
            Dim ids(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                ids(index) = selectedRows.Item(index).Cells.Item("FruitID").Value
            Next
            Dim answer As Integer = MsgBox("Are you sure to delete these fruits?", vbQuestion & vbYesNoCancel, "Alert")
            If answer = vbYes Then
                DeleteFruits(ids)
                ReloadFruitsTable()
            End If
        Else
            MsgBox("Please select rows to be removed")
        End If
    End Sub

    Private Sub btnEditFruit_Click(sender As Object, e As EventArgs) Handles btnEditFruit.Click
        If dgvFruits.SelectedRows.Count > 1 Then
            MsgBox("Please select only one data")
            Return
        End If

        If dgvFruits.SelectedRows.Count < 0 Then
            MsgBox("Please select a row")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvFruits.SelectedRows.Item(0)

        FormFruit.Edit(selectedRow.Cells.Item("FruitID").Value)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        FormProfile.ShowByID(EmployeeID)
    End Sub
End Class