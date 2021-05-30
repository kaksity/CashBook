Public Class frmRevenueRegister
    Dim newRecord As Boolean = False
    Dim tblAccounts As New dbO.Table
    Dim tblTransactions As New dbO.Table
    Dim logger As New logger

    Private Sub enable()
        cboAccount.Enabled = True
        dtpDateOfTransaction.Enabled = True
        txtDebit.Enabled = True
        cboDescription.Enabled = True
        txtReceipts.Enabled = True
        txtRVNumber.Enabled = True
        txtSubhead.Enabled = True
        txtNameOfPayee.Enabled = True
        btnNew.Enabled = False
        btnUndo.Enabled = True
        btnSave.Enabled = True
    End Sub
    Private Sub disable()

        cboAccount.Enabled = False
        dtpDateOfTransaction.Enabled = False
        txtDebit.Enabled = False
        cboDescription.Enabled = False
        txtReceipts.Enabled = False
        txtRVNumber.Enabled = False
        txtNameOfPayee.Enabled = False
        txtSubhead.Enabled = False
        btnNew.Enabled = True
        btnUndo.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub clear()
        txtDebit.Text = ""
        txtReceipts.Text = ""
        txtRVNumber.Text = ""
        txtSubhead.Text = ""
        txtNameOfPayee.Text = ""
    End Sub

    Private Sub loadAccountsData()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM accounts WHERE is_deleted=0"

        tblAccounts.Rows.Clear()
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Exit Sub

        cboAccount.DisplayMember = "name"
        cboAccount.ValueMember = "number"
        cboAccount.DataSource = tblAccounts
    End Sub

    Private Sub frmRevenueRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub loadDescription()
        Dim tblDescription As New dbO.Table

        tblDescription.Clear()
        tblDescription = connection.Fetch("SELECT * FROM transaction_description WHERE type_of_transaction = 'INCOME' AND is_deleted=0")
        If tblDescription.Rows.Count = 0 Then Exit Sub

        cboDescription.DisplayMember = "description_name"
        cboDescription.ValueMember = "ukey"
        cboDescription.DataSource = tblDescription
    End Sub
    Private Sub reset()
        loadAccountsData()
        clear()
        newRecord = False
        disable()
        initializeTransaction()
        loadDescription()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        Dim tblVerifyTransaction As New dbO.Table
        If newRecord = True Then
            If txtRVNumber.Text = "" Then
                MessageBox.Show("RV Number is required", Application.ProductName)
                txtRVNumber.Focus()
                Exit Sub
            End If
            If txtReceipts.Text = "" Then
                MessageBox.Show("Receipts is required", Application.ProductName)
                txtReceipts.Focus()
                Exit Sub
            End If
            If txtSubhead.Text = "" Then
                MessageBox.Show("Subhead is required", Application.ProductName)
                txtSubhead.Focus()
                Exit Sub
            End If
            If cboDescription.Text = "" Then
                MessageBox.Show("Description is required", Application.ProductName)
                cboDescription.Focus()
                Exit Sub
            End If
            If txtDebit.Text = "" Then
                MessageBox.Show("Debit Ammount is required", Application.ProductName)
                txtDebit.Focus()
                Exit Sub
            End If
            If txtNameOfPayee.Text = "" Then
                MessageBox.Show("Name of Payee is required", Application.ProductName)
                txtNameOfPayee.Focus()
                Exit Sub
            End If

            If IsNumeric(txtDebit.Text) = False Then
                MessageBox.Show("Debit Account must be numeric", Application.ProductName)
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to add this transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes

                    Dim sqlQuery As String
                    Dim tblMaintainBalance As New dbO.Table
                    Dim dateEntered As Date
                    Dim duration As String

                    dateEntered = CDate(dtpDateOfTransaction.Value)
                    duration = CStr(dateEntered.Month) + "." + CStr(dateEntered.Year)

                    sqlQuery = $"SELECT * FROM maintain_balance WHERE account_number = '{CStr(cboAccount.SelectedValue)}' AND duration = '{ duration }' AND is_deleted=0"
                    tblMaintainBalance.Clear()
                    tblMaintainBalance = connection.Fetch(sqlQuery)

                    If tblMaintainBalance.Rows.Count = 0 Then
                        MessageBox.Show("Cannot Perform Transaction. Date Must be Within this month", Application.ProductName)
                        Exit Sub
                    End If

                    If CLng(tblMaintainBalance.Rows(0).Item("closing_balance")) <> 0 Then
                        MessageBox.Show("Cannot Perform Transaction. Financial Month has been closed", Application.ProductName)
                        Exit Sub
                    End If

                    ''Store the transactions
                    tblTransactions.Addnew()
                    tblTransactions.Fields("account_number") = cboAccount.SelectedValue
                    tblTransactions.Fields("initial_balance") = tblAccounts.Rows(0).Item("current_balance")
                    tblTransactions.Fields("final_balance") = CStr(Val(tblAccounts.Rows(0).Item("current_balance")) + Val(txtDebit.Text))
                    tblTransactions.Fields("ammount_withdrawn") = "0"
                    tblTransactions.Fields("ammount_deposited") = txtDebit.Text.Trim
                    tblTransactions.Fields("name_of_beneficiary") = txtNameOfPayee.Text.ToUpper.Trim
                    tblTransactions.Fields("date_of_transaction") = dtpDateOfTransaction.Value
                    tblTransactions.Fields("pv_or_rv_number") = txtRVNumber.Text.ToUpper.Trim
                    tblTransactions.Fields("description_of_transaction") = cboDescription.SelectedValue
                    tblTransactions.Fields("subhead_column") = txtSubhead.Text.Trim.ToUpper
                    tblTransactions.Fields("approved_by") = CStr(userID)
                    tblAccounts.Fields("is_deleted") = 0

                    tblTransactions.Update()

                    ''Update the current balance 
                    tblAccounts.Move(cboAccount.SelectedIndex)
                    tblAccounts.Fields("current_balance") = CStr((Val(tblAccounts.Fields("current_balance")) + Val(txtDebit.Text.Trim)))
                    tblAccounts.Update()
                    logger.createTransaction(userID, cboAccount.SelectedValue, txtDebit.Text.Trim, "INCOME", txtNameOfPayee.Text.Trim.ToUpper)
                    MessageBox.Show("Transaction was added successfully", Application.ProductName)
                    reset()

                Case dialog.No
                    reset()
            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newRecord = True
        enable()
        clear()
    End Sub
    Private Sub initializeTransaction()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE is_deleted=0 AND UKEY = -1"
        tblTransactions.Clear()
        tblTransactions = connection.Fetch(sqlQuery)
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        reset()
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged
        Try
            lblAccountBalance.Text = "N" + FormatNumber(tblAccounts.Rows(cboAccount.SelectedIndex).Item("current_balance"))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAddDescription_Click(sender As Object, e As EventArgs) Handles btnAddDescription.Click
        frmTransactionDescription.ShowDialog()
        loadAccountsData()
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        frmAccount.ShowDialog()
        loadDescription()
    End Sub
End Class