Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FormFruit
    Private editMode As Boolean = False
    Private fruitId As String

    Private Sub LoadSupplierCombo()
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, Name FROM Supplier"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)
            DataReader = Command.ExecuteReader()

            DataTable = New DataTable()
            DataTable.Load(DataReader)

            ComboSupplier.DataSource = DataTable
            ComboSupplier.DisplayMember = "Name"
            ComboSupplier.ValueMember = "ID"
        Catch ex As Exception
            MsgBox("Failed to get suppliers: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub Clear()
        FieldName.Clear()
        FieldPurchasePrice.Clear()
        FieldSellPrice.Clear()
        FieldStock.Clear()
        ComboSupplier.SelectedIndex = 0
        ComboType.SelectedIndex = 0
    End Sub

    Friend Sub Add()
        editMode = False
        fruitId = ""

        LoadSupplierCombo()
        Clear()
        Show()

        btnCreate.Text = "CREATE"
    End Sub

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The 'name' field is required", vbOKOnly, "Error")
            Return False
        End If

        If ComboType.SelectedItem.Equals("") Then
            MsgBox("The 'type' field is required", vbOKOnly, "Error")
            Return False
        End If

        If FieldStock.Text.Equals("") Then
            MsgBox("The 'stock' field is required", vbOKOnly, "Error")
            Return False
        End If

        If Not Regex.IsMatch(FieldStock.Text, "\d+") Then
            MsgBox("The 'stock' must be a number", vbOKOnly, "Error")
            Return False
        End If

        If Not Regex.IsMatch(FieldPurchasePrice.Text, "\d+") Then
            MsgBox("The 'purchase price' must be a number", vbOKOnly, "Error")
            Return False
        End If

        If Not Regex.IsMatch(FieldSellPrice.Text, "\d+") Then
            MsgBox("The 'sale price' must be a number", vbOKOnly, "Error")
            Return False
        End If

        Return True
    End Function

    Friend Sub Edit(id As String)
        editMode = True
        fruitId = id

        LoadSupplierCombo()
        Clear()
        Show()

        btnCreate.Text = "SAVE"

        Try
            AppConnection.Open()

            SqlQuery = "SELECT * FROM Fruit WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.Read() Then
                FieldName.Text = DataReader.Item("FruitName")
                FieldStock.Text = DataReader.Item("Stock")
                ComboSupplier.SelectedValue = DataReader.Item("Unit")
                FieldPurchasePrice.Text = CDbl(DataReader.Item("PurchasePrice"))
                FieldSellPrice.Text = CDbl(DataReader.Item("SellPrice"))
                ComboType.SelectedIndex = ComboType.Items.IndexOf(DataReader.Item("FruitType"))
            End If
        Catch ex As Exception
            MsgBox("Failed to get fruit data by ID: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If IsInputValid() Then
            Dim fruitName As String = FieldName.Text
            Dim fruitType As String = ComboType.SelectedItem.ToString()
            Dim stock As String = FieldStock.Text
            Dim unit As String = ComboSupplier.SelectedValue.ToString()
            Dim purchasePrice As String = FieldPurchasePrice.Text
            Dim sellPrice As String = FieldSellPrice.Text

            Try
                AppConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Fruit (ID, FruitName, FruitType, Stock, Unit, PurchasePrice, SellPrice, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + fruitName + "', '" + fruitType + "', '" + stock + "', '" + unit + "', '" + purchasePrice + "', '" + sellPrice + "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Fruit SET FruitName='" + fruitName + "', FruitType='" + fruitType + "', Stock='" + stock + "', Unit='" + unit + "', PurchasePrice='" + purchasePrice + "', SellPrice='" + sellPrice + "', UpdatedAt=GETDATE() WHERE ID='" + fruitId + "'"
                End If

                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()

                FormAdmin.ReloadFruitsTable("")
                Hide()
            Catch ex As Exception
                MsgBox("Failed to execute INSERT operation: " + ex.Message, vbOKOnly, "Error")
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub
End Class