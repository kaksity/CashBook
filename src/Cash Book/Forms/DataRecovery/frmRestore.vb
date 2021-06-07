Imports FirebirdSql.Data.Services
Imports FirebirdSql.Data.FirebirdClient

Public Class frmRestore
    Dim strSourcePath As String
    Dim strDestinationPath As String
    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Dim openDialog As New OpenFileDialog

        openDialog.Title = "Cash Book - Restore"

        openDialog.Filter = "CashBook File|*.fbk"

        If openDialog.ShowDialog() = DialogResult.OK Then
            strSourcePath = openDialog.FileName
            lblPath.Text = strSourcePath
        End If
    End Sub

    Private Sub btnStartProcess_Click(sender As Object, e As EventArgs) Handles btnStartProcess.Click
        Dim dialog As DialogResult

        If strSourcePath = "" Then
            MessageBox.Show("You must select a location", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Restore will overwrite all existing data. Do you wish to continue restore?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes

                Dim restore As New FbRestore
                Dim file As FbBackupFile
                btnStartProcess.Text = "Please Wait"
                btnStartProcess.Enabled = False
                'Stop the existing connection to the database
                connection.Close()
                FbConnection.ClearAllPools()
                restore.ConnectionString = "server=localhost;user=SYSDBA;password=masterkey;database=" + Application.StartupPath + "/CASH BOOK.FDB"

                file = New FbBackupFile(strSourcePath)
                restore.BackupFiles.Add(file)
                restore.Options = FbRestoreFlags.Replace
                restore.Verbose = True

                Try
                    'connection.Close()
                    connection.dbConnection.Close()
                    restore.Execute()

                    lblStatus.Text = "Restore Completed"
                    btnStartProcess.Text = "Start Process"
                    btnStartProcess.Enabled = True
                    MessageBox.Show("Your data was restored successfully. Please restart the program again", Application.ProductName)
                    lblPath.Text = ""
                    lblStatus.Text = ""
                    Application.Restart()
                Catch ex As System.ComponentModel.Win32Exception
                    MessageBox.Show("Restart CashBook Again", Application.ProductName)
                End Try

            Case DialogResult.No
                lblPath.Text = ""
                strSourcePath = ""
        End Select

    End Sub

    Private Sub frmRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPath.Text = ""
        strDestinationPath = ""
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub restoreWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
    End Sub
End Class