Public Class frmAccount
    Dim newRecord As Boolean = False
    Dim editRecord As Boolean = False
    Dim tblAccountList As New dbO.Table
    Dim tblMaintainBalance As New dbO.Table
    Dim logger As New logger

    Private Sub initData()
        tblAccountList.Clear()
        tblAccountList = connection.Fetch("SELECT * FROM ACCOUNTS")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        frmSearchForAccount.ShowDialog()
    End Sub
    Private Sub initMaintainBalance()
        Dim sqlQuery As String
        tblMaintainBalance.Clear()
        sqlQuery = "SELECT * FROM maintain_balance WHERE ukey = -1"
        tblMaintainBalance = connection.Fetch(sqlQuery)
    End Sub
    Private Sub enable()
        txtAccountNumber.Enabled = True
        txtBankName.Enabled = True
        txtDescription.Enabled = True
        txtName.Enabled = True
        txtOpeningBalance.Enabled = True
        dtpOpeningDate.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnFind.Enabled = False
        btnSave.Enabled = True
        btnUndo.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub editEnable()
        txtAccountNumber.Enabled = False
        txtBankName.Enabled = True
        txtDescription.Enabled = True
        txtName.Enabled = True
        txtOpeningBalance.Enabled = False
        dtpOpeningDate.Enabled = False
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnFind.Enabled = False
        btnSave.Enabled = True
        btnUndo.Enabled = True
        btnDelete.Enabled = False
    End Sub
    Private Sub disable()
        dtpOpeningDate.Enabled = False
        txtAccountNumber.Enabled = False
        txtBankName.Enabled = False
        txtDescription.Enabled = False
        txtName.Enabled = False
        txtOpeningBalance.Enabled = False
        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnFind.Enabled = True
        btnSave.Enabled = False
        btnUndo.Enabled = False
        btnDelete.Enabled = True
    End Sub

    Private Sub reset()
        clear()
        newRecord = False
        editRecord = False
        PubAccountRowIndex = -1
        disable()
    End Sub

    Private Sub clear()
        txtAccountNumber.Text = ""
        txtBankName.Text = ""
        txtDescription.Text = ""
        txtName.Text = ""
        txtOpeningBalance.Text = ""
        lblCurrentBalance.Text = ""
    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        initData()
        initMaintainBalance()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
        enable()
        newRecord = True
        editRecord = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If PubAccountRowIndex = -1 Then Exit Sub
        editEnable()
        newRecord = False
        editRecord = True
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        reset()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        Dim tblCheckAccount As New dbO.Table
        'Check you are inserting a new record or editing an existing record
        If newRecord = True And editRecord = False Then
            Dim OpeningBalance As String

            If txtName.Text = "" Then
                MessageBox.Show("Account Name is required", Application.ProductName)
                txtName.Focus()
                Exit Sub
            End If
            If txtAccountNumber.Text = "" Then
                MessageBox.Show("Account Number is required", Application.ProductName)
                txtAccountNumber.Focus()
                Exit Sub
            End If
            If txtOpeningBalance.Text = "" Then
                MessageBox.Show("Account Opening Balance is required", Application.ProductName)
                txtOpeningBalance.Focus()
                Exit Sub
            End If

            'Check if the Opening Balance is a valid number
            If txtOpeningBalance.Text.Length < 0 Then
                MessageBox.Show("Opening Balance must be 0 or greater", Application.ProductName)
                txtOpeningBalance.Focus()
                Exit Sub
            End If

            'Account Number must be 10 characters
            If txtAccountNumber.Text.Length <> 10 Then
                MessageBox.Show("Account Number must be 10 characters", Application.ProductName)
                txtAccountNumber.Focus()
                Exit Sub
            End If

            If IsNumeric(txtAccountNumber.Text) = False Then
                MessageBox.Show("Account Number Must Be Numeric", Application.ProductName)
                Exit Sub
            End If

            If IsNumeric(txtOpeningBalance.Text) = False Then
                MessageBox.Show("Opening Balance must be Numerics only", Application.ProductName)
                txtOpeningBalance.Focus()
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to create this account", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes

                    Dim sqlQuery As String
                    Dim duration As String
                    Dim dateEntered As Date
                    'Check if Account Already exist
                    tblCheckAccount = connection.Fetch("SELECT * FROM accounts WHERE number = '" + txtAccountNumber.Text.Trim + "'")

                    tblCheckAccount.Rows.Clear()
                    If tblCheckAccount.Rows.Count <> 0 Then
                        MessageBox.Show("Account Already Exist", Application.ProductName)
                        Exit Sub
                    End If


                    Try
                        'Insert a new account using dbO
                        OpeningBalance = txtOpeningBalance.Text
                        tblAccountList.Addnew()
                        tblAccountList.Fields("name") = txtName.Text.ToUpper.Trim
                        tblAccountList.Fields("number") = txtAccountNumber.Text.ToUpper.Trim
                        tblAccountList.Fields("opening_date") = dtpOpeningDate.Value
                        tblAccountList.Fields("bank_name") = txtBankName.Text.ToUpper.Trim
                        tblAccountList.Fields("description") = txtDescription.Text.ToUpper.Trim
                        tblAccountList.Fields("opening_balance") = CStr(OpeningBalance)
                        tblAccountList.Fields("current_balance") = CStr(OpeningBalance)

                        tblAccountList.Update()

                        dateEntered = CDate(dtpOpeningDate.Value)
                        duration = CStr(dateEntered.Month) + "." + CStr(dateEntered.Year)
                        sqlQuery = "INSERT INTO MAINTAIN_BALANCE (ACCOUNT_NUMBER, OPENING_BALANCE, CLOSING_BALANCE, DURATION,STATUS, UKEY) VALUES ('" + txtAccountNumber.Text.Trim + "','" + CStr(OpeningBalance) + "','0','" + duration + "',0, null)"
                        connection.Execute(sqlQuery)

                        sqlQuery = "INSERT INTO MAINTAIN_BALANCE_YEARLY (ACCOUNT_NUMBER, OPENING_BALANCE, CLOSING_BALANCE, YEARS, UKEY) VALUES ('" + txtAccountNumber.Text.Trim + "', '" + CStr(OpeningBalance) + "', '0','" + CStr(dateEntered.Year) + "', null)"
                        connection.Execute(sqlQuery)
                        logger.createAccount(userID, txtAccountNumber.Text.Trim, txtOpeningBalance.Text.Trim)
                        MessageBox.Show("Account was created successfully", Application.ProductName)
                        reset()
                        initData()
                    Catch ex As Exception
                        MessageBox.Show("Please Restart the Program again", Application.ProductName)
                        Throw ex
                    End Try
                Case dialog.No
                    reset()
                    Exit Sub
            End Select
        ElseIf editRecord = True And newRecord = False
            If txtName.Text = "" Then
                MessageBox.Show("Account Name is required", Application.ProductName)
                txtName.Focus()
                Exit Sub
            End If
            dialog = MessageBox.Show("Do you wish to update this account", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes

                    tblAccountList.Move(PubAccountRowIndex)
                    tblAccountList.Fields("name") = txtName.Text.ToUpper.Trim
                    tblAccountList.Fields("bank_name") = txtBankName.Text.ToUpper.Trim
                    tblAccountList.Fields("description") = txtDescription.Text.ToUpper.Trim

                    tblAccountList.Update()
                    MessageBox.Show("Account was updated successfully", Application.ProductName)
                    reset()
                Case dialog.No
                    reset()
                    Exit Sub
            End Select
        Else
            Exit Sub

        End If
    End Sub


    Private Sub toForm(i As Integer)
        txtName.Text = tblAccountList.Rows(i).Item("name")
        txtAccountNumber.Text = tblAccountList.Rows(i).Item("number")
        txtBankName.Text = tblAccountList.Rows(i).Item("bank_name")
        txtDescription.Text = tblAccountList.Rows(i).Item("description")
        txtOpeningBalance.Text = $"N{FormatNumber(tblAccountList.Rows(i).Item("opening_balance"))}"
        lblCurrentBalance.Text = $"N{FormatNumber(tblAccountList.Rows(i).Item("current_balance"))}"
        dtpOpeningDate.Value = Convert.ToDateTime(tblAccountList.Rows(i).Item("opening_date"))
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As DialogResult

        If PubAccountRowIndex < 0 Then Exit Sub

        dialog = MessageBox.Show("Do you wish to delete this Account?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes
                dialog = MessageBox.Show("Deleting this Account will delete all transactions related to this account. Do you wish to continue?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                Select Case dialog
                    Case dialog.Yes
                        deleteAccount(txtAccountNumber.Text)
                        logger.deleteAccount(userID, txtAccountNumber.Text.Trim)
                        MessageBox.Show("Account has been deleted successfully", Application.ProductName)
                        clear()
                        initData()
                    Case dialog.No
                        Exit Sub
                End Select
            Case dialog.No
                Exit Sub
        End Select

    End Sub
    Private Sub deleteAccount(account As String)
        Dim sqlQuery As String
        Dim tblTransaction As New dbO.Table

        'Delete All Bank reconcilation related to the account number
        sqlQuery = "DELETE FROM bank_reconcilation WHERE account_number = '" + account + "'"
        connection.Execute(sqlQuery)

        'Delete All Balance from related to the account number
        sqlQuery = "DELETE FROM maintain_balance WHERE account_number = '" + account + "'"
        connection.Execute(sqlQuery)

        'Delete All Maitain Balance from relateed to the account number
        sqlQuery = "DELETE FROM maintain_balance_yearly WHERE account_number = '" + account + "'"
        connection.Execute(sqlQuery)

        'Delete All the Transactions
        sqlQuery = "SELECT * FROM transactions WHERE account_number = '" + account + "'"
        tblTransaction.Clear()

        tblTransaction = connection.Fetch(sqlQuery)

        If tblTransaction.Rows.Count = 0 Then

            sqlQuery = "DELETE FROM accounts WHERE number = '" + account + "'"
            connection.Execute(sqlQuery)
            Exit Sub

        End If

        For i = 0 To tblTransaction.Rows.Count - 1

            'Go through All the Transactions and delete the supporting documents
            sqlQuery = "DELETE FROM supporting_document WHERE transactions = " + CStr(tblTransaction.Rows(i).Item("ukey"))
            connection.Execute(sqlQuery)

        Next i

        sqlQuery = "DELETE FROM transactions WHERE account_number = '" + account + "'"
        connection.Execute(sqlQuery)

        sqlQuery = "DELETE FROM accounts WHERE number = '" + account + "'"
        connection.Execute(sqlQuery)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        frmSearchForAccount.ShowDialog()

        If PubAccountRowIndex = -1 Then Exit Sub

        toForm(PubAccountRowIndex)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        frmRDLViewPrintAccount.ShowDialog()
    End Sub
End Class