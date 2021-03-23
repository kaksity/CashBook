Public Class frmViewTransactionReport
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim saveDialog As New SaveFileDialog
        saveDialog.Filter = "PDF|*.pdf"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            RDLViewer.SaveAs(saveDialog.FileName, "pdf")
            MessageBox.Show("PDF Report was generated successfully", Application.ProductName)
        End If

    End Sub

    Private Sub frmViewTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class