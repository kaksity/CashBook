<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolFeesSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolFeesSettings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboYearGroup = New System.Windows.Forms.ComboBox()
        Me.CboTerm = New System.Windows.Forms.ComboBox()
        Me.CboAcademicSession = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSchoolFees = New System.Windows.Forms.TextBox()
        Me.BtnNew = New crsButton.cButton()
        Me.BtnSave = New crsButton.cButton()
        Me.BtnDelete = New crsButton.cButton()
        Me.BtnUndo = New crsButton.cButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboYearGroup)
        Me.GroupBox1.Controls.Add(Me.CboTerm)
        Me.GroupBox1.Controls.Add(Me.CboAcademicSession)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 153)
        Me.GroupBox1.TabIndex = 7
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Term"
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
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(409, 15)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(484, 283)
        Me.Grid.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtSchoolFees)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 58)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "School Fees"
        '
        'TxtSchoolFees
        '
        Me.TxtSchoolFees.Location = New System.Drawing.Point(110, 21)
        Me.TxtSchoolFees.Name = "TxtSchoolFees"
        Me.TxtSchoolFees.Size = New System.Drawing.Size(275, 22)
        Me.TxtSchoolFees.TabIndex = 0
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
        Me.BtnNew.Location = New System.Drawing.Point(12, 235)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(85, 45)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(194, 235)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 45)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.ButtonType = crsButton.cButton.btnType.remove
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(285, 235)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 45)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.UseVisualStyleBackColor = False
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
        Me.BtnUndo.Location = New System.Drawing.Point(103, 235)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(85, 45)
        Me.BtnUndo.TabIndex = 12
        Me.BtnUndo.UseVisualStyleBackColor = False
        '
        'frmSchoolFeesSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 310)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchoolFeesSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - School Fees Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CboYearGroup As ComboBox
    Friend WithEvents CboTerm As ComboBox
    Friend WithEvents CboAcademicSession As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtSchoolFees As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnNew As crsButton.cButton
    Friend WithEvents BtnSave As crsButton.cButton
    Friend WithEvents BtnDelete As crsButton.cButton
    Friend WithEvents BtnUndo As crsButton.cButton
End Class
