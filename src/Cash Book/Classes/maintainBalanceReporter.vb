Public Class maintainBalanceReporter

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



    Private Function prepareTable(table As dbO.Table) As dbO.Table
        Dim duration As String
        Dim month As Integer
        Dim year As Integer

        '        table.Columns("status").DataType = GetType(String)

        For i = 0 To table.Rows.Count - 1
            table.Move(i)

            duration = table.Fields("duration")
            If duration.Length = 6 Then
                month = CInt(duration.Substring(0, 1))
                year = CInt(duration.Substring(2, 4))
            ElseIf duration.Length = 7 Then
                month = CInt(duration.Substring(0, 2))
                year = CInt(duration.Substring(3, 4))
            End If

            table.Fields("duration") = getMonthInWord(month) + " " + CStr(year)
        Next
        Return table
    End Function

    Public Sub render()
        Dim viewer As New frmMaintainBalanceReport
        Dim sqlQuery As String
        Dim tblMaintainBalance As New dbO.Table
        sqlQuery = "SELECT accounts.name,maintain_balance. OPENING_BALANCE, maintain_balance.CLOSING_BALANCE,maintain_balance. DURATION, maintain_balance.STATUS FROM MAINTAIN_BALANCE INNER JOIN accounts ON accounts.number=maintain_balance.account_number"

        tblMaintainBalance.Clear()
        tblMaintainBalance = connection.FetchLight(sqlQuery)

        With viewer.RDLViewer
            .SourceFile = "C:\projects\Visual Basic\Cash Book\rdl\maintain_balance.rdl"
            .Report.DataSets("Data").SetData(prepareTable(tblMaintainBalance))
            .Rebuild()
        End With

        viewer.ShowDialog()
    End Sub
End Class
