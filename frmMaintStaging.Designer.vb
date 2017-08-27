<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintStaging
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId:="dgrSelRow")>
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintStaging))
        Me.lblStgName = New System.Windows.Forms.Label()
        Me.txtStgAreaCode = New System.Windows.Forms.TextBox()
        Me.lblStgCode = New System.Windows.Forms.Label()
        Me.dgvStg = New System.Windows.Forms.DataGridView()
        Me.StgID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StagingCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StagingDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdStgReset = New System.Windows.Forms.Button()
        Me.cmdStgHelp = New System.Windows.Forms.Button()
        Me.cmdStgSave = New System.Windows.Forms.Button()
        Me.cmdStgDelete = New System.Windows.Forms.Button()
        Me.cmdStgEdit = New System.Windows.Forms.Button()
        Me.cmdStgNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.txtStagingDesc = New System.Windows.Forms.TextBox()
        Me.ttpMaintStg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvStg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStgName
        '
        Me.lblStgName.AutoSize = True
        Me.lblStgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStgName.Location = New System.Drawing.Point(253, 73)
        Me.lblStgName.Name = "lblStgName"
        Me.lblStgName.Size = New System.Drawing.Size(185, 15)
        Me.lblStgName.TabIndex = 163
        Me.lblStgName.Text = "Staging Yard Description / Name"
        '
        'txtStgAreaCode
        '
        Me.txtStgAreaCode.Enabled = False
        Me.txtStgAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStgAreaCode.Location = New System.Drawing.Point(94, 96)
        Me.txtStgAreaCode.Name = "txtStgAreaCode"
        Me.txtStgAreaCode.Size = New System.Drawing.Size(144, 21)
        Me.txtStgAreaCode.TabIndex = 162
        '
        'lblStgCode
        '
        Me.lblStgCode.AutoSize = True
        Me.lblStgCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStgCode.Location = New System.Drawing.Point(91, 73)
        Me.lblStgCode.Name = "lblStgCode"
        Me.lblStgCode.Size = New System.Drawing.Size(109, 15)
        Me.lblStgCode.TabIndex = 161
        Me.lblStgCode.Text = "Staging Yard Code"
        '
        'dgvStg
        '
        Me.dgvStg.AllowUserToAddRows = False
        Me.dgvStg.AllowUserToDeleteRows = False
        Me.dgvStg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StgID, Me.StagingCode, Me.StagingDesc})
        Me.dgvStg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvStg.Location = New System.Drawing.Point(94, 133)
        Me.dgvStg.MultiSelect = False
        Me.dgvStg.Name = "dgvStg"
        Me.dgvStg.RowHeadersVisible = False
        Me.dgvStg.Size = New System.Drawing.Size(438, 137)
        Me.dgvStg.TabIndex = 158
        '
        'StgID
        '
        Me.StgID.DataPropertyName = "StgID"
        Me.StgID.HeaderText = "Staging ID"
        Me.StgID.Name = "StgID"
        Me.StgID.Visible = False
        '
        'StagingCode
        '
        Me.StagingCode.DataPropertyName = "StagingCode"
        Me.StagingCode.HeaderText = "Staging Area Code"
        Me.StagingCode.Name = "StagingCode"
        Me.StagingCode.Width = 150
        '
        'StagingDesc
        '
        Me.StagingDesc.DataPropertyName = "StagingDesc"
        Me.StagingDesc.HeaderText = "Description"
        Me.StagingDesc.Name = "StagingDesc"
        Me.StagingDesc.Width = 250
        '
        'cmdStgReset
        '
        Me.cmdStgReset.Location = New System.Drawing.Point(301, 26)
        Me.cmdStgReset.Name = "cmdStgReset"
        Me.cmdStgReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgReset.TabIndex = 157
        Me.cmdStgReset.Text = "Reset"
        '
        'cmdStgHelp
        '
        Me.cmdStgHelp.Enabled = False
        Me.cmdStgHelp.Location = New System.Drawing.Point(385, 26)
        Me.cmdStgHelp.Name = "cmdStgHelp"
        Me.cmdStgHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgHelp.TabIndex = 156
        Me.cmdStgHelp.Text = "Help"
        '
        'cmdStgSave
        '
        Me.cmdStgSave.Location = New System.Drawing.Point(216, 26)
        Me.cmdStgSave.Name = "cmdStgSave"
        Me.cmdStgSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgSave.TabIndex = 155
        Me.cmdStgSave.Text = "Save"
        '
        'cmdStgDelete
        '
        Me.cmdStgDelete.Location = New System.Drawing.Point(507, 26)
        Me.cmdStgDelete.Name = "cmdStgDelete"
        Me.cmdStgDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgDelete.TabIndex = 154
        Me.cmdStgDelete.Text = "Delete"
        '
        'cmdStgEdit
        '
        Me.cmdStgEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStgEdit.Location = New System.Drawing.Point(131, 26)
        Me.cmdStgEdit.Name = "cmdStgEdit"
        Me.cmdStgEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgEdit.TabIndex = 153
        Me.cmdStgEdit.Text = "Edit"
        Me.cmdStgEdit.UseVisualStyleBackColor = True
        '
        'cmdStgNew
        '
        Me.cmdStgNew.Location = New System.Drawing.Point(45, 26)
        Me.cmdStgNew.Name = "cmdStgNew"
        Me.cmdStgNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdStgNew.TabIndex = 152
        Me.cmdStgNew.Text = "New"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(434, 291)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 151
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
        'txtStagingDesc
        '
        Me.txtStagingDesc.Enabled = False
        Me.txtStagingDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStagingDesc.Location = New System.Drawing.Point(256, 96)
        Me.txtStagingDesc.Name = "txtStagingDesc"
        Me.txtStagingDesc.Size = New System.Drawing.Size(240, 21)
        Me.txtStagingDesc.TabIndex = 164
        '
        'frmMaintStaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 346)
        Me.Controls.Add(Me.txtStagingDesc)
        Me.Controls.Add(Me.lblStgName)
        Me.Controls.Add(Me.txtStgAreaCode)
        Me.Controls.Add(Me.lblStgCode)
        Me.Controls.Add(Me.dgvStg)
        Me.Controls.Add(Me.cmdStgReset)
        Me.Controls.Add(Me.cmdStgHelp)
        Me.Controls.Add(Me.cmdStgSave)
        Me.Controls.Add(Me.cmdStgDelete)
        Me.Controls.Add(Me.cmdStgEdit)
        Me.Controls.Add(Me.cmdStgNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaintStaging"
        Me.Text = "Maintain - Staging"
        CType(Me.dgvStg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStgName As System.Windows.Forms.Label
    Friend WithEvents txtStgAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents lblStgCode As System.Windows.Forms.Label
    Friend WithEvents dgvStg As System.Windows.Forms.DataGridView
    Friend WithEvents cmdStgReset As System.Windows.Forms.Button
    Friend WithEvents cmdStgHelp As System.Windows.Forms.Button
    Friend WithEvents cmdStgSave As System.Windows.Forms.Button
    Friend WithEvents cmdStgDelete As System.Windows.Forms.Button
    Friend WithEvents cmdStgEdit As System.Windows.Forms.Button
    Friend WithEvents cmdStgNew As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtStagingDesc As System.Windows.Forms.TextBox
    Friend WithEvents ttpMaintStg As System.Windows.Forms.ToolTip
    Friend WithEvents StgID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StagingCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StagingDesc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
