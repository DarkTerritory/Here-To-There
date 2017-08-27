<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintTrain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintTrain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cboTrainClass = New System.Windows.Forms.ComboBox
        Me.lblTrainDir = New System.Windows.Forms.Label
        Me.cmdTrainReset = New System.Windows.Forms.Button
        Me.cmdTrainHelp = New System.Windows.Forms.Button
        Me.cmdTrainSave = New System.Windows.Forms.Button
        Me.cmdTrainDelete = New System.Windows.Forms.Button
        Me.cmdTrainEdit = New System.Windows.Forms.Button
        Me.cmdTrainNew = New System.Windows.Forms.Button
        Me.cboTrainDir = New System.Windows.Forms.ComboBox
        Me.cboTrainOrigOL = New System.Windows.Forms.ComboBox
        Me.cboTrainScope = New System.Windows.Forms.ComboBox
        Me.lblTrainOriginOL = New System.Windows.Forms.Label
        Me.lblTrainScope = New System.Windows.Forms.Label
        Me.lblTrainClass = New System.Windows.Forms.Label
        Me.lblTrainType = New System.Windows.Forms.Label
        Me.lblTrainName = New System.Windows.Forms.Label
        Me.txtTrainName = New System.Windows.Forms.TextBox
        Me.dgvTrain = New System.Windows.Forms.DataGridView
        Me.cboTrainType = New System.Windows.Forms.ComboBox
        Me.nudTrainCars = New System.Windows.Forms.NumericUpDown
        Me.lblTrainCarLimit = New System.Windows.Forms.Label
        Me.ttpMaintTrain = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblLowPriority = New System.Windows.Forms.Label
        Me.lblPctThru = New System.Windows.Forms.Label
        Me.nudThruCars = New System.Windows.Forms.NumericUpDown
        Me.cboLowPriority = New System.Windows.Forms.ComboBox
        Me.cmdEditTrainWork = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTrainID = New System.Windows.Forms.TextBox
        Me.cboTrainDepartTime = New System.Windows.Forms.ComboBox
        Me.lblTrainDepartTime = New System.Windows.Forms.Label
        Me.cboFromStagingArea = New System.Windows.Forms.ComboBox
        Me.lblFromStagingArea = New System.Windows.Forms.Label
        Me.TrName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrDirection = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trClass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrScope = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrMaxCars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrPctThru = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrAllowLowPriority = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrOrigOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrDepartTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrFromStagingArea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblTrainID = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTrainCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThruCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(763, 446)
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
        'cboTrainClass
        '
        Me.cboTrainClass.Enabled = False
        Me.cboTrainClass.FormattingEnabled = True
        Me.cboTrainClass.Location = New System.Drawing.Point(353, 134)
        Me.cboTrainClass.Name = "cboTrainClass"
        Me.cboTrainClass.Size = New System.Drawing.Size(64, 21)
        Me.cboTrainClass.TabIndex = 90
        '
        'lblTrainDir
        '
        Me.lblTrainDir.AutoSize = True
        Me.lblTrainDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainDir.Location = New System.Drawing.Point(219, 112)
        Me.lblTrainDir.Name = "lblTrainDir"
        Me.lblTrainDir.Size = New System.Drawing.Size(56, 15)
        Me.lblTrainDir.TabIndex = 89
        Me.lblTrainDir.Text = "Direction"
        '
        'cmdTrainReset
        '
        Me.cmdTrainReset.Location = New System.Drawing.Point(303, 33)
        Me.cmdTrainReset.Name = "cmdTrainReset"
        Me.cmdTrainReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainReset.TabIndex = 87
        Me.cmdTrainReset.Text = "Reset"
        '
        'cmdTrainHelp
        '
        Me.cmdTrainHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrainHelp.Enabled = False
        Me.cmdTrainHelp.Location = New System.Drawing.Point(714, 33)
        Me.cmdTrainHelp.Name = "cmdTrainHelp"
        Me.cmdTrainHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainHelp.TabIndex = 86
        Me.cmdTrainHelp.Text = "Help"
        '
        'cmdTrainSave
        '
        Me.cmdTrainSave.Location = New System.Drawing.Point(218, 33)
        Me.cmdTrainSave.Name = "cmdTrainSave"
        Me.cmdTrainSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainSave.TabIndex = 85
        Me.cmdTrainSave.Text = "Save"
        '
        'cmdTrainDelete
        '
        Me.cmdTrainDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrainDelete.Location = New System.Drawing.Point(803, 33)
        Me.cmdTrainDelete.Name = "cmdTrainDelete"
        Me.cmdTrainDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainDelete.TabIndex = 84
        Me.cmdTrainDelete.Text = "Delete"
        '
        'cmdTrainEdit
        '
        Me.cmdTrainEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTrainEdit.Location = New System.Drawing.Point(133, 33)
        Me.cmdTrainEdit.Name = "cmdTrainEdit"
        Me.cmdTrainEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainEdit.TabIndex = 83
        Me.cmdTrainEdit.Text = "Edit"
        Me.cmdTrainEdit.UseVisualStyleBackColor = True
        '
        'cmdTrainNew
        '
        Me.cmdTrainNew.Location = New System.Drawing.Point(47, 33)
        Me.cmdTrainNew.Name = "cmdTrainNew"
        Me.cmdTrainNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdTrainNew.TabIndex = 82
        Me.cmdTrainNew.Text = "New"
        '
        'cboTrainDir
        '
        Me.cboTrainDir.Enabled = False
        Me.cboTrainDir.FormattingEnabled = True
        Me.cboTrainDir.Location = New System.Drawing.Point(222, 134)
        Me.cboTrainDir.Name = "cboTrainDir"
        Me.cboTrainDir.Size = New System.Drawing.Size(56, 21)
        Me.cboTrainDir.TabIndex = 81
        '
        'cboTrainOrigOL
        '
        Me.cboTrainOrigOL.Enabled = False
        Me.cboTrainOrigOL.FormattingEnabled = True
        Me.cboTrainOrigOL.Location = New System.Drawing.Point(675, 133)
        Me.cboTrainOrigOL.Name = "cboTrainOrigOL"
        Me.cboTrainOrigOL.Size = New System.Drawing.Size(54, 21)
        Me.cboTrainOrigOL.TabIndex = 80
        '
        'cboTrainScope
        '
        Me.cboTrainScope.Enabled = False
        Me.cboTrainScope.FormattingEnabled = True
        Me.cboTrainScope.Location = New System.Drawing.Point(423, 134)
        Me.cboTrainScope.Name = "cboTrainScope"
        Me.cboTrainScope.Size = New System.Drawing.Size(75, 21)
        Me.cboTrainScope.TabIndex = 79
        '
        'lblTrainOriginOL
        '
        Me.lblTrainOriginOL.AutoSize = True
        Me.lblTrainOriginOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainOriginOL.Location = New System.Drawing.Point(672, 110)
        Me.lblTrainOriginOL.Name = "lblTrainOriginOL"
        Me.lblTrainOriginOL.Size = New System.Drawing.Size(69, 15)
        Me.lblTrainOriginOL.TabIndex = 78
        Me.lblTrainOriginOL.Text = "Origin O/L?"
        '
        'lblTrainScope
        '
        Me.lblTrainScope.AutoSize = True
        Me.lblTrainScope.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainScope.Location = New System.Drawing.Point(420, 110)
        Me.lblTrainScope.Name = "lblTrainScope"
        Me.lblTrainScope.Size = New System.Drawing.Size(42, 15)
        Me.lblTrainScope.TabIndex = 77
        Me.lblTrainScope.Text = "Scope"
        '
        'lblTrainClass
        '
        Me.lblTrainClass.AutoSize = True
        Me.lblTrainClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainClass.Location = New System.Drawing.Point(350, 113)
        Me.lblTrainClass.Name = "lblTrainClass"
        Me.lblTrainClass.Size = New System.Drawing.Size(37, 15)
        Me.lblTrainClass.TabIndex = 76
        Me.lblTrainClass.Text = "Class"
        '
        'lblTrainType
        '
        Me.lblTrainType.AutoSize = True
        Me.lblTrainType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainType.Location = New System.Drawing.Point(281, 110)
        Me.lblTrainType.Name = "lblTrainType"
        Me.lblTrainType.Size = New System.Drawing.Size(33, 15)
        Me.lblTrainType.TabIndex = 75
        Me.lblTrainType.Text = "Type"
        '
        'lblTrainName
        '
        Me.lblTrainName.AutoSize = True
        Me.lblTrainName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainName.Location = New System.Drawing.Point(39, 113)
        Me.lblTrainName.Name = "lblTrainName"
        Me.lblTrainName.Size = New System.Drawing.Size(72, 15)
        Me.lblTrainName.TabIndex = 74
        Me.lblTrainName.Text = "Train Name"
        '
        'txtTrainName
        '
        Me.txtTrainName.Enabled = False
        Me.txtTrainName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrainName.Location = New System.Drawing.Point(42, 134)
        Me.txtTrainName.Name = "txtTrainName"
        Me.txtTrainName.Size = New System.Drawing.Size(143, 21)
        Me.txtTrainName.TabIndex = 73
        '
        'dgvTrain
        '
        Me.dgvTrain.AllowUserToAddRows = False
        Me.dgvTrain.AllowUserToDeleteRows = False
        Me.dgvTrain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrName, Me.TrID, Me.TrDirection, Me.TrType, Me.trClass, Me.TrScope, Me.TrMaxCars, Me.TrPctThru, Me.TrAllowLowPriority, Me.TrOrigOL, Me.TrDepartTime, Me.TrFromStagingArea})
        Me.dgvTrain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTrain.Location = New System.Drawing.Point(42, 181)
        Me.dgvTrain.MultiSelect = False
        Me.dgvTrain.Name = "dgvTrain"
        Me.dgvTrain.RowHeadersVisible = False
        Me.dgvTrain.Size = New System.Drawing.Size(839, 218)
        Me.dgvTrain.TabIndex = 72
        '
        'cboTrainType
        '
        Me.cboTrainType.Enabled = False
        Me.cboTrainType.FormattingEnabled = True
        Me.cboTrainType.Location = New System.Drawing.Point(284, 134)
        Me.cboTrainType.Name = "cboTrainType"
        Me.cboTrainType.Size = New System.Drawing.Size(62, 21)
        Me.cboTrainType.TabIndex = 93
        '
        'nudTrainCars
        '
        Me.nudTrainCars.Location = New System.Drawing.Point(504, 134)
        Me.nudTrainCars.Name = "nudTrainCars"
        Me.nudTrainCars.Size = New System.Drawing.Size(46, 20)
        Me.nudTrainCars.TabIndex = 94
        '
        'lblTrainCarLimit
        '
        Me.lblTrainCarLimit.AutoSize = True
        Me.lblTrainCarLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainCarLimit.Location = New System.Drawing.Point(501, 112)
        Me.lblTrainCarLimit.Name = "lblTrainCarLimit"
        Me.lblTrainCarLimit.Size = New System.Drawing.Size(56, 15)
        Me.lblTrainCarLimit.TabIndex = 95
        Me.lblTrainCarLimit.Text = "Car Limit"
        '
        'lblLowPriority
        '
        Me.lblLowPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowPriority.Location = New System.Drawing.Point(612, 80)
        Me.lblLowPriority.Name = "lblLowPriority"
        Me.lblLowPriority.Size = New System.Drawing.Size(54, 48)
        Me.lblLowPriority.TabIndex = 96
        Me.lblLowPriority.Text = "Allow Low Priority?"
        '
        'lblPctThru
        '
        Me.lblPctThru.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPctThru.Location = New System.Drawing.Point(553, 97)
        Me.lblPctThru.Name = "lblPctThru"
        Me.lblPctThru.Size = New System.Drawing.Size(56, 31)
        Me.lblPctThru.TabIndex = 99
        Me.lblPctThru.Text = "Pct. Thru Cars?"
        '
        'nudThruCars
        '
        Me.nudThruCars.Location = New System.Drawing.Point(556, 134)
        Me.nudThruCars.Name = "nudThruCars"
        Me.nudThruCars.Size = New System.Drawing.Size(53, 20)
        Me.nudThruCars.TabIndex = 98
        '
        'cboLowPriority
        '
        Me.cboLowPriority.Enabled = False
        Me.cboLowPriority.FormattingEnabled = True
        Me.cboLowPriority.Location = New System.Drawing.Point(615, 133)
        Me.cboLowPriority.Name = "cboLowPriority"
        Me.cboLowPriority.Size = New System.Drawing.Size(54, 21)
        Me.cboLowPriority.TabIndex = 100
        '
        'cmdEditTrainWork
        '
        Me.cmdEditTrainWork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditTrainWork.Location = New System.Drawing.Point(408, 427)
        Me.cmdEditTrainWork.Name = "cmdEditTrainWork"
        Me.cmdEditTrainWork.Size = New System.Drawing.Size(105, 27)
        Me.cmdEditTrainWork.TabIndex = 101
        Me.cmdEditTrainWork.Text = "Edit Train Work"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Click Here to Edit the Selected Train's Work"
        '
        'txtTrainID
        '
        Me.txtTrainID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrainID.Location = New System.Drawing.Point(2, 12)
        Me.txtTrainID.Name = "txtTrainID"
        Me.txtTrainID.Size = New System.Drawing.Size(25, 21)
        Me.txtTrainID.TabIndex = 103
        Me.txtTrainID.Visible = False
        '
        'cboTrainDepartTime
        '
        Me.cboTrainDepartTime.Enabled = False
        Me.cboTrainDepartTime.FormattingEnabled = True
        Me.cboTrainDepartTime.Location = New System.Drawing.Point(738, 133)
        Me.cboTrainDepartTime.Name = "cboTrainDepartTime"
        Me.cboTrainDepartTime.Size = New System.Drawing.Size(54, 21)
        Me.cboTrainDepartTime.TabIndex = 104
        '
        'lblTrainDepartTime
        '
        Me.lblTrainDepartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainDepartTime.Location = New System.Drawing.Point(736, 99)
        Me.lblTrainDepartTime.Name = "lblTrainDepartTime"
        Me.lblTrainDepartTime.Size = New System.Drawing.Size(56, 31)
        Me.lblTrainDepartTime.TabIndex = 105
        Me.lblTrainDepartTime.Text = "Depart Time"
        '
        'cboFromStagingArea
        '
        Me.cboFromStagingArea.Enabled = False
        Me.cboFromStagingArea.FormattingEnabled = True
        Me.cboFromStagingArea.Location = New System.Drawing.Point(798, 133)
        Me.cboFromStagingArea.Name = "cboFromStagingArea"
        Me.cboFromStagingArea.Size = New System.Drawing.Size(83, 21)
        Me.cboFromStagingArea.TabIndex = 106
        '
        'lblFromStagingArea
        '
        Me.lblFromStagingArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromStagingArea.Location = New System.Drawing.Point(795, 83)
        Me.lblFromStagingArea.Name = "lblFromStagingArea"
        Me.lblFromStagingArea.Size = New System.Drawing.Size(74, 45)
        Me.lblFromStagingArea.TabIndex = 107
        Me.lblFromStagingArea.Text = "From Staging Area"
        '
        'TrName
        '
        Me.TrName.DataPropertyName = "TrName"
        Me.TrName.HeaderText = "Train Name"
        Me.TrName.Name = "TrName"
        Me.TrName.Width = 140
        '
        'TrID
        '
        Me.TrID.DataPropertyName = "TrID"
        Me.TrID.HeaderText = "ID#"
        Me.TrID.Name = "TrID"
        Me.TrID.Width = 40
        '
        'TrDirection
        '
        Me.TrDirection.DataPropertyName = "TrDirection"
        Me.TrDirection.HeaderText = "Direction"
        Me.TrDirection.Name = "TrDirection"
        Me.TrDirection.Width = 60
        '
        'TrType
        '
        Me.TrType.DataPropertyName = "TrType"
        Me.TrType.HeaderText = "Type"
        Me.TrType.Name = "TrType"
        Me.TrType.Width = 70
        '
        'trClass
        '
        Me.trClass.DataPropertyName = "TrClass"
        Me.trClass.HeaderText = "Class"
        Me.trClass.Name = "trClass"
        Me.trClass.Width = 70
        '
        'TrScope
        '
        Me.TrScope.DataPropertyName = "TrScope"
        Me.TrScope.HeaderText = "Scope"
        Me.TrScope.Name = "TrScope"
        Me.TrScope.Width = 75
        '
        'TrMaxCars
        '
        Me.TrMaxCars.DataPropertyName = "TrMaxCars"
        Me.TrMaxCars.HeaderText = "Car Limit"
        Me.TrMaxCars.Name = "TrMaxCars"
        Me.TrMaxCars.Width = 60
        '
        'TrPctThru
        '
        Me.TrPctThru.DataPropertyName = "TrPctThru"
        Me.TrPctThru.HeaderText = "Pct Thru"
        Me.TrPctThru.Name = "TrPctThru"
        Me.TrPctThru.Width = 60
        '
        'TrAllowLowPriority
        '
        Me.TrAllowLowPriority.DataPropertyName = "TrAllowLowPriority"
        Me.TrAllowLowPriority.HeaderText = "LowPriority"
        Me.TrAllowLowPriority.Name = "TrAllowLowPriority"
        Me.TrAllowLowPriority.Width = 60
        '
        'TrOrigOL
        '
        Me.TrOrigOL.DataPropertyName = "TrOriginateOL"
        Me.TrOrigOL.HeaderText = "Orig O/L"
        Me.TrOrigOL.Name = "TrOrigOL"
        Me.TrOrigOL.Width = 60
        '
        'TrDepartTime
        '
        Me.TrDepartTime.DataPropertyName = "TrDepartTime"
        Me.TrDepartTime.HeaderText = "Dep Time"
        Me.TrDepartTime.Name = "TrDepartTime"
        Me.TrDepartTime.Width = 70
        '
        'TrFromStagingArea
        '
        Me.TrFromStagingArea.DataPropertyName = "StagingArea"
        Me.TrFromStagingArea.HeaderText = "Staging Area"
        Me.TrFromStagingArea.Name = "TrFromStagingArea"
        Me.TrFromStagingArea.Width = 80
        '
        'lblTrainID
        '
        Me.lblTrainID.AutoSize = True
        Me.lblTrainID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainID.Location = New System.Drawing.Point(185, 112)
        Me.lblTrainID.Name = "lblTrainID"
        Me.lblTrainID.Size = New System.Drawing.Size(29, 15)
        Me.lblTrainID.TabIndex = 108
        Me.lblTrainID.Text = "ID #"
        '
        'frmMaintTrain
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 487)
        Me.Controls.Add(Me.lblTrainID)
        Me.Controls.Add(Me.lblFromStagingArea)
        Me.Controls.Add(Me.cboFromStagingArea)
        Me.Controls.Add(Me.lblTrainDepartTime)
        Me.Controls.Add(Me.cboTrainDepartTime)
        Me.Controls.Add(Me.txtTrainID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEditTrainWork)
        Me.Controls.Add(Me.cboLowPriority)
        Me.Controls.Add(Me.lblTrainOriginOL)
        Me.Controls.Add(Me.lblPctThru)
        Me.Controls.Add(Me.nudThruCars)
        Me.Controls.Add(Me.lblLowPriority)
        Me.Controls.Add(Me.lblTrainCarLimit)
        Me.Controls.Add(Me.nudTrainCars)
        Me.Controls.Add(Me.cboTrainType)
        Me.Controls.Add(Me.cboTrainClass)
        Me.Controls.Add(Me.lblTrainDir)
        Me.Controls.Add(Me.cmdTrainReset)
        Me.Controls.Add(Me.cmdTrainHelp)
        Me.Controls.Add(Me.cmdTrainSave)
        Me.Controls.Add(Me.cmdTrainDelete)
        Me.Controls.Add(Me.cmdTrainEdit)
        Me.Controls.Add(Me.cmdTrainNew)
        Me.Controls.Add(Me.cboTrainDir)
        Me.Controls.Add(Me.cboTrainOrigOL)
        Me.Controls.Add(Me.cboTrainScope)
        Me.Controls.Add(Me.lblTrainScope)
        Me.Controls.Add(Me.lblTrainClass)
        Me.Controls.Add(Me.lblTrainType)
        Me.Controls.Add(Me.lblTrainName)
        Me.Controls.Add(Me.txtTrainName)
        Me.Controls.Add(Me.dgvTrain)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintTrain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Trains"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTrainCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThruCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cboTrainClass As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrainDir As System.Windows.Forms.Label
    Friend WithEvents cmdTrainReset As System.Windows.Forms.Button
    Friend WithEvents cmdTrainHelp As System.Windows.Forms.Button
    Friend WithEvents cmdTrainSave As System.Windows.Forms.Button
    Friend WithEvents cmdTrainDelete As System.Windows.Forms.Button
    Friend WithEvents cmdTrainEdit As System.Windows.Forms.Button
    Friend WithEvents cmdTrainNew As System.Windows.Forms.Button
    Friend WithEvents cboTrainDir As System.Windows.Forms.ComboBox
    Friend WithEvents cboTrainOrigOL As System.Windows.Forms.ComboBox
    Friend WithEvents cboTrainScope As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrainOriginOL As System.Windows.Forms.Label
    Friend WithEvents lblTrainScope As System.Windows.Forms.Label
    Friend WithEvents lblTrainClass As System.Windows.Forms.Label
    Friend WithEvents lblTrainType As System.Windows.Forms.Label
    Friend WithEvents lblTrainName As System.Windows.Forms.Label
    Friend WithEvents txtTrainName As System.Windows.Forms.TextBox
    Friend WithEvents dgvTrain As System.Windows.Forms.DataGridView
    Friend WithEvents cboTrainType As System.Windows.Forms.ComboBox
    Friend WithEvents nudTrainCars As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTrainCarLimit As System.Windows.Forms.Label
    Friend WithEvents ttpMaintTrain As System.Windows.Forms.ToolTip
    Friend WithEvents lblLowPriority As System.Windows.Forms.Label
    Friend WithEvents lblPctThru As System.Windows.Forms.Label
    Friend WithEvents nudThruCars As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboLowPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEditTrainWork As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTrainID As System.Windows.Forms.TextBox
    Friend WithEvents cboTrainDepartTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrainDepartTime As System.Windows.Forms.Label
    Friend WithEvents cboFromStagingArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblFromStagingArea As System.Windows.Forms.Label
    Friend WithEvents TrName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrDirection As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trClass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrScope As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrMaxCars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrPctThru As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrAllowLowPriority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrOrigOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrDepartTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrFromStagingArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTrainID As System.Windows.Forms.Label

End Class
