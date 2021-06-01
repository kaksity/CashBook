<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearGroupSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYearGroupSettings))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New crsButton.cButton()
        Me.BtnRemove = New crsButton.cButton()
        Me.BtnUndo = New crsButton.cButton()
        Me.BtnNew = New crsButton.cButton()
        Me.BtnEdit = New crsButton.cButton()
        Me.BtnSave = New crsButton.cButton()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(12, 15)
        Me.Grid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grid.Name = "Grid"
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(540, 370)
        Me.Grid.TabIndex = 9
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.ButtonType = crsButton.cButton.btnType.close2
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(467, 393)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(85, 55)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.BtnRemove.Location = New System.Drawing.Point(376, 393)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(85, 55)
        Me.BtnRemove.TabIndex = 5
        Me.BtnRemove.UseVisualStyleBackColor = False
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
        Me.BtnUndo.Location = New System.Drawing.Point(285, 393)
        Me.BtnUndo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(85, 55)
        Me.BtnUndo.TabIndex = 6
        Me.BtnUndo.UseVisualStyleBackColor = False
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
        Me.BtnNew.Location = New System.Drawing.Point(12, 393)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(85, 55)
        Me.BtnNew.TabIndex = 7
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
        Me.BtnEdit.Location = New System.Drawing.Point(103, 393)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(85, 55)
        Me.BtnEdit.TabIndex = 8
        Me.BtnEdit.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(194, 393)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 55)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'frmYearGroupSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 463)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSave)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmYearGroupSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year Group Section Settings"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DataGridView
    Friend WithEvents BtnClose As crsButton.cButton
    Friend WithEvents BtnRemove As crsButton.cButton
    Friend WithEvents BtnUndo As crsButton.cButton
    Friend WithEvents BtnNew As crsButton.cButton
    Friend WithEvents BtnEdit As crsButton.cButton
    Friend WithEvents BtnSave As crsButton.cButton
End Class
