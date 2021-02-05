Public Class frmAddSupportingDocument
    Private newRecord As Boolean = False
    Private editRecord As Boolean = False
    Private tblSupportingDocument As New dbO.Table

    Private rowIndex As Integer = -1

    Private Sub initGrid()
        grid.Rows.Clear()
        grid.Columns.Clear()

        With grid
            .Columns.Add("colsSNum", "S/No")
            .Columns.Add("colsName", "Name")
            .Columns.Add("colsDescription", "Description")

            .Columns("colsSNum").ReadOnly = True
            .Columns("colsName").ReadOnly = True
            .Columns("colsDescription").ReadOnly = True


            .Columns("colsSNum").Width = 100
            .Columns("colsName").Width = 200
            .Columns("colsDescription").Width = 350

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub

    Private Sub loadGrid()
        Dim sqlQuery As String

        tblSupportingDocument.Clear()

        sqlQuery = "SELECT * FROM supporting_document WHERE transactions = '" + selectedExpenseTransaction + "'"

        tblSupportingDocument = connection.Fetch(sqlQuery)

        grid.Rows.Clear()
        If tblSupportingDocument.Rows.Count = 0 Then Exit Sub

        grid.Rows.Add(tblSupportingDocument.Rows.Count)

        For i = 0 To tblSupportingDocument.Rows.Count - 1
            With grid
                .Rows(i).Cells("colsSNum").Value = i + 1
                .Rows(i).Cells("colsName").Value = tblSupportingDocument.Rows(i).Item("name")
                .Rows(i).Cells("colsDescription").Value = tblSupportingDocument.Rows(i).Item("description")
            End With
        Next i
    End Sub

    Private Sub clear()
        txtDocumentDescription.Text = ""
        txtNameOfDocument.Text = ""
        picDocument.Image = Nothing
    End Sub

    Private Sub enable()
        grid.Enabled = False
        txtNameOfDocument.Enabled = True
        txtDocumentDescription.Enabled = True

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        btnAddDocument.Enabled = True
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub disable()
        grid.Enabled = True
        txtDocumentDescription.Enabled = False
        txtNameOfDocument.Enabled = False

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        btnAddDocument.Enabled = False
        btnSave.Enabled = False
        btnUndo.Enabled = False
    End Sub

    Private Sub frmAddSupportingDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passport = False
        document = False
        clear()
        disable()
        initGrid()
        loadGrid()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newRecord = True
        editRecord = False

        enable()
        clear()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editRecord = True
        newRecord = False
        enable()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        newRecord = False
        editRecord = False
        rowIndex = -1
        clear()
        disable()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        If newRecord = True And editRecord = False Then

            If txtNameOfDocument.Text = "" Then
                MessageBox.Show("Name of Document is required", Application.ProductName)
                txtNameOfDocument.Focus()
                Exit Sub
            End If

            If picDocument.Image Is Nothing Then
                MessageBox.Show("An Image of the document is required", Application.ProductName)
                btnAddDocument.Focus()
                Exit Sub
            End If


            tblSupportingDocument.Addnew()

            tblSupportingDocument.Fields("transactions") = CInt(selectedExpenseTransaction)
            tblSupportingDocument.Fields("name") = txtNameOfDocument.Text.ToUpper.Trim
            tblSupportingDocument.Fields("description") = txtDocumentDescription.Text.ToUpper.Trim
            tblSupportingDocument.Fields("document") = picDocument.Image

            tblSupportingDocument.Update()
            MessageBox.Show("Supporting Document record was added successfully", Application.ProductName)
            disable()
            clear()
            loadGrid()

            Exit Sub
        ElseIf newRecord = False And editRecord = True

            If txtNameOfDocument.Text = "" Then
                MessageBox.Show("Name of Document is required", Application.ProductName)
                txtNameOfDocument.Focus()
                Exit Sub
            End If

            If picDocument.Image Is Nothing Then
                MessageBox.Show("An Image of the document is required", Application.ProductName)
                btnAddDocument.Focus()
                Exit Sub
            End If

            dialog = MessageBox.Show("Do you wish to update this supporting document record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Select Case dialog
                Case dialog.Yes
                    tblSupportingDocument.Move(rowIndex)
                    tblSupportingDocument.Fields("name") = txtNameOfDocument.Text.ToUpper.Trim
                    tblSupportingDocument.Fields("description") = txtDocumentDescription.Text.ToUpper.Trim
                    tblSupportingDocument.Fields("document") = picDocument.Image
                    tblSupportingDocument.Update()
                    MessageBox.Show("Supporting Document record was updated successfully", Application.ProductName)
                    loadGrid()
                    clear()
                    disable()
                    Exit Sub
                Case dialog.No
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        passport = False
        document = True
        picDocument.Image = frmAcquire.Acquire
        passport = False
        document = False
    End Sub

    Private Sub toForm(index As Integer)

        tblSupportingDocument.Move(index)
        txtNameOfDocument.Text = tblSupportingDocument.Fields("name")
        txtDocumentDescription.Text = tblSupportingDocument.Fields("description")
        picDocument.Image = tblSupportingDocument.Fields("document")
    End Sub


    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
        rowIndex = e.RowIndex
        toForm(e.RowIndex)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As DialogResult

        If rowIndex = -1 Then
            MessageBox.Show("You Must Select a record before you can delete a record", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes
                Dim ukey As Integer
                Dim sqlQuery As String


                tblSupportingDocument.Move(rowIndex)

                ukey = tblSupportingDocument.Fields("ukey")
                sqlQuery = "DELETE FROM supporting_document WHERE ukey = " + CStr(ukey)
                connection.Execute(sqlQuery)

                'tblSupportingDocument.Delete()
                'tblSupportingDocument.Save()
                'tblSupportingDocument.Update()
                MessageBox.Show("Supportting Document record was deleted successfully", Application.ProductName)
                clear()
                loadGrid()
                Exit Sub
            Case dialog.No
                Exit Sub
        End Select
    End Sub
End Class