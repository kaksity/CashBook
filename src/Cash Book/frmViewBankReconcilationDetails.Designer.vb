<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewBankReconcilationDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewBankReconcilationDetails))
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.rdlViews = New fyiReporting.RdlViewer.RdlViewer()
        Me.SuspendLayout()
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.Location = New System.Drawing.Point(12, 12)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(138, 44)
        Me.btnGeneratePDF.TabIndex = 0
        Me.btnGeneratePDF.Text = "&Generate PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'rdlViews
        '
        Me.rdlViews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdlViews.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdlViews.Folder = Nothing
        Me.rdlViews.HighlightAll = False
        Me.rdlViews.HighlightAllColor = System.Drawing.Color.Fuchsia
        Me.rdlViews.HighlightCaseSensitive = False
        Me.rdlViews.HighlightItemColor = System.Drawing.Color.Aqua
        Me.rdlViews.HighlightPageItem = Nothing
        Me.rdlViews.HighlightText = Nothing
        Me.rdlViews.Location = New System.Drawing.Point(12, 62)
        Me.rdlViews.Name = "rdlViews"
        Me.rdlViews.PageCurrent = 1
        Me.rdlViews.Parameters = Nothing
        Me.rdlViews.ReportName = Nothing
        Me.rdlViews.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.rdlViews.ShowFindPanel = False
        Me.rdlViews.ShowParameterPanel = False
        Me.rdlViews.Size = New System.Drawing.Size(879, 624)
        Me.rdlViews.SourceFile = Nothing
        Me.rdlViews.SourceRdl = Nothing
        Me.rdlViews.TabIndex = 1
        Me.rdlViews.UseTrueMargins = True
        Me.rdlViews.Zoom = 1.023064!
        Me.rdlViews.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'frmViewBankReconcilationDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 698)
        Me.Controls.Add(Me.rdlViews)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewBankReconcilationDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Bank Reconcilation Details"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents rdlViews As fyiReporting.RdlViewer.RdlViewer
End Class
