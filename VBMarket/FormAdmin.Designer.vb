<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.labelGreetings = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.AdminTabs = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnFruits = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabEmployees = New System.Windows.Forms.TabPage()
        Me.FieldEmployeeFilterQuery = New System.Windows.Forms.TextBox()
        Me.ComboEmployeeFilterColumn = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDateOfBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveEmployee = New System.Windows.Forms.Button()
        Me.btnEditEmployee = New System.Windows.Forms.Button()
        Me.btnNewEmployee = New System.Windows.Forms.Button()
        Me.TabFruit = New System.Windows.Forms.TabPage()
        Me.FieldFruitFilterQuery = New System.Windows.Forms.TextBox()
        Me.ComboFruitFilterColumn = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvFruits = New System.Windows.Forms.DataGridView()
        Me.FruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitPurchasePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitSellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveFruit = New System.Windows.Forms.Button()
        Me.btnEditFruit = New System.Windows.Forms.Button()
        Me.btnNewFruit = New System.Windows.Forms.Button()
        Me.TabRestock = New System.Windows.Forms.TabPage()
        Me.RestockComboSupplier = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FieldFruitRestockFilterQuery = New System.Windows.Forms.TextBox()
        Me.ComboFruitRestockFilterColumn = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvFruitsRestock = New System.Windows.Forms.DataGridView()
        Me.RestockFruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockFruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockFruitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockFruitStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockFruitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpPurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvCartRestock = New System.Windows.Forms.DataGridView()
        Me.RestockCartFruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockCartFruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockCartFruitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockCartQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockCartPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestockCartSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveFromCart = New System.Windows.Forms.Button()
        Me.FieldTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FieldCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabSupplier = New System.Windows.Forms.TabPage()
        Me.FieldSupplierFilterQuery = New System.Windows.Forms.TextBox()
        Me.ComboSupplierFilterColumn = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteSupplier = New System.Windows.Forms.Button()
        Me.btnEditSupplier = New System.Windows.Forms.Button()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.AdminTabs.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TabEmployees.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFruit.SuspendLayout()
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRestock.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvFruitsRestock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCartRestock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSupplier.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelGreetings
        '
        Me.labelGreetings.AutoSize = True
        Me.labelGreetings.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelGreetings.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labelGreetings.Location = New System.Drawing.Point(6, 13)
        Me.labelGreetings.Name = "labelGreetings"
        Me.labelGreetings.Size = New System.Drawing.Size(280, 45)
        Me.labelGreetings.TabIndex = 0
        Me.labelGreetings.Text = "Welcome, admin!"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 37)
        Me.Panel1.TabIndex = 0
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
        Me.btnProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProfile.BackColor = System.Drawing.Color.Silver
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProfile.Location = New System.Drawing.Point(583, 0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(93, 37)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnLogout.Location = New System.Drawing.Point(682, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 37)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'AdminTabs
        '
        Me.AdminTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdminTabs.Controls.Add(Me.TabHome)
        Me.AdminTabs.Controls.Add(Me.TabEmployees)
        Me.AdminTabs.Controls.Add(Me.TabFruit)
        Me.AdminTabs.Controls.Add(Me.TabRestock)
        Me.AdminTabs.Controls.Add(Me.TabSupplier)
        Me.AdminTabs.Location = New System.Drawing.Point(12, 66)
        Me.AdminTabs.Name = "AdminTabs"
        Me.AdminTabs.SelectedIndex = 0
        Me.AdminTabs.Size = New System.Drawing.Size(779, 413)
        Me.AdminTabs.TabIndex = 1
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.btnRestock)
        Me.TabHome.Controls.Add(Me.btnViewReport)
        Me.TabHome.Controls.Add(Me.btnFruits)
        Me.TabHome.Controls.Add(Me.btnSuppliers)
        Me.TabHome.Controls.Add(Me.btnEmployees)
        Me.TabHome.Controls.Add(Me.Label2)
        Me.TabHome.Controls.Add(Me.labelGreetings)
        Me.TabHome.Location = New System.Drawing.Point(4, 24)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(771, 385)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'btnRestock
        '
        Me.btnRestock.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestock.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRestock.Location = New System.Drawing.Point(182, 160)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(125, 36)
        Me.btnRestock.TabIndex = 2
        Me.btnRestock.Text = "Restock Fruits"
        Me.btnRestock.UseVisualStyleBackColor = False
        '
        'btnViewReport
        '
        Me.btnViewReport.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReport.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnViewReport.Location = New System.Drawing.Point(313, 118)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(125, 36)
        Me.btnViewReport.TabIndex = 2
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.UseVisualStyleBackColor = False
        '
        'btnFruits
        '
        Me.btnFruits.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnFruits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFruits.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnFruits.Location = New System.Drawing.Point(182, 118)
        Me.btnFruits.Name = "btnFruits"
        Me.btnFruits.Size = New System.Drawing.Size(125, 36)
        Me.btnFruits.TabIndex = 2
        Me.btnFruits.Text = "Manage Fruits"
        Me.btnFruits.UseVisualStyleBackColor = False
        '
        'btnSuppliers
        '
        Me.btnSuppliers.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSuppliers.Location = New System.Drawing.Point(15, 160)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(151, 36)
        Me.btnSuppliers.TabIndex = 2
        Me.btnSuppliers.Text = "Manage Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEmployees.Location = New System.Drawing.Point(15, 118)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(151, 36)
        Me.btnEmployees.TabIndex = 2
        Me.btnEmployees.Text = "Manage Employees"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Here's some quick actions for you"
        '
        'TabEmployees
        '
        Me.TabEmployees.Controls.Add(Me.FieldEmployeeFilterQuery)
        Me.TabEmployees.Controls.Add(Me.ComboEmployeeFilterColumn)
        Me.TabEmployees.Controls.Add(Me.Label10)
        Me.TabEmployees.Controls.Add(Me.dgvEmployees)
        Me.TabEmployees.Controls.Add(Me.btnRemoveEmployee)
        Me.TabEmployees.Controls.Add(Me.btnEditEmployee)
        Me.TabEmployees.Controls.Add(Me.btnNewEmployee)
        Me.TabEmployees.Location = New System.Drawing.Point(4, 24)
        Me.TabEmployees.Name = "TabEmployees"
        Me.TabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEmployees.Size = New System.Drawing.Size(771, 385)
        Me.TabEmployees.TabIndex = 1
        Me.TabEmployees.Text = "Employees"
        Me.TabEmployees.UseVisualStyleBackColor = True
        '
        'FieldEmployeeFilterQuery
        '
        Me.FieldEmployeeFilterQuery.Location = New System.Drawing.Point(175, 9)
        Me.FieldEmployeeFilterQuery.Name = "FieldEmployeeFilterQuery"
        Me.FieldEmployeeFilterQuery.Size = New System.Drawing.Size(219, 23)
        Me.FieldEmployeeFilterQuery.TabIndex = 6
        '
        'ComboEmployeeFilterColumn
        '
        Me.ComboEmployeeFilterColumn.FormattingEnabled = True
        Me.ComboEmployeeFilterColumn.Items.AddRange(New Object() {"Name", "Username", "Email", "Address"})
        Me.ComboEmployeeFilterColumn.Location = New System.Drawing.Point(61, 9)
        Me.ComboEmployeeFilterColumn.Name = "ComboEmployeeFilterColumn"
        Me.ComboEmployeeFilterColumn.Size = New System.Drawing.Size(108, 23)
        Me.ComboEmployeeFilterColumn.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Filter By"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.EmployeeUsername, Me.EmployeeEmail, Me.EmployeeAddress, Me.EmployeeDateOfBirth, Me.EmployeeRole})
        Me.dgvEmployees.Location = New System.Drawing.Point(0, 39)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowTemplate.Height = 25
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(743, 263)
        Me.dgvEmployees.TabIndex = 3
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        '
        'EmployeeUsername
        '
        Me.EmployeeUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeUsername.HeaderText = "Username"
        Me.EmployeeUsername.Name = "EmployeeUsername"
        Me.EmployeeUsername.ReadOnly = True
        '
        'EmployeeEmail
        '
        Me.EmployeeEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeEmail.HeaderText = "Email"
        Me.EmployeeEmail.Name = "EmployeeEmail"
        Me.EmployeeEmail.ReadOnly = True
        '
        'EmployeeAddress
        '
        Me.EmployeeAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeAddress.HeaderText = "Address"
        Me.EmployeeAddress.Name = "EmployeeAddress"
        Me.EmployeeAddress.ReadOnly = True
        '
        'EmployeeDateOfBirth
        '
        Me.EmployeeDateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeDateOfBirth.HeaderText = "Date of Birth"
        Me.EmployeeDateOfBirth.Name = "EmployeeDateOfBirth"
        Me.EmployeeDateOfBirth.ReadOnly = True
        '
        'EmployeeRole
        '
        Me.EmployeeRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeRole.HeaderText = "Role"
        Me.EmployeeRole.Name = "EmployeeRole"
        Me.EmployeeRole.ReadOnly = True
        '
        'btnRemoveEmployee
        '
        Me.btnRemoveEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveEmployee.BackColor = System.Drawing.Color.Maroon
        Me.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveEmployee.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemoveEmployee.Location = New System.Drawing.Point(601, 308)
        Me.btnRemoveEmployee.Name = "btnRemoveEmployee"
        Me.btnRemoveEmployee.Size = New System.Drawing.Size(136, 32)
        Me.btnRemoveEmployee.TabIndex = 2
        Me.btnRemoveEmployee.Text = "REMOVE SELECTED"
        Me.btnRemoveEmployee.UseVisualStyleBackColor = False
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditEmployee.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEmployee.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditEmployee.Location = New System.Drawing.Point(478, 308)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(117, 32)
        Me.btnEditEmployee.TabIndex = 2
        Me.btnEditEmployee.Text = "EDIT SELECTED"
        Me.btnEditEmployee.UseVisualStyleBackColor = False
        '
        'btnNewEmployee
        '
        Me.btnNewEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewEmployee.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewEmployee.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnNewEmployee.Location = New System.Drawing.Point(382, 308)
        Me.btnNewEmployee.Name = "btnNewEmployee"
        Me.btnNewEmployee.Size = New System.Drawing.Size(90, 32)
        Me.btnNewEmployee.TabIndex = 2
        Me.btnNewEmployee.Text = "ADD NEW"
        Me.btnNewEmployee.UseVisualStyleBackColor = False
        '
        'TabFruit
        '
        Me.TabFruit.Controls.Add(Me.FieldFruitFilterQuery)
        Me.TabFruit.Controls.Add(Me.ComboFruitFilterColumn)
        Me.TabFruit.Controls.Add(Me.Label11)
        Me.TabFruit.Controls.Add(Me.dgvFruits)
        Me.TabFruit.Controls.Add(Me.btnRemoveFruit)
        Me.TabFruit.Controls.Add(Me.btnEditFruit)
        Me.TabFruit.Controls.Add(Me.btnNewFruit)
        Me.TabFruit.Location = New System.Drawing.Point(4, 24)
        Me.TabFruit.Name = "TabFruit"
        Me.TabFruit.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFruit.Size = New System.Drawing.Size(771, 385)
        Me.TabFruit.TabIndex = 2
        Me.TabFruit.Text = "Fruits"
        Me.TabFruit.UseVisualStyleBackColor = True
        '
        'FieldFruitFilterQuery
        '
        Me.FieldFruitFilterQuery.Location = New System.Drawing.Point(175, 9)
        Me.FieldFruitFilterQuery.Name = "FieldFruitFilterQuery"
        Me.FieldFruitFilterQuery.Size = New System.Drawing.Size(219, 23)
        Me.FieldFruitFilterQuery.TabIndex = 9
        '
        'ComboFruitFilterColumn
        '
        Me.ComboFruitFilterColumn.FormattingEnabled = True
        Me.ComboFruitFilterColumn.Items.AddRange(New Object() {"FruitName", "FruitType", "FruitStock", "Supplier.Name", "PurchasePrice", "SellPrice"})
        Me.ComboFruitFilterColumn.Location = New System.Drawing.Point(61, 9)
        Me.ComboFruitFilterColumn.Name = "ComboFruitFilterColumn"
        Me.ComboFruitFilterColumn.Size = New System.Drawing.Size(108, 23)
        Me.ComboFruitFilterColumn.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Filter By"
        '
        'dgvFruits
        '
        Me.dgvFruits.AllowUserToAddRows = False
        Me.dgvFruits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFruits.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvFruits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFruits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FruitID, Me.FruitName, Me.FruitType, Me.FruitStock, Me.FruitUnit, Me.FruitSupplier, Me.FruitPurchasePrice, Me.FruitSellPrice})
        Me.dgvFruits.Location = New System.Drawing.Point(0, 39)
        Me.dgvFruits.Name = "dgvFruits"
        Me.dgvFruits.ReadOnly = True
        Me.dgvFruits.RowTemplate.Height = 25
        Me.dgvFruits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFruits.Size = New System.Drawing.Size(744, 263)
        Me.dgvFruits.TabIndex = 6
        '
        'FruitID
        '
        Me.FruitID.HeaderText = "ID"
        Me.FruitID.Name = "FruitID"
        Me.FruitID.ReadOnly = True
        Me.FruitID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FruitID.Visible = False
        '
        'FruitName
        '
        Me.FruitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitName.HeaderText = "Fruit Name"
        Me.FruitName.Name = "FruitName"
        Me.FruitName.ReadOnly = True
        '
        'FruitType
        '
        Me.FruitType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitType.HeaderText = "Fruit Type"
        Me.FruitType.Name = "FruitType"
        Me.FruitType.ReadOnly = True
        '
        'FruitStock
        '
        Me.FruitStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitStock.HeaderText = "Stock"
        Me.FruitStock.Name = "FruitStock"
        Me.FruitStock.ReadOnly = True
        '
        'FruitUnit
        '
        Me.FruitUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitUnit.HeaderText = "Unit (hidden)"
        Me.FruitUnit.Name = "FruitUnit"
        Me.FruitUnit.ReadOnly = True
        Me.FruitUnit.Visible = False
        '
        'FruitSupplier
        '
        Me.FruitSupplier.HeaderText = "Unit"
        Me.FruitSupplier.Name = "FruitSupplier"
        Me.FruitSupplier.ReadOnly = True
        '
        'FruitPurchasePrice
        '
        Me.FruitPurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitPurchasePrice.HeaderText = "Purchase"
        Me.FruitPurchasePrice.Name = "FruitPurchasePrice"
        Me.FruitPurchasePrice.ReadOnly = True
        '
        'FruitSellPrice
        '
        Me.FruitSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FruitSellPrice.HeaderText = "Sell"
        Me.FruitSellPrice.Name = "FruitSellPrice"
        Me.FruitSellPrice.ReadOnly = True
        '
        'btnRemoveFruit
        '
        Me.btnRemoveFruit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFruit.BackColor = System.Drawing.Color.Maroon
        Me.btnRemoveFruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFruit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemoveFruit.Location = New System.Drawing.Point(601, 308)
        Me.btnRemoveFruit.Name = "btnRemoveFruit"
        Me.btnRemoveFruit.Size = New System.Drawing.Size(136, 32)
        Me.btnRemoveFruit.TabIndex = 3
        Me.btnRemoveFruit.Text = "REMOVE SELECTED"
        Me.btnRemoveFruit.UseVisualStyleBackColor = False
        '
        'btnEditFruit
        '
        Me.btnEditFruit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditFruit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditFruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditFruit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditFruit.Location = New System.Drawing.Point(478, 308)
        Me.btnEditFruit.Name = "btnEditFruit"
        Me.btnEditFruit.Size = New System.Drawing.Size(117, 32)
        Me.btnEditFruit.TabIndex = 4
        Me.btnEditFruit.Text = "EDIT SELECTED"
        Me.btnEditFruit.UseVisualStyleBackColor = False
        '
        'btnNewFruit
        '
        Me.btnNewFruit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewFruit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNewFruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewFruit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnNewFruit.Location = New System.Drawing.Point(382, 308)
        Me.btnNewFruit.Name = "btnNewFruit"
        Me.btnNewFruit.Size = New System.Drawing.Size(90, 32)
        Me.btnNewFruit.TabIndex = 5
        Me.btnNewFruit.Text = "ADD NEW"
        Me.btnNewFruit.UseVisualStyleBackColor = False
        '
        'TabRestock
        '
        Me.TabRestock.Controls.Add(Me.RestockComboSupplier)
        Me.TabRestock.Controls.Add(Me.SplitContainer1)
        Me.TabRestock.Controls.Add(Me.FieldCurrentBalance)
        Me.TabRestock.Controls.Add(Me.Label8)
        Me.TabRestock.Controls.Add(Me.Label7)
        Me.TabRestock.Location = New System.Drawing.Point(4, 24)
        Me.TabRestock.Name = "TabRestock"
        Me.TabRestock.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRestock.Size = New System.Drawing.Size(771, 385)
        Me.TabRestock.TabIndex = 3
        Me.TabRestock.Text = "Restock"
        Me.TabRestock.UseVisualStyleBackColor = True
        '
        'RestockComboSupplier
        '
        Me.RestockComboSupplier.DisplayMember = "Name"
        Me.RestockComboSupplier.FormattingEnabled = True
        Me.RestockComboSupplier.Location = New System.Drawing.Point(119, 10)
        Me.RestockComboSupplier.Name = "RestockComboSupplier"
        Me.RestockComboSupplier.Size = New System.Drawing.Size(164, 23)
        Me.RestockComboSupplier.TabIndex = 17
        Me.RestockComboSupplier.ValueMember = "ID"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FieldFruitRestockFilterQuery)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboFruitRestockFilterColumn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvFruitsRestock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numQty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddToCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtpPurchaseDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvCartRestock)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRemoveFromCart)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FieldTotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnConfirm)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 346)
        Me.SplitContainer1.SplitterDistance = 382
        Me.SplitContainer1.TabIndex = 2
        '
        'FieldFruitRestockFilterQuery
        '
        Me.FieldFruitRestockFilterQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldFruitRestockFilterQuery.Location = New System.Drawing.Point(230, 5)
        Me.FieldFruitRestockFilterQuery.Name = "FieldFruitRestockFilterQuery"
        Me.FieldFruitRestockFilterQuery.Size = New System.Drawing.Size(149, 23)
        Me.FieldFruitRestockFilterQuery.TabIndex = 16
        '
        'ComboFruitRestockFilterColumn
        '
        Me.ComboFruitRestockFilterColumn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboFruitRestockFilterColumn.FormattingEnabled = True
        Me.ComboFruitRestockFilterColumn.Items.AddRange(New Object() {"FruitName", "FruitType", "Stock", "PurchasePrice"})
        Me.ComboFruitRestockFilterColumn.Location = New System.Drawing.Point(134, 5)
        Me.ComboFruitRestockFilterColumn.Name = "ComboFruitRestockFilterColumn"
        Me.ComboFruitRestockFilterColumn.Size = New System.Drawing.Size(90, 23)
        Me.ComboFruitRestockFilterColumn.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(79, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Filter By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fruits"
        '
        'dgvFruitsRestock
        '
        Me.dgvFruitsRestock.AllowUserToAddRows = False
        Me.dgvFruitsRestock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFruitsRestock.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvFruitsRestock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFruitsRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFruitsRestock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RestockFruitID, Me.RestockFruitName, Me.RestockFruitType, Me.RestockFruitStock, Me.RestockFruitPrice})
        Me.dgvFruitsRestock.Location = New System.Drawing.Point(3, 32)
        Me.dgvFruitsRestock.Name = "dgvFruitsRestock"
        Me.dgvFruitsRestock.ReadOnly = True
        Me.dgvFruitsRestock.RowTemplate.Height = 25
        Me.dgvFruitsRestock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFruitsRestock.Size = New System.Drawing.Size(376, 256)
        Me.dgvFruitsRestock.TabIndex = 7
        '
        'RestockFruitID
        '
        Me.RestockFruitID.HeaderText = "ID"
        Me.RestockFruitID.Name = "RestockFruitID"
        Me.RestockFruitID.ReadOnly = True
        Me.RestockFruitID.Visible = False
        '
        'RestockFruitName
        '
        Me.RestockFruitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RestockFruitName.FillWeight = 200.0!
        Me.RestockFruitName.HeaderText = "Fruit Name"
        Me.RestockFruitName.Name = "RestockFruitName"
        Me.RestockFruitName.ReadOnly = True
        '
        'RestockFruitType
        '
        Me.RestockFruitType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RestockFruitType.FillWeight = 200.0!
        Me.RestockFruitType.HeaderText = "Fruit Type"
        Me.RestockFruitType.Name = "RestockFruitType"
        Me.RestockFruitType.ReadOnly = True
        '
        'RestockFruitStock
        '
        Me.RestockFruitStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RestockFruitStock.HeaderText = "Stock"
        Me.RestockFruitStock.Name = "RestockFruitStock"
        Me.RestockFruitStock.ReadOnly = True
        '
        'RestockFruitPrice
        '
        Me.RestockFruitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RestockFruitPrice.HeaderText = "Price"
        Me.RestockFruitPrice.Name = "RestockFruitPrice"
        Me.RestockFruitPrice.ReadOnly = True
        '
        'numQty
        '
        Me.numQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numQty.Location = New System.Drawing.Point(148, 301)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(120, 23)
        Me.numQty.TabIndex = 10
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToCart.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddToCart.Location = New System.Drawing.Point(274, 294)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(105, 32)
        Me.btnAddToCart.TabIndex = 11
        Me.btnAddToCart.Text = "ADD TO CART"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Qty"
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(94, 301)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(146, 23)
        Me.dtpPurchaseDate.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cart"
        '
        'dgvCartRestock
        '
        Me.dgvCartRestock.AllowUserToAddRows = False
        Me.dgvCartRestock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCartRestock.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvCartRestock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCartRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCartRestock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RestockCartFruitID, Me.RestockCartFruitName, Me.RestockCartFruitType, Me.RestockCartQty, Me.RestockCartPrice, Me.RestockCartSubtotal})
        Me.dgvCartRestock.Location = New System.Drawing.Point(3, 32)
        Me.dgvCartRestock.Name = "dgvCartRestock"
        Me.dgvCartRestock.ReadOnly = True
        Me.dgvCartRestock.RowTemplate.Height = 25
        Me.dgvCartRestock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCartRestock.Size = New System.Drawing.Size(371, 163)
        Me.dgvCartRestock.TabIndex = 8
        '
        'RestockCartFruitID
        '
        Me.RestockCartFruitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartFruitID.HeaderText = "Fruit ID"
        Me.RestockCartFruitID.Name = "RestockCartFruitID"
        Me.RestockCartFruitID.ReadOnly = True
        Me.RestockCartFruitID.Visible = False
        '
        'RestockCartFruitName
        '
        Me.RestockCartFruitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartFruitName.HeaderText = "Fruit Name"
        Me.RestockCartFruitName.Name = "RestockCartFruitName"
        Me.RestockCartFruitName.ReadOnly = True
        Me.RestockCartFruitName.Width = 91
        '
        'RestockCartFruitType
        '
        Me.RestockCartFruitType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartFruitType.HeaderText = "Fruit Type"
        Me.RestockCartFruitType.Name = "RestockCartFruitType"
        Me.RestockCartFruitType.ReadOnly = True
        Me.RestockCartFruitType.Width = 83
        '
        'RestockCartQty
        '
        Me.RestockCartQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartQty.HeaderText = "Qty"
        Me.RestockCartQty.Name = "RestockCartQty"
        Me.RestockCartQty.ReadOnly = True
        Me.RestockCartQty.Width = 51
        '
        'RestockCartPrice
        '
        Me.RestockCartPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartPrice.HeaderText = "Price"
        Me.RestockCartPrice.Name = "RestockCartPrice"
        Me.RestockCartPrice.ReadOnly = True
        Me.RestockCartPrice.Width = 58
        '
        'RestockCartSubtotal
        '
        Me.RestockCartSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RestockCartSubtotal.HeaderText = "Subtotal"
        Me.RestockCartSubtotal.Name = "RestockCartSubtotal"
        Me.RestockCartSubtotal.ReadOnly = True
        Me.RestockCartSubtotal.Width = 76
        '
        'btnRemoveFromCart
        '
        Me.btnRemoveFromCart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFromCart.BackColor = System.Drawing.Color.DarkRed
        Me.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFromCart.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRemoveFromCart.Location = New System.Drawing.Point(218, 201)
        Me.btnRemoveFromCart.Name = "btnRemoveFromCart"
        Me.btnRemoveFromCart.Size = New System.Drawing.Size(156, 32)
        Me.btnRemoveFromCart.TabIndex = 11
        Me.btnRemoveFromCart.Text = "REMOVE FROM CART"
        Me.btnRemoveFromCart.UseVisualStyleBackColor = False
        '
        'FieldTotal
        '
        Me.FieldTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FieldTotal.Location = New System.Drawing.Point(3, 255)
        Me.FieldTotal.Name = "FieldTotal"
        Me.FieldTotal.ReadOnly = True
        Me.FieldTotal.Size = New System.Drawing.Size(350, 23)
        Me.FieldTotal.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Purchase Date"
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnConfirm.Location = New System.Drawing.Point(269, 294)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(105, 32)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total"
        '
        'FieldCurrentBalance
        '
        Me.FieldCurrentBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldCurrentBalance.Location = New System.Drawing.Point(604, 10)
        Me.FieldCurrentBalance.Name = "FieldCurrentBalance"
        Me.FieldCurrentBalance.ReadOnly = True
        Me.FieldCurrentBalance.Size = New System.Drawing.Size(149, 23)
        Me.FieldCurrentBalance.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(496, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Current Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Supplier Unit"
        '
        'TabSupplier
        '
        Me.TabSupplier.Controls.Add(Me.FieldSupplierFilterQuery)
        Me.TabSupplier.Controls.Add(Me.ComboSupplierFilterColumn)
        Me.TabSupplier.Controls.Add(Me.Label12)
        Me.TabSupplier.Controls.Add(Me.dgvSuppliers)
        Me.TabSupplier.Controls.Add(Me.btnDeleteSupplier)
        Me.TabSupplier.Controls.Add(Me.btnEditSupplier)
        Me.TabSupplier.Controls.Add(Me.btnNewSupplier)
        Me.TabSupplier.Location = New System.Drawing.Point(4, 24)
        Me.TabSupplier.Name = "TabSupplier"
        Me.TabSupplier.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSupplier.Size = New System.Drawing.Size(771, 385)
        Me.TabSupplier.TabIndex = 4
        Me.TabSupplier.Text = "Suppliers"
        Me.TabSupplier.UseVisualStyleBackColor = True
        '
        'FieldSupplierFilterQuery
        '
        Me.FieldSupplierFilterQuery.Location = New System.Drawing.Point(172, 8)
        Me.FieldSupplierFilterQuery.Name = "FieldSupplierFilterQuery"
        Me.FieldSupplierFilterQuery.Size = New System.Drawing.Size(219, 23)
        Me.FieldSupplierFilterQuery.TabIndex = 9
        '
        'ComboSupplierFilterColumn
        '
        Me.ComboSupplierFilterColumn.FormattingEnabled = True
        Me.ComboSupplierFilterColumn.Items.AddRange(New Object() {"Name", "Email", "Phone", "Address"})
        Me.ComboSupplierFilterColumn.Location = New System.Drawing.Point(58, 8)
        Me.ComboSupplierFilterColumn.Name = "ComboSupplierFilterColumn"
        Me.ComboSupplierFilterColumn.Size = New System.Drawing.Size(108, 23)
        Me.ComboSupplierFilterColumn.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Filter By"
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierID, Me.SupplierName, Me.SupplierEmail, Me.SupplierPhone, Me.SupplierAddress})
        Me.dgvSuppliers.Location = New System.Drawing.Point(0, 38)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowTemplate.Height = 25
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.Size = New System.Drawing.Size(580, 308)
        Me.dgvSuppliers.TabIndex = 0
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "ID"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.ReadOnly = True
        Me.SupplierID.Visible = False
        '
        'SupplierName
        '
        Me.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierName.HeaderText = "Name"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.ReadOnly = True
        '
        'SupplierEmail
        '
        Me.SupplierEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierEmail.HeaderText = "Email"
        Me.SupplierEmail.Name = "SupplierEmail"
        Me.SupplierEmail.ReadOnly = True
        '
        'SupplierPhone
        '
        Me.SupplierPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierPhone.HeaderText = "Phone"
        Me.SupplierPhone.Name = "SupplierPhone"
        Me.SupplierPhone.ReadOnly = True
        '
        'SupplierAddress
        '
        Me.SupplierAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierAddress.HeaderText = "Address"
        Me.SupplierAddress.Name = "SupplierAddress"
        Me.SupplierAddress.ReadOnly = True
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteSupplier.BackColor = System.Drawing.Color.DarkRed
        Me.btnDeleteSupplier.FlatAppearance.BorderSize = 0
        Me.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSupplier.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(608, 84)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(128, 33)
        Me.btnDeleteSupplier.TabIndex = 1
        Me.btnDeleteSupplier.Text = "DELETE SUPPLIER"
        Me.btnDeleteSupplier.UseVisualStyleBackColor = False
        '
        'btnEditSupplier
        '
        Me.btnEditSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditSupplier.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditSupplier.FlatAppearance.BorderSize = 0
        Me.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSupplier.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnEditSupplier.Location = New System.Drawing.Point(608, 45)
        Me.btnEditSupplier.Name = "btnEditSupplier"
        Me.btnEditSupplier.Size = New System.Drawing.Size(128, 33)
        Me.btnEditSupplier.TabIndex = 1
        Me.btnEditSupplier.Text = "EDIT SUPPLIER"
        Me.btnEditSupplier.UseVisualStyleBackColor = False
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewSupplier.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnNewSupplier.FlatAppearance.BorderSize = 0
        Me.btnNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSupplier.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNewSupplier.Location = New System.Drawing.Point(608, 6)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(128, 33)
        Me.btnNewSupplier.TabIndex = 1
        Me.btnNewSupplier.Text = "NEW SUPPLIER"
        Me.btnNewSupplier.UseVisualStyleBackColor = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.AdminTabs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB MARKET Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AdminTabs.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        Me.TabEmployees.ResumeLayout(False)
        Me.TabEmployees.PerformLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFruit.ResumeLayout(False)
        Me.TabFruit.PerformLayout()
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRestock.ResumeLayout(False)
        Me.TabRestock.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvFruitsRestock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCartRestock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSupplier.ResumeLayout(False)
        Me.TabSupplier.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelGreetings As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents AdminTabs As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabEmployees As TabPage
    Friend WithEvents btnNewEmployee As Button
    Friend WithEvents btnEditEmployee As Button
    Friend WithEvents btnRemoveEmployee As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabFruit As TabPage
    Friend WithEvents btnFruits As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnRemoveFruit As Button
    Friend WithEvents btnEditFruit As Button
    Friend WithEvents btnNewFruit As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents dgvFruits As DataGridView
    Friend WithEvents btnProfile As Button
    Friend WithEvents TabSupplier As TabPage
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents btnDeleteSupplier As Button
    Friend WithEvents btnEditSupplier As Button
    Friend WithEvents btnNewSupplier As Button
    Friend WithEvents btnRestock As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnViewReport As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabRestock As TabPage
    Friend WithEvents RestockComboSupplier As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvFruitsRestock As DataGridView
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPurchaseDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvCartRestock As DataGridView
    Friend WithEvents btnRemoveFromCart As Button
    Friend WithEvents FieldTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents FieldCurrentBalance As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmail As DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhone As DataGridViewTextBoxColumn
    Friend WithEvents SupplierAddress As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeUsername As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmail As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAddress As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeRole As DataGridViewTextBoxColumn
    Friend WithEvents RestockFruitID As DataGridViewTextBoxColumn
    Friend WithEvents RestockFruitName As DataGridViewTextBoxColumn
    Friend WithEvents RestockFruitType As DataGridViewTextBoxColumn
    Friend WithEvents RestockFruitStock As DataGridViewTextBoxColumn
    Friend WithEvents RestockFruitPrice As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartFruitID As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartFruitName As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartFruitType As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartQty As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartPrice As DataGridViewTextBoxColumn
    Friend WithEvents RestockCartSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents FieldEmployeeFilterQuery As TextBox
    Friend WithEvents ComboEmployeeFilterColumn As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FieldFruitFilterQuery As TextBox
    Friend WithEvents ComboFruitFilterColumn As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FieldSupplierFilterQuery As TextBox
    Friend WithEvents ComboSupplierFilterColumn As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FieldFruitRestockFilterQuery As TextBox
    Friend WithEvents ComboFruitRestockFilterColumn As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FruitID As DataGridViewTextBoxColumn
    Friend WithEvents FruitName As DataGridViewTextBoxColumn
    Friend WithEvents FruitType As DataGridViewTextBoxColumn
    Friend WithEvents FruitStock As DataGridViewTextBoxColumn
    Friend WithEvents FruitUnit As DataGridViewTextBoxColumn
    Friend WithEvents FruitSupplier As DataGridViewTextBoxColumn
    Friend WithEvents FruitPurchasePrice As DataGridViewTextBoxColumn
    Friend WithEvents FruitSellPrice As DataGridViewTextBoxColumn
End Class
