Public Class frmFinanceWizard
    'Get all the data from the user
    Dim decLoanAmount As Decimal
    Dim decLoanFees As Decimal
    Dim decInterestRate As Decimal
    Dim intMortgageTerm As Integer

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs)
        panelExpenseTracker.Visible = False
        panelMortgageCalc.Visible = False
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        panelExpenseTracker.Visible = True
        panelMortgageCalc.Visible = False
    End Sub

    Private Sub btnInvestment_Click(sender As Object, e As EventArgs)
        panelExpenseTracker.Visible = False
        panelMortgageCalc.Visible = False
    End Sub

    Private Sub btnMortgage_Click(sender As Object, e As EventArgs) Handles btnMortgage.Click
        panelExpenseTracker.Visible = False
        panelMortgageCalc.Visible = True
    End Sub

    'Calculates the number mortgage payment amount per month for a specified loan amount, annual interest rate, and mortgage term
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            decLoanAmount = Decimal.Parse(txtbxLoanAmount.Text)
            decLoanFees = Double.Parse(txtbxLoanFees.Text)
            decInterestRate = Double.Parse(txtbxAnnualInterest.Text)
            intMortgageTerm = Integer.Parse(cbMortgageTerm.Text)
        Catch ex As Exception
            MsgBox("Please use only numerical digits", MsgBoxStyle.OkOnly, "Error")
            Return
        End Try
        'Begin calculating the montly payment, total interest paid, total paid
        decInterestRate = decInterestRate / 100
        Dim decMonthlyPayment As Decimal
        Dim decInterestPaid As Decimal
        Dim decTotalPaid As Decimal
        Dim decMonthlyInterestRate As Decimal = (decInterestRate / 12)
        Dim intMonths As Integer = intMortgageTerm * 12
        Dim decBalance As Decimal
        decLoanAmount = (decLoanAmount + decLoanFees)
        For i As Integer = 1 To intMonths
            decMonthlyPayment = decLoanAmount * (decMonthlyInterestRate * (1 + decMonthlyInterestRate) ^ intMonths) / ((1 + decMonthlyInterestRate) ^ intMonths - 1)
            decBalance = decLoanAmount * (decMonthlyInterestRate * (((1 + decMonthlyInterestRate) ^ intMonths) - (1 + decMonthlyInterestRate) ^ decMonthlyPayment)) / ((1 + decMonthlyInterestRate) ^ intMonths - 1)
            decInterestPaid = decLoanAmount * decMonthlyInterestRate
            Dim strMonthInfo(5) As String
            strMonthInfo(0) = i.ToString
            strMonthInfo(1) = FormatNumber(decLoanAmount, 2)
            strMonthInfo(2) = FormatNumber(decInterestPaid, 2)
            strMonthInfo(3) = FormatNumber(decMonthlyPayment, 2)
            strMonthInfo(4) = FormatNumber(decBalance, 2)
            lsvMonthlySchedule.Items.Add(New ListViewItem(strMonthInfo))
            decLoanAmount = decBalance
        Next
    End Sub
End Class
