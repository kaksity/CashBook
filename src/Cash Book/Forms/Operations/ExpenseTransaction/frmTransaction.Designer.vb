<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPVNumber = New System.Windows.Forms.TextBox()
        Me.dtpDateOfTransaction = New System.Windows.Forms.DateTimePicker()
        Me.cboDescription = New System.Windows.Forms.ComboBox()
        Me.cboAccounts = New System.Windows.Forms.ComboBox()
        Me.txtRefNumber = New System.Windows.Forms.TextBox()
        Me.txtSubheadColumn = New System.Windows.Forms.TextBox()
        Me.txtAmmountWithDrawn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBeneficiary = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAccountBalance = New System.Windows.Forms.Label()
        Me.btnNew = New crsButton.cButton()
        Me.btnUndo = New crsButton.cButton()
        Me.btnSave = New crsButton.cButton()
        Me.btnAddAccount = New crsButton.cButton()
        Me.btnAddDescription = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accounts"
        '
        'txtPVNumber
        '
        Me.txtPVNumber.Location = New System.Drawing.Point(144, 110)
        Me.txtPVNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPVNumber.Name = "txtPVNumber"
        Me.txtPVNumber.Size = New System.Drawing.Size(273, 22)
        Me.txtPVNumber.TabIndex = 3
        '
        'dtpDateOfTransaction
        '
        Me.dtpDateOfTransaction.CustomFormat = "dd/M/yyyy"
        Me.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfTransaction.Location = New System.Drawing.Point(144, 57)
        Me.dtpDateOfTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateOfTransaction.Name = "dtpDateOfTransaction"
        Me.dtpDateOfTransaction.Size = New System.Drawing.Size(273, 22)
        Me.dtpDateOfTransaction.TabIndex = 1
        '
        'cboDescription
        '
        Me.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(144, 82)
        Me.cboDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(273, 24)
        Me.cboDescription.TabIndex = 2
        '
        'cboAccounts
        '
        Me.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(144, 30)
        Me.cboAccounts.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(273, 24)
        Me.cboAccounts.TabIndex = 0
        '
        'txtRefNumber
        '
        Me.txtRefNumber.Location = New System.Drawing.Point(144, 135)
        Me.txtRefNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRefNumber.Name = "txtRefNumber"
        Me.txtRefNumber.Size = New System.Drawing.Size(273, 22)
        Me.txtRefNumber.TabIndex = 4
        '
        'txtSubheadColumn
        '
        Me.txtSubheadColumn.Location = New System.Drawing.Point(144, 161)
        Me.txtSubheadColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubheadColumn.Name = "txtSubheadColumn"
        Me.txtSubheadColumn.Size = New System.Drawing.Size(273, 22)
        Me.txtSubheadColumn.TabIndex = 5
        '
        'txtAmmountWithDrawn
        '
        Me.txtAmmountWithDrawn.Location = New System.Drawing.Point(144, 186)
        Me.txtAmmountWithDrawn.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmmountWithDrawn.Name = "txtAmmountWithDrawn"
        Me.txtAmmountWithDrawn.Size = New System.Drawing.Size(273, 22)
        Me.txtAmmountWithDrawn.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date of Transaction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PV Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ref Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 163)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sub Head Column"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 189)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CR - Payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 214)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name of Beneficiary"
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.Location = New System.Drawing.Point(144, 212)
        Me.txtBeneficiary.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.Size = New System.Drawing.Size(273, 22)
        Me.txtBeneficiary.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 242)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Account Balance"
        '
        'lblAccountBalance
        '
        Me.lblAccountBalance.BackColor = System.Drawing.Color.White
        Me.lblAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccountBalance.Location = New System.Drawing.Point(143, 235)
        Me.lblAccountBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccountBalance.Name = "lblAccountBalance"
        Me.lblAccountBalance.Size = New System.Drawing.Size(273, 30)
        Me.lblAccountBalance.TabIndex = 0
        Me.lblAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnNew.Location = New System.Drawing.Point(144, 268)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(85, 45)
        Me.btnNew.TabIndex = 11
        Me.btnNew.UseVisualStyleBackColor = False
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
        Me.btnUndo.Location = New System.Drawing.Point(235, 268)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(85, 45)
        Me.btnUndo.TabIndex = 11
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
        Me.btnSave.Location = New System.Drawing.Point(331, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 45)
        Me.btnSave.TabIndex = 11
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnAddAccount.Location = New System.Drawing.Point(422, 30)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(26, 24)
        Me.btnAddAccount.TabIndex = 12
        Me.btnAddAccount.UseVisualStyleBackColor = False
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
        Me.btnAddDescription.Location = New System.Drawing.Point(422, 82)
        Me.btnAddDescription.Name = "btnAddDescription"
        Me.btnAddDescription.Size = New System.Drawing.Size(26, 23)
        Me.btnAddDescription.TabIndex = 13
        Me.btnAddDescription.UseVisualStyleBackColor = False
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 342)
        Me.Controls.Add(Me.btnAddDescription)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.cboAccounts)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.dtpDateOfTransaction)
        Me.Controls.Add(Me.txtBeneficiary)
        Me.Controls.Add(Me.txtAmmountWithDrawn)
        Me.Controls.Add(Me.txtSubheadColumn)
        Me.Controls.Add(Me.txtRefNumber)
        Me.Controls.Add(Me.txtPVNumber)
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
        Me.Name = "frmTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPVNumber As TextBox
    Friend WithEvents dtpDateOfTransaction As DateTimePicker
    Friend WithEvents cboDescription As ComboBox
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents txtRefNumber As TextBox
    Friend WithEvents txtSubheadColumn As TextBox
    Friend WithEvents txtAmmountWithDrawn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBeneficiary As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAccountBalance As Label
    Friend WithEvents btnNew As crsButton.cButton
    Friend WithEvents btnUndo As crsButton.cButton
    Friend WithEvents btnSave As crsButton.cButton
    Friend WithEvents btnAddAccount As crsButton.cButton
    Friend WithEvents btnAddDescription As crsButton.cButton
End Class
