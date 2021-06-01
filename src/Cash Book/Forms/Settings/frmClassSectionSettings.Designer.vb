<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassSectionSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassSectionSettings))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.CButton5 = New crsButton.cButton()
        Me.CButton4 = New crsButton.cButton()
        Me.CButton3 = New crsButton.cButton()
        Me.CButton6 = New crsButton.cButton()
        Me.CButton2 = New crsButton.cButton()
        Me.CButton1 = New crsButton.cButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboYearGroup = New System.Windows.Forms.ComboBox()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(12, 57)
        Me.Grid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(540, 328)
        Me.Grid.TabIndex = 9
        '
        'CButton5
        '
        Me.CButton5.BackColor = System.Drawing.Color.Transparent
        Me.CButton5.ButtonType = crsButton.cButton.btnType.close2
        Me.CButton5.FlatAppearance.BorderSize = 0
        Me.CButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton5.Image = CType(resources.GetObject("CButton5.Image"), System.Drawing.Image)
        Me.CButton5.Location = New System.Drawing.Point(467, 393)
        Me.CButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton5.Name = "CButton5"
        Me.CButton5.Size = New System.Drawing.Size(85, 55)
        Me.CButton5.TabIndex = 4
        Me.CButton5.UseVisualStyleBackColor = False
        '
        'CButton4
        '
        Me.CButton4.BackColor = System.Drawing.Color.Transparent
        Me.CButton4.ButtonType = crsButton.cButton.btnType.remove
        Me.CButton4.FlatAppearance.BorderSize = 0
        Me.CButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton4.Image = CType(resources.GetObject("CButton4.Image"), System.Drawing.Image)
        Me.CButton4.Location = New System.Drawing.Point(376, 393)
        Me.CButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton4.Name = "CButton4"
        Me.CButton4.Size = New System.Drawing.Size(85, 55)
        Me.CButton4.TabIndex = 5
        Me.CButton4.UseVisualStyleBackColor = False
        '
        'CButton3
        '
        Me.CButton3.BackColor = System.Drawing.Color.Transparent
        Me.CButton3.ButtonType = crsButton.cButton.btnType.undo
        Me.CButton3.FlatAppearance.BorderSize = 0
        Me.CButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton3.Image = CType(resources.GetObject("CButton3.Image"), System.Drawing.Image)
        Me.CButton3.Location = New System.Drawing.Point(285, 393)
        Me.CButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton3.Name = "CButton3"
        Me.CButton3.Size = New System.Drawing.Size(85, 55)
        Me.CButton3.TabIndex = 6
        Me.CButton3.UseVisualStyleBackColor = False
        '
        'CButton6
        '
        Me.CButton6.BackColor = System.Drawing.Color.Transparent
        Me.CButton6.ButtonType = crsButton.cButton.btnType.new_
        Me.CButton6.FlatAppearance.BorderSize = 0
        Me.CButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton6.Image = CType(resources.GetObject("CButton6.Image"), System.Drawing.Image)
        Me.CButton6.Location = New System.Drawing.Point(12, 393)
        Me.CButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton6.Name = "CButton6"
        Me.CButton6.Size = New System.Drawing.Size(85, 55)
        Me.CButton6.TabIndex = 7
        Me.CButton6.UseVisualStyleBackColor = False
        '
        'CButton2
        '
        Me.CButton2.BackColor = System.Drawing.Color.Transparent
        Me.CButton2.ButtonType = crsButton.cButton.btnType.edit
        Me.CButton2.FlatAppearance.BorderSize = 0
        Me.CButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton2.Image = CType(resources.GetObject("CButton2.Image"), System.Drawing.Image)
        Me.CButton2.Location = New System.Drawing.Point(103, 393)
        Me.CButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.Size = New System.Drawing.Size(85, 55)
        Me.CButton2.TabIndex = 8
        Me.CButton2.UseVisualStyleBackColor = False
        '
        'CButton1
        '
        Me.CButton1.BackColor = System.Drawing.Color.Transparent
        Me.CButton1.ButtonType = crsButton.cButton.btnType.save
        Me.CButton1.FlatAppearance.BorderSize = 0
        Me.CButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton1.Image = CType(resources.GetObject("CButton1.Image"), System.Drawing.Image)
        Me.CButton1.Location = New System.Drawing.Point(194, 393)
        Me.CButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(85, 55)
        Me.CButton1.TabIndex = 3
        Me.CButton1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Year Group Section"
        '
        'CboYearGroup
        '
        Me.CboYearGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboYearGroup.FormattingEnabled = True
        Me.CboYearGroup.Location = New System.Drawing.Point(119, 18)
        Me.CboYearGroup.Name = "CboYearGroup"
        Me.CboYearGroup.Size = New System.Drawing.Size(433, 24)
        Me.CboYearGroup.TabIndex = 11
        '
        'frmClassSectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 463)
        Me.Controls.Add(Me.CboYearGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.CButton5)
        Me.Controls.Add(Me.CButton4)
        Me.Controls.Add(Me.CButton3)
        Me.Controls.Add(Me.CButton6)
        Me.Controls.Add(Me.CButton2)
        Me.Controls.Add(Me.CButton1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClassSectionSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Section Settings"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grid As DataGridView
    Friend WithEvents CButton5 As crsButton.cButton
    Friend WithEvents CButton4 As crsButton.cButton
    Friend WithEvents CButton3 As crsButton.cButton
    Friend WithEvents CButton6 As crsButton.cButton
    Friend WithEvents CButton2 As crsButton.cButton
    Friend WithEvents CButton1 As crsButton.cButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CboYearGroup As ComboBox
End Class
