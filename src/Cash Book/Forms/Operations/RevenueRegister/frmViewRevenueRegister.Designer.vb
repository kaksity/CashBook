﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewRevenueRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewRevenueRegister))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoadAllData = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.cboAccounts = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New crsButton.cButton()
        Me.btnCancel = New crsButton.cButton()
        Me.btnAdd = New crsButton.cButton()
        Me.lblSelectedRecord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(9, 10)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(912, 327)
        Me.grid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoadAllData)
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.cboYears)
        Me.GroupBox1.Controls.Add(Me.cboMonths)
        Me.GroupBox1.Controls.Add(Me.cboAccounts)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 464)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(905, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnLoadAllData
        '
        Me.btnLoadAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadAllData.Location = New System.Drawing.Point(763, 16)
        Me.btnLoadAllData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadAllData.Name = "btnLoadAllData"
        Me.btnLoadAllData.Size = New System.Drawing.Size(138, 30)
        Me.btnLoadAllData.TabIndex = 2
        Me.btnLoadAllData.Text = "&Load All Data"
        Me.btnLoadAllData.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Location = New System.Drawing.Point(621, 16)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(137, 30)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(418, 20)
        Me.cboYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(200, 24)
        Me.cboYears.TabIndex = 0
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(214, 20)
        Me.cboMonths.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(200, 24)
        Me.cboMonths.TabIndex = 0
        '
        'cboAccounts
        '
        Me.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(10, 20)
        Me.cboAccounts.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(200, 24)
        Me.cboAccounts.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRemove)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.lblSelectedRecord)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 342)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(912, 118)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Supportting Document"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.ButtonType = crsButton.cButton.btnType.remove
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(716, 66)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(189, 39)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonType = crsButton.cButton.btnType.cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(816, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 45)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ButtonType = crsButton.cButton.btnType.add
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(716, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 38)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblSelectedRecord
        '
        Me.lblSelectedRecord.BackColor = System.Drawing.Color.White
        Me.lblSelectedRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSelectedRecord.Location = New System.Drawing.Point(115, 18)
        Me.lblSelectedRecord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedRecord.Name = "lblSelectedRecord"
        Me.lblSelectedRecord.Size = New System.Drawing.Size(596, 87)
        Me.lblSelectedRecord.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selected Record"
        '
        'frmViewRevenueRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 529)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewRevenueRegister"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - View Revenue Register"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnLoadAllData As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblSelectedRecord As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As crsButton.cButton
    Friend WithEvents btnCancel As crsButton.cButton
    Friend WithEvents btnRemove As crsButton.cButton
End Class
