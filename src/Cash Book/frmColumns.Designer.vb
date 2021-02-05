<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColumns))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.pgProgress = New System.Windows.Forms.ProgressBar()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 12)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1231, 487)
        Me.grid.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(12, 505)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(252, 41)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "&Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'pgProgress
        '
        Me.pgProgress.Location = New System.Drawing.Point(270, 505)
        Me.pgProgress.Name = "pgProgress"
        Me.pgProgress.Size = New System.Drawing.Size(973, 41)
        Me.pgProgress.TabIndex = 2
        '
        'frmColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 558)
        Me.Controls.Add(Me.pgProgress)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColumns"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Columns"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents btnExport As Button
    Friend WithEvents pgProgress As ProgressBar
End Class
