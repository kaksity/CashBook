Public Class frmSchoolFeesSettings
    Dim IsNewRecord As Boolean = False
    Dim TblSchoolFeesSettings As New dbO.Table
    Dim RowIndex As Integer = -1
    Private Sub InitData()
        Dim SqlQuery As String
        SqlQuery = "SELECT * FROM school_fees WHERE is_deleted=0"

        TblSchoolFeesSettings.Clear()
        TblSchoolFeesSettings = connection.Fetch(SqlQuery)

    End Sub
    Private Sub LoadGridData()
        Dim SqlQuery As String
        Dim TblSchoolFeesGridSettings As New dbO.Table

        TblSchoolFeesGridSettings.Clear()

        SqlQuery = "SELECT s.session ,sf.academic_term,yg.name, sf.ammount as school_fees_ammount FROM school_fees sf INNER JOIN sessions s ON sf.session_id=s.id INNER JOIN year_groups yg ON sf.year_group_id=yg.id WHERE sf.is_deleted=0"
        TblSchoolFeesGridSettings = connection.FetchLight(SqlQuery)

        Grid.Rows.Clear()

        If TblSchoolFeesGridSettings.RowCount = 0 Then Exit Sub
        Grid.Rows.Add(TblSchoolFeesGridSettings.RowCount)

        For i = 0 To TblSchoolFeesGridSettings.RowCount - 1
            TblSchoolFeesGridSettings.Move(i)

            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsSession").Value = TblSchoolFeesGridSettings.Fields("session")
                .Rows(i).Cells("ColsTerm").Value = TblSchoolFeesGridSettings.Fields("academic_term")
                .Rows(i).Cells("ColsYearGroup").Value = TblSchoolFeesGridSettings.Fields("name")
                .Rows(i).Cells("ColsAmmount").Value = $"N{FormatNumber(TblSchoolFeesGridSettings.Fields("school_fees_ammount"))}"
            End With
        Next
    End Sub
    Private Sub frmSchoolFeesSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAcademicTerm()
        FillYearGroupComboBox()
        FillSessionCombox()
        InitGrid()
        InitData()
        LoadGridData()
        Disable()
        Clear()
    End Sub

    Private Sub Clear()
        TxtSchoolFees.Text = ""
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

    Private Sub InitGrid()
        With Grid

            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsSession", "Session")
            .Columns.Add("ColsTerm", "Academic Term")
            .Columns.Add("ColsYearGroup", "Year Group")
            .Columns.Add("ColsAmmount", "Ammount")

            .Columns("ColsSNum").Width = 70
            .Columns("ColsSession").Width = 200
            .Columns("ColsTerm").Width = 200
            .Columns("ColsYearGroup").Width = 150
            .Columns("ColsAmmount").Width = 150

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsSession").ReadOnly = True
            .Columns("ColsTerm").ReadOnly = True
            .Columns("ColsYearGroup").ReadOnly = True
            .Columns("ColsAmmount").ReadOnly = True

            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub
    Private Sub FillAcademicTerm()
        Dim TblAcademicTerm As New dbO.Table

        TblAcademicTerm.Clear()

        TblAcademicTerm.Columns.Add("name", GetType(String))
        TblAcademicTerm.Columns.Add("value", GetType(String))

        TblAcademicTerm.Rows.Add("First Term", "First Term")
        TblAcademicTerm.Rows.Add("Second Term", "Second Term")
        TblAcademicTerm.Rows.Add("Third Term", "Third Term")

        CboTerm.DisplayMember = "name"
        CboTerm.ValueMember = "value"

        CboTerm.DataSource = TblAcademicTerm
    End Sub
    Private Sub CboYearGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYearGroup.SelectedIndexChanged

    End Sub
    Private Sub Enable()
        CboAcademicSession.Enabled = True
        CboTerm.Enabled = True
        CboYearGroup.Enabled = True
        TxtSchoolFees.Enabled = True

        Grid.Enabled = False

        BtnNew.Enabled = False
        BtnUndo.Enabled = True
        BtnSave.Enabled = True
        BtnDelete.Enabled = False
    End Sub
    Private Sub Disable()
        CboAcademicSession.Enabled = False
        CboTerm.Enabled = False
        CboYearGroup.Enabled = False
        TxtSchoolFees.Enabled = False

        Grid.Enabled = True

        BtnNew.Enabled = True
        BtnUndo.Enabled = False
        BtnSave.Enabled = False
        BtnDelete.Enabled = True
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        IsNewRecord = True
        Clear()
        Enable()
    End Sub
    Private Sub Reset()
        IsNewRecord = False
        Disable()
        RowIndex = -1
        Clear()
        CboYearGroup.SelectedIndex = 0
        CboAcademicSession.SelectedIndex = 0
        CboTerm.SelectedIndex = 0
    End Sub
    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Reset()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsNewRecord = True Then

            If TxtSchoolFees.Text = "" Then
                MessageBox.Show("School Fees ammount is required", Application.ProductName)
                TxtSchoolFees.Focus()
                Exit Sub
            End If

            If IsNumeric(TxtSchoolFees.Text) = False Then
                MessageBox.Show("School Fees must be numeric", Application.ProductName)
                Exit Sub
            End If
            'Check if another record has not already been entered
            Dim TblCheckSchoolFees As New dbO.Table
            Dim SqlQuery As String
            TblCheckSchoolFees.Clear()

            SqlQuery = $"SELECT * FROM school_fees WHERE is_deleted=0 AND session_id={CboAcademicSession.SelectedValue } AND academic_term = '{CboTerm.SelectedValue }' AND year_group_id={CboYearGroup.SelectedValue }"

            TblCheckSchoolFees = connection.FetchLight(SqlQuery)

            If TblCheckSchoolFees.RowCount <> 0 Then
                MessageBox.Show("School Fees Settings Record already exists", Application.ProductName)
                Exit Sub
            End If

            TblSchoolFeesSettings.Addnew()
            TblSchoolFeesSettings.Fields("SESSION_ID") = CboAcademicSession.SelectedValue
            TblSchoolFeesSettings.Fields("academic_term") = CboTerm.SelectedValue
            TblSchoolFeesSettings.Fields("year_group_id") = CboYearGroup.SelectedValue
            TblSchoolFeesSettings.Fields("ammount") = TxtSchoolFees.Text
            TblSchoolFeesSettings.Fields("is_deleted") = 0
            TblSchoolFeesSettings.Update()
            MessageBox.Show("New school fees settings record was added successfully", Application.ProductName)
            LoadGridData()
            Reset()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If RowIndex = -1 Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If

        If MessageBox.Show("Do you wish to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            TblSchoolFeesSettings.Fields("is_deleted") = 1
            TblSchoolFeesSettings.Update()


            MessageBox.Show("School Fees settings record was deleted successfully", Application.ProductName)
            LoadGridData()
            Exit Sub
        End If
    End Sub
    Private Sub ToForm(index As Integer)
        TblSchoolFeesSettings.Move(index)

        CboAcademicSession.SelectedValue = TblSchoolFeesSettings.Fields("session_id")
        CboTerm.SelectedValue = TblSchoolFeesSettings.Fields("academic_term")
        CboYearGroup.SelectedValue = TblSchoolFeesSettings.Fields("year_group_id")
        TxtSchoolFees.Text = TblSchoolFeesSettings.Fields("ammount")
    End Sub
    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        RowIndex = e.RowIndex

        ToForm(RowIndex)
    End Sub
End Class