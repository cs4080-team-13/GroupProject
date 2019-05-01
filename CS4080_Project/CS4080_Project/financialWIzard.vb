Public Class frmFinanceWizard
    'Get all the data from the user
    Private decMonthlyPayment As Decimal
    Private decLoanAmount As Decimal
    Private decLoanFees As Decimal
    Private decInterestRate As Decimal
    Dim intMortgageTerm As Integer

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        panelExpenseTracker.Visible = True
        panelMortgageCalc.Visible = False
    End Sub

    Private Sub btnMortgage_Click(sender As Object, e As EventArgs) Handles btnMortgage.Click
        panelExpenseTracker.Visible = False
        panelMortgageCalc.Visible = True
    End Sub

    'Calculates the number mortgage payment amount per month for a specified loan amount, annual interest rate, and mortgage term
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lsvMonthlySchedule.Clear()
        Try
            decLoanAmount = Decimal.Parse(txtbxLoanAmount.Text)
            decLoanFees = Double.Parse(txtbxLoanFees.Text)
            decInterestRate = Double.Parse(txtbxAnnualInterest.Text)
            intMortgageTerm = Integer.Parse(cbMortgageTerm.Text)
        Catch ex As Exception
            MsgBox("Please use only numerical digits", MsgBoxStyle.OkOnly, "Error")
            Return
        End Try
        'Calculate the montly interest rate
        decInterestRate = decInterestRate / 100
        Dim decMonthlyInterest As Decimal
        Dim decMonthlyInterestRate As Decimal = decInterestRate / 12
        Dim intMonths As Integer = intMortgageTerm * 12
        Dim decBalance As Decimal = decLoanAmount + decLoanFees
        'Calulate the monthly payment, it only needs to be calculated once
        decMonthlyPayment = calcMonthlyPayment(decMonthlyInterestRate, intMonths)
        For i As Integer = 1 To intMonths
            'Calculate the interest for month i
            decMonthlyInterest = Math.Round((decBalance * decMonthlyInterestRate), 2)
            'Create an array of strings to be added to the ListView
            Dim strMonthInfo(5) As String
            strMonthInfo(0) = i.ToString
            strMonthInfo(1) = FormatNumber(decBalance, 2)
            strMonthInfo(2) = FormatNumber(decMonthlyInterest, 2)
            strMonthInfo(3) = FormatNumber(decMonthlyPayment, 2)
            'Calculate the remaining balance
            decBalance = calcBalance(decBalance, decMonthlyInterest)
            strMonthInfo(4) = FormatNumber(decBalance, 2)
            'Pass the string to the ListView item
            lsvMonthlySchedule.Items.Add(New ListViewItem(strMonthInfo))
        Next
    End Sub
    Private Function calcMonthlyPayment(ByVal decMIR As Decimal, ByVal intM As Integer) As Decimal
        Return Math.Round((decLoanAmount * (decMIR * (1 + decMIR) ^ intM) / (((1 + decMIR) ^ intM) - 1)), 2)
    End Function
    Private Function calcBalance(ByVal decBal As Decimal, ByVal decMI As Decimal) As Decimal
        Return Math.Round((decBal - (decMonthlyPayment - decMI)))
    End Function
End Class
