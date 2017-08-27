<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintSiding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintSiding))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cmdSidReset = New System.Windows.Forms.Button
        Me.cmdSidHelp = New System.Windows.Forms.Button
        Me.cmdSidSave = New System.Windows.Forms.Button
        Me.cmdSidDelete = New System.Windows.Forms.Button
        Me.cmdSidEdit = New System.Windows.Forms.Button
        Me.cmdSidNew = New System.Windows.Forms.Button
        Me.cboSidRR = New System.Windows.Forms.ComboBox
        Me.cboSidFaces = New System.Windows.Forms.ComboBox
        Me.cboSidTown = New System.Windows.Forms.ComboBox
        Me.lblSidFaces = New System.Windows.Forms.Label
        Me.lblSidCarLimit = New System.Windows.Forms.Label
        Me.lblSidTown = New System.Windows.Forms.Label
        Me.lblSidRR = New System.Windows.Forms.Label
        Me.lblSidName = New System.Windows.Forms.Label
        Me.txtSidName = New System.Windows.Forms.TextBox
        Me.dgvSiding = New System.Windows.Forms.DataGridView
        Me.TxtSidNum = New System.Windows.Forms.TextBox
        Me.nudSidCarLimit = New System.Windows.Forms.NumericUpDown
        Me.ttpMaintSiding = New System.Windows.Forms.ToolTip(Me.components)
        Me.SidID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingTown = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingCars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidingFaces = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvSiding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSidCarLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(611, 540)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(46, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Close"
        '
        'cmdSidReset
        '
        Me.cmdSidReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidReset.Location = New System.Drawing.Point(303, 52)
        Me.cmdSidReset.Name = "cmdSidReset"
        Me.cmdSidReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidReset.TabIndex = 46
        Me.cmdSidReset.Text = "Reset"
        '
        'cmdSidHelp
        '
        Me.cmdSidHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidHelp.Enabled = False
        Me.cmdSidHelp.Location = New System.Drawing.Point(531, 52)
        Me.cmdSidHelp.Name = "cmdSidHelp"
        Me.cmdSidHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidHelp.TabIndex = 45
        Me.cmdSidHelp.Text = "Help"
        '
        'cmdSidSave
        '
        Me.cmdSidSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidSave.Location = New System.Drawing.Point(218, 52)
        Me.cmdSidSave.Name = "cmdSidSave"
        Me.cmdSidSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidSave.TabIndex = 44
        Me.cmdSidSave.Text = "Save"
        '
        'cmdSidDelete
        '
        Me.cmdSidDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidDelete.Location = New System.Drawing.Point(653, 52)
        Me.cmdSidDelete.Name = "cmdSidDelete"
        Me.cmdSidDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidDelete.TabIndex = 43
        Me.cmdSidDelete.Text = "Delete"
        '
        'cmdSidEdit
        '
        Me.cmdSidEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSidEdit.Location = New System.Drawing.Point(133, 52)
        Me.cmdSidEdit.Name = "cmdSidEdit"
        Me.cmdSidEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidEdit.TabIndex = 42
        Me.cmdSidEdit.Text = "Edit"
        Me.cmdSidEdit.UseVisualStyleBackColor = True
        '
        'cmdSidNew
        '
        Me.cmdSidNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSidNew.Location = New System.Drawing.Point(47, 52)
        Me.cmdSidNew.Name = "cmdSidNew"
        Me.cmdSidNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdSidNew.TabIndex = 41
        Me.cmdSidNew.Text = "New"
        '
        'cboSidRR
        '
        Me.cboSidRR.Enabled = False
        Me.cboSidRR.FormattingEnabled = True
        Me.cboSidRR.Location = New System.Drawing.Point(269, 134)
        Me.cboSidRR.Name = "cboSidRR"
        Me.cboSidRR.Size = New System.Drawing.Size(144, 23)
        Me.cboSidRR.TabIndex = 40
        '
        'cboSidFaces
        '
        Me.cboSidFaces.Enabled = False
        Me.cboSidFaces.FormattingEnabled = True
        Me.cboSidFaces.Location = New System.Drawing.Point(624, 136)
        Me.cboSidFaces.Name = "cboSidFaces"
        Me.cboSidFaces.Size = New System.Drawing.Size(77, 23)
        Me.cboSidFaces.TabIndex = 39
        '
        'cboSidTown
        '
        Me.cboSidTown.Enabled = False
        Me.cboSidTown.FormattingEnabled = True
        Me.cboSidTown.Location = New System.Drawing.Point(419, 135)
        Me.cboSidTown.Name = "cboSidTown"
        Me.cboSidTown.Size = New System.Drawing.Size(136, 23)
        Me.cboSidTown.TabIndex = 37
        '
        'lblSidFaces
        '
        Me.lblSidFaces.AutoSize = True
        Me.lblSidFaces.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidFaces.Location = New System.Drawing.Point(621, 113)
        Me.lblSidFaces.Name = "lblSidFaces"
        Me.lblSidFaces.Size = New System.Drawing.Size(40, 15)
        Me.lblSidFaces.TabIndex = 35
        Me.lblSidFaces.Text = "Faces"
        '
        'lblSidCarLimit
        '
        Me.lblSidCarLimit.AutoSize = True
        Me.lblSidCarLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidCarLimit.Location = New System.Drawing.Point(558, 113)
        Me.lblSidCarLimit.Name = "lblSidCarLimit"
        Me.lblSidCarLimit.Size = New System.Drawing.Size(56, 15)
        Me.lblSidCarLimit.TabIndex = 34
        Me.lblSidCarLimit.Text = "Car Limit"
        '
        'lblSidTown
        '
        Me.lblSidTown.AutoSize = True
        Me.lblSidTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidTown.Location = New System.Drawing.Point(416, 113)
        Me.lblSidTown.Name = "lblSidTown"
        Me.lblSidTown.Size = New System.Drawing.Size(37, 15)
        Me.lblSidTown.TabIndex = 33
        Me.lblSidTown.Text = "Town"
        '
        'lblSidRR
        '
        Me.lblSidRR.AutoSize = True
        Me.lblSidRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidRR.Location = New System.Drawing.Point(266, 111)
        Me.lblSidRR.Name = "lblSidRR"
        Me.lblSidRR.Size = New System.Drawing.Size(54, 15)
        Me.lblSidRR.TabIndex = 32
        Me.lblSidRR.Text = "Railroad"
        '
        'lblSidName
        '
        Me.lblSidName.AutoSize = True
        Me.lblSidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidName.Location = New System.Drawing.Point(63, 113)
        Me.lblSidName.Name = "lblSidName"
        Me.lblSidName.Size = New System.Drawing.Size(79, 15)
        Me.lblSidName.TabIndex = 31
        Me.lblSidName.Text = "Siding Name"
        '
        'txtSidName
        '
        Me.txtSidName.Enabled = False
        Me.txtSidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSidName.Location = New System.Drawing.Point(66, 136)
        Me.txtSidName.Name = "txtSidName"
        Me.txtSidName.Size = New System.Drawing.Size(196, 21)
        Me.txtSidName.TabIndex = 28
        '
        'dgvSiding
        '
        Me.dgvSiding.AllowUserToAddRows = False
        Me.dgvSiding.AllowUserToDeleteRows = False
        Me.dgvSiding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSiding.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidID, Me.SidingNotes, Me.SidingID, Me.SidingRR, Me.SidingTown, Me.SidingCars, Me.SidingFaces})
        Me.dgvSiding.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSiding.Location = New System.Drawing.Point(66, 181)
        Me.dgvSiding.MultiSelect = False
        Me.dgvSiding.Name = "dgvSiding"
        Me.dgvSiding.RowHeadersVisible = False
        Me.dgvSiding.Size = New System.Drawing.Size(665, 329)
        Me.dgvSiding.TabIndex = 26
        '
        'TxtSidNum
        '
        Me.TxtSidNum.Enabled = False
        Me.TxtSidNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSidNum.Location = New System.Drawing.Point(-1, 2)
        Me.TxtSidNum.Name = "TxtSidNum"
        Me.TxtSidNum.Size = New System.Drawing.Size(54, 21)
        Me.TxtSidNum.TabIndex = 47
        Me.TxtSidNum.Visible = False
        '
        'nudSidCarLimit
        '
        Me.nudSidCarLimit.Location = New System.Drawing.Point(561, 136)
        Me.nudSidCarLimit.Name = "nudSidCarLimit"
        Me.nudSidCarLimit.Size = New System.Drawing.Size(57, 21)
        Me.nudSidCarLimit.TabIndex = 49
        '
        'SidID
        '
        Me.SidID.DataPropertyName = "SidID"
        Me.SidID.HeaderText = "SidID"
        Me.SidID.Name = "SidID"
        Me.SidID.Visible = False
        '
        'SidingNotes
        '
        Me.SidingNotes.DataPropertyName = "SidingNotes"
        Me.SidingNotes.HeaderText = "Siding Name"
        Me.SidingNotes.Name = "SidingNotes"
        Me.SidingNotes.Width = 200
        '
        'SidingID
        '
        Me.SidingID.DataPropertyName = "SidingID"
        Me.SidingID.HeaderText = "Number"
        Me.SidingID.Name = "SidingID"
        Me.SidingID.Visible = False
        Me.SidingID.Width = 60
        '
        'SidingRR
        '
        Me.SidingRR.DataPropertyName = "SidingRR"
        Me.SidingRR.HeaderText = "Railroad"
        Me.SidingRR.Name = "SidingRR"
        Me.SidingRR.Width = 150
        '
        'SidingTown
        '
        Me.SidingTown.DataPropertyName = "SidingTown"
        Me.SidingTown.HeaderText = "Town"
        Me.SidingTown.Name = "SidingTown"
        Me.SidingTown.Width = 140
        '
        'SidingCars
        '
        Me.SidingCars.DataPropertyName = "SidingCars"
        Me.SidingCars.HeaderText = "Car Limit"
        Me.SidingCars.Name = "SidingCars"
        Me.SidingCars.Width = 65
        '
        'SidingFaces
        '
        Me.SidingFaces.DataPropertyName = "SidingFaces"
        Me.SidingFaces.HeaderText = "Faces"
        Me.SidingFaces.Name = "SidingFaces"
        Me.SidingFaces.Width = 80
        '
        'frmMaintSiding
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 585)
        Me.Controls.Add(Me.nudSidCarLimit)
        Me.Controls.Add(Me.TxtSidNum)
        Me.Controls.Add(Me.cmdSidReset)
        Me.Controls.Add(Me.cmdSidHelp)
        Me.Controls.Add(Me.cmdSidSave)
        Me.Controls.Add(Me.cmdSidDelete)
        Me.Controls.Add(Me.cmdSidEdit)
        Me.Controls.Add(Me.cmdSidNew)
        Me.Controls.Add(Me.cboSidRR)
        Me.Controls.Add(Me.cboSidFaces)
        Me.Controls.Add(Me.cboSidTown)
        Me.Controls.Add(Me.lblSidFaces)
        Me.Controls.Add(Me.lblSidCarLimit)
        Me.Controls.Add(Me.lblSidTown)
        Me.Controls.Add(Me.lblSidRR)
        Me.Controls.Add(Me.lblSidName)
        Me.Controls.Add(Me.txtSidName)
        Me.Controls.Add(Me.dgvSiding)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintSiding"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Sidings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvSiding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSidCarLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cmdSidReset As System.Windows.Forms.Button
    Friend WithEvents cmdSidHelp As System.Windows.Forms.Button
    Friend WithEvents cmdSidSave As System.Windows.Forms.Button
    Friend WithEvents cmdSidDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSidEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSidNew As System.Windows.Forms.Button
    Friend WithEvents cboSidRR As System.Windows.Forms.ComboBox
    Friend WithEvents cboSidFaces As System.Windows.Forms.ComboBox
    Friend WithEvents cboSidTown As System.Windows.Forms.ComboBox
    Friend WithEvents lblSidFaces As System.Windows.Forms.Label
    Friend WithEvents lblSidCarLimit As System.Windows.Forms.Label
    Friend WithEvents lblSidTown As System.Windows.Forms.Label
    Friend WithEvents lblSidRR As System.Windows.Forms.Label
    Friend WithEvents lblSidName As System.Windows.Forms.Label
    Friend WithEvents txtSidName As System.Windows.Forms.TextBox
    Friend WithEvents dgvSiding As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSidNum As System.Windows.Forms.TextBox
    Friend WithEvents nudSidCarLimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents ttpMaintSiding As System.Windows.Forms.ToolTip
    Friend WithEvents SidID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingTown As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingCars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidingFaces As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
