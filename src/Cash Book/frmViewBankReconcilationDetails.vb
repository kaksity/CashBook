Imports fyiReporting

Public Class frmViewBankReconcilationDetails
    Dim RdlViewer As New RdlViewer.RdlViewer
    Dim tblAccounts As New dbO.Table
    Private Sub frmViewBankReconcilationDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim saveDialog As New SaveFileDialog

        saveDialog.Filter = "PDF|*.pdf"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            rdlViews.SaveAs(saveDialog.FileName, "PDF")
            MessageBox.Show("PDF report was generated Successfully", Application.ProductName)
        End If

    End Sub

End Class