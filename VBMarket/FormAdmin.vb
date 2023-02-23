﻿Imports System.Data.SqlClient

Public Class FormAdmin
    Private activeSupplierID As String = ""

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

    Friend Sub ReloadSuppliersTable()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, Name, Phone, Email, Address FROM Supplier ORDER BY CreatedAt DESC"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            dgvSuppliers.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvSuppliers.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("Name").ToString(),
                        DataReader.Item("Phone").ToString(),
                        DataReader.Item("Email").ToString(),
                        DataReader.Item("Address").ToString()
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

    Friend Sub ReloadFruitsTableForRestock()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, FruitName, FruitType, Stock, PurchasePrice FROM Fruit ORDER BY CreatedAt DESC;
                        SELECT CurrentBalance FROM Finance"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            dgvFruitsRestock.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvFruitsRestock.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("FruitName").ToString(),
                        DataReader.Item("FruitType").ToString(),
                        DataReader.Item("Stock").ToString(),
                        DataReader.Item("PurchasePrice").ToString()
                    })
                End While
            End If

            If DataReader.NextResult() Then
                If DataReader.Read Then
                    FieldCurrentBalance.Text = DataReader.Item("CurrentBalance")
                End If
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub FillSupplierDetailForRestock()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name, Email FROM Supplier WHERE ID='" + activeSupplierID + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    FieldSupplierName.Text = DataReader.Item("Name")
                    FieldSupplierEmail.Text = DataReader.Item("Email")
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed to fetch supplier detail: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub ClearRestockFields()
        dgvCartRestock.Rows.Clear()
        numQty.Value = 0
        FieldTotal.Text = "0"
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

    Private Sub DeleteSuppliers(supplierIDs As String())
        Try
            AppConnection.Open()

            For Each id As String In supplierIDs
                SqlQuery = "DELETE FROM Supplier WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operations: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub AddToCartHandler(selectedRow As DataGridViewRow)
        Dim qty As Integer = numQty.Value
        Dim price As Integer = selectedRow.Cells.Item("RestockFruitPrice").Value
        Dim subtotal As Integer = qty * price

        dgvCartRestock.Rows.Add(New String() {
            selectedRow.Cells.Item("RestockFruitID").Value,
            selectedRow.Cells.Item("RestockFruitName").Value,
            selectedRow.Cells.Item("RestockFruitType").Value,
            qty,
            price,
            subtotal
        })

        CalculateTotal()
    End Sub

    Private Function GetCartFruitIDs() As String()
        Dim result(dgvCartRestock.RowCount - 1) As String

        For index As Integer = 0 To dgvCartRestock.RowCount - 1
            result(index) = dgvCartRestock.Rows.Item(index).Cells.Item("RestockCartFruitID").Value
        Next

        Return result
    End Function

    Private Sub CalculateTotal()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In dgvCartRestock.Rows
            total += row.Cells.Item("RestockCartSubtotal").Value
        Next

        FieldTotal.Text = total
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
        FormProfile.ShowById(EmployeeID)
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If dgvFruitsRestock.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow = dgvFruitsRestock.SelectedRows.Item(0)
            If Not GetCartFruitIDs().Contains(selectedRow.Cells.Item("RestockFruitID").Value) Then
                AddToCartHandler(selectedRow)
                CalculateTotal()
            Else
                MsgBox("The fruit is already on the cart")
            End If
        Else
            MsgBox("Please select exactly one row")
        End If
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        If dgvCartRestock.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = dgvCartRestock.SelectedRows
            For Each selectedRow As DataGridViewRow In selectedRows
                dgvCartRestock.Rows.Remove(selectedRow)
            Next
            CalculateTotal()
        Else
            MsgBox("Please select at least one row to remove")
        End If
    End Sub

    Private Sub dgvCartRestock_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartRestock.CellValueChanged
        If e.ColumnIndex = dgvCartRestock.Columns.IndexOf(dgvCartRestock.Columns.Item("RestockCartQty")) Then
            Dim changedRow As DataGridViewRow = dgvCartRestock.Rows.Item(e.RowIndex)

            Dim newQty As Integer = changedRow.Cells.Item("RestockCartQty").Value
            Dim price As Integer = changedRow.Cells.Item("RestockCartPrice").Value

            Dim previousSubtotal As Integer = changedRow.Cells.Item("RestockCartSubtotal").Value
            Dim newSubtotal As Integer = newQty * price

            changedRow.Cells.Item("RestockCartSubtotal").Value = newSubtotal

            CalculateTotal()
        End If
    End Sub

    Private Sub btnNewSupplier_Click(sender As Object, e As EventArgs) Handles btnNewSupplier.Click
        FormSupplier.Add()
    End Sub

    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvSuppliers.SelectedRows

        If selectedRows.Count = 1 Then
            FormSupplier.Edit(selectedRows.Item(0).Cells.Item("SupplierID").Value)
        Else
            MsgBox("Please select exactly one row")
        End If
    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvSuppliers.SelectedRows

        If selectedRows.Count > 0 Then
            Dim ids(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                ids(index) = selectedRows.Item(index).Cells.Item("SupplierID").Value
            Next

            Dim answer As Integer = MsgBox("Are you sure to remove these suppliers?", vbQuestion + vbYesNo)
            If answer = vbYes Then
                DeleteSuppliers(ids)
                ReloadSuppliersTable()
            End If
        End If
    End Sub

    Private Sub btnBringSupplierToRestock_Click(sender As Object, e As EventArgs) Handles btnBringSupplierToRestock.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvSuppliers.SelectedRows

        If selectedRows.Count = 1 Then
            activeSupplierID = selectedRows.Item(0).Cells.Item("SupplierID").Value
            FillSupplierDetailForRestock()

            AdminTabs.SelectedTab = TabRestock
        Else
            MsgBox("Please select exactly one row")
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim total As Integer = FieldTotal.Text
        Dim currentBalance As Integer = FieldCurrentBalance.Text

        If activeSupplierID.Equals("") Then
            MsgBox("You haven't select the supplier for restock")
            Return
        End If

        If total > currentBalance Then
            MsgBox("Not enough balance for this payment")
            Return
        End If

        Try
            AppConnection.Open()

            Dim selectedRows As DataGridViewRowCollection = dgvCartRestock.Rows

            For Each selectedRow As DataGridViewRow In selectedRows
                Dim fruitId As String = selectedRow.Cells.Item("RestockCartFruitID").Value
                Dim qty As String = selectedRow.Cells.Item("RestockCartQty").Value
                Dim subtotal As String = selectedRow.Cells.Item("RestockCartSubtotal").Value

                SqlQuery = "INSERT INTO Purchase (ID, AdminID, SupplierID, FruitID, Qty, Subtotal, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + EmployeeID + "', '" + activeSupplierID + "', '" + fruitId + "', '" + qty + "', '" + subtotal + "', GETDATE(), GETDATE());
                                UPDATE Fruit SET Stock += '" + qty + "' WHERE ID='" + fruitId + ";'
                                UPDATE Finance SET CurrentBalance -= '" + subtotal + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next

            MsgBox("Purchase Recorded!")
            ReloadFruitsTableForRestock()
            ClearRestockFields()
        Catch ex As Exception
            MsgBox("Couldn't perform INSERT-UPDATE operations: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub FieldTotal_TextChanged(sender As Object, e As EventArgs) Handles FieldTotal.TextChanged
        If FieldTotal.Text > FieldCurrentBalance.Text Then
            FieldTotal.ForeColor = Color.DarkRed
        Else
            FieldTotal.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
        End If
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        AdminTabs.SelectedTab = TabSupplier
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        AdminTabs.SelectedTab = TabRestock
    End Sub

    Private Sub AdminTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AdminTabs.SelectedIndexChanged
        Select Case AdminTabs.SelectedIndex
            Case AdminTabs.TabPages.IndexOf(TabEmployees)
                ReloadEmployeesTable()
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabFruit)
                ReloadFruitsTable()
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabSupplier)
                ReloadSuppliersTable()
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabRestock)
                ReloadFruitsTableForRestock()
                If activeSupplierID.Equals("") Then
                    MsgBox("You haven't selected a supplier yet, be sure to select it now or later")
                End If
                Exit Select
        End Select
    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        FormReport.Show()
    End Sub
End Class