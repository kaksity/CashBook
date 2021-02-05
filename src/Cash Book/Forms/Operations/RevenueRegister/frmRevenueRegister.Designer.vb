<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevenueRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevenueRegister))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.dtpDateOfTransaction = New System.Windows.Forms.DateTimePicker()
        Me.txtNameOfPayee = New System.Windows.Forms.TextBox()
        Me.txtReceipts = New System.Windows.Forms.TextBox()
        Me.txtRVNumber = New System.Windows.Forms.TextBox()
        Me.txtDebit = New System.Windows.Forms.TextBox()
        Me.txtSubhead = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAccountBalance = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboDescription = New System.Windows.Forms.ComboBox()
        Me.btnAddAccount = New crsButton.cButton()
        Me.btnUndo = New crsButton.cButton()
        Me.btnSave = New crsButton.cButton()
        Me.btnNew = New crsButton.cButton()
        Me.btnAddDescription = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account"
        '
        'cboAccount
        '
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(133, 16)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(287, 24)
        Me.cboAccount.TabIndex = 0
        '
        'dtpDateOfTransaction
        '
        Me.dtpDateOfTransaction.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfTransaction.Location = New System.Drawing.Point(133, 44)
        Me.dtpDateOfTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateOfTransaction.Name = "dtpDateOfTransaction"
        Me.dtpDateOfTransaction.Size = New System.Drawing.Size(287, 22)
        Me.dtpDateOfTransaction.TabIndex = 1
        '
        'txtNameOfPayee
        '
        Me.txtNameOfPayee.Location = New System.Drawing.Point(133, 199)
        Me.txtNameOfPayee.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameOfPayee.Name = "txtNameOfPayee"
        Me.txtNameOfPayee.Size = New System.Drawing.Size(287, 22)
        Me.txtNameOfPayee.TabIndex = 7
        '
        'txtReceipts
        '
        Me.txtReceipts.Location = New System.Drawing.Point(133, 95)
        Me.txtReceipts.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReceipts.Name = "txtReceipts"
        Me.txtReceipts.Size = New System.Drawing.Size(287, 22)
        Me.txtReceipts.TabIndex = 3
        '
        'txtRVNumber
        '
        Me.txtRVNumber.Location = New System.Drawing.Point(133, 70)
        Me.txtRVNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRVNumber.Name = "txtRVNumber"
        Me.txtRVNumber.Size = New System.Drawing.Size(287, 22)
        Me.txtRVNumber.TabIndex = 2
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(133, 173)
        Me.txtDebit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(287, 22)
        Me.txtDebit.TabIndex = 6
        '
        'txtSubhead
        '
        Me.txtSubhead.Location = New System.Drawing.Point(133, 121)
        Me.txtSubhead.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubhead.Name = "txtSubhead"
        Me.txtSubhead.Size = New System.Drawing.Size(287, 22)
        Me.txtSubhead.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date of Transaction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RV Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Receipts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Subhead"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 175)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Debit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 201)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name of Payee"
        '
        'lblAccountBalance
        '
        Me.lblAccountBalance.BackColor = System.Drawing.Color.White
        Me.lblAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccountBalance.Location = New System.Drawing.Point(133, 222)
        Me.lblAccountBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccountBalance.Name = "lblAccountBalance"
        Me.lblAccountBalance.Size = New System.Drawing.Size(286, 31)
        Me.lblAccountBalance.TabIndex = 0
        Me.lblAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Account Balance"
        '
        'cboDescription
        '
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(133, 147)
        Me.cboDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(287, 24)
        Me.cboDescription.TabIndex = 11
        '
        'btnAddAccount
        '
        Me.btnAddAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAccount.ButtonType = crsButton.cButton.btnType.add_combo
        Me.btnAddAccount.FlatAppearance.BorderSize = 0
        Me.btnAddAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAccount.Image = CType(resources.GetObject("btnAddAccount.Image"), System.Drawing.Image)
        Me.btnAddAccount.Location = New System.Drawing.Point(425, 12)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(25, 28)
        Me.btnAddAccount.TabIndex = 12
        Me.btnAddAccount.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Transparent
        Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
        Me.btnUndo.FlatAppearance.BorderSize = 0
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.Location = New System.Drawing.Point(224, 265)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(85, 45)
        Me.btnUndo.TabIndex = 13
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.ButtonType = crsButton.cButton.btnType.save
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(334, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.ButtonType = crsButton.cButton.btnType.new_
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(133, 265)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(85, 45)
        Me.btnNew.TabIndex = 13
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnAddDescription
        '
        Me.btnAddDescription.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDescription.ButtonType = crsButton.cButton.btnType.add_combo
        Me.btnAddDescription.FlatAppearance.BorderSize = 0
        Me.btnAddDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDescription.Image = CType(resources.GetObject("btnAddDescription.Image"), System.Drawing.Image)
        Me.btnAddDescription.Location = New System.Drawing.Point(425, 144)
        Me.btnAddDescription.Name = "btnAddDescription"
        Me.btnAddDescription.Size = New System.Drawing.Size(25, 28)
        Me.btnAddDescription.TabIndex = 14
        Me.btnAddDescription.UseVisualStyleBackColor = False
        '
        'frmRevenueRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 330)
        Me.Controls.Add(Me.btnAddDescription)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.txtRVNumber)
        Me.Controls.Add(Me.txtSubhead)
        Me.Controls.Add(Me.txtReceipts)
        Me.Controls.Add(Me.txtNameOfPayee)
        Me.Controls.Add(Me.dtpDateOfTransaction)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.lblAccountBalance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRevenueRegister"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Revenue Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboAccount As ComboBox
    Friend WithEvents dtpDateOfTransaction As DateTimePicker
    Friend WithEvents txtNameOfPayee As TextBox
    Friend WithEvents txtReceipts As TextBox
    Friend WithEvents txtRVNumber As TextBox
    Friend WithEvents txtDebit As TextBox
    Friend WithEvents txtSubhead As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAccountBalance As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboDescription As ComboBox
    Friend WithEvents btnAddAccount As crsButton.cButton
    Friend WithEvents btnUndo As crsButton.cButton
    Friend WithEvents btnSave As crsButton.cButton
    Friend WithEvents btnNew As crsButton.cButton
    Friend WithEvents btnAddDescription As crsButton.cButton
End Class
