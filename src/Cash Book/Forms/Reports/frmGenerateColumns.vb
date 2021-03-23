Public Class frmGenerateColumns

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
    Private Sub frmGenerateColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountColumn = ""
        monthColumn = ""
        yearColumn = ""

        loadAccounts()
        loadMonths()
        loadYears()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        accountColumn = CStr(cboAccounts.SelectedValue)
        monthColumn = CStr(cboMonths.SelectedValue)
        yearColumn = CStr(cboYears.SelectedValue)

        'frmColumns.ShowDialog()
    End Sub
End Class