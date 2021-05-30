Public Class frmCloseFinancialMonth
    Dim tblFinancialMonth As New dbO.Table
    Dim rowIndex As Integer = -1
    Dim logger As New logger
    Private Sub initGrid()

        With grid

            .Columns.Clear()
            .Rows.Clear()

            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsAccountName", "Account Name")
            .Columns.Add("colsAccountNumber", "Account Number")
            .Columns.Add("colsDuration", "Duration")
            .Columns.Add("colsOpeningBalance", "Opening Balance")
            .Columns.Add("colsClosingBalance", "Closing Balance")

            .Columns("colsSNum").Width = 70
            .Columns("colsAccountName").Width = 150
            .Columns("colsAccountNumber").Width = 150
            .Columns("colsDuration").Width = 200
            .Columns("colsOpeningBalance").Width = 150
            .Columns("colsClosingBalance").Width = 150

            .Columns("colsSNum").ReadOnly = True
            .Columns("colsAccountName").ReadOnly = True
            .Columns("colsAccountNumber").ReadOnly = True
            .Columns("colsDuration").ReadOnly = True
            .Columns("colsOpeningBalance").ReadOnly = True
            .Columns("colsClosingBalance").ReadOnly = True


            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
        End With
    End Sub

    Private Sub loadGrid()
        Dim sqlQuery As String
        Dim month As Integer
        Dim year As Integer
        Dim duration As String

        tblFinancialMonth.Clear()

        sqlQuery = "SELECT * FROM maintain_balance WHERE is_deleted=0"
        tblFinancialMonth = connection.Fetch(sqlQuery)

        grid.Rows.Clear()
        If tblFinancialMonth.Rows.Count = 0 Then Exit Sub
        grid.Rows.Add(tblFinancialMonth.Rows.Count)

        For i = 0 To tblFinancialMonth.Rows.Count - 1

            With grid
                tblFinancialMonth.Move(i)

                duration = tblFinancialMonth.Fields("duration").ToString()
                If duration.Length = 6 Then
                    Month = CInt(duration.Substring(0, 1))
                    Year = CInt(duration.Substring(2, 4))
                ElseIf duration.Length = 7 Then
                    Month = CInt(duration.Substring(0, 2))
                    Year = CInt(duration.Substring(3, 4))
                End If

                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsAccountName").Value = getAccountName(tblFinancialMonth.Fields("account_number"))
                .Rows(i).Cells("colsAccountNumber").Value = tblFinancialMonth.Fields("account_number")
                .Rows(i).Cells("colsDuration").Value = getMonthInWord(month) + " " + CStr(year)
                .Rows(i).Cells("colsOpeningBalance").Value = FormatNumber(tblFinancialMonth.Fields("opening_balance"))

                If tblFinancialMonth.Fields("closing_balance") = "0" Then
                    .Rows(i).Cells("colsClosingBalance").Value = "Yet to be Closed"
                Else
                    .Rows(i).Cells("colsClosingBalance").Value = FormatNumber(tblFinancialMonth.Fields("closing_balance"))
                End If
            End With
        Next i
    End Sub

    Private Function getAccountName(accountNumber As String)
        Dim tblAccounts As New dbO.Table
        Dim sqlQuery As String
        tblAccounts.Clear()

        sqlQuery = $"SELECT * FROM ACCOUNTS WHERE NUMBER = '{ CStr(accountNumber)}' AND is_deleted=0"
        tblAccounts = connection.Fetch(sqlQuery)

        If tblAccounts.Rows.Count = 0 Then Return ""

        Return tblAccounts.Rows(0).Item("name")
    End Function


    Private Sub clear()
        rowIndex = -1
        lblAccount.Text = ""
        lblCurrentMonth.Text = ""
        lblClosingBalance.Text = ""
        lblOpeningBalance.Text = ""
        lblClosingBalance.Text = ""
        lblStatus.Text = ""
    End Sub

    Private Sub enable()

    End Sub

    Private Sub disable()

    End Sub

    Private Sub frmCloseFinancialMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rowIndex = -1
        initGrid()
        loadGrid()
    End Sub


    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        rowIndex = e.RowIndex
        toForm(e.RowIndex)
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

    Private Sub toForm(index As Integer)
        Dim month As Integer
        Dim year As Integer
        Dim duration As String

        tblFinancialMonth.Move(index)

        duration = tblFinancialMonth.Fields("duration").ToString()

        If duration.Length = 6 Then
            month = CInt(duration.Substring(0, 1))
            year = CInt(duration.Substring(2, 4))
        ElseIf duration.Length = 7 Then
            month = CInt(duration.Substring(0, 2))
            year = CInt(duration.Substring(3, 4))
        End If

        lblAccount.Text = getAccountName(tblFinancialMonth.Fields("account_number")) + " - " + tblFinancialMonth.Fields("account_number")
        lblCurrentMonth.Text = getMonthInWord(month) + " " + CStr(year)
        lblOpeningBalance.Text = "N" + FormatNumber(tblFinancialMonth.Fields("opening_balance"))

        If tblFinancialMonth.Fields("closing_balance") = "0" Then
            lblClosingBalance.Text = "Yet to be Closed"
        Else
            lblClosingBalance.Text = "N" + FormatNumber(tblFinancialMonth.Fields("closing_balance"))
        End If

        lblStatus.Text = getStatus(tblFinancialMonth.Fields("status"))
    End Sub

    Private Function getStatus(status As Integer) As String
        If status = 1 Then
            Return "Month is Closed"
        Else
            Return "Month is not Closed"
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnCloseTransaction_Click(sender As Object, e As EventArgs) Handles btnCloseTransaction.Click
        Dim account As String = ""
        Dim openingBalance As String = ""
        Dim duration As String
        Dim month As Integer
        Dim year As Integer
        Dim dialog As DialogResult

        If rowIndex = -1 Then
            MessageBox.Show("You Must Select a record", Application.ProductName)
            clear()
            Exit Sub
        End If

        'Check if the month has been closed
        tblFinancialMonth.Move(rowIndex)
        If tblFinancialMonth.Fields("status") = 1 Then
            MessageBox.Show("Financial Month has been closed", Application.ProductName)
            clear()
            Exit Sub
        End If

        'Check if the bank reconcilation has been generated
        If tblFinancialMonth.Fields("closing_balance") = "0" Then
            MessageBox.Show("Cannot Close financial Month. Reason Bank reconcilation for the month must be generated Or Viewed", Application.ProductName)
            clear()
            Exit Sub
        End If
        dialog = MessageBox.Show("Do you wish to close this financial Month?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Select Case dialog
            Case dialog.Yes
                Dim sqlQuery As String = ""

                'Close the financial Month
                tblFinancialMonth.Fields("status") = 1
                account = tblFinancialMonth.Fields("account_number")
                openingBalance = tblFinancialMonth.Fields("closing_balance")
                duration = tblFinancialMonth.Fields("duration")
                Dim closedDuration = duration
                If duration.Length = 6 Then
                    month = CStr(duration.Substring(0, 1))
                    year = CStr(duration.Substring(2, 4))
                ElseIf duration.Length = 7
                    month = CStr(duration.Substring(0, 2))
                    year = CStr(duration.Substring(3, 4))
                End If

                tblFinancialMonth.Update()

                If month <> 12 Then
                    month = month + 1
                    year = year
                Else

                    month = 1
                    year = year + 1

                    sqlQuery = $"INSERT INTO MAINTAIN_BALANCE_YEARLY (ACCOUNT_NUMBER, OPENING_BALANCE, CLOSING_BALANCE, YEARS, UKEY,is_deleted) VALUES ('{ account }','{ openingBalance}','0','{ CStr(year)}',null,0)"
                    connection.Execute(sqlQuery)

                End If

                sqlQuery = $"UPDATE accounts SET current_balance = '{openingBalance }' WHERE number = '{ CStr(account) }' AND is_deleted=0"
                connection.Execute(sqlQuery)

                duration = CStr(month) + "." + CStr(year)

                tblFinancialMonth.Addnew()
                tblFinancialMonth.Fields("account_number") = CStr(account)
                tblFinancialMonth.Fields("opening_balance") = CStr(openingBalance)
                tblFinancialMonth.Fields("closing_balance") = "0"
                tblFinancialMonth.Fields("status") = 0
                tblFinancialMonth.Fields("duration") = CStr(duration)
                tblFinancialMonth.Update()



                logger.closeFinancialMonth(userID, account, closedDuration.Replace(".", "/"))
                MessageBox.Show("Financial Month was Closed Successfully", Application.ProductName)
                loadGrid()
                clear()
                Exit Sub


            Case dialog.No
                clear()
                Exit Sub
        End Select

    End Sub

End Class
