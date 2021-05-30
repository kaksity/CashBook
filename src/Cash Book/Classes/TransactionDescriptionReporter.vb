Imports fyiReporting

Public Class TransactionDescriptionReporter
    Private report As fyiReporting.RDL.Report
    Private datasource As RDL.DataSource

    Public Sub allDescription()
        Dim tblDescription As New dbO.Table
        Dim sqlQuery As String
        Dim viewer As New frmViewTransactionDescriptionDetails
        Dim tblOrganization As New dbO.Table

        tblDescription.Clear()
        sqlQuery = "SELECT * FROM TRANSACTION_DESCRIPTION WHERE is_deleted=0"
        tblDescription = connection.Fetch(sqlQuery)

        tblOrganization.Clear()

        sqlQuery = "SELECT * FROM organization"
        tblOrganization = connection.Fetch(sqlQuery)


        With viewer.RDLViewerDescription
            .SourceFile = Application.StartupPath & "\transaction_description.rdl"
            .Report.DataSets("Data").SetData(tblDescription)
            .Parameters = "organization=" + tblOrganization.Rows(0).Item("name")
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub
End Class
