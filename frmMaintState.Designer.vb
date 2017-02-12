<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintState
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintState))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.txtStateName = New System.Windows.Forms.TextBox
        Me.lblStateName = New System.Windows.Forms.Label
        Me.txtStateCode = New System.Windows.Forms.TextBox
        Me.lblStateCode = New System.Windows.Forms.Label
        Me.dgvState = New System.Windows.Forms.DataGridView
        Me.AARState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AARStateName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AARRegion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdStateReset = New System.Windows.Forms.Button
        Me.cmdStateHelp = New System.Windows.Forms.Button
        Me.cmdStateSave = New System.Windows.Forms.Button
        Me.cmdStateDelete = New System.Windows.Forms.Button
        Me.cmdStateEdit = New System.Windows.Forms.Button
        Me.cmdStateNew = New System.Windows.Forms.Button
        Me.cboAARRegion = New System.Windows.Forms.ComboBox
        Me.lblAARReg = New System.Windows.Forms.Label
        Me.ttpMaintAARState = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(476, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(39, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Close"
        '
        'txtStateName
        '
        Me.txtStateName.Enabled = False
        Me.txtStateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateName.Location = New System.Drawing.Point(178, 115)
        Me.txtStateName.Name = "txtStateName"
        Me.txtStateName.Size = New System.Drawing.Size(190, 21)
        Me.txtStateName.TabIndex = 144
        '
        'lblStateName
        '
        Me.lblStateName.AutoSize = True
        Me.lblStateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateName.Location = New System.Drawing.Point(175, 94)
        Me.lblStateName.Name = "lblStateName"
        Me.lblStateName.Size = New System.Drawing.Size(72, 15)
        Me.lblStateName.TabIndex = 143
        Me.lblStateName.Text = "State Name"
        '
        'txtStateCode
        '
        Me.txtStateCode.Enabled = False
        Me.txtStateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateCode.Location = New System.Drawing.Point(78, 115)
        Me.txtStateCode.Name = "txtStateCode"
        Me.txtStateCode.Size = New System.Drawing.Size(94, 21)
        Me.txtStateCode.TabIndex = 142
        '
        'lblStateCode
        '
        Me.lblStateCode.AutoSize = True
        Me.lblStateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateCode.Location = New System.Drawing.Point(75, 94)
        Me.lblStateCode.Name = "lblStateCode"
        Me.lblStateCode.Size = New System.Drawing.Size(67, 15)
        Me.lblStateCode.TabIndex = 141
        Me.lblStateCode.Text = "State Code"
        '
        'dgvState
        '
        Me.dgvState.AllowUserToAddRows = False
        Me.dgvState.AllowUserToDeleteRows = False
        Me.dgvState.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvState.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AARState, Me.AARStateName, Me.AARRegion})
        Me.dgvState.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvState.Location = New System.Drawing.Point(78, 142)
        Me.dgvState.MultiSelect = False
        Me.dgvState.Name = "dgvState"
        Me.dgvState.RowHeadersVisible = False
        Me.dgvState.Size = New System.Drawing.Size(468, 137)
        Me.dgvState.TabIndex = 140
        '
        'AARState
        '
        Me.AARState.DataPropertyName = "AARState"
        Me.AARState.HeaderText = "State Code"
        Me.AARState.Name = "AARState"
        '
        'AARStateName
        '
        Me.AARStateName.DataPropertyName = "AARStateName"
        Me.AARStateName.HeaderText = "State Name"
        Me.AARStateName.Name = "AARStateName"
        Me.AARStateName.Width = 200
        '
        'AARRegion
        '
        Me.AARRegion.DataPropertyName = "RegionName"
        Me.AARRegion.HeaderText = "AARRegion"
        Me.AARRegion.Name = "AARRegion"
        Me.AARRegion.Width = 170
        '
        'cmdStateReset
        '
        Me.cmdStateReset.Location = New System.Drawing.Point(301, 46)
        Me.cmdStateReset.Name = "cmdStateReset"
        Me.cmdStateReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateReset.TabIndex = 139
        Me.cmdStateReset.Text = "Reset"
        '
        'cmdStateHelp
        '
        Me.cmdStateHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStateHelp.Enabled = False
        Me.cmdStateHelp.Location = New System.Drawing.Point(422, 46)
        Me.cmdStateHelp.Name = "cmdStateHelp"
        Me.cmdStateHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateHelp.TabIndex = 138
        Me.cmdStateHelp.Text = "Help"
        '
        'cmdStateSave
        '
        Me.cmdStateSave.Location = New System.Drawing.Point(216, 46)
        Me.cmdStateSave.Name = "cmdStateSave"
        Me.cmdStateSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateSave.TabIndex = 137
        Me.cmdStateSave.Text = "Save"
        '
        'cmdStateDelete
        '
        Me.cmdStateDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStateDelete.Location = New System.Drawing.Point(507, 46)
        Me.cmdStateDelete.Name = "cmdStateDelete"
        Me.cmdStateDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateDelete.TabIndex = 136
        Me.cmdStateDelete.Text = "Delete"
        '
        'cmdStateEdit
        '
        Me.cmdStateEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStateEdit.Location = New System.Drawing.Point(131, 46)
        Me.cmdStateEdit.Name = "cmdStateEdit"
        Me.cmdStateEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateEdit.TabIndex = 135
        Me.cmdStateEdit.Text = "Edit"
        Me.cmdStateEdit.UseVisualStyleBackColor = True
        '
        'cmdStateNew
        '
        Me.cmdStateNew.Location = New System.Drawing.Point(45, 46)
        Me.cmdStateNew.Name = "cmdStateNew"
        Me.cmdStateNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdStateNew.TabIndex = 134
        Me.cmdStateNew.Text = "New"
        '
        'cboAARRegion
        '
        Me.cboAARRegion.FormattingEnabled = True
        Me.cboAARRegion.Location = New System.Drawing.Point(374, 115)
        Me.cboAARRegion.Name = "cboAARRegion"
        Me.cboAARRegion.Size = New System.Drawing.Size(172, 21)
        Me.cboAARRegion.TabIndex = 145
        '
        'lblAARReg
        '
        Me.lblAARReg.AutoSize = True
        Me.lblAARReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAARReg.Location = New System.Drawing.Point(371, 94)
        Me.lblAARReg.Name = "lblAARReg"
        Me.lblAARReg.Size = New System.Drawing.Size(136, 15)
        Me.lblAARReg.TabIndex = 146
        Me.lblAARReg.Text = "Member of AAR Region"
        '
        'frmMaintState
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 347)
        Me.Controls.Add(Me.lblAARReg)
        Me.Controls.Add(Me.cboAARRegion)
        Me.Controls.Add(Me.txtStateName)
        Me.Controls.Add(Me.lblStateName)
        Me.Controls.Add(Me.txtStateCode)
        Me.Controls.Add(Me.lblStateCode)
        Me.Controls.Add(Me.dgvState)
        Me.Controls.Add(Me.cmdStateReset)
        Me.Controls.Add(Me.cmdStateHelp)
        Me.Controls.Add(Me.cmdStateSave)
        Me.Controls.Add(Me.cmdStateDelete)
        Me.Controls.Add(Me.cmdStateEdit)
        Me.Controls.Add(Me.cmdStateNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintState"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - State"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtStateName As System.Windows.Forms.TextBox
    Friend WithEvents lblStateName As System.Windows.Forms.Label
    Friend WithEvents txtStateCode As System.Windows.Forms.TextBox
    Friend WithEvents lblStateCode As System.Windows.Forms.Label
    Friend WithEvents dgvState As System.Windows.Forms.DataGridView
    Friend WithEvents cmdStateReset As System.Windows.Forms.Button
    Friend WithEvents cmdStateHelp As System.Windows.Forms.Button
    Friend WithEvents cmdStateSave As System.Windows.Forms.Button
    Friend WithEvents cmdStateDelete As System.Windows.Forms.Button
    Friend WithEvents cmdStateEdit As System.Windows.Forms.Button
    Friend WithEvents cmdStateNew As System.Windows.Forms.Button
    Friend WithEvents cboAARRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblAARReg As System.Windows.Forms.Label
    Friend WithEvents ttpMaintAARState As System.Windows.Forms.ToolTip
    Friend WithEvents AARState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARStateName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARRegion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
