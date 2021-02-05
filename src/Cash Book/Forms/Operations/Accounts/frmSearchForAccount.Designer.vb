<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchForAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchForAccount))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAccountName = New System.Windows.Forms.RadioButton()
        Me.rbAccountNumber = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchResult = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New crsButton.cButton()
        Me.btnOkay = New crsButton.cButton()
        Me.lblNumberOfFoundRecord = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSearchResult)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.rbAccountNumber)
        Me.GroupBox1.Controls.Add(Me.rbAccountName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'rbAccountName
        '
        Me.rbAccountName.AutoSize = True
        Me.rbAccountName.Location = New System.Drawing.Point(6, 74)
        Me.rbAccountName.Name = "rbAccountName"
        Me.rbAccountName.Size = New System.Drawing.Size(60, 20)
        Me.rbAccountName.TabIndex = 0
        Me.rbAccountName.TabStop = True
        Me.rbAccountName.Text = "Name"
        Me.rbAccountName.UseVisualStyleBackColor = True
        '
        'rbAccountNumber
        '
        Me.rbAccountNumber.AutoSize = True
        Me.rbAccountNumber.Location = New System.Drawing.Point(72, 74)
        Me.rbAccountNumber.Name = "rbAccountNumber"
        Me.rbAccountNumber.Size = New System.Drawing.Size(71, 20)
        Me.rbAccountNumber.TabIndex = 1
        Me.rbAccountNumber.TabStop = True
        Me.rbAccountNumber.Text = "Number"
        Me.rbAccountNumber.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(149, 72)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(254, 22)
        Me.txtSearch.TabIndex = 2
        '
        'lblSearchResult
        '
        Me.lblSearchResult.BackColor = System.Drawing.Color.White
        Me.lblSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSearchResult.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResult.Location = New System.Drawing.Point(6, 18)
        Me.lblSearchResult.Name = "lblSearchResult"
        Me.lblSearchResult.Size = New System.Drawing.Size(397, 51)
        Me.lblSearchResult.TabIndex = 3
        Me.lblSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 118)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(409, 214)
        Me.grid.TabIndex = 1
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
        Me.btnCancel.Location = New System.Drawing.Point(336, 338)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 45)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOkay
        '
        Me.btnOkay.BackColor = System.Drawing.Color.Transparent
        Me.btnOkay.ButtonType = crsButton.cButton.btnType.ok
        Me.btnOkay.FlatAppearance.BorderSize = 0
        Me.btnOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkay.Image = CType(resources.GetObject("btnOkay.Image"), System.Drawing.Image)
        Me.btnOkay.Location = New System.Drawing.Point(245, 338)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(85, 45)
        Me.btnOkay.TabIndex = 2
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'lblNumberOfFoundRecord
        '
        Me.lblNumberOfFoundRecord.BackColor = System.Drawing.Color.White
        Me.lblNumberOfFoundRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfFoundRecord.Location = New System.Drawing.Point(9, 338)
        Me.lblNumberOfFoundRecord.Name = "lblNumberOfFoundRecord"
        Me.lblNumberOfFoundRecord.Size = New System.Drawing.Size(230, 45)
        Me.lblNumberOfFoundRecord.TabIndex = 3
        Me.lblNumberOfFoundRecord.Text = "Label1"
        Me.lblNumberOfFoundRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSearchForAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 397)
        Me.Controls.Add(Me.lblNumberOfFoundRecord)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchForAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Search Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rbAccountNumber As RadioButton
    Friend WithEvents rbAccountName As RadioButton
    Friend WithEvents lblSearchResult As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents btnCancel As crsButton.cButton
    Friend WithEvents btnOkay As crsButton.cButton
    Friend WithEvents lblNumberOfFoundRecord As Label
End Class
