Imports FirebirdSql.Data.FirebirdClient
Imports dbO
Module main
    Public connection As New dbO.Connection
    'The following parameters are to be public to all the class
    Public userID As String = ""
    Public selectedExpenseTransaction As String = ""
    Public accountColumn As String = ""
    Public monthColumn As String = ""
    Public yearColumn As String = ""
    Public passport As Boolean = False
    Public document As Boolean = False

    Public PubAccountRowIndex As Int32 = -1


    Public Sub main()
        Dim startForm As New frmSplashScreen

        'Try to Establish a database connection

        'Try

        connection.ConnectionString = $"server=localhost;user=SYSDBA;password=masterkey;database={CStr(Application.StartupPath) }/CASH BOOK.FDB"
        connection.Open()


            'Parameters

            Application.EnableVisualStyles()

            Application.Run(startForm)
            'Catch ex As Exception
            '   Throw ex
            MessageBox.Show("Please Contact your Database administrator", Application.ProductName)
        'End Try
    End Sub
End Module
