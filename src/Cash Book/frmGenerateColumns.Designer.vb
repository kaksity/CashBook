<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateColumns))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAccounts = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account"
        '
        'cboAccounts
        '
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.Location = New System.Drawing.Point(88, 21)
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(269, 28)
        Me.cboAccounts.TabIndex = 1
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(88, 55)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(269, 28)
        Me.cboMonths.TabIndex = 2
        '
        'cboYears
        '
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(88, 89)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(269, 28)
        Me.cboYears.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Year"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(88, 123)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(269, 41)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmGenerateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 173)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.cboYears)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.cboAccounts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerateColumns"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Generate Column Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboAccounts As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGenerate As Button
End Class
