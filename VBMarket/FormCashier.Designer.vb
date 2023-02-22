<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.CashierTabs = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.btnSellFruits = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelGreetings = New System.Windows.Forms.Label()
        Me.TabCustomers = New System.Windows.Forms.TabPage()
        Me.btnRemoveCustomer = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.btnToSales = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDebt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabSales = New System.Windows.Forms.TabPage()
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnToDebt = New System.Windows.Forms.Button()
        Me.btnRemoveFromCart = New System.Windows.Forms.Button()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.dgvFruits = New System.Windows.Forms.DataGridView()
        Me.FruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.CartFruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartFruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FieldChanges = New System.Windows.Forms.TextBox()
        Me.FieldCustomerPhone = New System.Windows.Forms.TextBox()
        Me.FieldPayment = New System.Windows.Forms.TextBox()
        Me.FieldCustomerName = New System.Windows.Forms.TextBox()
        Me.FieldTotal = New System.Windows.Forms.TextBox()
        Me.FieldCustomerID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.CashierTabs.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TabCustomers.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSales.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 37)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VB MARKET"
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.Silver
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProfile.Location = New System.Drawing.Point(455, 0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(93, 37)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnLogout.Location = New System.Drawing.Point(554, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 37)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'CashierTabs
        '
        Me.CashierTabs.Controls.Add(Me.TabHome)
        Me.CashierTabs.Controls.Add(Me.TabCustomers)
        Me.CashierTabs.Controls.Add(Me.TabSales)
        Me.CashierTabs.Location = New System.Drawing.Point(12, 75)
        Me.CashierTabs.Name = "CashierTabs"
        Me.CashierTabs.SelectedIndex = 0
        Me.CashierTabs.Size = New System.Drawing.Size(650, 525)
        Me.CashierTabs.TabIndex = 2
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.btnSellFruits)
        Me.TabHome.Controls.Add(Me.btnCustomers)
        Me.TabHome.Controls.Add(Me.Label2)
        Me.TabHome.Controls.Add(Me.labelGreetings)
        Me.TabHome.Location = New System.Drawing.Point(4, 24)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(642, 497)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'btnSellFruits
        '
        Me.btnSellFruits.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSellFruits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellFruits.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSellFruits.Location = New System.Drawing.Point(182, 129)
        Me.btnSellFruits.Name = "btnSellFruits"
        Me.btnSellFruits.Size = New System.Drawing.Size(101, 36)
        Me.btnSellFruits.TabIndex = 9
        Me.btnSellFruits.Text = "Sell Fruits"
        Me.btnSellFruits.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomers.Location = New System.Drawing.Point(15, 129)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(151, 36)
        Me.btnCustomers.TabIndex = 10
        Me.btnCustomers.Text = "Manage Customers"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Here's some quick actions for you"
        '
        'labelGreetings
        '
        Me.labelGreetings.AutoSize = True
        Me.labelGreetings.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelGreetings.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labelGreetings.Location = New System.Drawing.Point(6, 24)
        Me.labelGreetings.Name = "labelGreetings"
        Me.labelGreetings.Size = New System.Drawing.Size(290, 45)
        Me.labelGreetings.TabIndex = 7
        Me.labelGreetings.Text = "Welcome, cashier!"
        '
        'TabCustomers
        '
        Me.TabCustomers.Controls.Add(Me.btnRemoveCustomer)
        Me.TabCustomers.Controls.Add(Me.btnEditCustomer)
        Me.TabCustomers.Controls.Add(Me.btnToSales)
        Me.TabCustomers.Controls.Add(Me.btnNewCustomer)
        Me.TabCustomers.Controls.Add(Me.dgvCustomers)
        Me.TabCustomers.Location = New System.Drawing.Point(4, 24)
        Me.TabCustomers.Name = "TabCustomers"
        Me.TabCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCustomers.Size = New System.Drawing.Size(642, 497)
        Me.TabCustomers.TabIndex = 1
        Me.TabCustomers.Text = "Customers"
        Me.TabCustomers.UseVisualStyleBackColor = True
        '
        'btnRemoveCustomer
        '
        Me.btnRemoveCustomer.BackColor = System.Drawing.Color.Maroon
        Me.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemoveCustomer.Location = New System.Drawing.Point(500, 459)
        Me.btnRemoveCustomer.Name = "btnRemoveCustomer"
        Me.btnRemoveCustomer.Size = New System.Drawing.Size(136, 32)
        Me.btnRemoveCustomer.TabIndex = 3
        Me.btnRemoveCustomer.Text = "REMOVE SELECTED"
        Me.btnRemoveCustomer.UseVisualStyleBackColor = False
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditCustomer.Location = New System.Drawing.Point(377, 459)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(117, 32)
        Me.btnEditCustomer.TabIndex = 4
        Me.btnEditCustomer.Text = "EDIT SELECTED"
        Me.btnEditCustomer.UseVisualStyleBackColor = False
        '
        'btnToSales
        '
        Me.btnToSales.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnToSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToSales.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnToSales.Location = New System.Drawing.Point(8, 459)
        Me.btnToSales.Name = "btnToSales"
        Me.btnToSales.Size = New System.Drawing.Size(104, 32)
        Me.btnToSales.TabIndex = 5
        Me.btnToSales.Text = "GO TO SALES"
        Me.btnToSales.UseVisualStyleBackColor = False
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnNewCustomer.Location = New System.Drawing.Point(281, 459)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(90, 32)
        Me.btnNewCustomer.TabIndex = 5
        Me.btnNewCustomer.Text = "ADD NEW"
        Me.btnNewCustomer.UseVisualStyleBackColor = False
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerID, Me.CustomerName, Me.CustomerEmail, Me.CustomerPhone, Me.CustomerAddress, Me.CustomerDebt})
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowTemplate.Height = 25
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(643, 453)
        Me.dgvCustomers.TabIndex = 0
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "ID"
        Me.CustomerID.Name = "CustomerID"
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Name"
        Me.CustomerName.Name = "CustomerName"
        '
        'CustomerEmail
        '
        Me.CustomerEmail.HeaderText = "Email"
        Me.CustomerEmail.Name = "CustomerEmail"
        '
        'CustomerPhone
        '
        Me.CustomerPhone.HeaderText = "Phone"
        Me.CustomerPhone.Name = "CustomerPhone"
        '
        'CustomerAddress
        '
        Me.CustomerAddress.HeaderText = "Address"
        Me.CustomerAddress.Name = "CustomerAddress"
        '
        'CustomerDebt
        '
        Me.CustomerDebt.HeaderText = "Debt"
        Me.CustomerDebt.Name = "CustomerDebt"
        '
        'TabSales
        '
        Me.TabSales.Controls.Add(Me.dtpSaleDate)
        Me.TabSales.Controls.Add(Me.numQty)
        Me.TabSales.Controls.Add(Me.Label8)
        Me.TabSales.Controls.Add(Me.btnCancel)
        Me.TabSales.Controls.Add(Me.btnConfirm)
        Me.TabSales.Controls.Add(Me.btnToDebt)
        Me.TabSales.Controls.Add(Me.btnRemoveFromCart)
        Me.TabSales.Controls.Add(Me.btnAddToCart)
        Me.TabSales.Controls.Add(Me.dgvFruits)
        Me.TabSales.Controls.Add(Me.dgvCart)
        Me.TabSales.Controls.Add(Me.FieldChanges)
        Me.TabSales.Controls.Add(Me.FieldCustomerPhone)
        Me.TabSales.Controls.Add(Me.FieldPayment)
        Me.TabSales.Controls.Add(Me.FieldCustomerName)
        Me.TabSales.Controls.Add(Me.FieldTotal)
        Me.TabSales.Controls.Add(Me.FieldCustomerID)
        Me.TabSales.Controls.Add(Me.Label7)
        Me.TabSales.Controls.Add(Me.Label11)
        Me.TabSales.Controls.Add(Me.Label12)
        Me.TabSales.Controls.Add(Me.Label5)
        Me.TabSales.Controls.Add(Me.Label10)
        Me.TabSales.Controls.Add(Me.Label4)
        Me.TabSales.Controls.Add(Me.Label6)
        Me.TabSales.Controls.Add(Me.Label9)
        Me.TabSales.Controls.Add(Me.Label3)
        Me.TabSales.Location = New System.Drawing.Point(4, 24)
        Me.TabSales.Name = "TabSales"
        Me.TabSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSales.Size = New System.Drawing.Size(642, 497)
        Me.TabSales.TabIndex = 2
        Me.TabSales.Text = "Sales"
        Me.TabSales.UseVisualStyleBackColor = True
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSaleDate.Location = New System.Drawing.Point(6, 468)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(141, 23)
        Me.dtpSaleDate.TabIndex = 9
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(42, 233)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(156, 23)
        Me.numQty.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Qty"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(388, 459)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 32)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnConfirm.Location = New System.Drawing.Point(518, 459)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(110, 32)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnToDebt
        '
        Me.btnToDebt.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnToDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToDebt.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnToDebt.Location = New System.Drawing.Point(518, 405)
        Me.btnToDebt.Name = "btnToDebt"
        Me.btnToDebt.Size = New System.Drawing.Size(110, 32)
        Me.btnToDebt.TabIndex = 6
        Me.btnToDebt.Text = "TO DEBT"
        Me.btnToDebt.UseVisualStyleBackColor = False
        '
        'btnRemoveFromCart
        '
        Me.btnRemoveFromCart.BackColor = System.Drawing.Color.DarkRed
        Me.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFromCart.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemoveFromCart.Location = New System.Drawing.Point(493, 228)
        Me.btnRemoveFromCart.Name = "btnRemoveFromCart"
        Me.btnRemoveFromCart.Size = New System.Drawing.Size(143, 32)
        Me.btnRemoveFromCart.TabIndex = 4
        Me.btnRemoveFromCart.Text = "REMOVE FROM CART"
        Me.btnRemoveFromCart.UseVisualStyleBackColor = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddToCart.Location = New System.Drawing.Point(204, 227)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(110, 32)
        Me.btnAddToCart.TabIndex = 2
        Me.btnAddToCart.Text = "ADD TO CART"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'dgvFruits
        '
        Me.dgvFruits.AllowUserToAddRows = False
        Me.dgvFruits.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvFruits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFruits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FruitID, Me.FruitName, Me.FruitType, Me.SellPrice})
        Me.dgvFruits.Location = New System.Drawing.Point(6, 40)
        Me.dgvFruits.Name = "dgvFruits"
        Me.dgvFruits.RowTemplate.Height = 25
        Me.dgvFruits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFruits.Size = New System.Drawing.Size(308, 181)
        Me.dgvFruits.TabIndex = 0
        '
        'FruitID
        '
        Me.FruitID.HeaderText = "ID"
        Me.FruitID.Name = "FruitID"
        '
        'FruitName
        '
        Me.FruitName.HeaderText = "Name"
        Me.FruitName.Name = "FruitName"
        '
        'FruitType
        '
        Me.FruitType.HeaderText = "Type"
        Me.FruitType.Name = "FruitType"
        '
        'SellPrice
        '
        Me.SellPrice.HeaderText = "Price"
        Me.SellPrice.Name = "SellPrice"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartFruitID, Me.CartFruitName, Me.CartQty, Me.CartPrice, Me.CartSubtotal})
        Me.dgvCart.Location = New System.Drawing.Point(334, 40)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowTemplate.Height = 25
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(302, 181)
        Me.dgvCart.TabIndex = 3
        '
        'CartFruitID
        '
        Me.CartFruitID.HeaderText = "Fruit ID"
        Me.CartFruitID.Name = "CartFruitID"
        '
        'CartFruitName
        '
        Me.CartFruitName.HeaderText = "Name"
        Me.CartFruitName.Name = "CartFruitName"
        '
        'CartQty
        '
        Me.CartQty.HeaderText = "Qty"
        Me.CartQty.Name = "CartQty"
        '
        'CartPrice
        '
        Me.CartPrice.HeaderText = "Price"
        Me.CartPrice.Name = "CartPrice"
        '
        'CartSubtotal
        '
        Me.CartSubtotal.HeaderText = "Subtotal"
        Me.CartSubtotal.Name = "CartSubtotal"
        '
        'FieldChanges
        '
        Me.FieldChanges.Location = New System.Drawing.Point(334, 411)
        Me.FieldChanges.Name = "FieldChanges"
        Me.FieldChanges.ReadOnly = True
        Me.FieldChanges.Size = New System.Drawing.Size(178, 23)
        Me.FieldChanges.TabIndex = 1
        '
        'FieldCustomerPhone
        '
        Me.FieldCustomerPhone.Location = New System.Drawing.Point(6, 411)
        Me.FieldCustomerPhone.Name = "FieldCustomerPhone"
        Me.FieldCustomerPhone.ReadOnly = True
        Me.FieldCustomerPhone.Size = New System.Drawing.Size(308, 23)
        Me.FieldCustomerPhone.TabIndex = 1
        '
        'FieldPayment
        '
        Me.FieldPayment.Location = New System.Drawing.Point(334, 353)
        Me.FieldPayment.Name = "FieldPayment"
        Me.FieldPayment.Size = New System.Drawing.Size(294, 23)
        Me.FieldPayment.TabIndex = 5
        '
        'FieldCustomerName
        '
        Me.FieldCustomerName.Location = New System.Drawing.Point(6, 353)
        Me.FieldCustomerName.Name = "FieldCustomerName"
        Me.FieldCustomerName.ReadOnly = True
        Me.FieldCustomerName.Size = New System.Drawing.Size(308, 23)
        Me.FieldCustomerName.TabIndex = 1
        '
        'FieldTotal
        '
        Me.FieldTotal.Location = New System.Drawing.Point(334, 295)
        Me.FieldTotal.Name = "FieldTotal"
        Me.FieldTotal.ReadOnly = True
        Me.FieldTotal.Size = New System.Drawing.Size(294, 23)
        Me.FieldTotal.TabIndex = 1
        Me.FieldTotal.Text = "0"
        '
        'FieldCustomerID
        '
        Me.FieldCustomerID.Location = New System.Drawing.Point(6, 295)
        Me.FieldCustomerID.Name = "FieldCustomerID"
        Me.FieldCustomerID.ReadOnly = True
        Me.FieldCustomerID.Size = New System.Drawing.Size(308, 23)
        Me.FieldCustomerID.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fruits"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(334, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Changes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sale Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Customer Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cart"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(334, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer ID"
        '
        'FormCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 612)
        Me.Controls.Add(Me.CashierTabs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Market Cashier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CashierTabs.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        Me.TabCustomers.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSales.ResumeLayout(False)
        Me.TabSales.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents CashierTabs As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabCustomers As TabPage
    Friend WithEvents TabSales As TabPage
    Friend WithEvents btnSellFruits As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents labelGreetings As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnRemoveCustomer As Button
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmail As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhone As DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddress As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDebt As DataGridViewTextBoxColumn
    Friend WithEvents btnToSales As Button
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents FieldCustomerPhone As TextBox
    Friend WithEvents FieldCustomerName As TextBox
    Friend WithEvents FieldCustomerID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvFruits As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnToDebt As Button
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents FieldChanges As TextBox
    Friend WithEvents FieldPayment As TextBox
    Friend WithEvents FieldTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FruitID As DataGridViewTextBoxColumn
    Friend WithEvents FruitName As DataGridViewTextBoxColumn
    Friend WithEvents FruitType As DataGridViewTextBoxColumn
    Friend WithEvents SellPrice As DataGridViewTextBoxColumn
    Friend WithEvents CartFruitID As DataGridViewTextBoxColumn
    Friend WithEvents CartFruitName As DataGridViewTextBoxColumn
    Friend WithEvents CartQty As DataGridViewTextBoxColumn
    Friend WithEvents CartPrice As DataGridViewTextBoxColumn
    Friend WithEvents CartSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveFromCart As Button
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents Label12 As Label
End Class
