Public Class frmTransaction
    Dim tblAccounts As New dbO.Table
    Dim tblTransactions As New dbO.Table
    Dim newRecord As Boolean = False
    Dim logger As New logger
    Private Sub reset()
        loadAccounts()
        clear()
        initializeTransaction()
        disable()
        loadDescription()
    End Sub

    Private Sub btnSupportingDocument_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        If newRecord = True Then

            If txtPVNumber.Text = "" Then
                MessageBox.Show("PV Number is required", Application.ProductName)
                txtPVNumber.Focus()
                Exit Sub
            End If

            If txtRefNumber.Text = "" Then
                MessageBox.Show("Ref Number is required", Application.ProductName)
                txtRefNumber.Focus()
                Exit Sub
            End If

            If txtSubheadColumn.Text = "" Then
                MessageBox.Show("Sub Head Column is required", Application.ProductName)
                txtSubheadColumn.Focus()
                Exit Sub
            End If

            If txtAmmountWithDrawn.Text = "" Then
                MessageBox.Show("Ammount Withdrawn is required", Application.ProductName)
                txtAmmountWithDrawn.Focus()
                Exit Sub
            End If
            If txtBeneficiary.Text = "" Then
                MessageBox.Show("Beneficiary Name is required", Application.ProductName)
                txtBeneficiary.Focus()
                Exit Sub
            End If

            If IsNumeric(txtAmmountWithDrawn.Text) = False Then
                MessageBox.Show("Ammount withdrawn must be numeric", Application.ProductName)
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to add this transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes

                    Dim dateEntered As Date
                    Dim duration As String
                    Dim sqlQuery As String
                    Dim tblMaintainBalance As New dbO.Table


                    dateEntered = CDate(dtpDateOfTransaction.Value)
                    duration = CStr(dateEntered.Month) + "." + CStr(dateEntered.Year)

                    sqlQuery = "SELECT * FROM maintain_balance WHERE account_number = '" + CStr(cboAccounts.SelectedValue) + "' AND duration = '" + duration + "'"
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
                    tblTransactions.Fields("account_number") = cboAccounts.SelectedValue
                    tblTransactions.Fields("initial_balance") = tblAccounts.Rows(cboAccounts.SelectedIndex).Item("current_balance")
                    tblTransactions.Fields("final_balance") = CStr(Val(tblAccounts.Rows(cboAccounts.SelectedIndex).Item("current_balance")) - Val(txtAmmountWithDrawn.Text.Trim))
                    tblTransactions.Fields("ammount_withdrawn") = txtAmmountWithDrawn.Text.Trim
                    tblTransactions.Fields("ammount_deposited") = "0"
                    tblTransactions.Fields("name_of_beneficiary") = txtBeneficiary.Text.ToUpper.Trim
                    tblTransactions.Fields("date_of_transaction") = dtpDateOfTransaction.Value
                    tblTransactions.Fields("pv_or_rv_number") = txtPVNumber.Text.ToUpper.Trim
                    tblTransactions.Fields("description_of_transaction") = cboDescription.SelectedValue
                    tblTransactions.Fields("subhead_column") = txtSubheadColumn.Text.Trim.ToUpper
                    tblTransactions.Fields("ref_number") = txtRefNumber.Text.Trim
                    tblTransactions.Fields("approved_by") = "kaksity"

                    tblTransactions.Update()

                    ''Update the current balance 
                    tblAccounts.Move(cboAccounts.SelectedIndex)
                    tblAccounts.Fields("current_balance") = CStr((Val(tblAccounts.Fields("current_balance")) - Val(txtAmmountWithDrawn.Text)))
                    tblAccounts.Update()

                    logger.createTransaction(userID, cboAccounts.SelectedValue, txtAmmountWithDrawn.Text.Trim, "EXPENSE", txtBeneficiary.Text.Trim.ToUpper)
                    MessageBox.Show("Transaction was added successfully", Application.ProductName)
                    reset()
                Case dialog.No
                    reset()
            End Select

        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub clear()
        txtAmmountWithDrawn.Text = ""
        txtBeneficiary.Text = ""
        txtPVNumber.Text = ""
        txtRefNumber.Text = ""
        txtSubheadColumn.Text = ""
    End Sub

    Private Sub enable()
        dtpDateOfTransaction.Enabled = True
        cboAccounts.Enabled = True
        cboDescription.Enabled = True
        txtAmmountWithDrawn.Enabled = True
        txtBeneficiary.Enabled = True
        txtPVNumber.Enabled = True
        txtRefNumber.Enabled = True
        txtSubheadColumn.Enabled = True
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub disable()
        dtpDateOfTransaction.Enabled = False
        cboAccounts.Enabled = False
        cboDescription.Enabled = False
        txtAmmountWithDrawn.Enabled = False
        txtBeneficiary.Enabled = False
        txtPVNumber.Enabled = False
        txtRefNumber.Enabled = False
        txtSubheadColumn.Enabled = False
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnUndo.Enabled = False
    End Sub

    Private Sub loadAccounts()
        Dim sqlQuery As String

        tblAccounts.Clear()

        sqlQuery = "SELECT * FROM ACCOUNTS"
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Exit Sub

        cboAccounts.DisplayMember = "name"
        cboAccounts.ValueMember = "number"
        cboAccounts.DataSource = tblAccounts

    End Sub

    Private Sub initializeTransaction()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE UKEY = -1"
        tblTransactions.Clear()
        tblTransactions = connection.Fetch(sqlQuery)
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        reset()
        newRecord = False
    End Sub
    Private Sub loadDescription()
        Dim tblDescription As New dbO.Table

        tblDescription.Clear()
        tblDescription = connection.Fetch("SELECT * FROM transaction_description WHERE type_of_transaction = 'EXPENSE'")
        If tblDescription.Rows.Count = 0 Then Exit Sub

        cboDescription.DisplayMember = "description_name"
        cboDescription.ValueMember = "ukey"
        cboDescription.DataSource = tblDescription
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        enable()
        clear()
        newRecord = True
    End Sub

    Private Sub cboAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccounts.SelectedIndexChanged
        Try
            tblAccounts.Move(cboAccounts.SelectedIndex)
            lblAccountBalance.Text = "N" + FormatNumber(tblAccounts.Fields("current_balance"))
        Catch
        End Try
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        frmAccount.ShowDialog()
        loadAccounts()
    End Sub

    Private Sub btnAddDescription_Click(sender As Object, e As EventArgs) Handles btnAddDescription.Click
        frmTransactionDescription.ShowDialog()
        loadDescription()

    End Sub
End Class