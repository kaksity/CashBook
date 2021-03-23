Imports fyiReporting
Public Class AccountReporter
    Private report As fyiReporting.RDL.Report
    Private datasource As RDL.DataSource
    Private path As String = Application.StartupPath


    Private Function prepareTable(table As dbO.Table) As dbO.Table

        For i = 0 To table.RowCount - 1
            table.Move(0)
            table.Fields("opening_balance") = FormatNumber(table.Fields("opening_balance"))
            table.Fields("current_balance") = FormatNumber(table.Fields("current_balance"))
            table.Save()
        Next

        Return table
    End Function

    Public Sub allAccount()
        Dim sqlQuery As String
        Dim tblAccounts As New dbO.Table

        Dim tblOrganization As New dbO.Table

        Dim viewer As New frmViewAccountDetails

        sqlQuery = "SELECT * FROM accounts"

        tblAccounts.Clear()
        tblAccounts = connection.Fetch(sqlQuery)

        tblOrganization.Clear()

        sqlQuery = "SELECT * FROM organization"
        tblOrganization = connection.Fetch(sqlQuery)

        With viewer.RdlViewer1

            .SourceFile = Application.StartupPath & "\accounts.rdl"
            .Report.DataSets("Data").SetData(prepareTable(tblAccounts))
            .Parameters = "organization=" + tblOrganization.Rows(0).Item("name")
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub

End Class
