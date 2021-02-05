<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBankReconcilation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewBankReconcilation))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 12)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(859, 364)
        Me.grid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selected Record"
        '
        'lblDuration
        '
        Me.lblDuration.BackColor = System.Drawing.Color.White
        Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDuration.Location = New System.Drawing.Point(129, 389)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(742, 20)
        Me.lblDuration.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(626, 412)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(245, 39)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnViewDetails
        '
        Me.btnViewDetails.Location = New System.Drawing.Point(129, 412)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(233, 39)
        Me.btnViewDetails.TabIndex = 2
        Me.btnViewDetails.Text = "&View Details"
        Me.btnViewDetails.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(371, 412)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(249, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmViewBankReconcilation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 480)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewBankReconcilation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - View Bank Reconcilation"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnDelete As Button
End Class
