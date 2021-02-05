<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRDLViewPrintAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDLViewPrintAccount))
        Me.RDLViewer = New fyiReporting.RdlViewer.RdlViewer()
        Me.btnPrint = New crsButton.cButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.RDLViewer.Location = New System.Drawing.Point(14, 15)
        Me.RDLViewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RDLViewer.Name = "RDLViewer"
        Me.RDLViewer.PageCurrent = 1
        Me.RDLViewer.Parameters = Nothing
        Me.RDLViewer.ReportName = Nothing
        Me.RDLViewer.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.RDLViewer.ShowFindPanel = False
        Me.RDLViewer.ShowParameterPanel = False
        Me.RDLViewer.Size = New System.Drawing.Size(506, 480)
        Me.RDLViewer.SourceFile = Nothing
        Me.RDLViewer.SourceRdl = Nothing
        Me.RDLViewer.TabIndex = 0
        Me.RDLViewer.Text = "RdlViewer1"
        Me.RDLViewer.UseTrueMargins = True
        Me.RDLViewer.Zoom = 0.5803692!
        Me.RDLViewer.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.ButtonType = crsButton.cButton.btnType.print
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(391, 496)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 40)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 512)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(14, 503)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRDLViewPrintAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 549)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RDLViewer)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDLViewPrintAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Print Account"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RDLViewer As fyiReporting.RdlViewer.RdlViewer
    Friend WithEvents btnPrint As crsButton.cButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
