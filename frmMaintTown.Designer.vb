<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaintTown
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintTown))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblTownState = New System.Windows.Forms.Label()
        Me.TxtTownCallSign = New System.Windows.Forms.TextBox()
        Me.cmdTownReset = New System.Windows.Forms.Button()
        Me.cmdTownHelp = New System.Windows.Forms.Button()
        Me.cmdTownSave = New System.Windows.Forms.Button()
        Me.cmdTownDelete = New System.Windows.Forms.Button()
        Me.cmdTownEdit = New System.Windows.Forms.Button()
        Me.cmdTownNew = New System.Windows.Forms.Button()
        Me.cboTownState = New System.Windows.Forms.ComboBox()
        Me.cboTownDiv = New System.Windows.Forms.ComboBox()
        Me.cboTownServedBy = New System.Windows.Forms.ComboBox()
        Me.lblTownDivision = New System.Windows.Forms.Label()
        Me.lblTownServedBy = New System.Windows.Forms.Label()
        Me.lblTownFreightHub = New System.Windows.Forms.Label()
        Me.lblTownCallSign = New System.Windows.Forms.Label()
        Me.lblTownName = New System.Windows.Forms.Label()
        Me.txtTownName = New System.Windows.Forms.TextBox()
        Me.dgvTown = New System.Windows.Forms.DataGridView()
        Me.TownName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownCallSign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownFrtHub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownServedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownDiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownEastOf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownWestOf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sidings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboTownFrtHub = New System.Windows.Forms.ComboBox()
        Me.txtTownID = New System.Windows.Forms.TextBox()
        Me.lblTownID = New System.Windows.Forms.Label()
        Me.cboTownLocal = New System.Windows.Forms.ComboBox()
        Me.lblTownLocal = New System.Windows.Forms.Label()
        Me.ttpMaintTown = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEastOf = New System.Windows.Forms.Label()
        Me.lblWestOf = New System.Windows.Forms.Label()
        Me.cboTownEastOf = New System.Windows.Forms.ComboBox()
        Me.cboTownWestOf = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(957, 507)
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
        'lblTownState
        '
        Me.lblTownState.AutoSize = True
        Me.lblTownState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownState.Location = New System.Drawing.Point(241, 113)
        Me.lblTownState.Name = "lblTownState"
        Me.lblTownState.Size = New System.Drawing.Size(35, 15)
        Me.lblTownState.TabIndex = 67
        Me.lblTownState.Text = "State"
        '
        'TxtTownCallSign
        '
        Me.TxtTownCallSign.Enabled = False
        Me.TxtTownCallSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTownCallSign.Location = New System.Drawing.Point(323, 135)
        Me.TxtTownCallSign.Name = "TxtTownCallSign"
        Me.TxtTownCallSign.Size = New System.Drawing.Size(76, 21)
        Me.TxtTownCallSign.TabIndex = 66
        '
        'cmdTownReset
        '
        Me.cmdTownReset.Location = New System.Drawing.Point(310, 34)
        Me.cmdTownReset.Name = "cmdTownReset"
        Me.cmdTownReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownReset.TabIndex = 65
        Me.cmdTownReset.Text = "Reset"
        '
        'cmdTownHelp
        '
        Me.cmdTownHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTownHelp.Enabled = False
        Me.cmdTownHelp.Location = New System.Drawing.Point(835, 34)
        Me.cmdTownHelp.Name = "cmdTownHelp"
        Me.cmdTownHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownHelp.TabIndex = 64
        Me.cmdTownHelp.Text = "Help"
        '
        'cmdTownSave
        '
        Me.cmdTownSave.Location = New System.Drawing.Point(225, 34)
        Me.cmdTownSave.Name = "cmdTownSave"
        Me.cmdTownSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownSave.TabIndex = 63
        Me.cmdTownSave.Text = "Save"
        '
        'cmdTownDelete
        '
        Me.cmdTownDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTownDelete.Location = New System.Drawing.Point(957, 34)
        Me.cmdTownDelete.Name = "cmdTownDelete"
        Me.cmdTownDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownDelete.TabIndex = 62
        Me.cmdTownDelete.Text = "Delete"
        '
        'cmdTownEdit
        '
        Me.cmdTownEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTownEdit.Location = New System.Drawing.Point(140, 34)
        Me.cmdTownEdit.Name = "cmdTownEdit"
        Me.cmdTownEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownEdit.TabIndex = 61
        Me.cmdTownEdit.Text = "Edit"
        Me.cmdTownEdit.UseVisualStyleBackColor = True
        '
        'cmdTownNew
        '
        Me.cmdTownNew.Location = New System.Drawing.Point(54, 34)
        Me.cmdTownNew.Name = "cmdTownNew"
        Me.cmdTownNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdTownNew.TabIndex = 60
        Me.cmdTownNew.Text = "New"
        '
        'cboTownState
        '
        Me.cboTownState.Enabled = False
        Me.cboTownState.FormattingEnabled = True
        Me.cboTownState.Location = New System.Drawing.Point(244, 135)
        Me.cboTownState.Name = "cboTownState"
        Me.cboTownState.Size = New System.Drawing.Size(73, 21)
        Me.cboTownState.TabIndex = 59
        '
        'cboTownDiv
        '
        Me.cboTownDiv.Enabled = False
        Me.cboTownDiv.FormattingEnabled = True
        Me.cboTownDiv.Location = New System.Drawing.Point(584, 135)
        Me.cboTownDiv.Name = "cboTownDiv"
        Me.cboTownDiv.Size = New System.Drawing.Size(118, 21)
        Me.cboTownDiv.TabIndex = 58
        '
        'cboTownServedBy
        '
        Me.cboTownServedBy.Enabled = False
        Me.cboTownServedBy.FormattingEnabled = True
        Me.cboTownServedBy.Location = New System.Drawing.Point(486, 135)
        Me.cboTownServedBy.Name = "cboTownServedBy"
        Me.cboTownServedBy.Size = New System.Drawing.Size(92, 21)
        Me.cboTownServedBy.TabIndex = 57
        '
        'lblTownDivision
        '
        Me.lblTownDivision.AutoSize = True
        Me.lblTownDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownDivision.Location = New System.Drawing.Point(581, 112)
        Me.lblTownDivision.Name = "lblTownDivision"
        Me.lblTownDivision.Size = New System.Drawing.Size(50, 15)
        Me.lblTownDivision.TabIndex = 56
        Me.lblTownDivision.Text = "Division"
        '
        'lblTownServedBy
        '
        Me.lblTownServedBy.AutoSize = True
        Me.lblTownServedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownServedBy.Location = New System.Drawing.Point(483, 112)
        Me.lblTownServedBy.Name = "lblTownServedBy"
        Me.lblTownServedBy.Size = New System.Drawing.Size(61, 15)
        Me.lblTownServedBy.TabIndex = 55
        Me.lblTownServedBy.Text = "Served By"
        '
        'lblTownFreightHub
        '
        Me.lblTownFreightHub.AutoSize = True
        Me.lblTownFreightHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownFreightHub.Location = New System.Drawing.Point(402, 112)
        Me.lblTownFreightHub.Name = "lblTownFreightHub"
        Me.lblTownFreightHub.Size = New System.Drawing.Size(78, 15)
        Me.lblTownFreightHub.TabIndex = 54
        Me.lblTownFreightHub.Text = "Freight Hub?"
        '
        'lblTownCallSign
        '
        Me.lblTownCallSign.AutoSize = True
        Me.lblTownCallSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownCallSign.Location = New System.Drawing.Point(320, 112)
        Me.lblTownCallSign.Name = "lblTownCallSign"
        Me.lblTownCallSign.Size = New System.Drawing.Size(56, 15)
        Me.lblTownCallSign.TabIndex = 53
        Me.lblTownCallSign.Text = "Call Sign"
        '
        'lblTownName
        '
        Me.lblTownName.AutoSize = True
        Me.lblTownName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownName.Location = New System.Drawing.Point(39, 113)
        Me.lblTownName.Name = "lblTownName"
        Me.lblTownName.Size = New System.Drawing.Size(74, 15)
        Me.lblTownName.TabIndex = 52
        Me.lblTownName.Text = "Town Name"
        '
        'txtTownName
        '
        Me.txtTownName.Enabled = False
        Me.txtTownName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTownName.Location = New System.Drawing.Point(42, 135)
        Me.txtTownName.Name = "txtTownName"
        Me.txtTownName.Size = New System.Drawing.Size(145, 21)
        Me.txtTownName.TabIndex = 51
        '
        'dgvTown
        '
        Me.dgvTown.AllowUserToAddRows = False
        Me.dgvTown.AllowUserToDeleteRows = False
        Me.dgvTown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTown.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TownName, Me.TownID, Me.TownState, Me.TownCallSign, Me.TownFrtHub, Me.TownServedBy, Me.TownDiv, Me.TownEastOf, Me.TownWestOf, Me.TownLocal, Me.Sidings})
        Me.dgvTown.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTown.Location = New System.Drawing.Point(42, 181)
        Me.dgvTown.MultiSelect = False
        Me.dgvTown.Name = "dgvTown"
        Me.dgvTown.RowHeadersVisible = False
        Me.dgvTown.Size = New System.Drawing.Size(1021, 306)
        Me.dgvTown.TabIndex = 50
        '
        'TownName
        '
        Me.TownName.DataPropertyName = "TownName"
        Me.TownName.HeaderText = "Town Name"
        Me.TownName.Name = "TownName"
        Me.TownName.Width = 150
        '
        'TownID
        '
        Me.TownID.DataPropertyName = "TownID"
        Me.TownID.HeaderText = "ID #"
        Me.TownID.Name = "TownID"
        Me.TownID.Width = 50
        '
        'TownState
        '
        Me.TownState.DataPropertyName = "TownState"
        Me.TownState.HeaderText = "State"
        Me.TownState.Name = "TownState"
        Me.TownState.Width = 80
        '
        'TownCallSign
        '
        Me.TownCallSign.DataPropertyName = "TownCallSign"
        Me.TownCallSign.HeaderText = "Call Sign"
        Me.TownCallSign.Name = "TownCallSign"
        Me.TownCallSign.Width = 80
        '
        'TownFrtHub
        '
        Me.TownFrtHub.DataPropertyName = "TownFrtHub"
        Me.TownFrtHub.HeaderText = "Freight Hub"
        Me.TownFrtHub.Name = "TownFrtHub"
        Me.TownFrtHub.Width = 80
        '
        'TownServedBy
        '
        Me.TownServedBy.DataPropertyName = "TownServedBy"
        Me.TownServedBy.HeaderText = "Served By"
        Me.TownServedBy.Name = "TownServedBy"
        '
        'TownDiv
        '
        Me.TownDiv.DataPropertyName = "TownDiv"
        Me.TownDiv.HeaderText = "Division"
        Me.TownDiv.Name = "TownDiv"
        Me.TownDiv.Width = 125
        '
        'TownEastOf
        '
        Me.TownEastOf.DataPropertyName = "TownEastOf"
        Me.TownEastOf.HeaderText = "East Of"
        Me.TownEastOf.Name = "TownEastOf"
        '
        'TownWestOf
        '
        Me.TownWestOf.DataPropertyName = "TownWestOf"
        Me.TownWestOf.HeaderText = "West Of"
        Me.TownWestOf.Name = "TownWestOf"
        '
        'TownLocal
        '
        Me.TownLocal.DataPropertyName = "TownLocal"
        Me.TownLocal.FillWeight = 75.0!
        Me.TownLocal.HeaderText = "Local"
        Me.TownLocal.Name = "TownLocal"
        Me.TownLocal.Width = 75
        '
        'Sidings
        '
        Me.Sidings.DataPropertyName = "Sidings"
        Me.Sidings.FillWeight = 75.0!
        Me.Sidings.HeaderText = "Sidings"
        Me.Sidings.Name = "Sidings"
        Me.Sidings.Width = 75
        '
        'cboTownFrtHub
        '
        Me.cboTownFrtHub.Enabled = False
        Me.cboTownFrtHub.FormattingEnabled = True
        Me.cboTownFrtHub.Location = New System.Drawing.Point(405, 135)
        Me.cboTownFrtHub.Name = "cboTownFrtHub"
        Me.cboTownFrtHub.Size = New System.Drawing.Size(75, 21)
        Me.cboTownFrtHub.TabIndex = 69
        '
        'txtTownID
        '
        Me.txtTownID.Enabled = False
        Me.txtTownID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTownID.Location = New System.Drawing.Point(193, 135)
        Me.txtTownID.Name = "txtTownID"
        Me.txtTownID.Size = New System.Drawing.Size(45, 21)
        Me.txtTownID.TabIndex = 71
        '
        'lblTownID
        '
        Me.lblTownID.AutoSize = True
        Me.lblTownID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownID.Location = New System.Drawing.Point(190, 112)
        Me.lblTownID.Name = "lblTownID"
        Me.lblTownID.Size = New System.Drawing.Size(29, 15)
        Me.lblTownID.TabIndex = 70
        Me.lblTownID.Text = "ID #"
        '
        'cboTownLocal
        '
        Me.cboTownLocal.Enabled = False
        Me.cboTownLocal.FormattingEnabled = True
        Me.cboTownLocal.Location = New System.Drawing.Point(909, 135)
        Me.cboTownLocal.Name = "cboTownLocal"
        Me.cboTownLocal.Size = New System.Drawing.Size(70, 21)
        Me.cboTownLocal.TabIndex = 73
        '
        'lblTownLocal
        '
        Me.lblTownLocal.AutoSize = True
        Me.lblTownLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownLocal.Location = New System.Drawing.Point(906, 112)
        Me.lblTownLocal.Name = "lblTownLocal"
        Me.lblTownLocal.Size = New System.Drawing.Size(44, 15)
        Me.lblTownLocal.TabIndex = 72
        Me.lblTownLocal.Text = "Local?"
        '
        'lblEastOf
        '
        Me.lblEastOf.AutoSize = True
        Me.lblEastOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEastOf.Location = New System.Drawing.Point(705, 112)
        Me.lblEastOf.Name = "lblEastOf"
        Me.lblEastOf.Size = New System.Drawing.Size(55, 15)
        Me.lblEastOf.TabIndex = 74
        Me.lblEastOf.Text = "East Of..."
        '
        'lblWestOf
        '
        Me.lblWestOf.AutoSize = True
        Me.lblWestOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWestOf.Location = New System.Drawing.Point(806, 113)
        Me.lblWestOf.Name = "lblWestOf"
        Me.lblWestOf.Size = New System.Drawing.Size(58, 15)
        Me.lblWestOf.TabIndex = 76
        Me.lblWestOf.Text = "West Of..."
        '
        'cboTownEastOf
        '
        Me.cboTownEastOf.Enabled = False
        Me.cboTownEastOf.FormattingEnabled = True
        Me.cboTownEastOf.Location = New System.Drawing.Point(708, 135)
        Me.cboTownEastOf.Name = "cboTownEastOf"
        Me.cboTownEastOf.Size = New System.Drawing.Size(97, 21)
        Me.cboTownEastOf.TabIndex = 77
        '
        'cboTownWestOf
        '
        Me.cboTownWestOf.Enabled = False
        Me.cboTownWestOf.FormattingEnabled = True
        Me.cboTownWestOf.Location = New System.Drawing.Point(809, 135)
        Me.cboTownWestOf.Name = "cboTownWestOf"
        Me.cboTownWestOf.Size = New System.Drawing.Size(92, 21)
        Me.cboTownWestOf.TabIndex = 78
        '
        'frmMaintTown
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 548)
        Me.Controls.Add(Me.cboTownWestOf)
        Me.Controls.Add(Me.cboTownEastOf)
        Me.Controls.Add(Me.lblWestOf)
        Me.Controls.Add(Me.lblEastOf)
        Me.Controls.Add(Me.cboTownLocal)
        Me.Controls.Add(Me.lblTownLocal)
        Me.Controls.Add(Me.txtTownID)
        Me.Controls.Add(Me.lblTownID)
        Me.Controls.Add(Me.cboTownFrtHub)
        Me.Controls.Add(Me.lblTownState)
        Me.Controls.Add(Me.TxtTownCallSign)
        Me.Controls.Add(Me.cmdTownReset)
        Me.Controls.Add(Me.cmdTownHelp)
        Me.Controls.Add(Me.cmdTownSave)
        Me.Controls.Add(Me.cmdTownDelete)
        Me.Controls.Add(Me.cmdTownEdit)
        Me.Controls.Add(Me.cmdTownNew)
        Me.Controls.Add(Me.cboTownState)
        Me.Controls.Add(Me.cboTownDiv)
        Me.Controls.Add(Me.cboTownServedBy)
        Me.Controls.Add(Me.lblTownDivision)
        Me.Controls.Add(Me.lblTownServedBy)
        Me.Controls.Add(Me.lblTownFreightHub)
        Me.Controls.Add(Me.lblTownCallSign)
        Me.Controls.Add(Me.lblTownName)
        Me.Controls.Add(Me.txtTownName)
        Me.Controls.Add(Me.dgvTown)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintTown"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Town"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblTownState As System.Windows.Forms.Label
    Friend WithEvents TxtTownCallSign As System.Windows.Forms.TextBox
    Friend WithEvents cmdTownReset As System.Windows.Forms.Button
    Friend WithEvents cmdTownHelp As System.Windows.Forms.Button
    Friend WithEvents cmdTownSave As System.Windows.Forms.Button
    Friend WithEvents cmdTownDelete As System.Windows.Forms.Button
    Friend WithEvents cmdTownEdit As System.Windows.Forms.Button
    Friend WithEvents cmdTownNew As System.Windows.Forms.Button
    Friend WithEvents cboTownState As System.Windows.Forms.ComboBox
    Friend WithEvents cboTownDiv As System.Windows.Forms.ComboBox
    Friend WithEvents cboTownServedBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblTownDivision As System.Windows.Forms.Label
    Friend WithEvents lblTownServedBy As System.Windows.Forms.Label
    Friend WithEvents lblTownFreightHub As System.Windows.Forms.Label
    Friend WithEvents lblTownCallSign As System.Windows.Forms.Label
    Friend WithEvents lblTownName As System.Windows.Forms.Label
    Friend WithEvents txtTownName As System.Windows.Forms.TextBox
    Friend WithEvents dgvTown As System.Windows.Forms.DataGridView
    Friend WithEvents cboTownFrtHub As System.Windows.Forms.ComboBox
    Friend WithEvents txtTownID As System.Windows.Forms.TextBox
    Friend WithEvents lblTownID As System.Windows.Forms.Label
    Friend WithEvents cboTownLocal As System.Windows.Forms.ComboBox
    Friend WithEvents lblTownLocal As System.Windows.Forms.Label
    Friend WithEvents ttpMaintTown As System.Windows.Forms.ToolTip
    Friend WithEvents lblEastOf As System.Windows.Forms.Label
    Friend WithEvents lblWestOf As System.Windows.Forms.Label
    Friend WithEvents cboTownEastOf As System.Windows.Forms.ComboBox
    Friend WithEvents cboTownWestOf As System.Windows.Forms.ComboBox
    Friend WithEvents TownName As DataGridViewTextBoxColumn
    Friend WithEvents TownID As DataGridViewTextBoxColumn
    Friend WithEvents TownState As DataGridViewTextBoxColumn
    Friend WithEvents TownCallSign As DataGridViewTextBoxColumn
    Friend WithEvents TownFrtHub As DataGridViewTextBoxColumn
    Friend WithEvents TownServedBy As DataGridViewTextBoxColumn
    Friend WithEvents TownDiv As DataGridViewTextBoxColumn
    Friend WithEvents TownEastOf As DataGridViewTextBoxColumn
    Friend WithEvents TownWestOf As DataGridViewTextBoxColumn
    Friend WithEvents TownLocal As DataGridViewTextBoxColumn
    Friend WithEvents Sidings As DataGridViewTextBoxColumn
End Class
