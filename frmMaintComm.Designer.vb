<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintComm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintComm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.chkUse = New System.Windows.Forms.CheckBox
        Me.txtCommName = New System.Windows.Forms.TextBox
        Me.txtCommNotes = New System.Windows.Forms.TextBox
        Me.lblCommUse = New System.Windows.Forms.Label
        Me.lblCommName = New System.Windows.Forms.Label
        Me.lblCommPriority = New System.Windows.Forms.Label
        Me.lblCommCarType1 = New System.Windows.Forms.Label
        Me.lblCommCarType2 = New System.Windows.Forms.Label
        Me.lblCommCarType3 = New System.Windows.Forms.Label
        Me.lblCommNotes = New System.Windows.Forms.Label
        Me.cboCommCarType1 = New System.Windows.Forms.ComboBox
        Me.cboCommCarType2 = New System.Windows.Forms.ComboBox
        Me.cboCommCarType3 = New System.Windows.Forms.ComboBox
        Me.cboCommPriority = New System.Windows.Forms.ComboBox
        Me.cmdCommNew = New System.Windows.Forms.Button
        Me.cmdCommEdit = New System.Windows.Forms.Button
        Me.cmdCommDelete = New System.Windows.Forms.Button
        Me.cmdCommSave = New System.Windows.Forms.Button
        Me.cmdCommHelp = New System.Windows.Forms.Button
        Me.cmdCommReset = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ttpMaintComm = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvComm = New System.Windows.Forms.DataGridView
        Me.CommUse = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommodityName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommPriority = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommAARType1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommAARType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommAARType3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvComm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(588, 466)
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
        'chkUse
        '
        Me.chkUse.Location = New System.Drawing.Point(72, 116)
        Me.chkUse.Name = "chkUse"
        Me.chkUse.Size = New System.Drawing.Size(26, 24)
        Me.chkUse.TabIndex = 27
        Me.chkUse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCommName
        '
        Me.txtCommName.Enabled = False
        Me.txtCommName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommName.Location = New System.Drawing.Point(107, 118)
        Me.txtCommName.Name = "txtCommName"
        Me.txtCommName.Size = New System.Drawing.Size(148, 21)
        Me.txtCommName.TabIndex = 3
        '
        'txtCommNotes
        '
        Me.txtCommNotes.Enabled = False
        Me.txtCommNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommNotes.Location = New System.Drawing.Point(579, 118)
        Me.txtCommNotes.Name = "txtCommNotes"
        Me.txtCommNotes.Size = New System.Drawing.Size(98, 21)
        Me.txtCommNotes.TabIndex = 8
        '
        'lblCommUse
        '
        Me.lblCommUse.AutoSize = True
        Me.lblCommUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommUse.Location = New System.Drawing.Point(62, 98)
        Me.lblCommUse.Name = "lblCommUse"
        Me.lblCommUse.Size = New System.Drawing.Size(36, 15)
        Me.lblCommUse.TabIndex = 9
        Me.lblCommUse.Text = "Use?"
        '
        'lblCommName
        '
        Me.lblCommName.AutoSize = True
        Me.lblCommName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommName.Location = New System.Drawing.Point(104, 98)
        Me.lblCommName.Name = "lblCommName"
        Me.lblCommName.Size = New System.Drawing.Size(106, 15)
        Me.lblCommName.TabIndex = 10
        Me.lblCommName.Text = "Commodity Name"
        '
        'lblCommPriority
        '
        Me.lblCommPriority.AutoSize = True
        Me.lblCommPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommPriority.Location = New System.Drawing.Point(258, 98)
        Me.lblCommPriority.Name = "lblCommPriority"
        Me.lblCommPriority.Size = New System.Drawing.Size(44, 15)
        Me.lblCommPriority.TabIndex = 11
        Me.lblCommPriority.Text = "Priority"
        '
        'lblCommCarType1
        '
        Me.lblCommCarType1.AutoSize = True
        Me.lblCommCarType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommCarType1.Location = New System.Drawing.Point(339, 98)
        Me.lblCommCarType1.Name = "lblCommCarType1"
        Me.lblCommCarType1.Size = New System.Drawing.Size(65, 15)
        Me.lblCommCarType1.TabIndex = 12
        Me.lblCommCarType1.Text = "Car Type 1"
        '
        'lblCommCarType2
        '
        Me.lblCommCarType2.AutoSize = True
        Me.lblCommCarType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommCarType2.Location = New System.Drawing.Point(418, 98)
        Me.lblCommCarType2.Name = "lblCommCarType2"
        Me.lblCommCarType2.Size = New System.Drawing.Size(65, 15)
        Me.lblCommCarType2.TabIndex = 13
        Me.lblCommCarType2.Text = "Car Type 2"
        '
        'lblCommCarType3
        '
        Me.lblCommCarType3.AutoSize = True
        Me.lblCommCarType3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommCarType3.Location = New System.Drawing.Point(497, 98)
        Me.lblCommCarType3.Name = "lblCommCarType3"
        Me.lblCommCarType3.Size = New System.Drawing.Size(65, 15)
        Me.lblCommCarType3.TabIndex = 14
        Me.lblCommCarType3.Text = "Car Type 3"
        '
        'lblCommNotes
        '
        Me.lblCommNotes.AutoSize = True
        Me.lblCommNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommNotes.Location = New System.Drawing.Point(576, 98)
        Me.lblCommNotes.Name = "lblCommNotes"
        Me.lblCommNotes.Size = New System.Drawing.Size(39, 15)
        Me.lblCommNotes.TabIndex = 15
        Me.lblCommNotes.Text = "Notes"
        '
        'cboCommCarType1
        '
        Me.cboCommCarType1.Enabled = False
        Me.cboCommCarType1.FormattingEnabled = True
        Me.cboCommCarType1.Location = New System.Drawing.Point(342, 118)
        Me.cboCommCarType1.Name = "cboCommCarType1"
        Me.cboCommCarType1.Size = New System.Drawing.Size(73, 21)
        Me.cboCommCarType1.TabIndex = 16
        '
        'cboCommCarType2
        '
        Me.cboCommCarType2.Enabled = False
        Me.cboCommCarType2.FormattingEnabled = True
        Me.cboCommCarType2.Location = New System.Drawing.Point(421, 118)
        Me.cboCommCarType2.Name = "cboCommCarType2"
        Me.cboCommCarType2.Size = New System.Drawing.Size(73, 21)
        Me.cboCommCarType2.TabIndex = 17
        '
        'cboCommCarType3
        '
        Me.cboCommCarType3.Enabled = False
        Me.cboCommCarType3.FormattingEnabled = True
        Me.cboCommCarType3.Location = New System.Drawing.Point(500, 118)
        Me.cboCommCarType3.Name = "cboCommCarType3"
        Me.cboCommCarType3.Size = New System.Drawing.Size(73, 21)
        Me.cboCommCarType3.TabIndex = 18
        '
        'cboCommPriority
        '
        Me.cboCommPriority.Enabled = False
        Me.cboCommPriority.FormattingEnabled = True
        Me.cboCommPriority.Location = New System.Drawing.Point(261, 118)
        Me.cboCommPriority.Name = "cboCommPriority"
        Me.cboCommPriority.Size = New System.Drawing.Size(75, 21)
        Me.cboCommPriority.TabIndex = 19
        '
        'cmdCommNew
        '
        Me.cmdCommNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommNew.Location = New System.Drawing.Point(57, 44)
        Me.cmdCommNew.Name = "cmdCommNew"
        Me.cmdCommNew.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommNew.TabIndex = 20
        Me.cmdCommNew.Text = "New"
        '
        'cmdCommEdit
        '
        Me.cmdCommEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCommEdit.Location = New System.Drawing.Point(130, 44)
        Me.cmdCommEdit.Name = "cmdCommEdit"
        Me.cmdCommEdit.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommEdit.TabIndex = 21
        Me.cmdCommEdit.Text = "Edit"
        Me.cmdCommEdit.UseVisualStyleBackColor = True
        '
        'cmdCommDelete
        '
        Me.cmdCommDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommDelete.Location = New System.Drawing.Point(621, 44)
        Me.cmdCommDelete.Name = "cmdCommDelete"
        Me.cmdCommDelete.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommDelete.TabIndex = 22
        Me.cmdCommDelete.Text = "Delete"
        '
        'cmdCommSave
        '
        Me.cmdCommSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommSave.Location = New System.Drawing.Point(203, 44)
        Me.cmdCommSave.Name = "cmdCommSave"
        Me.cmdCommSave.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommSave.TabIndex = 23
        Me.cmdCommSave.Text = "Save"
        '
        'cmdCommHelp
        '
        Me.cmdCommHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommHelp.Enabled = False
        Me.cmdCommHelp.Location = New System.Drawing.Point(516, 44)
        Me.cmdCommHelp.Name = "cmdCommHelp"
        Me.cmdCommHelp.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommHelp.TabIndex = 24
        Me.cmdCommHelp.Text = "Help"
        '
        'cmdCommReset
        '
        Me.cmdCommReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCommReset.Location = New System.Drawing.Point(276, 44)
        Me.cmdCommReset.Name = "cmdCommReset"
        Me.cmdCommReset.Size = New System.Drawing.Size(67, 23)
        Me.cmdCommReset.TabIndex = 25
        Me.cmdCommReset.Text = "Reset"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(57, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Show Waybills For Selected Item"
        '
        'dgvComm
        '
        Me.dgvComm.AllowUserToAddRows = False
        Me.dgvComm.AllowUserToDeleteRows = False
        Me.dgvComm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CommUse, Me.CommodityName, Me.CommPriority, Me.CommAARType1, Me.CommAARType2, Me.CommAARType3, Me.CommNotes})
        Me.dgvComm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvComm.Location = New System.Drawing.Point(57, 154)
        Me.dgvComm.MultiSelect = False
        Me.dgvComm.Name = "dgvComm"
        Me.dgvComm.RowHeadersVisible = False
        Me.dgvComm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvComm.Size = New System.Drawing.Size(620, 271)
        Me.dgvComm.TabIndex = 28
        '
        'CommUse
        '
        Me.CommUse.DataPropertyName = "CommUse"
        Me.CommUse.HeaderText = "Use?"
        Me.CommUse.Name = "CommUse"
        Me.CommUse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CommUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CommUse.Width = 50
        '
        'CommodityName
        '
        Me.CommodityName.DataPropertyName = "CommodityName"
        Me.CommodityName.HeaderText = "CommodityName"
        Me.CommodityName.Name = "CommodityName"
        Me.CommodityName.Width = 150
        '
        'CommPriority
        '
        Me.CommPriority.DataPropertyName = "CommPriority"
        Me.CommPriority.HeaderText = "CommPriority"
        Me.CommPriority.Name = "CommPriority"
        Me.CommPriority.Width = 80
        '
        'CommAARType1
        '
        Me.CommAARType1.DataPropertyName = "CommAARType1"
        Me.CommAARType1.HeaderText = "Car Type 1"
        Me.CommAARType1.Name = "CommAARType1"
        Me.CommAARType1.Width = 80
        '
        'CommAARType2
        '
        Me.CommAARType2.DataPropertyName = "CommAARType2"
        Me.CommAARType2.HeaderText = "Car Type 2"
        Me.CommAARType2.Name = "CommAARType2"
        Me.CommAARType2.Width = 80
        '
        'CommAARType3
        '
        Me.CommAARType3.DataPropertyName = "CommAARType3"
        Me.CommAARType3.HeaderText = "Car Type 3"
        Me.CommAARType3.Name = "CommAARType3"
        Me.CommAARType3.Width = 80
        '
        'CommNotes
        '
        Me.CommNotes.DataPropertyName = "CommNotes"
        Me.CommNotes.HeaderText = "Notes"
        Me.CommNotes.Name = "CommNotes"
        Me.CommNotes.Width = 90
        '
        'frmMaintComm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 507)
        Me.Controls.Add(Me.dgvComm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdCommReset)
        Me.Controls.Add(Me.cmdCommHelp)
        Me.Controls.Add(Me.cmdCommSave)
        Me.Controls.Add(Me.cmdCommDelete)
        Me.Controls.Add(Me.cmdCommEdit)
        Me.Controls.Add(Me.cmdCommNew)
        Me.Controls.Add(Me.cboCommPriority)
        Me.Controls.Add(Me.cboCommCarType3)
        Me.Controls.Add(Me.cboCommCarType2)
        Me.Controls.Add(Me.cboCommCarType1)
        Me.Controls.Add(Me.lblCommNotes)
        Me.Controls.Add(Me.lblCommCarType3)
        Me.Controls.Add(Me.lblCommCarType2)
        Me.Controls.Add(Me.lblCommCarType1)
        Me.Controls.Add(Me.lblCommPriority)
        Me.Controls.Add(Me.lblCommName)
        Me.Controls.Add(Me.lblCommUse)
        Me.Controls.Add(Me.txtCommNotes)
        Me.Controls.Add(Me.txtCommName)
        Me.Controls.Add(Me.chkUse)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintComm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Commodities"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvComm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents chkUse As System.Windows.Forms.CheckBox
    Friend WithEvents txtCommName As System.Windows.Forms.TextBox
    Friend WithEvents txtCommNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblCommUse As System.Windows.Forms.Label
    Friend WithEvents lblCommName As System.Windows.Forms.Label
    Friend WithEvents lblCommPriority As System.Windows.Forms.Label
    Friend WithEvents lblCommCarType1 As System.Windows.Forms.Label
    Friend WithEvents lblCommCarType2 As System.Windows.Forms.Label
    Friend WithEvents lblCommCarType3 As System.Windows.Forms.Label
    Friend WithEvents lblCommNotes As System.Windows.Forms.Label
    Friend WithEvents cboCommCarType1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCommCarType2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCommCarType3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCommPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCommNew As System.Windows.Forms.Button
    Friend WithEvents cmdCommEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCommDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCommSave As System.Windows.Forms.Button
    Friend WithEvents cmdCommHelp As System.Windows.Forms.Button
    Friend WithEvents cmdCommReset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ttpMaintComm As System.Windows.Forms.ToolTip
    Friend WithEvents dgvComm As System.Windows.Forms.DataGridView
    Friend WithEvents CommUse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommodityName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommPriority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommAARType1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommAARType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommAARType3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommNotes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
