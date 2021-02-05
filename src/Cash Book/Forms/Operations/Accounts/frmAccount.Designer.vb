<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.dtpOpeningDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNew = New crsButton.cButton()
        Me.btnEdit = New crsButton.cButton()
        Me.btnUndo = New crsButton.cButton()
        Me.btnDelete = New crsButton.cButton()
        Me.btnSave = New crsButton.cButton()
        Me.btnPrint = New crsButton.cButton()
        Me.btnFind = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 18)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(523, 22)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Opening Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Current Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bank Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Opening Date"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(127, 44)
        Me.txtAccountNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(523, 22)
        Me.txtAccountNumber.TabIndex = 1
        '
        'dtpOpeningDate
        '
        Me.dtpOpeningDate.CustomFormat = "dd/M/yyyy"
        Me.dtpOpeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOpeningDate.Location = New System.Drawing.Point(127, 69)
        Me.dtpOpeningDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpOpeningDate.Name = "dtpOpeningDate"
        Me.dtpOpeningDate.Size = New System.Drawing.Size(523, 22)
        Me.dtpOpeningDate.TabIndex = 2
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(127, 100)
        Me.txtBankName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(523, 22)
        Me.txtBankName.TabIndex = 3
        '
        'txtOpeningBalance
        '
        Me.txtOpeningBalance.Location = New System.Drawing.Point(127, 205)
        Me.txtOpeningBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOpeningBalance.Name = "txtOpeningBalance"
        Me.txtOpeningBalance.Size = New System.Drawing.Size(523, 22)
        Me.txtOpeningBalance.TabIndex = 5
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.BackColor = System.Drawing.Color.White
        Me.lblCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentBalance.Location = New System.Drawing.Point(127, 228)
        Me.lblCurrentBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(522, 32)
        Me.lblCurrentBalance.TabIndex = 0
        Me.lblCurrentBalance.Text = "Current Balance"
        Me.lblCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(127, 125)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(523, 75)
        Me.txtDescription.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Description"
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
        Me.btnNew.Location = New System.Drawing.Point(18, 278)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(85, 45)
        Me.btnNew.TabIndex = 13
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(109, 278)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 45)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnUndo.Location = New System.Drawing.Point(200, 278)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(85, 45)
        Me.btnUndo.TabIndex = 13
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.ButtonType = crsButton.cButton.btnType.remove
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(564, 278)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 45)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(473, 278)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.ButtonType = crsButton.cButton.btnType.print
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(382, 278)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 45)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Transparent
        Me.btnFind.ButtonType = crsButton.cButton.btnType.find
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(291, 278)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(85, 45)
        Me.btnFind.TabIndex = 13
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 340)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dtpOpeningDate)
        Me.Controls.Add(Me.txtOpeningBalance)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents dtpOpeningDate As DateTimePicker
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents txtOpeningBalance As TextBox
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNew As crsButton.cButton
    Friend WithEvents btnEdit As crsButton.cButton
    Friend WithEvents btnUndo As crsButton.cButton
    Friend WithEvents btnDelete As crsButton.cButton
    Friend WithEvents btnSave As crsButton.cButton
    Friend WithEvents btnPrint As crsButton.cButton
    Friend WithEvents btnFind As crsButton.cButton
End Class
