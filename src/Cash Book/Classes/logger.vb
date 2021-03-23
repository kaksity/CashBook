Public Class logger
    Dim tblLogs As New dbO.Table
    
    Public Sub New()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM logs WHERE ukey = -1"
        tblLogs.Clear()
        tblLogs = connection.Fetch(sqlQuery)
    End Sub

    Public Sub login(id As Integer)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Logged In"
        tblLogs.Update()
    End Sub

    Public Sub createAccount(id As Integer, account As String, balance As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Created Account " + CStr(account) + " with Opening Balance N" + CStr(balance)
        tblLogs.Update()
    End Sub

    Public Sub deleteAccount(id As Integer, account As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Deleted Account " + CStr(account)
        tblLogs.Update()
    End Sub

    Public Sub createTransaction(id As Integer, account As String, ammount As String, type As String, person As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        If type = "INCOME" Then
            tblLogs.Fields("log_activity") = "Account " + CStr(account) + " deposited N" + CStr(ammount) + " by " + person
        Else
            tblLogs.Fields("log_activity") = "Account " + CStr(account) + " withdrew N" + CStr(ammount) + " to " + person
        End If
        tblLogs.Update()
    End Sub

    Public Sub deleteTransaction(id As Integer, account As String, ammount As String, type As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        If type = "INCOME" Then
            tblLogs.Fields("log_activity") = "Account " + CStr(account) + " deleted a deposit transaction of  N" + CStr(ammount)
        Else
            tblLogs.Fields("log_activity") = "Account " + CStr(account) + " deleted a withdraw transction of N" + CStr(ammount)
        End If
        tblLogs.Update()
    End Sub

    Public Sub createBankReconcilation(id As Integer, account As String, duration As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Account " + CStr(account) + " Created Bank reconcilation for the month of " + CStr(duration)
        tblLogs.Update()
    End Sub

    Public Sub deleteBankReconcilation(id As Integer, account As String, duration As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Account " + CStr(account) + " Deleted Bank reconcilation for the month of " + CStr(duration)
        tblLogs.Update()
    End Sub

    Public Sub closeFinancialMonth(id, account, duration)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Account " + CStr(account) + " closed for the month of " + CStr(duration)
        tblLogs.Update()
    End Sub
End Class
