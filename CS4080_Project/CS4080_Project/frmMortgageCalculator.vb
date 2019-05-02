Imports System
Imports System.Net
Imports System.IO

Public Class frmCSMoney
    Private decMonthlyPayment As Decimal
    Private decLoanAmount As Decimal
    Private decLoanFees As Decimal
    Private decInterestRate As Decimal

    Dim intMortgageTerm As Integer

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        panelCurrency.Visible = True
        panelMortgageCalc.Visible = False
    End Sub

    Private Sub btnMortgage_Click(sender As Object, e As EventArgs) Handles btnMortgage.Click
        panelCurrency.Visible = False
        panelMortgageCalc.Visible = True
    End Sub

    'Calculates the number mortgage payment amount per month for a specified loan amount, annual interest rate, and mortgage term
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Get all the data from the user
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
        Dim decTotalPaid As Decimal
        Dim decInterestPaid As Decimal
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
            decTotalPaid += decMonthlyPayment
            decInterestPaid += decMonthlyInterest
        Next
        lblMonthlyPaymentAmnt.Text = "$" + FormatNumber(decMonthlyPayment, 2)
        lblTotalPaidAmnt.Text = "$" + FormatNumber(decTotalPaid, 2)
        lblInterestPaidAmnt.Text = "$" + FormatNumber(decInterestPaid, 2)
    End Sub
    'Calculates the Monthly Payment
    Private Function calcMonthlyPayment(ByVal decBal As Decimal, ByVal decMIR As Decimal, ByVal intM As Integer) As Decimal
        'Return Math.Round((decLoanAmount * (decMIR * (1 + decMIR) ^ intM) / (((1 + decMIR) ^ intM) - 1)), 2)
        Return Math.Round((decBal * decMIR) / (1 - (1 + decMIR) ^ (-intM)), 2)
    End Function

    'Calculates the Balance after a payment has been made
    Private Function calcBalance(ByVal decBal As Decimal, ByVal decMIR As Decimal, ByVal decMP As Decimal, ByVal intMR As Integer) As Decimal
        'Return Math.Round((decBal - (decMonthlyPayment - decMI)))
        Return Math.Round((decMP * (1 - (1 + decMIR) ^ (-intMR))) / decMIR, 2)
    End Function

    Private Sub Request_Currency_Data()
        ' Define endpoint '
        Const API_KEY As String = "e97c84d09749879bd229"
        Dim Url As String = "https://free.currconv.com/api/v7/convert?q=EUR_USD,GBP_USD,CAD_USD,AUD_USD&compact=ultra&apiKey=" & API_KEY
        ' Create request and stream '
        Dim Req As WebRequest = WebRequest.Create(Url)
        Dim Stream As Stream = Req.GetResponse.GetResponseStream()
        ' Create stream reader helper vars ' 
        Dim Reader As New StreamReader(Stream)
        Dim Line As String = ""
        Dim Json As String = ""
        ' Read stream line by line and concat json string '
        Do While Not Line Is Nothing
            Line = Reader.ReadLine
            If Not Line Is Nothing Then
                Json = Json & Line
            End If
        Loop
        ' Update view '
        Update_Currencies_From_JSON(Json)
    End Sub

    Private Sub Update_Currencies_From_JSON(Json As String)
        Dim intEuroPriceStart As Integer = Json.IndexOf("""EUR_USD"":") + 10
        Dim intPoundPriceStart As Integer = Json.IndexOf(",""GBP_USD"":") + 11
        Dim intCadDollarPriceStart As Integer = Json.IndexOf(",""CAD_USD"":") + 11
        Dim intAusDollarPriceStart As Integer = Json.IndexOf(",""AUD_USD"":") + 11
        Dim intEnd = Json.IndexOf("}")
        ' Get each value by taking substring, not ideal '
        'Dim Euro As String = Json.Substring(11, 4)
        'Dim Pound As String = Json.Substring(30, 4)
        'Dim CadDollar As String = Json.Substring(49, 4)
        'Dim AusDollar As String = Json.Substring(68, 4)
        Dim Euro As String = Json.Substring(intEuroPriceStart, intPoundPriceStart - intEuroPriceStart - 11)
        Dim Pound As String = Json.Substring(intPoundPriceStart, intCadDollarPriceStart - intPoundPriceStart - 11)
        Dim CadDollar As String = Json.Substring(intCadDollarPriceStart, intAusDollarPriceStart - intCadDollarPriceStart - 11)
        Dim AusDollar As String = Json.Substring(intAusDollarPriceStart, intEnd - intAusDollarPriceStart)
        ' Update Labels
        lblEURUSDPrice.Text = "$" + Euro
        lblGBPUSDPrice.Text = "$" + Pound
        lblCADUSDPrice.Text = "$" + CadDollar
        lblAUDUSDPrice.Text = "$" + AusDollar
    End Sub

    Private Sub frmMortgageCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCurrency.Visible = False
        panelMortgageCalc.Visible = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Request_Currency_Data()
    End Sub
End Class
