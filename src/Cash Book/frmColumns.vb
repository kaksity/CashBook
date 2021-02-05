Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Public Class frmColumns

    Dim tblGridColumnName As New dbO.Table
    Dim tblNamesOfColumns As New dbO.Table

    Private Sub initGrid()
        Dim tblGrid As New dbO.Table
        Dim sqlQuery As String

        tblGridColumnName.Columns.Clear()
        tblNamesOfColumns.Columns.Clear()

        tblGridColumnName.Rows.Clear()
        tblNamesOfColumns.Rows.Clear()


        sqlQuery = "SELECT * FROM transaction_description WHERE type_of_transaction = 'EXPENSE'"

        tblGrid.Clear()
        tblGrid = connection.Fetch(sqlQuery)

        grid.Columns.Clear()
        grid.Rows.Clear()

        With grid
            .Columns.Add("date_of_transaction", "DATE OF TRANSACTION")
            .Columns.Add("transaction_total", "TRANSACTION TOTAL")

            .Columns("date_of_transaction").Width = 150
            .Columns("transaction_total").Width = 150
        End With


        For i = 0 To tblGrid.Rows.Count - 1
            With grid
                tblGrid.Move(i)
                .Columns.Add(CStr(tblGrid.Fields("ukey")), tblGrid.Fields("description_name"))
                .Columns(CStr(tblGrid.Fields("ukey"))).Width = 150
            End With
        Next



        tblGridColumnName.Columns.Add("date_of_transaction", GetType(String))
        tblGridColumnName.Columns.Add("transaction_total", GetType(String))

        tblNamesOfColumns.Clear()
        tblNamesOfColumns.Columns.Add("name", GetType(String))

        tblNamesOfColumns.Rows.Add("date_of_transaction")
        tblNamesOfColumns.Rows.Add("transaction_total")

        For i = 0 To tblGrid.Rows.Count - 1
            With grid
                tblGrid.Move(i)
                tblNamesOfColumns.Addnew()
                tblGridColumnName.Columns.Add(CStr(tblGrid.Fields("ukey")), GetType(String))
                tblNamesOfColumns.Fields("name") = CStr(tblGrid.Fields("ukey"))
                tblNamesOfColumns.Save()
            End With
        Next

    End Sub

    Private Sub loadGrid()
        Dim tblTransaction As New dbO.Table
        Dim sqlQuery As String
        Dim tblSingleTransactions As New dbO.Table
        Dim tblCalculatedTransaction As New dbO.Table
        Dim transactionDescription As String
        Dim total As String = "0"

        'Select all the transaction one after the other on a daily basis
        tblTransaction.Clear()
        sqlQuery = "SELECT DISTINCT(date_of_transaction) FROM TRANSACTIONS WHERE account_number = '" + accountColumn + "' AND ammount_deposited = '0' AND extract(YEAR FROM date_of_transaction) = '" + CStr(yearColumn) + "' AND extract(MONTH FROM date_of_transaction) = '" + CStr(monthColumn) + "' ORDER BY date_of_transaction ASC"

        tblTransaction = connection.FetchLight(sqlQuery)

        For i = 0 To tblTransaction.Rows.Count - 1
            tblTransaction.Move(i)
            tblSingleTransactions.Clear()

            sqlQuery = "SELECT * FROM transactions WHERE ammount_deposited='0' AND date_of_transaction = '" + tblTransaction.Fields("date_of_transaction") + "'"
            tblSingleTransactions = connection.Fetch(sqlQuery)

            tblGridColumnName.Addnew()

            For j = 0 To tblSingleTransactions.Rows.Count - 1
                tblSingleTransactions.Move(j)



                tblGridColumnName.Fields("date_of_transaction") = tblTransaction.Fields("date_of_transaction")

                transactionDescription = CStr(tblSingleTransactions.Fields("description_of_transaction"))
                If IsDBNull(tblGridColumnName.Fields(transactionDescription)) Then
                    tblGridColumnName.Fields(transactionDescription) = tblSingleTransactions.Fields("ammount_withdrawn")
                Else
                    tblGridColumnName.Fields(transactionDescription) = CStr(Val(tblGridColumnName.Fields(transactionDescription)) + Val(tblSingleTransactions.Fields("ammount_withdrawn")))
                End If

                total = CStr(Val(total) + Val(tblSingleTransactions.Fields("ammount_withdrawn")))
                tblGridColumnName.Fields("transaction_total") = total
            Next
            tblGridColumnName.Save()
        Next

        grid.Rows.Clear()
        Dim value As String = ""
        If tblGridColumnName.Rows.Count = 0 Then Exit Sub
        grid.Rows.Add(tblGridColumnName.Rows.Count)

        For i = 0 To tblGridColumnName.Rows.Count - 1
            tblGridColumnName.Move(i)
            For j = 0 To tblNamesOfColumns.Rows.Count - 1
                tblNamesOfColumns.Move(j)
                With grid

                    If IsNumeric(tblGridColumnName.Fields(tblNamesOfColumns.Fields("name"))) = True Then
                        .Rows(i).Cells(tblNamesOfColumns.Fields("name")).Value = FormatNumber(tblGridColumnName.Fields(tblNamesOfColumns.Fields("name")))
                    ElseIf IsNumeric(tblGridColumnName.Fields(tblNamesOfColumns.Fields("name"))) = False And IsDBNull(tblGridColumnName.Fields(tblNamesOfColumns.Fields("name"))) = False Then
                        .Rows(i).Cells(tblNamesOfColumns.Fields("name")).Value = Format(CDate(tblGridColumnName.Fields(tblNamesOfColumns.Fields("name"))), "dd/MM/yyyy")
                    End If

                End With
            Next
        Next
    End Sub

    Private Sub frmColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pgProgress.Value = 0
        initGrid()
        loadGrid()
        btnExport.Enabled = True
    End Sub

    Private Function getMonthInWord(month As Integer)
        Dim result As String
        Dim months(12) As String

        months(0) = "January"
        months(1) = "February"
        months(2) = "March"
        months(3) = "April"
        months(4) = "May"
        months(5) = "June"
        months(6) = "July"
        months(7) = "August"
        months(8) = "September"
        months(9) = "October"
        months(10) = "November"
        months(11) = "December"

        result = months(month - 1)
        Return result
    End Function

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Try

        Dim sqlQuery As String
            Dim tblAccount As New dbO.Table
            Dim tblOrganization As New dbO.Table



            Dim saveDialog As New SaveFileDialog

            btnExport.Text = "Please Wait..."
            btnExport.Enabled = False

            saveDialog.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                'Merge the cells inorder to be used to show the Header

                xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, grid.Columns.Count)).Merge()
                xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, grid.Columns.Count)).Merge()
                xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, grid.Columns.Count)).Merge()

                'Perform the Sql query here
                sqlQuery = "SELECT name,bank_name FROM accounts WHERE number = '" + accountColumn + "'"
                tblAccount.Clear()
                tblAccount = connection.FetchLight(sqlQuery)

                sqlQuery = "SELECT name FROM organization"
                tblOrganization.Clear()
                tblOrganization = connection.FetchLight(sqlQuery)

                tblAccount.Move(0)
                tblOrganization.Move(0)



                'INSERT the Needed Values
                xlWorkSheet.Cells(1, 1) = tblOrganization.Fields("name")
                xlWorkSheet.Cells(2, 1) = "32 COLUMN CASHBOOK AS AT " + CStr(getMonthInWord(monthColumn)) + " " + CStr(yearColumn)
                xlWorkSheet.Cells(3, 1) = tblAccount.Fields("name") + "[" + tblAccount.Fields("bank_name") + "]"

                xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter
                xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, grid.Columns.Count)).HorizontalAlignment = Excel.Constants.xlCenter



                For i = 0 To grid.Rows.Count - 1
                    For j = 0 To grid.ColumnCount - 1
                        For k As Integer = 1 To grid.Columns.Count
                            xlWorkSheet.Columns.ColumnWidth = 25
                            xlWorkSheet.Cells(4, k) = grid.Columns(k - 1).HeaderText

                        If IsNumeric(grid(j, i).Value) = True Then
                            xlWorkSheet.Cells(i + 5, j + 1) = FormatNumber(grid(j, i).Value)
                        ElseIf IsNumeric(grid(j, i).Value) = False And grid(j, i).Value <> ""
                            xlWorkSheet.Cells(i + 5, j + 1) = grid(j, i).Value.ToString()
                            End If

                        Next
                    Next
                    pgProgress.Value = CSng((i / (grid.RowCount - 1)) * 100)
                Next

                xlWorkSheet.SaveAs(saveDialog.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & saveDialog.FileName, MsgBoxStyle.Information, "Information")

                btnExport.Text = "Export To MS Excel"
                btnExport.Enabled = True
            Else
                btnExport.Text = "Export To MS Excel"
                btnExport.Enabled = True
            End If
        'Catch ex As Exception
        '    btnExport.Text = "Export To MS Excel"
        '    btnExport.Enabled = True
        '    MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex < 0 Then Exit Sub
    End Sub
End Class