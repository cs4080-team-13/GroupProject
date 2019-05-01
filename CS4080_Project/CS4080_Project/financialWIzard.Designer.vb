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
        Me.btnExpense = New System.Windows.Forms.Button()
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
        Me.lblPaymentSchedule = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.panelExpenseTracker = New System.Windows.Forms.Panel()
        Me.lbExpenseTracker = New System.Windows.Forms.Label()
        Me.lsvSchedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpButtons.SuspendLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.panelMortgageCalc.SuspendLayout()
        Me.panelExpenseTracker.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExpense
        '
        Me.btnExpense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpense.Location = New System.Drawing.Point(3, 3)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(94, 86)
        Me.btnExpense.TabIndex = 1
        Me.btnExpense.Text = "Expense Tracker"
        Me.btnExpense.UseVisualStyleBackColor = True
        '
        'btnMortgage
        '
        Me.btnMortgage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMortgage.Location = New System.Drawing.Point(3, 95)
        Me.btnMortgage.Name = "btnMortgage"
        Me.btnMortgage.Size = New System.Drawing.Size(94, 87)
        Me.btnMortgage.TabIndex = 2
        Me.btnMortgage.Text = "Mortgage Calculator"
        Me.btnMortgage.UseVisualStyleBackColor = True
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Controls.Add(Me.btnExpense, 0, 0)
        Me.tlpButtons.Controls.Add(Me.btnMortgage, 0, 1)
        Me.tlpButtons.Location = New System.Drawing.Point(0, 0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 2
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(100, 185)
        Me.tlpButtons.TabIndex = 1
        '
        'scMain
        '
        Me.scMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.scMain.Panel1.Controls.Add(Me.tlpButtons)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.panelMortgageCalc)
        Me.scMain.Panel2.Controls.Add(Me.panelExpenseTracker)
        Me.scMain.Size = New System.Drawing.Size(1084, 661)
        Me.scMain.SplitterDistance = 133
        Me.scMain.TabIndex = 2
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
        Me.panelMortgageCalc.Controls.Add(Me.lblPaymentSchedule)
        Me.panelMortgageCalc.Controls.Add(Me.lblLoanAmount)
        Me.panelMortgageCalc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMortgageCalc.Location = New System.Drawing.Point(0, 0)
        Me.panelMortgageCalc.Name = "panelMortgageCalc"
        Me.panelMortgageCalc.Size = New System.Drawing.Size(947, 661)
        Me.panelMortgageCalc.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculate.Location = New System.Drawing.Point(21, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 37)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'cbMortgageTerm
        '
        Me.cbMortgageTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbMortgageTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMortgageTerm.FormattingEnabled = True
        Me.cbMortgageTerm.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cbMortgageTerm.Location = New System.Drawing.Point(21, 223)
        Me.cbMortgageTerm.Name = "cbMortgageTerm"
        Me.cbMortgageTerm.Size = New System.Drawing.Size(121, 29)
        Me.cbMortgageTerm.TabIndex = 4
        '
        'txtbxAnnualInterest
        '
        Me.txtbxAnnualInterest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAnnualInterest.Location = New System.Drawing.Point(21, 161)
        Me.txtbxAnnualInterest.Name = "txtbxAnnualInterest"
        Me.txtbxAnnualInterest.Size = New System.Drawing.Size(129, 29)
        Me.txtbxAnnualInterest.TabIndex = 3
        Me.txtbxAnnualInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbxLoanFees
        '
        Me.txtbxLoanFees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLoanFees.Location = New System.Drawing.Point(21, 95)
        Me.txtbxLoanFees.Name = "txtbxLoanFees"
        Me.txtbxLoanFees.Size = New System.Drawing.Size(129, 29)
        Me.txtbxLoanFees.TabIndex = 2
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
        'lblPaymentSchedule
        '
        Me.lblPaymentSchedule.AutoSize = True
        Me.lblPaymentSchedule.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPaymentSchedule.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblPaymentSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPaymentSchedule.Location = New System.Drawing.Point(183, 14)
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
        'panelExpenseTracker
        '
        Me.panelExpenseTracker.Controls.Add(Me.lbExpenseTracker)
        Me.panelExpenseTracker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelExpenseTracker.Location = New System.Drawing.Point(0, 0)
        Me.panelExpenseTracker.Name = "panelExpenseTracker"
        Me.panelExpenseTracker.Size = New System.Drawing.Size(947, 661)
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
        'lsvSchedule
        '
        Me.lsvSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lsvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lsvSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSchedule.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lsvSchedule.Location = New System.Drawing.Point(188, 44)
        Me.lsvSchedule.Name = "lsvSchedule"
        Me.lsvSchedule.Size = New System.Drawing.Size(618, 521)
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
        'frmFinanceWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1084, 661)
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
        Me.panelExpenseTracker.ResumeLayout(False)
        Me.panelExpenseTracker.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExpense As Button
    Friend WithEvents btnMortgage As Button
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents scMain As SplitContainer
    Friend WithEvents panelMortgageCalc As Panel
    Friend WithEvents txtbxAnnualInterest As TextBox
    Friend WithEvents txtbxLoanFees As TextBox
    Friend WithEvents txtbxLoanAmount As TextBox
    Friend WithEvents lblMortgageTerm As Label
    Friend WithEvents lblAnnualInterest As Label
    Friend WithEvents lblLoanFees As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents panelExpenseTracker As Panel
    Friend WithEvents cbMortgageTerm As ComboBox
    Friend WithEvents lbExpenseTracker As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPaymentSchedule As Label
    Friend WithEvents lsvSchedule As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
