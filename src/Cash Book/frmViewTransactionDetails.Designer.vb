<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTransactionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTransactionDetails))
        Me.btnPrintNow = New System.Windows.Forms.Button()
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.RdlViewer1 = New fyiReporting.RdlViewer.RdlViewer()
        Me.SuspendLayout()
        '
        'btnPrintNow
        '
        Me.btnPrintNow.Location = New System.Drawing.Point(12, 12)
        Me.btnPrintNow.Name = "btnPrintNow"
        Me.btnPrintNow.Size = New System.Drawing.Size(144, 46)
        Me.btnPrintNow.TabIndex = 1
        Me.btnPrintNow.Text = "&Print Now"
        Me.btnPrintNow.UseVisualStyleBackColor = True
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.Location = New System.Drawing.Point(162, 12)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(144, 46)
        Me.btnGeneratePDF.TabIndex = 1
        Me.btnGeneratePDF.Text = "&Generate PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'RdlViewer1
        '
        Me.RdlViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RdlViewer1.Folder = Nothing
        Me.RdlViewer1.HighlightAll = False
        Me.RdlViewer1.HighlightAllColor = System.Drawing.Color.Fuchsia
        Me.RdlViewer1.HighlightCaseSensitive = False
        Me.RdlViewer1.HighlightItemColor = System.Drawing.Color.Aqua
        Me.RdlViewer1.HighlightPageItem = Nothing
        Me.RdlViewer1.HighlightText = Nothing
        Me.RdlViewer1.Location = New System.Drawing.Point(12, 64)
        Me.RdlViewer1.Name = "RdlViewer1"
        Me.RdlViewer1.PageCurrent = 1
        Me.RdlViewer1.Parameters = Nothing
        Me.RdlViewer1.ReportName = Nothing
        Me.RdlViewer1.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.RdlViewer1.ShowFindPanel = False
        Me.RdlViewer1.ShowParameterPanel = True
        Me.RdlViewer1.Size = New System.Drawing.Size(1041, 494)
        Me.RdlViewer1.SourceFile = Nothing
        Me.RdlViewer1.SourceRdl = Nothing
        Me.RdlViewer1.TabIndex = 2
        Me.RdlViewer1.Text = "RdlViewer1"
        Me.RdlViewer1.UseTrueMargins = True
        Me.RdlViewer1.Zoom = 1.215333!
        Me.RdlViewer1.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'frmViewTransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 570)
        Me.Controls.Add(Me.RdlViewer1)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.Controls.Add(Me.btnPrintNow)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewTransactionDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Transaction Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrintNow As Button
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents RdlViewer1 As fyiReporting.RdlViewer.RdlViewer
End Class
