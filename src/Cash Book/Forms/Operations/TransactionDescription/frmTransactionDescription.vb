Public Class frmTransactionDescription
    Dim tblTransactionDescription As New dbO.Table
    Dim newRecord As Boolean = False
    Dim editRecord As Boolean = False
    Dim rowIndex As Int16 = -1

    Private Sub enable()
        grid.Enabled = False
        txtDescription.Enabled = True
        txtNameOfDescription.Enabled = True
        cboTypeOfTransaction.Enabled = True

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnUndo.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub loadTypeOfTransaction()
        Dim tblTypeOfTransaction As New DataTable

        tblTypeOfTransaction.Columns.Add("name", GetType(String))
        tblTypeOfTransaction.Columns.Add("value", GetType(String))


        tblTypeOfTransaction.Rows.Add("Income", "INCOME")
        tblTypeOfTransaction.Rows.Add("Expense", "EXPENSE")

        cboTypeOfTransaction.DisplayMember = "name"
        cboTypeOfTransaction.ValueMember = "value"
        cboTypeOfTransaction.DataSource = tblTypeOfTransaction
    End Sub
    Private Sub disable()
        grid.Enabled = True
        txtDescription.Enabled = False
        txtNameOfDescription.Enabled = False
        cboTypeOfTransaction.Enabled = False

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnUndo.Enabled = False
        btnDelete.Enabled = True

    End Sub
    Private Sub initGrid()

        grid.Columns.Clear()
        grid.Rows.Clear()

        With grid
            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsName", "Name")
            .Columns.Add("colsTypeOfTransaction", "Type Of Transaction")
            .Columns.Add("colsDescription", "Description")

            .Columns("colsSNum").Width = 100
            .Columns("colsName").Width = 200
            .Columns("colsTypeOfTransaction").Width = 150
            .Columns("colsDescription").Width = 200

            .Columns("colsSNum").ReadOnly = True
            .Columns("colsName").ReadOnly = True
            .Columns("colsTypeOfTransaction").ReadOnly = True
            .Columns("colsDescription").ReadOnly = True

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub

    Private Sub loadGrid()
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM TRANSACTION_DESCRIPTION"
        tblTransactionDescription.Clear()
        tblTransactionDescription = connection.Fetch(sqlQuery)
        grid.Rows.Clear()
        If tblTransactionDescription.Rows.Count = 0 Then Exit Sub
        grid.Rows.Add(tblTransactionDescription.Rows.Count)

        For i = 0 To tblTransactionDescription.Rows.Count - 1
            With grid
                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsName").Value = tblTransactionDescription.Rows(i).Item("description_name")
                .Rows(i).Cells("colsTypeOfTransaction").Value = tblTransactionDescription.Rows(i).Item("type_of_transaction")
                .Rows(i).Cells("colsDescription").Value = tblTransactionDescription.Rows(i).Item("description")
            End With
        Next i

    End Sub

    Private Sub clear()
        txtDescription.Text = ""
        txtNameOfDescription.Text = ""
        rowIndex = -1
    End Sub

    Private Sub reset()
        rowIndex = -1
        loadGrid()
        loadTypeOfTransaction()
        disable()
        clear()
        newRecord = False
        editRecord = False
    End Sub

    Private Sub frmTransactionDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGrid()
        reset()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        enable()
        clear()
        newRecord = True
        editRecord = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enable()
        cboTypeOfTransaction.Enabled = False
        newRecord = False
        editRecord = True
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        reset()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        If newRecord = True And editRecord = False Then
            If txtNameOfDescription.Text = "" Then
                MessageBox.Show("Name of Description is required", Application.ProductName)
                txtNameOfDescription.Focus()
                Exit Sub
            End If

            If cboTypeOfTransaction.SelectedValue = "" Then
                MessageBox.Show("Type of Transaction is required", Application.ProductName)
                cboTypeOfTransaction.Focus()
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to add this Description?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes
                    'Add the Transaction description into the transaction database
                    tblTransactionDescription.Addnew()
                    tblTransactionDescription.Fields("description_name") = txtNameOfDescription.Text.Trim.ToUpper
                    tblTransactionDescription.Fields("type_of_transaction") = cboTypeOfTransaction.SelectedValue
                    tblTransactionDescription.Fields("description") = txtDescription.Text.ToUpper.Trim
                    tblTransactionDescription.Update()

                    MessageBox.Show("Transction description record was added successfully", Application.ProductName)
                    reset()
                    Exit Sub
                Case dialog.No
                    reset()
            End Select

        ElseIf newRecord = False And editRecord = True
            dialog = MessageBox.Show("Do you wish to Updated this Description?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialog
                Case dialog.Yes
                    tblTransactionDescription.Move(rowIndex)
                    tblTransactionDescription.Fields("description") = txtDescription.Text.ToUpper.Trim
                    tblTransactionDescription.Update()
                    MessageBox.Show("Transaction description record was updated successfully", Application.ProductName)
                    reset()

                    Exit Sub
                Case dialog.No
                    reset()
                    Exit Sub
            End Select
        End If
    End Sub
    Private Sub toForm(row As Integer)
        txtNameOfDescription.Text = tblTransactionDescription.Rows(row).Item("description_name")
        txtDescription.Text = tblTransactionDescription.Rows(row).Item("description")
        cboTypeOfTransaction.SelectedValue = tblTransactionDescription.Rows(row).Item("type_of_transaction")
    End Sub
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        rowIndex = e.RowIndex
        toForm(rowIndex)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As DialogResult
        If rowIndex = -1 Then
            MessageBox.Show("You Must select a record", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to delete this transaction description record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes

                'Check if the transaction description has been used
                Try
                    tblTransactionDescription.Move(rowIndex)
                    tblTransactionDescription.Delete()
                    tblTransactionDescription.Update()
                    MessageBox.Show("Transaction Description was deleted successfully", Application.ProductName)

                Catch ex As Exception
                    MessageBox.Show("Cannot delete this record", Application.ProductName)
                End Try
                reset()
            Case dialog.No
                reset()
        End Select
    End Sub
End Class