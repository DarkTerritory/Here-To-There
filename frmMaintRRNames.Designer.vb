<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintRRNames
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintRRNames))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.txtRRName = New System.Windows.Forms.TextBox
        Me.lblRRName = New System.Windows.Forms.Label
        Me.txtRRCode = New System.Windows.Forms.TextBox
        Me.lblAARCode = New System.Windows.Forms.Label
        Me.dgvRRName = New System.Windows.Forms.DataGridView
        Me.AAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Railroad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReportMark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdRRNameReset = New System.Windows.Forms.Button
        Me.cmdRRNameHelp = New System.Windows.Forms.Button
        Me.cmdRRNameSave = New System.Windows.Forms.Button
        Me.cmdRRNameDelete = New System.Windows.Forms.Button
        Me.cmdRRNameEdit = New System.Windows.Forms.Button
        Me.cmdRRNameNew = New System.Windows.Forms.Button
        Me.txtRepMark = New System.Windows.Forms.TextBox
        Me.lblRepMark = New System.Windows.Forms.Label
        Me.ttpMaintRRName = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvRRName, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtRRName
        '
        Me.txtRRName.Enabled = False
        Me.txtRRName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRRName.Location = New System.Drawing.Point(190, 109)
        Me.txtRRName.Name = "txtRRName"
        Me.txtRRName.Size = New System.Drawing.Size(189, 21)
        Me.txtRRName.TabIndex = 133
        '
        'lblRRName
        '
        Me.lblRRName.AutoSize = True
        Me.lblRRName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRName.Location = New System.Drawing.Point(187, 86)
        Me.lblRRName.Name = "lblRRName"
        Me.lblRRName.Size = New System.Drawing.Size(91, 15)
        Me.lblRRName.TabIndex = 132
        Me.lblRRName.Text = "Railroad Name"
        '
        'txtRRCode
        '
        Me.txtRRCode.Enabled = False
        Me.txtRRCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRRCode.Location = New System.Drawing.Point(114, 109)
        Me.txtRRCode.Name = "txtRRCode"
        Me.txtRRCode.Size = New System.Drawing.Size(70, 21)
        Me.txtRRCode.TabIndex = 131
        '
        'lblAARCode
        '
        Me.lblAARCode.AutoSize = True
        Me.lblAARCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAARCode.Location = New System.Drawing.Point(111, 86)
        Me.lblAARCode.Name = "lblAARCode"
        Me.lblAARCode.Size = New System.Drawing.Size(62, 15)
        Me.lblAARCode.TabIndex = 130
        Me.lblAARCode.Text = "AAR Code"
        '
        'dgvRRName
        '
        Me.dgvRRName.AllowUserToAddRows = False
        Me.dgvRRName.AllowUserToDeleteRows = False
        Me.dgvRRName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRRName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AAR, Me.Railroad, Me.ReportMark})
        Me.dgvRRName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRRName.Location = New System.Drawing.Point(114, 145)
        Me.dgvRRName.MultiSelect = False
        Me.dgvRRName.Name = "dgvRRName"
        Me.dgvRRName.RowHeadersVisible = False
        Me.dgvRRName.Size = New System.Drawing.Size(406, 137)
        Me.dgvRRName.TabIndex = 129
        '
        'AAR
        '
        Me.AAR.DataPropertyName = "AAR"
        Me.AAR.HeaderText = "AAR Code"
        Me.AAR.Name = "AAR"
        Me.AAR.Width = 75
        '
        'Railroad
        '
        Me.Railroad.DataPropertyName = "Railroad"
        Me.Railroad.HeaderText = "Railroad Name"
        Me.Railroad.Name = "Railroad"
        Me.Railroad.Width = 200
        '
        'ReportMark
        '
        Me.ReportMark.DataPropertyName = "ReportMark"
        Me.ReportMark.HeaderText = "Report Mark"
        Me.ReportMark.Name = "ReportMark"
        '
        'cmdRRNameReset
        '
        Me.cmdRRNameReset.Location = New System.Drawing.Point(301, 46)
        Me.cmdRRNameReset.Name = "cmdRRNameReset"
        Me.cmdRRNameReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameReset.TabIndex = 128
        Me.cmdRRNameReset.Text = "Reset"
        '
        'cmdRRNameHelp
        '
        Me.cmdRRNameHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRRNameHelp.Enabled = False
        Me.cmdRRNameHelp.Location = New System.Drawing.Point(422, 46)
        Me.cmdRRNameHelp.Name = "cmdRRNameHelp"
        Me.cmdRRNameHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameHelp.TabIndex = 127
        Me.cmdRRNameHelp.Text = "Help"
        '
        'cmdRRNameSave
        '
        Me.cmdRRNameSave.Location = New System.Drawing.Point(216, 46)
        Me.cmdRRNameSave.Name = "cmdRRNameSave"
        Me.cmdRRNameSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameSave.TabIndex = 126
        Me.cmdRRNameSave.Text = "Save"
        '
        'cmdRRNameDelete
        '
        Me.cmdRRNameDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRRNameDelete.Location = New System.Drawing.Point(507, 46)
        Me.cmdRRNameDelete.Name = "cmdRRNameDelete"
        Me.cmdRRNameDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameDelete.TabIndex = 125
        Me.cmdRRNameDelete.Text = "Delete"
        '
        'cmdRRNameEdit
        '
        Me.cmdRRNameEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRRNameEdit.Location = New System.Drawing.Point(131, 46)
        Me.cmdRRNameEdit.Name = "cmdRRNameEdit"
        Me.cmdRRNameEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameEdit.TabIndex = 124
        Me.cmdRRNameEdit.Text = "Edit"
        Me.cmdRRNameEdit.UseVisualStyleBackColor = True
        '
        'cmdRRNameNew
        '
        Me.cmdRRNameNew.Location = New System.Drawing.Point(45, 46)
        Me.cmdRRNameNew.Name = "cmdRRNameNew"
        Me.cmdRRNameNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdRRNameNew.TabIndex = 123
        Me.cmdRRNameNew.Text = "New"
        '
        'txtRepMark
        '
        Me.txtRepMark.Enabled = False
        Me.txtRepMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepMark.Location = New System.Drawing.Point(390, 109)
        Me.txtRepMark.Name = "txtRepMark"
        Me.txtRepMark.Size = New System.Drawing.Size(101, 21)
        Me.txtRepMark.TabIndex = 135
        '
        'lblRepMark
        '
        Me.lblRepMark.AutoSize = True
        Me.lblRepMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepMark.Location = New System.Drawing.Point(387, 86)
        Me.lblRepMark.Name = "lblRepMark"
        Me.lblRepMark.Size = New System.Drawing.Size(75, 15)
        Me.lblRepMark.TabIndex = 134
        Me.lblRepMark.Text = "Report Mark"
        '
        'frmMaintRRNames
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 347)
        Me.Controls.Add(Me.txtRepMark)
        Me.Controls.Add(Me.lblRepMark)
        Me.Controls.Add(Me.txtRRName)
        Me.Controls.Add(Me.lblRRName)
        Me.Controls.Add(Me.txtRRCode)
        Me.Controls.Add(Me.lblAARCode)
        Me.Controls.Add(Me.dgvRRName)
        Me.Controls.Add(Me.cmdRRNameReset)
        Me.Controls.Add(Me.cmdRRNameHelp)
        Me.Controls.Add(Me.cmdRRNameSave)
        Me.Controls.Add(Me.cmdRRNameDelete)
        Me.Controls.Add(Me.cmdRRNameEdit)
        Me.Controls.Add(Me.cmdRRNameNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintRRNames"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Railroad Names"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvRRName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtRRName As System.Windows.Forms.TextBox
    Friend WithEvents lblRRName As System.Windows.Forms.Label
    Friend WithEvents txtRRCode As System.Windows.Forms.TextBox
    Friend WithEvents lblAARCode As System.Windows.Forms.Label
    Friend WithEvents dgvRRName As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRRNameReset As System.Windows.Forms.Button
    Friend WithEvents cmdRRNameHelp As System.Windows.Forms.Button
    Friend WithEvents cmdRRNameSave As System.Windows.Forms.Button
    Friend WithEvents cmdRRNameDelete As System.Windows.Forms.Button
    Friend WithEvents cmdRRNameEdit As System.Windows.Forms.Button
    Friend WithEvents cmdRRNameNew As System.Windows.Forms.Button
    Friend WithEvents AAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Railroad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportMark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRepMark As System.Windows.Forms.TextBox
    Friend WithEvents lblRepMark As System.Windows.Forms.Label
    Friend WithEvents ttpMaintRRName As System.Windows.Forms.ToolTip

End Class
