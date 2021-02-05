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
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(137, 29)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(339, 26)
        Me.txtUsername.TabIndex = 0
        '
        'txtSecurityQuestion
        '
        Me.txtSecurityQuestion.Enabled = False
        Me.txtSecurityQuestion.Location = New System.Drawing.Point(137, 61)
        Me.txtSecurityQuestion.Name = "txtSecurityQuestion"
        Me.txtSecurityQuestion.ReadOnly = True
        Me.txtSecurityQuestion.Size = New System.Drawing.Size(339, 26)
        Me.txtSecurityQuestion.TabIndex = 1
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(137, 93)
        Me.txtSecurityAnswer.Multiline = True
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(339, 124)
        Me.txtSecurityAnswer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Security Question"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Security Answer"
        '
        'btnCheckUsername
        '
        Me.btnCheckUsername.Location = New System.Drawing.Point(137, 223)
        Me.btnCheckUsername.Name = "btnCheckUsername"
        Me.btnCheckUsername.Size = New System.Drawing.Size(168, 42)
        Me.btnCheckUsername.TabIndex = 2
        Me.btnCheckUsername.Text = "&Check Username"
        Me.btnCheckUsername.UseVisualStyleBackColor = True
        '
        'btnGeneratePassword
        '
        Me.btnGeneratePassword.Location = New System.Drawing.Point(311, 223)
        Me.btnGeneratePassword.Name = "btnGeneratePassword"
        Me.btnGeneratePassword.Size = New System.Drawing.Size(168, 42)
        Me.btnGeneratePassword.TabIndex = 3
        Me.btnGeneratePassword.Text = "&Generate Password"
        Me.btnGeneratePassword.UseVisualStyleBackColor = True
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 279)
        Me.Controls.Add(Me.btnGeneratePassword)
        Me.Controls.Add(Me.btnCheckUsername)
        Me.Controls.Add(Me.txtSecurityAnswer)
        Me.Controls.Add(Me.txtSecurityQuestion)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
