<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolFees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolFees))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboClass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboYearGroup = New System.Windows.Forms.ComboBox()
        Me.CboTerm = New System.Windows.Forms.ComboBox()
        Me.CboAcademicSession = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDeduct = New crsButton.cButton()
        Me.BtnCancel = New crsButton.cButton()
        Me.BtnAccept = New crsButton.cButton()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAdmissionNumber = New System.Windows.Forms.Label()
        Me.TxtAmmountPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnFind = New crsButton.cButton()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(491, 12)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(423, 483)
        Me.Grid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CboClass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboYearGroup)
        Me.GroupBox1.Controls.Add(Me.CboTerm)
        Me.GroupBox1.Controls.Add(Me.CboAcademicSession)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 202)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section / Class / Term"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Year Group"
        '
        'CboClass
        '
        Me.CboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClass.FormattingEnabled = True
        Me.CboClass.Location = New System.Drawing.Point(110, 113)
        Me.CboClass.Name = "CboClass"
        Me.CboClass.Size = New System.Drawing.Size(275, 24)
        Me.CboClass.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Term"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Class"
        '
        'CboYearGroup
        '
        Me.CboYearGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYearGroup.FormattingEnabled = True
        Me.CboYearGroup.Location = New System.Drawing.Point(110, 83)
        Me.CboYearGroup.Name = "CboYearGroup"
        Me.CboYearGroup.Size = New System.Drawing.Size(275, 24)
        Me.CboYearGroup.TabIndex = 8
        '
        'CboTerm
        '
        Me.CboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTerm.FormattingEnabled = True
        Me.CboTerm.Location = New System.Drawing.Point(110, 53)
        Me.CboTerm.Name = "CboTerm"
        Me.CboTerm.Size = New System.Drawing.Size(275, 24)
        Me.CboTerm.TabIndex = 9
        '
        'CboAcademicSession
        '
        Me.CboAcademicSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAcademicSession.FormattingEnabled = True
        Me.CboAcademicSession.Location = New System.Drawing.Point(110, 23)
        Me.CboAcademicSession.Name = "CboAcademicSession"
        Me.CboAcademicSession.Size = New System.Drawing.Size(275, 24)
        Me.CboAcademicSession.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Academic Session"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnDeduct)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnAccept)
        Me.GroupBox2.Controls.Add(Me.lblFullName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblAdmissionNumber)
        Me.GroupBox2.Controls.Add(Me.TxtAmmountPaid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 248)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'BtnDeduct
        '
        Me.BtnDeduct.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeduct.ButtonType = crsButton.cButton.btnType.deductions
        Me.BtnDeduct.FlatAppearance.BorderSize = 0
        Me.BtnDeduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDeduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDeduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeduct.Image = CType(resources.GetObject("BtnDeduct.Image"), System.Drawing.Image)
        Me.BtnDeduct.Location = New System.Drawing.Point(292, 127)
        Me.BtnDeduct.Name = "BtnDeduct"
        Me.BtnDeduct.Size = New System.Drawing.Size(168, 60)
        Me.BtnDeduct.TabIndex = 9
        Me.BtnDeduct.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.ButtonType = crsButton.cButton.btnType.cancel
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(117, 193)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 45)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnAccept
        '
        Me.BtnAccept.BackColor = System.Drawing.Color.Transparent
        Me.BtnAccept.ButtonType = crsButton.cButton.btnType.accept
        Me.BtnAccept.FlatAppearance.BorderSize = 0
        Me.BtnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccept.Image = CType(resources.GetObject("BtnAccept.Image"), System.Drawing.Image)
        Me.BtnAccept.Location = New System.Drawing.Point(117, 127)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(169, 60)
        Me.BtnAccept.TabIndex = 8
        Me.BtnAccept.UseVisualStyleBackColor = False
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.White
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Location = New System.Drawing.Point(117, 63)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(274, 25)
        Me.lblFullName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ammount Paid"
        '
        'lblAdmissionNumber
        '
        Me.lblAdmissionNumber.BackColor = System.Drawing.Color.White
        Me.lblAdmissionNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdmissionNumber.Location = New System.Drawing.Point(117, 29)
        Me.lblAdmissionNumber.Name = "lblAdmissionNumber"
        Me.lblAdmissionNumber.Size = New System.Drawing.Size(274, 25)
        Me.lblAdmissionNumber.TabIndex = 3
        '
        'TxtAmmountPaid
        '
        Me.TxtAmmountPaid.Location = New System.Drawing.Point(117, 99)
        Me.TxtAmmountPaid.Name = "TxtAmmountPaid"
        Me.TxtAmmountPaid.Size = New System.Drawing.Size(274, 22)
        Me.TxtAmmountPaid.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Admission Number"
        '
        'BtnFind
        '
        Me.BtnFind.BackColor = System.Drawing.Color.Transparent
        Me.BtnFind.ButtonType = crsButton.cButton.btnType.find
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(110, 143)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(85, 45)
        Me.BtnFind.TabIndex = 14
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'frmSchoolFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 507)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchoolFees"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - School Fees"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboYearGroup As ComboBox
    Friend WithEvents CboTerm As ComboBox
    Friend WithEvents CboAcademicSession As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAdmissionNumber As Label
    Friend WithEvents TxtAmmountPaid As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents BtnAccept As crsButton.cButton
    Friend WithEvents BtnDeduct As crsButton.cButton
    Friend WithEvents Label8 As Label
    Friend WithEvents CboClass As ComboBox
    Friend WithEvents BtnCancel As crsButton.cButton
    Friend WithEvents BtnFind As crsButton.cButton
End Class
