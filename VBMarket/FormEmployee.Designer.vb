<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FieldName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FieldUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FieldPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FieldConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FieldEmail = New System.Windows.Forms.TextBox()
        Me.FieldAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FieldRole = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.CheckShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'FieldName
        '
        Me.FieldName.Location = New System.Drawing.Point(16, 43)
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Size = New System.Drawing.Size(248, 23)
        Me.FieldName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'FieldUsername
        '
        Me.FieldUsername.Location = New System.Drawing.Point(16, 109)
        Me.FieldUsername.Name = "FieldUsername"
        Me.FieldUsername.Size = New System.Drawing.Size(248, 23)
        Me.FieldUsername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'FieldPassword
        '
        Me.FieldPassword.Location = New System.Drawing.Point(16, 244)
        Me.FieldPassword.Name = "FieldPassword"
        Me.FieldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.FieldPassword.Size = New System.Drawing.Size(248, 23)
        Me.FieldPassword.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Confirm Password"
        '
        'FieldConfirmPassword
        '
        Me.FieldConfirmPassword.Location = New System.Drawing.Point(16, 321)
        Me.FieldConfirmPassword.Name = "FieldConfirmPassword"
        Me.FieldConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.FieldConfirmPassword.Size = New System.Drawing.Size(248, 23)
        Me.FieldConfirmPassword.TabIndex = 4
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCreate.Location = New System.Drawing.Point(446, 315)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 32)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(285, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(282, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Email"
        '
        'FieldEmail
        '
        Me.FieldEmail.Location = New System.Drawing.Point(16, 178)
        Me.FieldEmail.Name = "FieldEmail"
        Me.FieldEmail.Size = New System.Drawing.Size(248, 23)
        Me.FieldEmail.TabIndex = 2
        '
        'FieldAddress
        '
        Me.FieldAddress.Location = New System.Drawing.Point(285, 43)
        Me.FieldAddress.Multiline = True
        Me.FieldAddress.Name = "FieldAddress"
        Me.FieldAddress.Size = New System.Drawing.Size(261, 89)
        Me.FieldAddress.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(282, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Role"
        '
        'FieldRole
        '
        Me.FieldRole.Location = New System.Drawing.Point(285, 178)
        Me.FieldRole.Name = "FieldRole"
        Me.FieldRole.Size = New System.Drawing.Size(263, 23)
        Me.FieldRole.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(280, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Date of Birth"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "yyyy-MM-dd"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(285, 244)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(261, 23)
        Me.dtpDOB.TabIndex = 8
        '
        'CheckShowPassword
        '
        Me.CheckShowPassword.AutoSize = True
        Me.CheckShowPassword.Location = New System.Drawing.Point(16, 361)
        Me.CheckShowPassword.Name = "CheckShowPassword"
        Me.CheckShowPassword.Size = New System.Drawing.Size(108, 19)
        Me.CheckShowPassword.TabIndex = 5
        Me.CheckShowPassword.Text = "Show Password"
        Me.CheckShowPassword.UseVisualStyleBackColor = True
        '
        'InputEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 392)
        Me.Controls.Add(Me.CheckShowPassword)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.FieldAddress)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.FieldConfirmPassword)
        Me.Controls.Add(Me.FieldPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FieldRole)
        Me.Controls.Add(Me.FieldEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FieldUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FieldName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "InputEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FieldName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FieldUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FieldConfirmPassword As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FieldEmail As TextBox
    Friend WithEvents FieldAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FieldRole As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents CheckShowPassword As CheckBox
End Class
