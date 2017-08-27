<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintInd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintInd))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.dgvInd = New System.Windows.Forms.DataGridView
        Me.indID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Active = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Railroad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipRecv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Commodity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Siding = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Frequency = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Spots = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdIndReset = New System.Windows.Forms.Button
        Me.cmdIndHelp = New System.Windows.Forms.Button
        Me.cmdIndSave = New System.Windows.Forms.Button
        Me.cmdIndDelete = New System.Windows.Forms.Button
        Me.cmdIndEdit = New System.Windows.Forms.Button
        Me.cmdIndNew = New System.Windows.Forms.Button
        Me.cboIndFrequency = New System.Windows.Forms.ComboBox
        Me.cboIndRR = New System.Windows.Forms.ComboBox
        Me.cboIndState = New System.Windows.Forms.ComboBox
        Me.cboIndComm = New System.Windows.Forms.ComboBox
        Me.lblIndNotes = New System.Windows.Forms.Label
        Me.lblIndRR = New System.Windows.Forms.Label
        Me.lblIndState = New System.Windows.Forms.Label
        Me.lblIndCity = New System.Windows.Forms.Label
        Me.lblIndName = New System.Windows.Forms.Label
        Me.lblIndCLIC = New System.Windows.Forms.Label
        Me.lblIndActive = New System.Windows.Forms.Label
        Me.txtIndNotes = New System.Windows.Forms.TextBox
        Me.txtIndCLIC = New System.Windows.Forms.TextBox
        Me.txtIndName = New System.Windows.Forms.TextBox
        Me.txtIndCity = New System.Windows.Forms.TextBox
        Me.nudSpots = New System.Windows.Forms.NumericUpDown
        Me.lblIndSpots = New System.Windows.Forms.Label
        Me.lblIndFreq = New System.Windows.Forms.Label
        Me.cboIndShipRecv = New System.Windows.Forms.ComboBox
        Me.lblIndSR = New System.Windows.Forms.Label
        Me.lblIndComm = New System.Windows.Forms.Label
        Me.lblIndSiding = New System.Windows.Forms.Label
        Me.cboIndSiding = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboIndActive = New System.Windows.Forms.ComboBox
        Me.ttpMaintInd = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdIndCopy = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdClearSearch = New System.Windows.Forms.Button
        Me.chkAutoGenCLIC = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdClose, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(706, 466)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClose.Location = New System.Drawing.Point(39, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(67, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        '
        'dgvInd
        '
        Me.dgvInd.AllowUserToAddRows = False
        Me.dgvInd.AllowUserToDeleteRows = False
        Me.dgvInd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indID, Me.Active, Me.CLIC, Me.IndName, Me.IndCity, Me.IndState, Me.Railroad, Me.ShipRecv, Me.Commodity, Me.Siding, Me.Frequency, Me.Spots, Me.Notes})
        Me.dgvInd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInd.Location = New System.Drawing.Point(12, 179)
        Me.dgvInd.MultiSelect = False
        Me.dgvInd.Name = "dgvInd"
        Me.dgvInd.RowHeadersVisible = False
        Me.dgvInd.Size = New System.Drawing.Size(837, 265)
        Me.dgvInd.TabIndex = 2
        '
        'indID
        '
        Me.indID.DataPropertyName = "IndID"
        Me.indID.HeaderText = "IndID"
        Me.indID.Name = "indID"
        Me.indID.Visible = False
        Me.indID.Width = 50
        '
        'Active
        '
        Me.Active.DataPropertyName = "Active"
        Me.Active.HeaderText = "Active"
        Me.Active.MaxInputLength = 1
        Me.Active.Name = "Active"
        Me.Active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Active.Width = 50
        '
        'CLIC
        '
        Me.CLIC.DataPropertyName = "CLIC"
        Me.CLIC.HeaderText = "CLIC"
        Me.CLIC.Name = "CLIC"
        Me.CLIC.Width = 75
        '
        'IndName
        '
        Me.IndName.DataPropertyName = "IndName"
        Me.IndName.HeaderText = "Industry Name"
        Me.IndName.Name = "IndName"
        Me.IndName.Width = 150
        '
        'IndCity
        '
        Me.IndCity.DataPropertyName = "IndCity"
        Me.IndCity.HeaderText = "City"
        Me.IndCity.Name = "IndCity"
        '
        'IndState
        '
        Me.IndState.DataPropertyName = "IndState"
        Me.IndState.HeaderText = "State"
        Me.IndState.Name = "IndState"
        Me.IndState.Width = 50
        '
        'Railroad
        '
        Me.Railroad.DataPropertyName = "Railroad"
        Me.Railroad.HeaderText = "Railroad"
        Me.Railroad.Name = "Railroad"
        '
        'ShipRecv
        '
        Me.ShipRecv.DataPropertyName = "ShipRecv"
        Me.ShipRecv.HeaderText = "S / R"
        Me.ShipRecv.Name = "ShipRecv"
        Me.ShipRecv.Width = 60
        '
        'Commodity
        '
        Me.Commodity.DataPropertyName = "Commodity"
        Me.Commodity.HeaderText = "Commodity"
        Me.Commodity.Name = "Commodity"
        Me.Commodity.Width = 125
        '
        'Siding
        '
        Me.Siding.DataPropertyName = "Siding"
        Me.Siding.HeaderText = "Siding"
        Me.Siding.Name = "Siding"
        '
        'Frequency
        '
        Me.Frequency.DataPropertyName = "Frequency"
        Me.Frequency.HeaderText = "Frequency"
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Width = 75
        '
        'Spots
        '
        Me.Spots.DataPropertyName = "Spots"
        Me.Spots.HeaderText = "Spots"
        Me.Spots.Name = "Spots"
        Me.Spots.Width = 75
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 150
        '
        'cmdIndReset
        '
        Me.cmdIndReset.Location = New System.Drawing.Point(316, 33)
        Me.cmdIndReset.Name = "cmdIndReset"
        Me.cmdIndReset.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndReset.TabIndex = 31
        Me.cmdIndReset.Text = "Reset"
        '
        'cmdIndHelp
        '
        Me.cmdIndHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdIndHelp.Enabled = False
        Me.cmdIndHelp.Location = New System.Drawing.Point(667, 33)
        Me.cmdIndHelp.Name = "cmdIndHelp"
        Me.cmdIndHelp.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndHelp.TabIndex = 30
        Me.cmdIndHelp.Text = "Help"
        '
        'cmdIndSave
        '
        Me.cmdIndSave.Location = New System.Drawing.Point(243, 33)
        Me.cmdIndSave.Name = "cmdIndSave"
        Me.cmdIndSave.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndSave.TabIndex = 29
        Me.cmdIndSave.Text = "Save"
        '
        'cmdIndDelete
        '
        Me.cmdIndDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdIndDelete.Location = New System.Drawing.Point(772, 33)
        Me.cmdIndDelete.Name = "cmdIndDelete"
        Me.cmdIndDelete.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndDelete.TabIndex = 28
        Me.cmdIndDelete.Text = "Delete"
        '
        'cmdIndEdit
        '
        Me.cmdIndEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIndEdit.Location = New System.Drawing.Point(97, 33)
        Me.cmdIndEdit.Name = "cmdIndEdit"
        Me.cmdIndEdit.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndEdit.TabIndex = 27
        Me.cmdIndEdit.Text = "Edit"
        Me.cmdIndEdit.UseVisualStyleBackColor = True
        '
        'cmdIndNew
        '
        Me.cmdIndNew.Location = New System.Drawing.Point(24, 33)
        Me.cmdIndNew.Name = "cmdIndNew"
        Me.cmdIndNew.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndNew.TabIndex = 26
        Me.cmdIndNew.Text = "New"
        '
        'cboIndFrequency
        '
        Me.cboIndFrequency.Enabled = False
        Me.cboIndFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndFrequency.FormattingEnabled = True
        Me.cboIndFrequency.Location = New System.Drawing.Point(442, 137)
        Me.cboIndFrequency.Name = "cboIndFrequency"
        Me.cboIndFrequency.Size = New System.Drawing.Size(118, 23)
        Me.cboIndFrequency.TabIndex = 45
        '
        'cboIndRR
        '
        Me.cboIndRR.Enabled = False
        Me.cboIndRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndRR.FormattingEnabled = True
        Me.cboIndRR.Location = New System.Drawing.Point(451, 98)
        Me.cboIndRR.Name = "cboIndRR"
        Me.cboIndRR.Size = New System.Drawing.Size(189, 23)
        Me.cboIndRR.TabIndex = 44
        '
        'cboIndState
        '
        Me.cboIndState.Enabled = False
        Me.cboIndState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndState.FormattingEnabled = True
        Me.cboIndState.Location = New System.Drawing.Point(398, 98)
        Me.cboIndState.Name = "cboIndState"
        Me.cboIndState.Size = New System.Drawing.Size(47, 23)
        Me.cboIndState.TabIndex = 43
        '
        'cboIndComm
        '
        Me.cboIndComm.Enabled = False
        Me.cboIndComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndComm.FormattingEnabled = True
        Me.cboIndComm.Location = New System.Drawing.Point(86, 137)
        Me.cboIndComm.Name = "cboIndComm"
        Me.cboIndComm.Size = New System.Drawing.Size(180, 23)
        Me.cboIndComm.TabIndex = 42
        '
        'lblIndNotes
        '
        Me.lblIndNotes.AutoSize = True
        Me.lblIndNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndNotes.Location = New System.Drawing.Point(627, 119)
        Me.lblIndNotes.Name = "lblIndNotes"
        Me.lblIndNotes.Size = New System.Drawing.Size(39, 15)
        Me.lblIndNotes.TabIndex = 41
        Me.lblIndNotes.Text = "Notes"
        '
        'lblIndRR
        '
        Me.lblIndRR.AutoSize = True
        Me.lblIndRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndRR.Location = New System.Drawing.Point(448, 78)
        Me.lblIndRR.Name = "lblIndRR"
        Me.lblIndRR.Size = New System.Drawing.Size(54, 15)
        Me.lblIndRR.TabIndex = 40
        Me.lblIndRR.Text = "Railroad"
        '
        'lblIndState
        '
        Me.lblIndState.AutoSize = True
        Me.lblIndState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndState.Location = New System.Drawing.Point(395, 78)
        Me.lblIndState.Name = "lblIndState"
        Me.lblIndState.Size = New System.Drawing.Size(35, 15)
        Me.lblIndState.TabIndex = 39
        Me.lblIndState.Text = "State"
        '
        'lblIndCity
        '
        Me.lblIndCity.AutoSize = True
        Me.lblIndCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndCity.Location = New System.Drawing.Point(304, 78)
        Me.lblIndCity.Name = "lblIndCity"
        Me.lblIndCity.Size = New System.Drawing.Size(26, 15)
        Me.lblIndCity.TabIndex = 38
        Me.lblIndCity.Text = "City"
        '
        'lblIndName
        '
        Me.lblIndName.AutoSize = True
        Me.lblIndName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndName.Location = New System.Drawing.Point(148, 78)
        Me.lblIndName.Name = "lblIndName"
        Me.lblIndName.Size = New System.Drawing.Size(86, 15)
        Me.lblIndName.TabIndex = 37
        Me.lblIndName.Text = "Industry Name"
        '
        'lblIndCLIC
        '
        Me.lblIndCLIC.AutoSize = True
        Me.lblIndCLIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndCLIC.Location = New System.Drawing.Point(69, 78)
        Me.lblIndCLIC.Name = "lblIndCLIC"
        Me.lblIndCLIC.Size = New System.Drawing.Size(33, 15)
        Me.lblIndCLIC.TabIndex = 36
        Me.lblIndCLIC.Text = "CLIC"
        '
        'lblIndActive
        '
        Me.lblIndActive.AutoSize = True
        Me.lblIndActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndActive.Location = New System.Drawing.Point(10, 78)
        Me.lblIndActive.Name = "lblIndActive"
        Me.lblIndActive.Size = New System.Drawing.Size(45, 15)
        Me.lblIndActive.TabIndex = 35
        Me.lblIndActive.Text = "Active?"
        '
        'txtIndNotes
        '
        Me.txtIndNotes.Enabled = False
        Me.txtIndNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndNotes.Location = New System.Drawing.Point(630, 137)
        Me.txtIndNotes.Name = "txtIndNotes"
        Me.txtIndNotes.Size = New System.Drawing.Size(130, 21)
        Me.txtIndNotes.TabIndex = 34
        '
        'txtIndCLIC
        '
        Me.txtIndCLIC.Enabled = False
        Me.txtIndCLIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndCLIC.Location = New System.Drawing.Point(72, 98)
        Me.txtIndCLIC.Name = "txtIndCLIC"
        Me.txtIndCLIC.Size = New System.Drawing.Size(73, 21)
        Me.txtIndCLIC.TabIndex = 33
        '
        'txtIndName
        '
        Me.txtIndName.Enabled = False
        Me.txtIndName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndName.Location = New System.Drawing.Point(151, 98)
        Me.txtIndName.Name = "txtIndName"
        Me.txtIndName.Size = New System.Drawing.Size(140, 21)
        Me.txtIndName.TabIndex = 46
        '
        'txtIndCity
        '
        Me.txtIndCity.Enabled = False
        Me.txtIndCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndCity.Location = New System.Drawing.Point(297, 98)
        Me.txtIndCity.Name = "txtIndCity"
        Me.txtIndCity.Size = New System.Drawing.Size(95, 21)
        Me.txtIndCity.TabIndex = 47
        '
        'nudSpots
        '
        Me.nudSpots.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSpots.Location = New System.Drawing.Point(566, 137)
        Me.nudSpots.Name = "nudSpots"
        Me.nudSpots.Size = New System.Drawing.Size(58, 21)
        Me.nudSpots.TabIndex = 48
        '
        'lblIndSpots
        '
        Me.lblIndSpots.AutoSize = True
        Me.lblIndSpots.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSpots.Location = New System.Drawing.Point(563, 119)
        Me.lblIndSpots.Name = "lblIndSpots"
        Me.lblIndSpots.Size = New System.Drawing.Size(38, 15)
        Me.lblIndSpots.TabIndex = 49
        Me.lblIndSpots.Text = "Spots"
        '
        'lblIndFreq
        '
        Me.lblIndFreq.AutoSize = True
        Me.lblIndFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndFreq.Location = New System.Drawing.Point(439, 121)
        Me.lblIndFreq.Name = "lblIndFreq"
        Me.lblIndFreq.Size = New System.Drawing.Size(64, 15)
        Me.lblIndFreq.TabIndex = 50
        Me.lblIndFreq.Text = "Frequency"
        '
        'cboIndShipRecv
        '
        Me.cboIndShipRecv.Enabled = False
        Me.cboIndShipRecv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndShipRecv.FormattingEnabled = True
        Me.cboIndShipRecv.Location = New System.Drawing.Point(646, 98)
        Me.cboIndShipRecv.Name = "cboIndShipRecv"
        Me.cboIndShipRecv.Size = New System.Drawing.Size(85, 23)
        Me.cboIndShipRecv.TabIndex = 51
        '
        'lblIndSR
        '
        Me.lblIndSR.AutoSize = True
        Me.lblIndSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSR.Location = New System.Drawing.Point(643, 78)
        Me.lblIndSR.Name = "lblIndSR"
        Me.lblIndSR.Size = New System.Drawing.Size(62, 15)
        Me.lblIndSR.TabIndex = 52
        Me.lblIndSR.Text = "Ship/Recv"
        '
        'lblIndComm
        '
        Me.lblIndComm.AutoSize = True
        Me.lblIndComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndComm.Location = New System.Drawing.Point(83, 119)
        Me.lblIndComm.Name = "lblIndComm"
        Me.lblIndComm.Size = New System.Drawing.Size(69, 15)
        Me.lblIndComm.TabIndex = 53
        Me.lblIndComm.Text = "Commodity"
        '
        'lblIndSiding
        '
        Me.lblIndSiding.AutoSize = True
        Me.lblIndSiding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSiding.Location = New System.Drawing.Point(269, 121)
        Me.lblIndSiding.Name = "lblIndSiding"
        Me.lblIndSiding.Size = New System.Drawing.Size(42, 15)
        Me.lblIndSiding.TabIndex = 57
        Me.lblIndSiding.Text = "Siding"
        '
        'cboIndSiding
        '
        Me.cboIndSiding.Enabled = False
        Me.cboIndSiding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndSiding.FormattingEnabled = True
        Me.cboIndSiding.Location = New System.Drawing.Point(272, 137)
        Me.cboIndSiding.Name = "cboIndSiding"
        Me.cboIndSiding.Size = New System.Drawing.Size(164, 23)
        Me.cboIndSiding.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(677, 447)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 15)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Red Text - Not Recognized"
        '
        'cboIndActive
        '
        Me.cboIndActive.Enabled = False
        Me.cboIndActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndActive.FormattingEnabled = True
        Me.cboIndActive.Location = New System.Drawing.Point(11, 98)
        Me.cboIndActive.Name = "cboIndActive"
        Me.cboIndActive.Size = New System.Drawing.Size(55, 23)
        Me.cboIndActive.TabIndex = 61
        '
        'cmdIndCopy
        '
        Me.cmdIndCopy.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIndCopy.Location = New System.Drawing.Point(170, 33)
        Me.cmdIndCopy.Name = "cmdIndCopy"
        Me.cmdIndCopy.Size = New System.Drawing.Size(67, 23)
        Me.cmdIndCopy.TabIndex = 62
        Me.cmdIndCopy.Text = "Copy"
        Me.cmdIndCopy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Search >"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Select a Column"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Type Search Value"
        Me.Label3.Visible = False
        '
        'cboSearch
        '
        Me.cboSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(103, 463)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(118, 23)
        Me.cboSearch.TabIndex = 66
        Me.cboSearch.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(232, 463)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(140, 21)
        Me.txtSearch.TabIndex = 67
        Me.txtSearch.Visible = False
        '
        'cmdClearSearch
        '
        Me.cmdClearSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClearSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearSearch.Location = New System.Drawing.Point(398, 462)
        Me.cmdClearSearch.Name = "cmdClearSearch"
        Me.cmdClearSearch.Size = New System.Drawing.Size(67, 23)
        Me.cmdClearSearch.TabIndex = 68
        Me.cmdClearSearch.Text = "Clear"
        Me.cmdClearSearch.UseVisualStyleBackColor = True
        Me.cmdClearSearch.Visible = False
        '
        'chkAutoGenCLIC
        '
        Me.chkAutoGenCLIC.AutoSize = True
        Me.chkAutoGenCLIC.Checked = True
        Me.chkAutoGenCLIC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenCLIC.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoGenCLIC.Location = New System.Drawing.Point(451, 37)
        Me.chkAutoGenCLIC.Name = "chkAutoGenCLIC"
        Me.chkAutoGenCLIC.Size = New System.Drawing.Size(149, 17)
        Me.chkAutoGenCLIC.TabIndex = 69
        Me.chkAutoGenCLIC.Text = "Auto-Generate CLIC Code"
        Me.chkAutoGenCLIC.UseVisualStyleBackColor = True
        '
        'frmMaintInd
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 507)
        Me.Controls.Add(Me.chkAutoGenCLIC)
        Me.Controls.Add(Me.cmdClearSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdIndCopy)
        Me.Controls.Add(Me.cboIndActive)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblIndSiding)
        Me.Controls.Add(Me.cboIndSiding)
        Me.Controls.Add(Me.lblIndComm)
        Me.Controls.Add(Me.lblIndSR)
        Me.Controls.Add(Me.cboIndShipRecv)
        Me.Controls.Add(Me.lblIndFreq)
        Me.Controls.Add(Me.nudSpots)
        Me.Controls.Add(Me.txtIndCity)
        Me.Controls.Add(Me.txtIndName)
        Me.Controls.Add(Me.cboIndFrequency)
        Me.Controls.Add(Me.cboIndRR)
        Me.Controls.Add(Me.cboIndState)
        Me.Controls.Add(Me.cboIndComm)
        Me.Controls.Add(Me.lblIndNotes)
        Me.Controls.Add(Me.lblIndRR)
        Me.Controls.Add(Me.lblIndState)
        Me.Controls.Add(Me.lblIndCity)
        Me.Controls.Add(Me.lblIndName)
        Me.Controls.Add(Me.lblIndCLIC)
        Me.Controls.Add(Me.lblIndActive)
        Me.Controls.Add(Me.txtIndNotes)
        Me.Controls.Add(Me.txtIndCLIC)
        Me.Controls.Add(Me.cmdIndReset)
        Me.Controls.Add(Me.cmdIndHelp)
        Me.Controls.Add(Me.cmdIndSave)
        Me.Controls.Add(Me.cmdIndDelete)
        Me.Controls.Add(Me.cmdIndEdit)
        Me.Controls.Add(Me.cmdIndNew)
        Me.Controls.Add(Me.dgvInd)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblIndSpots)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintInd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Industries"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dgvInd As System.Windows.Forms.DataGridView
    Friend WithEvents cmdIndReset As System.Windows.Forms.Button
    Friend WithEvents cmdIndHelp As System.Windows.Forms.Button
    Friend WithEvents cmdIndSave As System.Windows.Forms.Button
    Friend WithEvents cmdIndDelete As System.Windows.Forms.Button
    Friend WithEvents cmdIndEdit As System.Windows.Forms.Button
    Friend WithEvents cmdIndNew As System.Windows.Forms.Button
    Friend WithEvents cboIndFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents cboIndRR As System.Windows.Forms.ComboBox
    Friend WithEvents cboIndState As System.Windows.Forms.ComboBox
    Friend WithEvents cboIndComm As System.Windows.Forms.ComboBox
    Friend WithEvents lblIndNotes As System.Windows.Forms.Label
    Friend WithEvents lblIndRR As System.Windows.Forms.Label
    Friend WithEvents lblIndState As System.Windows.Forms.Label
    Friend WithEvents lblIndCity As System.Windows.Forms.Label
    Friend WithEvents lblIndName As System.Windows.Forms.Label
    Friend WithEvents lblIndCLIC As System.Windows.Forms.Label
    Friend WithEvents lblIndActive As System.Windows.Forms.Label
    Friend WithEvents txtIndNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtIndCLIC As System.Windows.Forms.TextBox
    Friend WithEvents txtIndName As System.Windows.Forms.TextBox
    Friend WithEvents txtIndCity As System.Windows.Forms.TextBox
    Friend WithEvents nudSpots As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblIndSpots As System.Windows.Forms.Label
    Friend WithEvents lblIndFreq As System.Windows.Forms.Label
    Friend WithEvents cboIndShipRecv As System.Windows.Forms.ComboBox
    Friend WithEvents lblIndSR As System.Windows.Forms.Label
    Friend WithEvents lblIndComm As System.Windows.Forms.Label
    Friend WithEvents lblIndSiding As System.Windows.Forms.Label
    Friend WithEvents cboIndSiding As System.Windows.Forms.ComboBox
    Friend WithEvents indID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Active As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Railroad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipRecv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commodity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Siding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Frequency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Spots As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboIndActive As System.Windows.Forms.ComboBox
    Friend WithEvents ttpMaintInd As System.Windows.Forms.ToolTip
    Friend WithEvents cmdIndCopy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearSearch As System.Windows.Forms.Button
    Friend WithEvents chkAutoGenCLIC As System.Windows.Forms.CheckBox

End Class
