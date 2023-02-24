Imports System.Data.SqlClient
''' <summary>
''' Form Admin. Digunakan untuk mengelola data level admin. Diantaranya adalah data pegawai,
''' data buah, dan data supplier
''' </summary>
Public Class FormAdmin
    ' Mengambil informasi admin yang relevan untuk ditampilkan di tab home
    Friend Sub GetAdminInfo()
        Try
            AppConnection.Open() ' membuka koneksi ke databse
            SqlQuery = "SELECT Name FROM Employee WHERE ID='" & EmployeeID & "'" ' mendapatkan nama pengguna dari tabel employee dengan ID yang sama dengan ID yang disimpan pada variabel EmployeeID pada module GlobalVariable
            Command = New SqlCommand(SqlQuery, AppConnection.Connection) ' memasangkan perintah sql diatas ke dalam wrapper untuk nantinya dijalankan

            DataReader = Command.ExecuteReader() ' memulai pembacaan data

            If DataReader.Read() Then ' jika data reader bisa geser ke baris setelahnya (artinya ada hasil dari operasi ini)
                labelGreetings.Text = "Hello, " & DataReader.Item("Name") & "!" ' Menampilkan nama pengguna pada label yang tersedia pada tab Home
            End If

            DataReader.Close() ' menutup pembacaan data
        Catch ex As Exception
            MsgBox("Failed to retrieve Employee information: " & ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Merefresh data employee pada data grid view employee
    ' - additionalClause: klausa ekstra yang dalam konteks aplikasi ini digunakan untuk memfilter data dengan menambahkan klausa where ekstra
    Friend Sub ReloadEmployeesTable(additionalClause As String)
        Try
            AppConnection.Open() ' membuka koneksi ke database

            SqlQuery = "SELECT ID, Name, Username, Email, Address, DOB, Role FROM Employee " + additionalClause + " ORDER BY CreatedAt DESC" ' menyiapkan sintaks sql untuk mendapatkan data-data pegawai
            Command = New SqlCommand(SqlQuery, AppConnection.Connection) ' memasangkan sintaks sql tersebut ke kelas wrapper untuk mengabstraksikan detail low level dalam menjalankan query sql dari vb net

            DataReader = Command.ExecuteReader() ' memulai pembacaan data
            dgvEmployees.Rows.Clear() ' menghapus semua baris yang ada pada data grid view employee
            If DataReader.HasRows Then ' jika data reader memiliki baris untuk dibaca
                While DataReader.Read() ' selama data reader masih membaca baris data
                    dgvEmployees.Rows.Add(New String() { ' tambahkan baris baru di dgv employee dengan,
                        DataReader.Item("ID").ToString(), ' kolom ID - invisible
                        DataReader.Item("Name").ToString(), ' kolom Name
                        DataReader.Item("Username").ToString(), ' kolom Username
                        DataReader.Item("Email").ToString(), ' kolom Email
                        DataReader.Item("Address").ToString(), ' kolom address
                        DataReader.Item("DOB"), ' kolom date of birth
                        DataReader.Item("Role").ToString() ' kolom role
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Merefresh data supplier pada data grid view supplier
    ' - additionalClause: klausa ekstra yang dalam konteks aplikasi ini digunakan untuk memfilter data dengan menambahkan klausa where ekstra
    Friend Sub ReloadSuppliersTable(additionalClause As String)
        ' Logika programnya hampir mirip dengan ReloadEmployeesTable, yang membedakan hanyalah:
        ' - nama tabel dan kolom-kolomnya
        ' - data grid view untuk menampilkan datanya (karena ini supplier maka data grid view yang digunakan adalah data grid view supplier
        Try
            AppConnection.Open()

            SqlQuery = "SELECT ID, Name, Phone, Email, Address FROM Supplier " + additionalClause + " ORDER BY CreatedAt DESC"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()
            dgvSuppliers.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvSuppliers.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("Name").ToString(),
                        DataReader.Item("Email").ToString(),
                        DataReader.Item("Phone").ToString(),
                        DataReader.Item("Address").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Merefresh data buah pada data grid view fruit
    ' - additionalClause: klausa ekstra yang dalam konteks aplikasi ini digunakan untuk memfilter data dengan menambahkan klausa where ekstra
    Friend Sub ReloadFruitsTable(additionalClause As String)
        ' Logika programnya hampir mirip dengan ReloadEmployeesTable, yang membedakan hanyalah:
        ' - nama tabel dan kolom-kolomnya
        ' - data grid view untuk menampilkan datanya (karena ini supplier maka data grid view yang digunakan adalah data grid view supplier
        Try
            AppConnection.Open()

            SqlQuery = "SELECT Fruit.ID, FruitName, FruitType, Stock, Supplier.Name as SupplierName, Unit, PurchasePrice, SellPrice FROM Fruit
            INNER JOIN Supplier ON Supplier.ID = Fruit.Unit " + additionalClause + " ORDER BY Fruit.CreatedAt DESC"
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
                        DataReader.Item("SupplierName").ToString(),
                        DataReader.Item("PurchasePrice").ToString(),
                        DataReader.Item("SellPrice").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Couldn't load data into table: " & ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Merefresh data buah pada data grid view fruit di tab restock
    ' - additionalClause: klausa ekstra yang dalam konteks aplikasi ini digunakan untuk memfilter data dengan menambahkan klausa where ekstra
    Friend Sub ReloadFruitsTableForRestock(additionalWhere As String)
        If Not RestockComboSupplier.SelectedValue.ToString().Equals("") Then ' query hanya akan dijalankan jika ada supplier yang dipilih dari combo box supplier
            ' Logika programnya hampir mirip dengan ReloadEmployeesTable, yang membedakan hanyalah:
            ' - nama tabel dan kolom-kolomnya
            ' - data grid view untuk menampilkan datanya (karena ini supplier maka data grid view yang digunakan adalah data grid view supplier
            Try
                AppConnection.Open()

                SqlQuery = "SELECT ID, FruitName, FruitType, Stock, PurchasePrice FROM Fruit WHERE Unit='" + RestockComboSupplier.SelectedValue.ToString() + "' " + additionalWhere + " ORDER BY CreatedAt DESC;
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
                MsgBox("Couldn't load data into table: " & ex.Message, vbOKOnly, "Error")
            Finally
                AppConnection.Close()
            End Try
        End If
    End Sub

    ' Menampilkan pilihan supplier pada combo box supplier pada tab restock
    Private Sub LoadSuppliersCombo()
        Try
            AppConnection.Open() ' membuka koneksi ke database

            SqlQuery = "SELECT ID, Name FROM Supplier" ' menyiapkan sintaks sql
            Command = New SqlCommand(SqlQuery, AppConnection.Connection) ' memasangkan sintaks sql tersebut ke sebuah kelas wrapper untuk nantinya akan dijalankan

            DataReader = Command.ExecuteReader() ' memulai pembacaan data
            DataTable = New DataTable() ' menginisialisasi data table

            DataTable.Load(DataReader) ' mengisi data table tersebut dengan hasil dari select tadi

            RestockComboSupplier.DataSource = DataTable ' menjadikan datatable tadi sebagai sumber data untuk ditampilkan di combo box. Nilai yang ditampilkan (DisplayMember) adalah kolom nama, sedangkan nilainya sebenarnya (ValueMember) adalah kolom ID.
        Catch ex As Exception
            MsgBox("Couldn't load supplier list: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Mereset field field untuk persiapan sesi belanja baru
    Private Sub ClearRestockFields()
        dgvCartRestock.Rows.Clear()
        numQty.Value = 0
        FieldTotal.Text = "0"
        dtpPurchaseDate.Value = Date.Now
    End Sub

    ' Menghapus data-data pegawai berdasarkan ID-ID yang dispesifikasikan
    ' - employeeIds: ID-ID employee yang akan dihapus
    Private Sub DeleteEmployees(employeeIds() As String)
        Try
            AppConnection.Open() ' membuka koneksi ke database

            For Each id As String In employeeIds ' loop untuk setiap list id yang akan dihapus
                SqlQuery = "DELETE FROM Employee WHERE ID='" + id + "'" ' menyiapkan query untuk menghapus data berdasarkan id pada sesi loop saat ini
                Command = New SqlCommand(SqlQuery, AppConnection.Connection) ' memasangnya pada kelas wrapper

                Command.ExecuteNonQuery() ' menjalankan query tersebut
            Next ' repeat~
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operation: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Menghapus data-data buah berdasarkan ID-ID yang dispesifikasikan
    ' - fruitIds: ID-ID buah yang akan dihapus
    Private Sub DeleteFruits(fruitIds() As String)
        ' Logika programnya hampir mirip dengan DeleteEmployees, yang membedakan hanya:
        ' - nama tabel pada sintaks sql
        Try
            AppConnection.Open()

            For Each id As String In fruitIds
                SqlQuery = "DELETE FROM Fruit WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operation: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Menghapus data-data buah berdasarkan ID-ID yang dispesifikasikan
    ' - fruitIds: ID-ID buah yang akan dihapus
    Private Sub DeleteSuppliers(supplierIDs As String())
        ' Logika programnya hampir mirip dengan DeleteEmployees, yang membedakan hanya:
        ' - nama tabel pada sintaks sql
        Try
            AppConnection.Open()

            For Each id As String In supplierIDs
                SqlQuery = "DELETE FROM Supplier WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to execute DELETE operations: " + ex.Message, vbOKOnly, "Error")
        Finally
            AppConnection.Close()
        End Try
    End Sub

    ' Menangani serangkaian operasi yang terjadi saat admin mengklik tombol 'Add to cart'
    ' Setelah data yang akan ditambahkan dijamin valid sebelumnya
    Private Sub AddToCartHandler(selectedRow As DataGridViewRow)
        Dim qty As Integer = numQty.Value ' menyiapkan variabel qty untuk persiapan menghitung subtotal
        Dim price As Integer = selectedRow.Cells.Item("RestockFruitPrice").Value ' menyiapkan variabel price untuk persiapan menghitung subtotal
        Dim subtotal As Integer = qty * price ' menghitung subtotal sebagai qty dikali harga

        dgvCartRestock.Rows.Add(New String() { ' menambahkan baris baru ke data grid view cart dengan,
            selectedRow.Cells.Item("RestockFruitID").Value, ' kolom id - invisible
            selectedRow.Cells.Item("RestockFruitName").Value, ' nama buah
            selectedRow.Cells.Item("RestockFruitType").Value, ' jenis buah
            qty, ' banyak pesanan
            price, ' harga per pcs
            subtotal ' subtotal
        })

        CalculateTotal() ' menghitung ulang total belanjaan
    End Sub

    ' Mendapatkan daftar ID buah yang terdapat pada data grid view cart
    Private Function GetCartFruitIDs() As String()
        Dim result(dgvCartRestock.RowCount - 1) As String ' membuat array untuk menampung daftar id tersebut, -1 karena index tertinggi array dengan banyaknya item n adalah n-1

        For index As Integer = 0 To dgvCartRestock.RowCount - 1 ' loop dari 0 sampai index tertinggi array
            result(index) = dgvCartRestock.Rows.Item(index).Cells.Item("RestockCartFruitID").Value ' mengisi index saat ini dengan nilai kolom id dengan baris ke-index saat ini pada tabel cart
        Next ' repeat~

        Return result ' mengembalikan daftar id untuk kepentingan lain
    End Function

    ' Menghitung ulang total belanjaan
    Private Sub CalculateTotal()
        Dim total As Integer = 0 ' default total 0

        For Each row As DataGridViewRow In dgvCartRestock.Rows ' loop setiap baris di tabel cart
            total += row.Cells.Item("RestockCartSubtotal").Value ' menambahkan total dengan nilai subtotal pada baris saat ini
        Next ' repeat~

        FieldTotal.Text = total ' mengisi teks field total dengan hasil penghitungan total
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As Integer = MsgBox("Are you sure want to logout?", vbQuestion & vbYesNoCancel) ' menampilkan modal konfirmasi logout dengan tombol yes, no, dan cancel
        If result = vbYes Then ' jika hasilnya sama dengan vbYes (variabel vb untuk hasil dialog YES)
            Hide() ' tutup form ini
            EmployeeID = "" ' reset nilai employee id

            FormLogin.Show() ' tampilkan form login
        End If
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        AdminTabs.SelectedTab = TabEmployees ' saat tombol employees di klik, set tab saat ini ke tab employee
    End Sub

    Private Sub btnFruits_Click(sender As Object, e As EventArgs) Handles btnFruits.Click
        AdminTabs.SelectedTab = TabFruit ' saat tombol fruit di klik, set tab saat ini ke tab fruit
    End Sub

    Private Sub btnNewEmployee_Click(sender As Object, e As EventArgs) Handles btnNewEmployee.Click
        FormEmployee.Add() ' Tampilkan form untuk menginput data pengguna baru
    End Sub

    Private Sub btnRemoveEmployee_Click(sender As Object, e As EventArgs) Handles btnRemoveEmployee.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvEmployees.SelectedRows ' dapatkan daftar kolom yang dipilih di tabel Employee

        If selectedRows.Count > 0 Then ' jika kolom yang dipilih lebih dari 0
            Dim ids(selectedRows.Count - 1) As String ' siapkan array untuk menampung id-id pegawai yang dipilih
            For index As Integer = 0 To selectedRows.Count - 1 ' loop sampai nilai tertingi dari array tersebut
                ids(index) = selectedRows.Item(index).Cells.Item("ID").Value ' simpan id baris yang sedang di loop saat ini ke idnex yang sesuai di array
            Next ' repeat~
            If Not ids.Contains(EmployeeID) Then ' Hanya perbolehkan hapus employee selain employee yang sedang login saat ini
                Dim answer As Integer = MsgBox("Are you sure to delete these employees?", vbQuestion & vbYesNoCancel, "Alert")
                If answer = vbYes Then
                    DeleteEmployees(ids)
                    ReloadEmployeesTable("")
                End If
            Else
                MsgBox("You cannot delete the currently logged in user", vbOKOnly, "Error")
            End If
        Else
            MsgBox("Please select rows to be removed", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        If dgvEmployees.SelectedRows.Count > 1 Then ' hanya boleh mengedit satu data dalam satu waktu
            MsgBox("Please select only one data", vbOKOnly, "Error")
            Return
        End If

        If dgvEmployees.SelectedRows.Count < 0 Then ' dan satu maksud saya benar benar satu, tidak lebih apa lagi kurang
            MsgBox("Please select a row", vbOKOnly, "Error")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvEmployees.SelectedRows.Item(0) ' mendapatkan kolom yang sedang dipilih saat ini

        FormEmployee.Edit(selectedRow.Cells.Item("ID").Value) ' menampilkan form edit dengan mengirimkan id pengguna yang akan diedit bersamanya
    End Sub

    Private Sub btnNewFruit_Click(sender As Object, e As EventArgs) Handles btnNewFruit.Click
        FormFruit.Add() ' menampilkan form untuk mengedit buah
    End Sub

    Private Sub btnRemoveFruit_Click(sender As Object, e As EventArgs) Handles btnRemoveFruit.Click
        ' Logikanya mirip sekali dengan RemoveEmployee, yang membedakan hanyalah data grid view yang dipantau saja
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvFruits.SelectedRows

        If selectedRows.Count > 0 Then
            Dim ids(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                ids(index) = selectedRows.Item(index).Cells.Item("FruitID").Value
            Next
            Dim answer As Integer = MsgBox("Are you sure to delete these fruits?", vbQuestion & vbYesNoCancel, "Alert")
            If answer = vbYes Then
                DeleteFruits(ids)
                ReloadFruitsTable("")
            End If
        Else
            MsgBox("Please select rows to be removed", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnEditFruit_Click(sender As Object, e As EventArgs) Handles btnEditFruit.Click
        ' Logikanya mirip sekali dengan EditEmployee, yang membedakan hanyalah data grid view yang dipantau saja
        If dgvFruits.SelectedRows.Count > 1 Then
            MsgBox("Please select only one data", vbOKOnly, "Error")
            Return
        End If

        If dgvFruits.SelectedRows.Count < 0 Then
            MsgBox("Please select a row", vbOKOnly, "Error")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvFruits.SelectedRows.Item(0)

        FormFruit.Edit(selectedRow.Cells.Item("FruitID").Value)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        FormProfile.ShowById(EmployeeID)
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If dgvFruitsRestock.SelectedRows.Count > 0 Then ' hanya tambahkan item ke cart jika terdapat lebih dari satu data yang dipilih
            For Each selectedRow As DataGridViewRow In dgvFruitsRestock.SelectedRows ' loop setiap baris yang terpilih di data grid view cart
                If Not GetCartFruitIDs().Contains(selectedRow.Cells.Item("RestockFruitID").Value) Then ' hanya tambahkan item ke cart jika item tersebut belum ada di cart
                    AddToCartHandler(selectedRow)
                Else
                    MsgBox("The fruit '" + selectedRow.Cells.Item("RestockFruitName").Value + "' is already on the cart")
                End If
            Next

            CalculateTotal() ' hitung ulang total belanjaan
        Else
            MsgBox("Please select at least one row", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        If dgvCartRestock.SelectedRows.Count > 0 Then ' hapus buah dari cart jika banyaknya data yang akan dihapus lebih dari 0
            Dim selectedRows As DataGridViewSelectedRowCollection = dgvCartRestock.SelectedRows
            For Each selectedRow As DataGridViewRow In selectedRows ' loop untuk setiap baris yang dipilih
                dgvCartRestock.Rows.Remove(selectedRow) ' hapus baris yang terpilih dari data grid view cart
            Next
            CalculateTotal() ' hitung ulang total belanjaan
        Else
            MsgBox("Please select at least one row to remove", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub dgvCartRestock_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartRestock.CellValueChanged
        If e.ColumnIndex = dgvCartRestock.Columns.IndexOf(dgvCartRestock.Columns.Item("RestockCartQty")) Then ' jika cell yang berubah nilainya adalah cell dari kolom qty di dgv cart
            Dim changedRow As DataGridViewRow = dgvCartRestock.Rows.Item(e.RowIndex) ' dapatkan data baris dengan cell yang berganti

            Dim newQty As Integer = changedRow.Cells.Item("RestockCartQty").Value ' dapatkan nilai qty yang berubah
            Dim price As Integer = changedRow.Cells.Item("RestockCartPrice").Value ' dapatkan nilai price dari kolom yang berubah qty-nya

            Dim newSubtotal As Integer = newQty * price ' menghitung ulang subtotal sebenarnya

            changedRow.Cells.Item("RestockCartSubtotal").Value = newSubtotal ' mengupdate kolom subtotal pada baris yang diubah qty nya

            CalculateTotal() ' menghitung ulang total belanjaan
        End If
    End Sub

    Private Sub btnNewSupplier_Click(sender As Object, e As EventArgs) Handles btnNewSupplier.Click
        FormSupplier.Add() ' menampilkan form untuk mengedit supplier
    End Sub

    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click
        ' Logikanya mirip sekali dengan EditEmployee, yang membedakan hanyalah data grid view yang dipantau saja
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvSuppliers.SelectedRows

        If selectedRows.Count = 1 Then
            FormSupplier.Edit(selectedRows.Item(0).Cells.Item("SupplierID").Value)
        Else
            MsgBox("Please select exactly one row", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        ' Logikanya mirip sekali dengan DeleteEmployee, yang membedakan hanyalah data grid view yang dipantau saja
        Dim selectedRows As DataGridViewSelectedRowCollection = dgvSuppliers.SelectedRows

        If selectedRows.Count > 0 Then
            Dim ids(selectedRows.Count - 1) As String
            For index As Integer = 0 To selectedRows.Count - 1
                ids(index) = selectedRows.Item(index).Cells.Item("SupplierID").Value
            Next

            Dim answer As Integer = MsgBox("Are you sure to remove these suppliers?", vbQuestion + vbYesNo)
            If answer = vbYes Then
                DeleteSuppliers(ids)
                ReloadSuppliersTable("")
            End If
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim total As Integer = FieldTotal.Text
        Dim currentBalance As Integer = FieldCurrentBalance.Text

        If RestockComboSupplier.SelectedValue.ToString().Equals("") Then
            MsgBox("You haven't select the supplier for restock", vbOKOnly, "Error")
            Return
        End If

        If total > currentBalance Then
            MsgBox("Not enough balance for this payment", vbOKOnly, "Error")
            Return
        End If

        Try
            AppConnection.Open()

            Dim selectedRows As DataGridViewRowCollection = dgvCartRestock.Rows

            For Each selectedRow As DataGridViewRow In selectedRows
                Dim supplierId As String = RestockComboSupplier.SelectedValue.ToString()
                Dim fruitId As String = selectedRow.Cells.Item("RestockCartFruitID").Value
                Dim qty As String = selectedRow.Cells.Item("RestockCartQty").Value
                Dim subtotal As String = selectedRow.Cells.Item("RestockCartSubtotal").Value
                Dim purchaseDate As String = dtpPurchaseDate.Value.ToString("yyyy-MM-dd")

                SqlQuery = "INSERT INTO Purchase (ID, EmployeeID, SupplierID, FruitID, Qty, Subtotal, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + EmployeeID + "', '" + supplierId + "', '" + fruitId + "', '" + qty + "', '" + subtotal + "', '" + purchaseDate + "', GETDATE());
                                UPDATE Fruit SET Stock += '" + qty + "' WHERE ID='" + fruitId + ";'
                                UPDATE Finance SET CurrentBalance -= '" + subtotal + "'"
                Command = New SqlCommand(SqlQuery, AppConnection.Connection)

                Command.ExecuteNonQuery()
            Next

            MsgBox("Purchase Recorded!")
            ReloadFruitsTableForRestock("")
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
                ComboEmployeeFilterColumn.SelectedIndex = 0
                ReloadEmployeesTable("")
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabFruit)
                ComboFruitFilterColumn.SelectedIndex = 0
                ReloadFruitsTable("")
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabSupplier)
                ComboSupplierFilterColumn.SelectedIndex = 0
                ReloadSuppliersTable("")
                Exit Select
            Case AdminTabs.TabPages.IndexOf(TabRestock)
                LoadSuppliersCombo()
                RestockComboSupplier.SelectedIndex = 0
                ComboFruitRestockFilterColumn.SelectedIndex = 0
                ReloadFruitsTableForRestock("")
                If RestockComboSupplier.SelectedValue.ToString().Equals("") Then
                    MsgBox("You haven't selected a supplier yet, be sure to select it now or later", vbOKOnly, "Error")
                End If
                Exit Select
        End Select
    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        FormReport.Show()
    End Sub

    Private Sub RestockComboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RestockComboSupplier.SelectedIndexChanged
        ReloadFruitsTableForRestock("")
    End Sub

    Private Sub ComboEmployeeFilterColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEmployeeFilterColumn.SelectedIndexChanged, FieldEmployeeFilterQuery.TextChanged
        Dim filterColumn As String = ComboEmployeeFilterColumn.SelectedItem.ToString()
        Dim filterQuery As String = FieldEmployeeFilterQuery.Text

        ReloadEmployeesTable("WHERE " + filterColumn + " LIKE '%" + filterQuery + "%'")
    End Sub

    Private Sub FieldFruitFilterQuery_TextChanged(sender As Object, e As EventArgs) Handles FieldFruitFilterQuery.TextChanged, ComboFruitFilterColumn.SelectedIndexChanged
        Dim filterColumn As String = ComboFruitFilterColumn.SelectedItem.ToString()
        Dim filterQuery As String = FieldFruitFilterQuery.Text

        ReloadFruitsTable("WHERE " + filterColumn + " LIKE '%" + filterQuery + "%'")
    End Sub

    Private Sub FieldSupplierFilterQuery_TextChanged(sender As Object, e As EventArgs) Handles FieldSupplierFilterQuery.TextChanged, ComboSupplierFilterColumn.SelectedIndexChanged
        Dim filterColumn As String = ComboSupplierFilterColumn.SelectedItem.ToString()
        Dim filterQuery As String = FieldSupplierFilterQuery.Text

        ReloadSuppliersTable("WHERE " + filterColumn + " LIKE '%" + filterQuery + "%'")
    End Sub

    Private Sub FieldFruitRestockFilterQuery_TextChanged(sender As Object, e As EventArgs) Handles FieldFruitRestockFilterQuery.TextChanged, ComboFruitRestockFilterColumn.SelectedIndexChanged
        Dim filterColumn As String = ComboFruitRestockFilterColumn.SelectedItem.ToString()
        Dim filterQuery As String = FieldFruitRestockFilterQuery.Text

        ReloadFruitsTableForRestock("AND " + filterColumn + " LIKE '%" + filterQuery + "%'")
    End Sub
End Class