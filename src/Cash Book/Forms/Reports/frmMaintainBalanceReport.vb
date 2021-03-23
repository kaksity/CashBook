Public Class frmMaintainBalanceReport
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim saveDialog As New SaveFileDialog

        saveDialog.Filter = "PDF|*.pdf"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            RDLViewer.SaveAs(saveDialog.FileName, "pdf")
            MessageBox.Show("PDF report was generated successfully", Application.ProductName)
        End If
    End Sub
End Class