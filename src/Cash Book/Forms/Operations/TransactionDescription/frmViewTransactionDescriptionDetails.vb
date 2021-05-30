Public Class frmViewTransactionDescriptionDetails
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim saveDialog As New SaveFileDialog


        saveDialog.Filter = "PDF|*.pdf"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            RDLViewerDescription.SaveAs(saveDialog.FileName, "pdf")
            MessageBox.Show("PDF report was generated successfully", Application.ProductName)
        End If
    End Sub

    Private Sub frmViewTransactionDescriptionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class