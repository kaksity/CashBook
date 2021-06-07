Public Class frmRegisterStudent
    Dim IsNewRecord As Boolean = False
    Dim IsEditRecord As Boolean = False
    Dim RowIndex As Integer = -1
    Dim TblStudents As New dbO.Table

    Private Sub LoadGridData(AcademicSession As String, YearGroup As Integer, AcademicClass As Integer)
        Dim SqlQuery As String

        SqlQuery = $"SELECT * FROM students WHERE academic_session = '{AcademicSession }' AND year_group_id = {YearGroup } AND class_id = '{AcademicClass }' AND is_deleted=0"
        TblStudents.Clear()

        TblStudents = connection.Fetch(SqlQuery)

        Grid.Rows.Clear()

        If TblStudents.RowCount = 0 Then Exit Sub

        Grid.Rows.Add(TblStudents.RowCount)

        For i = 0 To TblStudents.RowCount - 1
            TblStudents.Move(i)
            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsAdmissionNumber").Value = TblStudents.Fields("admission_number")
                .Rows(i).Cells("ColsFullName").Value = TblStudents.Fields("full_name")
            End With
        Next

    End Sub

    Private Sub FillYearGroupComboBox()
        Dim SqlQuery As String
        Dim TblYearGroups As New dbO.Table

        SqlQuery = "SELECT id,name FROM year_groups WHERE is_deleted=0"

        TblYearGroups.Clear()
        TblYearGroups = connection.FetchLight(SqlQuery)

        CboYearGroup.DisplayMember = "name"
        CboYearGroup.ValueMember = "id"
        CboYearGroup.DataSource = TblYearGroups
    End Sub

    Private Sub FillClassComboBox(YearGroupId As Integer)
        Dim SqlQuery As String
        Dim TblYearGroups As New dbO.Table

        SqlQuery = $"SELECT * FROM classes WHERE year_group_id = {YearGroupId } AND is_deleted=0"

        TblYearGroups.Clear()
        TblYearGroups = connection.FetchLight(SqlQuery)

        CboClass.DisplayMember = "name"
        CboClass.ValueMember = "id"
        CboClass.DataSource = TblYearGroups
    End Sub
    Private Sub FillSessionCombox()
        Dim SqlQuery As String
        Dim TblSession As New dbO.Table

        SqlQuery = "SELECT * FROM sessions WHERE is_deleted=0"
        TblSession.Clear()

        TblSession = connection.FetchLight(SqlQuery)


        CboAcademicSession.DisplayMember = "session"
        CboAcademicSession.ValueMember = "id"
        CboAcademicSession.DataSource = TblSession

    End Sub
    Private Sub frmRegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillYearGroupComboBox()
        FillSessionCombox()
        InitGrid()
        Disable()

    End Sub

    Private Sub Enable()
        TxtAdmissionNumber.Enabled = True
        TxtFullName.Enabled = True

        Grid.Enabled = False

        BtnNew.Enabled = False
        BtnEdit.Enabled = False

        BtnUndo.Enabled = True
        BtnSave.Enabled = True

        BtnRemove.Enabled = False
    End Sub

    Private Sub Disable()
        TxtAdmissionNumber.Enabled = False
        TxtFullName.Enabled = False

        Grid.Enabled = True

        BtnNew.Enabled = True
        BtnEdit.Enabled = True

        BtnUndo.Enabled = False
        BtnSave.Enabled = False

        BtnRemove.Enabled = True
    End Sub
    Private Sub InitGrid()
        With Grid
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsAdmissionNumber", "Admission Number")
            .Columns.Add("ColsFullName", "Full Name")

            .Columns("ColsSNum").Width = 70
            .Columns("ColsAdmissionNumber").Width = 200
            .Columns("ColsFullName").Width = 200

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsAdmissionNumber").ReadOnly = True
            .Columns("ColsFullName").ReadOnly = True

            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub

    Private Sub CboYearGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYearGroup.SelectedIndexChanged
        FillClassComboBox(CboYearGroup.SelectedValue)
    End Sub
    Private Sub Reset()
        IsNewRecord = False
        IsEditRecord = False
        RowIndex = -1
        Clear()
        Disable()
    End Sub

    Private Sub Clear()
        TxtAdmissionNumber.Text = ""
        TxtFullName.Text = ""
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        IsNewRecord = True
        IsEditRecord = False
        Enable()
        Clear()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If
        IsNewRecord = False
        IsEditRecord = True
        Enable()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Reset()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtAdmissionNumber.Text = "" Then
            MessageBox.Show("Admission Number is required", Application.ProductName)
            TxtAdmissionNumber.Focus()
            Exit Sub
        End If

        If TxtFullName.Text = "" Then
            MessageBox.Show("Full Name is required", Application.ProductName)
            TxtFullName.Focus()
            Exit Sub
        End If

        If IsNewRecord = True And IsEditRecord = False Then
            TblStudents.Addnew()
            TblStudents.Fields("academic_session") = CboAcademicSession.SelectedValue
            TblStudents.Fields("year_group_id") = CboYearGroup.SelectedValue
            TblStudents.Fields("class_id") = CboClass.SelectedValue
            TblStudents.Fields("admission_number") = TxtAdmissionNumber.Text
            TblStudents.Fields("full_name") = TxtFullName.Text.ToUpper.Trim
            TblStudents.Fields("is_deleted") = 0
            TblStudents.Update()

            MessageBox.Show("New Student Record was added successfully", Application.ProductName)
            Reset()
            LoadGridData(CboAcademicSession.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
        ElseIf IsNewRecord = False And IsEditRecord = True
            If MessageBox.Show("Do you wish to edit this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then
                TblStudents.Move(RowIndex)
                TblStudents.Fields("academic_session") = CboAcademicSession.SelectedValue
                TblStudents.Fields("year_group_id") = CboYearGroup.SelectedValue
                TblStudents.Fields("class_id") = CboClass.SelectedValue
                TblStudents.Fields("full_name") = TxtFullName.Text.ToUpper.Trim
                TblStudents.Update()

                MessageBox.Show("Student Record was updated successfully", Application.ProductName)
            End If
            Reset()
            LoadGridData(CboAcademicSession.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
            End If
    End Sub

    Private Sub ToForm(Index As Integer)
        TblStudents.Move(Index)
        TxtAdmissionNumber.Text = TblStudents.Fields("admission_number")
        TxtFullName.Text = TblStudents.Fields("full_name")
    End Sub
    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        RowIndex = e.RowIndex
        ToForm(RowIndex)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If
        If MessageBox.Show("Do you wish to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TblStudents.Move(RowIndex)
            TblStudents.Fields("is_deleted") = 1
            TblStudents.Update()
            MessageBox.Show("Student Record was deleted successfully", Application.ProductName)
        End If
        Reset()
        LoadGridData(CboAcademicSession.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
    End Sub


    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        LoadGridData(CboAcademicSession.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
    End Sub
End Class