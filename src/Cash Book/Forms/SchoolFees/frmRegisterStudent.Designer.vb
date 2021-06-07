<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAdmissionNumber = New System.Windows.Forms.TextBox()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboClass = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboYearGroup = New System.Windows.Forms.ComboBox()
        Me.CboAcademicSession = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.BtnNew = New crsButton.cButton()
        Me.BtnEdit = New crsButton.cButton()
        Me.BtnUndo = New crsButton.cButton()
        Me.BtnSave = New crsButton.cButton()
        Me.BtnRemove = New crsButton.cButton()
        Me.BtnFind = New crsButton.cButton()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admission Number"
        '
        'TxtAdmissionNumber
        '
        Me.TxtAdmissionNumber.Location = New System.Drawing.Point(110, 21)
        Me.TxtAdmissionNumber.Name = "TxtAdmissionNumber"
        Me.TxtAdmissionNumber.Size = New System.Drawing.Size(329, 22)
        Me.TxtAdmissionNumber.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(463, 12)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(401, 484)
        Me.Grid.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CboClass)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboYearGroup)
        Me.GroupBox1.Controls.Add(Me.CboAcademicSession)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 177)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section / Class / Term"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Year Group"
        '
        'CboClass
        '
        Me.CboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClass.FormattingEnabled = True
        Me.CboClass.Location = New System.Drawing.Point(110, 83)
        Me.CboClass.Name = "CboClass"
        Me.CboClass.Size = New System.Drawing.Size(275, 24)
        Me.CboClass.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Class"
        '
        'CboYearGroup
        '
        Me.CboYearGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYearGroup.FormattingEnabled = True
        Me.CboYearGroup.Location = New System.Drawing.Point(110, 53)
        Me.CboYearGroup.Name = "CboYearGroup"
        Me.CboYearGroup.Size = New System.Drawing.Size(275, 24)
        Me.CboYearGroup.TabIndex = 8
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Academic Session"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtFullName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtAdmissionNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 85)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name"
        '
        'TxtFullName
        '
        Me.TxtFullName.Location = New System.Drawing.Point(110, 49)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(329, 22)
        Me.TxtFullName.TabIndex = 3
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnNew.ButtonType = crsButton.cButton.btnType.new_
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(12, 286)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(85, 45)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.ButtonType = crsButton.cButton.btnType.edit
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(99, 286)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(85, 45)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnUndo
        '
        Me.BtnUndo.BackColor = System.Drawing.Color.Transparent
        Me.BtnUndo.ButtonType = crsButton.cButton.btnType.undo
        Me.BtnUndo.FlatAppearance.BorderSize = 0
        Me.BtnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUndo.Image = CType(resources.GetObject("BtnUndo.Image"), System.Drawing.Image)
        Me.BtnUndo.Location = New System.Drawing.Point(190, 286)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(85, 45)
        Me.BtnUndo.TabIndex = 10
        Me.BtnUndo.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.ButtonType = crsButton.cButton.btnType.save
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(281, 286)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 45)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.Transparent
        Me.BtnRemove.ButtonType = crsButton.cButton.btnType.remove
        Me.BtnRemove.FlatAppearance.BorderSize = 0
        Me.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Image = CType(resources.GetObject("BtnRemove.Image"), System.Drawing.Image)
        Me.BtnRemove.Location = New System.Drawing.Point(372, 286)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(85, 45)
        Me.BtnRemove.TabIndex = 11
        Me.BtnRemove.UseVisualStyleBackColor = False
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
        Me.BtnFind.Location = New System.Drawing.Point(110, 113)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(85, 45)
        Me.BtnFind.TabIndex = 14
        Me.BtnFind.UseVisualStyleBackColor = False
        '
        'frmRegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 508)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegisterStudent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Register Student"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAdmissionNumber As TextBox
    Friend WithEvents Grid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CboClass As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboYearGroup As ComboBox
    Friend WithEvents CboAcademicSession As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnNew As crsButton.cButton
    Friend WithEvents BtnEdit As crsButton.cButton
    Friend WithEvents BtnUndo As crsButton.cButton
    Friend WithEvents BtnSave As crsButton.cButton
    Friend WithEvents BtnRemove As crsButton.cButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFullName As TextBox
    Friend WithEvents BtnFind As crsButton.cButton
End Class
