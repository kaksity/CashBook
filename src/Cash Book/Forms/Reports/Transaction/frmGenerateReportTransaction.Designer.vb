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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTransactionType = New System.Windows.Forms.CheckBox()
        Me.cboTypeOfTransaction = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accounts"
        '
        'cboDescription
        '
        Me.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(139, 118)
        Me.cboDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(237, 24)
        Me.cboDescription.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description"
        '
        'cboAccounts
        '
        Me.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(141, 17)
        Me.cboAccounts.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(237, 24)
        Me.cboAccounts.TabIndex = 1
        '
        'chkDescription
        '
        Me.chkDescription.AutoSize = True
        Me.chkDescription.Location = New System.Drawing.Point(139, 94)
        Me.chkDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDescription.Name = "chkDescription"
        Me.chkDescription.Size = New System.Drawing.Size(111, 20)
        Me.chkDescription.TabIndex = 3
        Me.chkDescription.Text = "All Description"
        Me.chkDescription.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Type Of Transaction"
        '
        'chkTransactionType
        '
        Me.chkTransactionType.AutoSize = True
        Me.chkTransactionType.Location = New System.Drawing.Point(141, 44)
        Me.chkTransactionType.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTransactionType.Name = "chkTransactionType"
        Me.chkTransactionType.Size = New System.Drawing.Size(144, 20)
        Me.chkTransactionType.TabIndex = 6
        Me.chkTransactionType.Text = "All Transaction Type"
        Me.chkTransactionType.UseVisualStyleBackColor = True
        '
        'cboTypeOfTransaction
        '
        Me.cboTypeOfTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeOfTransaction.FormattingEnabled = True
        Me.cboTypeOfTransaction.Location = New System.Drawing.Point(141, 67)
        Me.cboTypeOfTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTypeOfTransaction.Name = "cboTypeOfTransaction"
        Me.cboTypeOfTransaction.Size = New System.Drawing.Size(235, 24)
        Me.cboTypeOfTransaction.TabIndex = 7
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(139, 149)
        Me.cboMonths.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(105, 24)
        Me.cboMonths.TabIndex = 8
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(248, 149)
        Me.cboYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(128, 24)
        Me.cboYears.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Duration"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerateReport.ButtonType = crsButton.cButton.btnType.report
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Image = CType(resources.GetObject("btnGenerateReport.Image"), System.Drawing.Image)
        Me.btnGenerateReport.Location = New System.Drawing.Point(139, 178)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(237, 60)
        Me.btnGenerateReport.TabIndex = 10
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'frmGenerateReportTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 246)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboYears)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.cboTypeOfTransaction)
        Me.Controls.Add(Me.chkTransactionType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkDescription)
        Me.Controls.Add(Me.cboAccounts)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents chkTransactionType As CheckBox
    Friend WithEvents cboTypeOfTransaction As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerateReport As crsButton.cButton
End Class
