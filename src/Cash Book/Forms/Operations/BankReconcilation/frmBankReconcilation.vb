Public Class frmBankReconcilation
    Dim newRecord As Boolean = False
    Dim tblBankReconcilation As New dbO.Table
    Dim logger As New logger
    Dim tblAccounts As New dbO.Table

    Private Sub initBankReconcilation()
        Dim sqlQuery As String

        tblBankReconcilation.Clear()

        sqlQuery = "SELECT * FROM bank_reconcilation WHERE ukey = -1"
        tblBankReconcilation = connection.Fetch(sqlQuery)
    End Sub
    Private Sub disable()

        cboAccount.Enabled = False
        cboMonths.Enabled = False
        cboYears.Enabled = False
        txtBankCharges.Enabled = False
        txtCreditTransfer.Enabled = False
        txtDebitTransfer.Enabled = False
        txtInterestReceived.Enabled = False
        txtItemsInBankNotCashBook.Enabled = False
        txtItemsInCashBookNotBank.Enabled = False
        txtOutstandingStaleChqs.Enabled = False
        txtStaleChqsReversed.Enabled = False
        txtUncreditedLodgement.Enabled = False
        txtUnpresentedChqs.Enabled = False

        btnNew.Enabled = True
        btnSave.Enabled = False
        btnClose.Enabled = True
        btnUndo.Enabled = False

    End Sub

    Private Sub enable()

        cboAccount.Enabled = True
        cboMonths.Enabled = True
        cboYears.Enabled = True
        txtBankCharges.Enabled = True
        txtCreditTransfer.Enabled = True
        txtDebitTransfer.Enabled = True
        txtInterestReceived.Enabled = True
        txtItemsInBankNotCashBook.Enabled = True
        txtItemsInCashBookNotBank.Enabled = True
        txtOutstandingStaleChqs.Enabled = True
        txtStaleChqsReversed.Enabled = True
        txtUncreditedLodgement.Enabled = True
        txtUnpresentedChqs.Enabled = True

        btnUndo.Enabled = True
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnClose.Enabled = True
    End Sub

    Private Sub clear()

        cboAccount.Text = ""
        cboMonths.Text = ""
        cboYears.Text = ""
        txtBankCharges.Text = ""
        txtCreditTransfer.Text = ""
        txtDebitTransfer.Text = ""
        txtInterestReceived.Text = ""
        txtItemsInBankNotCashBook.Text = ""
        txtItemsInCashBookNotBank.Text = ""
        txtOutstandingStaleChqs.Text = ""
        txtStaleChqsReversed.Text = ""
        txtUncreditedLodgement.Text = ""
        txtUnpresentedChqs.Text = ""

    End Sub

    Private Sub loadAccounts()
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM ACCOUNTS"
        tblAccounts.Rows.Clear()

        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Exit Sub

        cboAccount.DisplayMember = "name"
        cboAccount.ValueMember = "number"
        cboAccount.DataSource = tblAccounts
    End Sub

    Private Sub loadYears()
        Dim tblYears As New DataTable
        Dim currentYear As Integer

        currentYear = 2020

        tblYears.Columns.Add("name", GetType(String))
        tblYears.Columns.Add("value", GetType(Integer))

        While currentYear <= DateAndTime.Year(DateAndTime.Now)
            tblYears.Rows.Add(CStr(currentYear), CInt(currentYear))
            currentYear += 1
        End While

        cboYears.DisplayMember = "name"
        cboYears.ValueMember = "value"
        cboYears.DataSource = tblYears
    End Sub
    Private Sub loadMonths()
        Dim tblMonths As New DataTable

        tblMonths.Columns.Add("name", GetType(String))
        tblMonths.Columns.Add("value", GetType(Integer))

        tblMonths.Rows.Add("", 0)
        tblMonths.Rows.Add("January", 1)
        tblMonths.Rows.Add("February", 2)
        tblMonths.Rows.Add("March", 3)
        tblMonths.Rows.Add("April", 4)
        tblMonths.Rows.Add("May", 5)
        tblMonths.Rows.Add("June", 6)
        tblMonths.Rows.Add("July", 7)
        tblMonths.Rows.Add("August", 8)
        tblMonths.Rows.Add("September", 9)
        tblMonths.Rows.Add("October", 10)
        tblMonths.Rows.Add("November", 11)
        tblMonths.Rows.Add("December", 12)

        cboMonths.DisplayMember = "name"
        cboMonths.ValueMember = "value"
        cboMonths.DataSource = tblMonths
    End Sub


    Private Sub frmBankReconcilation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
        clear()
        loadAccounts()
        loadMonths()
        loadYears()
        initBankReconcilation()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        enable()
        clear()
        newRecord = True
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        disable()
        clear()
        newRecord = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim dialog As DialogResult

        If newRecord = True Then
            'Verify If All the Necesary InPuts are given
            If cboAccount.SelectedValue = "" Or cboAccount.Text = "" Then

                MessageBox.Show("Account is Required", Application.ProductName)
                cboAccount.Focus()
                Exit Sub

            End If

            If cboMonths.SelectedValue = 0 Or cboMonths.Text = "" Then

                MessageBox.Show("Months is required", Application.ProductName)
                cboMonths.Focus()
                Exit Sub

            End If

            If cboYears.SelectedValue > 2020 Or cboYears.Text = "" Then

                MessageBox.Show("Years is required", Application.ProductName)
                cboYears.Focus()
                Exit Sub

            End If

            If txtCreditTransfer.Text = "" Then
                MessageBox.Show("Credit Transfer is required", Application.ProductName)
                txtCreditTransfer.Focus()
                Exit Sub
            End If

            If txtInterestReceived.Text = "" Then
                MessageBox.Show("Interest Received is required", Application.ProductName)
                txtInterestReceived.Focus()
                Exit Sub
            End If
            If txtStaleChqsReversed.Text = "" Then
                MessageBox.Show("Stale Cheque Reversed is required", Application.ProductName)
                txtStaleChqsReversed.Focus()
                Exit Sub
            End If

            If txtBankCharges.Text = "" Then
                MessageBox.Show("Bank Charges is required", Application.ProductName)
                txtBankCharges.Focus()
                Exit Sub
            End If
            If txtDebitTransfer.Text = "" Then
                MessageBox.Show("Debit Transfer is required", Application.ProductName)
                txtDebitTransfer.Focus()
                Exit Sub
            End If

            If txtOutstandingStaleChqs.Text = "" Then
                MessageBox.Show("Outstanding Stale Cheques is required", Application.ProductName)
                txtOutstandingStaleChqs.Focus()
                Exit Sub
            End If

            If txtUnpresentedChqs.Text = "" Then
                MessageBox.Show("Unpresented Cheques is required")
                txtUnpresentedChqs.Focus()
                Exit Sub
            End If
            If txtItemsInBankNotCashBook.Text = "" Then
                MessageBox.Show("Items in Bank not in Cash Book is required", Application.ProductName)
                txtItemsInBankNotCashBook.Focus()
                Exit Sub
            End If
            If txtUncreditedLodgement.Text = "" Then
                MessageBox.Show("Uncredited Lodgements is required", Application.ProductName)
                txtUncreditedLodgement.Focus()
                Exit Sub
            End If
            If txtItemsInCashBookNotBank.Text = "" Then
                MessageBox.Show("Items in Cash Book not in Bank is required", Application.ProductName)
                txtItemsInCashBookNotBank.Focus()
                Exit Sub
            End If

            'Check if the data are in the right format
            If IsNumeric(txtCreditTransfer.Text) = False Then
                MessageBox.Show("Credit Transfer must be numeric", Application.ProductName)
                txtCreditTransfer.Focus()
                Exit Sub
            End If

            If IsNumeric(txtInterestReceived.Text) = False Then
                MessageBox.Show("Interest Received must be numeric", Application.ProductName)
                txtInterestReceived.Focus()
                Exit Sub
            End If

            If IsNumeric(txtStaleChqsReversed.Text) = False Then
                MessageBox.Show("Stale Cheques Reversed must be numeric", Application.ProductName)
                txtStaleChqsReversed.Focus()
                Exit Sub
            End If

            If IsNumeric(txtBankCharges.Text) = False Then
                MessageBox.Show("Bank Charges must be numeric", Application.ProductName)
                txtBankCharges.Focus()
                Exit Sub
            End If

            If IsNumeric(txtDebitTransfer.Text) = False Then
                MessageBox.Show("Debit Transfer must be numeric", Application.ProductName)
                txtDebitTransfer.Focus()
                Exit Sub
            End If

            If IsNumeric(txtOutstandingStaleChqs.Text) = False Then
                MessageBox.Show("Outstanding Stale Cheques must be numeric", Application.ProductName)
                txtOutstandingStaleChqs.Focus()
                Exit Sub
            End If

            If IsNumeric(txtUnpresentedChqs.Text) = False Then
                MessageBox.Show("Unpresented Cheques must be numeric", Application.ProductName)
                txtUnpresentedChqs.Focus()
                Exit Sub
            End If
            If IsNumeric(txtItemsInBankNotCashBook.Text) = False Then
                MessageBox.Show("Items in Bank and not in Cash Book must be numeric", Application.ProductName)
                txtItemsInBankNotCashBook.Focus()
                Exit Sub

            End If
            If IsNumeric(txtUncreditedLodgement.Text) = False Then
                MessageBox.Show("Uncredited Lodgement must be numeric", Application.ProductName)
                txtUncreditedLodgement.Focus()
                Exit Sub
            End If
            If IsNumeric(txtItemsInCashBookNotBank.Text) = False Then
                MessageBox.Show("Items in Cash Book and not in Bank must be numeric")
                txtItemsInCashBookNotBank.Focus()
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to create a new bank reconcilation record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes

                    Dim accountOpenedDate As New Date
                    Dim sqlQuery As String
                    'Check if the Month is correct
                    tblAccounts.Move(cboAccount.SelectedIndex)
                    accountOpenedDate = CDate(tblAccounts.Fields("opening_date"))

                    If (accountOpenedDate.Month > cboMonths.SelectedValue) Or (accountOpenedDate.Year > cboYears.SelectedValue) Then
                        MessageBox.Show("Could Not Generate Bank reconcilation as month selected is less than date of opening account", Application.ProductName)
                        Exit Sub
                    End If


                    Dim sqlStrQuery As String
                    Dim duration As String
                    Dim tblCheckMaintainBalance As New dbO.Table

                    duration = CStr(cboMonths.SelectedValue) + "." + CStr(cboYears.SelectedValue)
                    sqlStrQuery = "SELECT * FROM MAINTAIN_BALANCE WHERE account_number='" + CStr(cboAccount.SelectedValue) + "' AND duration='" + duration + "'"

                    tblCheckMaintainBalance.Clear()

                    tblCheckMaintainBalance = connection.FetchLight(sqlStrQuery)

                    If tblCheckMaintainBalance.RowCount = 0 Then
                        MessageBox.Show("You must close previous month before generating bank reconcilation for present month", Application.ProductName)
                        Exit Sub
                    End If
                    'Before Adding a new bank reconcilation check if it has been generate already
                    If isBankReconcilationGenerated(cboAccount.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue) = True Then
                        MessageBox.Show("Bank Reconcilation for this month has already been generated", Application.ProductName)
                        disable()
                        clear()
                        Exit Sub
                    End If

                    tblBankReconcilation.Addnew()

                    tblBankReconcilation.Fields("ACCOUNT_NUMBER") = CStr(cboAccount.SelectedValue)
                    tblBankReconcilation.Fields("duration") = CStr(cboMonths.SelectedValue) + "/" + CStr(cboYears.SelectedValue)
                    tblBankReconcilation.Fields("credit_transfer") = txtCreditTransfer.Text.Trim
                    tblBankReconcilation.Fields("interest_received") = txtInterestReceived.Text.Trim
                    tblBankReconcilation.Fields("stale_chqs_reversed") = txtStaleChqsReversed.Text.Trim
                    tblBankReconcilation.Fields("bank_charges") = txtBankCharges.Text.Trim
                    tblBankReconcilation.Fields("debit_transfer") = txtDebitTransfer.Text.Trim
                    tblBankReconcilation.Fields("outstanding_stale_chqs") = txtOutstandingStaleChqs.Text.Trim
                    tblBankReconcilation.Fields("unpresented_chqs") = txtUnpresentedChqs.Text.Trim
                    tblBankReconcilation.Fields("bank_not_cashbook") = txtItemsInBankNotCashBook.Text.Trim
                    tblBankReconcilation.Fields("uncredited_lodgements") = txtUncreditedLodgement.Text.Trim
                    tblBankReconcilation.Fields("cashbook_not_bank") = txtItemsInCashBookNotBank.Text.Trim
                    tblBankReconcilation.Fields("diff_btw_bank_and_cashbook") = "0"

                    tblBankReconcilation.Update()
                    logger.createBankReconcilation(userID, cboAccount.SelectedValue, CStr(cboMonths.SelectedValue) + "/" + CStr(cboYears.SelectedValue))
                    MessageBox.Show("New Bank Reconcilation record was created successfully", Application.ProductName)
                    clear()
                    disable()
                    Exit Sub
                Case dialog.No
                    clear()
                    disable()
                    Exit Sub
            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Function isBankReconcilationGenerated(accountNumber As String, month As Integer, year As Integer) As Boolean
        Dim duration As String
        Dim tblCheckBankReconcilation As New dbO.Table
        Dim sqlQuery As String

        duration = CStr(month) + "/" + CStr(year)

        tblCheckBankReconcilation.Clear()
        sqlQuery = "SELECT * FROM bank_reconcilation WHERE account_number = '" + accountNumber + "' AND duration = '" + duration + "'"
        tblCheckBankReconcilation = connection.Fetch(sqlQuery)

        If tblCheckBankReconcilation.Rows.Count = 0 Then
            Return False
            Exit Function
        End If
        Return True
    End Function
End Class