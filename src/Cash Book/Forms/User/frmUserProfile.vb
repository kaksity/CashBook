Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Imports dbO
Public Class frmUserProfile
    Dim tblUser As New dbO.Table
    Dim editRecord As Boolean = False
    Private Sub frmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passport = False
        document = False
        disable()
        loadUserData()
    End Sub

    Private Sub disable()
        txtFullName.Enabled = False
        txtEmailAddress.Enabled = False
        txtPassword.Enabled = False
        txtSecurityAnswer.Enabled = False
        txtSecurityQuestion.Enabled = False
        txtTelephoneNumber.Enabled = False
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnAddPhoto.Enabled = False
    End Sub
    Private Sub enable()
        txtFullName.Enabled = True
        txtEmailAddress.Enabled = True
        txtPassword.Enabled = True
        txtSecurityAnswer.Enabled = True
        txtSecurityQuestion.Enabled = True
        txtTelephoneNumber.Enabled = True
        btnEdit.Enabled = False
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAddPhoto.Enabled = True
    End Sub

    Private Sub loadUserData()

        Dim sqlQuery As String

        tblUser.Rows.Clear()
        sqlQuery = "SELECT * FROM USERS WHERE USER_CODE = '" + userID + "'"
        tblUser = connection.Fetch(sqlQuery)

        If tblUser.Rows.Count = 0 Then Exit Sub

        lblUsername.Text = tblUser.Fields("username")
        txtFullName.Text = tblUser.Fields("full_name")
        txtEmailAddress.Text = tblUser.Fields("email_address")
        txtTelephoneNumber.Text = tblUser.Fields("telephone_number")
        txtSecurityQuestion.Text = tblUser.Fields("security_question")
        txtSecurityAnswer.Text = tblUser.Fields("security_answer")
        If IsDBNull(tblUser.Fields("picture")) = True Then
            picPhoto.Image = Nothing
        Else
            picPhoto.Image = tblUser.Fields("picture")
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enable()
        editRecord = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        disable()
        editRecord = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        Dim picture As New MemoryStream

        If IsNothing(picPhoto.Image) = False Then picPhoto.Image.Save(picture, picPhoto.Image.RawFormat)

        If editRecord = False Then
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to update this User Profile", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes
                tblUser.Move(0)
                tblUser.Fields("full_name") = txtFullName.Text.ToUpper
                tblUser.Fields("email_address") = txtEmailAddress.Text.ToLower
                tblUser.Fields("telephone_number") = txtTelephoneNumber.Text.ToUpper
                tblUser.Fields("security_question") = txtSecurityQuestion.Text.ToUpper
                tblUser.Fields("security_answer") = txtSecurityAnswer.Text.ToUpper
                tblUser.Fields("picture") = picPhoto.Image
                If txtPassword.Text <> "" Then
                    If txtPassword.Text.Length < 8 Then
                        MessageBox.Show("Password Length must be 8 or more character", Application.ProductName)
                        Exit Sub
                    End If
                    tblUser.Fields("password") = txtPassword.Text
                End If
                txtPassword.Text = ""
                tblUser.Update()
                MessageBox.Show("User Profile was updated successfully", Application.ProductName)
                loadUserData()
                disable()
            Case dialog.No
                disable()
                Exit Sub
        End Select
    End Sub

    Private Sub btnAddPhoto_Click(sender As Object, e As EventArgs) Handles btnAddPhoto.Click
        passport = True
        document = False
        picPhoto.Image = frmAcquire.Acquire
        passport = False
        document = False
    End Sub

End Class