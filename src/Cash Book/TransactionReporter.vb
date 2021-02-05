Imports fyiReporting

Public Class TransactionReporter

    Private report As fyiReporting.RDL.Report
    Private datasource As RDL.DataSource


    Private Function getLastDayOfTheMonth(month As Integer)

        Dim result As String
        If month = 9 Or month = 4 Or month = 6 Or month = 11 Then
            result = "30"
        ElseIf month = 2
            result = "28"
        Else
            result = "31"
        End If
        Return result

    End Function

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

    Private Function getDescriptionName(description As Integer) As String
        Dim sqlQuery As String = ""
        Dim table As New dbO.Table

        sqlQuery = "SELECT * FROM transaction_description WHERE ukey = " + CStr(description)
        table.Clear()
        table = connection.Fetch(sqlQuery)

        Return table.Rows(0).Item("description_name")

    End Function

    Private Function generateParams(account As String, month As Integer, year As Integer)
        Dim tblOrganization As New dbO.Table
        Dim tblAccount As New dbO.Table
        Dim tblMaintainBalance As New dbO.Table
        Dim sqlQuery As String
        Dim dateEntered As New Date
        Dim duration As String

        Dim params As String = ""

        'Add Organization parameters
        tblOrganization.Clear()
        sqlQuery = "SELECT * FROM organization"
        tblOrganization = connection.Fetch(sqlQuery)

        params += "Organization=" + tblOrganization.Rows(0).Item("name") + "&"

        'Add Date Parameters

        params += "Title=DETAILED CASHBOOK REPORT AS AT " + getLastDayOfTheMonth(month) + ", " + getMonthInWord(month) + " " + CStr(year) + "&"

        'Add Account Parameters
        tblAccount.Clear()
        sqlQuery = "SELECT * FROM accounts WHERE number = '" + account + "'"
        tblAccount = connection.Fetch(sqlQuery)

        params += "Account=" + tblAccount.Rows(0).Item("name") + "[" + tblAccount.Rows(0).Item("bank_name") + "]" + "&"

        tblMaintainBalance.Clear()

        duration = CStr(month) + "." + CStr(year)
        sqlQuery = "SELECT * FROM maintain_balance WHERE account_number = '" + account + "' AND duration = '" + duration + "'"
        tblMaintainBalance = connection.Fetch(sqlQuery)

        If tblMaintainBalance.Rows.Count = 0 Then
            params += "opening_balance=TRANSACTION OPENING BALANCE AS AT 1ST " + getMonthInWord(month) + " " + CStr(year) + " N NILL" + "&"
        Else
            params += "opening_balance=TRANSACTION OPENING BALANCE AS AT 1ST " + getMonthInWord(month) + " " + CStr(year) + " N" + FormatNumber(tblMaintainBalance.Rows(0).Item("opening_balance")) + "&"
        End If

        Return params
    End Function

    Public Sub allTransaction(account As String, month As Integer, year As Integer)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionReport
        Dim duration As String

        duration = CStr(month) + "." + CStr(year)
        tblTransaction.Clear()
        sqlQuery = "Select * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND extract(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND extract(MONTH FROM date_of_transaction) = '" + CStr(month) + "' ORDER BY date_of_transaction ASC"
        tblTransaction = connection.Fetch(sqlQuery)

        With viewer.RDLViewer
            .SourceFile = Application.StartupPath & "\transaction.rdl"
            .Report.DataSets("Data").SetData(generateTransactionToBeReported(account, duration, tblTransaction))
            .Parameters = generateParams(account, month, year)
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub

    Public Sub specificDescription(account As String, month As Integer, year As Integer, id As Integer)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionReport
        Dim duration As String

        duration = CStr(month) + "." + CStr(year)
        tblTransaction.Clear()
        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND DESCRIPTION_OF_TRANSACTION = " + CStr(id) + " AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'"
        tblTransaction = connection.Fetch(sqlQuery)

        With viewer.RDLViewer
            .SourceFile = Application.StartupPath & "\transaction.rdl"
            .Report.DataSets("Data").SetData(generateTransactionToBeReported(account, duration, tblTransaction))
            .Parameters = generateParams(account, month, year)
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub
    Public Sub allTransactionType(account As String, month As Integer, year As Integer, type As String)
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionReport
        Dim duration As String

        duration = CStr(month) + "." + CStr(year)

        tblTransaction.Clear()
        If type = "INCOME" Then sqlQuery = "SELECT * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND  ammount_withdrawn = 0 AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'" Else sqlQuery = " SELECT * FROM TRANSACTIONS WHERE ammount_deposited = 0 AND EXTRACT(YEAR FROM date_of_transaction) = '" + CStr(year) + "' AND EXTRACT(MONTH FROM date_of_transaction) = '" + CStr(month) + "'"

        tblTransaction = connection.Fetch(sqlQuery)

        With viewer.RDLViewer
            .SourceFile = Application.StartupPath & "\transaction.rdl"
            .Report.DataSets("Data").SetData(generateTransactionToBeReported(account, duration, tblTransaction))
            .Parameters = generateParams(account, month, year)
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub
    Public Sub allSpecificDuration(account As String, duration As String)

        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionReport

        tblTransaction.Clear()

        sqlQuery = "SELECT * FROM TRANSACTIONS WHERE account_number = '" + account + "' AND date_of_transaction LIKE '%" + duration + "'"
        tblTransaction = connection.Fetch(sqlQuery)

        With viewer.RDLViewer
            .SourceFile = Application.StartupPath & "\transaction.rdl"

            .Report.DataSets("Data").SetData(generateTransactionToBeReported(account, duration, tblTransaction))
            .Rebuild()
        End With

        viewer.ShowDialog()

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

        With viewer.RDLViewer
            .SourceFile = Application.StartupPath & "\transaction.rdl"
            .Report.DataSets("Data").SetData(generateTransactionToBeReported(account, duration, tblTransaction))
            .Parameters = generateParams(account, month, year)
            .Rebuild()
        End With

        viewer.ShowDialog()

    End Sub
End Class
