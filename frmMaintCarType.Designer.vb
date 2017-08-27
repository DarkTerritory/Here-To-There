<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintCarType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintCarType))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cmdCarTypeReset = New System.Windows.Forms.Button
        Me.cmdCarTypeHelp = New System.Windows.Forms.Button
        Me.cmdCarTypeSave = New System.Windows.Forms.Button
        Me.cmdCarTypeDelete = New System.Windows.Forms.Button
        Me.cmdCarTypeEdit = New System.Windows.Forms.Button
        Me.cmdCarTypeNew = New System.Windows.Forms.Button
        Me.dgvCarType = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AARCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AARDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCarTypeCode = New System.Windows.Forms.TextBox
        Me.lblCarTypeCode = New System.Windows.Forms.Label
        Me.txtCarTypeDesc = New System.Windows.Forms.TextBox
        Me.lblCarTypeDesc = New System.Windows.Forms.Label
        Me.ttpMaintCarType = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvCarType, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmdCarTypeReset
        '
        Me.cmdCarTypeReset.Location = New System.Drawing.Point(301, 46)
        Me.cmdCarTypeReset.Name = "cmdCarTypeReset"
        Me.cmdCarTypeReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeReset.TabIndex = 117
        Me.cmdCarTypeReset.Text = "Reset"
        '
        'cmdCarTypeHelp
        '
        Me.cmdCarTypeHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCarTypeHelp.Enabled = False
        Me.cmdCarTypeHelp.Location = New System.Drawing.Point(422, 46)
        Me.cmdCarTypeHelp.Name = "cmdCarTypeHelp"
        Me.cmdCarTypeHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeHelp.TabIndex = 116
        Me.cmdCarTypeHelp.Text = "Help"
        '
        'cmdCarTypeSave
        '
        Me.cmdCarTypeSave.Location = New System.Drawing.Point(216, 46)
        Me.cmdCarTypeSave.Name = "cmdCarTypeSave"
        Me.cmdCarTypeSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeSave.TabIndex = 115
        Me.cmdCarTypeSave.Text = "Save"
        '
        'cmdCarTypeDelete
        '
        Me.cmdCarTypeDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCarTypeDelete.Location = New System.Drawing.Point(507, 46)
        Me.cmdCarTypeDelete.Name = "cmdCarTypeDelete"
        Me.cmdCarTypeDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeDelete.TabIndex = 114
        Me.cmdCarTypeDelete.Text = "Delete"
        '
        'cmdCarTypeEdit
        '
        Me.cmdCarTypeEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCarTypeEdit.Location = New System.Drawing.Point(131, 46)
        Me.cmdCarTypeEdit.Name = "cmdCarTypeEdit"
        Me.cmdCarTypeEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeEdit.TabIndex = 113
        Me.cmdCarTypeEdit.Text = "Edit"
        Me.cmdCarTypeEdit.UseVisualStyleBackColor = True
        '
        'cmdCarTypeNew
        '
        Me.cmdCarTypeNew.Location = New System.Drawing.Point(45, 46)
        Me.cmdCarTypeNew.Name = "cmdCarTypeNew"
        Me.cmdCarTypeNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdCarTypeNew.TabIndex = 112
        Me.cmdCarTypeNew.Text = "New"
        '
        'dgvCarType
        '
        Me.dgvCarType.AllowUserToAddRows = False
        Me.dgvCarType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCarType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.AARCode, Me.AARDesc})
        Me.dgvCarType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCarType.Location = New System.Drawing.Point(134, 145)
        Me.dgvCarType.MultiSelect = False
        Me.dgvCarType.Name = "dgvCarType"
        Me.dgvCarType.RowHeadersVisible = False
        Me.dgvCarType.Size = New System.Drawing.Size(348, 137)
        Me.dgvCarType.TabIndex = 118
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "RecID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        Me.ID.Width = 50
        '
        'AARCode
        '
        Me.AARCode.DataPropertyName = "AARCode"
        Me.AARCode.HeaderText = "AAR Code"
        Me.AARCode.Name = "AARCode"
        '
        'AARDesc
        '
        Me.AARDesc.DataPropertyName = "AARDesc"
        Me.AARDesc.HeaderText = "Description"
        Me.AARDesc.Name = "AARDesc"
        Me.AARDesc.Width = 200
        '
        'txtCarTypeCode
        '
        Me.txtCarTypeCode.Enabled = False
        Me.txtCarTypeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarTypeCode.Location = New System.Drawing.Point(134, 109)
        Me.txtCarTypeCode.Name = "txtCarTypeCode"
        Me.txtCarTypeCode.Size = New System.Drawing.Size(94, 21)
        Me.txtCarTypeCode.TabIndex = 120
        '
        'lblCarTypeCode
        '
        Me.lblCarTypeCode.AutoSize = True
        Me.lblCarTypeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarTypeCode.Location = New System.Drawing.Point(131, 86)
        Me.lblCarTypeCode.Name = "lblCarTypeCode"
        Me.lblCarTypeCode.Size = New System.Drawing.Size(62, 15)
        Me.lblCarTypeCode.TabIndex = 119
        Me.lblCarTypeCode.Text = "AAR Code"
        '
        'txtCarTypeDesc
        '
        Me.txtCarTypeDesc.Enabled = False
        Me.txtCarTypeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarTypeDesc.Location = New System.Drawing.Point(234, 109)
        Me.txtCarTypeDesc.Name = "txtCarTypeDesc"
        Me.txtCarTypeDesc.Size = New System.Drawing.Size(229, 21)
        Me.txtCarTypeDesc.TabIndex = 122
        '
        'lblCarTypeDesc
        '
        Me.lblCarTypeDesc.AutoSize = True
        Me.lblCarTypeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarTypeDesc.Location = New System.Drawing.Point(231, 86)
        Me.lblCarTypeDesc.Name = "lblCarTypeDesc"
        Me.lblCarTypeDesc.Size = New System.Drawing.Size(69, 15)
        Me.lblCarTypeDesc.TabIndex = 121
        Me.lblCarTypeDesc.Text = "Description"
        '
        'frmMaintCarType
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 347)
        Me.Controls.Add(Me.txtCarTypeDesc)
        Me.Controls.Add(Me.lblCarTypeDesc)
        Me.Controls.Add(Me.txtCarTypeCode)
        Me.Controls.Add(Me.lblCarTypeCode)
        Me.Controls.Add(Me.dgvCarType)
        Me.Controls.Add(Me.cmdCarTypeReset)
        Me.Controls.Add(Me.cmdCarTypeHelp)
        Me.Controls.Add(Me.cmdCarTypeSave)
        Me.Controls.Add(Me.cmdCarTypeDelete)
        Me.Controls.Add(Me.cmdCarTypeEdit)
        Me.Controls.Add(Me.cmdCarTypeNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintCarType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain Car Type"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvCarType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeReset As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeHelp As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeSave As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCarTypeNew As System.Windows.Forms.Button
    Friend WithEvents dgvCarType As System.Windows.Forms.DataGridView
    Friend WithEvents txtCarTypeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCarTypeCode As System.Windows.Forms.Label
    Friend WithEvents txtCarTypeDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblCarTypeDesc As System.Windows.Forms.Label
    Friend WithEvents ttpMaintCarType As System.Windows.Forms.ToolTip
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARDesc As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
