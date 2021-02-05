<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTransactionDescriptionDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTransactionDescriptionDetails))
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.RDLViewerDescription = New fyiReporting.RdlViewer.RdlViewer()
        Me.documentToBePrinted = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.Location = New System.Drawing.Point(12, 12)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(246, 45)
        Me.btnGeneratePDF.TabIndex = 0
        Me.btnGeneratePDF.Text = "&Generate PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'RDLViewerDescription
        '
        Me.RDLViewerDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RDLViewerDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.RDLViewerDescription.Folder = Nothing
        Me.RDLViewerDescription.HighlightAll = False
        Me.RDLViewerDescription.HighlightAllColor = System.Drawing.Color.Fuchsia
        Me.RDLViewerDescription.HighlightCaseSensitive = False
        Me.RDLViewerDescription.HighlightItemColor = System.Drawing.Color.Aqua
        Me.RDLViewerDescription.HighlightPageItem = Nothing
        Me.RDLViewerDescription.HighlightText = Nothing
        Me.RDLViewerDescription.Location = New System.Drawing.Point(12, 63)
        Me.RDLViewerDescription.Name = "RDLViewerDescription"
        Me.RDLViewerDescription.PageCurrent = 1
        Me.RDLViewerDescription.Parameters = Nothing
        Me.RDLViewerDescription.ReportName = Nothing
        Me.RDLViewerDescription.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.RDLViewerDescription.ShowFindPanel = False
        Me.RDLViewerDescription.ShowParameterPanel = False
        Me.RDLViewerDescription.Size = New System.Drawing.Size(899, 527)
        Me.RDLViewerDescription.SourceFile = Nothing
        Me.RDLViewerDescription.SourceRdl = Nothing
        Me.RDLViewerDescription.TabIndex = 1
        Me.RDLViewerDescription.Text = "RdlViewer1"
        Me.RDLViewerDescription.UseTrueMargins = True
        Me.RDLViewerDescription.Zoom = 1.046801!
        Me.RDLViewerDescription.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'frmViewTransactionDescriptionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 602)
        Me.Controls.Add(Me.RDLViewerDescription)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewTransactionDescriptionDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Transaction Description Details Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents RDLViewerDescription As fyiReporting.RdlViewer.RdlViewer
    Friend WithEvents documentToBePrinted As Printing.PrintDocument
End Class
