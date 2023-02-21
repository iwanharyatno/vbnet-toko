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
        Me.btnFruits = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabEmployees = New System.Windows.Forms.TabPage()
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
        Me.dgvFruits = New System.Windows.Forms.DataGridView()
        Me.FruitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitPurchasePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FruitSellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveFruit = New System.Windows.Forms.Button()
        Me.btnEditFruit = New System.Windows.Forms.Button()
        Me.btnNewFruit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.AdminTabs.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TabEmployees.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFruit.SuspendLayout()
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 37)
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
        Me.btnProfile.BackColor = System.Drawing.Color.Silver
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProfile.Location = New System.Drawing.Point(555, 0)
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
        Me.btnLogout.Location = New System.Drawing.Point(654, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 37)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'AdminTabs
        '
        Me.AdminTabs.Controls.Add(Me.TabHome)
        Me.AdminTabs.Controls.Add(Me.TabEmployees)
        Me.AdminTabs.Controls.Add(Me.TabFruit)
        Me.AdminTabs.Location = New System.Drawing.Point(12, 66)
        Me.AdminTabs.Name = "AdminTabs"
        Me.AdminTabs.SelectedIndex = 0
        Me.AdminTabs.Size = New System.Drawing.Size(751, 377)
        Me.AdminTabs.TabIndex = 1
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.btnFruits)
        Me.TabHome.Controls.Add(Me.btnEmployees)
        Me.TabHome.Controls.Add(Me.Label2)
        Me.TabHome.Controls.Add(Me.labelGreetings)
        Me.TabHome.Location = New System.Drawing.Point(4, 24)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(743, 349)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
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
        Me.TabEmployees.Controls.Add(Me.dgvEmployees)
        Me.TabEmployees.Controls.Add(Me.btnRemoveEmployee)
        Me.TabEmployees.Controls.Add(Me.btnEditEmployee)
        Me.TabEmployees.Controls.Add(Me.btnNewEmployee)
        Me.TabEmployees.Location = New System.Drawing.Point(4, 24)
        Me.TabEmployees.Name = "TabEmployees"
        Me.TabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEmployees.Size = New System.Drawing.Size(743, 349)
        Me.TabEmployees.TabIndex = 1
        Me.TabEmployees.Text = "Employees"
        Me.TabEmployees.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.EmployeeUsername, Me.EmployeeEmail, Me.EmployeeAddress, Me.EmployeeDateOfBirth, Me.EmployeeRole})
        Me.dgvEmployees.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.RowTemplate.Height = 25
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(743, 302)
        Me.dgvEmployees.TabIndex = 3
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.Name = "EmployeeName"
        '
        'EmployeeUsername
        '
        Me.EmployeeUsername.HeaderText = "Username"
        Me.EmployeeUsername.Name = "EmployeeUsername"
        '
        'EmployeeEmail
        '
        Me.EmployeeEmail.HeaderText = "Email"
        Me.EmployeeEmail.Name = "EmployeeEmail"
        '
        'EmployeeAddress
        '
        Me.EmployeeAddress.HeaderText = "Address"
        Me.EmployeeAddress.Name = "EmployeeAddress"
        '
        'EmployeeDateOfBirth
        '
        Me.EmployeeDateOfBirth.HeaderText = "Date of Birth"
        Me.EmployeeDateOfBirth.Name = "EmployeeDateOfBirth"
        '
        'EmployeeRole
        '
        Me.EmployeeRole.HeaderText = "Role"
        Me.EmployeeRole.Name = "EmployeeRole"
        '
        'btnRemoveEmployee
        '
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
        Me.TabFruit.Controls.Add(Me.dgvFruits)
        Me.TabFruit.Controls.Add(Me.btnRemoveFruit)
        Me.TabFruit.Controls.Add(Me.btnEditFruit)
        Me.TabFruit.Controls.Add(Me.btnNewFruit)
        Me.TabFruit.Location = New System.Drawing.Point(4, 24)
        Me.TabFruit.Name = "TabFruit"
        Me.TabFruit.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFruit.Size = New System.Drawing.Size(743, 349)
        Me.TabFruit.TabIndex = 2
        Me.TabFruit.Text = "Fruits"
        Me.TabFruit.UseVisualStyleBackColor = True
        '
        'dgvFruits
        '
        Me.dgvFruits.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvFruits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFruits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FruitID, Me.FruitName, Me.FruitType, Me.FruitStock, Me.FruitUnit, Me.FruitPurchasePrice, Me.FruitSellPrice})
        Me.dgvFruits.Location = New System.Drawing.Point(0, 0)
        Me.dgvFruits.Name = "dgvFruits"
        Me.dgvFruits.RowTemplate.Height = 25
        Me.dgvFruits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFruits.Size = New System.Drawing.Size(744, 302)
        Me.dgvFruits.TabIndex = 6
        '
        'FruitID
        '
        Me.FruitID.HeaderText = "ID"
        Me.FruitID.Name = "FruitID"
        '
        'FruitName
        '
        Me.FruitName.HeaderText = "Fruit Name"
        Me.FruitName.Name = "FruitName"
        '
        'FruitType
        '
        Me.FruitType.HeaderText = "Fruit Type"
        Me.FruitType.Name = "FruitType"
        '
        'FruitStock
        '
        Me.FruitStock.HeaderText = "Stock"
        Me.FruitStock.Name = "FruitStock"
        '
        'FruitUnit
        '
        Me.FruitUnit.HeaderText = "Unit"
        Me.FruitUnit.Name = "FruitUnit"
        '
        'FruitPurchasePrice
        '
        Me.FruitPurchasePrice.HeaderText = "Purchase"
        Me.FruitPurchasePrice.Name = "FruitPurchasePrice"
        '
        'FruitSellPrice
        '
        Me.FruitSellPrice.HeaderText = "Sell"
        Me.FruitSellPrice.Name = "FruitSellPrice"
        '
        'btnRemoveFruit
        '
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
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 455)
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
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFruit.ResumeLayout(False)
        CType(Me.dgvFruits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelGreetings As Label
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeUsername As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmail As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAddress As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeRole As DataGridViewTextBoxColumn
    Friend WithEvents FruitID As DataGridViewTextBoxColumn
    Friend WithEvents FruitName As DataGridViewTextBoxColumn
    Friend WithEvents FruitType As DataGridViewTextBoxColumn
    Friend WithEvents FruitStock As DataGridViewTextBoxColumn
    Friend WithEvents FruitUnit As DataGridViewTextBoxColumn
    Friend WithEvents FruitPurchasePrice As DataGridViewTextBoxColumn
    Friend WithEvents FruitSellPrice As DataGridViewTextBoxColumn
    Friend WithEvents btnProfile As Button
End Class
