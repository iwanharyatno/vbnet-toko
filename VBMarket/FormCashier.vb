Imports System.Data.SqlClient

Public Class FormCashier
    Private shoppingCustomerID As String = ""

    Friend Sub GetCashierData()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name FROM Employee WHERE ID='" + EmployeeID + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    labelGreetings.Text = "Hello, " + DataReader.Item("Name").ToString()
                End If
            End If
        Catch ex As Exception
            MsgBox("Couldn't get current employee information: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub ResetSalesInputs()
        dgvCart.Rows.Clear()
        FieldPayment.Text = "0"
        dtpSaleDate.Value = Date.Now
        numQty.Value = 0
        FieldChanges.Text = ""

        CalculateTotal()
    End Sub

    Friend Sub ReloadCustomerTable()
        dgvCustomers.Rows.Clear()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT * FROM Customer ORDER BY CreatedAt"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvCustomers.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("Name").ToString(),
                        DataReader.Item("Email").ToString(),
                        DataReader.Item("Phone").ToString(),
                        DataReader.Item("Address").ToString(),
                        DataReader.Item("Debt").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load customer data into table: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Friend Sub ReloadFruitTable()
        dgvFruits.Rows.Clear()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, FruitName, FruitType, Stock, SellPrice FROM Fruit WHERE Stock > 0 ORDER BY CreatedAt"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvFruits.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("FruitName").ToString(),
                        DataReader.Item("FruitType").ToString(),
                        DataReader.Item("Stock").ToString(),
                        DataReader.Item("SellPrice").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load fruit data into table: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Function IsInputValid()
        If FieldPayment.Text.Equals("") Then
            MsgBox("Please enter payment value")
            Return False
        End If

        If shoppingCustomerID.Equals("") Then
            MsgBox("Please select customer first")
        End If

        Return True
    End Function

    Private Sub DeleteCustomers(ids As String())
        Try
            AppConnection.Open()
            For Each id As String In ids
                SqlQuery = "DELETE FROM Customer WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Couldn't execute DELETE operation: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub FillShoppingCustomerInformation()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT Name, Phone FROM Customer WHERE ID='" + shoppingCustomerID + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                If DataReader.Read() Then
                    FieldCustomerID.Text = shoppingCustomerID
                    FieldCustomerName.Text = DataReader.Item("Name")
                    FieldCustomerPhone.Text = DataReader.Item("Phone")
                End If
            End If
        Catch ex As Exception
            MsgBox("Couldn't get customer information: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Function GetCartFruitIDs() As String()
        Dim result(dgvCart.RowCount - 1) As String

        For index As Integer = 0 To dgvCart.RowCount - 1
            result(index) = dgvCart.Rows.Item(index).Cells.Item("CartFruitID").Value
        Next

        Return result
    End Function

    Private Sub AddToCartHandler(selectedRow As DataGridViewRow)
        Dim name As String = selectedRow.Cells.Item("FruitName").Value
        Dim stock As String = selectedRow.Cells.Item("FruitStock").Value
        Dim price As Integer = selectedRow.Cells.Item("SellPrice").Value
        Dim qty As Integer = numQty.Value
        Dim subtotal As Integer = qty * price

        If stock < qty Then
            MsgBox("There's not enough " + name + " to sell. Defaulting to " + stock)
        End If

        dgvCart.Rows.Add(New String() {
            selectedRow.Cells.Item("FruitID").Value,
            name,
            qty,
            price,
            subtotal
        })

        Dim total As Integer = FieldTotal.Text
        FieldTotal.Text = total + subtotal
    End Sub

    Private Sub CalculateTotal()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In dgvCart.Rows
            total += row.Cells.Item("CartSubtotal").Value
        Next

        FieldTotal.Text = total
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        CashierTabs.SelectedTab = TabCustomers
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        FormCustomer.Add()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Are you sure want to logout?", vbQuestion & vbYesNoCancel)
        If result = vbYes Then
            Hide()
            EmployeeID = ""

            FormLogin.Show()
        End If
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        FormProfile.ShowById(EmployeeID)
    End Sub

    Private Sub btnSellFruits_Click(sender As Object, e As EventArgs) Handles btnSellFruits.Click
        CashierTabs.SelectedTab = TabSales
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvCustomers.SelectedRows

        If selectedRows.Count = 1 Then
            FormCustomer.Edit(selectedRows.Item(0).Cells.Item("CustomerID").Value)
        Else
            MsgBox("Please select exactly one record to edit")
        End If
    End Sub

    Private Sub btnRemoveCustomer_Click(sender As Object, e As EventArgs) Handles btnRemoveCustomer.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvCustomers.SelectedRows

        If selectedRows.Count > 0 Then
            Dim deleteIds(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                deleteIds(index) = selectedRows.Item(index).Cells.Item("CustomerID").Value
            Next

            Dim answer As Integer = MsgBox("Are you sure to delete these customers?", vbQuestion + vbYesNoCancel)
            If answer = vbYes Then
                DeleteCustomers(deleteIds)
                ReloadCustomerTable()
            End If
        Else
            MsgBox("Please select at least one row to remove")
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If dgvFruits.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In dgvFruits.SelectedRows
                If Not GetCartFruitIDs().Contains(selectedRow.Cells.Item("FruitID").Value) Then
                    AddToCartHandler(selectedRow)
                Else
                    MsgBox("The fruit '" + selectedRow.Cells.Item("FruitName").Value + "' is already on the cart")
                End If
            Next
        Else
            MsgBox("Please select at least one row")
        End If
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = dgvCart.SelectedRows
            For Each selectedRow As DataGridViewRow In selectedRows
                dgvCart.Rows.Remove(selectedRow)
            Next
            CalculateTotal()
        Else
            MsgBox("Please select at least one item to be removed")
        End If
    End Sub

    Private Sub btnToSales_Click(sender As Object, e As EventArgs) Handles btnToSales.Click
        If dgvCustomers.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow = dgvCustomers.SelectedRows.Item(0)
            shoppingCustomerID = selectedRow.Cells.Item("CustomerID").Value
            CashierTabs.SelectedTab = TabSales
        Else
            MsgBox("Please select exactly one customer")
        End If
    End Sub

    Private Sub dgvCart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellValueChanged
        If e.ColumnIndex = dgvCart.Columns.IndexOf(dgvCart.Columns.Item("CartQty")) Then
            Dim changedRow As DataGridViewRow = dgvCart.Rows.Item(e.RowIndex)

            Dim newQty As Integer = changedRow.Cells.Item("CartQty").Value
            Dim price As Integer = changedRow.Cells.Item("CartPrice").Value

            Dim previousSubtotal As Integer = changedRow.Cells.Item("CartSubtotal").Value
            Dim newSubtotal As Integer = newQty * price

            changedRow.Cells.Item("CartSubtotal").Value = newSubtotal

            CalculateTotal()
        End If
    End Sub

    Private Sub FieldPayment_TextChanged(sender As Object, e As EventArgs) Handles FieldPayment.TextChanged
        If Not FieldPayment.Text.Equals("") Then
            FieldChanges.Text = FieldPayment.Text - FieldTotal.Text
        Else
            FieldChanges.Text = FieldTotal.Text * -1
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If IsInputValid() Then
            Try
                AppConnection.Open()

                Dim selectedItems As DataGridViewRowCollection = dgvCart.Rows

                For Each selectedItem As DataGridViewRow In selectedItems
                    Dim fruitId As String = selectedItem.Cells.Item("CartFruitID").Value
                    Dim qty As String = selectedItem.Cells.Item("CartQty").Value
                    Dim subtotal As String = selectedItem.Cells.Item("CartSubtotal").Value
                    Dim saleDate As String = dtpSaleDate.Value.ToString("yyyy-MM-dd")

                    SqlQuery =
                        "INSERT INTO Sale (ID, EmployeeID, CustomerID, FruitID, Qty, Subtotal, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + EmployeeID + "', '" + shoppingCustomerID + "', '" + fruitId + "', " + qty + ", '" + subtotal + "', '" + saleDate + "', GETDATE());" +
                        "UPDATE Fruit SET Stock -= " + qty + " WHERE ID='" + fruitId + "';" +
                        "UPDATE Finance SET CurrentBalance += " + subtotal + ""
                    Command = New SqlCommand(SqlQuery, AppConnection.Connection)
                    Command.ExecuteNonQuery()
                Next

                MsgBox("Sale recorded successfully")
                ResetSalesInputs()
                ReloadFruitTable()
            Catch ex As Exception
                MsgBox("Couldn't perform the INSERT operation: " + ex.Message)
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub

    Private Sub CashierTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CashierTabs.SelectedIndexChanged
        Select Case CashierTabs.SelectedIndex
            Case CashierTabs.TabPages.IndexOf(TabCustomers)
                ReloadCustomerTable()
                Exit Select
            Case CashierTabs.TabPages.IndexOf(TabSales)
                ReloadFruitTable()

                If Not shoppingCustomerID.Equals("") Then
                    FillShoppingCustomerInformation()
                Else
                    MsgBox("No selected customer yet, be sure to select it now or later", vbApplicationModal, "Warning")
                End If
                Exit Select
        End Select
    End Sub

    Private Sub btnToDebt_Click(sender As Object, e As EventArgs) Handles btnToDebt.Click
        If Not shoppingCustomerID.Equals("") Then
            Try
                AppConnection.Open()

                SqlQuery = "UPDATE Customer SET Debt += " + FieldChanges.Text + " WHERE ID='" + shoppingCustomerID + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
                MsgBox("Changes evaluated to customer's debt")
            Catch ex As Exception
                MsgBox("Couldn't execute UPDATE operation: " + ex.Message)
            Finally
                AppConnection.Close()
            End Try
        Else
            MsgBox("Please select a customer first")
        End If
    End Sub
End Class