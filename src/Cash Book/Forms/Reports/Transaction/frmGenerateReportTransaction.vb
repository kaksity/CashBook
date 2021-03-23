Public Class frmGenerateReportTransaction
    Dim reporter As New TransactionReporter
    Private Sub chkDescription_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescription.CheckedChanged
        If chkDescription.Checked = True Then
            cboDescription.Enabled = False
        ElseIf chkDescription.Checked = False
            cboDescription.Enabled = True
        End If
    End Sub

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
    Private Sub loadDescription()
        Dim tblDescription As New dbO.Table

        tblDescription.Clear()
        tblDescription = connection.Fetch("SELECT * FROM transaction_description")
        If tblDescription.Rows.Count = 0 Then Exit Sub

        cboDescription.DisplayMember = "description_name"
        cboDescription.ValueMember = "ukey"
        cboDescription.DataSource = tblDescription
    End Sub

    Private Sub frmGenerateReportTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAccounts()
        loadDescription()
        loadTypeOfTransaction()
        loadMonths()
        loadYears()
        loadTypeOfTransaction()
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


    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click

        Dim duration As String
        duration = CStr(cboMonths.SelectedValue) + "/" + CStr(cboYears.SelectedValue)

        If chkTransactionType.Checked = True And chkDescription.Checked = True Then
            reporter.allTransaction(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = False And chkDescription.Checked = True
            reporter.allTransactionType(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboTypeOfTransaction.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = True And chkDescription.Checked = False
            reporter.specificDescription(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboDescription.SelectedValue)
            Exit Sub
        ElseIf chkTransactionType.Checked = False And chkDescription.Checked = False
            reporter.allSpecificTransactionTypeAndDescription(cboAccounts.SelectedValue, cboMonths.SelectedValue, cboYears.SelectedValue, cboTypeOfTransaction.SelectedValue, cboDescription.SelectedValue)
            Exit Sub
            'ElseIf chkTransactionType.Checked = True And chkDuration.Checked = False And chkDescription.Checked = True
            '    reporter.allSpecificDuration(cboAccounts.SelectedValue, duration)
            '    Exit Sub
            'ElseIf chkTransactionType.Checked = True And chkDescription.Checked = False And chkDuration.Checked = False
            '    reporter.allSpecificDescriptionAndDuration(cboAccounts.SelectedValue, cboDescription.SelectedValue, duration)
            '    Exit Sub

        End If

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

    Private Sub chkTransactionType_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransactionType.CheckedChanged
        If chkTransactionType.Checked = False Then cboTypeOfTransaction.Enabled = True Else cboTypeOfTransaction.Enabled = False
    End Sub
End Class