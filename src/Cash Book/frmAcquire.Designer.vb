<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcquire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcquire))
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnAcquire = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.chkDialog = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Slider = New System.Windows.Forms.TrackBar()
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.grpFlip = New System.Windows.Forms.GroupBox()
        Me.btnHorizontal = New System.Windows.Forms.Button()
        Me.btnVertical = New System.Windows.Forms.Button()
        Me.btnClearPreview = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFlip.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPhoto
        '
        Me.picPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPhoto.BackColor = System.Drawing.Color.White
        Me.picPhoto.Location = New System.Drawing.Point(5, 6)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(630, 439)
        Me.picPhoto.TabIndex = 0
        Me.picPhoto.TabStop = False
        '
        'btnAcquire
        '
        Me.btnAcquire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcquire.BackColor = System.Drawing.Color.White
        Me.btnAcquire.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnAcquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcquire.Location = New System.Drawing.Point(640, 59)
        Me.btnAcquire.Name = "btnAcquire"
        Me.btnAcquire.Size = New System.Drawing.Size(140, 32)
        Me.btnAcquire.TabIndex = 1
        Me.btnAcquire.Text = "&Acquire"
        Me.btnAcquire.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.Color.White
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Location = New System.Drawing.Point(640, 97)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(140, 32)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Select Source"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'chkDialog
        '
        Me.chkDialog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDialog.AutoSize = True
        Me.chkDialog.Location = New System.Drawing.Point(643, 30)
        Me.chkDialog.Name = "chkDialog"
        Me.chkDialog.Size = New System.Drawing.Size(138, 17)
        Me.chkDialog.TabIndex = 2
        Me.chkDialog.Text = "Show Scanner Window"
        Me.chkDialog.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.Color.White
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(641, 451)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(139, 32)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.BackColor = System.Drawing.Color.White
        Me.OK.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(641, 413)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(140, 32)
        Me.OK.TabIndex = 6
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Slider
        '
        Me.Slider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Slider.LargeChange = 1
        Me.Slider.Location = New System.Drawing.Point(5, 453)
        Me.Slider.Maximum = 100
        Me.Slider.Minimum = 1
        Me.Slider.Name = "Slider"
        Me.Slider.Size = New System.Drawing.Size(611, 45)
        Me.Slider.TabIndex = 8
        Me.Slider.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Slider.Value = 100
        '
        'chkFile
        '
        Me.chkFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFile.AutoSize = True
        Me.chkFile.Location = New System.Drawing.Point(643, 7)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Size = New System.Drawing.Size(95, 17)
        Me.chkFile.TabIndex = 2
        Me.chkFile.Text = "Load From File"
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'picPreview
        '
        Me.picPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreview.Location = New System.Drawing.Point(640, 220)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(140, 140)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreview.TabIndex = 9
        Me.picPreview.TabStop = False
        '
        'grpFlip
        '
        Me.grpFlip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFlip.Controls.Add(Me.btnHorizontal)
        Me.grpFlip.Controls.Add(Me.btnVertical)
        Me.grpFlip.Location = New System.Drawing.Point(640, 146)
        Me.grpFlip.Name = "grpFlip"
        Me.grpFlip.Size = New System.Drawing.Size(140, 68)
        Me.grpFlip.TabIndex = 10
        Me.grpFlip.TabStop = False
        Me.grpFlip.Text = "Flip Image"
        '
        'btnHorizontal
        '
        Me.btnHorizontal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHorizontal.BackColor = System.Drawing.Color.White
        Me.btnHorizontal.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorizontal.Location = New System.Drawing.Point(14, 22)
        Me.btnHorizontal.Name = "btnHorizontal"
        Me.btnHorizontal.Size = New System.Drawing.Size(43, 32)
        Me.btnHorizontal.TabIndex = 13
        Me.btnHorizontal.Text = "H"
        Me.btnHorizontal.UseVisualStyleBackColor = False
        '
        'btnVertical
        '
        Me.btnVertical.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVertical.BackColor = System.Drawing.Color.White
        Me.btnVertical.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVertical.Location = New System.Drawing.Point(87, 22)
        Me.btnVertical.Name = "btnVertical"
        Me.btnVertical.Size = New System.Drawing.Size(43, 32)
        Me.btnVertical.TabIndex = 12
        Me.btnVertical.Text = "V"
        Me.btnVertical.UseVisualStyleBackColor = False
        '
        'btnClearPreview
        '
        Me.btnClearPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearPreview.BackColor = System.Drawing.Color.White
        Me.btnClearPreview.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnClearPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPreview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPreview.Location = New System.Drawing.Point(641, 366)
        Me.btnClearPreview.Name = "btnClearPreview"
        Me.btnClearPreview.Size = New System.Drawing.Size(140, 23)
        Me.btnClearPreview.TabIndex = 11
        Me.btnClearPreview.Text = "Clear &Preview"
        Me.btnClearPreview.UseVisualStyleBackColor = False
        '
        'frmAcquire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 495)
        Me.Controls.Add(Me.btnClearPreview)
        Me.Controls.Add(Me.grpFlip)
        Me.Controls.Add(Me.picPreview)
        Me.Controls.Add(Me.Slider)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.chkFile)
        Me.Controls.Add(Me.chkDialog)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnAcquire)
        Me.Controls.Add(Me.picPhoto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcquire"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acquire Image"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFlip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnAcquire As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents chkDialog As System.Windows.Forms.CheckBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Slider As System.Windows.Forms.TrackBar
    Friend WithEvents chkFile As System.Windows.Forms.CheckBox
    Friend WithEvents picPreview As System.Windows.Forms.PictureBox
    Friend WithEvents grpFlip As System.Windows.Forms.GroupBox
    Friend WithEvents btnHorizontal As System.Windows.Forms.Button
    Friend WithEvents btnVertical As System.Windows.Forms.Button
    Friend WithEvents btnClearPreview As System.Windows.Forms.Button
End Class
