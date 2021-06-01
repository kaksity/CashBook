'Imports Excel = Microsoft.Office.Interop.Excel
Imports OfficeOpenXml
Imports System.IO
Imports System

Public Class frmMainMenu
    Dim reporter As New AccountReporter
    Dim descriptionReporter As New TransactionDescriptionReporter
    Private Function isOrganizationRegistered() As Boolean
        Dim sqlQuery As String
        Dim tblOrganization As New dbO.Table

        tblOrganization.Clear()
        sqlQuery = "SELECT * FROM organization"
        tblOrganization = connection.Fetch(sqlQuery)

        If tblOrganization.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Function getUsername(id As String) As String
        Dim tblUser As New dbO.Table
        Dim sqlQuery As String
        Dim userDetails As String

        tblUser.Clear()
        sqlQuery = "SELECT * FROM users WHERE user_code = '" + id + "'"

        tblUser = connection.Fetch(sqlQuery)

        If tblUser.RowCount = 0 Then
            userDetails = "Logged in as: " + "Nill"
        End If

        tblUser.Move(0)
        userDetails = "Logged in as: " + tblUser.Fields("username")
        Return userDetails
    End Function
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        frmAccount.ShowDialog()
    End Sub

    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        frmRevenueRegister.ShowDialog()
    End Sub

    Private Sub CreateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem2.Click
        frmTransaction.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        frmUserProfile.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        frmViewTransaction.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        frmViewRevenueRegister.ShowDialog()
    End Sub

    Private Sub TSBCreateTransaction_Click(sender As Object, e As EventArgs)
        frmTransaction.ShowDialog()
    End Sub

    Private Sub TSBRegisterRevenue_Click(sender As Object, e As EventArgs)
        frmRevenueRegister.ShowDialog()
    End Sub

    Private Sub TSBCreateExpenseItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem3.Click
        frmTransactionDescription.ShowDialog()
    End Sub


    Private Sub frmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you wish to exit this program?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes
                End
            Case dialog.No
                e.Cancel = True
                Exit Sub
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub CreateToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem4.Click
        frmBankReconcilation.ShowDialog()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
        End If
        lblNumberOfRecords.Text = "Number of Records: 0"
        lblLoggedInStatus.Text = getUsername(userID)
        initGrid()
        loadAccounts()
        loadTypeOfTransaction()
        loadDescription()
        loadMonths()
        loadYears()
    End Sub

    Private Sub initGrid()
        With grid
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("colsDateOfTransaction", "DATE OF TRANSACTION")
            .Columns.Add("colsPVRV", "PV/RV NUMBER")
            .Columns.Add("colsRef", "REF NUMBER")
            .Columns.Add("colsSubHeadColumn", "SUB HEAD COLUMN")
            .Columns.Add("colsNameOfBeneficiary", "NAME - BENEFICIARY")
            .Columns.Add("colsDescriptionOfTransaction", "DESCRIPTION OF TRANSACTION")
            .Columns.Add("colsDRReceipts", "DR - RECEIPTS")
            .Columns.Add("colsCRPayments", "CR - PAYMENTS")

            .Columns("colsDateOfTransaction").Width = 150
            .Columns("colsPVRV").Width = 100
            .Columns("colsRef").Width = 100
            .Columns("colsSubHeadColumn").Width = 100
            .Columns("colsNameOfBeneficiary").Width = 300
            .Columns("colsDescriptionOfTransaction").Width = 300
            .Columns("colsDRReceipts").Width = 200
            .Columns("colsCRPayments").Width = 200


            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
        End With
    End Sub



    Private Sub loadTypeOfTransaction()
        Dim tblTypeOfTransaction As New DataTable

        tblTypeOfTransaction.Columns.Add("name", GetType(String))
        tblTypeOfTransaction.Columns.Add("value", GetType(String))


        tblTypeOfTransaction.Rows.Add("Income", "INCOME")
        tblTypeOfTransaction.Rows.Add("Expense", "EXPENSE")

        cboTypeOfTransaction.DisplayMember = "name"
        cboTypeOfTransaction.ValueMember = "value"
        cboTypeOfTransaction.DataSource = tblTypeOfTransaction

    End Sub

    Private Sub ViewToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem3.Click
        frmOrganization.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        frmViewBankReconcilation.ShowDialog()
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        frmGenerateReportTransaction.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        frmRevenueRegister.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        frmTransactionDescription.ShowDialog()

    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        reporter.allAccount()
    End Sub

    Private Sub TransactionDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionDescriptionToolStripMenuItem.Click
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        descriptionReporter.allDescription()
    End Sub

    Private Sub CloseFinancialTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFinancialTransactionToolStripMenuItem.Click
        frmCloseFinancialMonth.ShowDialog()
    End Sub

    Private Sub BankReconcilationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BankReconcilationToolStripMenuItem1.Click
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        frmViewBankReconcilation.ShowDialog()
    End Sub

    Private Sub ColumnCashBookToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If isOrganizationRegistered() = False Then
            frmRegisterOrganization.ShowDialog()
            Exit Sub
        End If
        frmGenerateColumns.ShowDialog()
    End Sub

    Private Sub BackupToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmBackUp.ShowDialog()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmRestore.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub MaintainBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim reporter As New maintainBalanceReporter

        reporter.render()
    End Sub
    Public Sub loadDescription()
        Dim tblDescription As New dbO.Table
        tblDescription.Clear()
        tblDescription = connection.Fetch("SELECT * FROM transaction_description WHERE type_of_transaction = 'EXPENSE'")
        If tblDescription.Rows.Count = 0 Then Exit Sub

        cboDescription.DisplayMember = "description_name"
        cboDescription.ValueMember = "ukey"
        cboDescription.DataSource = tblDescription
    End Sub

    Private Sub loadMonths()
        Dim tblMonths As New DataTable

        tblMonths.Columns.Add("name", GetType(String))
        tblMonths.Columns.Add("value", GetType(Integer))

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

    Public Sub loadAccounts()
        Dim sqlQuery As String
        Dim tblAccounts As New dbO.Table
        tblAccounts.Clear()

        sqlQuery = "SELECT * FROM ACCOUNTS"
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Exit Sub

        cboAccounts.DisplayMember = "name"
        cboAccounts.ValueMember = "number"
        cboAccounts.DataSource = tblAccounts

    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        If chkTransactionType.Checked = True And chkDescription.Checked = True Then
            loadAllTransactions(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = False And chkDescription.Checked = True
            loadAllTransactionType(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboTypeOfTransaction.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = True And chkDescription.Checked = False
            loadSpecificDescriptionTransaction(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboDescription.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = False And chkDescription.Checked = False
            allSpecificTransactionTypeAndDescription(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboTypeOfTransaction.SelectedValue, cboDescription.SelectedValue)
            Exit Sub
        End If
    End Sub


    Public Sub allSpecificTransactionTypeAndDescription(account As String, month As Integer, year As Integer, type As String, description As Integer)
        Dim sqlQuery As String
        Dim tblTransaction As New dbO.Table
        Dim viewer As New frmViewTransactionReport
        Dim duration As String

        duration = CStr(month) + "." + CStr(year)

        sqlQuery = "SELECT * FROM transactions WHERE account_number = '" + account + "' AND DESCRIPTION_OF_TRANSACTION = " + CStr(description) + " AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'"

        If type = "INCOME" Then
            sqlQuery = sqlQuery + " AND ammount_withdrawn = '0'"

        ElseIf type = "EXPENSE" Then
            sqlQuery = sqlQuery + " AND ammount_deposited = '0'"
        End If

        tblTransaction.Clear()

        tblTransaction = connection.Fetch(sqlQuery)

        grid.Rows.Clear()
        lblNumberOfRecords.Text = "Number of Record: " + CStr(tblTransaction.RowCount)

        If tblTransaction.Rows.Count = 0 Then Exit Sub
        tblTransaction = generateTransactionToBeReported(cboAccounts.SelectedValue, duration, tblTransaction)
        grid.Rows.Add(tblTransaction.RowCount)

        For i = 0 To tblTransaction.RowCount - 1
            With grid
                tblTransaction.Move(i)
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblTransaction.Fields("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsPVRV").Value = tblTransaction.Fields("pv_or_rv_number")
                .Rows(i).Cells("colsRef").Value = tblTransaction.Fields("ref_number")
                .Rows(i).Cells("colsSubHeadColumn").Value = tblTransaction.Fields("subhead_column")
                .Rows(i).Cells("colsNameOfBeneficiary").Value = tblTransaction.Fields("name_of_beneficiary")
                .Rows(i).Cells("colsDescriptionOfTransaction").Value = tblTransaction.Fields("account_number")
                .Rows(i).Cells("colsDRReceipts").Value = tblTransaction.Fields("ammount_deposited")
                .Rows(i).Cells("colsCRPayments").Value = tblTransaction.Fields("ammount_withdrawn")
            End With
        Next
    End Sub

    Public Sub loadSpecificDescriptionTransaction(account As String, month As Integer, year As Integer, id As Integer)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String

        Dim duration As String

        duration = CStr(month) + "." + CStr(year)
        tblTransaction.Clear()
        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND DESCRIPTION_OF_TRANSACTION = " + CStr(id) + " AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'"
        tblTransaction = connection.Fetch(sqlQuery)

        grid.Rows.Clear()

        lblNumberOfRecords.Text = "Number of Record: " + CStr(tblTransaction.RowCount)
        If tblTransaction.Rows.Count = 0 Then Exit Sub

        tblTransaction = generateTransactionToBeReported(cboAccounts.SelectedValue, duration, tblTransaction)

        grid.Rows.Add(tblTransaction.RowCount)

        For i = 0 To tblTransaction.RowCount - 1
            With grid
                tblTransaction.Move(i)
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblTransaction.Fields("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsPVRV").Value = tblTransaction.Fields("pv_or_rv_number")
                .Rows(i).Cells("colsRef").Value = tblTransaction.Fields("ref_number")
                .Rows(i).Cells("colsSubHeadColumn").Value = tblTransaction.Fields("subhead_column")
                .Rows(i).Cells("colsNameOfBeneficiary").Value = tblTransaction.Fields("name_of_beneficiary")
                .Rows(i).Cells("colsDescriptionOfTransaction").Value = tblTransaction.Fields("account_number")
                .Rows(i).Cells("colsDRReceipts").Value = tblTransaction.Fields("ammount_deposited")
                .Rows(i).Cells("colsCRPayments").Value = tblTransaction.Fields("ammount_withdrawn")
            End With
        Next

    End Sub

    Private Function getDescriptionName(description As Integer) As String
        Dim sqlQuery As String = ""
        Dim table As New dbO.Table

        sqlQuery = "SELECT * FROM transaction_description WHERE ukey = " + CStr(description)
        table.Clear()
        table = connection.Fetch(sqlQuery)

        Return table.Rows(0).Item("description_name")

    End Function

    Private Function generateTransactionToBeReported(account As String, duration As String, table As dbO.Table) As dbO.Table
        Dim sqlQuery As String
        Dim tblMaintainBalance As New dbO.Table
        Dim transactionDescription As String = ""
        Dim openingBalance As String


        sqlQuery = "SELECT * FROM maintain_balance WHERE account_number = '" + account + "' AND duration LIKE '%" + duration + "%'"
        tblMaintainBalance.Clear()
        tblMaintainBalance = connection.Fetch(sqlQuery)

        If tblMaintainBalance.Rows.Count = 0 Then
            MessageBox.Show("There is no transaction for the Month", Application.ProductName)
            Return Nothing
            Exit Function
        End If

        tblMaintainBalance.Move(0)
        openingBalance = tblMaintainBalance.Fields("opening_balance")

        For i = 0 To table.Rows.Count - 1
            table.Move(i)
            '    table.Fields("date_of_transaction") = CDate(Format(table.Fields("date_of_transaction"), "dd-MM-yyyy"))
            If table.Fields("ammount_deposited") = "0" Then
                openingBalance = CStr(Val(openingBalance) - Val(table.Fields("ammount_withdrawn")))
            ElseIf table.Fields("ammount_withdrawn") = "0"
                openingBalance = CStr(Val(openingBalance) + Val(table.Fields("ammount_deposited")))
            End If

            transactionDescription = getDescriptionName(CInt(table.Fields("description_of_transaction")))
            table.Fields("account_number") = transactionDescription
            table.Fields("final_balance") = CStr(FormatNumber(openingBalance))
            table.Fields("ammount_withdrawn") = FormatNumber(table.Fields("ammount_withdrawn"))
            table.Fields("ammount_deposited") = FormatNumber(table.Fields("ammount_deposited"))
            table.Save()
        Next i


        Return table
    End Function


    Private Sub loadAllTransactions(account As String, months As Integer, years As Integer)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionReport
        Dim duration As String

        duration = CStr(months) + "." + CStr(years)
        tblTransaction.Clear()
        sqlQuery = "Select * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND extract(YEAR FROM date_of_transaction) = '" + CStr(years) + "' AND extract(MONTH FROM date_of_transaction) = '" + CStr(months) + "' ORDER BY date_of_transaction ASC"
        tblTransaction = connection.Fetch(sqlQuery)

        grid.Rows.Clear()
        lblNumberOfRecords.Text = "Number of Record: " + CStr(tblTransaction.RowCount)
        If tblTransaction.Rows.Count = 0 Then Exit Sub

        tblTransaction = generateTransactionToBeReported(cboAccounts.SelectedValue, duration, tblTransaction)

        grid.Rows.Add(tblTransaction.RowCount)
        For i = 0 To tblTransaction.RowCount - 1
            With grid
                tblTransaction.Move(i)
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblTransaction.Fields("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsPVRV").Value = tblTransaction.Fields("pv_or_rv_number")
                .Rows(i).Cells("colsRef").Value = tblTransaction.Fields("ref_number")
                .Rows(i).Cells("colsSubHeadColumn").Value = tblTransaction.Fields("subhead_column")
                .Rows(i).Cells("colsNameOfBeneficiary").Value = tblTransaction.Fields("name_of_beneficiary")
                .Rows(i).Cells("colsDescriptionOfTransaction").Value = tblTransaction.Fields("account_number")
                .Rows(i).Cells("colsDRReceipts").Value = tblTransaction.Fields("ammount_deposited")
                .Rows(i).Cells("colsCRPayments").Value = tblTransaction.Fields("ammount_withdrawn")
            End With
        Next
    End Sub
    Private Sub loadAllTransactionType(account As String, months As Integer, years As Integer, type As String)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim duration As String

        duration = CStr(months) + "." + CStr(years)

        tblTransaction.Clear()
        If type = "INCOME" Then sqlQuery = "SELECT * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND  ammount_withdrawn = 0 AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(years) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(months) + "'" Else sqlQuery = " SELECT * FROM TRANSACTIONS WHERE ammount_deposited = 0 AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(years) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(months) + "'"

        tblTransaction = connection.Fetch(sqlQuery)

        grid.Rows.Clear()
        lblNumberOfRecords.Text = "Number of Record: " + CStr(tblTransaction.RowCount)

        If tblTransaction.Rows.Count = 0 Then Exit Sub

        tblTransaction = generateTransactionToBeReported(cboAccounts.SelectedValue, duration, tblTransaction)

        grid.Rows.Add(tblTransaction.RowCount)
        For i = 0 To tblTransaction.RowCount - 1
            With grid
                tblTransaction.Move(i)
                .Rows(i).Cells("colsDateOfTransaction").Value = Format(tblTransaction.Fields("date_of_transaction"), "dd/MM/yyyy")
                .Rows(i).Cells("colsPVRV").Value = tblTransaction.Fields("pv_or_rv_number")
                .Rows(i).Cells("colsRef").Value = tblTransaction.Fields("ref_number")
                .Rows(i).Cells("colsSubHeadColumn").Value = tblTransaction.Fields("subhead_column")
                .Rows(i).Cells("colsNameOfBeneficiary").Value = tblTransaction.Fields("name_of_beneficiary")
                .Rows(i).Cells("colsDescriptionOfTransaction").Value = tblTransaction.Fields("account_number")
                .Rows(i).Cells("colsDRReceipts").Value = tblTransaction.Fields("ammount_deposited")
                .Rows(i).Cells("colsCRPayments").Value = tblTransaction.Fields("ammount_withdrawn")
            End With
        Next
    End Sub

    Private Sub chkTransactionType_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransactionType.CheckedChanged
        If chkTransactionType.Checked = True Then
            cboTypeOfTransaction.Enabled = False
        Else
            cboTypeOfTransaction.Enabled = True
        End If
    End Sub

    Private Sub chkDescription_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescription.CheckedChanged
        If chkDescription.Checked = True Then
            cboDescription.Enabled = False
        Else
            cboDescription.Enabled = True
        End If
    End Sub

    Private Function getMonthInWord(month As Integer)
        Dim result As String
        Dim months(12) As String

        months(0) = "January"
        months(1) = "February"
        months(2) = "March"
        months(3) = "April"
        months(4) = "May"
        months(5) = "June"
        months(6) = "July"
        months(7) = "August"
        months(8) = "September"
        months(9) = "October"
        months(10) = "November"
        months(11) = "December"

        result = months(month - 1)
        Return result
    End Function

    Private Sub btnExportToExcelToExcel_Click(sender As Object, e As EventArgs)
        'Try
        '    Dim saveDialog As New SaveFileDialog

        '    btnExportToExcel.Text = "Please Wait..."
        '    btnExportToExcel.Enabled = False

        '    saveDialog.Filter = "Excel Document (*.xlsx)|*.xlsx"
        '    If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Dim ExPackage As New ExcelPackage
        '        Dim ExWorkSheet As ExcelWorksheet = ExPackage.Workbook.Worksheets.Add("sheet1")
        '        Dim sqlQuery As String
        '        Dim tblAccount As New dbO.Table
        '        Dim tblOrganization As New dbO.Table


        '        Dim i As Integer
        '        Dim j As Integer

        '        'Merge the cells inorder to be used to show the Header
        '        ExWorkSheet.Cells(1, 1, 1, grid.Columns.Count).Merge = True
        '        ExWorkSheet.Cells(2, 1, 2, grid.Columns.Count).Merge = True
        '        ExWorkSheet.Cells(3, 1, 2, grid.Columns.Count).Merge = True


        '        'Perform the Sql query here
        '        sqlQuery = "SELECT name,bank_name FROM accounts WHERE number = '" + CStr(cboAccounts.SelectedValue) + "'"
        '        tblAccount.Clear()
        '        tblAccount = connection.FetchLight(sqlQuery)

        '        sqlQuery = "SELECT name FROM organization"
        '        tblOrganization.Clear()
        '        tblOrganization = connection.FetchLight(sqlQuery)

        '        tblAccount.Move(0)
        '        tblOrganization.Move(0)



        '        'INSERT the Needed Values
        '        xlWorkSheet.Cells(1, 1) = tblOrganization.Fields("name")
        '        xlWorkSheet.Cells(2, 1) = "DETAILED CASHBOOK REPORT AS AT " + CStr(getMonthInWord(cboMonths.SelectedValue)) + " " + CStr(cboYears.SelectedValue)
        '        xlWorkSheet.Cells(3, 1) = tblAccount.Fields("name") + "[" + tblAccount.Fields("bank_name") + "]"

        '        xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter
        '        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter
        '        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter



        '        For i = 0 To grid.Rows.Count - 1
        '            For j = 0 To grid.ColumnCount - 1
        '                For k As Integer = 1 To grid.Columns.Count
        '                    xlWorkSheet.Columns.ColumnWidth = 25
        '                    xlWorkSheet.Cells(4, k) = grid.Columns(k - 1).HeaderText

        '                    If IsNumeric(grid(j, i).Value) = True Then
        '                        xlWorkSheet.Cells(i + 5, j + 1) = FormatNumber(grid(j, i).Value)
        '                    ElseIf IsNumeric(grid(j, i).Value) = False And IsDBNull(grid(j, i).Value) = False
        '                        xlWorkSheet.Cells(i + 5, j + 1) = grid(j, i).Value.ToString()
        '                    End If

        '                Next
        '            Next
        '            pgProgress.Value = CSng((i / (grid.RowCount - 1)) * 100)
        '        Next

        '        xlWorkSheet.SaveAs(saveDialog.FileName)
        '        xlWorkBook.Close()
        '        xlApp.Quit()

        '        releaseObject(xlApp)
        '        releaseObject(xlWorkBook)
        '        releaseObject(xlWorkSheet)

        '        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & saveDialog.FileName, MsgBoxStyle.Information, "Information")

        '        pgProgress.Value = 0
        '        btnExportToExcel.Text = "Export To MS Excel"
        '        btnExportToExcel.Enabled = True
        '    Else
        '        btnExportToExcel.Text = "Export To MS Excel"
        '        btnExportToExcel.Enabled = True
        '    End If
        'Catch ex As Exception
        '    'MessageBox.Show(ex.Message)

        '    MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    btnExportToExcel.Text = "Export To MS Excel"
        '    btnExportToExcel.Enabled = True
        '    Throw ex
        '    Return
        'End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
    End Sub

    Private Sub ColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmGenerateColumns.ShowDialog()
    End Sub

    Private Sub tlbExpenseTransaction_Click(sender As Object, e As EventArgs) Handles tlbExpenseTransaction.Click
        frmTransaction.ShowDialog()
        Exit Sub
    End Sub

    Private Sub tlbRevenueRegister_Click(sender As Object, e As EventArgs) Handles tlbRevenueRegister.Click
        frmRevenueRegister.ShowDialog()
        Exit Sub
    End Sub

    Private Sub tlbTransactionItems_Click(sender As Object, e As EventArgs) Handles tlbTransactionItems.Click
        frmTransactionDescription.ShowDialog()
        Exit Sub
    End Sub

    Private Sub BackUpToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles BackUpToolStripMenuItem1.Click
        frmBackUp.ShowDialog()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        frmRestore.ShowDialog()
    End Sub

    Private Sub SessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SessionsToolStripMenuItem.Click
        frmSessionSettings.ShowDialog()
    End Sub

    Private Sub YearGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearGroupToolStripMenuItem.Click
        frmYearGroupSettings.ShowDialog()

    End Sub

    Private Sub ClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesToolStripMenuItem.Click
        frmClassSectionSettings.ShowDialog()
    End Sub
End Class