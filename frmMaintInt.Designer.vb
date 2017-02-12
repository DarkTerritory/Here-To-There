<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintInt))
        Me.lblIntForRRDir = New System.Windows.Forms.Label
        Me.cboIntForRRDir = New System.Windows.Forms.ComboBox
        Me.cboIntForRR = New System.Windows.Forms.ComboBox
        Me.lblIntForRR = New System.Windows.Forms.Label
        Me.lblIntPriRR = New System.Windows.Forms.Label
        Me.lblIntTown = New System.Windows.Forms.Label
        Me.dgvInt = New System.Windows.Forms.DataGridView
        Me.IntID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntTown = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InTPrimaryRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntForeignRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntForeignRRDir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntNearestOnLineInt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntStagingArea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdIntReset = New System.Windows.Forms.Button
        Me.cmdIntHelp = New System.Windows.Forms.Button
        Me.cmdIntSave = New System.Windows.Forms.Button
        Me.cmdIntDelete = New System.Windows.Forms.Button
        Me.cmdIntEdit = New System.Windows.Forms.Button
        Me.cmdIntNew = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cboIntTown = New System.Windows.Forms.ComboBox
        Me.cboIntPriRR = New System.Windows.Forms.ComboBox
        Me.cboIntNearestOLInt = New System.Windows.Forms.ComboBox
        Me.lblIntNearestOLInt = New System.Windows.Forms.Label
        Me.ttpMaintInt = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboIntStagingArea = New System.Windows.Forms.ComboBox
        Me.lblIntStagingArea = New System.Windows.Forms.Label
        CType(Me.dgvInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIntForRRDir
        '
        Me.lblIntForRRDir.AutoSize = True
        Me.lblIntForRRDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntForRRDir.Location = New System.Drawing.Point(433, 80)
        Me.lblIntForRRDir.Name = "lblIntForRRDir"
        Me.lblIntForRRDir.Size = New System.Drawing.Size(102, 15)
        Me.lblIntForRRDir.TabIndex = 166
        Me.lblIntForRRDir.Text = "Foreign RR Runs"
        '
        'cboIntForRRDir
        '
        Me.cboIntForRRDir.FormattingEnabled = True
        Me.cboIntForRRDir.Location = New System.Drawing.Point(436, 103)
        Me.cboIntForRRDir.Name = "cboIntForRRDir"
        Me.cboIntForRRDir.Size = New System.Drawing.Size(98, 21)
        Me.cboIntForRRDir.TabIndex = 165
        '
        'cboIntForRR
        '
        Me.cboIntForRR.FormattingEnabled = True
        Me.cboIntForRR.Location = New System.Drawing.Point(288, 103)
        Me.cboIntForRR.Name = "cboIntForRR"
        Me.cboIntForRR.Size = New System.Drawing.Size(142, 21)
        Me.cboIntForRR.TabIndex = 164
        '
        'lblIntForRR
        '
        Me.lblIntForRR.AutoSize = True
        Me.lblIntForRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntForRR.Location = New System.Drawing.Point(285, 80)
        Me.lblIntForRR.Name = "lblIntForRR"
        Me.lblIntForRR.Size = New System.Drawing.Size(99, 15)
        Me.lblIntForRR.TabIndex = 163
        Me.lblIntForRR.Text = "Foreign Railroad"
        '
        'lblIntPriRR
        '
        Me.lblIntPriRR.AutoSize = True
        Me.lblIntPriRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntPriRR.Location = New System.Drawing.Point(132, 80)
        Me.lblIntPriRR.Name = "lblIntPriRR"
        Me.lblIntPriRR.Size = New System.Drawing.Size(99, 15)
        Me.lblIntPriRR.TabIndex = 161
        Me.lblIntPriRR.Text = "Primary Railroad"
        '
        'lblIntTown
        '
        Me.lblIntTown.AutoSize = True
        Me.lblIntTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntTown.Location = New System.Drawing.Point(33, 80)
        Me.lblIntTown.Name = "lblIntTown"
        Me.lblIntTown.Size = New System.Drawing.Size(37, 15)
        Me.lblIntTown.TabIndex = 159
        Me.lblIntTown.Text = "Town"
        '
        'dgvInt
        '
        Me.dgvInt.AllowUserToAddRows = False
        Me.dgvInt.AllowUserToDeleteRows = False
        Me.dgvInt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IntID, Me.IntTown, Me.InTPrimaryRR, Me.IntForeignRR, Me.IntForeignRRDir, Me.IntNearestOnLineInt, Me.IntStagingArea})
        Me.dgvInt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInt.Location = New System.Drawing.Point(36, 141)
        Me.dgvInt.MultiSelect = False
        Me.dgvInt.Name = "dgvInt"
        Me.dgvInt.RowHeadersVisible = False
        Me.dgvInt.Size = New System.Drawing.Size(724, 137)
        Me.dgvInt.TabIndex = 158
        '
        'IntID
        '
        Me.IntID.DataPropertyName = "IntID"
        Me.IntID.HeaderText = "IntID"
        Me.IntID.Name = "IntID"
        Me.IntID.Visible = False
        '
        'IntTown
        '
        Me.IntTown.DataPropertyName = "IntTown"
        Me.IntTown.HeaderText = "Town"
        Me.IntTown.Name = "IntTown"
        '
        'InTPrimaryRR
        '
        Me.InTPrimaryRR.DataPropertyName = "IntPrimaryRR"
        Me.InTPrimaryRR.HeaderText = "Primary RR"
        Me.InTPrimaryRR.Name = "InTPrimaryRR"
        Me.InTPrimaryRR.Width = 150
        '
        'IntForeignRR
        '
        Me.IntForeignRR.DataPropertyName = "IntForeignRR"
        Me.IntForeignRR.HeaderText = "Foreign RR"
        Me.IntForeignRR.Name = "IntForeignRR"
        Me.IntForeignRR.Width = 150
        '
        'IntForeignRRDir
        '
        Me.IntForeignRRDir.DataPropertyName = "IntForeignRRDir"
        Me.IntForeignRRDir.HeaderText = "Foreign RR Runs"
        Me.IntForeignRRDir.Name = "IntForeignRRDir"
        '
        'IntNearestOnLineInt
        '
        Me.IntNearestOnLineInt.DataPropertyName = "IntNearestOnLineInt"
        Me.IntNearestOnLineInt.HeaderText = "Nearest OnLine Int"
        Me.IntNearestOnLineInt.Name = "IntNearestOnLineInt"
        Me.IntNearestOnLineInt.Width = 110
        '
        'IntStagingArea
        '
        Me.IntStagingArea.DataPropertyName = "IntStagingArea"
        Me.IntStagingArea.HeaderText = "Staging Area"
        Me.IntStagingArea.Name = "IntStagingArea"
        '
        'cmdIntReset
        '
        Me.cmdIntReset.Location = New System.Drawing.Point(292, 33)
        Me.cmdIntReset.Name = "cmdIntReset"
        Me.cmdIntReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntReset.TabIndex = 157
        Me.cmdIntReset.Text = "Reset"
        '
        'cmdIntHelp
        '
        Me.cmdIntHelp.Enabled = False
        Me.cmdIntHelp.Location = New System.Drawing.Point(540, 33)
        Me.cmdIntHelp.Name = "cmdIntHelp"
        Me.cmdIntHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntHelp.TabIndex = 156
        Me.cmdIntHelp.Text = "Help"
        '
        'cmdIntSave
        '
        Me.cmdIntSave.Location = New System.Drawing.Point(207, 33)
        Me.cmdIntSave.Name = "cmdIntSave"
        Me.cmdIntSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntSave.TabIndex = 155
        Me.cmdIntSave.Text = "Save"
        '
        'cmdIntDelete
        '
        Me.cmdIntDelete.Location = New System.Drawing.Point(682, 33)
        Me.cmdIntDelete.Name = "cmdIntDelete"
        Me.cmdIntDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntDelete.TabIndex = 154
        Me.cmdIntDelete.Text = "Delete"
        '
        'cmdIntEdit
        '
        Me.cmdIntEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIntEdit.Location = New System.Drawing.Point(122, 33)
        Me.cmdIntEdit.Name = "cmdIntEdit"
        Me.cmdIntEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntEdit.TabIndex = 153
        Me.cmdIntEdit.Text = "Edit"
        Me.cmdIntEdit.UseVisualStyleBackColor = False
        '
        'cmdIntNew
        '
        Me.cmdIntNew.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIntNew.Location = New System.Drawing.Point(36, 33)
        Me.cmdIntNew.Name = "cmdIntNew"
        Me.cmdIntNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdIntNew.TabIndex = 152
        Me.cmdIntNew.Text = "New"
        Me.cmdIntNew.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(623, 295)
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
        'cboIntTown
        '
        Me.cboIntTown.FormattingEnabled = True
        Me.cboIntTown.Location = New System.Drawing.Point(36, 103)
        Me.cboIntTown.Name = "cboIntTown"
        Me.cboIntTown.Size = New System.Drawing.Size(93, 21)
        Me.cboIntTown.TabIndex = 167
        '
        'cboIntPriRR
        '
        Me.cboIntPriRR.FormattingEnabled = True
        Me.cboIntPriRR.Location = New System.Drawing.Point(135, 103)
        Me.cboIntPriRR.Name = "cboIntPriRR"
        Me.cboIntPriRR.Size = New System.Drawing.Size(147, 21)
        Me.cboIntPriRR.TabIndex = 168
        '
        'cboIntNearestOLInt
        '
        Me.cboIntNearestOLInt.FormattingEnabled = True
        Me.cboIntNearestOLInt.Location = New System.Drawing.Point(540, 103)
        Me.cboIntNearestOLInt.Name = "cboIntNearestOLInt"
        Me.cboIntNearestOLInt.Size = New System.Drawing.Size(116, 21)
        Me.cboIntNearestOLInt.TabIndex = 169
        '
        'lblIntNearestOLInt
        '
        Me.lblIntNearestOLInt.AutoSize = True
        Me.lblIntNearestOLInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntNearestOLInt.Location = New System.Drawing.Point(537, 80)
        Me.lblIntNearestOLInt.Name = "lblIntNearestOLInt"
        Me.lblIntNearestOLInt.Size = New System.Drawing.Size(112, 15)
        Me.lblIntNearestOLInt.TabIndex = 170
        Me.lblIntNearestOLInt.Text = "Nearest OnLine Int."
        '
        'cboIntStagingArea
        '
        Me.cboIntStagingArea.FormattingEnabled = True
        Me.cboIntStagingArea.Location = New System.Drawing.Point(662, 103)
        Me.cboIntStagingArea.Name = "cboIntStagingArea"
        Me.cboIntStagingArea.Size = New System.Drawing.Size(98, 21)
        Me.cboIntStagingArea.TabIndex = 171
        '
        'lblIntStagingArea
        '
        Me.lblIntStagingArea.AutoSize = True
        Me.lblIntStagingArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntStagingArea.Location = New System.Drawing.Point(658, 80)
        Me.lblIntStagingArea.Name = "lblIntStagingArea"
        Me.lblIntStagingArea.Size = New System.Drawing.Size(77, 15)
        Me.lblIntStagingArea.TabIndex = 172
        Me.lblIntStagingArea.Text = "Staging Area"
        '
        'frmMaintInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 347)
        Me.Controls.Add(Me.lblIntStagingArea)
        Me.Controls.Add(Me.cboIntStagingArea)
        Me.Controls.Add(Me.lblIntNearestOLInt)
        Me.Controls.Add(Me.cboIntNearestOLInt)
        Me.Controls.Add(Me.cboIntPriRR)
        Me.Controls.Add(Me.cboIntTown)
        Me.Controls.Add(Me.lblIntForRRDir)
        Me.Controls.Add(Me.cboIntForRRDir)
        Me.Controls.Add(Me.cboIntForRR)
        Me.Controls.Add(Me.lblIntForRR)
        Me.Controls.Add(Me.lblIntPriRR)
        Me.Controls.Add(Me.lblIntTown)
        Me.Controls.Add(Me.dgvInt)
        Me.Controls.Add(Me.cmdIntReset)
        Me.Controls.Add(Me.cmdIntHelp)
        Me.Controls.Add(Me.cmdIntSave)
        Me.Controls.Add(Me.cmdIntDelete)
        Me.Controls.Add(Me.cmdIntEdit)
        Me.Controls.Add(Me.cmdIntNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaintInt"
        Me.Text = "Maintain - Interchanges"
        CType(Me.dgvInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntForRRDir As System.Windows.Forms.Label
    Friend WithEvents cboIntForRRDir As System.Windows.Forms.ComboBox
    Friend WithEvents cboIntForRR As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntForRR As System.Windows.Forms.Label
    Friend WithEvents lblIntPriRR As System.Windows.Forms.Label
    Friend WithEvents lblIntTown As System.Windows.Forms.Label
    Friend WithEvents dgvInt As System.Windows.Forms.DataGridView
    Friend WithEvents cmdIntReset As System.Windows.Forms.Button
    Friend WithEvents cmdIntHelp As System.Windows.Forms.Button
    Friend WithEvents cmdIntSave As System.Windows.Forms.Button
    Friend WithEvents cmdIntDelete As System.Windows.Forms.Button
    Friend WithEvents cmdIntEdit As System.Windows.Forms.Button
    Friend WithEvents cmdIntNew As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cboIntTown As System.Windows.Forms.ComboBox
    Friend WithEvents cboIntPriRR As System.Windows.Forms.ComboBox
    Friend WithEvents cboIntNearestOLInt As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntNearestOLInt As System.Windows.Forms.Label
    Friend WithEvents ttpMaintInt As System.Windows.Forms.ToolTip
    Friend WithEvents cboIntStagingArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntStagingArea As System.Windows.Forms.Label
    Friend WithEvents IntID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntTown As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InTPrimaryRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntForeignRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntForeignRRDir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntNearestOnLineInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntStagingArea As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
