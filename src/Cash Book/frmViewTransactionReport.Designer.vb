﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.RDLViewer.Location = New System.Drawing.Point(12, 69)
        Me.RDLViewer.Name = "RDLViewer"
        Me.RDLViewer.PageCurrent = 1
        Me.RDLViewer.Parameters = Nothing
        Me.RDLViewer.ReportName = Nothing
        Me.RDLViewer.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous
        Me.RDLViewer.ShowFindPanel = False
        Me.RDLViewer.ShowParameterPanel = False
        Me.RDLViewer.Size = New System.Drawing.Size(1183, 446)
        Me.RDLViewer.SourceFile = Nothing
        Me.RDLViewer.SourceRdl = Nothing
        Me.RDLViewer.TabIndex = 0
        Me.RDLViewer.Text = "RdlViewer1"
        Me.RDLViewer.UseTrueMargins = True
        Me.RDLViewer.Zoom = 1.383866!
        Me.RDLViewer.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.Location = New System.Drawing.Point(12, 12)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(201, 51)
        Me.btnGeneratePDF.TabIndex = 1
        Me.btnGeneratePDF.Text = "&Generate PDF"
        Me.btnGeneratePDF.UseVisualStyleBackColor = True
        '
        'frmViewTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 537)
        Me.Controls.Add(Me.btnGeneratePDF)
        Me.Controls.Add(Me.RDLViewer)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
End Class
