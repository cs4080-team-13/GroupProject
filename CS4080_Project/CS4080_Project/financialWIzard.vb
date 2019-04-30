Public Class frmFinanceWizard

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
        'Get all the data from the user
        Dim dblLoanAmount As Double
        Dim dblLoanFees As Double
        Dim dblDownPaymentPercent As Double
        Dim dblInterestRate As Double
        Dim intMortgageTerm As Integer
        Try
            dblLoanAmount = Double.Parse(txtbxLoanAmount.Text)
            dblLoanFees = Double.Parse(txtbxLoanFees.Text)
            dblDownPaymentPercent = Double.Parse(txtbxDownPayment.Text)
            dblInterestRate = Double.Parse(txtbxAnnualInterest.Text)
            intMortgageTerm = 20 ' = Integer.Parse(cbMortgageTerm.SelectedText)
        Catch ex As Exception
            MsgBox("Please use only numerical digits", MsgBoxStyle.OkOnly, "Error")
            Return
        End Try
        'Begin calculating the montly payment, total interest paid, total paid
        Dim dblMonthlyPayment As Double
        Dim dblInterestPaid As Double = 0.0
        Dim dblTotalPaid As Double = 0.0
        Dim dblMonthlyInterestRate As Double = dblInterestRate / 12
        Dim intMonths As Integer = intMortgageTerm * 12
        Dim dblBalance As Double
        dblLoanAmount = (dblLoanAmount + dblLoanFees) - (dblLoanAmount * dblDownPaymentPercent)
        For i As Integer = 1 To intMonths
            dblMonthlyPayment = dblLoanAmount * (dblMonthlyInterestRate * (1 + dblMonthlyInterestRate) ^ intMonths) / ((1 + dblMonthlyInterestRate) ^ intMonths - 1)
            dblBalance = dblLoanAmount * (dblMonthlyInterestRate * (((1 + dblMonthlyInterestRate) ^ intMonths) - (1 + dblMonthlyInterestRate) ^ intMonths)) / ((1 + dblMonthlyInterestRate) ^ intMonths - 1)
            dblInterestPaid = dblLoanAmount * dblMonthlyInterestRate
            lsvMonthlySchedule.Items(i).SubItems.Add(i)
            lsvMonthlySchedule.Items(i).SubItems.Add(dblLoanAmount)
            lsvMonthlySchedule.Items(i).SubItems.Add(dblInterestPaid)
            lsvMonthlySchedule.Items(i).SubItems.Add(dblMonthlyPayment)
            lsvMonthlySchedule.Items(i).SubItems.Add(dblBalance)
        Next

    End Sub
End Class
