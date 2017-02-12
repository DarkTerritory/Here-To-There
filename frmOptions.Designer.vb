<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.TabOptions = New System.Windows.Forms.TabControl
        Me.tbpUser = New System.Windows.Forms.TabPage
        Me.txtScreenWidth = New System.Windows.Forms.TextBox
        Me.lblScreenWidth = New System.Windows.Forms.Label
        Me.txtScreenHeight = New System.Windows.Forms.TextBox
        Me.lblScreenHeight = New System.Windows.Forms.Label
        Me.cmdSaveScreenDimensions = New System.Windows.Forms.Button
        Me.tbpSystem = New System.Windows.Forms.TabPage
        Me.tmrOptions = New System.Windows.Forms.Timer(Me.components)
        Me.TabOptions.SuspendLayout()
        Me.tbpUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabOptions
        '
        Me.TabOptions.Controls.Add(Me.tbpUser)
        Me.TabOptions.Controls.Add(Me.tbpSystem)
        Me.TabOptions.Location = New System.Drawing.Point(12, 60)
        Me.TabOptions.Name = "TabOptions"
        Me.TabOptions.SelectedIndex = 0
        Me.TabOptions.Size = New System.Drawing.Size(731, 331)
        Me.TabOptions.TabIndex = 0
        '
        'tbpUser
        '
        Me.tbpUser.BackColor = System.Drawing.SystemColors.Control
        Me.tbpUser.Controls.Add(Me.txtScreenWidth)
        Me.tbpUser.Controls.Add(Me.lblScreenWidth)
        Me.tbpUser.Controls.Add(Me.txtScreenHeight)
        Me.tbpUser.Controls.Add(Me.lblScreenHeight)
        Me.tbpUser.Controls.Add(Me.cmdSaveScreenDimensions)
        Me.tbpUser.Location = New System.Drawing.Point(4, 22)
        Me.tbpUser.Name = "tbpUser"
        Me.tbpUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUser.Size = New System.Drawing.Size(723, 305)
        Me.tbpUser.TabIndex = 0
        Me.tbpUser.Text = "User Options"
        '
        'txtScreenWidth
        '
        Me.txtScreenWidth.Location = New System.Drawing.Point(142, 40)
        Me.txtScreenWidth.Name = "txtScreenWidth"
        Me.txtScreenWidth.Size = New System.Drawing.Size(75, 20)
        Me.txtScreenWidth.TabIndex = 5
        '
        'lblScreenWidth
        '
        Me.lblScreenWidth.AutoSize = True
        Me.lblScreenWidth.Location = New System.Drawing.Point(21, 43)
        Me.lblScreenWidth.Name = "lblScreenWidth"
        Me.lblScreenWidth.Size = New System.Drawing.Size(112, 13)
        Me.lblScreenWidth.TabIndex = 4
        Me.lblScreenWidth.Text = "Primary Screen Width:"
        Me.lblScreenWidth.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtScreenHeight
        '
        Me.txtScreenHeight.Location = New System.Drawing.Point(142, 20)
        Me.txtScreenHeight.Name = "txtScreenHeight"
        Me.txtScreenHeight.Size = New System.Drawing.Size(75, 20)
        Me.txtScreenHeight.TabIndex = 3
        '
        'lblScreenHeight
        '
        Me.lblScreenHeight.AutoSize = True
        Me.lblScreenHeight.Location = New System.Drawing.Point(21, 23)
        Me.lblScreenHeight.Name = "lblScreenHeight"
        Me.lblScreenHeight.Size = New System.Drawing.Size(115, 13)
        Me.lblScreenHeight.TabIndex = 1
        Me.lblScreenHeight.Text = "Primary Screen Height:"
        Me.lblScreenHeight.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdSaveScreenDimensions
        '
        Me.cmdSaveScreenDimensions.Location = New System.Drawing.Point(24, 66)
        Me.cmdSaveScreenDimensions.Name = "cmdSaveScreenDimensions"
        Me.cmdSaveScreenDimensions.Size = New System.Drawing.Size(193, 23)
        Me.cmdSaveScreenDimensions.TabIndex = 0
        Me.cmdSaveScreenDimensions.Text = "Save Screen Size"
        Me.cmdSaveScreenDimensions.UseVisualStyleBackColor = True
        '
        'tbpSystem
        '
        Me.tbpSystem.BackColor = System.Drawing.SystemColors.Control
        Me.tbpSystem.Location = New System.Drawing.Point(4, 22)
        Me.tbpSystem.Name = "tbpSystem"
        Me.tbpSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSystem.Size = New System.Drawing.Size(723, 305)
        Me.tbpSystem.TabIndex = 1
        Me.tbpSystem.Text = "System Options"
        '
        'tmrOptions
        '
        Me.tmrOptions.Interval = 1000
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 466)
        Me.Controls.Add(Me.TabOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Text = "Here To There - Options"
        Me.TabOptions.ResumeLayout(False)
        Me.tbpUser.ResumeLayout(False)
        Me.tbpUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabOptions As System.Windows.Forms.TabControl
    Friend WithEvents tbpUser As System.Windows.Forms.TabPage
    Friend WithEvents tbpSystem As System.Windows.Forms.TabPage
    Friend WithEvents txtScreenHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblScreenHeight As System.Windows.Forms.Label
    Friend WithEvents cmdSaveScreenDimensions As System.Windows.Forms.Button
    Friend WithEvents tmrOptions As System.Windows.Forms.Timer
    Friend WithEvents txtScreenWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblScreenWidth As System.Windows.Forms.Label
End Class
