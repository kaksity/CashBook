Public Class frmSearchForAccount
    Dim tblAccountList As New dbO.Table
    Dim CloseAsAResultOfOkay = False
    Private Sub frmSearchForAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGrid()
        clear()
        loadGrid()
    End Sub
    Private Sub clear()
        txtSearch.Text = ""
        lblNumberOfFoundRecord.Text = ""
        lblSearchResult.Text = ""
    End Sub
    Private Sub initGrid()

        grid.Columns.Clear()
        grid.Rows.Clear()

        With grid
            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsAccountName", "Account Name")
            .Columns.Add("colsAccountNumber", "Account Number")
            .Columns.Add("colsOpeningBalance", "Opening Balance")
            .Columns.Add("colsCurrentBalance", "Current Balance")
            .Columns.Add("colsDateOfOpening", "Date Of Opening")

            .Columns("colsSNum").ReadOnly = True
            .Columns("colsAccountName").ReadOnly = True
            .Columns("colsAccountNumber").ReadOnly = True
            .Columns("colsOpeningBalance").ReadOnly = True
            .Columns("colsCurrentBalance").ReadOnly = True
            .Columns("colsDateOfOpening").ReadOnly = True

            .Columns("colsSNum").Width = 70
            .Columns("colsAccountName").Width = 200
            .Columns("colsAccountNumber").Width = 200
            .Columns("colsOpeningBalance").Width = 200
            .Columns("colsCurrentBalance").Width = 200
            .Columns("colsDateOfOpening").Width = 200

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
        End With
    End Sub

    Private Sub loadGrid()

        tblAccountList.Clear()

        tblAccountList = connection.FetchLight("SELECT * FROM ACCOUNTS WHERE is_deleted=0")

        lblNumberOfFoundRecord.Text = $"Records: {tblAccountList.RowCount }"

        grid.Rows.Clear()

        If tblAccountList.Rows.Count = 0 Then Exit Sub
        grid.Rows.Add(tblAccountList.Rows.Count)

        For i = 0 To tblAccountList.Rows.Count - 1
            grid.Rows(i).Cells("colsSNum").Value = i + 1
            grid.Rows(i).Cells("colsAccountName").Value = tblAccountList.Rows(i).Item("name")
            grid.Rows(i).Cells("colsAccountNumber").Value = tblAccountList.Rows(i).Item("number")
            grid.Rows(i).Cells("colsOpeningBalance").Value = FormatNumber(tblAccountList.Rows(i).Item("opening_balance"))
            grid.Rows(i).Cells("colsCurrentBalance").Value = FormatNumber(tblAccountList.Rows(i).Item("current_balance"))
            grid.Rows(i).Cells("colsDateOfOpening").Value = Format(tblAccountList.Rows(i).Item("opening_date"), "dd/MM/yyyy")
        Next i
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        PubAccountRowIndex = e.RowIndex
        tblAccountList.Move(PubAccountRowIndex)

        lblSearchResult.Text = $"( {tblAccountList.Fields("name")} - {tblAccountList.Fields("number")} )"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PubAccountRowIndex = -1
        Me.Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        CloseAsAResultOfOkay = True
        Me.Close()
    End Sub

    Private Sub frmSearchForAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseAsAResultOfOkay <> True Then PubAccountRowIndex = -1
    End Sub
End Class