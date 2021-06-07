Public Class frmClassSectionSettings
    Dim IsNewRecord As Boolean = False
    Dim IsEditRecord As Boolean = False
    Dim RowIndex As Integer = -1
    Dim SqlQuery As String
    Dim TblGridDataTable As New dbO.Table

    Private Sub FillYearGroupComboBox()
        Dim TblYearGroupTable As New dbO.Table

        TblYearGroupTable.Clear()
        TblYearGroupTable = connection.FetchLight("SELECT name,id FROM year_groups WHERE is_deleted=0")
        CboYearGroup.DisplayMember = "NAME"
        CboYearGroup.ValueMember = "ID"
        CboYearGroup.DataSource = TblYearGroupTable
    End Sub

    Private Sub InitGrid()
        With Grid

            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsYearGroup", "Year Group")
            .Columns.Add("ColsClass", "Class Name")

            .Columns("ColsSNum").Width = 100
            .Columns("ColsClass").Width = 200
            .Columns("ColsYearGroup").Width = 200

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsClass").ReadOnly = True
            .Columns("ColsYearGroup").ReadOnly = True

            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With

    End Sub
    Private Sub LoadGridData(YearGroupID As Integer)
        Dim SqlQuery As String

        SqlQuery = $"SELECT yg.name as year_group_name, cl.id as class_id,cl.name as class_name FROM year_groups yg INNER JOIN classes cl ON yg.id=cl.year_group_id WHERE yg.id = {YearGroupID } AND yg.is_deleted=0 AND cl.is_deleted=0"

        TblGridDataTable.Clear()

        TblGridDataTable = connection.FetchLight(SqlQuery)
        Grid.Rows.Clear()

        If TblGridDataTable.RowCount = 0 Then Exit Sub


        Grid.Rows.Add(TblGridDataTable.RowCount)

        For i = 0 To TblGridDataTable.RowCount - 1
            TblGridDataTable.Move(i)
            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsYearGroup").Value = TblGridDataTable.Fields("year_group_name")
                .Rows(i).Cells("ColsClass").Value = TblGridDataTable.Fields("class_name")
            End With
        Next
    End Sub
    Private Sub frmClassSectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitGrid()
        FillYearGroupComboBox()
    End Sub

    Private Sub CboYearGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYearGroup.SelectedIndexChanged
        Reset()
        LoadGridData(CboYearGroup.SelectedValue)
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        IsNewRecord = True
        IsEditRecord = False
        Grid.Rows.Add(1)

        Grid.Rows(Grid.RowCount - 1).Cells("ColsSNum").Value = Grid.RowCount
        Grid.Rows(Grid.RowCount - 1).Cells("ColsYearGroup").Value = CboYearGroup.Text

        Grid.Rows(Grid.RowCount - 1).Cells("ColsClass").ReadOnly = False

        Enable()
    End Sub

    Private Sub Enable()
        BtnNew.Enabled = False
        BtnEdit.Enabled = False

        BtnSave.Enabled = True
        BtnUndo.Enabled = True

        BtnRemove.Enabled = False

    End Sub
    Private Sub Disable()

        BtnNew.Enabled = True
        BtnEdit.Enabled = True

        BtnSave.Enabled = False
        BtnUndo.Enabled = False


        BtnRemove.Enabled = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If
        IsNewRecord = False
        IsEditRecord = True
        Grid.Rows(RowIndex).Cells("ColsClass").ReadOnly = False
        Enable()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Reset()

    End Sub
    Private Sub Reset()
        If IsNewRecord = True And IsEditRecord = False Then Grid.Rows.RemoveAt(Grid.RowCount - 1)

        IsNewRecord = False
        IsEditRecord = False
        RowIndex = -1
        Grid.Columns("ColsClass").ReadOnly = True
        Disable()
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        RowIndex = e.RowIndex
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If


        If MessageBox.Show("Do you wish to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TblGridDataTable.Move(RowIndex)
            SqlQuery = $"UPDATE classes SET is_deleted = 1 WHERE is_deleted=0 AND id={TblGridDataTable.Fields("class_id")}"
            connection.Execute(SqlQuery)
            MessageBox.Show("Class Record was deleted successfully", Application.ProductName)
        End If
        LoadGridData(CboYearGroup.SelectedValue)
        Reset()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsNewRecord = True And IsEditRecord = False Then
            If Grid.Rows(Grid.RowCount - 1).Cells("ColsClass").Value = "" Then
                MessageBox.Show("Class is required", Application.ProductName)
                Exit Sub
            End If

            SqlQuery = $"INSERT INTO CLASSES (id, year_group_id, name, is_deleted)VALUES (null, {CboYearGroup.SelectedValue }, '{Grid.Rows(Grid.RowCount - 1).Cells("ColsClass").Value.ToString.ToUpper }', 0);"
            connection.Execute(SqlQuery)
            MessageBox.Show("New Class record was added successfully", Application.ProductName)
            LoadGridData(CboYearGroup.SelectedValue)
            Reset()
        ElseIf IsNewRecord = False And IsEditRecord = True
            If Grid.Rows(RowIndex).Cells("ColsClass").Value = "" Then
                MessageBox.Show("Class is required", Application.ProductName)
                Exit Sub
            End If
            TblGridDataTable.Move(RowIndex)
            SqlQuery = $"UPDATE classes SET name='{Grid.Rows(RowIndex).Cells("ColsClass").Value.ToString.ToUpper  }' WHERE is_deleted=0 AND id={TblGridDataTable.Fields("class_id")}"
            connection.Execute(SqlQuery)
            MessageBox.Show("Class record was updated successfully", Application.ProductName)
            LoadGridData(CboYearGroup.SelectedValue)
            Reset()
        End If
    End Sub
End Class