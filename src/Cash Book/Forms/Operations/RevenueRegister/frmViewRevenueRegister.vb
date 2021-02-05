Public Class frmViewRevenueRegister
    Dim tblRevenueTransactions As New dbO.Table
    Dim rowIndex As Integer = -1
    Dim logger As New logger
    Private Sub initGrid()
        grid.Columns.Clear()
        grid.Rows.Clear()

        With grid

            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsAccountName", "Account Name")
            .Columns.Add("colsAccountNumber", "Account Number")
            .Columns.Add("colsDateOfTransaction", "Date of Transaction")
            .Columns.Add("colsRVNumber", "RV Number")
            .Columns.Add("colsDescription", "Description")
            .Columns.Add("colsBeneficiaryName", "Beneficiary Name")
            .Columns.Add("colsAmmountDeposited", "Ammount Deposited")

            .Columns("colsDateOfTransaction").Width = 150
            .Columns("colsBeneficiaryName").Width = 250
            .Columns("colsDescription").Width = 300
            .Columns("colsAccountName").Width = 150
            .Columns("colsAccountNumber").Width = 150
            .Columns("colsAmmountDeposited").Width = 130

            .Columns("colsDateOfTransaction").ReadOnly = True
            .Columns("colsBeneficiaryName").ReadOnly = True
            .Columns("colsDescription").ReadOnly = True
            .Columns("colsAccountName").ReadOnly = True
            .Columns("colsAccountNumber").ReadOnly = True
            .Columns("colsAmmountDeposited").ReadOnly = True

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub

    Private Sub loadTransaction()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE AMMOUNT_WITHDRAWN = 0"

        tblRevenueTransactions.Clear()
        tblRevenueTransactions = connection.Fetch(sqlQuery)

        grid.Rows.Clear()

        If tblRevenueTransactions.Rows.Count = 0 Then Exit Sub

        grid.Rows.Add(tblRevenueTransactions.Rows.Count)

        For i = 0 To tblRevenueTransactions.Rows.Count - 1
            With grid
                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsAccountName").Value = getAccountName(tblRevenueTransactions.Rows(i).Item("account_number"))
                .Rows(i).Cells("colsAccountNumber").Value = tblRevenueTransactions.Rows(i).Item("account_number")
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblRevenueTransactions.Rows(i).Item("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsRVNumber").Value = tblRevenueTransactions.Rows(i).Item("pv_or_rv_number")
                .Rows(i).Cells("colsDescription").Value = getDescriptionName(tblRevenueTransactions.Rows(i).Item("description_of_transaction"))
                .Rows(i).Cells("colsBeneficiaryName").Value = tblRevenueTransactions.Rows(i).Item("name_of_beneficiary")
                .Rows(i).Cells("colsAmmountDeposited").Value = FormatNumber(tblRevenueTransactions.Rows(i).Item("ammount_deposited"))
            End With
        Next i
    End Sub


    Private Function getAccountName(accountNumber As String)
        Dim tblAccounts As New dbO.Table
        Dim sqlQuery As String
        tblAccounts.Clear()

        sqlQuery = "SELECT * FROM ACCOUNTS WHERE NUMBER = '" + CStr(accountNumber) + "'"
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Return ""

        Return tblAccounts.Rows(0).Item("name")
    End Function

    Private Function getDescriptionName(id) As String
        Dim tblDescription As New dbO.Table
        Dim sqlQuery As String

        tblDescription.Clear()

        sqlQuery = "SELECT * FROM TRANSACTION_DESCRIPTION WHERE UKEY = '" + CStr(id) + "'"
        tblDescription = connection.Fetch(sqlQuery)

        If tblDescription.Rows.Count = 0 Then Return ""

        Return tblDescription.Rows(0).Item("description_name")
    End Function
    Private Sub loadAccounts()
        Dim tblAccounts As New dbO.Table
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM ACCOUNTS"
        tblAccounts.Rows.Clear()

        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Exit Sub

        cboAccounts.DisplayMember = "name"
        cboAccounts.ValueMember = "number"
        cboAccounts.DataSource = tblAccounts
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

    Private Sub loadFilterData(accountNumber As String, month As Integer, year As String)
        Dim sqlQuery As String
        accountNumber = CStr(accountNumber)


        tblRevenueTransactions.Clear()

        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE AMMOUNT_WITHDRAWN = 0 AND account_number = '" + accountNumber + "' AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'"
        tblRevenueTransactions = connection.Fetch(sqlQuery)

        grid.Rows.Clear()

        If tblRevenueTransactions.Rows.Count = 0 Then Exit Sub

        grid.Rows.Add(tblRevenueTransactions.Rows.Count)

        For i = 0 To tblRevenueTransactions.Rows.Count - 1
            With grid
                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsAccountName").Value = getAccountName(tblRevenueTransactions.Rows(i).Item("account_number"))
                .Rows(i).Cells("colsAccountNumber").Value = tblRevenueTransactions.Rows(i).Item("account_number")
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblRevenueTransactions.Rows(i).Item("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsRVNumber").Value = tblRevenueTransactions.Rows(i).Item("pv_or_rv_number")
                .Rows(i).Cells("colsDescription").Value = getDescriptionName(tblRevenueTransactions.Rows(i).Item("description_of_transaction"))
                .Rows(i).Cells("colsBeneficiaryName").Value = tblRevenueTransactions.Rows(i).Item("name_of_beneficiary")
                .Rows(i).Cells("colsAmmountDeposited").Value = FormatNumber(tblRevenueTransactions.Rows(i).Item("ammount_deposited"))
            End With
        Next i
    End Sub
    Private Sub frmViewRevenueRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGrid()
        loadYears()
        loadTransaction()
        loadAccounts()
        loadMonths()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        loadFilterData(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue)
    End Sub

    Private Sub btnLoadAllData_Click(sender As Object, e As EventArgs) Handles btnLoadAllData.Click
        loadTransaction()
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        rowIndex = e.RowIndex
        lblSelectedRecord.Text = "Selected " + getAccountName(tblRevenueTransactions.Rows(e.RowIndex).Item("account_number")) + " Account Number " + tblRevenueTransactions.Rows(e.RowIndex).Item("account_number") + " on " + tblRevenueTransactions.Rows(e.RowIndex).Item("date_of_transaction") + "Beneficiary " + tblRevenueTransactions.Rows(e.RowIndex).Item("name_of_beneficiary") + " Ammount " + tblRevenueTransactions.Rows(e.RowIndex).Item("ammount_deposited")

        selectedExpenseTransaction = CStr(tblRevenueTransactions.Rows(e.RowIndex).Item("ukey"))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub clear()
        lblSelectedRecord.Text = ""
        selectedExpenseTransaction = ""
        rowIndex = -1
    End Sub

    Private Sub btnAddSupportingDocument_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lblSelectedRecord.Text = "" Or selectedExpenseTransaction = "" Then
            MessageBox.Show("You Must Select a record", Application.ProductName)
            Exit Sub
        End If
        frmAddSupportingDocument.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim dialog As DialogResult
        Dim dateEntered As New Date
        Dim year As Integer
        Dim month As Integer
        Dim duration As String
        Dim sqlQuery As String
        Dim tblMaintainBalance As New dbO.Table

        If rowIndex = -1 Then
            MessageBox.Show("You Must Select a record", Application.ProductName)
            Exit Sub
        End If

        'Check if the financial Month has been closed
        tblRevenueTransactions.Move(rowIndex)
        dateEntered = CDate(tblRevenueTransactions.Fields("date_of_transaction"))

        month = dateEntered.Month
        year = dateEntered.Year

        duration = CStr(month) + "." + CStr(year)

        sqlQuery = "SELECT * FROM maintain_balance WHERE duration = '" + duration + "'"
        tblMaintainBalance.Clear()
        tblMaintainBalance = connection.Fetch(sqlQuery)

        tblMaintainBalance.Move(0)
        If tblMaintainBalance.Fields("status") = 1 Then
            MessageBox.Show("Cannot perform this operation because the financial month has been closed", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to delete this transaction", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Select Case dialog
            Case dialog.Yes
                Dim tblAccount As New dbO.Table

                'Get the Ammount and update the account balance
                sqlQuery = "SELECT * FROM ACCOUNTS WHERE NUMBER='" + tblRevenueTransactions.Fields("account_number") + "'"
                tblAccount.Clear()
                tblAccount = connection.Fetch(sqlQuery)
                tblAccount.Move(0)
                tblAccount.Fields("current_balance") = CStr(Val(tblAccount.Fields("current_balance")) - Val(tblRevenueTransactions.Fields("ammount_deposited")))
                tblAccount.Update()

                'Delete all the supporting document 
                sqlQuery = "DELETE FROM supporting_document WHERE transactions = " + CStr(tblRevenueTransactions.Fields("ukey"))
                connection.Execute(sqlQuery)

                'Delete the transaction
                sqlQuery = "DELETE FROM transactions WHERE ukey = " + CStr(tblRevenueTransactions.Fields("ukey"))
                connection.Execute(sqlQuery)

                logger.deleteTransaction(userID, tblRevenueTransactions.Fields("account_number"), tblRevenueTransactions.Fields("ammount_deposited"), "INCOME")

                MessageBox.Show("Transaction was deleted successfully", Application.ProductName)
                loadTransaction()
                clear()

            Case dialog.No
                clear()
                Exit Sub
        End Select
    End Sub

End Class