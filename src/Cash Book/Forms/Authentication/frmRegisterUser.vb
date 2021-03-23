Imports FirebirdSql.Data.FirebirdClient
Imports dbO
Public Class frmRegisterUser
    Private Sub frmRegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegisterUser.Click
        Dim sqlQuery As String
        Dim userCode As Integer
        Dim random As New Random
        Dim time As New DateTime

        'Check if the fields are empty
        If EmptyFields() = False Then
            Exit Sub
        End If
        If txtPassword.Text.Length < 8 Then
            MessageBox.Show("Password Length must be 8 or more characters")
            Exit Sub
        End If
        If txtConfirmPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Password Must Match Confirm Password")
            Exit Sub
        End If

        userCode = random.Next()
        sqlQuery = "INSERT INTO USERS (USERNAME, PASSWORD, FULL_NAME, TELEPHONE_NUMBER, EMAIL_ADDRESS, SECURITY_QUESTION, SECURITY_ANSWER, USER_CODE, UKEY) VALUES ('" + txtUsername.Text.ToUpper + "', '" + txtPassword.Text + "','" + txtFullName.Text.ToUpper + "','" + txtTelephoneNumber.Text + "','" + txtEmailAddress.Text.ToLower + "', '" + txtSecurityQuestion.Text.ToUpper + "','" + txtSecurityAnswer.Text.ToUpper + "','" + CStr(userCode) + "',null)"

        connection.Execute(sqlQuery)
        userID = CStr(userCode)
        MessageBox.Show("Thank you for using CashBook. User account was created successfully", Application.ProductName)
        Me.Hide()
        frmMainMenu.ShowDialog()
    End Sub
    Private Function EmptyFields()
        If txtUsername.Text = "" Then
            MessageBox.Show("Username is required", Application.ProductName)
            txtUsername.Focus()

            Return False
        End If
        If txtFullName.Text = "" Then
            MessageBox.Show("Full Name is required", Application.ProductName)
            txtFullName.Focus()
            Return False
        End If
        If txtSecurityQuestion.Text = "" Then
            MessageBox.Show("Security Question is required", Application.ProductName)
            txtSecurityQuestion.Focus()
            Return False
        End If
        If txtSecurityAnswer.Text = "" Then
            MessageBox.Show("Security Answer is required", Application.ProductName)
            txtSecurityAnswer.Focus()
            Return False
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Password is required", Application.ProductName)
            txtPassword.Focus()
            Return False
        End If
        If txtConfirmPassword.Text = "" Then
            MessageBox.Show("Confirm Password is required", Application.ProductName)
            txtConfirmPassword.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub frmRegisterUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class