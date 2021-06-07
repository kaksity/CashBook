Public Class frmSchoolFees

    Dim SchoolFeesAmount As String
    Dim RowIndex As Integer = -1
    Dim StudentId As Integer
    Dim SchoolFeesId As Integer
    Dim Logger As New logger

    Private Sub frmSchoolFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSessionCombox()
        FillAcademicTerm()
        FillYearGroupComboBox()
        InitGrid()
    End Sub

    Private Sub LoadGridData(AcademicSession As String, AcademicTerm As String, YearGroup As Integer, AcademicClass As Integer)

        Dim SqlQuery As String
        Dim TblStudents As New dbO.Table
        Dim TblFindSchoolFees As New dbO.Table
        Dim TblSchoolFeesPayment As New dbO.Table

        SqlQuery = $"SELECT * FROM school_fees WHERE session_id={CboAcademicSession.SelectedValue } AND academic_term='{CboTerm.SelectedValue }' AND year_group_id={CboYearGroup.SelectedValue } AND is_deleted=0"

        TblFindSchoolFees.Clear()
        TblFindSchoolFees = connection.FetchLight(SqlQuery)

        If TblFindSchoolFees.RowCount = 0 Then
            MessageBox.Show("School Fees has not been set for the session, term & year group", Application.ProductName)
            Exit Sub
        End If

        TblFindSchoolFees.Move(0)

        SchoolFeesId = TblFindSchoolFees.Fields("id")
        SchoolFeesAmount = TblFindSchoolFees.Fields("ammount")


        SqlQuery = $"SELECT id AS student_id, admission_number,full_name FROM students WHERE academic_session = '{AcademicSession }' AND year_group_id = {YearGroup } AND class_id = '{AcademicClass }' AND is_deleted=0"
        TblStudents.Clear()

        TblStudents = connection.FetchLight(SqlQuery)

        Grid.Rows.Clear()

        If TblStudents.RowCount = 0 Then Exit Sub

        Grid.Rows.Add(TblStudents.RowCount)

        For i = 0 To TblStudents.RowCount - 1
            TblStudents.Move(i)
            'Check if the student has already paid their school fees
            SqlQuery = $"SELECT * FROM school_fee_payments WHERE student_id = {TblStudents.Fields("student_id")} AND school_fee_id = {TblFindSchoolFees.Fields("id")} AND is_deleted=0"

            TblSchoolFeesPayment.Clear()
            TblSchoolFeesPayment = connection.FetchLight(SqlQuery)

            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsAdmissionNumber").Value = TblStudents.Fields("admission_number")
                .Rows(i).Cells("ColsFullName").Value = TblStudents.Fields("full_name")
                .Rows(i).Cells("ColsStudentID").Value = TblStudents.Fields("student_id")

                If TblSchoolFeesPayment.RowCount = 0 Then
                    .Rows(i).Cells("ColsAmmountPaid").Value = $"N{FormatNumber(0)}"
                    .Rows(i).Cells("ColsOutstandingBalance").Value = $"N{FormatNumber(0 - Val(SchoolFeesAmount))}"
                Else
                    TblSchoolFeesPayment.Move(0)
                    .Rows(i).Cells("ColsAmmountPaid").Value = $"N{FormatNumber(TblSchoolFeesPayment.Fields("ammount_paid"))}"
                    .Rows(i).Cells("ColsOutstandingBalance").Value = $"N{FormatNumber(TblSchoolFeesPayment.Fields("ammount_paid") - Val(SchoolFeesAmount))}"
                End If
            End With
        Next
    End Sub
    Private Sub FillYearGroupComboBox()
        Dim SqlQuery As String
        Dim TblYearGroups As New dbO.Table

        SqlQuery = "Select id, Name FROM year_groups WHERE is_deleted=0"

        TblYearGroups.Clear()
        TblYearGroups = connection.FetchLight(SqlQuery)

        CboYearGroup.DisplayMember = "name"
        CboYearGroup.ValueMember = "id"
        CboYearGroup.DataSource = TblYearGroups
    End Sub

    Private Sub FillClassComboBox(YearGroupId As Integer)
        Dim SqlQuery As String
        Dim TblYearGroups As New dbO.Table

        SqlQuery = $"SELECT * FROM classes WHERE year_group_id = {YearGroupId } And is_deleted=0"

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

    Private Sub InitGrid()
        With Grid

            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsAdmissionNumber", "Admission Number")
            .Columns.Add("ColsFullName", "Full Name")
            .Columns.Add("ColsAmmountPaid", "Ammount Paid")
            .Columns.Add("ColsOutstandingBalance", "Out Standing Balance")
            .Columns.Add("ColsStudentID", "Student ID")

            .Columns("ColsStudentID").Visible = False


            .Columns("ColsSNum").Width = 70
            .Columns("ColsAdmissionNumber").Width = 200
            .Columns("ColsFullName").Width = 200
            .Columns("ColsAmmountPaid").Width = 150
            .Columns("ColsOutstandingBalance").Width = 150

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsAdmissionNumber").ReadOnly = True
            .Columns("ColsFullName").ReadOnly = True
            .Columns("ColsAmmountPaid").ReadOnly = True
            .Columns("ColsOutstandingBalance").ReadOnly = True

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
        FillClassComboBox(CboYearGroup.SelectedValue)
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If e.RowIndex < 0 Then Exit Sub

        StudentId = Grid.Rows(e.RowIndex).Cells("ColsStudentID").Value
        ToForm(StudentId)
        'ToForm(RowIndex)
    End Sub
    Private Sub ToForm(StudentId As Integer)
        Dim SqlQuery As String
        Dim TblStudents As New dbO.Table


        SqlQuery = $"SELECT * FROM students WHERE id={StudentId } AND is_deleted=0"
        TblStudents.Clear()

        TblStudents = connection.FetchLight(SqlQuery)

        If TblStudents.RowCount = 0 Then Exit Sub

        TblStudents.Move(0)

        lblFullName.Text = TblStudents.Fields("full_name")
        lblAdmissionNumber.Text = TblStudents.Fields("admission_number")

    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        Dim SqlQuery As String

        If lblAdmissionNumber.Text = "" And lblFullName.Text = "" Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If

        If TxtAmmountPaid.Text = "" Then
            MessageBox.Show("Ammount Paid is required", Application.ProductName)
            TxtAmmountPaid.Focus()
            Exit Sub
        End If

        If IsNumeric(TxtAmmountPaid.Text) = False Then
            MessageBox.Show("Ammount Paid must be numeric", Application.ProductName)
            TxtAmmountPaid.Focus()
            Exit Sub
        End If


        'Check Wether we are to update a record or to add a new record
        Dim TblPaidSchoolFees As New dbO.Table

        TblPaidSchoolFees.Clear()

        SqlQuery = $"SELECT * FROM school_fee_payments WHERE student_id={StudentId } AND school_fee_id={SchoolFeesId } AND is_deleted=0"

        TblPaidSchoolFees = connection.Fetch(SqlQuery)

        If TblPaidSchoolFees.RowCount = 0 Then
            TblPaidSchoolFees.Addnew()
            TblPaidSchoolFees.Fields("student_id") = StudentId
            TblPaidSchoolFees.Fields("school_fee_id") = SchoolFeesId
            TblPaidSchoolFees.Fields("ammount_paid") = TxtAmmountPaid.Text
            TblPaidSchoolFees.Fields("is_deleted") = 0
            TblPaidSchoolFees.Update()
        Else
            TblPaidSchoolFees.Move(0)
            TblPaidSchoolFees.Fields("ammount_paid") = Val(TxtAmmountPaid.Text) + Val(TblPaidSchoolFees.Fields("ammount_paid"))
            TblPaidSchoolFees.Update()
        End If
        Logger.AddSchoolFeesPayment(userID, TxtAmmountPaid.Text, StudentId)
        MessageBox.Show("School Fees was paid successfully", Application.ProductName)
        LoadGridData(CboAcademicSession.SelectedValue, CboTerm.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
        Reset()
    End Sub

    Private Sub Reset()
        StudentId = 0
        lblAdmissionNumber.Text = ""
        lblFullName.Text = ""
        TxtAmmountPaid.Text = ""
        SchoolFeesId = 0
    End Sub


    Private Sub BtnDeduct_Click(sender As Object, e As EventArgs) Handles BtnDeduct.Click
        Dim SqlQuery As String

        If lblAdmissionNumber.Text = "" And lblFullName.Text = "" Then
            MessageBox.Show("You must select a record", Application.ProductName)
            Exit Sub
        End If

        If TxtAmmountPaid.Text = "" Then
            MessageBox.Show("Ammount Paid is required", Application.ProductName)
            TxtAmmountPaid.Focus()
            Exit Sub
        End If

        If IsNumeric(TxtAmmountPaid.Text) = False Then
            MessageBox.Show("Ammount Paid must be numeric", Application.ProductName)
            TxtAmmountPaid.Focus()
            Exit Sub
        End If


        'Check Wether we are to update a record or to add a new record
        Dim TblPaidSchoolFees As New dbO.Table

        TblPaidSchoolFees.Clear()

        SqlQuery = $"SELECT * FROM school_fee_payments WHERE student_id={StudentId } AND school_fee_id={SchoolFeesId } AND is_deleted=0"

        TblPaidSchoolFees = connection.Fetch(SqlQuery)

        If TblPaidSchoolFees.RowCount = 0 Then
            MessageBox.Show("School Fees was not paid at all for deductions", Application.ProductName)
            Exit Sub
        Else
            TblPaidSchoolFees.Move(0)
            TblPaidSchoolFees.Fields("ammount_paid") = Val(TblPaidSchoolFees.Fields("ammount_paid")) - Val(TxtAmmountPaid.Text)
            TblPaidSchoolFees.Update()
        End If
        Logger.DeductSchoolFeesPayment(userID, TxtAmmountPaid.Text, StudentId)
        MessageBox.Show("School Fees was deducted successfully", Application.ProductName)
        LoadGridData(CboAcademicSession.SelectedValue, CboTerm.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
        Reset()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Reset()
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        LoadGridData(CboAcademicSession.SelectedValue, CboTerm.SelectedValue, CboYearGroup.SelectedValue, CboClass.SelectedValue)
    End Sub
End Class