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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CButton1 = New crsButton.cButton()
        Me.CButton2 = New crsButton.cButton()
        Me.CButton3 = New crsButton.cButton()
        Me.CButton4 = New crsButton.cButton()
        Me.CButton5 = New crsButton.cButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 22)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(463, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 484)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 153)
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
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(110, 113)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(275, 24)
        Me.ComboBox4.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Term"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Class"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(110, 83)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(275, 24)
        Me.ComboBox3.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(110, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(275, 24)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(275, 24)
        Me.ComboBox1.TabIndex = 7
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
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 55)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'CButton1
        '
        Me.CButton1.BackColor = System.Drawing.Color.Transparent
        Me.CButton1.ButtonType = crsButton.cButton.btnType.new_
        Me.CButton1.FlatAppearance.BorderSize = 0
        Me.CButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton1.Image = CType(resources.GetObject("CButton1.Image"), System.Drawing.Image)
        Me.CButton1.Location = New System.Drawing.Point(12, 232)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(85, 45)
        Me.CButton1.TabIndex = 10
        Me.CButton1.UseVisualStyleBackColor = False
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
        Me.CButton2.Location = New System.Drawing.Point(99, 232)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.Size = New System.Drawing.Size(85, 45)
        Me.CButton2.TabIndex = 10
        Me.CButton2.UseVisualStyleBackColor = False
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
        Me.CButton3.Location = New System.Drawing.Point(190, 232)
        Me.CButton3.Name = "CButton3"
        Me.CButton3.Size = New System.Drawing.Size(85, 45)
        Me.CButton3.TabIndex = 10
        Me.CButton3.UseVisualStyleBackColor = False
        '
        'CButton4
        '
        Me.CButton4.BackColor = System.Drawing.Color.Transparent
        Me.CButton4.ButtonType = crsButton.cButton.btnType.save
        Me.CButton4.FlatAppearance.BorderSize = 0
        Me.CButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton4.Image = CType(resources.GetObject("CButton4.Image"), System.Drawing.Image)
        Me.CButton4.Location = New System.Drawing.Point(281, 232)
        Me.CButton4.Name = "CButton4"
        Me.CButton4.Size = New System.Drawing.Size(85, 45)
        Me.CButton4.TabIndex = 10
        Me.CButton4.UseVisualStyleBackColor = False
        '
        'CButton5
        '
        Me.CButton5.BackColor = System.Drawing.Color.Transparent
        Me.CButton5.ButtonType = crsButton.cButton.btnType.remove
        Me.CButton5.FlatAppearance.BorderSize = 0
        Me.CButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton5.Image = CType(resources.GetObject("CButton5.Image"), System.Drawing.Image)
        Me.CButton5.Location = New System.Drawing.Point(372, 232)
        Me.CButton5.Name = "CButton5"
        Me.CButton5.Size = New System.Drawing.Size(85, 45)
        Me.CButton5.TabIndex = 11
        Me.CButton5.UseVisualStyleBackColor = False
        '
        'frmRegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 508)
        Me.Controls.Add(Me.CButton5)
        Me.Controls.Add(Me.CButton4)
        Me.Controls.Add(Me.CButton3)
        Me.Controls.Add(Me.CButton2)
        Me.Controls.Add(Me.CButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRegisterStudent"
        Me.Text = "Cash Book - Register Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CButton1 As crsButton.cButton
    Friend WithEvents CButton2 As crsButton.cButton
    Friend WithEvents CButton3 As crsButton.cButton
    Friend WithEvents CButton4 As crsButton.cButton
    Friend WithEvents CButton5 As crsButton.cButton
End Class
