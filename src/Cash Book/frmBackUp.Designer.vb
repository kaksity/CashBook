<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackUp))
        Me.btnLocation = New System.Windows.Forms.Button()
        Me.btnStartProcess = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLocation
        '
        Me.btnLocation.Location = New System.Drawing.Point(314, 82)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.Size = New System.Drawing.Size(241, 42)
        Me.btnLocation.TabIndex = 7
        Me.btnLocation.Text = "&Location"
        Me.btnLocation.UseVisualStyleBackColor = True
        '
        'btnStartProcess
        '
        Me.btnStartProcess.Location = New System.Drawing.Point(78, 82)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(230, 42)
        Me.btnStartProcess.TabIndex = 8
        Me.btnStartProcess.Text = "&Start Process"
        Me.btnStartProcess.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.BackColor = System.Drawing.Color.White
        Me.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath.Location = New System.Drawing.Point(78, 13)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(477, 29)
        Me.lblPath.TabIndex = 3
        Me.lblPath.Text = "Path"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Path"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(78, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(477, 30)
        Me.lblStatus.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Status"
        '
        'frmBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 137)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnStartProcess)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackUp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book - Back Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLocation As Button
    Friend WithEvents btnStartProcess As Button
    Friend WithEvents lblPath As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
End Class
