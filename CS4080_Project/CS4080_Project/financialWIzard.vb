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
        decMonthlyPayment = calcMonthlyPayment(decBalance, decMonthlyInterestRate, intMonths)
        For i As Integer = 1 To intMonths
            'Calculate the interest for month i
            decMonthlyInterest = Math.Round((decBalance * decMonthlyInterestRate), 2)
            'Create an array of strings to be added to the ListView
            Dim strMonthInfo(4) As String
            strMonthInfo(0) = i.ToString
            strMonthInfo(1) = FormatNumber(decBalance, 2)
            strMonthInfo(2) = FormatNumber(decMonthlyInterest, 2)
            strMonthInfo(3) = FormatNumber(decMonthlyPayment, 2)
            'Calculate the remaining balance
            decBalance = calcBalance(decBalance, decMonthlyInterestRate, decMonthlyPayment, intMonths - i)
            strMonthInfo(4) = FormatNumber(decBalance, 2)
            'Dim lsvi As ListViewItem = New ListViewItem(strMonthInfo)
            'Pass the string to the ListView item
            lsvSchedule.Items.Add(New ListViewItem(strMonthInfo))
        Next
    End Sub
    Private Function calcMonthlyPayment(ByVal decBal As Decimal, ByVal decMIR As Decimal, ByVal intM As Integer) As Decimal
        'Return Math.Round((decLoanAmount * (decMIR * (1 + decMIR) ^ intM) / (((1 + decMIR) ^ intM) - 1)), 2)
        Return Math.Round((decBal * decMIR) / (1 - (1 + decMIR) ^ (-intM)), 2)
    End Function
    Private Function calcBalance(ByVal decBal As Decimal, ByVal decMIR As Decimal, ByVal decMP As Decimal, ByVal intMR As Integer) As Decimal
        'Return Math.Round((decBal - (decMonthlyPayment - decMI)))
        Return Math.Round((decMP * (1 - (1 + decMIR) ^ (-intMR))) / decMIR, 2)
    End Function
End Class
