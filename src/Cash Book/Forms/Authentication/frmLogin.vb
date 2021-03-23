Public Class frmLogin
    Dim logger As New logger
    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        frmForgotPassword.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim tblUser As New dbO.Table
        Dim sqlQuery As String
        'Check if the username is supplied
        If txtUsername.Text = "" Then

            MessageBox.Show("Username is required", Application.ProductName)
            txtUsername.Focus()
            Exit Sub

        End If

        'Check if the password is supplied 
        If txtPassword.Text = "" Then
            MessageBox.Show("Password is required", Application.ProductName)
            txtPassword.Focus()
            Exit Sub
        End If

        'Check the database if the username and the password exist in the database
        tblUser.Clear()
        sqlQuery = "SELECT * FROM users WHERE username = '" + txtUsername.Text.ToUpper.Trim + "' AND password = '" + txtPassword.Text.Trim + "'"
        tblUser = connection.Fetch(sqlQuery)

        If tblUser.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username or Password Combination", Application.ProductName)
            Exit Sub
        End If
        userID = tblUser.Rows(0).Item("user_code")
        logger.login(userID)
        MessageBox.Show("Welcome User " + tblUser.Rows(0).Item("username"), Application.ProductName)
        Me.Hide()
        frmMainMenu.Show()

    End Sub


    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
