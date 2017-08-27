<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWBCatalog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId:="dgrSelRow")>
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId:="dgrCatalog")>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWBCatalog))
        Me.dgvCatalog = New System.Windows.Forms.DataGridView()
        Me.CatalogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriCLIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriInd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatComm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCommIdx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatPrimarySR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatCartype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriSiding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriDiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriServBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecInd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecSiding = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecDiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecServBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteOnWith = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteIntOnAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoutIntOffWith = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteIntOffAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteIntVia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteIntDir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteVerso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintLoadSide1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintMTYForHome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCatHelp = New System.Windows.Forms.Button()
        Me.cmdCatDelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRecsReturned = New System.Windows.Forms.Label()
        Me.lblWhiteComplete = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCatalog
        '
        Me.dgvCatalog.AllowUserToAddRows = False
        Me.dgvCatalog.AllowUserToDeleteRows = False
        Me.dgvCatalog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatalogID, Me.CatCommID, Me.PriCLIC, Me.PriInd, Me.CatComm, Me.CatNotes, Me.CatCommIdx, Me.CatPrimarySR, Me.CatCartype, Me.PriCity, Me.PriState, Me.PriRR, Me.PriSiding, Me.PriDiv, Me.PriServBy, Me.Notes, Me.SecInd, Me.SecCity, Me.SecState, Me.SecRR, Me.SecSiding, Me.SecDiv, Me.SecServBy, Me.RouteOnWith, Me.RouteIntOnAt, Me.RoutIntOffWith, Me.RouteIntOffAt, Me.RouteIntVia, Me.RouteIntDir, Me.RouteVerso, Me.PrintLoadSide1, Me.PrintMTYForHome})
        Me.dgvCatalog.Location = New System.Drawing.Point(12, 69)
        Me.dgvCatalog.Name = "dgvCatalog"
        Me.dgvCatalog.ReadOnly = True
        Me.dgvCatalog.RowHeadersVisible = False
        Me.dgvCatalog.Size = New System.Drawing.Size(787, 423)
        Me.dgvCatalog.TabIndex = 5
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
        'PriCLIC
        '
        Me.PriCLIC.DataPropertyName = "PriCLIC"
        Me.PriCLIC.HeaderText = "CLIC"
        Me.PriCLIC.Name = "PriCLIC"
        Me.PriCLIC.ReadOnly = True
        Me.PriCLIC.Width = 75
        '
        'PriInd
        '
        Me.PriInd.DataPropertyName = "PriInd"
        Me.PriInd.HeaderText = "Primary Ind"
        Me.PriInd.Name = "PriInd"
        Me.PriInd.ReadOnly = True
        Me.PriInd.Width = 150
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
        'CatCommIdx
        '
        Me.CatCommIdx.DataPropertyName = "CatCommIdx"
        Me.CatCommIdx.HeaderText = "CatCommIdx"
        Me.CatCommIdx.Name = "CatCommIdx"
        Me.CatCommIdx.ReadOnly = True
        Me.CatCommIdx.Visible = False
        Me.CatCommIdx.Width = 75
        '
        'CatPrimarySR
        '
        Me.CatPrimarySR.DataPropertyName = "CatPrimarySR"
        Me.CatPrimarySR.HeaderText = "Ship/Recv"
        Me.CatPrimarySR.Name = "CatPrimarySR"
        Me.CatPrimarySR.ReadOnly = True
        Me.CatPrimarySR.Width = 75
        '
        'CatCartype
        '
        Me.CatCartype.DataPropertyName = "CatCartype"
        Me.CatCartype.HeaderText = "Car Type"
        Me.CatCartype.Name = "CatCartype"
        Me.CatCartype.ReadOnly = True
        Me.CatCartype.Width = 75
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
        Me.PriRR.HeaderText = "Primary RR"
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
        'Notes
        '
        Me.Notes.DataPropertyName = "SecCLIC"
        Me.Notes.HeaderText = "Sec. CLIC"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Visible = False
        '
        'SecInd
        '
        Me.SecInd.DataPropertyName = "SecInd"
        Me.SecInd.HeaderText = "Sec. Ind"
        Me.SecInd.Name = "SecInd"
        Me.SecInd.ReadOnly = True
        Me.SecInd.Width = 75
        '
        'SecCity
        '
        Me.SecCity.DataPropertyName = "SecCity"
        Me.SecCity.HeaderText = "Sec. City"
        Me.SecCity.Name = "SecCity"
        Me.SecCity.ReadOnly = True
        '
        'SecState
        '
        Me.SecState.DataPropertyName = "SecState"
        Me.SecState.HeaderText = "Sec. State"
        Me.SecState.Name = "SecState"
        Me.SecState.ReadOnly = True
        '
        'SecRR
        '
        Me.SecRR.DataPropertyName = "SecRR"
        Me.SecRR.HeaderText = "Secondary RR"
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
        'cmdCatHelp
        '
        Me.cmdCatHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCatHelp.Enabled = False
        Me.cmdCatHelp.Location = New System.Drawing.Point(577, 26)
        Me.cmdCatHelp.Name = "cmdCatHelp"
        Me.cmdCatHelp.Size = New System.Drawing.Size(67, 23)
        Me.cmdCatHelp.TabIndex = 26
        Me.cmdCatHelp.Text = "Help"
        '
        'cmdCatDelete
        '
        Me.cmdCatDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCatDelete.Location = New System.Drawing.Point(682, 26)
        Me.cmdCatDelete.Name = "cmdCatDelete"
        Me.cmdCatDelete.Size = New System.Drawing.Size(67, 23)
        Me.cmdCatDelete.TabIndex = 25
        Me.cmdCatDelete.Text = "Delete"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(653, 525)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 27
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Catalog entries cannot be edited.  To create new waybills, use the Local Industry" &
    " and Matchup tools."
        '
        'lblRecsReturned
        '
        Me.lblRecsReturned.AutoSize = True
        Me.lblRecsReturned.Location = New System.Drawing.Point(12, 495)
        Me.lblRecsReturned.Name = "lblRecsReturned"
        Me.lblRecsReturned.Size = New System.Drawing.Size(94, 13)
        Me.lblRecsReturned.TabIndex = 29
        Me.lblRecsReturned.Text = "Records Returned"
        '
        'lblWhiteComplete
        '
        Me.lblWhiteComplete.AutoSize = True
        Me.lblWhiteComplete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWhiteComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhiteComplete.Location = New System.Drawing.Point(137, 495)
        Me.lblWhiteComplete.Name = "lblWhiteComplete"
        Me.lblWhiteComplete.Size = New System.Drawing.Size(126, 15)
        Me.lblWhiteComplete.TabIndex = 30
        Me.lblWhiteComplete.Text = "White Rows - Completed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(281, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Blue Rows  - Incomplete"
        '
        'frmWBCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 566)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWhiteComplete)
        Me.Controls.Add(Me.lblRecsReturned)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmdCatHelp)
        Me.Controls.Add(Me.cmdCatDelete)
        Me.Controls.Add(Me.dgvCatalog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWBCatalog"
        Me.Text = "Create - Waybill Catalog"
        CType(Me.dgvCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCatalog As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCatHelp As System.Windows.Forms.Button
    Friend WithEvents cmdCatDelete As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CatalogID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriCLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriInd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCommIdx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatPrimarySR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatCartype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriSiding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriDiv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriServBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecInd As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents lblRecsReturned As System.Windows.Forms.Label
    Friend WithEvents lblWhiteComplete As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
