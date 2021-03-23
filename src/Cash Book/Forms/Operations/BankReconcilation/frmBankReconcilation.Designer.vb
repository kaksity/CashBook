<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBankReconcilation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankReconcilation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOutstandingStaleChqs = New System.Windows.Forms.TextBox()
        Me.txtDebitTransfer = New System.Windows.Forms.TextBox()
        Me.txtBankCharges = New System.Windows.Forms.TextBox()
        Me.txtStaleChqsReversed = New System.Windows.Forms.TextBox()
        Me.txtInterestReceived = New System.Windows.Forms.TextBox()
        Me.txtCreditTransfer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemsInCashBookNotBank = New System.Windows.Forms.TextBox()
        Me.txtUncreditedLodgement = New System.Windows.Forms.TextBox()
        Me.txtItemsInBankNotCashBook = New System.Windows.Forms.TextBox()
        Me.txtUnpresentedChqs = New System.Windows.Forms.TextBox()
        Me.btnNew = New crsButton.cButton()
        Me.btnSave = New crsButton.cButton()
        Me.btnUndo = New crsButton.cButton()
        Me.btnClose = New crsButton.cButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOutstandingStaleChqs)
        Me.GroupBox1.Controls.Add(Me.txtDebitTransfer)
        Me.GroupBox1.Controls.Add(Me.txtBankCharges)
        Me.GroupBox1.Controls.Add(Me.txtStaleChqsReversed)
        Me.GroupBox1.Controls.Add(Me.txtInterestReceived)
        Me.GroupBox1.Controls.Add(Me.txtCreditTransfer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(310, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cash Book Details"
        '
        'txtOutstandingStaleChqs
        '
        Me.txtOutstandingStaleChqs.Location = New System.Drawing.Point(171, 148)
        Me.txtOutstandingStaleChqs.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOutstandingStaleChqs.Name = "txtOutstandingStaleChqs"
        Me.txtOutstandingStaleChqs.Size = New System.Drawing.Size(135, 22)
        Me.txtOutstandingStaleChqs.TabIndex = 8
        '
        'txtDebitTransfer
        '
        Me.txtDebitTransfer.Location = New System.Drawing.Point(171, 122)
        Me.txtDebitTransfer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDebitTransfer.Name = "txtDebitTransfer"
        Me.txtDebitTransfer.Size = New System.Drawing.Size(135, 22)
        Me.txtDebitTransfer.TabIndex = 7
        '
        'txtBankCharges
        '
        Me.txtBankCharges.Location = New System.Drawing.Point(171, 97)
        Me.txtBankCharges.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(135, 22)
        Me.txtBankCharges.TabIndex = 6
        '
        'txtStaleChqsReversed
        '
        Me.txtStaleChqsReversed.Location = New System.Drawing.Point(171, 71)
        Me.txtStaleChqsReversed.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStaleChqsReversed.Name = "txtStaleChqsReversed"
        Me.txtStaleChqsReversed.Size = New System.Drawing.Size(135, 22)
        Me.txtStaleChqsReversed.TabIndex = 5
        '
        'txtInterestReceived
        '
        Me.txtInterestReceived.Location = New System.Drawing.Point(171, 46)
        Me.txtInterestReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInterestReceived.Name = "txtInterestReceived"
        Me.txtInterestReceived.Size = New System.Drawing.Size(135, 22)
        Me.txtInterestReceived.TabIndex = 4
        '
        'txtCreditTransfer
        '
        Me.txtCreditTransfer.Location = New System.Drawing.Point(171, 20)
        Me.txtCreditTransfer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCreditTransfer.Name = "txtCreditTransfer"
        Me.txtCreditTransfer.Size = New System.Drawing.Size(135, 22)
        Me.txtCreditTransfer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Outstanding Stale Chqs/Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Debit Transfer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Bank Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stale Chqs Reversed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Interest Received"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Transfer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account"
        '
        'cboAccount
        '
        Me.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(71, 19)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(616, 24)
        Me.cboAccount.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboYears)
        Me.GroupBox2.Controls.Add(Me.cboMonths)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 46)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(682, 60)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Duration"
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(353, 19)
        Me.cboYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(325, 24)
        Me.cboYears.TabIndex = 2
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(5, 20)
        Me.cboMonths.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(328, 24)
        Me.cboMonths.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtItemsInCashBookNotBank)
        Me.GroupBox3.Controls.Add(Me.txtUncreditedLodgement)
        Me.GroupBox3.Controls.Add(Me.txtItemsInBankNotCashBook)
        Me.GroupBox3.Controls.Add(Me.txtUnpresentedChqs)
        Me.GroupBox3.Location = New System.Drawing.Point(324, 111)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(367, 125)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bank Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Items In Cash Book Not Bank"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 71)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Uncredited Lodgements"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Items In Bank Not Cash Book"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Unpresent Chqs"
        '
        'txtItemsInCashBookNotBank
        '
        Me.txtItemsInCashBookNotBank.Location = New System.Drawing.Point(191, 93)
        Me.txtItemsInCashBookNotBank.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemsInCashBookNotBank.Name = "txtItemsInCashBookNotBank"
        Me.txtItemsInCashBookNotBank.Size = New System.Drawing.Size(155, 22)
        Me.txtItemsInCashBookNotBank.TabIndex = 12
        '
        'txtUncreditedLodgement
        '
        Me.txtUncreditedLodgement.Location = New System.Drawing.Point(191, 68)
        Me.txtUncreditedLodgement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUncreditedLodgement.Name = "txtUncreditedLodgement"
        Me.txtUncreditedLodgement.Size = New System.Drawing.Size(155, 22)
        Me.txtUncreditedLodgement.TabIndex = 11
        '
        'txtItemsInBankNotCashBook
        '
        Me.txtItemsInBankNotCashBook.Location = New System.Drawing.Point(191, 42)
        Me.txtItemsInBankNotCashBook.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemsInBankNotCashBook.Name = "txtItemsInBankNotCashBook"
        Me.txtItemsInBankNotCashBook.Size = New System.Drawing.Size(155, 22)
        Me.txtItemsInBankNotCashBook.TabIndex = 10
        '
        'txtUnpresentedChqs
        '
        Me.txtUnpresentedChqs.Location = New System.Drawing.Point(191, 17)
        Me.txtUnpresentedChqs.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnpresentedChqs.Name = "txtUnpresentedChqs"
        Me.txtUnpresentedChqs.Size = New System.Drawing.Size(155, 22)
        Me.txtUnpresentedChqs.TabIndex = 9
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
        Me.btnNew.Location = New System.Drawing.Point(324, 239)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(85, 45)
        Me.btnNew.TabIndex = 2
        Me.btnNew.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(515, 239)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 45)
        Me.btnSave.TabIndex = 2
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnUndo.Location = New System.Drawing.Point(415, 239)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(85, 45)
        Me.btnUndo.TabIndex = 2
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(606, 239)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 45)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmBankReconcilation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 312)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBankReconcilation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Bank Reconcilation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAccount As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOutstandingStaleChqs As TextBox
    Friend WithEvents txtDebitTransfer As TextBox
    Friend WithEvents txtBankCharges As TextBox
    Friend WithEvents txtStaleChqsReversed As TextBox
    Friend WithEvents txtInterestReceived As TextBox
    Friend WithEvents txtCreditTransfer As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnpresentedChqs As TextBox
    Friend WithEvents txtItemsInCashBookNotBank As TextBox
    Friend WithEvents txtUncreditedLodgement As TextBox
    Friend WithEvents txtItemsInBankNotCashBook As TextBox
    Friend WithEvents btnNew As crsButton.cButton
    Friend WithEvents btnSave As crsButton.cButton
    Friend WithEvents btnUndo As crsButton.cButton
    Friend WithEvents btnClose As crsButton.cButton
End Class
