Public Class logger
    Dim tblLogs As New dbO.Table
    
    Public Sub New()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM logs WHERE ukey = -1"
        tblLogs.Clear()
        tblLogs = connection.Fetch(sqlQuery)
    End Sub

    Public Sub Login(Id As Integer)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = "Logged In"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub AddSchoolFeesPayment(Id, Ammount, StudentId)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Added School Fees Payment Ammount ${Ammount} Paid By ${StudentId}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub
    Public Sub DeductSchoolFeesPayment(Id, Ammount, StudentId)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Deducted School Fees Payment Ammount ${Ammount} Paid By ${StudentId}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub
    Public Sub CreateAccount(Id As Integer, Account As String, Balance As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Created Account {CStr(Account) } with Opening Balance N{ CStr(Balance)}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub DeleteAccount(Id As Integer, Account As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Deleted Account { CStr(Account)}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub CreateTransaction(Id As Integer, Account As String, Ammount As String, Type As String, Person As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = Id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        If Type = "INCOME" Then
            tblLogs.Fields("log_activity") = $"Account {CStr(Account) } deposited N{CStr(Ammount) } by { Person}"
        Else
            tblLogs.Fields("log_activity") = $"Account {CStr(Account)} withdrew N{ CStr(Ammount) } To { Person}"
        End If
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub DeleteTransaction(id As Integer, account As String, ammount As String, type As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        If type = "INCOME" Then
            tblLogs.Fields("log_activity") = $"Account { CStr(account) } deleted a deposit transaction Of  N{ CStr(ammount)}"
        Else
            tblLogs.Fields("log_activity") = $"Account { CStr(account) } deleted a withdraw transction Of N{ CStr(ammount)}"
        End If
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub CreateBankReconcilation(id As Integer, account As String, duration As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Account {CStr(account)} Created Bank reconcilation For the month Of { CStr(duration)}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub DeleteBankReconcilation(id As Integer, account As String, duration As String)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Account {CStr(account) } Deleted Bank reconcilation For the month Of { CStr(duration)}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub

    Public Sub CloseFinancialMonth(id, account, duration)
        tblLogs.Addnew()
        tblLogs.Fields("user_code") = id
        tblLogs.Fields("date_of_activity") = DateAndTime.Now
        tblLogs.Fields("log_activity") = $"Account {CStr(account)} closed For the month Of { CStr(duration)}"
        tblLogs.Fields("is_deleted") = 0
        tblLogs.Update()
    End Sub
End Class
