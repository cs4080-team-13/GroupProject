<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCSMoney
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelCurrency = New System.Windows.Forms.Panel()
        Me.panelMortgageCalc = New System.Windows.Forms.Panel()
        Me.lsvSchedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cbMortgageTerm = New System.Windows.Forms.ComboBox()
        Me.txtbxAnnualInterest = New System.Windows.Forms.TextBox()
        Me.txtbxLoanFees = New System.Windows.Forms.TextBox()
        Me.txtbxLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblMortgageTerm = New System.Windows.Forms.Label()
        Me.lblAnnualInterest = New System.Windows.Forms.Label()
        Me.lblLoanFees = New System.Windows.Forms.Label()
        Me.lblInterestPaidAmnt = New System.Windows.Forms.Label()
        Me.lblTotalPaidAmnt = New System.Windows.Forms.Label()
        Me.lblMonthlyPaymentAmnt = New System.Windows.Forms.Label()
        Me.lblInterestPaid = New System.Windows.Forms.Label()
        Me.lblTotalPaid = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.lblPaymentSchedule = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAustralianDollar = New System.Windows.Forms.Label()
        Me.lblAUDUSDPrice = New System.Windows.Forms.Label()
        Me.AUDUSD = New System.Windows.Forms.Label()
        Me.lblCanadianDollar = New System.Windows.Forms.Label()
        Me.lblCADUSDPrice = New System.Windows.Forms.Label()
        Me.lblCADUSD = New System.Windows.Forms.Label()
        Me.lblGreatBritainPound = New System.Windows.Forms.Label()
        Me.lblGBPUSDPrice = New System.Windows.Forms.Label()
        Me.lblGBPUSD = New System.Windows.Forms.Label()
        Me.lblEuropeanEuro = New System.Windows.Forms.Label()
        Me.lblEURUSDPrice = New System.Windows.Forms.Label()
        Me.lblEURUSD = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.lblLiveCurrencyExchangeRates = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.picAUSFlag = New System.Windows.Forms.PictureBox()
        Me.picCANFlag = New System.Windows.Forms.PictureBox()
        Me.picGBRFlag = New System.Windows.Forms.PictureBox()
        Me.picEURFlag = New System.Windows.Forms.PictureBox()
        Me.btnMortgage = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelCurrency.SuspendLayout()
        Me.panelMortgageCalc.SuspendLayout()
        CType(Me.picAUSFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCANFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGBRFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEURFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCurrency
        '
        Me.panelCurrency.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panelCurrency.Controls.Add(Me.btnRefresh)
        Me.panelCurrency.Controls.Add(Me.picAUSFlag)
        Me.panelCurrency.Controls.Add(Me.picCANFlag)
        Me.panelCurrency.Controls.Add(Me.picGBRFlag)
        Me.panelCurrency.Controls.Add(Me.picEURFlag)
        Me.panelCurrency.Controls.Add(Me.lblPrice)
        Me.panelCurrency.Controls.Add(Me.lblAustralianDollar)
        Me.panelCurrency.Controls.Add(Me.lblAUDUSDPrice)
        Me.panelCurrency.Controls.Add(Me.AUDUSD)
        Me.panelCurrency.Controls.Add(Me.lblCanadianDollar)
        Me.panelCurrency.Controls.Add(Me.lblCADUSDPrice)
        Me.panelCurrency.Controls.Add(Me.lblCADUSD)
        Me.panelCurrency.Controls.Add(Me.lblGreatBritainPound)
        Me.panelCurrency.Controls.Add(Me.lblGBPUSDPrice)
        Me.panelCurrency.Controls.Add(Me.lblGBPUSD)
        Me.panelCurrency.Controls.Add(Me.lblEuropeanEuro)
        Me.panelCurrency.Controls.Add(Me.lblEURUSDPrice)
        Me.panelCurrency.Controls.Add(Me.lblEURUSD)
        Me.panelCurrency.Controls.Add(Me.Label4)
        Me.panelCurrency.Controls.Add(Me.lblCurrency)
        Me.panelCurrency.Controls.Add(Me.lblLiveCurrencyExchangeRates)
        Me.panelCurrency.Location = New System.Drawing.Point(103, 2)
        Me.panelCurrency.Name = "panelCurrency"
        Me.panelCurrency.Size = New System.Drawing.Size(878, 661)
        Me.panelCurrency.TabIndex = 1
        '
        'panelMortgageCalc
        '
        Me.panelMortgageCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panelMortgageCalc.Controls.Add(Me.lsvSchedule)
        Me.panelMortgageCalc.Controls.Add(Me.btnCalculate)
        Me.panelMortgageCalc.Controls.Add(Me.cbMortgageTerm)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxAnnualInterest)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxLoanFees)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxLoanAmount)
        Me.panelMortgageCalc.Controls.Add(Me.lblMortgageTerm)
        Me.panelMortgageCalc.Controls.Add(Me.lblAnnualInterest)
        Me.panelMortgageCalc.Controls.Add(Me.lblLoanFees)
        Me.panelMortgageCalc.Controls.Add(Me.lblInterestPaidAmnt)
        Me.panelMortgageCalc.Controls.Add(Me.lblTotalPaidAmnt)
        Me.panelMortgageCalc.Controls.Add(Me.lblMonthlyPaymentAmnt)
        Me.panelMortgageCalc.Controls.Add(Me.lblInterestPaid)
        Me.panelMortgageCalc.Controls.Add(Me.lblTotalPaid)
        Me.panelMortgageCalc.Controls.Add(Me.lblMonthlyPayment)
        Me.panelMortgageCalc.Controls.Add(Me.lblPaymentSchedule)
        Me.panelMortgageCalc.Controls.Add(Me.lblLoanAmount)
        Me.panelMortgageCalc.Location = New System.Drawing.Point(100, 2)
        Me.panelMortgageCalc.Name = "panelMortgageCalc"
        Me.panelMortgageCalc.Size = New System.Drawing.Size(872, 658)
        Me.panelMortgageCalc.TabIndex = 3
        '
        'lsvSchedule
        '
        Me.lsvSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lsvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lsvSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSchedule.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lsvSchedule.Location = New System.Drawing.Point(187, 143)
        Me.lsvSchedule.Name = "lsvSchedule"
        Me.lsvSchedule.Size = New System.Drawing.Size(618, 463)
        Me.lsvSchedule.TabIndex = 7
        Me.lsvSchedule.UseCompatibleStateImageBehavior = False
        Me.lsvSchedule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Month"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Starting Balance"
        Me.ColumnHeader7.Width = 154
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Interest"
        Me.ColumnHeader8.Width = 112
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Monthly Payment"
        Me.ColumnHeader9.Width = 157
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Balance"
        Me.ColumnHeader10.Width = 131
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Green
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculate.Location = New System.Drawing.Point(21, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 37)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'cbMortgageTerm
        '
        Me.cbMortgageTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbMortgageTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbMortgageTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMortgageTerm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbMortgageTerm.FormattingEnabled = True
        Me.cbMortgageTerm.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cbMortgageTerm.Location = New System.Drawing.Point(21, 223)
        Me.cbMortgageTerm.Name = "cbMortgageTerm"
        Me.cbMortgageTerm.Size = New System.Drawing.Size(121, 29)
        Me.cbMortgageTerm.TabIndex = 6
        '
        'txtbxAnnualInterest
        '
        Me.txtbxAnnualInterest.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtbxAnnualInterest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAnnualInterest.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxAnnualInterest.Location = New System.Drawing.Point(21, 161)
        Me.txtbxAnnualInterest.Name = "txtbxAnnualInterest"
        Me.txtbxAnnualInterest.Size = New System.Drawing.Size(129, 29)
        Me.txtbxAnnualInterest.TabIndex = 5
        Me.txtbxAnnualInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbxLoanFees
        '
        Me.txtbxLoanFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtbxLoanFees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLoanFees.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxLoanFees.Location = New System.Drawing.Point(21, 95)
        Me.txtbxLoanFees.Name = "txtbxLoanFees"
        Me.txtbxLoanFees.Size = New System.Drawing.Size(129, 29)
        Me.txtbxLoanFees.TabIndex = 4
        Me.txtbxLoanFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbxLoanAmount
        '
        Me.txtbxLoanAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtbxLoanAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLoanAmount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxLoanAmount.Location = New System.Drawing.Point(21, 38)
        Me.txtbxLoanAmount.Name = "txtbxLoanAmount"
        Me.txtbxLoanAmount.Size = New System.Drawing.Size(129, 29)
        Me.txtbxLoanAmount.TabIndex = 3
        Me.txtbxLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMortgageTerm
        '
        Me.lblMortgageTerm.AutoSize = True
        Me.lblMortgageTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMortgageTerm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMortgageTerm.Location = New System.Drawing.Point(17, 198)
        Me.lblMortgageTerm.Name = "lblMortgageTerm"
        Me.lblMortgageTerm.Size = New System.Drawing.Size(167, 21)
        Me.lblMortgageTerm.TabIndex = 0
        Me.lblMortgageTerm.Text = "Mortgage Term (years)"
        '
        'lblAnnualInterest
        '
        Me.lblAnnualInterest.AutoSize = True
        Me.lblAnnualInterest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualInterest.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnnualInterest.Location = New System.Drawing.Point(17, 137)
        Me.lblAnnualInterest.Name = "lblAnnualInterest"
        Me.lblAnnualInterest.Size = New System.Drawing.Size(142, 21)
        Me.lblAnnualInterest.TabIndex = 0
        Me.lblAnnualInterest.Text = "Annual Interest (%)"
        '
        'lblLoanFees
        '
        Me.lblLoanFees.AutoSize = True
        Me.lblLoanFees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanFees.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLoanFees.Location = New System.Drawing.Point(17, 71)
        Me.lblLoanFees.Name = "lblLoanFees"
        Me.lblLoanFees.Size = New System.Drawing.Size(79, 21)
        Me.lblLoanFees.TabIndex = 0
        Me.lblLoanFees.Text = "Loan Fees"
        '
        'lblInterestPaidAmnt
        '
        Me.lblInterestPaidAmnt.AutoSize = True
        Me.lblInterestPaidAmnt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblInterestPaidAmnt.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestPaidAmnt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInterestPaidAmnt.Location = New System.Drawing.Point(651, 41)
        Me.lblInterestPaidAmnt.Name = "lblInterestPaidAmnt"
        Me.lblInterestPaidAmnt.Size = New System.Drawing.Size(80, 40)
        Me.lblInterestPaidAmnt.TabIndex = 0
        Me.lblInterestPaidAmnt.Text = "$ 0.0"
        Me.lblInterestPaidAmnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalPaidAmnt
        '
        Me.lblTotalPaidAmnt.AutoSize = True
        Me.lblTotalPaidAmnt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTotalPaidAmnt.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaidAmnt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalPaidAmnt.Location = New System.Drawing.Point(412, 44)
        Me.lblTotalPaidAmnt.Name = "lblTotalPaidAmnt"
        Me.lblTotalPaidAmnt.Size = New System.Drawing.Size(80, 40)
        Me.lblTotalPaidAmnt.TabIndex = 0
        Me.lblTotalPaidAmnt.Text = "$ 0.0"
        Me.lblTotalPaidAmnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMonthlyPaymentAmnt
        '
        Me.lblMonthlyPaymentAmnt.AutoSize = True
        Me.lblMonthlyPaymentAmnt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblMonthlyPaymentAmnt.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPaymentAmnt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthlyPaymentAmnt.Location = New System.Drawing.Point(182, 44)
        Me.lblMonthlyPaymentAmnt.Name = "lblMonthlyPaymentAmnt"
        Me.lblMonthlyPaymentAmnt.Size = New System.Drawing.Size(80, 40)
        Me.lblMonthlyPaymentAmnt.TabIndex = 0
        Me.lblMonthlyPaymentAmnt.Text = "$ 0.0"
        Me.lblMonthlyPaymentAmnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInterestPaid
        '
        Me.lblInterestPaid.AutoSize = True
        Me.lblInterestPaid.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblInterestPaid.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblInterestPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInterestPaid.Location = New System.Drawing.Point(651, 11)
        Me.lblInterestPaid.Name = "lblInterestPaid"
        Me.lblInterestPaid.Size = New System.Drawing.Size(116, 25)
        Me.lblInterestPaid.TabIndex = 0
        Me.lblInterestPaid.Text = "Interest Paid"
        Me.lblInterestPaid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTotalPaid.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTotalPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalPaid.Location = New System.Drawing.Point(412, 14)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(93, 25)
        Me.lblTotalPaid.TabIndex = 0
        Me.lblTotalPaid.Text = "Total Paid"
        Me.lblTotalPaid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblMonthlyPayment.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblMonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(182, 14)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(159, 25)
        Me.lblMonthlyPayment.TabIndex = 0
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        Me.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPaymentSchedule
        '
        Me.lblPaymentSchedule.AutoSize = True
        Me.lblPaymentSchedule.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPaymentSchedule.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblPaymentSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPaymentSchedule.Location = New System.Drawing.Point(184, 113)
        Me.lblPaymentSchedule.Name = "lblPaymentSchedule"
        Me.lblPaymentSchedule.Size = New System.Drawing.Size(166, 25)
        Me.lblPaymentSchedule.TabIndex = 0
        Me.lblPaymentSchedule.Text = "Payment Schedule"
        Me.lblPaymentSchedule.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLoanAmount.Location = New System.Drawing.Point(17, 14)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(104, 21)
        Me.lblLoanAmount.TabIndex = 0
        Me.lblLoanAmount.Text = "Loan Amount"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPrice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblPrice.Location = New System.Drawing.Point(431, 59)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 21)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = "Price"
        '
        'lblAustralianDollar
        '
        Me.lblAustralianDollar.AutoSize = True
        Me.lblAustralianDollar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAustralianDollar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblAustralianDollar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblAustralianDollar.Location = New System.Drawing.Point(126, 219)
        Me.lblAustralianDollar.Name = "lblAustralianDollar"
        Me.lblAustralianDollar.Size = New System.Drawing.Size(129, 21)
        Me.lblAustralianDollar.TabIndex = 0
        Me.lblAustralianDollar.Text = "Australian Dollar"
        '
        'lblAUDUSDPrice
        '
        Me.lblAUDUSDPrice.AutoSize = True
        Me.lblAUDUSDPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAUDUSDPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblAUDUSDPrice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblAUDUSDPrice.Location = New System.Drawing.Point(431, 219)
        Me.lblAUDUSDPrice.Name = "lblAUDUSDPrice"
        Me.lblAUDUSDPrice.Size = New System.Drawing.Size(19, 21)
        Me.lblAUDUSDPrice.TabIndex = 0
        Me.lblAUDUSDPrice.Text = "$"
        '
        'AUDUSD
        '
        Me.AUDUSD.AutoSize = True
        Me.AUDUSD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUDUSD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AUDUSD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.AUDUSD.Location = New System.Drawing.Point(301, 219)
        Me.AUDUSD.Name = "AUDUSD"
        Me.AUDUSD.Size = New System.Drawing.Size(81, 21)
        Me.AUDUSD.TabIndex = 0
        Me.AUDUSD.Text = "AUD/USD"
        '
        'lblCanadianDollar
        '
        Me.lblCanadianDollar.AutoSize = True
        Me.lblCanadianDollar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanadianDollar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCanadianDollar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblCanadianDollar.Location = New System.Drawing.Point(126, 179)
        Me.lblCanadianDollar.Name = "lblCanadianDollar"
        Me.lblCanadianDollar.Size = New System.Drawing.Size(123, 21)
        Me.lblCanadianDollar.TabIndex = 0
        Me.lblCanadianDollar.Text = "Canadian Dollar"
        '
        'lblCADUSDPrice
        '
        Me.lblCADUSDPrice.AutoSize = True
        Me.lblCADUSDPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCADUSDPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCADUSDPrice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblCADUSDPrice.Location = New System.Drawing.Point(431, 179)
        Me.lblCADUSDPrice.Name = "lblCADUSDPrice"
        Me.lblCADUSDPrice.Size = New System.Drawing.Size(19, 21)
        Me.lblCADUSDPrice.TabIndex = 0
        Me.lblCADUSDPrice.Text = "$"
        '
        'lblCADUSD
        '
        Me.lblCADUSD.AutoSize = True
        Me.lblCADUSD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCADUSD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCADUSD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblCADUSD.Location = New System.Drawing.Point(301, 179)
        Me.lblCADUSD.Name = "lblCADUSD"
        Me.lblCADUSD.Size = New System.Drawing.Size(80, 21)
        Me.lblCADUSD.TabIndex = 0
        Me.lblCADUSD.Text = "CAD/USD"
        '
        'lblGreatBritainPound
        '
        Me.lblGreatBritainPound.AutoSize = True
        Me.lblGreatBritainPound.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreatBritainPound.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblGreatBritainPound.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblGreatBritainPound.Location = New System.Drawing.Point(126, 139)
        Me.lblGreatBritainPound.Name = "lblGreatBritainPound"
        Me.lblGreatBritainPound.Size = New System.Drawing.Size(151, 21)
        Me.lblGreatBritainPound.TabIndex = 0
        Me.lblGreatBritainPound.Text = "Great Britain Pound"
        '
        'lblGBPUSDPrice
        '
        Me.lblGBPUSDPrice.AutoSize = True
        Me.lblGBPUSDPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGBPUSDPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblGBPUSDPrice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblGBPUSDPrice.Location = New System.Drawing.Point(431, 139)
        Me.lblGBPUSDPrice.Name = "lblGBPUSDPrice"
        Me.lblGBPUSDPrice.Size = New System.Drawing.Size(19, 21)
        Me.lblGBPUSDPrice.TabIndex = 0
        Me.lblGBPUSDPrice.Text = "$"
        '
        'lblGBPUSD
        '
        Me.lblGBPUSD.AutoSize = True
        Me.lblGBPUSD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGBPUSD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblGBPUSD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblGBPUSD.Location = New System.Drawing.Point(301, 139)
        Me.lblGBPUSD.Name = "lblGBPUSD"
        Me.lblGBPUSD.Size = New System.Drawing.Size(78, 21)
        Me.lblGBPUSD.TabIndex = 0
        Me.lblGBPUSD.Text = "GBP/USD"
        '
        'lblEuropeanEuro
        '
        Me.lblEuropeanEuro.AutoSize = True
        Me.lblEuropeanEuro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuropeanEuro.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblEuropeanEuro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblEuropeanEuro.Location = New System.Drawing.Point(126, 99)
        Me.lblEuropeanEuro.Name = "lblEuropeanEuro"
        Me.lblEuropeanEuro.Size = New System.Drawing.Size(116, 21)
        Me.lblEuropeanEuro.TabIndex = 0
        Me.lblEuropeanEuro.Text = "European Euro"
        '
        'lblEURUSDPrice
        '
        Me.lblEURUSDPrice.AutoSize = True
        Me.lblEURUSDPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEURUSDPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblEURUSDPrice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblEURUSDPrice.Location = New System.Drawing.Point(431, 99)
        Me.lblEURUSDPrice.Name = "lblEURUSDPrice"
        Me.lblEURUSDPrice.Size = New System.Drawing.Size(19, 21)
        Me.lblEURUSDPrice.TabIndex = 0
        Me.lblEURUSDPrice.Text = "$"
        '
        'lblEURUSD
        '
        Me.lblEURUSD.AutoSize = True
        Me.lblEURUSD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEURUSD.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblEURUSD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblEURUSD.Location = New System.Drawing.Point(301, 99)
        Me.lblEURUSD.Name = "lblEURUSD"
        Me.lblEURUSD.Size = New System.Drawing.Size(77, 21)
        Me.lblEURUSD.TabIndex = 0
        Me.lblEURUSD.Text = "EUR/USD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(126, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Currency"
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCurrency.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblCurrency.Location = New System.Drawing.Point(301, 59)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(113, 21)
        Me.lblCurrency.TabIndex = 0
        Me.lblCurrency.Text = "Currency Code"
        '
        'lblLiveCurrencyExchangeRates
        '
        Me.lblLiveCurrencyExchangeRates.AutoSize = True
        Me.lblLiveCurrencyExchangeRates.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveCurrencyExchangeRates.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblLiveCurrencyExchangeRates.Location = New System.Drawing.Point(15, 20)
        Me.lblLiveCurrencyExchangeRates.Name = "lblLiveCurrencyExchangeRates"
        Me.lblLiveCurrencyExchangeRates.Size = New System.Drawing.Size(138, 25)
        Me.lblLiveCurrencyExchangeRates.TabIndex = 0
        Me.lblLiveCurrencyExchangeRates.Text = "Currency Rates"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Green
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(40, 287)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(113, 36)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'picAUSFlag
        '
        Me.picAUSFlag.BackgroundImage = Global.CS4080_Project.My.Resources.Resources.AUFlag
        Me.picAUSFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picAUSFlag.Location = New System.Drawing.Point(58, 212)
        Me.picAUSFlag.Name = "picAUSFlag"
        Me.picAUSFlag.Size = New System.Drawing.Size(51, 39)
        Me.picAUSFlag.TabIndex = 4
        Me.picAUSFlag.TabStop = False
        '
        'picCANFlag
        '
        Me.picCANFlag.BackgroundImage = Global.CS4080_Project.My.Resources.Resources.CADFlag
        Me.picCANFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCANFlag.Location = New System.Drawing.Point(58, 169)
        Me.picCANFlag.Name = "picCANFlag"
        Me.picCANFlag.Size = New System.Drawing.Size(51, 39)
        Me.picCANFlag.TabIndex = 4
        Me.picCANFlag.TabStop = False
        '
        'picGBRFlag
        '
        Me.picGBRFlag.BackgroundImage = Global.CS4080_Project.My.Resources.Resources.GBFlag
        Me.picGBRFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picGBRFlag.Location = New System.Drawing.Point(58, 132)
        Me.picGBRFlag.Name = "picGBRFlag"
        Me.picGBRFlag.Size = New System.Drawing.Size(51, 39)
        Me.picGBRFlag.TabIndex = 4
        Me.picGBRFlag.TabStop = False
        '
        'picEURFlag
        '
        Me.picEURFlag.BackgroundImage = Global.CS4080_Project.My.Resources.Resources.EUFlag
        Me.picEURFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picEURFlag.Location = New System.Drawing.Point(58, 89)
        Me.picEURFlag.Name = "picEURFlag"
        Me.picEURFlag.Size = New System.Drawing.Size(51, 39)
        Me.picEURFlag.TabIndex = 4
        Me.picEURFlag.TabStop = False
        '
        'btnMortgage
        '
        Me.btnMortgage.BackgroundImage = Global.CS4080_Project.My.Resources.Resources.MortgageCalculatorIcon
        Me.btnMortgage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMortgage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMortgage.Location = New System.Drawing.Point(0, 0)
        Me.btnMortgage.Name = "btnMortgage"
        Me.btnMortgage.Size = New System.Drawing.Size(94, 86)
        Me.btnMortgage.TabIndex = 1
        Me.btnMortgage.UseVisualStyleBackColor = True
        '
        'btnCurrency
        '
        Me.btnCurrency.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrency.Image = Global.CS4080_Project.My.Resources.Resources.CurrencyRateIcon1
        Me.btnCurrency.Location = New System.Drawing.Point(0, 87)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(94, 86)
        Me.btnCurrency.TabIndex = 2
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCurrency)
        Me.Panel1.Controls.Add(Me.btnMortgage)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 658)
        Me.Panel1.TabIndex = 4
        '
        'frmCSMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelCurrency)
        Me.Controls.Add(Me.panelMortgageCalc)
        Me.Name = "frmCSMoney"
        Me.Text = "CS Money"
        Me.panelCurrency.ResumeLayout(False)
        Me.panelCurrency.PerformLayout()
        Me.panelMortgageCalc.ResumeLayout(False)
        Me.panelMortgageCalc.PerformLayout()
        CType(Me.picAUSFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCANFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGBRFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEURFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMortgageCalc As Panel
    Friend WithEvents txtbxAnnualInterest As TextBox
    Friend WithEvents txtbxLoanFees As TextBox
    Friend WithEvents txtbxLoanAmount As TextBox
    Friend WithEvents lblMortgageTerm As Label
    Friend WithEvents lblAnnualInterest As Label
    Friend WithEvents lblLoanFees As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents panelCurrency As Panel
    Friend WithEvents cbMortgageTerm As ComboBox
    Friend WithEvents lblLiveCurrencyExchangeRates As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPaymentSchedule As Label
    Friend WithEvents lsvSchedule As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents lblInterestPaidAmnt As Label
    Friend WithEvents lblTotalPaidAmnt As Label
    Friend WithEvents lblMonthlyPaymentAmnt As Label
    Friend WithEvents lblInterestPaid As Label
    Friend WithEvents lblTotalPaid As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCurrency As Label
    Friend WithEvents lblAustralianDollar As Label
    Friend WithEvents lblAUDUSDPrice As Label
    Friend WithEvents AUDUSD As Label
    Friend WithEvents lblCanadianDollar As Label
    Friend WithEvents lblCADUSDPrice As Label
    Friend WithEvents lblCADUSD As Label
    Friend WithEvents lblGreatBritainPound As Label
    Friend WithEvents lblGBPUSDPrice As Label
    Friend WithEvents lblGBPUSD As Label
    Friend WithEvents lblEuropeanEuro As Label
    Friend WithEvents lblEURUSDPrice As Label
    Friend WithEvents lblEURUSD As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents picAUSFlag As PictureBox
    Friend WithEvents picCANFlag As PictureBox
    Friend WithEvents picGBRFlag As PictureBox
    Friend WithEvents picEURFlag As PictureBox
    Friend WithEvents btnMortgage As Button
    Friend WithEvents btnCurrency As Button
    Friend WithEvents Panel1 As Panel
End Class
