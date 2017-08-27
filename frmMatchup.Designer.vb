<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatchup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId:="dgrSelectedRow")>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatchup))
        Me.gbPrimary = New System.Windows.Forms.GroupBox()
        Me.lablLCL = New System.Windows.Forms.Label()
        Me.chkLCL = New System.Windows.Forms.CheckBox()
        Me.lblPriServedByCd = New System.Windows.Forms.Label()
        Me.lblPriTownCd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPriServedBy = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPriDivision = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPriSiding = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPriRR = New System.Windows.Forms.Label()
        Me.lblPriState = New System.Windows.Forms.Label()
        Me.lblPriTown = New System.Windows.Forms.Label()
        Me.lblPriInd = New System.Windows.Forms.Label()
        Me.gbSecondary = New System.Windows.Forms.GroupBox()
        Me.lblSecServedByCd = New System.Windows.Forms.Label()
        Me.lblSecTownCd = New System.Windows.Forms.Label()
        Me.cmdSelectSecondary = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSecServedBy = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSecDivision = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblSecSiding = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSecRR = New System.Windows.Forms.Label()
        Me.lblSecState = New System.Windows.Forms.Label()
        Me.lblSecTown = New System.Windows.Forms.Label()
        Me.lblSecInd = New System.Windows.Forms.Label()
        Me.lblCommodity = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblWaybillStatus = New System.Windows.Forms.Label()
        Me.dgvSelInd = New System.Windows.Forms.DataGridView()
        Me.CatalogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommodity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipRecv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.indCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommIdx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Siding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frequency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriDiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriServBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblBillCount = New System.Windows.Forms.Label()
        Me.gbRouting = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWbNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optVerso3 = New System.Windows.Forms.RadioButton()
        Me.optverso2 = New System.Windows.Forms.RadioButton()
        Me.optVerso1 = New System.Windows.Forms.RadioButton()
        Me.cmdEditVia = New System.Windows.Forms.Button()
        Me.lblInterchangeAt = New System.Windows.Forms.Label()
        Me.cboStaging = New System.Windows.Forms.ComboBox()
        Me.cboInterchangeWith = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmdSaveWaybill = New System.Windows.Forms.Button()
        Me.cmdClearFields = New System.Windows.Forms.Button()
        Me.ttpMatchup = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.gbPrimary.SuspendLayout()
        Me.gbSecondary.SuspendLayout()
        CType(Me.dgvSelInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRouting.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPrimary
        '
        Me.gbPrimary.Controls.Add(Me.lablLCL)
        Me.gbPrimary.Controls.Add(Me.chkLCL)
        Me.gbPrimary.Controls.Add(Me.lblPriServedByCd)
        Me.gbPrimary.Controls.Add(Me.lblPriTownCd)
        Me.gbPrimary.Controls.Add(Me.Label5)
        Me.gbPrimary.Controls.Add(Me.lblPriServedBy)
        Me.gbPrimary.Controls.Add(Me.Label3)
        Me.gbPrimary.Controls.Add(Me.lblPriDivision)
        Me.gbPrimary.Controls.Add(Me.Label1)
        Me.gbPrimary.Controls.Add(Me.lblPriSiding)
        Me.gbPrimary.Controls.Add(Me.Label12)
        Me.gbPrimary.Controls.Add(Me.Label11)
        Me.gbPrimary.Controls.Add(Me.Label10)
        Me.gbPrimary.Controls.Add(Me.Label9)
        Me.gbPrimary.Controls.Add(Me.lblPriRR)
        Me.gbPrimary.Controls.Add(Me.lblPriState)
        Me.gbPrimary.Controls.Add(Me.lblPriTown)
        Me.gbPrimary.Controls.Add(Me.lblPriInd)
        Me.gbPrimary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrimary.Location = New System.Drawing.Point(27, 301)
        Me.gbPrimary.Name = "gbPrimary"
        Me.gbPrimary.Size = New System.Drawing.Size(495, 118)
        Me.gbPrimary.TabIndex = 0
        Me.gbPrimary.TabStop = False
        Me.gbPrimary.Text = "Primary Industry"
        '
        'lablLCL
        '
        Me.lablLCL.AutoSize = True
        Me.lablLCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablLCL.Location = New System.Drawing.Point(442, 69)
        Me.lablLCL.Name = "lablLCL"
        Me.lablLCL.Size = New System.Drawing.Size(38, 15)
        Me.lablLCL.TabIndex = 17
        Me.lablLCL.Text = "L.C.L."
        '
        'chkLCL
        '
        Me.chkLCL.AutoSize = True
        Me.chkLCL.Location = New System.Drawing.Point(453, 88)
        Me.chkLCL.Name = "chkLCL"
        Me.chkLCL.Size = New System.Drawing.Size(15, 14)
        Me.chkLCL.TabIndex = 16
        Me.chkLCL.UseVisualStyleBackColor = True
        '
        'lblPriServedByCd
        '
        Me.lblPriServedByCd.AutoSize = True
        Me.lblPriServedByCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriServedByCd.Location = New System.Drawing.Point(420, 69)
        Me.lblPriServedByCd.Name = "lblPriServedByCd"
        Me.lblPriServedByCd.Size = New System.Drawing.Size(15, 15)
        Me.lblPriServedByCd.TabIndex = 15
        Me.lblPriServedByCd.Text = "X"
        Me.lblPriServedByCd.Visible = False
        '
        'lblPriTownCd
        '
        Me.lblPriTownCd.AutoSize = True
        Me.lblPriTownCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriTownCd.Location = New System.Drawing.Point(335, 26)
        Me.lblPriTownCd.Name = "lblPriTownCd"
        Me.lblPriTownCd.Size = New System.Drawing.Size(15, 15)
        Me.lblPriTownCd.TabIndex = 14
        Me.lblPriTownCd.Text = "X"
        Me.lblPriTownCd.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Division"
        '
        'lblPriServedBy
        '
        Me.lblPriServedBy.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriServedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriServedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriServedBy.Location = New System.Drawing.Point(299, 84)
        Me.lblPriServedBy.Name = "lblPriServedBy"
        Me.lblPriServedBy.Size = New System.Drawing.Size(136, 21)
        Me.lblPriServedBy.TabIndex = 12
        Me.lblPriServedBy.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Served From"
        '
        'lblPriDivision
        '
        Me.lblPriDivision.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriDivision.Location = New System.Drawing.Point(157, 84)
        Me.lblPriDivision.Name = "lblPriDivision"
        Me.lblPriDivision.Size = New System.Drawing.Size(136, 21)
        Me.lblPriDivision.TabIndex = 10
        Me.lblPriDivision.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Siding"
        '
        'lblPriSiding
        '
        Me.lblPriSiding.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriSiding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriSiding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriSiding.Location = New System.Drawing.Point(15, 84)
        Me.lblPriSiding.Name = "lblPriSiding"
        Me.lblPriSiding.Size = New System.Drawing.Size(136, 21)
        Me.lblPriSiding.TabIndex = 8
        Me.lblPriSiding.UseMnemonic = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(404, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Railroad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(214, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Town"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Industry"
        '
        'lblPriRR
        '
        Me.lblPriRR.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriRR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriRR.Location = New System.Drawing.Point(404, 41)
        Me.lblPriRR.Name = "lblPriRR"
        Me.lblPriRR.Size = New System.Drawing.Size(75, 21)
        Me.lblPriRR.TabIndex = 3
        Me.lblPriRR.UseMnemonic = False
        '
        'lblPriState
        '
        Me.lblPriState.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriState.Location = New System.Drawing.Point(356, 41)
        Me.lblPriState.Name = "lblPriState"
        Me.lblPriState.Size = New System.Drawing.Size(42, 21)
        Me.lblPriState.TabIndex = 2
        Me.lblPriState.UseMnemonic = False
        '
        'lblPriTown
        '
        Me.lblPriTown.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriTown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriTown.Location = New System.Drawing.Point(214, 41)
        Me.lblPriTown.Name = "lblPriTown"
        Me.lblPriTown.Size = New System.Drawing.Size(136, 21)
        Me.lblPriTown.TabIndex = 1
        Me.lblPriTown.UseMnemonic = False
        '
        'lblPriInd
        '
        Me.lblPriInd.BackColor = System.Drawing.SystemColors.Window
        Me.lblPriInd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriInd.Location = New System.Drawing.Point(15, 41)
        Me.lblPriInd.Name = "lblPriInd"
        Me.lblPriInd.Size = New System.Drawing.Size(193, 21)
        Me.lblPriInd.TabIndex = 0
        Me.lblPriInd.UseMnemonic = False
        '
        'gbSecondary
        '
        Me.gbSecondary.Controls.Add(Me.lblSecServedByCd)
        Me.gbSecondary.Controls.Add(Me.lblSecTownCd)
        Me.gbSecondary.Controls.Add(Me.cmdSelectSecondary)
        Me.gbSecondary.Controls.Add(Me.Label7)
        Me.gbSecondary.Controls.Add(Me.lblSecServedBy)
        Me.gbSecondary.Controls.Add(Me.Label17)
        Me.gbSecondary.Controls.Add(Me.lblSecDivision)
        Me.gbSecondary.Controls.Add(Me.Label21)
        Me.gbSecondary.Controls.Add(Me.lblSecSiding)
        Me.gbSecondary.Controls.Add(Me.Label16)
        Me.gbSecondary.Controls.Add(Me.Label15)
        Me.gbSecondary.Controls.Add(Me.Label14)
        Me.gbSecondary.Controls.Add(Me.Label13)
        Me.gbSecondary.Controls.Add(Me.lblSecRR)
        Me.gbSecondary.Controls.Add(Me.lblSecState)
        Me.gbSecondary.Controls.Add(Me.lblSecTown)
        Me.gbSecondary.Controls.Add(Me.lblSecInd)
        Me.gbSecondary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSecondary.Location = New System.Drawing.Point(528, 301)
        Me.gbSecondary.Name = "gbSecondary"
        Me.gbSecondary.Size = New System.Drawing.Size(495, 118)
        Me.gbSecondary.TabIndex = 1
        Me.gbSecondary.TabStop = False
        Me.gbSecondary.Text = "Secondary Industry"
        '
        'lblSecServedByCd
        '
        Me.lblSecServedByCd.AutoSize = True
        Me.lblSecServedByCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecServedByCd.Location = New System.Drawing.Point(420, 68)
        Me.lblSecServedByCd.Name = "lblSecServedByCd"
        Me.lblSecServedByCd.Size = New System.Drawing.Size(15, 15)
        Me.lblSecServedByCd.TabIndex = 21
        Me.lblSecServedByCd.Text = "X"
        Me.lblSecServedByCd.Visible = False
        '
        'lblSecTownCd
        '
        Me.lblSecTownCd.AutoSize = True
        Me.lblSecTownCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecTownCd.Location = New System.Drawing.Point(335, 26)
        Me.lblSecTownCd.Name = "lblSecTownCd"
        Me.lblSecTownCd.Size = New System.Drawing.Size(15, 15)
        Me.lblSecTownCd.TabIndex = 20
        Me.lblSecTownCd.Text = "X"
        Me.lblSecTownCd.Visible = False
        '
        'cmdSelectSecondary
        '
        Me.cmdSelectSecondary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectSecondary.Location = New System.Drawing.Point(325, 0)
        Me.cmdSelectSecondary.Name = "cmdSelectSecondary"
        Me.cmdSelectSecondary.Size = New System.Drawing.Size(154, 23)
        Me.cmdSelectSecondary.TabIndex = 15
        Me.cmdSelectSecondary.Text = "Select a Secondary"
        Me.cmdSelectSecondary.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(158, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Division"
        '
        'lblSecServedBy
        '
        Me.lblSecServedBy.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecServedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecServedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecServedBy.Location = New System.Drawing.Point(299, 83)
        Me.lblSecServedBy.Name = "lblSecServedBy"
        Me.lblSecServedBy.Size = New System.Drawing.Size(136, 21)
        Me.lblSecServedBy.TabIndex = 18
        Me.lblSecServedBy.UseMnemonic = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(299, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 15)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Served From"
        '
        'lblSecDivision
        '
        Me.lblSecDivision.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecDivision.Location = New System.Drawing.Point(157, 83)
        Me.lblSecDivision.Name = "lblSecDivision"
        Me.lblSecDivision.Size = New System.Drawing.Size(136, 21)
        Me.lblSecDivision.TabIndex = 16
        Me.lblSecDivision.UseMnemonic = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 15)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Siding"
        '
        'lblSecSiding
        '
        Me.lblSecSiding.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecSiding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecSiding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecSiding.Location = New System.Drawing.Point(15, 83)
        Me.lblSecSiding.Name = "lblSecSiding"
        Me.lblSecSiding.Size = New System.Drawing.Size(136, 21)
        Me.lblSecSiding.TabIndex = 14
        Me.lblSecSiding.UseMnemonic = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(404, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 15)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Railroad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(353, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "State"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(214, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Town"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Industry"
        '
        'lblSecRR
        '
        Me.lblSecRR.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecRR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecRR.Location = New System.Drawing.Point(404, 41)
        Me.lblSecRR.Name = "lblSecRR"
        Me.lblSecRR.Size = New System.Drawing.Size(75, 21)
        Me.lblSecRR.TabIndex = 4
        Me.lblSecRR.UseMnemonic = False
        '
        'lblSecState
        '
        Me.lblSecState.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecState.Location = New System.Drawing.Point(356, 41)
        Me.lblSecState.Name = "lblSecState"
        Me.lblSecState.Size = New System.Drawing.Size(42, 21)
        Me.lblSecState.TabIndex = 3
        Me.lblSecState.UseMnemonic = False
        '
        'lblSecTown
        '
        Me.lblSecTown.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecTown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecTown.Location = New System.Drawing.Point(214, 41)
        Me.lblSecTown.Name = "lblSecTown"
        Me.lblSecTown.Size = New System.Drawing.Size(136, 21)
        Me.lblSecTown.TabIndex = 2
        Me.lblSecTown.UseMnemonic = False
        '
        'lblSecInd
        '
        Me.lblSecInd.BackColor = System.Drawing.SystemColors.Window
        Me.lblSecInd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecInd.Location = New System.Drawing.Point(15, 41)
        Me.lblSecInd.Name = "lblSecInd"
        Me.lblSecInd.Size = New System.Drawing.Size(193, 21)
        Me.lblSecInd.TabIndex = 1
        Me.lblSecInd.UseMnemonic = False
        '
        'lblCommodity
        '
        Me.lblCommodity.BackColor = System.Drawing.SystemColors.Window
        Me.lblCommodity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommodity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommodity.Location = New System.Drawing.Point(255, 266)
        Me.lblCommodity.Name = "lblCommodity"
        Me.lblCommodity.Size = New System.Drawing.Size(193, 21)
        Me.lblCommodity.TabIndex = 2
        Me.lblCommodity.UseMnemonic = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(252, 251)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 15)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Commodity"
        '
        'lblCarType
        '
        Me.lblCarType.BackColor = System.Drawing.SystemColors.Window
        Me.lblCarType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarType.Location = New System.Drawing.Point(461, 266)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(55, 21)
        Me.lblCarType.TabIndex = 7
        Me.lblCarType.UseMnemonic = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(461, 251)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Car Type"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(607, 251)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 15)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Waybill Status"
        '
        'lblWaybillStatus
        '
        Me.lblWaybillStatus.BackColor = System.Drawing.SystemColors.Window
        Me.lblWaybillStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWaybillStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybillStatus.Location = New System.Drawing.Point(607, 266)
        Me.lblWaybillStatus.Name = "lblWaybillStatus"
        Me.lblWaybillStatus.Size = New System.Drawing.Size(136, 21)
        Me.lblWaybillStatus.TabIndex = 9
        Me.lblWaybillStatus.UseMnemonic = False
        '
        'dgvSelInd
        '
        Me.dgvSelInd.AllowUserToAddRows = False
        Me.dgvSelInd.AllowUserToDeleteRows = False
        Me.dgvSelInd.ColumnHeadersHeight = 28
        Me.dgvSelInd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatalogID, Me.IndName, Me.CatCommodity, Me.ShipRecv, Me.indCity, Me.IndState, Me.CLIC, Me.CatCommID, Me.CatCommIdx, Me.Siding, Me.CatCommSeq, Me.CarType, Me.Spots, Me.IndRR, Me.Frequency, Me.Notes, Me.PriDiv, Me.PriServBy})
        Me.dgvSelInd.Location = New System.Drawing.Point(27, 12)
        Me.dgvSelInd.MultiSelect = False
        Me.dgvSelInd.Name = "dgvSelInd"
        Me.dgvSelInd.ReadOnly = True
        Me.dgvSelInd.RowHeadersVisible = False
        Me.dgvSelInd.RowTemplate.ReadOnly = True
        Me.dgvSelInd.Size = New System.Drawing.Size(996, 225)
        Me.dgvSelInd.TabIndex = 11
        '
        'CatalogID
        '
        Me.CatalogID.DataPropertyName = "CatalogID"
        Me.CatalogID.HeaderText = "CatalogID"
        Me.CatalogID.Name = "CatalogID"
        Me.CatalogID.ReadOnly = True
        Me.CatalogID.Visible = False
        '
        'IndName
        '
        Me.IndName.DataPropertyName = "PriInd"
        Me.IndName.HeaderText = "Industry"
        Me.IndName.Name = "IndName"
        Me.IndName.ReadOnly = True
        Me.IndName.Width = 200
        '
        'CatCommodity
        '
        Me.CatCommodity.DataPropertyName = "CatComm"
        Me.CatCommodity.HeaderText = "Commodity"
        Me.CatCommodity.Name = "CatCommodity"
        Me.CatCommodity.ReadOnly = True
        Me.CatCommodity.Width = 150
        '
        'ShipRecv
        '
        Me.ShipRecv.DataPropertyName = "CatPrimarySR"
        Me.ShipRecv.HeaderText = "S/R"
        Me.ShipRecv.Name = "ShipRecv"
        Me.ShipRecv.ReadOnly = True
        Me.ShipRecv.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ShipRecv.Width = 50
        '
        'indCity
        '
        Me.indCity.DataPropertyName = "PriCity"
        Me.indCity.HeaderText = "City"
        Me.indCity.Name = "indCity"
        Me.indCity.ReadOnly = True
        Me.indCity.Width = 150
        '
        'IndState
        '
        Me.IndState.DataPropertyName = "PriState"
        Me.IndState.HeaderText = "State"
        Me.IndState.Name = "IndState"
        Me.IndState.ReadOnly = True
        Me.IndState.Width = 50
        '
        'CLIC
        '
        Me.CLIC.DataPropertyName = "PriCLIC"
        Me.CLIC.HeaderText = "CLIC"
        Me.CLIC.Name = "CLIC"
        Me.CLIC.ReadOnly = True
        Me.CLIC.Width = 80
        '
        'CatCommID
        '
        Me.CatCommID.DataPropertyName = "CatCommID"
        Me.CatCommID.HeaderText = "CatCommID"
        Me.CatCommID.Name = "CatCommID"
        Me.CatCommID.ReadOnly = True
        Me.CatCommID.Visible = False
        '
        'CatCommIdx
        '
        Me.CatCommIdx.DataPropertyName = "CatCommIdx"
        Me.CatCommIdx.HeaderText = "CatCommIdx"
        Me.CatCommIdx.Name = "CatCommIdx"
        Me.CatCommIdx.ReadOnly = True
        Me.CatCommIdx.Visible = False
        '
        'Siding
        '
        Me.Siding.DataPropertyName = "PriSiding"
        Me.Siding.HeaderText = "Siding"
        Me.Siding.Name = "Siding"
        Me.Siding.ReadOnly = True
        Me.Siding.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Siding.Width = 90
        '
        'CatCommSeq
        '
        Me.CatCommSeq.DataPropertyName = "CatCommSeq"
        Me.CatCommSeq.HeaderText = "CatCommSeq"
        Me.CatCommSeq.Name = "CatCommSeq"
        Me.CatCommSeq.ReadOnly = True
        Me.CatCommSeq.Visible = False
        '
        'CarType
        '
        Me.CarType.DataPropertyName = "CatCarType"
        Me.CarType.HeaderText = "Car Type"
        Me.CarType.Name = "CarType"
        Me.CarType.ReadOnly = True
        Me.CarType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CarType.Width = 70
        '
        'Spots
        '
        Me.Spots.DataPropertyName = "CatSpots"
        Me.Spots.HeaderText = "Spots"
        Me.Spots.Name = "Spots"
        Me.Spots.ReadOnly = True
        Me.Spots.Visible = False
        '
        'IndRR
        '
        Me.IndRR.DataPropertyName = "PriRR"
        Me.IndRR.HeaderText = "IndRR"
        Me.IndRR.Name = "IndRR"
        Me.IndRR.ReadOnly = True
        Me.IndRR.Visible = False
        '
        'Frequency
        '
        Me.Frequency.DataPropertyName = "CatFrequency"
        Me.Frequency.HeaderText = "Frequency"
        Me.Frequency.Name = "Frequency"
        Me.Frequency.ReadOnly = True
        Me.Frequency.Visible = False
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "CatNotes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 150
        '
        'PriDiv
        '
        Me.PriDiv.DataPropertyName = "PriDiv"
        Me.PriDiv.HeaderText = "PriDiv"
        Me.PriDiv.Name = "PriDiv"
        Me.PriDiv.ReadOnly = True
        Me.PriDiv.Visible = False
        '
        'PriServBy
        '
        Me.PriServBy.DataPropertyName = "PriServBy"
        Me.PriServBy.HeaderText = "PrIServBy"
        Me.PriServBy.Name = "PriServBy"
        Me.PriServBy.ReadOnly = True
        Me.PriServBy.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(529, 251)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 15)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Bill Count"
        '
        'lblBillCount
        '
        Me.lblBillCount.BackColor = System.Drawing.SystemColors.Window
        Me.lblBillCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBillCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillCount.Location = New System.Drawing.Point(529, 266)
        Me.lblBillCount.Name = "lblBillCount"
        Me.lblBillCount.Size = New System.Drawing.Size(62, 21)
        Me.lblBillCount.TabIndex = 13
        Me.lblBillCount.UseMnemonic = False
        '
        'gbRouting
        '
        Me.gbRouting.Controls.Add(Me.Label2)
        Me.gbRouting.Controls.Add(Me.txtWbNotes)
        Me.gbRouting.Controls.Add(Me.Label4)
        Me.gbRouting.Controls.Add(Me.optVerso3)
        Me.gbRouting.Controls.Add(Me.optverso2)
        Me.gbRouting.Controls.Add(Me.optVerso1)
        Me.gbRouting.Controls.Add(Me.cmdEditVia)
        Me.gbRouting.Controls.Add(Me.lblInterchangeAt)
        Me.gbRouting.Controls.Add(Me.cboStaging)
        Me.gbRouting.Controls.Add(Me.cboInterchangeWith)
        Me.gbRouting.Controls.Add(Me.Label34)
        Me.gbRouting.Controls.Add(Me.Label35)
        Me.gbRouting.Controls.Add(Me.Label36)
        Me.gbRouting.Controls.Add(Me.Label37)
        Me.gbRouting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRouting.Location = New System.Drawing.Point(27, 425)
        Me.gbRouting.Name = "gbRouting"
        Me.gbRouting.Size = New System.Drawing.Size(996, 102)
        Me.gbRouting.TabIndex = 15
        Me.gbRouting.TabStop = False
        Me.gbRouting.Text = "Routing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Notes to appear on Waybill:"
        '
        'txtWbNotes
        '
        Me.txtWbNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWbNotes.Location = New System.Drawing.Point(715, 37)
        Me.txtWbNotes.Multiline = True
        Me.txtWbNotes.Name = "txtWbNotes"
        Me.txtWbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWbNotes.Size = New System.Drawing.Size(265, 46)
        Me.txtWbNotes.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Waybill Verso:"
        '
        'optVerso3
        '
        Me.optVerso3.AutoSize = True
        Me.optVerso3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVerso3.Location = New System.Drawing.Point(352, 73)
        Me.optVerso3.Name = "optVerso3"
        Me.optVerso3.Size = New System.Drawing.Size(134, 19)
        Me.optVerso3.TabIndex = 23
        Me.optVerso3.TabStop = True
        Me.optVerso3.Text = "Freight Agent Select"
        Me.optVerso3.UseVisualStyleBackColor = True
        '
        'optverso2
        '
        Me.optverso2.AutoSize = True
        Me.optverso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optverso2.Location = New System.Drawing.Point(230, 73)
        Me.optverso2.Name = "optverso2"
        Me.optverso2.Size = New System.Drawing.Size(108, 19)
        Me.optverso2.TabIndex = 23
        Me.optverso2.TabStop = True
        Me.optverso2.Text = "Start at Industry"
        Me.optverso2.UseVisualStyleBackColor = True
        '
        'optVerso1
        '
        Me.optVerso1.AutoSize = True
        Me.optVerso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVerso1.Location = New System.Drawing.Point(104, 73)
        Me.optVerso1.Name = "optVerso1"
        Me.optVerso1.Size = New System.Drawing.Size(104, 19)
        Me.optVerso1.TabIndex = 22
        Me.optVerso1.TabStop = True
        Me.optVerso1.Text = "Staging Select"
        Me.optVerso1.UseVisualStyleBackColor = True
        '
        'cmdEditVia
        '
        Me.cmdEditVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditVia.Location = New System.Drawing.Point(398, 37)
        Me.cmdEditVia.Name = "cmdEditVia"
        Me.cmdEditVia.Size = New System.Drawing.Size(82, 23)
        Me.cmdEditVia.TabIndex = 20
        Me.cmdEditVia.Text = "Click to Edit"
        Me.cmdEditVia.UseVisualStyleBackColor = True
        '
        'lblInterchangeAt
        '
        Me.lblInterchangeAt.BackColor = System.Drawing.SystemColors.Window
        Me.lblInterchangeAt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterchangeAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterchangeAt.Location = New System.Drawing.Point(210, 37)
        Me.lblInterchangeAt.Name = "lblInterchangeAt"
        Me.lblInterchangeAt.Size = New System.Drawing.Size(177, 23)
        Me.lblInterchangeAt.TabIndex = 21
        Me.lblInterchangeAt.UseMnemonic = False
        '
        'cboStaging
        '
        Me.cboStaging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaging.FormattingEnabled = True
        Me.cboStaging.Location = New System.Drawing.Point(491, 38)
        Me.cboStaging.Name = "cboStaging"
        Me.cboStaging.Size = New System.Drawing.Size(203, 23)
        Me.cboStaging.TabIndex = 19
        '
        'cboInterchangeWith
        '
        Me.cboInterchangeWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInterchangeWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInterchangeWith.FormattingEnabled = True
        Me.cboInterchangeWith.Location = New System.Drawing.Point(15, 38)
        Me.cboInterchangeWith.Name = "cboInterchangeWith"
        Me.cboInterchangeWith.Size = New System.Drawing.Size(181, 23)
        Me.cboInterchangeWith.TabIndex = 17
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(398, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(82, 15)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Via Directions"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(495, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(132, 15)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "To / From Staging Area"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(15, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(149, 15)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Interchange With Railroad"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(210, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(85, 15)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Interchange At"
        '
        'cmdSaveWaybill
        '
        Me.cmdSaveWaybill.Location = New System.Drawing.Point(446, 543)
        Me.cmdSaveWaybill.Name = "cmdSaveWaybill"
        Me.cmdSaveWaybill.Size = New System.Drawing.Size(158, 30)
        Me.cmdSaveWaybill.TabIndex = 16
        Me.cmdSaveWaybill.Text = "Save to Catalog"
        Me.cmdSaveWaybill.UseVisualStyleBackColor = True
        '
        'cmdClearFields
        '
        Me.cmdClearFields.Location = New System.Drawing.Point(27, 543)
        Me.cmdClearFields.Name = "cmdClearFields"
        Me.cmdClearFields.Size = New System.Drawing.Size(158, 30)
        Me.cmdClearFields.TabIndex = 17
        Me.cmdClearFields.Text = "Clear Fields"
        Me.cmdClearFields.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(892, 544)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 33
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
        'frmMatchup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 597)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmdClearFields)
        Me.Controls.Add(Me.cmdSaveWaybill)
        Me.Controls.Add(Me.gbRouting)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblBillCount)
        Me.Controls.Add(Me.dgvSelInd)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblWaybillStatus)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblCommodity)
        Me.Controls.Add(Me.gbSecondary)
        Me.Controls.Add(Me.gbPrimary)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatchup"
        Me.Text = "Build Catalog - Match Local Industries With Partners"
        Me.gbPrimary.ResumeLayout(False)
        Me.gbPrimary.PerformLayout()
        Me.gbSecondary.ResumeLayout(False)
        Me.gbSecondary.PerformLayout()
        CType(Me.dgvSelInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRouting.ResumeLayout(False)
        Me.gbRouting.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbPrimary As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPriRR As System.Windows.Forms.Label
    Friend WithEvents lblPriState As System.Windows.Forms.Label
    Friend WithEvents lblPriTown As System.Windows.Forms.Label
    Friend WithEvents lblPriInd As System.Windows.Forms.Label
    Friend WithEvents gbSecondary As System.Windows.Forms.GroupBox
    Friend WithEvents lblSecRR As System.Windows.Forms.Label
    Friend WithEvents lblSecState As System.Windows.Forms.Label
    Friend WithEvents lblSecTown As System.Windows.Forms.Label
    Friend WithEvents lblSecInd As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCommodity As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblCarType As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPriServedBy As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPriDivision As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPriSiding As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSecServedBy As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblSecDivision As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblSecSiding As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblWaybillStatus As System.Windows.Forms.Label
    Friend WithEvents dgvSelInd As System.Windows.Forms.DataGridView
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblBillCount As System.Windows.Forms.Label
    Friend WithEvents cmdSelectSecondary As System.Windows.Forms.Button
    Friend WithEvents gbRouting As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveWaybill As System.Windows.Forms.Button
    Friend WithEvents cmdClearFields As System.Windows.Forms.Button
    Friend WithEvents cboStaging As System.Windows.Forms.ComboBox
    Friend WithEvents cboInterchangeWith As System.Windows.Forms.ComboBox
    Friend WithEvents lblInterchangeAt As System.Windows.Forms.Label
    Friend WithEvents cmdEditVia As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optVerso3 As System.Windows.Forms.RadioButton
    Friend WithEvents optverso2 As System.Windows.Forms.RadioButton
    Friend WithEvents optVerso1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPriServedByCd As System.Windows.Forms.Label
    Friend WithEvents lblPriTownCd As System.Windows.Forms.Label
    Friend WithEvents lblSecServedByCd As System.Windows.Forms.Label
    Friend WithEvents lblSecTownCd As System.Windows.Forms.Label
    Friend WithEvents chkLCL As System.Windows.Forms.CheckBox
    Friend WithEvents lablLCL As System.Windows.Forms.Label
    Friend WithEvents ttpMatchup As System.Windows.Forms.ToolTip
    Friend WithEvents Commodity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatalogID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommodity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipRecv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents indCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommIdx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Siding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommSeq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Spots As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Frequency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriDiv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriServBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWbNotes As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
End Class
