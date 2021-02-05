Imports FirebirdSql.Data.FirebirdClient
Imports dbO
Public Class frmSearchAccount
    Private Sub frmSearchAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub loadListOfAccounts()
        Dim sqlQuery As String
        Dim tblAccount As New dbO.Table
        Dim lstAccountItem As ListViewItem
        Dim accountName As String
        sqlQuery = "SELECT * FROM ACCOUNTS"

        tblAccount.Rows.Clear()
        tblAccount = connection.Fetch(sqlQuery)

        If tblAccount.Rows.Count = 0 Then Exit Sub

        For i = 0 To tblAccount.Rows.Count - 1
            accountName = tblAccount.Rows(i).Item("name")
            lstAccountItem = New ListViewItem(accountName)
            lstAccountItem.Tag = tblAccount.Rows(i).Item("number")
            lstAccounts.Items.Add(lstAccountItem)
        Next i
    End Sub
End Class