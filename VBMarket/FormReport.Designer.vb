<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FieldYear = New System.Windows.Forms.TextBox()
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelIncome = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelProfit = New System.Windows.Forms.Label()
        Me.labelProfitInfo = New System.Windows.Forms.Label()
        Me.labelItemsSold = New System.Windows.Forms.Label()
        Me.labelReportDate = New System.Windows.Forms.Label()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelCurrentBalance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monthly Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Input Year"
        '
        'FieldYear
        '
        Me.FieldYear.Location = New System.Drawing.Point(120, 62)
        Me.FieldYear.Name = "FieldYear"
        Me.FieldYear.Size = New System.Drawing.Size(151, 23)
        Me.FieldYear.TabIndex = 2
        '
        'ComboMonth
        '
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboMonth.Location = New System.Drawing.Point(120, 27)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(151, 23)
        Me.ComboMonth.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Items Sold"
        '
        'labelIncome
        '
        Me.labelIncome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelIncome.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelIncome.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labelIncome.Location = New System.Drawing.Point(246, 270)
        Me.labelIncome.Name = "labelIncome"
        Me.labelIncome.Size = New System.Drawing.Size(361, 65)
        Me.labelIncome.TabIndex = 4
        Me.labelIncome.Text = "Rp0"
        Me.labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(421, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Income"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelProfit
        '
        Me.labelProfit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelProfit.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelProfit.ForeColor = System.Drawing.Color.DarkGreen
        Me.labelProfit.Location = New System.Drawing.Point(613, 270)
        Me.labelProfit.Name = "labelProfit"
        Me.labelProfit.Size = New System.Drawing.Size(224, 65)
        Me.labelProfit.TabIndex = 4
        Me.labelProfit.Text = "0%"
        Me.labelProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelProfitInfo
        '
        Me.labelProfitInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelProfitInfo.Location = New System.Drawing.Point(613, 352)
        Me.labelProfitInfo.Name = "labelProfitInfo"
        Me.labelProfitInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.labelProfitInfo.Size = New System.Drawing.Size(224, 15)
        Me.labelProfitInfo.TabIndex = 5
        Me.labelProfitInfo.Text = "Profit"
        Me.labelProfitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelItemsSold
        '
        Me.labelItemsSold.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelItemsSold.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labelItemsSold.Location = New System.Drawing.Point(22, 270)
        Me.labelItemsSold.Name = "labelItemsSold"
        Me.labelItemsSold.Size = New System.Drawing.Size(224, 65)
        Me.labelItemsSold.TabIndex = 4
        Me.labelItemsSold.Text = "0"
        Me.labelItemsSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelReportDate
        '
        Me.labelReportDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelReportDate.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelReportDate.ForeColor = System.Drawing.Color.Black
        Me.labelReportDate.Location = New System.Drawing.Point(552, 172)
        Me.labelReportDate.Name = "labelReportDate"
        Me.labelReportDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labelReportDate.Size = New System.Drawing.Size(285, 37)
        Me.labelReportDate.TabIndex = 0
        Me.labelReportDate.Text = "February 2023"
        Me.labelReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewReport
        '
        Me.btnViewReport.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewReport.FlatAppearance.BorderSize = 0
        Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReport.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnViewReport.Location = New System.Drawing.Point(120, 103)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(151, 31)
        Me.btnViewReport.TabIndex = 6
        Me.btnViewReport.Text = "VIEW REPORT"
        Me.btnViewReport.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Current Balance"
        '
        'labelCurrentBalance
        '
        Me.labelCurrentBalance.AutoSize = True
        Me.labelCurrentBalance.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelCurrentBalance.ForeColor = System.Drawing.Color.DarkGreen
        Me.labelCurrentBalance.Location = New System.Drawing.Point(29, 498)
        Me.labelCurrentBalance.Name = "labelCurrentBalance"
        Me.labelCurrentBalance.Size = New System.Drawing.Size(117, 65)
        Me.labelCurrentBalance.TabIndex = 4
        Me.labelCurrentBalance.Text = "Rp0"
        Me.labelCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 616)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.labelProfitInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelProfit)
        Me.Controls.Add(Me.labelCurrentBalance)
        Me.Controls.Add(Me.labelItemsSold)
        Me.Controls.Add(Me.labelIncome)
        Me.Controls.Add(Me.ComboMonth)
        Me.Controls.Add(Me.FieldYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelReportDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldYear As TextBox
    Friend WithEvents ComboMonth As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents labelIncome As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents labelProfit As Label
    Friend WithEvents labelProfitInfo As Label
    Friend WithEvents labelItemsSold As Label
    Friend WithEvents labelReportDate As Label
    Friend WithEvents btnViewReport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents labelCurrentBalance As Label
End Class
