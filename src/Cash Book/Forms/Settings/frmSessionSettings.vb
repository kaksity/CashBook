Public Class frmSessionSettings
    Dim IsNewRecord As Boolean = False
    Dim IsEditRecord As Boolean = False
    Dim RowIndex As Integer = -1
    Dim TblSessions As New dbO.Table
    Private Sub InitGrid()
        With Grid

            'Clear all the Rows And then all the columns
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("ColsSNum", "S/No")
            .Columns.Add("ColsSession", "Session")


            .Columns("ColsSNum").Width = 70
            .Columns("ColsSession").Width = 450

            .Columns("ColsSNum").ReadOnly = True
            .Columns("ColsSession").ReadOnly = True

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False


        End With
    End Sub
    Private Sub frmSessionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitGrid()
        LoadGridData()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        IsNewRecord = True
        IsEditRecord = False

        Grid.Rows.Add(1)

        Grid.Columns("ColsSession").ReadOnly = False
        '   Grid.Rows(Grid.RowCount).Cells("ColsSNum").Value = Grid.RowCount + 1
        Enable()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        IsEditRecord = True
        IsNewRecord = False
    End Sub

    Private Sub Reset()
        IsNewRecord = False
        IsEditRecord = False

        Grid.Rows.RemoveAt(Grid.Rows.Count - 1)
        Grid.Columns("ColsSession").ReadOnly = True
        Disable()
    End Sub

    Private Sub Disable()
        BtnNew.Enabled = True
        BtnEdit.Enabled = True

        BtnSave.Enabled = False
        BtnUndo.Enabled = False

        BtnRemove.Enabled = True

    End Sub

    Private Sub LoadGridData()

        TblSessions.Clear()
        TblSessions = connection.Fetch("SELECT * FROM sessions WHERE is_deleted=0")

        For i = 0 To TblSessions.RowCount - 1
            TblSessions.Move(i)
            With Grid
                .Rows(i).Cells("ColsSNum").Value = i + 1
                .Rows(i).Cells("ColsSession").Value = TblSessions.Fields("session")
            End With
        Next
    End Sub
    Private Sub Enable()
        BtnNew.Enabled = False
        BtnEdit.Enabled = False

        BtnSave.Enabled = True
        BtnUndo.Enabled = True

        BtnRemove.Enabled = False
    End Sub
    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Reset()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsNewRecord = True And IsEditRecord = False Then
            'Check if session has been typed
            If Grid.Rows(Grid.RowCount).Cells("ColsSession").Value = "" Then
                MessageBox.Show("Academic Session is required")
                Exit Sub
            End If

            'Check if a Session already exist
            Dim TblCheckAcademicSession As New dbO.Table

            TblCheckAcademicSession.Clear()

            TblCheckAcademicSession = connection.Fetch($"SELECT * FROM sessions WHERE session= '{Grid.Rows(Grid.RowCount).Cells("ColsSession").Value}' AND is_deleted=0")

            If TblCheckAcademicSession.RowCount <> 0 Then
                MessageBox.Show("Academic Session Already Exists")
                Exit Sub
            End If

            TblSessions.Addnew()
            TblSessions.Fields("session") = Grid.Rows(Grid.RowCount).Cells("ColsSession").Value
            TblSessions.Update()

            LoadGridData()
            Reset()
        End If
    End Sub
End Class