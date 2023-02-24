Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class FormReport
    Private Sub GetReport(month As String, year As String)
        Dim totalSold As Integer = 0
        Dim income As Integer = 0
        Dim outcome As Integer = 0
        Dim profit As Double = 0
        Dim currentBalance As Integer = 0

        Dim reportDate As Date = Date.Parse("10-" + month + "-" + year + " 00:00:00")
        labelReportDate.Text = reportDate.ToString("MMMM yyyy")

        Try
            AppConnection.Open()

            SqlQuery = "SELECT SUM(Qty) as ItemsSold, SUM(Subtotal) as Income FROM Sale WHERE MONTH(CreatedAt) = " + month + " AND YEAR(CreatedAt) = " + year + ";
                        SELECT SUM(Subtotal) as Outcome FROM Purchase WHERE MONTH(CreatedAt) = " + month + " AND YEAR(CreatedAt) = " + year + ";
                        SELECT CurrentBalance FROM Finance"
            Command = New SqlCommand(SqlQuery, AppConnection.Connection)

            DataReader = Command.ExecuteReader()

            If DataReader.HasRows() Then
                DataReader.Read()
                If DataReader.Item("ItemsSold") IsNot DBNull.Value Then
                    totalSold = DataReader.Item("ItemsSold")
                    income = DataReader.Item("Income")
                End If
            End If

            If DataReader.NextResult() Then
                DataReader.Read()
                If DataReader.Item("Outcome") IsNot DBNull.Value Then
                    outcome = DataReader.Item("Outcome")
                End If
            End If

            If DataReader.NextResult() Then
                DataReader.Read()
                If DataReader.Item("CurrentBalance") IsNot DBNull.Value Then
                    currentBalance = DataReader.Item("CurrentBalance")
                End If
            End If

            If outcome > 0 Then
                profit = (income - outcome) / outcome
            Else
                profit = 1
            End If

            If (income - outcome) = 0 Then
                profit = 0
            End If

            If profit < 0 Then
                labelProfit.ForeColor = Color.DarkRed
                labelProfitInfo.Text = "Loss"
            Else
                labelProfit.ForeColor = Color.DarkGreen
                labelProfitInfo.Text = "Profit"
            End If

            labelIncome.Text = income.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            labelOutcome.Text = outcome.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            labelItemsSold.Text = totalSold
            labelProfit.Text = profit.ToString("P")
            labelCurrentBalance.Text = currentBalance.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
        Catch ex As Exception
            MsgBox("Failed to get finance summary: " + ex.Message)
        Finally
            AppConnection.Close()
        End Try
    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        GetReport(Date.Now.Month, Date.Now.Year)
        ComboMonth.SelectedIndex = Date.Now.Month - 1
        FieldYear.Text = Date.Now.Year
    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        If Regex.IsMatch(FieldYear.Text, "^\d+$") Then
            GetReport(ComboMonth.SelectedIndex + 1, FieldYear.Text)
        Else
            MsgBox("Please specify a valid year")
        End If
    End Sub
End Class