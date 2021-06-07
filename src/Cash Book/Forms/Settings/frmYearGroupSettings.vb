Public Class frmYearGroupSettings
    Dim TblYearGroupList As New dbO.Table
    Dim RowIndex As Integer = -1
    Dim IsEditRecord As Boolean = False
    Dim IsNewRecord As Boolean = False

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub InitGrid()
        With Grid

            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsName", "Name")

            .Columns("ColsName").Width = 300

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsName").ReadOnly = True

            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub

    Private Sub LoadGridData()
        TblYearGroupList.Clear()

        TblYearGroupList = connection.Fetch("SELECT * FROM year_groups WHERE is_deleted=0")

        If TblYearGroupList.RowCount = 0 Then Exit Sub

        Grid.Rows.Clear()
        Grid.Rows.Add(TblYearGroupList.RowCount)
        For i = 0 To TblYearGroupList.RowCount - 1

            TblYearGroupList.Move(i)

            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsName").Value = TblYearGroupList.Fields("name")
            End With
        Next
    End Sub

    Private Sub Reset()

        If IsNewRecord = True And IsEditRecord = False Then Grid.Rows.RemoveAt(Grid.RowCount - 1)
        IsNewRecord = False
        IsEditRecord = False
        RowIndex = -1
        Grid.Columns("ColsName").ReadOnly = True
        Disable()
    End Sub


    Private Sub Disable()
        BtnNew.Enabled = True
        BtnEdit.Enabled = True

        BtnSave.Enabled = False
        BtnUndo.Enabled = False

        BtnRemove.Enabled = True

    End Sub

    Private Sub Enable()
        BtnNew.Enabled = False
        BtnEdit.Enabled = False

        BtnSave.Enabled = True
        BtnUndo.Enabled = True

        BtnRemove.Enabled = False
    End Sub
    Private Sub frmYearGroupSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitGrid()
        LoadGridData()
        Disable()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Reset()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        IsNewRecord = True
        IsEditRecord = False

        'Add A New Row to the Grid View
        Grid.Rows.Add(1)

        'Set the New Row to be the Selected Row
        'Grid.Rows(Grid.RowCount - 1).Selected = True
        Grid.Rows(Grid.RowCount - 1).Cells("ColsSNum").Value = Grid.RowCount
        Grid.Rows(Grid.RowCount - 1).Cells("ColsName").ReadOnly = False
        Enable()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If
        IsNewRecord = False
        IsEditRecord = True
        Grid.Rows(RowIndex).Cells("ColsName").ReadOnly = False
        Enable()
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        RowIndex = e.RowIndex
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsNewRecord = True And IsEditRecord = False Then
            TblYearGroupList.Addnew()
            TblYearGroupList.Fields("name") = Grid.Rows(Grid.RowCount - 1).Cells("ColsName").Value.ToString.ToUpper
            TblYearGroupList.Fields("is_deleted") = 0
            TblYearGroupList.Update()
            MessageBox.Show("New Year Group record was added successfully", Application.ProductName)
            LoadGridData()
            Reset()
        ElseIf IsEditRecord = True And IsNewRecord = False
            If MessageBox.Show("Do you wish to edit this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                TblYearGroupList.Move(RowIndex)
                TblYearGroupList.Fields("name") = Grid.Rows(RowIndex).Cells("ColsName").Value.ToString.ToUpper
                TblYearGroupList.Update()
                MessageBox.Show("Year Group record was updated successfully", Application.ProductName)
            End If
            LoadGridData()
            Reset()
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If
        If MessageBox.Show("Do you wish to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TblYearGroupList.Move(RowIndex)
            TblYearGroupList.Fields("is_deleted") = 1
            TblYearGroupList.Update()
            MessageBox.Show("Year Group record was deleted successfully", Application.ProductName)
        End If
        LoadGridData()
        Reset()
    End Sub
End Class