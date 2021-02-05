Imports fyiReporting
Public Class BankReconcilationReporter
    Private report As fyiReporting.RDL.Report
    Private datasource As RDL.DataSource

    Private Function getLastDayOfTheMonth(month As Integer) As String

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

    Private Function generateParameters(ukey As Integer) As String
        Dim parameter As String = ""
        Dim tblUser As New dbO.Table
        Dim tblBankReconcilation As New dbO.Table
        Dim tblTransaction As New dbO.Table
        Dim year As String

        Dim month As String = ""
        Dim duration As String = ""

        Dim totalIncome As String
        Dim totalExpense As String
        Dim subCashBookBalance As String = "0"
        Dim sqlQuery As String = "0"
        Dim openingBalance As String = "0"
        Dim cashBookBalance As String = "0"
        Dim suggestedCashbookBalance As String = "0"
        Dim bankTotal As String = "0"
        Dim bankAddTotal As String = "0"
        Dim bankLessTotal As String = "0"
        Dim reconciledBalance As String = "0"
        Dim closingBalance As String = "0"

        Dim tblOrganization As New dbO.Table
        Dim tblAccounts As New dbO.Table
        Dim months As Integer = 0
        Dim years As Integer = 0
        Dim dateOfReconcilation As String
        Dim tblMaintainYearBalance As New dbO.Table


        tblUser.Clear()
        sqlQuery = "Select * FROM users WHERE user_code=" + CStr(userID)
        tblUser = connection.Fetch(sqlQuery)

        tblOrganization.Clear()
        sqlQuery = "Select * FROM organization"
        tblOrganization = connection.Fetch(sqlQuery)

        sqlQuery = "Select * FROM bank_reconcilation WHERE ukey = " + CStr(ukey)
        tblBankReconcilation.Clear()
        tblBankReconcilation = connection.Fetch(sqlQuery)

        sqlQuery = "Select * FROM maintain_balance WHERE duration = ''"
        sqlQuery = "SELECT * FROM accounts WHERE number = '" + tblBankReconcilation.Rows(0).Item("account_number") + "'"
        tblAccounts.Clear()
        tblAccounts = connection.Fetch(sqlQuery)

        dateOfReconcilation = tblBankReconcilation.Rows(0).Item("duration").ToString()
        If dateOfReconcilation.Length = 6 Then
            months = CInt(dateOfReconcilation.Substring(0, 1))
            years = CInt(dateOfReconcilation.Substring(2, 4))
        ElseIf dateOfReconcilation.Length = 7
            months = CInt(dateOfReconcilation.Substring(0, 2))
            years = CInt(dateOfReconcilation.Substring(3, 4))
        End If

        sqlQuery = "SELECT * FROM maintain_balance WHERE account_number = '" + tblBankReconcilation.Rows(0).Item("account_number") + "' AND duration = '" + CStr(dateOfReconcilation.Replace("/", ".")) + "'"
        tblMaintainYearBalance.Clear()
        tblMaintainYearBalance = connection.Fetch(sqlQuery)

        tblMaintainYearBalance.Move(0)

        openingBalance = tblMaintainYearBalance.Fields("opening_balance")

        parameter += "organization_name=" + tblOrganization.Rows(0).Item("name") + "&"
        parameter += "title=BANK RECONCILATION AS AT " + getLastDayOfTheMonth(months) + ", " + getMonthInWord(months) + " " + CStr(years) + "&"
        parameter += "account=" + tblAccounts.Rows(0).Item("name") + "[" + tblAccounts.Rows(0).Item("bank_name") + "]&"

        parameter += "credit_transfer=N" + FormatNumber(tblBankReconcilation.Rows(0).Item("credit_transfer")) + "&interest_received=N" + FormatNumber(tblBankReconcilation.Rows(0).Item("interest_received")) + "&"
        parameter += "state_chqs_reversed=N" + FormatNumber(tblBankReconcilation.Rows(0).Item("stale_chqs_reversed")) + "&"
        parameter += "bank_charges=N" + FormatNumber(tblBankReconcilation.Rows(0).Item("bank_charges")) + "&debit_transfer=N" + FormatNumber(tblBankReconcilation.Rows(0).Item("debit_transfer")) + "&"


        duration = tblBankReconcilation.Rows(0).Item("duration").ToString()

        If duration.Length = 6 Then
            month = tblBankReconcilation.Rows(0).Item("duration").ToString().Substring(0, 1)
            year = tblBankReconcilation.Rows(0).Item("duration").ToString().Substring(2, 4)
        ElseIf duration.Length = 7
            month = tblBankReconcilation.Rows(0).Item("duration").ToString().Substring(0, 2)
            year = tblBankReconcilation.Rows(0).Item("duration").ToString().Substring(3, 4)
        End If

        sqlQuery = "SELECT * FROM transactions WHERE account_number = '" + tblBankReconcilation.Rows(0).Item("account_number") + "' AND extract(YEAR FROM date_of_transaction) = '" + year + "' AND extract(MONTH FROM date_of_transaction) = '" + month + "'"
        tblTransaction.Clear()
        tblTransaction = connection.Fetch(sqlQuery)

        For i = 0 To tblTransaction.Rows.Count - 1
            If tblTransaction.Rows(i).Item("ammount_withdrawn") = "0" Then

                totalIncome = CStr(Val(totalIncome) + Val(tblTransaction.Rows(i).Item("ammount_deposited")))

            ElseIf tblTransaction.Rows(i).Item("ammount_deposited") = "0"

                totalExpense = CStr(Val(totalExpense) + Val(tblTransaction.Rows(i).Item("ammount_withdrawn")))

            End If
        Next

        subCashBookBalance = CStr(Val(totalIncome) + Val(tblBankReconcilation.Rows(0).Item("credit_transfer")) + Val(tblBankReconcilation.Rows(0).Item("interest_received")) + Val(tblBankReconcilation.Rows(0).Item("stale_chqs_reversed")))
        subCashBookBalance = CStr(Val(subCashBookBalance) - Val(totalExpense) - Val(tblBankReconcilation.Rows(0).Item("debit_transfer")) - Val(tblBankReconcilation.Rows(0).Item("bank_charges")))
        cashBookBalance = CStr(Val(subCashBookBalance) + Val(openingBalance))
        suggestedCashbookBalance = CStr(Val(cashBookBalance) + Val(tblBankReconcilation.Rows(0).Item("outstanding_stale_chqs")))


        parameter += "receipts=N" + CStr(FormatNumber(totalIncome)) + "&payments=N" + CStr(FormatNumber(totalExpense)) + "&sub_cashbook_balance=N" + CStr(FormatNumber(subCashBookBalance)) + "&"
        parameter += "opening_balance=N" + CStr(FormatNumber(openingBalance)) + "&cashbook_balance=N" + CStr(FormatNumber(cashBookBalance)) + "&"
        parameter += "outstanding_stale_chqs=N" + CStr(FormatNumber(CLng(tblBankReconcilation.Rows(0).Item("outstanding_stale_chqs")))) + "&suggested_cashbook_balance=N" + CStr(FormatNumber(suggestedCashbookBalance)) + "&"
        parameter += "unpresented_cheques=N" + CStr(FormatNumber(tblBankReconcilation.Rows(0).Item("unpresented_chqs"))) + "&items_in_bank_not_in_cashbook=N" + CStr(FormatNumber(tblBankReconcilation.Rows(0).Item("bank_not_cashbook"))) + "&"
        parameter += "uncredited_lodgements=N" + CStr(FormatNumber(tblBankReconcilation.Rows(0).Item("uncredited_lodgements"))) + "&items_in_cashbook_not_in_bank=N" + CStr(FormatNumber(tblBankReconcilation.Rows(0).Item("cashbook_not_bank"))) + "&"

        bankAddTotal = CStr(Val(tblBankReconcilation.Rows(0).Item("unpresented_chqs")) + Val(tblBankReconcilation.Rows(0).Item("bank_not_cashbook")))
        bankLessTotal = CStr(Val(tblBankReconcilation.Rows(0).Item("uncredited_lodgements")) + Val(tblBankReconcilation.Rows(0).Item("cashbook_not_bank")))
        bankTotal = CStr(Val(bankAddTotal) - Val(bankLessTotal))

        parameter += "bank_add_total=N" + CStr(FormatNumber(bankAddTotal)) + "&bank_less_total=N" + CStr(FormatNumber(bankLessTotal)) + "&bank_total=N" + CStr(FormatNumber(bankTotal)) + "&"

        reconciledBalance = CStr(Val(suggestedCashbookBalance) + Val(bankTotal))
        closingBalance = reconciledBalance

        'Save The Reconciled Balance as the Closing Balance for the month
        duration = duration.Replace("/", ".")
        sqlQuery = "UPDATE maintain_balance SET closing_balance = '" + CStr(suggestedCashbookBalance) + "' WHERE account_number = '" + tblAccounts.Rows(0).Item("number") + "' AND duration = '" + duration + "'"
        connection.Execute(sqlQuery)

        'Text Parameters
        parameter += "text_cashbook_opening_balance=CASHBOOK O/BALANCE AS AT 1st " + getMonthInWord(month) + " " + CStr(year) + "&"
        parameter += "text_cashbook_balance=CASHBOOK BALANCE AS AT " + CStr(getLastDayOfTheMonth(month)) + " " + getMonthInWord(month) + " " + CStr(year) + "&"
        parameter += "text_suggested_cashbook_balance=SUGGESTED CASHBOOK BALANCE AS AT " + CStr(getLastDayOfTheMonth(month)) + " " + getMonthInWord(month) + " " + CStr(year) + "&"
        parameter += "text_reconciled_balance=SUGGESTED CASHBOOK BALANCE AS AT " + CStr(getLastDayOfTheMonth(month)) + " " + getMonthInWord(month) + " " + CStr(year) + "&"
        parameter += "text_closing_balance=SUGGESTED BANK BALANCE AS AT " + CStr(getLastDayOfTheMonth(month)) + " " + getMonthInWord(month) + " " + CStr(year) + "&"
        parameter += "reconciled_balance=N" + CStr(FormatNumber(reconciledBalance)) + "&closing_balance=N" + CStr(FormatNumber(closingBalance)) + "&"

        parameter += "prepared_by=" + CStr(tblUser.Rows(0).Item("full_name")) + "&"
        Return parameter
    End Function
    Public Sub renderReport(id As Integer)
        Dim viewer As New frmViewBankReconcilationDetails

        With viewer.rdlViews
            .SourceFile = Application.StartupPath & "\bank_reconcilation.rdl"
            .Parameters = generateParameters(id)
            .Rebuild()
        End With
        viewer.ShowDialog()
    End Sub
End Class
