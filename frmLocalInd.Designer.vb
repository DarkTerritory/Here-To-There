<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalInd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalInd))
        Me.cboTown = New System.Windows.Forms.ComboBox
        Me.pnlDetails = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFrequency = New System.Windows.Forms.ComboBox
        Me.lblFrequency = New System.Windows.Forms.Label
        Me.lblCarTypeDesc = New System.Windows.Forms.Label
        Me.lblShipRecv = New System.Windows.Forms.Label
        Me.nudCarloads = New System.Windows.Forms.NumericUpDown
        Me.lblCarloads = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboCarType = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblIndLight = New System.Windows.Forms.Label
        Me.cboIndustry = New System.Windows.Forms.ComboBox
        Me.cboCommodity = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdCopyToCatalog = New System.Windows.Forms.Button
        Me.cboSiding = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.pbxTown = New System.Windows.Forms.PictureBox
        Me.pbxSiding = New System.Windows.Forms.PictureBox
        Me.pbxInd = New System.Windows.Forms.PictureBox
        Me.pbxComm = New System.Windows.Forms.PictureBox
        Me.imlLI = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdHelp = New System.Windows.Forms.Button
        Me.lblTownLight = New System.Windows.Forms.Label
        Me.lblSidingLight = New System.Windows.Forms.Label
        Me.lblCommLight = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvLocalCatalog = New System.Windows.Forms.DataGridView
        Me.CatalogID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatCommID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatCommIdx = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatCartype = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriInd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatPrimarySR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriCLIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriSiding = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriDiv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriServBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecInd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecRR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecSiding = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecDiv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecServBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteOnWith = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteIntOnAt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoutIntOffWith = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteIntOffAt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteIntVia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteIntDir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RouteVerso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintLoadSide1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintMTYForHome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblBlueIncomplete = New System.Windows.Forms.Label
        Me.lblWhiteComplete = New System.Windows.Forms.Label
        Me.lblRecsReturned = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.pnlDetails.SuspendLayout()
        CType(Me.nudCarloads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSiding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLocalCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTown
        '
        Me.cboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTown.FormattingEnabled = True
        Me.cboTown.Location = New System.Drawing.Point(104, 33)
        Me.cboTown.Name = "cboTown"
        Me.cboTown.Size = New System.Drawing.Size(195, 23)
        Me.cboTown.TabIndex = 11
        '
        'pnlDetails
        '
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Me.Label3)
        Me.pnlDetails.Controls.Add(Me.cboFrequency)
        Me.pnlDetails.Controls.Add(Me.lblFrequency)
        Me.pnlDetails.Controls.Add(Me.lblCarTypeDesc)
        Me.pnlDetails.Controls.Add(Me.lblShipRecv)
        Me.pnlDetails.Controls.Add(Me.nudCarloads)
        Me.pnlDetails.Controls.Add(Me.lblCarloads)
        Me.pnlDetails.Controls.Add(Me.Label6)
        Me.pnlDetails.Controls.Add(Me.cboCarType)
        Me.pnlDetails.Controls.Add(Me.Label10)
        Me.pnlDetails.Location = New System.Drawing.Point(345, 28)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(320, 117)
        Me.pnlDetails.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Now make additional selections here:"
        '
        'cboFrequency
        '
        Me.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Location = New System.Drawing.Point(94, 30)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(210, 23)
        Me.cboFrequency.TabIndex = 31
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequency.Location = New System.Drawing.Point(21, 34)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(67, 15)
        Me.lblFrequency.TabIndex = 30
        Me.lblFrequency.Text = "Frequency:"
        Me.lblFrequency.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCarTypeDesc
        '
        Me.lblCarTypeDesc.BackColor = System.Drawing.Color.White
        Me.lblCarTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarTypeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarTypeDesc.Location = New System.Drawing.Point(159, 87)
        Me.lblCarTypeDesc.Name = "lblCarTypeDesc"
        Me.lblCarTypeDesc.Size = New System.Drawing.Size(145, 21)
        Me.lblCarTypeDesc.TabIndex = 15
        Me.lblCarTypeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShipRecv
        '
        Me.lblShipRecv.BackColor = System.Drawing.Color.White
        Me.lblShipRecv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipRecv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipRecv.Location = New System.Drawing.Point(218, 59)
        Me.lblShipRecv.Name = "lblShipRecv"
        Me.lblShipRecv.Size = New System.Drawing.Size(86, 21)
        Me.lblShipRecv.TabIndex = 13
        Me.lblShipRecv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCarloads
        '
        Me.nudCarloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCarloads.Location = New System.Drawing.Point(94, 59)
        Me.nudCarloads.Name = "nudCarloads"
        Me.nudCarloads.Size = New System.Drawing.Size(59, 21)
        Me.nudCarloads.TabIndex = 14
        Me.nudCarloads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCarloads
        '
        Me.lblCarloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarloads.Location = New System.Drawing.Point(-1, 61)
        Me.lblCarloads.Name = "lblCarloads"
        Me.lblCarloads.Size = New System.Drawing.Size(89, 15)
        Me.lblCarloads.TabIndex = 2
        Me.lblCarloads.Text = "Carloads:"
        Me.lblCarloads.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "S / R:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboCarType
        '
        Me.cboCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarType.FormattingEnabled = True
        Me.cboCarType.Location = New System.Drawing.Point(94, 86)
        Me.cboCarType.Name = "cboCarType"
        Me.cboCarType.Size = New System.Drawing.Size(59, 23)
        Me.cboCarType.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Car Type:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIndLight
        '
        Me.lblIndLight.AutoSize = True
        Me.lblIndLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndLight.Location = New System.Drawing.Point(323, 93)
        Me.lblIndLight.Name = "lblIndLight"
        Me.lblIndLight.Size = New System.Drawing.Size(16, 13)
        Me.lblIndLight.TabIndex = 26
        Me.lblIndLight.Text = "R"
        '
        'cboIndustry
        '
        Me.cboIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndustry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndustry.FormattingEnabled = True
        Me.cboIndustry.Location = New System.Drawing.Point(104, 90)
        Me.cboIndustry.Name = "cboIndustry"
        Me.cboIndustry.Size = New System.Drawing.Size(195, 23)
        Me.cboIndustry.TabIndex = 12
        '
        'cboCommodity
        '
        Me.cboCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommodity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommodity.FormattingEnabled = True
        Me.cboCommodity.Location = New System.Drawing.Point(104, 119)
        Me.cboCommodity.Name = "cboCommodity"
        Me.cboCommodity.Size = New System.Drawing.Size(195, 23)
        Me.cboCommodity.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Commodity:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdCopyToCatalog
        '
        Me.cmdCopyToCatalog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCopyToCatalog.Location = New System.Drawing.Point(247, 169)
        Me.cmdCopyToCatalog.Name = "cmdCopyToCatalog"
        Me.cmdCopyToCatalog.Size = New System.Drawing.Size(164, 23)
        Me.cmdCopyToCatalog.TabIndex = 10
        Me.cmdCopyToCatalog.Text = "Select for Catalog"
        Me.cmdCopyToCatalog.UseVisualStyleBackColor = True
        '
        'cboSiding
        '
        Me.cboSiding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSiding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSiding.FormattingEnabled = True
        Me.cboSiding.Location = New System.Drawing.Point(104, 61)
        Me.cboSiding.Name = "cboSiding"
        Me.cboSiding.Size = New System.Drawing.Size(195, 23)
        Me.cboSiding.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Town:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Siding:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Industry:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbxTown
        '
        Me.pbxTown.Location = New System.Drawing.Point(303, 36)
        Me.pbxTown.Name = "pbxTown"
        Me.pbxTown.Size = New System.Drawing.Size(20, 20)
        Me.pbxTown.TabIndex = 18
        Me.pbxTown.TabStop = False
        '
        'pbxSiding
        '
        Me.pbxSiding.Location = New System.Drawing.Point(303, 64)
        Me.pbxSiding.Name = "pbxSiding"
        Me.pbxSiding.Size = New System.Drawing.Size(20, 20)
        Me.pbxSiding.TabIndex = 19
        Me.pbxSiding.TabStop = False
        '
        'pbxInd
        '
        Me.pbxInd.Location = New System.Drawing.Point(303, 93)
        Me.pbxInd.Name = "pbxInd"
        Me.pbxInd.Size = New System.Drawing.Size(20, 20)
        Me.pbxInd.TabIndex = 20
        Me.pbxInd.TabStop = False
        '
        'pbxComm
        '
        Me.pbxComm.Location = New System.Drawing.Point(303, 122)
        Me.pbxComm.Name = "pbxComm"
        Me.pbxComm.Size = New System.Drawing.Size(20, 20)
        Me.pbxComm.TabIndex = 21
        Me.pbxComm.TabStop = False
        '
        'imlLI
        '
        Me.imlLI.ImageStream = CType(resources.GetObject("imlLI.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlLI.TransparentColor = System.Drawing.Color.Transparent
        Me.imlLI.Images.SetKeyName(0, "TownRed.gif")
        Me.imlLI.Images.SetKeyName(1, "TownYellow.gif")
        Me.imlLI.Images.SetKeyName(2, "TownGreen.gif")
        Me.imlLI.Images.SetKeyName(3, "SidingRed.gif")
        Me.imlLI.Images.SetKeyName(4, "SidingYellow.gif")
        Me.imlLI.Images.SetKeyName(5, "SidingGreen.gif")
        Me.imlLI.Images.SetKeyName(6, "IndRed.gif")
        Me.imlLI.Images.SetKeyName(7, "IndYellow.gif")
        Me.imlLI.Images.SetKeyName(8, "IndGreen.gif")
        Me.imlLI.Images.SetKeyName(9, "CommRed.gif")
        Me.imlLI.Images.SetKeyName(10, "CommYellow.gif")
        Me.imlLI.Images.SetKeyName(11, "CommGreen.gif")
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Location = New System.Drawing.Point(580, 169)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 22
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblTownLight
        '
        Me.lblTownLight.AutoSize = True
        Me.lblTownLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownLight.Location = New System.Drawing.Point(323, 38)
        Me.lblTownLight.Name = "lblTownLight"
        Me.lblTownLight.Size = New System.Drawing.Size(16, 13)
        Me.lblTownLight.TabIndex = 24
        Me.lblTownLight.Text = "R"
        '
        'lblSidingLight
        '
        Me.lblSidingLight.AutoSize = True
        Me.lblSidingLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidingLight.Location = New System.Drawing.Point(323, 66)
        Me.lblSidingLight.Name = "lblSidingLight"
        Me.lblSidingLight.Size = New System.Drawing.Size(16, 13)
        Me.lblSidingLight.TabIndex = 25
        Me.lblSidingLight.Text = "R"
        '
        'lblCommLight
        '
        Me.lblCommLight.AutoSize = True
        Me.lblCommLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommLight.Location = New System.Drawing.Point(323, 124)
        Me.lblCommLight.Name = "lblCommLight"
        Me.lblCommLight.Size = New System.Drawing.Size(16, 13)
        Me.lblCommLight.TabIndex = 27
        Me.lblCommLight.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "This is a listing of all entries in the Catalog."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgvLocalCatalog
        '
        Me.dgvLocalCatalog.AllowUserToAddRows = False
        Me.dgvLocalCatalog.AllowUserToDeleteRows = False
        Me.dgvLocalCatalog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLocalCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalCatalog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatalogID, Me.CatCommID, Me.CatCommIdx, Me.CatCartype, Me.CatComm, Me.CatNotes, Me.PriInd, Me.CatPrimarySR, Me.PriCLIC, Me.PriCity, Me.PriState, Me.PriRR, Me.PriSiding, Me.PriDiv, Me.PriServBy, Me.SecInd, Me.Notes, Me.SecCity, Me.SecState, Me.SecRR, Me.SecSiding, Me.SecDiv, Me.SecServBy, Me.RouteOnWith, Me.RouteIntOnAt, Me.RoutIntOffWith, Me.RouteIntOffAt, Me.RouteIntVia, Me.RouteIntDir, Me.RouteVerso, Me.PrintLoadSide1, Me.PrintMTYForHome})
        Me.dgvLocalCatalog.Location = New System.Drawing.Point(15, 229)
        Me.dgvLocalCatalog.Name = "dgvLocalCatalog"
        Me.dgvLocalCatalog.ReadOnly = True
        Me.dgvLocalCatalog.RowHeadersVisible = False
        Me.dgvLocalCatalog.Size = New System.Drawing.Size(650, 198)
        Me.dgvLocalCatalog.TabIndex = 29
        '
        'CatalogID
        '
        Me.CatalogID.DataPropertyName = "CatalogID"
        Me.CatalogID.HeaderText = "CatalogID"
        Me.CatalogID.Name = "CatalogID"
        Me.CatalogID.ReadOnly = True
        Me.CatalogID.Visible = False
        Me.CatalogID.Width = 60
        '
        'CatCommID
        '
        Me.CatCommID.DataPropertyName = "CatCommID"
        Me.CatCommID.HeaderText = "CatCommID"
        Me.CatCommID.Name = "CatCommID"
        Me.CatCommID.ReadOnly = True
        Me.CatCommID.Visible = False
        Me.CatCommID.Width = 60
        '
        'CatCommIdx
        '
        Me.CatCommIdx.DataPropertyName = "CatCommIdx"
        Me.CatCommIdx.HeaderText = "CatCommIdx"
        Me.CatCommIdx.Name = "CatCommIdx"
        Me.CatCommIdx.ReadOnly = True
        Me.CatCommIdx.Visible = False
        Me.CatCommIdx.Width = 75
        '
        'CatCartype
        '
        Me.CatCartype.DataPropertyName = "CatCartype"
        Me.CatCartype.HeaderText = "Car Type"
        Me.CatCartype.Name = "CatCartype"
        Me.CatCartype.ReadOnly = True
        Me.CatCartype.Width = 75
        '
        'CatComm
        '
        Me.CatComm.DataPropertyName = "CatComm"
        Me.CatComm.HeaderText = "Commodity"
        Me.CatComm.Name = "CatComm"
        Me.CatComm.ReadOnly = True
        '
        'CatNotes
        '
        Me.CatNotes.DataPropertyName = "CatNotes"
        Me.CatNotes.HeaderText = "Notes"
        Me.CatNotes.Name = "CatNotes"
        Me.CatNotes.ReadOnly = True
        '
        'PriInd
        '
        Me.PriInd.DataPropertyName = "PriInd"
        Me.PriInd.HeaderText = "Primary Ind"
        Me.PriInd.Name = "PriInd"
        Me.PriInd.ReadOnly = True
        Me.PriInd.Width = 150
        '
        'CatPrimarySR
        '
        Me.CatPrimarySR.DataPropertyName = "CatPrimarySR"
        Me.CatPrimarySR.HeaderText = "Ship/Recv"
        Me.CatPrimarySR.Name = "CatPrimarySR"
        Me.CatPrimarySR.ReadOnly = True
        Me.CatPrimarySR.Width = 75
        '
        'PriCLIC
        '
        Me.PriCLIC.DataPropertyName = "PriCLIC"
        Me.PriCLIC.HeaderText = "CLIC"
        Me.PriCLIC.Name = "PriCLIC"
        Me.PriCLIC.ReadOnly = True
        Me.PriCLIC.Width = 75
        '
        'PriCity
        '
        Me.PriCity.DataPropertyName = "PriCity"
        Me.PriCity.HeaderText = "City"
        Me.PriCity.Name = "PriCity"
        Me.PriCity.ReadOnly = True
        '
        'PriState
        '
        Me.PriState.DataPropertyName = "PriState"
        Me.PriState.HeaderText = "State"
        Me.PriState.Name = "PriState"
        Me.PriState.ReadOnly = True
        Me.PriState.Width = 60
        '
        'PriRR
        '
        Me.PriRR.DataPropertyName = "PriRR"
        Me.PriRR.HeaderText = "Railroad"
        Me.PriRR.Name = "PriRR"
        Me.PriRR.ReadOnly = True
        '
        'PriSiding
        '
        Me.PriSiding.DataPropertyName = "PriSiding"
        Me.PriSiding.HeaderText = "Siding"
        Me.PriSiding.Name = "PriSiding"
        Me.PriSiding.ReadOnly = True
        Me.PriSiding.Visible = False
        '
        'PriDiv
        '
        Me.PriDiv.DataPropertyName = "PriDiv"
        Me.PriDiv.HeaderText = "Division"
        Me.PriDiv.Name = "PriDiv"
        Me.PriDiv.ReadOnly = True
        Me.PriDiv.Visible = False
        Me.PriDiv.Width = 75
        '
        'PriServBy
        '
        Me.PriServBy.DataPropertyName = "PriServBy"
        Me.PriServBy.HeaderText = "Served By"
        Me.PriServBy.Name = "PriServBy"
        Me.PriServBy.ReadOnly = True
        Me.PriServBy.Visible = False
        Me.PriServBy.Width = 75
        '
        'SecInd
        '
        Me.SecInd.DataPropertyName = "SecInd"
        Me.SecInd.HeaderText = "Second Ind"
        Me.SecInd.Name = "SecInd"
        Me.SecInd.ReadOnly = True
        Me.SecInd.Width = 75
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "SecCLIC"
        Me.Notes.HeaderText = "CLIC"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'SecCity
        '
        Me.SecCity.DataPropertyName = "SecCity"
        Me.SecCity.HeaderText = "City"
        Me.SecCity.Name = "SecCity"
        Me.SecCity.ReadOnly = True
        '
        'SecState
        '
        Me.SecState.DataPropertyName = "SecState"
        Me.SecState.HeaderText = "State"
        Me.SecState.Name = "SecState"
        Me.SecState.ReadOnly = True
        '
        'SecRR
        '
        Me.SecRR.DataPropertyName = "SecRR"
        Me.SecRR.HeaderText = "Railroad"
        Me.SecRR.Name = "SecRR"
        Me.SecRR.ReadOnly = True
        '
        'SecSiding
        '
        Me.SecSiding.DataPropertyName = "SecSiding"
        Me.SecSiding.HeaderText = "Siding"
        Me.SecSiding.Name = "SecSiding"
        Me.SecSiding.ReadOnly = True
        '
        'SecDiv
        '
        Me.SecDiv.DataPropertyName = "SecDiv"
        Me.SecDiv.HeaderText = "Division"
        Me.SecDiv.Name = "SecDiv"
        Me.SecDiv.ReadOnly = True
        '
        'SecServBy
        '
        Me.SecServBy.DataPropertyName = "SecServBy"
        Me.SecServBy.HeaderText = "Served By"
        Me.SecServBy.Name = "SecServBy"
        Me.SecServBy.ReadOnly = True
        '
        'RouteOnWith
        '
        Me.RouteOnWith.DataPropertyName = "RouteIntOnWith"
        Me.RouteOnWith.HeaderText = "Route On With"
        Me.RouteOnWith.Name = "RouteOnWith"
        Me.RouteOnWith.ReadOnly = True
        '
        'RouteIntOnAt
        '
        Me.RouteIntOnAt.DataPropertyName = "RouteIntOnAt"
        Me.RouteIntOnAt.HeaderText = "Route On At"
        Me.RouteIntOnAt.Name = "RouteIntOnAt"
        Me.RouteIntOnAt.ReadOnly = True
        '
        'RoutIntOffWith
        '
        Me.RoutIntOffWith.DataPropertyName = "RouteIntOffWith"
        Me.RoutIntOffWith.HeaderText = "Route Off With"
        Me.RoutIntOffWith.Name = "RoutIntOffWith"
        Me.RoutIntOffWith.ReadOnly = True
        '
        'RouteIntOffAt
        '
        Me.RouteIntOffAt.DataPropertyName = "RouteIntOffAt"
        Me.RouteIntOffAt.HeaderText = "Route Off At"
        Me.RouteIntOffAt.Name = "RouteIntOffAt"
        Me.RouteIntOffAt.ReadOnly = True
        '
        'RouteIntVia
        '
        Me.RouteIntVia.DataPropertyName = "RouteIntVia"
        Me.RouteIntVia.HeaderText = "Route Via"
        Me.RouteIntVia.Name = "RouteIntVia"
        Me.RouteIntVia.ReadOnly = True
        '
        'RouteIntDir
        '
        Me.RouteIntDir.DataPropertyName = "RouteIntDir"
        Me.RouteIntDir.HeaderText = "Direction of Travel"
        Me.RouteIntDir.Name = "RouteIntDir"
        Me.RouteIntDir.ReadOnly = True
        '
        'RouteVerso
        '
        Me.RouteVerso.DataPropertyName = "RouteVerso"
        Me.RouteVerso.HeaderText = "Verso"
        Me.RouteVerso.Name = "RouteVerso"
        Me.RouteVerso.ReadOnly = True
        '
        'PrintLoadSide1
        '
        Me.PrintLoadSide1.DataPropertyName = "PrintLoadSide1"
        Me.PrintLoadSide1.HeaderText = "Side One Load?"
        Me.PrintLoadSide1.Name = "PrintLoadSide1"
        Me.PrintLoadSide1.ReadOnly = True
        '
        'PrintMTYForHome
        '
        Me.PrintMTYForHome.DataPropertyName = "PrintMTYForHome"
        Me.PrintMTYForHome.HeaderText = "MTY For Home?"
        Me.PrintMTYForHome.Name = "PrintMTYForHome"
        Me.PrintMTYForHome.ReadOnly = True
        '
        'lblBlueIncomplete
        '
        Me.lblBlueIncomplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBlueIncomplete.AutoSize = True
        Me.lblBlueIncomplete.BackColor = System.Drawing.Color.LightBlue
        Me.lblBlueIncomplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlueIncomplete.Location = New System.Drawing.Point(272, 432)
        Me.lblBlueIncomplete.Name = "lblBlueIncomplete"
        Me.lblBlueIncomplete.Size = New System.Drawing.Size(124, 15)
        Me.lblBlueIncomplete.TabIndex = 35
        Me.lblBlueIncomplete.Text = "Blue Rows  - Incomplete"
        '
        'lblWhiteComplete
        '
        Me.lblWhiteComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblWhiteComplete.AutoSize = True
        Me.lblWhiteComplete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWhiteComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhiteComplete.Location = New System.Drawing.Point(131, 432)
        Me.lblWhiteComplete.Name = "lblWhiteComplete"
        Me.lblWhiteComplete.Size = New System.Drawing.Size(126, 15)
        Me.lblWhiteComplete.TabIndex = 34
        Me.lblWhiteComplete.Text = "White Rows - Completed"
        '
        'lblRecsReturned
        '
        Me.lblRecsReturned.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRecsReturned.AutoSize = True
        Me.lblRecsReturned.Location = New System.Drawing.Point(12, 433)
        Me.lblRecsReturned.Name = "lblRecsReturned"
        Me.lblRecsReturned.Size = New System.Drawing.Size(94, 13)
        Me.lblRecsReturned.TabIndex = 33
        Me.lblRecsReturned.Text = "Records Returned"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(519, 433)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 32
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
        'frmLocalInd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 487)
        Me.Controls.Add(Me.lblBlueIncomplete)
        Me.Controls.Add(Me.lblWhiteComplete)
        Me.Controls.Add(Me.lblRecsReturned)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvLocalCatalog)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCommLight)
        Me.Controls.Add(Me.lblIndLight)
        Me.Controls.Add(Me.lblSidingLight)
        Me.Controls.Add(Me.lblTownLight)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.pbxComm)
        Me.Controls.Add(Me.pbxInd)
        Me.Controls.Add(Me.pbxSiding)
        Me.Controls.Add(Me.pbxTown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCommodity)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboIndustry)
        Me.Controls.Add(Me.cboSiding)
        Me.Controls.Add(Me.cboTown)
        Me.Controls.Add(Me.cmdCopyToCatalog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocalInd"
        Me.Text = "Build Catalog - Select Local Industries"
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.nudCarloads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSiding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLocalCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HereToThereDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboCommodity As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblCarloads As System.Windows.Forms.Label
    Friend WithEvents cboIndustry As System.Windows.Forms.ComboBox
    Friend WithEvents cboCarType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTown As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCopyToCatalog As System.Windows.Forms.Button
    Friend WithEvents lblShipRecv As System.Windows.Forms.Label
    Friend WithEvents nudCarloads As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboSiding As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbxTown As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSiding As System.Windows.Forms.PictureBox
    Friend WithEvents pbxInd As System.Windows.Forms.PictureBox
    Friend WithEvents pbxComm As System.Windows.Forms.PictureBox
    Friend WithEvents imlLI As System.Windows.Forms.ImageList
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents lblCarTypeDesc As System.Windows.Forms.Label
    Friend WithEvents lblTownLight As System.Windows.Forms.Label
    Friend WithEvents lblSidingLight As System.Windows.Forms.Label
    Friend WithEvents lblIndLight As System.Windows.Forms.Label
    Friend WithEvents lblCommLight As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents dgvLocalCatalog As System.Windows.Forms.DataGridView
    Friend WithEvents CatalogID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommIdx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCartype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriInd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatPrimarySR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriCLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriSiding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriDiv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriServBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecInd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecSiding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecDiv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecServBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteOnWith As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteIntOnAt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoutIntOffWith As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteIntOffAt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteIntVia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteIntDir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteVerso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintLoadSide1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintMTYForHome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblBlueIncomplete As System.Windows.Forms.Label
    Friend WithEvents lblWhiteComplete As System.Windows.Forms.Label
    Friend WithEvents lblRecsReturned As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
End Class
