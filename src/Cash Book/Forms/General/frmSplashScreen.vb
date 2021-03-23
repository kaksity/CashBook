Public Class frmSplashScreen
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashTimer.Start()
    End Sub

    Private Function isThereUser() As Boolean
        Dim tblUser As New dbO.Table
        Dim sqlQuery As String

        sqlQuery = "SELECT * FROM users"
        tblUser.Clear()
        tblUser = connection.Fetch(sqlQuery)

        If tblUser.Rows.Count = 0 Then Return False Else Return True

    End Function
    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick

        Me.Opacity = Me.Opacity - 0.05

        If Me.Opacity = 0 Then
            splashTimer.Stop()
            Me.Hide()
            'frmLogin.Show()
            If isThereUser() = True Then
                frmLogin.Show()
            ElseIf isThereUser() = False
                frmRegisterUser.Show()
            End If
        End If
    End Sub
End Class