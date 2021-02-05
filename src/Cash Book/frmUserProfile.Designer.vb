<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserProfile))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.txtSecurityQuestion = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(162, 316)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(433, 26)
        Me.txtPassword.TabIndex = 11
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(162, 191)
        Me.txtSecurityAnswer.Multiline = True
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(433, 119)
        Me.txtSecurityAnswer.TabIndex = 12
        '
        'txtSecurityQuestion
        '
        Me.txtSecurityQuestion.Location = New System.Drawing.Point(162, 159)
        Me.txtSecurityQuestion.Name = "txtSecurityQuestion"
        Me.txtSecurityQuestion.Size = New System.Drawing.Size(433, 26)
        Me.txtSecurityQuestion.TabIndex = 13
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(162, 127)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(433, 26)
        Me.txtEmailAddress.TabIndex = 14
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(162, 95)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(433, 26)
        Me.txtTelephoneNumber.TabIndex = 15
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(162, 63)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(433, 26)
        Me.txtFullName.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Security Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Security Question"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Email Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Telephone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Full Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Username"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(162, 348)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(137, 38)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(316, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 38)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(469, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 38)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Location = New System.Drawing.Point(162, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(433, 32)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.Color.White
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPhoto.Location = New System.Drawing.Point(601, 22)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(250, 250)
        Me.picPhoto.TabIndex = 18
        Me.picPhoto.TabStop = False
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.Location = New System.Drawing.Point(601, 292)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(250, 47)
        Me.btnAddPhoto.TabIndex = 19
        Me.btnAddPhoto.Text = "&Add Photo"
        Me.btnAddPhoto.UseVisualStyleBackColor = True
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 409)
        Me.Controls.Add(Me.btnAddPhoto)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtSecurityAnswer)
        Me.Controls.Add(Me.txtSecurityQuestion)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtTelephoneNumber)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - User Profile"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents txtSecurityQuestion As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtTelephoneNumber As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents btnAddPhoto As Button
End Class
