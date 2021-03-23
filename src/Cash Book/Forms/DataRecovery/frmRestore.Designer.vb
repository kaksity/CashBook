<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestore))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnStartProcess = New crsButton.cButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path"
        '
        'lblPath
        '
        Me.lblPath.BackColor = System.Drawing.Color.White
        Me.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath.Location = New System.Drawing.Point(61, 10)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(371, 23)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Status"
        '
        'btnLocation
        '
        Me.btnLocation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocation.Location = New System.Drawing.Point(234, 70)
        Me.btnLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(187, 41)
        Me.btnLocation.TabIndex = 2
        Me.btnLocation.Text = "&Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(61, 40)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(371, 20)
        Me.lblStatus.TabIndex = 3
        '
        'btnStartProcess
        '
        Me.btnStartProcess.BackColor = System.Drawing.Color.Transparent
        Me.btnStartProcess.ButtonType = crsButton.cButton.btnType.startprocessing
        Me.btnStartProcess.FlatAppearance.BorderSize = 0
        Me.btnStartProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStartProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartProcess.Image = CType(resources.GetObject("btnStartProcess.Image"), System.Drawing.Image)
        Me.btnStartProcess.Location = New System.Drawing.Point(61, 62)
        Me.btnStartProcess.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(169, 48)
        Me.btnStartProcess.TabIndex = 4
        Me.btnStartProcess.UseVisualStyleBackColor = False
        '
        'frmRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 118)
        Me.Controls.Add(Me.btnStartProcess)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRestore"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLocation As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStartProcess As crsButton.cButton
End Class
