<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSecurityQuestion = New System.Windows.Forms.TextBox()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCheckUsername = New System.Windows.Forms.Button()
        Me.btnGeneratePassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(121, 23)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(295, 22)
        Me.txtUsername.TabIndex = 0
        '
        'txtSecurityQuestion
        '
        Me.txtSecurityQuestion.Enabled = False
        Me.txtSecurityQuestion.Location = New System.Drawing.Point(121, 49)
        Me.txtSecurityQuestion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSecurityQuestion.Name = "txtSecurityQuestion"
        Me.txtSecurityQuestion.ReadOnly = True
        Me.txtSecurityQuestion.Size = New System.Drawing.Size(295, 22)
        Me.txtSecurityQuestion.TabIndex = 1
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(121, 74)
        Me.txtSecurityAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSecurityAnswer.Multiline = True
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(295, 100)
        Me.txtSecurityAnswer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Security Question"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Security Answer"
        '
        'btnCheckUsername
        '
        Me.btnCheckUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckUsername.Location = New System.Drawing.Point(121, 178)
        Me.btnCheckUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckUsername.Name = "btnCheckUsername"
        Me.btnCheckUsername.Size = New System.Drawing.Size(131, 34)
        Me.btnCheckUsername.TabIndex = 2
        Me.btnCheckUsername.Text = "&Check Username"
        Me.btnCheckUsername.UseVisualStyleBackColor = True
        '
        'btnGeneratePassword
        '
        Me.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePassword.Location = New System.Drawing.Point(285, 178)
        Me.btnGeneratePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneratePassword.Name = "btnGeneratePassword"
        Me.btnGeneratePassword.Size = New System.Drawing.Size(131, 34)
        Me.btnGeneratePassword.TabIndex = 3
        Me.btnGeneratePassword.Text = "&Generate Password"
        Me.btnGeneratePassword.UseVisualStyleBackColor = True
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 223)
        Me.Controls.Add(Me.btnGeneratePassword)
        Me.Controls.Add(Me.btnCheckUsername)
        Me.Controls.Add(Me.txtSecurityAnswer)
        Me.Controls.Add(Me.txtSecurityQuestion)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForgotPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtSecurityQuestion As TextBox
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCheckUsername As Button
    Friend WithEvents btnGeneratePassword As Button
End Class
