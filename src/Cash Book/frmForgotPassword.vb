Public Class frmForgotPassword
    Dim tblUser As New dbO.Table
    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheckUsername_Click(sender As Object, e As EventArgs) Handles btnCheckUsername.Click
        Dim sqlQuery As String
        If txtUsername.Text = "" Then
            MessageBox.Show("Username is required", Application.ProductName)
            txtUsername.Focus()
            Exit Sub
        End If

        tblUser.Clear()
        sqlQuery = "SELECT * FROM USERS WHERE USERNAME = '" + txtUsername.Text.ToUpper.Trim + "'"
        tblUser = connection.Fetch(sqlQuery)

        If tblUser.Rows.Count = 0 Then
            MessageBox.Show("This username is not registered")
            txtUsername.Focus()
            Exit Sub
        End If

        txtSecurityQuestion.Text = tblUser.Rows(0).Item("security_question")
    End Sub

    Private Sub btnGeneratePassword_Click(sender As Object, e As EventArgs) Handles btnGeneratePassword.Click
        Dim randomString As String
        Dim rand As New Random
        Dim newPassword As String = ""
        Dim i As Integer = 0
        Dim count As Integer = 0
        randomString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        If txtUsername.Text = "" Then
            MessageBox.Show("Username is required", Application.ProductName)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtSecurityQuestion.Text = "" Then
            MessageBox.Show("Click on Check Username", Application.ProductName)
            txtSecurityQuestion.Focus()
            Exit Sub
        End If

        If txtSecurityAnswer.Text = "" Then
            MessageBox.Show("Security Answer is required", Application.ProductName)
            txtSecurityAnswer.Focus()
            Exit Sub
        End If

        If txtSecurityAnswer.Text.ToUpper.Trim <> tblUser.Rows(0).Item("security_answer") Then
            MessageBox.Show("Security Answer given is not correct", Application.ProductName)
            txtSecurityAnswer.Focus()
            Exit Sub
        End If


        While count < 8
            i = rand.Next(0, randomString.Length)
            newPassword += randomString.Substring(i, 1)
            count += 1
        End While

        tblUser.Move(0)
        tblUser.Fields("password") = CStr(newPassword.Trim)
        tblUser.Update()

        MessageBox.Show("Newly Generated password is " + newPassword, Application.ProductName)
        txtUsername.Text = ""
        txtSecurityAnswer.Text = ""
        txtSecurityQuestion.Text = ""
        Exit Sub
    End Sub
End Class