Public Class frmViewBankReconcilation
    Dim tblBankReconcilation As New dbO.Table
    Dim rowIndex As String
    Dim reporter As New BankReconcilationReporter
    Dim logger As New logger
    Private Function getAccountName(accountNumber As String)
        Dim tblAccounts As New dbO.Table
        Dim sqlQuery As String
        tblAccounts.Clear()

        sqlQuery = "SELECT * FROM ACCOUNTS WHERE NUMBER = '" + CStr(accountNumber) + "'"
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Return ""

        Return tblAccounts.Rows(0).Item("name")
    End Function

    Private Sub loadGrid()
        Dim sqlQuery As String

        tblBankReconcilation.Clear()

        sqlQuery = "SELECT * FROM bank_reconcilation"
        tblBankReconcilation = connection.Fetch(sqlQuery)

        grid.Rows.Clear()

        If tblBankReconcilation.Rows.Count = 0 Then Exit Sub

        grid.Rows.Add(tblBankReconcilation.Rows.Count)

        For i = 0 To tblBankReconcilation.Rows.Count - 1
            With grid
                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsAccountName").Value = getAccountName(tblBankReconcilation.Rows(i).Item("account_number"))
                .Rows(i).Cells("colsAccountNumber").Value = tblBankReconcilation.Rows(i).Item("account_number")
                .Rows(i).Cells("colsDuration").Value = tblBankReconcilation.Rows(i).Item("duration")
                .Rows(i).Cells("colsStatus").Value = "GENERATED"
            End With
        Next
    End Sub
    Private Sub initGrid()
        grid.Columns.Clear()
        grid.Rows.Clear()
        With grid
            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsAccountName", "Account Name")
            .Columns.Add("colsAccountNumber", "Account Number")
            .Columns.Add("colsDuration", "Duration")
            .Columns.Add("colsStatus", "Status")

            .Columns("colsSNum").Width = 70
            .Columns("colsAccountName").Width = 200
            .Columns("colsAccountNumber").Width = 200
            .Columns("colsDuration").Width = 200
            .Columns("colsStatus").Width = 150


            .Columns("colsSNum").ReadOnly = True
            .Columns("colsAccountName").ReadOnly = True
            .Columns("colsAccountNumber").ReadOnly = True
            .Columns("colsDuration").ReadOnly = True
            .Columns("colsStatus").ReadOnly = True


            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
        End With
    End Sub
    Private Sub frmViewBankReconcilation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        initGrid()
        loadGrid()
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        rowIndex = e.RowIndex
        lblDuration.Text = "Selected Account Name " + getAccountName(tblBankReconcilation.Rows(e.RowIndex).Item("account_number")) + " with the Account Number " + tblBankReconcilation.Rows(e.RowIndex).Item("account_number") + " for the Month of " + tblBankReconcilation.Rows(e.RowIndex).Item("duration")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
    End Sub

    Private Sub clear()
        rowIndex = -1
        lblDuration.Text = ""
    End Sub
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If rowIndex = -1 Then Exit Sub
        reporter.renderReport(tblBankReconcilation.Rows(rowIndex).Item("ukey"))
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sqlQuery As String
        Dim duration As String
        Dim account As String
        Dim tblMaintainMonthlyBalance As New dbO.Table
        Dim dialog As DialogResult


        If rowIndex = -1 Then
            MessageBox.Show("You Must Select a record", Application.ProductName)
            Exit Sub
        End If



        'Move to the row index
        tblBankReconcilation.Move(rowIndex)
        account = tblBankReconcilation.Fields("account_number")
        duration = tblBankReconcilation.Fields("duration")
        duration = duration.Replace("/", ".")

        'Check if the financial month has been closed
        sqlQuery = "SELECT * FROM maintain_balance WHERE account_number = '" + CStr(account) + "' AND duration = '" + CStr(duration) + "'"

        tblMaintainMonthlyBalance.Clear()
        tblMaintainMonthlyBalance = connection.Fetch(sqlQuery)


        If tblMaintainMonthlyBalance.Rows(0).Item("status") = 1 Then
            MessageBox.Show("Cannot perform operation. Financial Month has Been Closed", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to delete this bank reconcilation record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Select Case dialog
            Case dialog.Yes

                'Form and sql query using the duration of the transaction
                sqlQuery = "UPDATE maintain_balance SET closing_balance = '0' WHERE account_number = '" + account + "' AND duration = '" + duration + "'"
                connection.Execute(sqlQuery)

                'Delete the record 
                sqlQuery = "DELETE FROM bank_reconcilation WHERE ukey = " + CStr(tblBankReconcilation.Fields("ukey"))
                connection.Execute(sqlQuery)

                logger.deleteBankReconcilation(userID, account, duration.Replace(".", "/"))
                MessageBox.Show("Bank reconcilation record was deleted successfully", Application.ProductName)

                clear()
                loadGrid()

                Exit Sub
            Case dialog.No
                clear()
                Exit Sub
        End Select

    End Sub
End Class