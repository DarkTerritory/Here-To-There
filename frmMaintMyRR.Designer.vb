<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintMyRR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintMyRR))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.txtMaintMyRRPPwkDate = New System.Windows.Forms.TextBox
        Me.txtMaintMyRROpSessionDate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMaintMyRREra = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMaintMyRRSlogan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMaintMyRRState = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMaintMyRRRepMarks = New System.Windows.Forms.TextBox
        Me.lblMyRRName = New System.Windows.Forms.Label
        Me.txtMaintMyRRName = New System.Windows.Forms.TextBox
        Me.optPrototype = New System.Windows.Forms.RadioButton
        Me.OptFreelanced = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvRailroads = New System.Windows.Forms.DataGridView
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvRailroads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(328, 508)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(95, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(14, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
        '
        'txtMaintMyRRPPwkDate
        '
        Me.txtMaintMyRRPPwkDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRPPwkDate.Location = New System.Drawing.Point(220, 467)
        Me.txtMaintMyRRPPwkDate.Name = "txtMaintMyRRPPwkDate"
        Me.txtMaintMyRRPPwkDate.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRPPwkDate.TabIndex = 26
        '
        'txtMaintMyRROpSessionDate
        '
        Me.txtMaintMyRROpSessionDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRROpSessionDate.Location = New System.Drawing.Point(28, 467)
        Me.txtMaintMyRROpSessionDate.Name = "txtMaintMyRROpSessionDate"
        Me.txtMaintMyRROpSessionDate.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRROpSessionDate.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(220, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 32)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "The Date that should appear on Paperwork is:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(25, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 32)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "The Date of my next Operating session is:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "The Era my Railroad is set in is:"
        '
        'txtMaintMyRREra
        '
        Me.txtMaintMyRREra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRREra.Location = New System.Drawing.Point(220, 381)
        Me.txtMaintMyRREra.Name = "txtMaintMyRREra"
        Me.txtMaintMyRREra.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRREra.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "The Nickname or Slogan is:"
        '
        'txtMaintMyRRSlogan
        '
        Me.txtMaintMyRRSlogan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRSlogan.Location = New System.Drawing.Point(28, 309)
        Me.txtMaintMyRRSlogan.Name = "txtMaintMyRRSlogan"
        Me.txtMaintMyRRSlogan.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRSlogan.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "It operates in the State of:"
        Me.Label2.Visible = False
        '
        'txtMaintMyRRState
        '
        Me.txtMaintMyRRState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRState.Location = New System.Drawing.Point(28, 381)
        Me.txtMaintMyRRState.Name = "txtMaintMyRRState"
        Me.txtMaintMyRRState.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRState.TabIndex = 18
        Me.txtMaintMyRRState.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Its reporting marks are: (Initials)"
        '
        'txtMaintMyRRRepMarks
        '
        Me.txtMaintMyRRRepMarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRRepMarks.Location = New System.Drawing.Point(220, 263)
        Me.txtMaintMyRRRepMarks.Name = "txtMaintMyRRRepMarks"
        Me.txtMaintMyRRRepMarks.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRRepMarks.TabIndex = 16
        '
        'lblMyRRName
        '
        Me.lblMyRRName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMyRRName.AutoSize = True
        Me.lblMyRRName.Location = New System.Drawing.Point(25, 247)
        Me.lblMyRRName.Name = "lblMyRRName"
        Me.lblMyRRName.Size = New System.Drawing.Size(140, 13)
        Me.lblMyRRName.TabIndex = 15
        Me.lblMyRRName.Text = "The Name of my Railroad is:"
        '
        'txtMaintMyRRName
        '
        Me.txtMaintMyRRName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRName.Location = New System.Drawing.Point(28, 263)
        Me.txtMaintMyRRName.Name = "txtMaintMyRRName"
        Me.txtMaintMyRRName.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRName.TabIndex = 14
        '
        'optPrototype
        '
        Me.optPrototype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optPrototype.AutoSize = True
        Me.optPrototype.Location = New System.Drawing.Point(223, 312)
        Me.optPrototype.Name = "optPrototype"
        Me.optPrototype.Size = New System.Drawing.Size(70, 17)
        Me.optPrototype.TabIndex = 28
        Me.optPrototype.TabStop = True
        Me.optPrototype.Text = "Prototype"
        Me.optPrototype.UseVisualStyleBackColor = True
        '
        'OptFreelanced
        '
        Me.OptFreelanced.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OptFreelanced.AutoSize = True
        Me.OptFreelanced.Location = New System.Drawing.Point(316, 312)
        Me.OptFreelanced.Name = "OptFreelanced"
        Me.OptFreelanced.Size = New System.Drawing.Size(78, 17)
        Me.OptFreelanced.TabIndex = 29
        Me.OptFreelanced.TabStop = True
        Me.OptFreelanced.Text = "Freelanced"
        Me.OptFreelanced.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "My Railroad is based on:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Select a Railroad from the list, or create a new one."
        '
        'dgvRailroads
        '
        Me.dgvRailroads.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRailroads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRailroads.ColumnHeadersVisible = False
        Me.dgvRailroads.Location = New System.Drawing.Point(28, 45)
        Me.dgvRailroads.Name = "dgvRailroads"
        Me.dgvRailroads.RowHeadersVisible = False
        Me.dgvRailroads.Size = New System.Drawing.Size(377, 186)
        Me.dgvRailroads.TabIndex = 33
        '
        'frmMaintMyRR
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 549)
        Me.Controls.Add(Me.dgvRailroads)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.OptFreelanced)
        Me.Controls.Add(Me.optPrototype)
        Me.Controls.Add(Me.txtMaintMyRRPPwkDate)
        Me.Controls.Add(Me.txtMaintMyRROpSessionDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaintMyRREra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaintMyRRSlogan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaintMyRRState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaintMyRRRepMarks)
        Me.Controls.Add(Me.lblMyRRName)
        Me.Controls.Add(Me.txtMaintMyRRName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintMyRR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - My Railroad"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvRailroads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtMaintMyRRPPwkDate As System.Windows.Forms.TextBox
    Friend WithEvents txtMaintMyRROpSessionDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaintMyRREra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaintMyRRSlogan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaintMyRRState As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaintMyRRRepMarks As System.Windows.Forms.TextBox
    Friend WithEvents lblMyRRName As System.Windows.Forms.Label
    Friend WithEvents txtMaintMyRRName As System.Windows.Forms.TextBox
    Friend WithEvents optPrototype As System.Windows.Forms.RadioButton
    Friend WithEvents OptFreelanced As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvRailroads As System.Windows.Forms.DataGridView

End Class
