<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintRegion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintRegion))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.txtRegionName = New System.Windows.Forms.TextBox
        Me.lblRegName = New System.Windows.Forms.Label
        Me.txtRegionCode = New System.Windows.Forms.TextBox
        Me.lblRegCode = New System.Windows.Forms.Label
        Me.dgvRegion = New System.Windows.Forms.DataGridView
        Me.AARCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AARRegName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdRegionReset = New System.Windows.Forms.Button
        Me.cmdRegionHelp = New System.Windows.Forms.Button
        Me.cmdRegionSave = New System.Windows.Forms.Button
        Me.cmdRegionDelete = New System.Windows.Forms.Button
        Me.cmdRegionEdit = New System.Windows.Forms.Button
        Me.cmdRegionNew = New System.Windows.Forms.Button
        Me.ttpMaintRegion = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvRegion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtRegionName
        '
        Me.txtRegionName.Enabled = False
        Me.txtRegionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegionName.Location = New System.Drawing.Point(253, 106)
        Me.txtRegionName.Name = "txtRegionName"
        Me.txtRegionName.Size = New System.Drawing.Size(229, 21)
        Me.txtRegionName.TabIndex = 133
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegName.Location = New System.Drawing.Point(250, 85)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(84, 15)
        Me.lblRegName.TabIndex = 132
        Me.lblRegName.Text = "Region Name"
        '
        'txtRegionCode
        '
        Me.txtRegionCode.Enabled = False
        Me.txtRegionCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegionCode.Location = New System.Drawing.Point(153, 106)
        Me.txtRegionCode.Name = "txtRegionCode"
        Me.txtRegionCode.Size = New System.Drawing.Size(94, 21)
        Me.txtRegionCode.TabIndex = 131
        '
        'lblRegCode
        '
        Me.lblRegCode.AutoSize = True
        Me.lblRegCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCode.Location = New System.Drawing.Point(150, 85)
        Me.lblRegCode.Name = "lblRegCode"
        Me.lblRegCode.Size = New System.Drawing.Size(79, 15)
        Me.lblRegCode.TabIndex = 130
        Me.lblRegCode.Text = "Region Code"
        '
        'dgvRegion
        '
        Me.dgvRegion.AllowUserToAddRows = False
        Me.dgvRegion.AllowUserToDeleteRows = False
        Me.dgvRegion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AARCode, Me.AARRegName})
        Me.dgvRegion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRegion.Location = New System.Drawing.Point(153, 142)
        Me.dgvRegion.MultiSelect = False
        Me.dgvRegion.Name = "dgvRegion"
        Me.dgvRegion.RowHeadersVisible = False
        Me.dgvRegion.Size = New System.Drawing.Size(329, 137)
        Me.dgvRegion.TabIndex = 129
        '
        'AARCode
        '
        Me.AARCode.DataPropertyName = "AARCode"
        Me.AARCode.HeaderText = "Region Code"
        Me.AARCode.Name = "AARCode"
        '
        'AARRegName
        '
        Me.AARRegName.DataPropertyName = "AARRegName"
        Me.AARRegName.HeaderText = "Region Name"
        Me.AARRegName.Name = "AARRegName"
        Me.AARRegName.Width = 200
        '
        'cmdRegionReset
        '
        Me.cmdRegionReset.Location = New System.Drawing.Point(301, 46)
        Me.cmdRegionReset.Name = "cmdRegionReset"
        Me.cmdRegionReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionReset.TabIndex = 128
        Me.cmdRegionReset.Text = "Reset"
        '
        'cmdRegionHelp
        '
        Me.cmdRegionHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRegionHelp.Enabled = False
        Me.cmdRegionHelp.Location = New System.Drawing.Point(422, 46)
        Me.cmdRegionHelp.Name = "cmdRegionHelp"
        Me.cmdRegionHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionHelp.TabIndex = 127
        Me.cmdRegionHelp.Text = "Help"
        '
        'cmdRegionSave
        '
        Me.cmdRegionSave.Location = New System.Drawing.Point(216, 46)
        Me.cmdRegionSave.Name = "cmdRegionSave"
        Me.cmdRegionSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionSave.TabIndex = 126
        Me.cmdRegionSave.Text = "Save"
        '
        'cmdRegionDelete
        '
        Me.cmdRegionDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRegionDelete.Location = New System.Drawing.Point(507, 46)
        Me.cmdRegionDelete.Name = "cmdRegionDelete"
        Me.cmdRegionDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionDelete.TabIndex = 125
        Me.cmdRegionDelete.Text = "Delete"
        '
        'cmdRegionEdit
        '
        Me.cmdRegionEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRegionEdit.Location = New System.Drawing.Point(131, 46)
        Me.cmdRegionEdit.Name = "cmdRegionEdit"
        Me.cmdRegionEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionEdit.TabIndex = 124
        Me.cmdRegionEdit.Text = "Edit"
        Me.cmdRegionEdit.UseVisualStyleBackColor = True
        '
        'cmdRegionNew
        '
        Me.cmdRegionNew.Location = New System.Drawing.Point(45, 46)
        Me.cmdRegionNew.Name = "cmdRegionNew"
        Me.cmdRegionNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdRegionNew.TabIndex = 123
        Me.cmdRegionNew.Text = "New"
        '
        'frmMaintRegion
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 347)
        Me.Controls.Add(Me.txtRegionName)
        Me.Controls.Add(Me.lblRegName)
        Me.Controls.Add(Me.txtRegionCode)
        Me.Controls.Add(Me.lblRegCode)
        Me.Controls.Add(Me.dgvRegion)
        Me.Controls.Add(Me.cmdRegionReset)
        Me.Controls.Add(Me.cmdRegionHelp)
        Me.Controls.Add(Me.cmdRegionSave)
        Me.Controls.Add(Me.cmdRegionDelete)
        Me.Controls.Add(Me.cmdRegionEdit)
        Me.Controls.Add(Me.cmdRegionNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintRegion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Region"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvRegion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtRegionName As System.Windows.Forms.TextBox
    Friend WithEvents lblRegName As System.Windows.Forms.Label
    Friend WithEvents txtRegionCode As System.Windows.Forms.TextBox
    Friend WithEvents lblRegCode As System.Windows.Forms.Label
    Friend WithEvents dgvRegion As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRegionReset As System.Windows.Forms.Button
    Friend WithEvents cmdRegionHelp As System.Windows.Forms.Button
    Friend WithEvents cmdRegionSave As System.Windows.Forms.Button
    Friend WithEvents cmdRegionDelete As System.Windows.Forms.Button
    Friend WithEvents cmdRegionEdit As System.Windows.Forms.Button
    Friend WithEvents cmdRegionNew As System.Windows.Forms.Button
    Friend WithEvents AARCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARRegName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttpMaintRegion As System.Windows.Forms.ToolTip

End Class
