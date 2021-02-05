Public Class frmViewAccountDetails

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim saveDialog As New SaveFileDialog

        saveDialog.Filter = "PDF|*.pdf"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            RdlViewer1.SaveAs(saveDialog.FileName, "PDF")
            MessageBox.Show("PDF report was generated Successfully", Application.ProductName)
        End If

    End Sub
End Class