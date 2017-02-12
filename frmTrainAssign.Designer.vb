<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainAssign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainAssign))
        Me.cboTrainName = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblTrainType = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTrainStops = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDirection = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAllocated = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblMaxCars = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblDestination = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.lblOrigin = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTrainClass = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAddWBFromCatalog = New System.Windows.Forms.Button
        Me.cmdRemoveWB = New System.Windows.Forms.Button
        Me.dgvWbAssigned = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OnOffRRAt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destination = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WaybillID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InTrainSeq = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmdMoveWBUp = New System.Windows.Forms.Button
        Me.cmdMoveWBDown = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvWbAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTrainName
        '
        Me.cboTrainName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrainName.FormattingEnabled = True
        Me.cboTrainName.Location = New System.Drawing.Point(21, 40)
        Me.cboTrainName.Name = "cboTrainName"
        Me.cboTrainName.Size = New System.Drawing.Size(149, 23)
        Me.cboTrainName.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblTrainType)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblTrainStops)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblDirection)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblAllocated)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblMaxCars)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDestination)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.lblOrigin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblTrainClass)
        Me.GroupBox1.Controls.Add(Me.cboTrainName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 476)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Train"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(99, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Type"
        '
        'lblTrainType
        '
        Me.lblTrainType.BackColor = System.Drawing.SystemColors.Window
        Me.lblTrainType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrainType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainType.Location = New System.Drawing.Point(98, 84)
        Me.lblTrainType.Name = "lblTrainType"
        Me.lblTrainType.Size = New System.Drawing.Size(72, 23)
        Me.lblTrainType.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(54, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Cars in Train"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 310)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Makes Stops At"
        '
        'lblTrainStops
        '
        Me.lblTrainStops.BackColor = System.Drawing.SystemColors.Window
        Me.lblTrainStops.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrainStops.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainStops.Location = New System.Drawing.Point(21, 328)
        Me.lblTrainStops.Name = "lblTrainStops"
        Me.lblTrainStops.Size = New System.Drawing.Size(149, 120)
        Me.lblTrainStops.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Train Name / Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Direction"
        '
        'lblDirection
        '
        Me.lblDirection.BackColor = System.Drawing.SystemColors.Window
        Me.lblDirection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.Location = New System.Drawing.Point(21, 283)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(149, 23)
        Me.lblDirection.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Allocated"
        '
        'lblAllocated
        '
        Me.lblAllocated.BackColor = System.Drawing.SystemColors.Window
        Me.lblAllocated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAllocated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllocated.Location = New System.Drawing.Point(98, 147)
        Me.lblAllocated.Name = "lblAllocated"
        Me.lblAllocated.Size = New System.Drawing.Size(72, 23)
        Me.lblAllocated.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Car Limit"
        '
        'lblMaxCars
        '
        Me.lblMaxCars.BackColor = System.Drawing.SystemColors.Window
        Me.lblMaxCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxCars.Location = New System.Drawing.Point(21, 147)
        Me.lblMaxCars.Name = "lblMaxCars"
        Me.lblMaxCars.Size = New System.Drawing.Size(67, 23)
        Me.lblMaxCars.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Destination"
        '
        'lblDestination
        '
        Me.lblDestination.BackColor = System.Drawing.SystemColors.Window
        Me.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(21, 238)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(149, 23)
        Me.lblDestination.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(22, 174)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 15)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Origin"
        '
        'lblOrigin
        '
        Me.lblOrigin.BackColor = System.Drawing.SystemColors.Window
        Me.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.Location = New System.Drawing.Point(21, 192)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(149, 23)
        Me.lblOrigin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class"
        '
        'lblTrainClass
        '
        Me.lblTrainClass.BackColor = System.Drawing.SystemColors.Window
        Me.lblTrainClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrainClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainClass.Location = New System.Drawing.Point(21, 84)
        Me.lblTrainClass.Name = "lblTrainClass"
        Me.lblTrainClass.Size = New System.Drawing.Size(67, 23)
        Me.lblTrainClass.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdAddWBFromCatalog)
        Me.GroupBox2.Controls.Add(Me.cmdRemoveWB)
        Me.GroupBox2.Controls.Add(Me.dgvWbAssigned)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmdMoveWBUp)
        Me.GroupBox2.Controls.Add(Me.cmdMoveWBDown)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(208, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(886, 476)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmdAddWBFromCatalog
        '
        Me.cmdAddWBFromCatalog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddWBFromCatalog.Enabled = False
        Me.cmdAddWBFromCatalog.Location = New System.Drawing.Point(215, 425)
        Me.cmdAddWBFromCatalog.Name = "cmdAddWBFromCatalog"
        Me.cmdAddWBFromCatalog.Size = New System.Drawing.Size(176, 23)
        Me.cmdAddWBFromCatalog.TabIndex = 28
        Me.cmdAddWBFromCatalog.Text = "Add Waybill From Catalog"
        Me.cmdAddWBFromCatalog.UseVisualStyleBackColor = True
        '
        'cmdRemoveWB
        '
        Me.cmdRemoveWB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemoveWB.Location = New System.Drawing.Point(21, 425)
        Me.cmdRemoveWB.Name = "cmdRemoveWB"
        Me.cmdRemoveWB.Size = New System.Drawing.Size(176, 23)
        Me.cmdRemoveWB.TabIndex = 27
        Me.cmdRemoveWB.Text = "Remove Selected Waybill"
        Me.cmdRemoveWB.UseVisualStyleBackColor = True
        '
        'dgvWbAssigned
        '
        Me.dgvWbAssigned.AllowUserToAddRows = False
        Me.dgvWbAssigned.AllowUserToDeleteRows = False
        Me.dgvWbAssigned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWbAssigned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.OnOffRRAt, Me.Destination, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.WaybillID, Me.InTrainSeq})
        Me.dgvWbAssigned.Location = New System.Drawing.Point(20, 40)
        Me.dgvWbAssigned.MultiSelect = False
        Me.dgvWbAssigned.Name = "dgvWbAssigned"
        Me.dgvWbAssigned.ReadOnly = True
        Me.dgvWbAssigned.RowHeadersVisible = False
        Me.dgvWbAssigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWbAssigned.ShowEditingIcon = False
        Me.dgvWbAssigned.Size = New System.Drawing.Size(756, 369)
        Me.dgvWbAssigned.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SecRR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "From RR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Instructions"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Disposition"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'OnOffRRAt
        '
        Me.OnOffRRAt.DataPropertyName = "OnOffRRAt"
        Me.OnOffRRAt.HeaderText = "On/Off RR At"
        Me.OnOffRRAt.Name = "OnOffRRAt"
        Me.OnOffRRAt.ReadOnly = True
        Me.OnOffRRAt.Width = 80
        '
        'Destination
        '
        Me.Destination.DataPropertyName = "Destination"
        Me.Destination.HeaderText = "Destination"
        Me.Destination.Name = "Destination"
        Me.Destination.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PriInd"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Industry"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Siding"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Siding"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "wbCarType"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Car Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "wbComm"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Commodity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "wbPrimarySR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ship/Recv"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'WaybillID
        '
        Me.WaybillID.DataPropertyName = "WaybillID"
        Me.WaybillID.HeaderText = "WaybillID"
        Me.WaybillID.Name = "WaybillID"
        Me.WaybillID.ReadOnly = True
        Me.WaybillID.Visible = False
        '
        'InTrainSeq
        '
        Me.InTrainSeq.DataPropertyName = "InTrainSeq"
        Me.InTrainSeq.HeaderText = "In-Train Sequence"
        Me.InTrainSeq.Name = "InTrainSeq"
        Me.InTrainSeq.ReadOnly = True
        Me.InTrainSeq.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Waybills"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(804, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 46)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Change Waybill Order"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdMoveWBUp
        '
        Me.cmdMoveWBUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveWBUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveWBUp.Location = New System.Drawing.Point(804, 114)
        Me.cmdMoveWBUp.Name = "cmdMoveWBUp"
        Me.cmdMoveWBUp.Size = New System.Drawing.Size(55, 49)
        Me.cmdMoveWBUp.TabIndex = 22
        Me.cmdMoveWBUp.Text = "Move Up"
        Me.cmdMoveWBUp.UseVisualStyleBackColor = True
        '
        'cmdMoveWBDown
        '
        Me.cmdMoveWBDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMoveWBDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveWBDown.Location = New System.Drawing.Point(804, 286)
        Me.cmdMoveWBDown.Name = "cmdMoveWBDown"
        Me.cmdMoveWBDown.Size = New System.Drawing.Size(55, 49)
        Me.cmdMoveWBDown.TabIndex = 21
        Me.cmdMoveWBDown.Text = "Move Down"
        Me.cmdMoveWBDown.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 15)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Waybills Assigned to Train"
        '
        'frmTrainAssign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTrainAssign"
        Me.Text = "Here To There - Assign In-Bound Waybills To Trains"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvWbAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTrainName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lblOrigin As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTrainClass As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAllocated As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMaxCars As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTrainStops As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdMoveWBUp As System.Windows.Forms.Button
    Friend WithEvents cmdMoveWBDown As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTrainType As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvWbAssigned As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRemoveWB As System.Windows.Forms.Button
    Friend WithEvents cmdAddWBFromCatalog As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OnOffRRAt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaybillID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InTrainSeq As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
