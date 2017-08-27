<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintDiv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintDiv))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblDivEndPointEast = New System.Windows.Forms.Label()
        Me.txtDivName = New System.Windows.Forms.TextBox()
        Me.lblDivName = New System.Windows.Forms.Label()
        Me.txtDivNum = New System.Windows.Forms.TextBox()
        Me.lblDivNum = New System.Windows.Forms.Label()
        Me.dgvDiv = New System.Windows.Forms.DataGridView()
        Me.DivNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivEndPointEast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivEndPointWest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdDivReset = New System.Windows.Forms.Button()
        Me.cmdDivHelp = New System.Windows.Forms.Button()
        Me.cmdDivSave = New System.Windows.Forms.Button()
        Me.cmdDivDelete = New System.Windows.Forms.Button()
        Me.cmdDivEdit = New System.Windows.Forms.Button()
        Me.cmdDivNew = New System.Windows.Forms.Button()
        Me.cboEndPointEast = New System.Windows.Forms.ComboBox()
        Me.cboEndPointWest = New System.Windows.Forms.ComboBox()
        Me.lblDivEndPointWest = New System.Windows.Forms.Label()
        Me.ttpMaintDiv = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDiv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(464, 300)
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
        'lblDivEndPointEast
        '
        Me.lblDivEndPointEast.AutoSize = True
        Me.lblDivEndPointEast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivEndPointEast.Location = New System.Drawing.Point(310, 82)
        Me.lblDivEndPointEast.Name = "lblDivEndPointEast"
        Me.lblDivEndPointEast.Size = New System.Drawing.Size(87, 15)
        Me.lblDivEndPointEast.TabIndex = 147
        Me.lblDivEndPointEast.Text = "End Point East"
        '
        'txtDivName
        '
        Me.txtDivName.Enabled = False
        Me.txtDivName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivName.Location = New System.Drawing.Point(163, 105)
        Me.txtDivName.Name = "txtDivName"
        Me.txtDivName.Size = New System.Drawing.Size(144, 21)
        Me.txtDivName.TabIndex = 146
        '
        'lblDivName
        '
        Me.lblDivName.AutoSize = True
        Me.lblDivName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivName.Location = New System.Drawing.Point(160, 82)
        Me.lblDivName.Name = "lblDivName"
        Me.lblDivName.Size = New System.Drawing.Size(87, 15)
        Me.lblDivName.TabIndex = 145
        Me.lblDivName.Text = "Division Name"
        '
        'txtDivNum
        '
        Me.txtDivNum.Enabled = False
        Me.txtDivNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivNum.Location = New System.Drawing.Point(87, 105)
        Me.txtDivNum.Name = "txtDivNum"
        Me.txtDivNum.Size = New System.Drawing.Size(70, 21)
        Me.txtDivNum.TabIndex = 144
        '
        'lblDivNum
        '
        Me.lblDivNum.AutoSize = True
        Me.lblDivNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivNum.Location = New System.Drawing.Point(84, 82)
        Me.lblDivNum.Name = "lblDivNum"
        Me.lblDivNum.Size = New System.Drawing.Size(49, 15)
        Me.lblDivNum.TabIndex = 143
        Me.lblDivNum.Text = "Div. No."
        '
        'dgvDiv
        '
        Me.dgvDiv.AllowUserToAddRows = False
        Me.dgvDiv.AllowUserToDeleteRows = False
        Me.dgvDiv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DivNum, Me.DivName, Me.DivEndPointEast, Me.DivEndPointWest})
        Me.dgvDiv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDiv.Location = New System.Drawing.Point(87, 142)
        Me.dgvDiv.MultiSelect = False
        Me.dgvDiv.Name = "dgvDiv"
        Me.dgvDiv.RowHeadersVisible = False
        Me.dgvDiv.Size = New System.Drawing.Size(438, 137)
        Me.dgvDiv.TabIndex = 142
        '
        'DivNum
        '
        Me.DivNum.DataPropertyName = "DivNum"
        Me.DivNum.HeaderText = "Div. No."
        Me.DivNum.Name = "DivNum"
        Me.DivNum.Width = 75
        '
        'DivName
        '
        Me.DivName.DataPropertyName = "DivName"
        Me.DivName.HeaderText = "Division Name"
        Me.DivName.Name = "DivName"
        Me.DivName.Width = 150
        '
        'DivEndPointEast
        '
        Me.DivEndPointEast.DataPropertyName = "DivEndPointEast"
        Me.DivEndPointEast.HeaderText = "End Point East"
        Me.DivEndPointEast.Name = "DivEndPointEast"
        '
        'DivEndPointWest
        '
        Me.DivEndPointWest.DataPropertyName = "DivEndPointWest"
        Me.DivEndPointWest.HeaderText = "End Point West"
        Me.DivEndPointWest.Name = "DivEndPointWest"
        '
        'cmdDivReset
        '
        Me.cmdDivReset.Location = New System.Drawing.Point(294, 35)
        Me.cmdDivReset.Name = "cmdDivReset"
        Me.cmdDivReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivReset.TabIndex = 141
        Me.cmdDivReset.Text = "Reset"
        '
        'cmdDivHelp
        '
        Me.cmdDivHelp.Enabled = False
        Me.cmdDivHelp.Location = New System.Drawing.Point(378, 35)
        Me.cmdDivHelp.Name = "cmdDivHelp"
        Me.cmdDivHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivHelp.TabIndex = 140
        Me.cmdDivHelp.Text = "Help"
        '
        'cmdDivSave
        '
        Me.cmdDivSave.Location = New System.Drawing.Point(209, 35)
        Me.cmdDivSave.Name = "cmdDivSave"
        Me.cmdDivSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivSave.TabIndex = 139
        Me.cmdDivSave.Text = "Save"
        '
        'cmdDivDelete
        '
        Me.cmdDivDelete.Location = New System.Drawing.Point(500, 35)
        Me.cmdDivDelete.Name = "cmdDivDelete"
        Me.cmdDivDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivDelete.TabIndex = 138
        Me.cmdDivDelete.Text = "Delete"
        '
        'cmdDivEdit
        '
        Me.cmdDivEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDivEdit.Location = New System.Drawing.Point(124, 35)
        Me.cmdDivEdit.Name = "cmdDivEdit"
        Me.cmdDivEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivEdit.TabIndex = 137
        Me.cmdDivEdit.Text = "Edit"
        Me.cmdDivEdit.UseVisualStyleBackColor = True
        '
        'cmdDivNew
        '
        Me.cmdDivNew.Location = New System.Drawing.Point(38, 35)
        Me.cmdDivNew.Name = "cmdDivNew"
        Me.cmdDivNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdDivNew.TabIndex = 136
        Me.cmdDivNew.Text = "New"
        '
        'cboEndPointEast
        '
        Me.cboEndPointEast.FormattingEnabled = True
        Me.cboEndPointEast.Location = New System.Drawing.Point(313, 105)
        Me.cboEndPointEast.Name = "cboEndPointEast"
        Me.cboEndPointEast.Size = New System.Drawing.Size(93, 21)
        Me.cboEndPointEast.TabIndex = 148
        '
        'cboEndPointWest
        '
        Me.cboEndPointWest.FormattingEnabled = True
        Me.cboEndPointWest.Location = New System.Drawing.Point(412, 105)
        Me.cboEndPointWest.Name = "cboEndPointWest"
        Me.cboEndPointWest.Size = New System.Drawing.Size(93, 21)
        Me.cboEndPointWest.TabIndex = 149
        '
        'lblDivEndPointWest
        '
        Me.lblDivEndPointWest.AutoSize = True
        Me.lblDivEndPointWest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivEndPointWest.Location = New System.Drawing.Point(409, 82)
        Me.lblDivEndPointWest.Name = "lblDivEndPointWest"
        Me.lblDivEndPointWest.Size = New System.Drawing.Size(90, 15)
        Me.lblDivEndPointWest.TabIndex = 150
        Me.lblDivEndPointWest.Text = "End Point West"
        '
        'frmMaintDiv
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 341)
        Me.Controls.Add(Me.lblDivEndPointWest)
        Me.Controls.Add(Me.cboEndPointWest)
        Me.Controls.Add(Me.cboEndPointEast)
        Me.Controls.Add(Me.lblDivEndPointEast)
        Me.Controls.Add(Me.txtDivName)
        Me.Controls.Add(Me.lblDivName)
        Me.Controls.Add(Me.txtDivNum)
        Me.Controls.Add(Me.lblDivNum)
        Me.Controls.Add(Me.dgvDiv)
        Me.Controls.Add(Me.cmdDivReset)
        Me.Controls.Add(Me.cmdDivHelp)
        Me.Controls.Add(Me.cmdDivSave)
        Me.Controls.Add(Me.cmdDivDelete)
        Me.Controls.Add(Me.cmdDivEdit)
        Me.Controls.Add(Me.cmdDivNew)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintDiv"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Divisions"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvDiv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblDivEndPointEast As System.Windows.Forms.Label
    Friend WithEvents txtDivName As System.Windows.Forms.TextBox
    Friend WithEvents lblDivName As System.Windows.Forms.Label
    Friend WithEvents txtDivNum As System.Windows.Forms.TextBox
    Friend WithEvents lblDivNum As System.Windows.Forms.Label
    Friend WithEvents dgvDiv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDivReset As System.Windows.Forms.Button
    Friend WithEvents cmdDivHelp As System.Windows.Forms.Button
    Friend WithEvents cmdDivSave As System.Windows.Forms.Button
    Friend WithEvents cmdDivDelete As System.Windows.Forms.Button
    Friend WithEvents cmdDivEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDivNew As System.Windows.Forms.Button
    Friend WithEvents cboEndPointEast As System.Windows.Forms.ComboBox
    Friend WithEvents cboEndPointWest As System.Windows.Forms.ComboBox
    Friend WithEvents lblDivEndPointWest As System.Windows.Forms.Label
    Friend WithEvents DivNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DivName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DivEndPointEast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DivEndPointWest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttpMaintDiv As System.Windows.Forms.ToolTip

End Class
