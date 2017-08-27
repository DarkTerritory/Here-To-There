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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaintMyRREra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaintMyRRSlogan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaintMyRRState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaintMyRRRepMarks = New System.Windows.Forms.TextBox()
        Me.lblMyRRName = New System.Windows.Forms.Label()
        Me.txtMaintMyRRName = New System.Windows.Forms.TextBox()
        Me.optPrototype = New System.Windows.Forms.RadioButton()
        Me.OptFreelanced = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvRailroads = New System.Windows.Forms.DataGridView()
        Me.RRID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRInitials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RREra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RROpSessionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRpaperworkDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRPrototype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBFilename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAddRR = New System.Windows.Forms.Button()
        Me.cmdDeleteRR = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEditRR = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        CType(Me.dgvRailroads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "The Era my Railroad is set in is:"
        '
        'txtMaintMyRREra
        '
        Me.txtMaintMyRREra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRREra.Enabled = False
        Me.txtMaintMyRREra.Location = New System.Drawing.Point(220, 293)
        Me.txtMaintMyRREra.Name = "txtMaintMyRREra"
        Me.txtMaintMyRREra.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRREra.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "The Nickname or Slogan is:"
        '
        'txtMaintMyRRSlogan
        '
        Me.txtMaintMyRRSlogan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRSlogan.Enabled = False
        Me.txtMaintMyRRSlogan.Location = New System.Drawing.Point(28, 243)
        Me.txtMaintMyRRSlogan.Name = "txtMaintMyRRSlogan"
        Me.txtMaintMyRRSlogan.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRSlogan.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "It operates in the State of:"
        '
        'txtMaintMyRRState
        '
        Me.txtMaintMyRRState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRState.Enabled = False
        Me.txtMaintMyRRState.Location = New System.Drawing.Point(28, 293)
        Me.txtMaintMyRRState.Name = "txtMaintMyRRState"
        Me.txtMaintMyRRState.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRState.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Its reporting marks are: (Initials)"
        '
        'txtMaintMyRRRepMarks
        '
        Me.txtMaintMyRRRepMarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRRepMarks.Enabled = False
        Me.txtMaintMyRRRepMarks.Location = New System.Drawing.Point(220, 197)
        Me.txtMaintMyRRRepMarks.Name = "txtMaintMyRRRepMarks"
        Me.txtMaintMyRRRepMarks.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRRepMarks.TabIndex = 16
        '
        'lblMyRRName
        '
        Me.lblMyRRName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMyRRName.AutoSize = True
        Me.lblMyRRName.Location = New System.Drawing.Point(25, 181)
        Me.lblMyRRName.Name = "lblMyRRName"
        Me.lblMyRRName.Size = New System.Drawing.Size(140, 13)
        Me.lblMyRRName.TabIndex = 15
        Me.lblMyRRName.Text = "The Name of my Railroad is:"
        '
        'txtMaintMyRRName
        '
        Me.txtMaintMyRRName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaintMyRRName.Enabled = False
        Me.txtMaintMyRRName.Location = New System.Drawing.Point(28, 197)
        Me.txtMaintMyRRName.Name = "txtMaintMyRRName"
        Me.txtMaintMyRRName.Size = New System.Drawing.Size(186, 20)
        Me.txtMaintMyRRName.TabIndex = 14
        '
        'optPrototype
        '
        Me.optPrototype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optPrototype.AutoSize = True
        Me.optPrototype.Enabled = False
        Me.optPrototype.Location = New System.Drawing.Point(223, 246)
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
        Me.OptFreelanced.Cursor = System.Windows.Forms.Cursors.No
        Me.OptFreelanced.Enabled = False
        Me.OptFreelanced.Location = New System.Drawing.Point(316, 246)
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
        Me.Label7.Location = New System.Drawing.Point(220, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "My Railroad is based on:"
        '
        'dgvRailroads
        '
        Me.dgvRailroads.AllowUserToAddRows = False
        Me.dgvRailroads.AllowUserToDeleteRows = False
        Me.dgvRailroads.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRailroads.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvRailroads.ColumnHeadersVisible = False
        Me.dgvRailroads.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RRID, Me.RRName, Me.RRInitials, Me.RRState, Me.RRNickname, Me.RREra, Me.RROpSessionDate, Me.RRpaperworkDate, Me.RRPrototype, Me.DBFilename})
        Me.dgvRailroads.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRailroads.Location = New System.Drawing.Point(28, 61)
        Me.dgvRailroads.MultiSelect = False
        Me.dgvRailroads.Name = "dgvRailroads"
        Me.dgvRailroads.RowHeadersVisible = False
        Me.dgvRailroads.ShowCellToolTips = False
        Me.dgvRailroads.ShowEditingIcon = False
        Me.dgvRailroads.Size = New System.Drawing.Size(377, 73)
        Me.dgvRailroads.TabIndex = 33
        '
        'RRID
        '
        Me.RRID.DataPropertyName = "RRID"
        Me.RRID.HeaderText = "RRID"
        Me.RRID.Name = "RRID"
        Me.RRID.Width = 5
        '
        'RRName
        '
        Me.RRName.DataPropertyName = "RRName"
        Me.RRName.HeaderText = "Railroad Name"
        Me.RRName.Name = "RRName"
        Me.RRName.Width = 150
        '
        'RRInitials
        '
        Me.RRInitials.DataPropertyName = "RRInitials"
        Me.RRInitials.HeaderText = "Reporting Marks"
        Me.RRInitials.Name = "RRInitials"
        Me.RRInitials.Width = 75
        '
        'RRState
        '
        Me.RRState.DataPropertyName = "RRState"
        Me.RRState.HeaderText = "State"
        Me.RRState.Name = "RRState"
        Me.RRState.Visible = False
        Me.RRState.Width = 50
        '
        'RRNickname
        '
        Me.RRNickname.DataPropertyName = "RRNickname"
        Me.RRNickname.HeaderText = "Nickname"
        Me.RRNickname.Name = "RRNickname"
        '
        'RREra
        '
        Me.RREra.DataPropertyName = "RREra"
        Me.RREra.HeaderText = "Era"
        Me.RREra.Name = "RREra"
        Me.RREra.Width = 50
        '
        'RROpSessionDate
        '
        Me.RROpSessionDate.DataPropertyName = "RROpSessionDate"
        Me.RROpSessionDate.HeaderText = "Op Session Date"
        Me.RROpSessionDate.Name = "RROpSessionDate"
        Me.RROpSessionDate.Visible = False
        '
        'RRpaperworkDate
        '
        Me.RRpaperworkDate.DataPropertyName = "RRPaperworkDate"
        Me.RRpaperworkDate.HeaderText = "Paperwork Date"
        Me.RRpaperworkDate.Name = "RRpaperworkDate"
        Me.RRpaperworkDate.Visible = False
        '
        'RRPrototype
        '
        Me.RRPrototype.DataPropertyName = "RRPrototype"
        Me.RRPrototype.HeaderText = "Prototype"
        Me.RRPrototype.Name = "RRPrototype"
        Me.RRPrototype.Width = 75
        '
        'DBFilename
        '
        Me.DBFilename.DataPropertyName = "DBFileName"
        Me.DBFilename.HeaderText = "dbfilename"
        Me.DBFilename.Name = "DBFilename"
        Me.DBFilename.Visible = False
        '
        'cmdAddRR
        '
        Me.cmdAddRR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddRR.Location = New System.Drawing.Point(29, 323)
        Me.cmdAddRR.Name = "cmdAddRR"
        Me.cmdAddRR.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddRR.TabIndex = 34
        Me.cmdAddRR.Text = "Add RR"
        Me.cmdAddRR.UseVisualStyleBackColor = True
        '
        'cmdDeleteRR
        '
        Me.cmdDeleteRR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDeleteRR.Location = New System.Drawing.Point(104, 323)
        Me.cmdDeleteRR.Name = "cmdDeleteRR"
        Me.cmdDeleteRR.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteRR.TabIndex = 35
        Me.cmdDeleteRR.Text = "Delete RR"
        Me.cmdDeleteRR.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(254, 323)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 36
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(331, 361)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 37
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Location = New System.Drawing.Point(329, 323)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 38
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(411, 46)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Double-click a Railroad in the grid below and click Select to use it. To create a" &
    " new Railroad, Click the Add RR button, type in the values in the boxes below an" &
    "d click Save."
        '
        'cmdEditRR
        '
        Me.cmdEditRR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEditRR.Location = New System.Drawing.Point(179, 323)
        Me.cmdEditRR.Name = "cmdEditRR"
        Me.cmdEditRR.Size = New System.Drawing.Size(75, 23)
        Me.cmdEditRR.TabIndex = 40
        Me.cmdEditRR.Text = "Edit RR"
        Me.cmdEditRR.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSelect.Enabled = False
        Me.cmdSelect.Location = New System.Drawing.Point(179, 140)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelect.TabIndex = 41
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'frmMaintMyRR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 407)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdEditRR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDeleteRR)
        Me.Controls.Add(Me.cmdAddRR)
        Me.Controls.Add(Me.dgvRailroads)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.OptFreelanced)
        Me.Controls.Add(Me.optPrototype)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintMyRR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - My Railroad (Layout)"
        CType(Me.dgvRailroads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents dgvRailroads As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAddRR As Button
    Friend WithEvents cmdDeleteRR As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEditRR As Button
    Friend WithEvents cmdSelect As Button
    Friend WithEvents RRID As DataGridViewTextBoxColumn
    Friend WithEvents RRName As DataGridViewTextBoxColumn
    Friend WithEvents RRInitials As DataGridViewTextBoxColumn
    Friend WithEvents RRState As DataGridViewTextBoxColumn
    Friend WithEvents RRNickname As DataGridViewTextBoxColumn
    Friend WithEvents RREra As DataGridViewTextBoxColumn
    Friend WithEvents RROpSessionDate As DataGridViewTextBoxColumn
    Friend WithEvents RRpaperworkDate As DataGridViewTextBoxColumn
    Friend WithEvents RRPrototype As DataGridViewTextBoxColumn
    Friend WithEvents DBFilename As DataGridViewTextBoxColumn
End Class
