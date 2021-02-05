<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddSupportingDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSupportingDocument))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddDocument = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtDocumentDescription = New System.Windows.Forms.TextBox()
        Me.txtNameOfDocument = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picDocument = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAddDocument)
        Me.GroupBox1.Controls.Add(Me.btnUndo)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.txtDocumentDescription)
        Me.GroupBox1.Controls.Add(Me.txtNameOfDocument)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Document"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(343, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 36)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddDocument
        '
        Me.btnAddDocument.Location = New System.Drawing.Point(167, 215)
        Me.btnAddDocument.Name = "btnAddDocument"
        Me.btnAddDocument.Size = New System.Drawing.Size(250, 36)
        Me.btnAddDocument.TabIndex = 2
        Me.btnAddDocument.Text = "&Add Document"
        Me.btnAddDocument.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(258, 173)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(79, 36)
        Me.btnUndo.TabIndex = 2
        Me.btnUndo.Text = "&Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(167, 173)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 36)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(88, 215)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 36)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(88, 173)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(73, 36)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtDocumentDescription
        '
        Me.txtDocumentDescription.Location = New System.Drawing.Point(88, 57)
        Me.txtDocumentDescription.Multiline = True
        Me.txtDocumentDescription.Name = "txtDocumentDescription"
        Me.txtDocumentDescription.Size = New System.Drawing.Size(329, 110)
        Me.txtDocumentDescription.TabIndex = 1
        '
        'txtNameOfDocument
        '
        Me.txtNameOfDocument.Location = New System.Drawing.Point(88, 25)
        Me.txtNameOfDocument.Name = "txtNameOfDocument"
        Me.txtNameOfDocument.Size = New System.Drawing.Size(329, 26)
        Me.txtNameOfDocument.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'picDocument
        '
        Me.picDocument.BackColor = System.Drawing.Color.White
        Me.picDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDocument.Location = New System.Drawing.Point(441, 22)
        Me.picDocument.Name = "picDocument"
        Me.picDocument.Size = New System.Drawing.Size(630, 439)
        Me.picDocument.TabIndex = 1
        Me.picDocument.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 267)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View Document"
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(6, 25)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(411, 236)
        Me.grid.TabIndex = 0
        '
        'frmAddSupportingDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.picDocument)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSupportingDocument"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Supporting Document"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picDocument As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNameOfDocument As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDocumentDescription As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
