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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cash Book Details"
        '
        'txtOutstandingStaleChqs
        '
        Me.txtOutstandingStaleChqs.Location = New System.Drawing.Point(220, 185)
        Me.txtOutstandingStaleChqs.Name = "txtOutstandingStaleChqs"
        Me.txtOutstandingStaleChqs.Size = New System.Drawing.Size(173, 26)
        Me.txtOutstandingStaleChqs.TabIndex = 8
        '
        'txtDebitTransfer
        '
        Me.txtDebitTransfer.Location = New System.Drawing.Point(220, 153)
        Me.txtDebitTransfer.Name = "txtDebitTransfer"
        Me.txtDebitTransfer.Size = New System.Drawing.Size(173, 26)
        Me.txtDebitTransfer.TabIndex = 7
        '
        'txtBankCharges
        '
        Me.txtBankCharges.Location = New System.Drawing.Point(220, 121)
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(173, 26)
        Me.txtBankCharges.TabIndex = 6
        '
        'txtStaleChqsReversed
        '
        Me.txtStaleChqsReversed.Location = New System.Drawing.Point(220, 89)
        Me.txtStaleChqsReversed.Name = "txtStaleChqsReversed"
        Me.txtStaleChqsReversed.Size = New System.Drawing.Size(173, 26)
        Me.txtStaleChqsReversed.TabIndex = 5
        '
        'txtInterestReceived
        '
        Me.txtInterestReceived.Location = New System.Drawing.Point(220, 57)
        Me.txtInterestReceived.Name = "txtInterestReceived"
        Me.txtInterestReceived.Size = New System.Drawing.Size(173, 26)
        Me.txtInterestReceived.TabIndex = 4
        '
        'txtCreditTransfer
        '
        Me.txtCreditTransfer.Location = New System.Drawing.Point(220, 25)
        Me.txtCreditTransfer.Name = "txtCreditTransfer"
        Me.txtCreditTransfer.Size = New System.Drawing.Size(173, 26)
        Me.txtCreditTransfer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Outstanding Stale Chqs/Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Debit Transfer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Bank Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stale Chqs Reversed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Interest Received"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Transfer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account"
        '
        'cboAccount
        '
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(91, 24)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(719, 28)
        Me.cboAccount.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboYears)
        Me.GroupBox2.Controls.Add(Me.cboMonths)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(798, 75)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Duration"
        '
        'cboYears
        '
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(405, 25)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(387, 28)
        Me.cboYears.TabIndex = 2
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(6, 25)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(393, 28)
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
        Me.GroupBox3.Location = New System.Drawing.Point(417, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 156)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bank Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Items In Cash Book Not Bank"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Uncredited Lodgements"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Items In Bank Not Cash Book"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Unpresent Chqs"
        '
        'txtItemsInCashBookNotBank
        '
        Me.txtItemsInCashBookNotBank.Location = New System.Drawing.Point(220, 118)
        Me.txtItemsInCashBookNotBank.Name = "txtItemsInCashBookNotBank"
        Me.txtItemsInCashBookNotBank.Size = New System.Drawing.Size(173, 26)
        Me.txtItemsInCashBookNotBank.TabIndex = 12
        '
        'txtUncreditedLodgement
        '
        Me.txtUncreditedLodgement.Location = New System.Drawing.Point(220, 86)
        Me.txtUncreditedLodgement.Name = "txtUncreditedLodgement"
        Me.txtUncreditedLodgement.Size = New System.Drawing.Size(173, 26)
        Me.txtUncreditedLodgement.TabIndex = 11
        '
        'txtItemsInBankNotCashBook
        '
        Me.txtItemsInBankNotCashBook.Location = New System.Drawing.Point(220, 54)
        Me.txtItemsInBankNotCashBook.Name = "txtItemsInBankNotCashBook"
        Me.txtItemsInBankNotCashBook.Size = New System.Drawing.Size(173, 26)
        Me.txtItemsInBankNotCashBook.TabIndex = 10
        '
        'txtUnpresentedChqs
        '
        Me.txtUnpresentedChqs.Location = New System.Drawing.Point(220, 22)
        Me.txtUnpresentedChqs.Name = "txtUnpresentedChqs"
        Me.txtUnpresentedChqs.Size = New System.Drawing.Size(173, 26)
        Me.txtUnpresentedChqs.TabIndex = 9
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(417, 301)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(135, 38)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(558, 301)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(127, 38)
        Me.btnUndo.TabIndex = 14
        Me.btnUndo.Text = "&Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(691, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 38)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(417, 345)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(399, 38)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmBankReconcilation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 390)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
