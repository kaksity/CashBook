<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenueRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpenseTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpenseItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankReconcilationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFinancialTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankReconcilationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkDescription = New System.Windows.Forms.CheckBox()
        Me.cboDescription = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkTransactionType = New System.Windows.Forms.CheckBox()
        Me.cboTypeOfTransaction = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboAccounts = New System.Windows.Forms.ComboBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLoggedInStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNumberOfRecords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlbExpenseTransaction = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbRevenueRegister = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbTransactionItems = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.DataRecoveryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.RevenueRegisterToolStripMenuItem, Me.ExpenseTransactionToolStripMenuItem, Me.ExpenseItemToolStripMenuItem, Me.BankReconcilationToolStripMenuItem, Me.CloseFinancialTransactionToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FileToolStripMenuItem.Text = "&Operations"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'RevenueRegisterToolStripMenuItem
        '
        Me.RevenueRegisterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem1, Me.ViewToolStripMenuItem})
        Me.RevenueRegisterToolStripMenuItem.Name = "RevenueRegisterToolStripMenuItem"
        Me.RevenueRegisterToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.RevenueRegisterToolStripMenuItem.Text = "Revenue Register"
        '
        'CreateToolStripMenuItem1
        '
        Me.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        Me.CreateToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem1.Text = "Create"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ExpenseTransactionToolStripMenuItem
        '
        Me.ExpenseTransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem2, Me.ViewToolStripMenuItem1})
        Me.ExpenseTransactionToolStripMenuItem.Name = "ExpenseTransactionToolStripMenuItem"
        Me.ExpenseTransactionToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ExpenseTransactionToolStripMenuItem.Text = "Expense Transaction"
        '
        'CreateToolStripMenuItem2
        '
        Me.CreateToolStripMenuItem2.Name = "CreateToolStripMenuItem2"
        Me.CreateToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem2.Text = "Create"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'ExpenseItemToolStripMenuItem
        '
        Me.ExpenseItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem3})
        Me.ExpenseItemToolStripMenuItem.Name = "ExpenseItemToolStripMenuItem"
        Me.ExpenseItemToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ExpenseItemToolStripMenuItem.Text = "Transaction Description Item"
        '
        'CreateToolStripMenuItem3
        '
        Me.CreateToolStripMenuItem3.Name = "CreateToolStripMenuItem3"
        Me.CreateToolStripMenuItem3.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem3.Text = "Create"
        '
        'BankReconcilationToolStripMenuItem
        '
        Me.BankReconcilationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem4})
        Me.BankReconcilationToolStripMenuItem.Name = "BankReconcilationToolStripMenuItem"
        Me.BankReconcilationToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.BankReconcilationToolStripMenuItem.Text = "Bank Reconcilation"
        '
        'CreateToolStripMenuItem4
        '
        Me.CreateToolStripMenuItem4.Name = "CreateToolStripMenuItem4"
        Me.CreateToolStripMenuItem4.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem4.Text = "Create"
        '
        'CloseFinancialTransactionToolStripMenuItem
        '
        Me.CloseFinancialTransactionToolStripMenuItem.Name = "CloseFinancialTransactionToolStripMenuItem"
        Me.CloseFinancialTransactionToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CloseFinancialTransactionToolStripMenuItem.Text = "Close Financial Transaction"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.OrganizationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HelpToolStripMenuItem.Text = "&Profile"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem2})
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BackupToolStripMenuItem.Text = "&User"
        '
        'ViewToolStripMenuItem2
        '
        Me.ViewToolStripMenuItem2.Name = "ViewToolStripMenuItem2"
        Me.ViewToolStripMenuItem2.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem2.Text = "View"
        '
        'OrganizationToolStripMenuItem
        '
        Me.OrganizationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem3})
        Me.OrganizationToolStripMenuItem.Name = "OrganizationToolStripMenuItem"
        Me.OrganizationToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OrganizationToolStripMenuItem.Text = "Organization"
        '
        'ViewToolStripMenuItem3
        '
        Me.ViewToolStripMenuItem3.Name = "ViewToolStripMenuItem3"
        Me.ViewToolStripMenuItem3.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem3.Text = "View"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.TransactionDescriptionToolStripMenuItem, Me.BankReconcilationToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'TransactionDescriptionToolStripMenuItem
        '
        Me.TransactionDescriptionToolStripMenuItem.Name = "TransactionDescriptionToolStripMenuItem"
        Me.TransactionDescriptionToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TransactionDescriptionToolStripMenuItem.Text = "Transaction Description"
        '
        'BankReconcilationToolStripMenuItem1
        '
        Me.BankReconcilationToolStripMenuItem1.Name = "BankReconcilationToolStripMenuItem1"
        Me.BankReconcilationToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.BankReconcilationToolStripMenuItem1.Text = "Bank Reconcilation"
        '
        'DataRecoveryToolStripMenuItem
        '
        Me.DataRecoveryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalToolStripMenuItem})
        Me.DataRecoveryToolStripMenuItem.Name = "DataRecoveryToolStripMenuItem"
        Me.DataRecoveryToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.DataRecoveryToolStripMenuItem.Text = "&Data Recovery"
        '
        'LocalToolStripMenuItem
        '
        Me.LocalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackUpToolStripMenuItem1, Me.RestoreToolStripMenuItem})
        Me.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem"
        Me.LocalToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.LocalToolStripMenuItem.Text = "&Local"
        '
        'BackUpToolStripMenuItem1
        '
        Me.BackUpToolStripMenuItem1.Name = "BackUpToolStripMenuItem1"
        Me.BackUpToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.BackUpToolStripMenuItem1.Text = "&Back Up"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RestoreToolStripMenuItem.Text = "&Restore"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 126)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnFilter)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1016, 102)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'btnFilter
        '
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Location = New System.Drawing.Point(896, 40)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboYears)
        Me.GroupBox6.Controls.Add(Me.cboMonths)
        Me.GroupBox6.Location = New System.Drawing.Point(668, 20)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(224, 74)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Duration"
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(113, 20)
        Me.cboYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(104, 24)
        Me.cboYears.TabIndex = 0
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(5, 20)
        Me.cboMonths.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(104, 24)
        Me.cboMonths.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkDescription)
        Me.GroupBox5.Controls.Add(Me.cboDescription)
        Me.GroupBox5.Location = New System.Drawing.Point(432, 20)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(231, 74)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Description"
        '
        'chkDescription
        '
        Me.chkDescription.AutoSize = True
        Me.chkDescription.Location = New System.Drawing.Point(5, 47)
        Me.chkDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDescription.Name = "chkDescription"
        Me.chkDescription.Size = New System.Drawing.Size(111, 20)
        Me.chkDescription.TabIndex = 1
        Me.chkDescription.Text = "All Description"
        Me.chkDescription.UseVisualStyleBackColor = True
        '
        'cboDescription
        '
        Me.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(5, 20)
        Me.cboDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(223, 24)
        Me.cboDescription.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkTransactionType)
        Me.GroupBox4.Controls.Add(Me.cboTypeOfTransaction)
        Me.GroupBox4.Location = New System.Drawing.Point(219, 20)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(209, 74)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type Of Transaction"
        '
        'chkTransactionType
        '
        Me.chkTransactionType.AutoSize = True
        Me.chkTransactionType.Location = New System.Drawing.Point(5, 47)
        Me.chkTransactionType.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTransactionType.Name = "chkTransactionType"
        Me.chkTransactionType.Size = New System.Drawing.Size(144, 20)
        Me.chkTransactionType.TabIndex = 1
        Me.chkTransactionType.Text = "All Transaction Type"
        Me.chkTransactionType.UseVisualStyleBackColor = True
        '
        'cboTypeOfTransaction
        '
        Me.cboTypeOfTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeOfTransaction.FormattingEnabled = True
        Me.cboTypeOfTransaction.Location = New System.Drawing.Point(5, 20)
        Me.cboTypeOfTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTypeOfTransaction.Name = "cboTypeOfTransaction"
        Me.cboTypeOfTransaction.Size = New System.Drawing.Size(201, 24)
        Me.cboTypeOfTransaction.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboAccounts)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(209, 74)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accounts"
        '
        'cboAccounts
        '
        Me.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(5, 20)
        Me.cboAccounts.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(201, 24)
        Me.cboAccounts.TabIndex = 0
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(9, 184)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1035, 281)
        Me.grid.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblLoggedInStatus, Me.ToolStripStatusLabel2, Me.lblNumberOfRecords})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1055, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lblLoggedInStatus
        '
        Me.lblLoggedInStatus.Name = "lblLoggedInStatus"
        Me.lblLoggedInStatus.Size = New System.Drawing.Size(120, 17)
        Me.lblLoggedInStatus.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'lblNumberOfRecords
        '
        Me.lblNumberOfRecords.Name = "lblNumberOfRecords"
        Me.lblNumberOfRecords.Size = New System.Drawing.Size(120, 17)
        Me.lblNumberOfRecords.Text = "ToolStripStatusLabel3"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbExpenseTransaction, Me.ToolStripSeparator1, Me.tlbRevenueRegister, Me.ToolStripSeparator2, Me.tlbTransactionItems, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1055, 32)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlbExpenseTransaction
        '
        Me.tlbExpenseTransaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbExpenseTransaction.Image = CType(resources.GetObject("tlbExpenseTransaction.Image"), System.Drawing.Image)
        Me.tlbExpenseTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbExpenseTransaction.Name = "tlbExpenseTransaction"
        Me.tlbExpenseTransaction.Size = New System.Drawing.Size(23, 29)
        Me.tlbExpenseTransaction.Text = "Expense Transaction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'tlbRevenueRegister
        '
        Me.tlbRevenueRegister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbRevenueRegister.Image = CType(resources.GetObject("tlbRevenueRegister.Image"), System.Drawing.Image)
        Me.tlbRevenueRegister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbRevenueRegister.Name = "tlbRevenueRegister"
        Me.tlbRevenueRegister.Size = New System.Drawing.Size(23, 29)
        Me.tlbRevenueRegister.Text = "Revenue Register"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'tlbTransactionItems
        '
        Me.tlbTransactionItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbTransactionItems.Image = CType(resources.GetObject("tlbTransactionItems.Image"), System.Drawing.Image)
        Me.tlbTransactionItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbTransactionItems.Name = "tlbTransactionItems"
        Me.tlbTransactionItems.Size = New System.Drawing.Size(23, 29)
        Me.tlbTransactionItems.Text = "Transaction Description Items"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 489)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevenueRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpenseTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpenseItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BankReconcilationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents OrganizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseFinancialTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BankReconcilationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkDescription As CheckBox
    Friend WithEvents cboDescription As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkTransactionType As CheckBox
    Friend WithEvents cboTypeOfTransaction As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblLoggedInStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblNumberOfRecords As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tlbExpenseTransaction As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tlbRevenueRegister As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tlbTransactionItems As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DataRecoveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackUpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
End Class
