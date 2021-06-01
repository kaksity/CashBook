Public Class frmClassSectionSettings
    Private Sub FillYearGroupComboBox()
        Dim TblYearGroupTable As New dbO.Table

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

            .Columns("ColsYearGroup").Width = 200
            .Columns("ColsClass").Width = 200

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
        Dim Table As New dbO.Table
        SqlQuery = $"SELECT yg.name as year_group_name, cl.name as class_name FROM year_groups yg INNER JOIN classes cl ON yg.id=cl.year_group_id WHERE yg.id = {YearGroupID } yg.is_deleted=0 AND cl.is_deleted=0"

        Table.Clear()

        Table = connection.FetchLight(SqlQuery)

        If Table.RowCount = 0 Then Exit Sub

        Grid.Rows.Clear()
        Grid.Rows.Add(Table.RowCount)

        For i = 0 To Table.RowCount - 1
            Table.Move(i)
            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsYearGroup").Value = Table.Fields("year_group_name")
                .Rows(i).Cells("ColsClass").Value = Table.Fields("class_name")
            End With
        Next
    End Sub
    Private Sub frmClassSectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitGrid()
        FillYearGroupComboBox()
    End Sub

    Private Sub CboYearGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYearGroup.SelectedIndexChanged
        LoadGridData(CboYearGroup.SelectedValue)
    End Sub
End Class