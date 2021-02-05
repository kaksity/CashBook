Public Class frmOrganization
    Dim tblOrganization As New dbO.Table
    Dim editRecord As Boolean = False

    Private Sub toForm()
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM organization"
        tblOrganization.Clear()
        tblOrganization = connection.Fetch(sqlQuery)

        If tblOrganization.Rows.Count = 0 Then Exit Sub

        txtName.Text = tblOrganization.Rows(0).Item("name")
        txtDescription.Text = tblOrganization.Rows(0).Item("description")
        txtTINNumber.Text = tblOrganization.Rows(0).Item("tin_number")
        txtContactPerson.Text = tblOrganization.Rows(0).Item("contact_person")
        txtContactNumber.Text = tblOrganization.Rows(0).Item("contact_number")

    End Sub
    Private Sub enable()
        txtName.Enabled = True
        txtDescription.Enabled = True
        txtTINNumber.Enabled = True
        txtContactNumber.Enabled = True
        txtContactPerson.Enabled = True

        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub disable()
        txtName.Enabled = False
        txtDescription.Enabled = False
        txtTINNumber.Enabled = False
        txtContactNumber.Enabled = False
        txtContactPerson.Enabled = False

        btnUndo.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()

        toForm()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enable()
        editRecord = True
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        disable()
        toForm()
        editRecord = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialogResult As DialogResult
        If editRecord = True Then
            If txtName.Text = "" Then
                MessageBox.Show("Name of Organization is required", Application.ProductName)
                txtName.Focus()
                Exit Sub
            End If
            dialogResult = MessageBox.Show("Do you wish to update organization record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case dialogResult
                Case DialogResult.Yes
                    tblOrganization.Move(0)

                    tblOrganization.Fields("name") = txtName.Text.ToUpper.Trim
                    tblOrganization.Fields("description") = txtDescription.Text.ToUpper.Trim
                    tblOrganization.Fields("tin_number") = txtTINNumber.Text.ToUpper.Trim
                    tblOrganization.Fields("contact_person") = txtContactPerson.Text.ToUpper.Trim
                    tblOrganization.Fields("contact_number") = txtContactNumber.Text.ToUpper.Trim

                    tblOrganization.Update()
                    MessageBox.Show("Organization Record was updated successfully", Application.ProductName)
                    toForm()
                    disable()
                    editRecord = False
                    Exit Sub
                Case DialogResult.No
                    toForm()
                    disable()
                    editRecord = False
                    Exit Sub
            End Select
        Else
            Exit Sub
        End If
    End Sub
End Class