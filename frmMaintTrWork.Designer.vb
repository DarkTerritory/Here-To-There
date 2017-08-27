<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintTrWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintTrWork))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.lblTWWorkInd = New System.Windows.Forms.Label
        Me.cboWorkTown = New System.Windows.Forms.ComboBox
        Me.cmdWorkReset = New System.Windows.Forms.Button
        Me.cmdWorkHelp = New System.Windows.Forms.Button
        Me.cmdWorkSave = New System.Windows.Forms.Button
        Me.cmdWorkDelete = New System.Windows.Forms.Button
        Me.cmdWorkEdit = New System.Windows.Forms.Button
        Me.cmdWorkNew = New System.Windows.Forms.Button
        Me.cboWorkInd = New System.Windows.Forms.ComboBox
        Me.cboWorkSOPU = New System.Windows.Forms.ComboBox
        Me.lblTWSOPU = New System.Windows.Forms.Label
        Me.lblTWTown = New System.Windows.Forms.Label
        Me.lblTWStop = New System.Windows.Forms.Label
        Me.dgvWork = New System.Windows.Forms.DataGridView
        Me.TrWorkID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkTrainName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkTrainID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkDirOfTravel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkStopNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkTown = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkSOPU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrWorkWorkIndustry = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nudWorkStop = New System.Windows.Forms.NumericUpDown
        Me.lblTWDir = New System.Windows.Forms.Label
        Me.ttpMaintTrainWork = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboWorkDirOfTravel = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWorkStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(512, 361)
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
        'lblTWWorkInd
        '
        Me.lblTWWorkInd.AutoSize = True
        Me.lblTWWorkInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTWWorkInd.Location = New System.Drawing.Point(547, 106)
        Me.lblTWWorkInd.Name = "lblTWWorkInd"
        Me.lblTWWorkInd.Size = New System.Drawing.Size(62, 15)
        Me.lblTWWorkInd.TabIndex = 118
        Me.lblTWWorkInd.Text = "Work Ind?"
        '
        'cboWorkTown
        '
        Me.cboWorkTown.Enabled = False
        Me.cboWorkTown.FormattingEnabled = True
        Me.cboWorkTown.Location = New System.Drawing.Point(349, 129)
        Me.cboWorkTown.Name = "cboWorkTown"
        Me.cboWorkTown.Size = New System.Drawing.Size(121, 21)
        Me.cboWorkTown.TabIndex = 113
        '
        'cmdWorkReset
        '
        Me.cmdWorkReset.Location = New System.Drawing.Point(300, 46)
        Me.cmdWorkReset.Name = "cmdWorkReset"
        Me.cmdWorkReset.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkReset.TabIndex = 111
        Me.cmdWorkReset.Text = "Reset"
        '
        'cmdWorkHelp
        '
        Me.cmdWorkHelp.Enabled = False
        Me.cmdWorkHelp.Location = New System.Drawing.Point(455, 46)
        Me.cmdWorkHelp.Name = "cmdWorkHelp"
        Me.cmdWorkHelp.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkHelp.TabIndex = 110
        Me.cmdWorkHelp.Text = "Help"
        '
        'cmdWorkSave
        '
        Me.cmdWorkSave.Location = New System.Drawing.Point(215, 46)
        Me.cmdWorkSave.Name = "cmdWorkSave"
        Me.cmdWorkSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkSave.TabIndex = 109
        Me.cmdWorkSave.Text = "Save"
        '
        'cmdWorkDelete
        '
        Me.cmdWorkDelete.Location = New System.Drawing.Point(554, 46)
        Me.cmdWorkDelete.Name = "cmdWorkDelete"
        Me.cmdWorkDelete.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkDelete.TabIndex = 108
        Me.cmdWorkDelete.Text = "Delete"
        '
        'cmdWorkEdit
        '
        Me.cmdWorkEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWorkEdit.Location = New System.Drawing.Point(130, 46)
        Me.cmdWorkEdit.Name = "cmdWorkEdit"
        Me.cmdWorkEdit.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkEdit.TabIndex = 107
        Me.cmdWorkEdit.Text = "Edit"
        Me.cmdWorkEdit.UseVisualStyleBackColor = True
        '
        'cmdWorkNew
        '
        Me.cmdWorkNew.Location = New System.Drawing.Point(44, 46)
        Me.cmdWorkNew.Name = "cmdWorkNew"
        Me.cmdWorkNew.Size = New System.Drawing.Size(78, 27)
        Me.cmdWorkNew.TabIndex = 106
        Me.cmdWorkNew.Text = "New"
        '
        'cboWorkInd
        '
        Me.cboWorkInd.Enabled = False
        Me.cboWorkInd.FormattingEnabled = True
        Me.cboWorkInd.Location = New System.Drawing.Point(550, 129)
        Me.cboWorkInd.Name = "cboWorkInd"
        Me.cboWorkInd.Size = New System.Drawing.Size(78, 21)
        Me.cboWorkInd.TabIndex = 104
        '
        'cboWorkSOPU
        '
        Me.cboWorkSOPU.Enabled = False
        Me.cboWorkSOPU.FormattingEnabled = True
        Me.cboWorkSOPU.Location = New System.Drawing.Point(476, 129)
        Me.cboWorkSOPU.Name = "cboWorkSOPU"
        Me.cboWorkSOPU.Size = New System.Drawing.Size(68, 21)
        Me.cboWorkSOPU.TabIndex = 103
        '
        'lblTWSOPU
        '
        Me.lblTWSOPU.AutoSize = True
        Me.lblTWSOPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTWSOPU.Location = New System.Drawing.Point(473, 106)
        Me.lblTWSOPU.Name = "lblTWSOPU"
        Me.lblTWSOPU.Size = New System.Drawing.Size(50, 15)
        Me.lblTWSOPU.TabIndex = 101
        Me.lblTWSOPU.Text = "SO / PU"
        '
        'lblTWTown
        '
        Me.lblTWTown.AutoSize = True
        Me.lblTWTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTWTown.Location = New System.Drawing.Point(346, 106)
        Me.lblTWTown.Name = "lblTWTown"
        Me.lblTWTown.Size = New System.Drawing.Size(37, 15)
        Me.lblTWTown.TabIndex = 100
        Me.lblTWTown.Text = "Town"
        '
        'lblTWStop
        '
        Me.lblTWStop.AutoSize = True
        Me.lblTWStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTWStop.Location = New System.Drawing.Point(270, 106)
        Me.lblTWStop.Name = "lblTWStop"
        Me.lblTWStop.Size = New System.Drawing.Size(42, 15)
        Me.lblTWStop.TabIndex = 99
        Me.lblTWStop.Text = "Stop #"
        '
        'dgvWork
        '
        Me.dgvWork.AllowUserToAddRows = False
        Me.dgvWork.AllowUserToDeleteRows = False
        Me.dgvWork.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrWorkID, Me.TrWorkTrainName, Me.TrWorkTrainID, Me.TrWorkDirOfTravel, Me.TrWorkStopNum, Me.TrWorkTown, Me.TrWorkSOPU, Me.TrWorkWorkIndustry})
        Me.dgvWork.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvWork.Location = New System.Drawing.Point(44, 173)
        Me.dgvWork.MultiSelect = False
        Me.dgvWork.Name = "dgvWork"
        Me.dgvWork.RowHeadersVisible = False
        Me.dgvWork.Size = New System.Drawing.Size(588, 170)
        Me.dgvWork.TabIndex = 96
        '
        'TrWorkID
        '
        Me.TrWorkID.DataPropertyName = "TrWorkID"
        Me.TrWorkID.HeaderText = "TrWorkID"
        Me.TrWorkID.Name = "TrWorkID"
        Me.TrWorkID.Visible = False
        '
        'TrWorkTrainName
        '
        Me.TrWorkTrainName.DataPropertyName = "TrWorkTrainName"
        Me.TrWorkTrainName.HeaderText = "Train Name"
        Me.TrWorkTrainName.Name = "TrWorkTrainName"
        Me.TrWorkTrainName.Width = 150
        '
        'TrWorkTrainID
        '
        Me.TrWorkTrainID.DataPropertyName = "TrWorkTrainID"
        Me.TrWorkTrainID.HeaderText = "ID #"
        Me.TrWorkTrainID.Name = "TrWorkTrainID"
        Me.TrWorkTrainID.Visible = False
        Me.TrWorkTrainID.Width = 50
        '
        'TrWorkDirOfTravel
        '
        Me.TrWorkDirOfTravel.DataPropertyName = "TrWorkDirOfTravel"
        Me.TrWorkDirOfTravel.HeaderText = "Direction"
        Me.TrWorkDirOfTravel.Name = "TrWorkDirOfTravel"
        Me.TrWorkDirOfTravel.Width = 80
        '
        'TrWorkStopNum
        '
        Me.TrWorkStopNum.DataPropertyName = "TrWorkStopNum"
        Me.TrWorkStopNum.HeaderText = "Stop"
        Me.TrWorkStopNum.Name = "TrWorkStopNum"
        Me.TrWorkStopNum.Width = 75
        '
        'TrWorkTown
        '
        Me.TrWorkTown.DataPropertyName = "TrWorkTown"
        Me.TrWorkTown.HeaderText = "Town"
        Me.TrWorkTown.Name = "TrWorkTown"
        Me.TrWorkTown.Width = 125
        '
        'TrWorkSOPU
        '
        Me.TrWorkSOPU.DataPropertyName = "TrWorkSOPU"
        Me.TrWorkSOPU.HeaderText = "SO / PU"
        Me.TrWorkSOPU.Name = "TrWorkSOPU"
        Me.TrWorkSOPU.Width = 75
        '
        'TrWorkWorkIndustry
        '
        Me.TrWorkWorkIndustry.DataPropertyName = "TrWorkWorkIndustry"
        Me.TrWorkWorkIndustry.HeaderText = "Work Ind"
        Me.TrWorkWorkIndustry.Name = "TrWorkWorkIndustry"
        Me.TrWorkWorkIndustry.Width = 75
        '
        'nudWorkStop
        '
        Me.nudWorkStop.Location = New System.Drawing.Point(273, 130)
        Me.nudWorkStop.Name = "nudWorkStop"
        Me.nudWorkStop.Size = New System.Drawing.Size(68, 20)
        Me.nudWorkStop.TabIndex = 120
        '
        'lblTWDir
        '
        Me.lblTWDir.AutoSize = True
        Me.lblTWDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTWDir.Location = New System.Drawing.Point(195, 106)
        Me.lblTWDir.Name = "lblTWDir"
        Me.lblTWDir.Size = New System.Drawing.Size(56, 15)
        Me.lblTWDir.TabIndex = 124
        Me.lblTWDir.Text = "Direction"
        '
        'cboWorkDirOfTravel
        '
        Me.cboWorkDirOfTravel.Enabled = False
        Me.cboWorkDirOfTravel.FormattingEnabled = True
        Me.cboWorkDirOfTravel.Location = New System.Drawing.Point(198, 130)
        Me.cboWorkDirOfTravel.Name = "cboWorkDirOfTravel"
        Me.cboWorkDirOfTravel.Size = New System.Drawing.Size(68, 21)
        Me.cboWorkDirOfTravel.TabIndex = 127
        '
        'frmMaintTrWork
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 402)
        Me.Controls.Add(Me.cboWorkDirOfTravel)
        Me.Controls.Add(Me.lblTWDir)
        Me.Controls.Add(Me.nudWorkStop)
        Me.Controls.Add(Me.lblTWWorkInd)
        Me.Controls.Add(Me.cboWorkTown)
        Me.Controls.Add(Me.cmdWorkReset)
        Me.Controls.Add(Me.cmdWorkHelp)
        Me.Controls.Add(Me.cmdWorkSave)
        Me.Controls.Add(Me.cmdWorkDelete)
        Me.Controls.Add(Me.cmdWorkEdit)
        Me.Controls.Add(Me.cmdWorkNew)
        Me.Controls.Add(Me.cboWorkInd)
        Me.Controls.Add(Me.cboWorkSOPU)
        Me.Controls.Add(Me.lblTWSOPU)
        Me.Controls.Add(Me.lblTWTown)
        Me.Controls.Add(Me.lblTWStop)
        Me.Controls.Add(Me.dgvWork)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaintTrWork"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain - Train Work"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWorkStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblTWWorkInd As System.Windows.Forms.Label
    Friend WithEvents cboWorkTown As System.Windows.Forms.ComboBox
    Friend WithEvents cmdWorkReset As System.Windows.Forms.Button
    Friend WithEvents cmdWorkHelp As System.Windows.Forms.Button
    Friend WithEvents cmdWorkSave As System.Windows.Forms.Button
    Friend WithEvents cmdWorkDelete As System.Windows.Forms.Button
    Friend WithEvents cmdWorkEdit As System.Windows.Forms.Button
    Friend WithEvents cmdWorkNew As System.Windows.Forms.Button
    Friend WithEvents cboWorkInd As System.Windows.Forms.ComboBox
    Friend WithEvents cboWorkSOPU As System.Windows.Forms.ComboBox
    Friend WithEvents lblTWSOPU As System.Windows.Forms.Label
    Friend WithEvents lblTWTown As System.Windows.Forms.Label
    Friend WithEvents lblTWStop As System.Windows.Forms.Label
    Friend WithEvents dgvWork As System.Windows.Forms.DataGridView
    Friend WithEvents nudWorkStop As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTWDir As System.Windows.Forms.Label
    Friend WithEvents TrWorkID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkTrainName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkTrainID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkDirOfTravel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkStopNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkTown As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkSOPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrWorkWorkIndustry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttpMaintTrainWork As System.Windows.Forms.ToolTip
    Friend WithEvents cboWorkDirOfTravel As System.Windows.Forms.ComboBox

End Class
