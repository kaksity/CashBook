<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTransactionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTransactionReport))
        Me.RDLViewer = New fyiReporting.RdlViewer.RdlViewer()
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnPrintNow = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'RDLViewer
        '
        Me.RDLViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.RDLViewer.Folder = Nothing
        Me.RDLViewer.HighlightAll = False
        Me.RDLViewer.HighlightAllColor = System.Drawing.Color.Fuchsia
        Me.RDLViewer.HighlightCaseSensitive = False
        Me.RDLViewer.HighlightItemColor = System.Drawing.Color.Aqua
        Me.RDLViewer.HighlightPageItem = Nothing
        Me.RDLViewer.HighlightText = Nothing
        Me.RDLViewer.Location = New System.Drawing.Point(9, 11)
        Me.RDLViewer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RDLViewer.Name = "RDLViewer"
        Me.RDLViewer.PageCurrent = 1
        Me.RDLViewer.Parameters = Nothing
        Me.RDLViewer.ReportName = Nothing
        Me.RDLViewer.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.RDLViewer.ShowFindPanel = False
        Me.RDLViewer.ShowParameterPanel = False
        Me.RDLViewer.Size = New System.Drawing.Size(821, 479)
        Me.RDLViewer.SourceFile = Nothing
        Me.RDLViewer.SourceRdl = Nothing
        Me.RDLViewer.TabIndex = 0
        Me.RDLViewer.Text = "RdlViewer1"
        Me.RDLViewer.UseTrueMargins = True
        Me.RDLViewer.Zoom = 0.9542267!
        Me.RDLViewer.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePDF.Location = New System.Drawing.Point(12, 495)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(92, 47)
        Me.btnGeneratePDF.TabIndex = 1
        Me.btnGeneratePDF.Text = "PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 507)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'btnPrintNow
        '
        Me.btnPrintNow.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintNow.ButtonType = crsButton.cButton.btnType.print
        Me.btnPrintNow.FlatAppearance.BorderSize = 0
        Me.btnPrintNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrintNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrintNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintNow.Image = CType(resources.GetObject("btnPrintNow.Image"), System.Drawing.Image)
        Me.btnPrintNow.Location = New System.Drawing.Point(744, 497)
        Me.btnPrintNow.Name = "btnPrintNow"
        Me.btnPrintNow.Size = New System.Drawing.Size(85, 45)
        Me.btnPrintNow.TabIndex = 3
        Me.btnPrintNow.UseVisualStyleBackColor = False
        '
        'frmViewTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 554)
        Me.Controls.Add(Me.btnPrintNow)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.Controls.Add(Me.RDLViewer)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewTransactionReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Transaction Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RDLViewer As fyiReporting.RdlViewer.RdlViewer
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnPrintNow As crsButton.cButton
End Class
