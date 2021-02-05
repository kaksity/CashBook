Imports FirebirdSql.Data.Services
Public Class frmBackUp
    Dim strSourcePath As String
    Dim strDestinationPath As String
    Dim strConnection As String

    Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Dim saveDialog As New SaveFileDialog

        saveDialog.Title = "Cash Book - Back Up"
        saveDialog.Filter = "CashBook File|*.fbk"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            strDestinationPath = saveDialog.FileName
            lblPath.Text = saveDialog.FileName
        End If
    End Sub

    Private Sub btnStartProcess_Click(sender As Object, e As EventArgs) Handles btnStartProcess.Click
        Dim dialog As DialogResult
        If strDestinationPath = "" Then
            MessageBox.Show("You must select a destination", Application.ProductName)
            Exit Sub
        End If

        dialog = MessageBox.Show("Do you wish to start back up?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case dialog
            Case dialog.Yes



                Dim backup As New FbBackup

                backup.ConnectionString = "server=localhost;user=SYSDBA;password=masterkey;database=" + Application.StartupPath + "/CASH BOOK.FDB"

                Dim file As New FbBackupFile(strDestinationPath)
                btnStartProcess.Text = "Please Wait"
                btnStartProcess.Enabled = False
                Try

                    backup.BackupFiles.Add(file)

                    backup.Verbose = True

                    backup.Execute()
                    lblStatus.Text = "Backup Completed"
                    MessageBox.Show("Back Up was done Successfully", Application.ProductName)

                    strDestinationPath = ""
                    lblPath.Text = ""
                    lblStatus.Text = ""

                    btnStartProcess.Text = "Start Process"
                    btnStartProcess.Enabled = True

                Catch ex As Exception
                    MessageBox.Show("Failed to perform BackUp", Application.ProductName)
                    btnStartProcess.Text = "Start Process"
                    btnStartProcess.Enabled = True
                End Try
            Case DialogResult.No
                lblPath.Text = ""
                strDestinationPath = ""
        End Select
    End Sub

    Private Sub frmBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strDestinationPath = ""
        lblPath.Text = ""
        lblStatus.Text = ""
    End Sub
End Class