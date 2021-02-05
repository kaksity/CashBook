Public Class frmRegisterOrganization
    Dim tblOrganization As New dbO.Table

    Private Sub initOrganization()
        Dim sqlQuery As String
        tblOrganization.Clear()
        sqlQuery = "SELECT * FROM organization WHERE ukey = -1"
        tblOrganization = connection.Fetch(sqlQuery)
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtName.Text = "" Then
            MessageBox.Show("Name of organization is required", Application.ProductName)
            txtName.Focus()
            Exit Sub
        End If

        tblOrganization.Addnew()
        tblOrganization.Fields("name") = txtName.Text.ToUpper.Trim
        tblOrganization.Fields("description") = txtDescription.Text.ToUpper.Trim
        tblOrganization.Fields("tin_number") = txtTINNumber.Text.Trim
        tblOrganization.Fields("contact_number") = txtContactNumber.Text.Trim
        tblOrganization.Fields("contact_person") = txtContactPerson.Text.ToUpper.Trim
        tblOrganization.Update()
        MessageBox.Show("Organization record was created successfully", Application.ProductName)
        Me.Close()
        Exit Sub
    End Sub

    Private Sub frmRegisterOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initOrganization()
    End Sub
End Class