<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateReportTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateReportTransaction))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDescription = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAccounts = New System.Windows.Forms.ComboBox()
        Me.chkDescription = New System.Windows.Forms.CheckBox()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTransactionType = New System.Windows.Forms.CheckBox()
        Me.cboTypeOfTransaction = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accounts"
        '
        'cboDescription
        '
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(138, 150)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(304, 28)
        Me.cboDescription.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description"
        '
        'cboAccounts
        '
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(140, 24)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(304, 28)
        Me.cboAccounts.TabIndex = 1
        '
        'chkDescription
        '
        Me.chkDescription.AutoSize = True
        Me.chkDescription.Location = New System.Drawing.Point(138, 120)
        Me.chkDescription.Name = "chkDescription"
        Me.chkDescription.Size = New System.Drawing.Size(114, 24)
        Me.chkDescription.TabIndex = 3
        Me.chkDescription.Text = "All Description"
        Me.chkDescription.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(138, 223)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(303, 41)
        Me.btnGenerateReport.TabIndex = 4
        Me.btnGenerateReport.Text = "&Generate"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Type Of Transaction"
        '
        'chkTransactionType
        '
        Me.chkTransactionType.AutoSize = True
        Me.chkTransactionType.Location = New System.Drawing.Point(140, 58)
        Me.chkTransactionType.Name = "chkTransactionType"
        Me.chkTransactionType.Size = New System.Drawing.Size(148, 24)
        Me.chkTransactionType.TabIndex = 6
        Me.chkTransactionType.Text = "All Transaction Type"
        Me.chkTransactionType.UseVisualStyleBackColor = True
        '
        'cboTypeOfTransaction
        '
        Me.cboTypeOfTransaction.FormattingEnabled = True
        Me.cboTypeOfTransaction.Location = New System.Drawing.Point(140, 86)
        Me.cboTypeOfTransaction.Name = "cboTypeOfTransaction"
        Me.cboTypeOfTransaction.Size = New System.Drawing.Size(301, 28)
        Me.cboTypeOfTransaction.TabIndex = 7
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(138, 189)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(134, 28)
        Me.cboMonths.TabIndex = 8
        '
        'cboYears
        '
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(278, 189)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(163, 28)
        Me.cboYears.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Duration"
        '
        'frmGenerateReportTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 275)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboYears)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.cboTypeOfTransaction)
        Me.Controls.Add(Me.chkTransactionType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.chkDescription)
        Me.Controls.Add(Me.cboAccounts)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerateReportTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Generate Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboDescription As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents chkDescription As CheckBox
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chkTransactionType As CheckBox
    Friend WithEvents cboTypeOfTransaction As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents Label2 As Label
End Class
