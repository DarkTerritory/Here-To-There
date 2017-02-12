<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerate))
        Me.dgvTrainLoadCount = New System.Windows.Forms.DataGridView
        Me.TrID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrCarLimit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WaybillCount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LkDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdGo = New System.Windows.Forms.Button
        Me.lblGo = New System.Windows.Forms.Label
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.lblNext = New System.Windows.Forms.Label
        Me.cmdNext = New System.Windows.Forms.Button
        Me.lblInstructionTitle = New System.Windows.Forms.Label
        Me.dgvAgentAssign = New System.Windows.Forms.DataGridView
        Me.CatalogID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.RouteVerso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriInd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatSpots = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvTrainLoadCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAgentAssign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTrainLoadCount
        '
        Me.dgvTrainLoadCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrainLoadCount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrID, Me.TrName, Me.TrCarLimit, Me.WaybillCount, Me.LkDesc})
        Me.dgvTrainLoadCount.Location = New System.Drawing.Point(104, 140)
        Me.dgvTrainLoadCount.Name = "dgvTrainLoadCount"
        Me.dgvTrainLoadCount.Size = New System.Drawing.Size(613, 199)
        Me.dgvTrainLoadCount.TabIndex = 0
        '
        'TrID
        '
        Me.TrID.DataPropertyName = "TrID"
        Me.TrID.HeaderText = "TrainID"
        Me.TrID.Name = "TrID"
        Me.TrID.Visible = False
        '
        'TrName
        '
        Me.TrName.DataPropertyName = "TrName"
        Me.TrName.HeaderText = "Train (Offline)"
        Me.TrName.Name = "TrName"
        Me.TrName.Width = 150
        '
        'TrCarLimit
        '
        Me.TrCarLimit.DataPropertyName = "TrCarLimit"
        Me.TrCarLimit.HeaderText = "Local Car Limit"
        Me.TrCarLimit.Name = "TrCarLimit"
        '
        'WaybillCount
        '
        Me.WaybillCount.DataPropertyName = "WaybillCount"
        Me.WaybillCount.HeaderText = "Assigned Cars"
        Me.WaybillCount.Name = "WaybillCount"
        '
        'LkDesc
        '
        Me.LkDesc.DataPropertyName = "LkDesc"
        Me.LkDesc.HeaderText = "From Staging Area"
        Me.LkDesc.Name = "LkDesc"
        Me.LkDesc.Width = 200
        '
        'cmdGo
        '
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(224, 370)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(59, 52)
        Me.cmdGo.TabIndex = 1
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'lblGo
        '
        Me.lblGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGo.Location = New System.Drawing.Point(101, 370)
        Me.lblGo.Name = "lblGo"
        Me.lblGo.Size = New System.Drawing.Size(117, 52)
        Me.lblGo.TabIndex = 2
        Me.lblGo.Text = "To make an initial pass through the Catalog Click GO"
        Me.lblGo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(104, 56)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(610, 81)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Instruction Text"
        '
        'lblNext
        '
        Me.lblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(534, 370)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(117, 52)
        Me.lblNext.TabIndex = 5
        Me.lblNext.Text = "The next process assigns through cars to each train"
        Me.lblNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(657, 370)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(59, 52)
        Me.cmdNext.TabIndex = 4
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'lblInstructionTitle
        '
        Me.lblInstructionTitle.AutoSize = True
        Me.lblInstructionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionTitle.Location = New System.Drawing.Point(104, 21)
        Me.lblInstructionTitle.Name = "lblInstructionTitle"
        Me.lblInstructionTitle.Size = New System.Drawing.Size(351, 16)
        Me.lblInstructionTitle.TabIndex = 6
        Me.lblInstructionTitle.Text = "Step One - Assign Local Traffic Waybills to Trains"
        '
        'dgvAgentAssign
        '
        Me.dgvAgentAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgentAssign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatalogID, Me.colChecked, Me.RouteVerso, Me.CatComm, Me.PriInd, Me.PriCity, Me.PriState, Me.CatSpots})
        Me.dgvAgentAssign.Location = New System.Drawing.Point(95, 129)
        Me.dgvAgentAssign.Name = "dgvAgentAssign"
        Me.dgvAgentAssign.Size = New System.Drawing.Size(613, 199)
        Me.dgvAgentAssign.TabIndex = 8
        Me.dgvAgentAssign.Visible = False
        '
        'CatalogID
        '
        Me.CatalogID.DataPropertyName = "CatalogID"
        Me.CatalogID.HeaderText = "Cat ID"
        Me.CatalogID.Name = "CatalogID"
        Me.CatalogID.Visible = False
        '
        'colChecked
        '
        Me.colChecked.HeaderText = "Use?"
        Me.colChecked.Name = "colChecked"
        Me.colChecked.Width = 40
        '
        'RouteVerso
        '
        Me.RouteVerso.DataPropertyName = "RouteVerso"
        Me.RouteVerso.HeaderText = "Bill Type"
        Me.RouteVerso.Name = "RouteVerso"
        '
        'CatComm
        '
        Me.CatComm.DataPropertyName = "CatComm"
        Me.CatComm.HeaderText = "Commodity"
        Me.CatComm.Name = "CatComm"
        '
        'PriInd
        '
        Me.PriInd.DataPropertyName = "PriInd"
        Me.PriInd.HeaderText = "Industry"
        Me.PriInd.Name = "PriInd"
        Me.PriInd.Width = 150
        '
        'PriCity
        '
        Me.PriCity.DataPropertyName = "PriCity"
        Me.PriCity.HeaderText = "City "
        Me.PriCity.Name = "PriCity"
        Me.PriCity.Width = 75
        '
        'PriState
        '
        Me.PriState.DataPropertyName = "PriState"
        Me.PriState.HeaderText = "State"
        Me.PriState.Name = "PriState"
        Me.PriState.Width = 50
        '
        'CatSpots
        '
        Me.CatSpots.DataPropertyName = "CatSpots"
        Me.CatSpots.HeaderText = "Bill Count"
        Me.CatSpots.Name = "CatSpots"
        Me.CatSpots.Width = 50
        '
        'frmGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 444)
        Me.Controls.Add(Me.dgvAgentAssign)
        Me.Controls.Add(Me.lblInstructionTitle)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblGo)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.dgvTrainLoadCount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGenerate"
        Me.Text = "Generate a New Operating Session"
        CType(Me.dgvTrainLoadCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAgentAssign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTrainLoadCount As System.Windows.Forms.DataGridView
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents lblGo As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblInstructionTitle As System.Windows.Forms.Label
    Friend WithEvents TrID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrCarLimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaybillCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LkDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAgentAssign As System.Windows.Forms.DataGridView
    Friend WithEvents CatalogID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChecked As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RouteVerso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriInd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatSpots As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
