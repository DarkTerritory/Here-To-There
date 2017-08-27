<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectPartner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectPartner))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cmdChangeComm = New System.Windows.Forms.Button()
        Me.dgvPartners = New System.Windows.Forms.DataGridView()
        Me.CLIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipRecv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Siding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkOnline = New System.Windows.Forms.CheckBox()
        Me.chkOffline = New System.Windows.Forms.CheckBox()
        Me.cboFilterBy = New System.Windows.Forms.ComboBox()
        Me.cboFilterByValue = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCommodity = New System.Windows.Forms.ComboBox()
        Me.optShippers = New System.Windows.Forms.RadioButton()
        Me.optReceivers = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkShowAny = New System.Windows.Forms.CheckBox()
        Me.chkLCL = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.ttpSelPartner = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvPartners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(510, 387)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 27)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'cmdChangeComm
        '
        Me.cmdChangeComm.Location = New System.Drawing.Point(282, 30)
        Me.cmdChangeComm.Name = "cmdChangeComm"
        Me.cmdChangeComm.Size = New System.Drawing.Size(162, 23)
        Me.cmdChangeComm.TabIndex = 17
        Me.cmdChangeComm.Text = "Change Commodity"
        Me.cmdChangeComm.UseVisualStyleBackColor = True
        '
        'dgvPartners
        '
        Me.dgvPartners.AllowUserToAddRows = False
        Me.dgvPartners.AllowUserToDeleteRows = False
        Me.dgvPartners.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIC, Me.IndName, Me.IndCity, Me.IndState, Me.IndRR, Me.ShipRecv, Me.Siding, Me.Notes})
        Me.dgvPartners.Location = New System.Drawing.Point(27, 138)
        Me.dgvPartners.Name = "dgvPartners"
        Me.dgvPartners.ReadOnly = True
        Me.dgvPartners.RowHeadersVisible = False
        Me.dgvPartners.Size = New System.Drawing.Size(638, 232)
        Me.dgvPartners.TabIndex = 18
        '
        'CLIC
        '
        Me.CLIC.DataPropertyName = "CLIC"
        Me.CLIC.HeaderText = "CLIC"
        Me.CLIC.Name = "CLIC"
        Me.CLIC.ReadOnly = True
        '
        'IndName
        '
        Me.IndName.DataPropertyName = "IndName"
        Me.IndName.HeaderText = "Industry Name"
        Me.IndName.Name = "IndName"
        Me.IndName.ReadOnly = True
        Me.IndName.Width = 200
        '
        'IndCity
        '
        Me.IndCity.DataPropertyName = "IndCity"
        Me.IndCity.HeaderText = "City"
        Me.IndCity.Name = "IndCity"
        Me.IndCity.ReadOnly = True
        Me.IndCity.Width = 150
        '
        'IndState
        '
        Me.IndState.DataPropertyName = "IndState"
        Me.IndState.HeaderText = "State"
        Me.IndState.Name = "IndState"
        Me.IndState.ReadOnly = True
        Me.IndState.Width = 40
        '
        'IndRR
        '
        Me.IndRR.DataPropertyName = "IndRR"
        Me.IndRR.HeaderText = "Home Road"
        Me.IndRR.Name = "IndRR"
        Me.IndRR.ReadOnly = True
        '
        'ShipRecv
        '
        Me.ShipRecv.DataPropertyName = "ShipRecv"
        Me.ShipRecv.HeaderText = "S/R"
        Me.ShipRecv.Name = "ShipRecv"
        Me.ShipRecv.ReadOnly = True
        Me.ShipRecv.Width = 40
        '
        'Siding
        '
        Me.Siding.DataPropertyName = "Siding"
        Me.Siding.HeaderText = "Siding"
        Me.Siding.Name = "Siding"
        Me.Siding.ReadOnly = True
        Me.Siding.Visible = False
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'chkOnline
        '
        Me.chkOnline.AutoSize = True
        Me.chkOnline.Location = New System.Drawing.Point(97, 17)
        Me.chkOnline.Name = "chkOnline"
        Me.chkOnline.Size = New System.Drawing.Size(70, 19)
        Me.chkOnline.TabIndex = 19
        Me.chkOnline.Text = "On-Line"
        Me.chkOnline.UseVisualStyleBackColor = True
        '
        'chkOffline
        '
        Me.chkOffline.AutoSize = True
        Me.chkOffline.Location = New System.Drawing.Point(97, 38)
        Me.chkOffline.Name = "chkOffline"
        Me.chkOffline.Size = New System.Drawing.Size(69, 19)
        Me.chkOffline.TabIndex = 20
        Me.chkOffline.Text = "Off-Line"
        Me.chkOffline.UseVisualStyleBackColor = True
        '
        'cboFilterBy
        '
        Me.cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterBy.FormattingEnabled = True
        Me.cboFilterBy.Items.AddRange(New Object() {"No Filter", "CLIC", "Industry Name", "City", "State", "Home Road"})
        Me.cboFilterBy.Location = New System.Drawing.Point(467, 30)
        Me.cboFilterBy.Name = "cboFilterBy"
        Me.cboFilterBy.Size = New System.Drawing.Size(153, 23)
        Me.cboFilterBy.TabIndex = 21
        '
        'cboFilterByValue
        '
        Me.cboFilterByValue.FormattingEnabled = True
        Me.cboFilterByValue.Location = New System.Drawing.Point(467, 73)
        Me.cboFilterByValue.Name = "cboFilterByValue"
        Me.cboFilterByValue.Size = New System.Drawing.Size(151, 23)
        Me.cboFilterByValue.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Filter By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Value"
        '
        'cboCommodity
        '
        Me.cboCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommodity.FormattingEnabled = True
        Me.cboCommodity.Location = New System.Drawing.Point(282, 73)
        Me.cboCommodity.Name = "cboCommodity"
        Me.cboCommodity.Size = New System.Drawing.Size(162, 23)
        Me.cboCommodity.TabIndex = 25
        '
        'optShippers
        '
        Me.optShippers.AutoSize = True
        Me.optShippers.Location = New System.Drawing.Point(186, 16)
        Me.optShippers.Name = "optShippers"
        Me.optShippers.Size = New System.Drawing.Size(74, 19)
        Me.optShippers.TabIndex = 26
        Me.optShippers.TabStop = True
        Me.optShippers.Text = "Shippers"
        Me.optShippers.UseVisualStyleBackColor = True
        '
        'optReceivers
        '
        Me.optReceivers.AutoSize = True
        Me.optReceivers.Location = New System.Drawing.Point(186, 37)
        Me.optReceivers.Name = "optReceivers"
        Me.optReceivers.Size = New System.Drawing.Size(79, 19)
        Me.optReceivers.TabIndex = 27
        Me.optReceivers.TabStop = True
        Me.optReceivers.Text = "Receivers"
        Me.optReceivers.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(186, 59)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(38, 19)
        Me.optAll.TabIndex = 28
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.chkShowAny)
        Me.GroupBox1.Controls.Add(Me.chkLCL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.cboCommodity)
        Me.GroupBox1.Controls.Add(Me.cboFilterBy)
        Me.GroupBox1.Controls.Add(Me.optAll)
        Me.GroupBox1.Controls.Add(Me.cmdChangeComm)
        Me.GroupBox1.Controls.Add(Me.cboFilterByValue)
        Me.GroupBox1.Controls.Add(Me.chkOnline)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.optShippers)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.optReceivers)
        Me.GroupBox1.Controls.Add(Me.chkOffline)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 108)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 27)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Clear Filters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkShowAny
        '
        Me.chkShowAny.AutoSize = True
        Me.chkShowAny.Location = New System.Drawing.Point(97, 82)
        Me.chkShowAny.Name = "chkShowAny"
        Me.chkShowAny.Size = New System.Drawing.Size(156, 19)
        Me.chkShowAny.TabIndex = 32
        Me.chkShowAny.Text = "Show 'Any' Destinations"
        Me.chkShowAny.UseVisualStyleBackColor = True
        '
        'chkLCL
        '
        Me.chkLCL.AutoSize = True
        Me.chkLCL.Location = New System.Drawing.Point(97, 60)
        Me.chkLCL.Name = "chkLCL"
        Me.chkLCL.Size = New System.Drawing.Size(57, 19)
        Me.chkLCL.TabIndex = 31
        Me.chkLCL.Text = "L.C.L."
        Me.chkLCL.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Commodity"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(6, 20)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(74, 52)
        Me.cmdSearch.TabIndex = 29
        Me.cmdSearch.Text = "Filtered Search "
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'frmSelectPartner
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(694, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvPartners)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectPartner"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Build Catalog - Select Secondary Trading Partners"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvPartners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cmdChangeComm As System.Windows.Forms.Button
    Friend WithEvents dgvPartners As System.Windows.Forms.DataGridView
    Friend WithEvents chkOnline As System.Windows.Forms.CheckBox
    Friend WithEvents chkOffline As System.Windows.Forms.CheckBox
    Friend WithEvents cboFilterBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboFilterByValue As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCommodity As System.Windows.Forms.ComboBox
    Friend WithEvents optShippers As System.Windows.Forms.RadioButton
    Friend WithEvents optReceivers As System.Windows.Forms.RadioButton
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chkLCL As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowAny As System.Windows.Forms.CheckBox
    Friend WithEvents ttpSelPartner As System.Windows.Forms.ToolTip
    Friend WithEvents CLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipRecv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Siding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
