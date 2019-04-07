<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinanceWizard
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
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.btnInvestment = New System.Windows.Forms.Button()
        Me.btnMortgage = New System.Windows.Forms.Button()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.panelMortgageCalc = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cbMortgageTerm = New System.Windows.Forms.ComboBox()
        Me.txtbxAnnualInterest = New System.Windows.Forms.TextBox()
        Me.txtbxLoanFees = New System.Windows.Forms.TextBox()
        Me.txtbxLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblMortgageTerm = New System.Windows.Forms.Label()
        Me.lblAnnualInterest = New System.Windows.Forms.Label()
        Me.lblLoanFees = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.panelInvestmentTracker = New System.Windows.Forms.Panel()
        Me.lblInvestmentTracker = New System.Windows.Forms.Label()
        Me.panelExpenseTracker = New System.Windows.Forms.Panel()
        Me.lbExpenseTracker = New System.Windows.Forms.Label()
        Me.panelCalendar = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblDownPayment = New System.Windows.Forms.Label()
        Me.txtbxDownPayment = New System.Windows.Forms.TextBox()
        Me.tlpButtons.SuspendLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.panelMortgageCalc.SuspendLayout()
        Me.panelInvestmentTracker.SuspendLayout()
        Me.panelExpenseTracker.SuspendLayout()
        Me.panelCalendar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalendar
        '
        Me.btnCalendar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendar.Location = New System.Drawing.Point(3, 3)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(94, 89)
        Me.btnCalendar.TabIndex = 0
        Me.btnCalendar.Text = "Interactive Calendar"
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnExpense
        '
        Me.btnExpense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpense.Location = New System.Drawing.Point(3, 98)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(94, 89)
        Me.btnExpense.TabIndex = 1
        Me.btnExpense.Text = "Expense Tracker"
        Me.btnExpense.UseVisualStyleBackColor = True
        '
        'btnInvestment
        '
        Me.btnInvestment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvestment.Location = New System.Drawing.Point(3, 193)
        Me.btnInvestment.Name = "btnInvestment"
        Me.btnInvestment.Size = New System.Drawing.Size(94, 89)
        Me.btnInvestment.TabIndex = 2
        Me.btnInvestment.Text = "Investment Tracker"
        Me.btnInvestment.UseVisualStyleBackColor = True
        '
        'btnMortgage
        '
        Me.btnMortgage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMortgage.Location = New System.Drawing.Point(3, 288)
        Me.btnMortgage.Name = "btnMortgage"
        Me.btnMortgage.Size = New System.Drawing.Size(94, 89)
        Me.btnMortgage.TabIndex = 3
        Me.btnMortgage.Text = "Mortgage Calculator"
        Me.btnMortgage.UseVisualStyleBackColor = True
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Controls.Add(Me.btnCalendar, 0, 0)
        Me.tlpButtons.Controls.Add(Me.btnMortgage, 0, 3)
        Me.tlpButtons.Controls.Add(Me.btnExpense, 0, 1)
        Me.tlpButtons.Controls.Add(Me.btnInvestment, 0, 2)
        Me.tlpButtons.Location = New System.Drawing.Point(0, 0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 5
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(100, 400)
        Me.tlpButtons.TabIndex = 1
        '
        'scMain
        '
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.tlpButtons)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.panelMortgageCalc)
        Me.scMain.Panel2.Controls.Add(Me.panelInvestmentTracker)
        Me.scMain.Panel2.Controls.Add(Me.panelExpenseTracker)
        Me.scMain.Panel2.Controls.Add(Me.panelCalendar)
        Me.scMain.Size = New System.Drawing.Size(800, 500)
        Me.scMain.SplitterDistance = 100
        Me.scMain.TabIndex = 2
        '
        'panelMortgageCalc
        '
        Me.panelMortgageCalc.Controls.Add(Me.btnCalculate)
        Me.panelMortgageCalc.Controls.Add(Me.cbMortgageTerm)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxAnnualInterest)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxDownPayment)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxLoanFees)
        Me.panelMortgageCalc.Controls.Add(Me.txtbxLoanAmount)
        Me.panelMortgageCalc.Controls.Add(Me.lblMortgageTerm)
        Me.panelMortgageCalc.Controls.Add(Me.lblAnnualInterest)
        Me.panelMortgageCalc.Controls.Add(Me.lblDownPayment)
        Me.panelMortgageCalc.Controls.Add(Me.lblLoanFees)
        Me.panelMortgageCalc.Controls.Add(Me.lblLoanAmount)
        Me.panelMortgageCalc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMortgageCalc.Location = New System.Drawing.Point(0, 0)
        Me.panelMortgageCalc.Name = "panelMortgageCalc"
        Me.panelMortgageCalc.Size = New System.Drawing.Size(696, 500)
        Me.panelMortgageCalc.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculate.Location = New System.Drawing.Point(21, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 37)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'cbMortgageTerm
        '
        Me.cbMortgageTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMortgageTerm.FormattingEnabled = True
        Me.cbMortgageTerm.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cbMortgageTerm.Location = New System.Drawing.Point(21, 279)
        Me.cbMortgageTerm.Name = "cbMortgageTerm"
        Me.cbMortgageTerm.Size = New System.Drawing.Size(121, 29)
        Me.cbMortgageTerm.TabIndex = 2
        '
        'txtbxAnnualInterest
        '
        Me.txtbxAnnualInterest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAnnualInterest.Location = New System.Drawing.Point(21, 217)
        Me.txtbxAnnualInterest.Name = "txtbxAnnualInterest"
        Me.txtbxAnnualInterest.Size = New System.Drawing.Size(129, 29)
        Me.txtbxAnnualInterest.TabIndex = 1
        Me.txtbxAnnualInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbxLoanFees
        '
        Me.txtbxLoanFees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLoanFees.Location = New System.Drawing.Point(21, 95)
        Me.txtbxLoanFees.Name = "txtbxLoanFees"
        Me.txtbxLoanFees.Size = New System.Drawing.Size(129, 29)
        Me.txtbxLoanFees.TabIndex = 1
        Me.txtbxLoanFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbxLoanAmount
        '
        Me.txtbxLoanAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLoanAmount.Location = New System.Drawing.Point(21, 38)
        Me.txtbxLoanAmount.Name = "txtbxLoanAmount"
        Me.txtbxLoanAmount.Size = New System.Drawing.Size(129, 29)
        Me.txtbxLoanAmount.TabIndex = 1
        Me.txtbxLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMortgageTerm
        '
        Me.lblMortgageTerm.AutoSize = True
        Me.lblMortgageTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMortgageTerm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMortgageTerm.Location = New System.Drawing.Point(17, 254)
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
        Me.lblAnnualInterest.Location = New System.Drawing.Point(17, 193)
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
        'panelInvestmentTracker
        '
        Me.panelInvestmentTracker.Controls.Add(Me.lblInvestmentTracker)
        Me.panelInvestmentTracker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelInvestmentTracker.Location = New System.Drawing.Point(0, 0)
        Me.panelInvestmentTracker.Name = "panelInvestmentTracker"
        Me.panelInvestmentTracker.Size = New System.Drawing.Size(696, 500)
        Me.panelInvestmentTracker.TabIndex = 2
        '
        'lblInvestmentTracker
        '
        Me.lblInvestmentTracker.AutoSize = True
        Me.lblInvestmentTracker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestmentTracker.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblInvestmentTracker.Location = New System.Drawing.Point(40, 40)
        Me.lblInvestmentTracker.Name = "lblInvestmentTracker"
        Me.lblInvestmentTracker.Size = New System.Drawing.Size(141, 21)
        Me.lblInvestmentTracker.TabIndex = 1
        Me.lblInvestmentTracker.Text = "Investment Tracker"
        '
        'panelExpenseTracker
        '
        Me.panelExpenseTracker.Controls.Add(Me.lbExpenseTracker)
        Me.panelExpenseTracker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelExpenseTracker.Location = New System.Drawing.Point(0, 0)
        Me.panelExpenseTracker.Name = "panelExpenseTracker"
        Me.panelExpenseTracker.Size = New System.Drawing.Size(696, 500)
        Me.panelExpenseTracker.TabIndex = 1
        '
        'lbExpenseTracker
        '
        Me.lbExpenseTracker.AutoSize = True
        Me.lbExpenseTracker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbExpenseTracker.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbExpenseTracker.Location = New System.Drawing.Point(46, 44)
        Me.lbExpenseTracker.Name = "lbExpenseTracker"
        Me.lbExpenseTracker.Size = New System.Drawing.Size(120, 21)
        Me.lbExpenseTracker.TabIndex = 0
        Me.lbExpenseTracker.Text = "Expense Tracker"
        '
        'panelCalendar
        '
        Me.panelCalendar.Controls.Add(Me.MonthCalendar1)
        Me.panelCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCalendar.Location = New System.Drawing.Point(0, 0)
        Me.panelCalendar.Name = "panelCalendar"
        Me.panelCalendar.Size = New System.Drawing.Size(696, 500)
        Me.panelCalendar.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(5, 3)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'lblDownPayment
        '
        Me.lblDownPayment.AutoSize = True
        Me.lblDownPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDownPayment.Location = New System.Drawing.Point(17, 132)
        Me.lblDownPayment.Name = "lblDownPayment"
        Me.lblDownPayment.Size = New System.Drawing.Size(142, 21)
        Me.lblDownPayment.TabIndex = 0
        Me.lblDownPayment.Text = "Down Payment (%)"
        '
        'txtbxDownPayment
        '
        Me.txtbxDownPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDownPayment.Location = New System.Drawing.Point(21, 156)
        Me.txtbxDownPayment.Name = "txtbxDownPayment"
        Me.txtbxDownPayment.Size = New System.Drawing.Size(129, 29)
        Me.txtbxDownPayment.TabIndex = 1
        Me.txtbxDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmFinanceWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.scMain)
        Me.Name = "frmFinanceWizard"
        Me.Text = "Finance Wizard"
        Me.tlpButtons.ResumeLayout(False)
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.panelMortgageCalc.ResumeLayout(False)
        Me.panelMortgageCalc.PerformLayout()
        Me.panelInvestmentTracker.ResumeLayout(False)
        Me.panelInvestmentTracker.PerformLayout()
        Me.panelExpenseTracker.ResumeLayout(False)
        Me.panelExpenseTracker.PerformLayout()
        Me.panelCalendar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnExpense As Button
    Friend WithEvents btnInvestment As Button
    Friend WithEvents btnMortgage As Button
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents scMain As SplitContainer
    Friend WithEvents panelCalendar As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents panelMortgageCalc As Panel
    Friend WithEvents txtbxAnnualInterest As TextBox
    Friend WithEvents txtbxLoanFees As TextBox
    Friend WithEvents txtbxLoanAmount As TextBox
    Friend WithEvents lblMortgageTerm As Label
    Friend WithEvents lblAnnualInterest As Label
    Friend WithEvents lblLoanFees As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents panelInvestmentTracker As Panel
    Friend WithEvents panelExpenseTracker As Panel
    Friend WithEvents cbMortgageTerm As ComboBox
    Friend WithEvents lblInvestmentTracker As Label
    Friend WithEvents lbExpenseTracker As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtbxDownPayment As TextBox
    Friend WithEvents lblDownPayment As Label
End Class
