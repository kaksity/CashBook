<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloseFinancialMonth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCloseFinancialMonth))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnCloseTransaction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrentMonth = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOpeningBalance = New System.Windows.Forms.Label()
        Me.lblClosingBalance = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(381, 10)
        Me.grid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(323, 213)
        Me.grid.TabIndex = 0
        '
        'btnCloseTransaction
        '
        Me.btnCloseTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseTransaction.Location = New System.Drawing.Point(120, 138)
        Me.btnCloseTransaction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCloseTransaction.Name = "btnCloseTransaction"
        Me.btnCloseTransaction.Size = New System.Drawing.Size(126, 33)
        Me.btnCloseTransaction.TabIndex = 1
        Me.btnCloseTransaction.Text = "Close &Transaction"
        Me.btnCloseTransaction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Month"
        '
        'lblCurrentMonth
        '
        Me.lblCurrentMonth.BackColor = System.Drawing.Color.White
        Me.lblCurrentMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentMonth.Location = New System.Drawing.Point(120, 35)
        Me.lblCurrentMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentMonth.Name = "lblCurrentMonth"
        Me.lblCurrentMonth.Size = New System.Drawing.Size(257, 22)
        Me.lblCurrentMonth.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Opening Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Closing Balance"
        '
        'lblOpeningBalance
        '
        Me.lblOpeningBalance.BackColor = System.Drawing.Color.White
        Me.lblOpeningBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpeningBalance.Location = New System.Drawing.Point(120, 60)
        Me.lblOpeningBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpeningBalance.Name = "lblOpeningBalance"
        Me.lblOpeningBalance.Size = New System.Drawing.Size(257, 22)
        Me.lblOpeningBalance.TabIndex = 2
        '
        'lblClosingBalance
        '
        Me.lblClosingBalance.BackColor = System.Drawing.Color.White
        Me.lblClosingBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClosingBalance.Location = New System.Drawing.Point(120, 86)
        Me.lblClosingBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClosingBalance.Name = "lblClosingBalance"
        Me.lblClosingBalance.Size = New System.Drawing.Size(257, 22)
        Me.lblClosingBalance.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(251, 138)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 33)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account"
        '
        'lblAccount
        '
        Me.lblAccount.BackColor = System.Drawing.Color.White
        Me.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccount.Location = New System.Drawing.Point(120, 10)
        Me.lblAccount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(257, 22)
        Me.lblAccount.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(120, 113)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(257, 22)
        Me.lblStatus.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Status"
        '
        'frmCloseFinancialMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 232)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblClosingBalance)
        Me.Controls.Add(Me.lblOpeningBalance)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.lblCurrentMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCloseTransaction)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCloseFinancialMonth"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Close Monthly Transaction"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents btnCloseTransaction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrentMonth As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOpeningBalance As Label
    Friend WithEvents lblClosingBalance As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
End Class
