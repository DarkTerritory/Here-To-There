<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildThruWBs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildThruWBs))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGetOriginRegions = New System.Windows.Forms.Button()
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.cmdGetComm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optLoad = New System.Windows.Forms.RadioButton()
        Me.optMTY = New System.Windows.Forms.RadioButton()
        Me.chkBuildRecipWB = New System.Windows.Forms.CheckBox()
        Me.cmdGetOriginInd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCarType = New System.Windows.Forms.ComboBox()
        Me.cmdGetDestRegion = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdGetDestInd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdShowMap1 = New System.Windows.Forms.Button()
        Me.cmdShowMap2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBillCount = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboStagingOn = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboStagingOff = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboOffRR = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboOnRR = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdClearFields = New System.Windows.Forms.Button()
        Me.cmdSaveWaybill = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.lblOriginRegion = New System.Windows.Forms.Label()
        Me.lblOriginInd = New System.Windows.Forms.Label()
        Me.lblDestRegion = New System.Windows.Forms.Label()
        Me.lblDestInd = New System.Windows.Forms.Label()
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.lblRoutingRecip = New System.Windows.Forms.Label()
        Me.txtRouting = New System.Windows.Forms.TextBox()
        Me.txtRoutingRecip = New System.Windows.Forms.TextBox()
        Me.cmdShowRouting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Origin Region"
        '
        'cmdGetOriginRegions
        '
        Me.cmdGetOriginRegions.Location = New System.Drawing.Point(165, 111)
        Me.cmdGetOriginRegions.Name = "cmdGetOriginRegions"
        Me.cmdGetOriginRegions.Size = New System.Drawing.Size(24, 23)
        Me.cmdGetOriginRegions.TabIndex = 6
        Me.cmdGetOriginRegions.Text = ">"
        Me.cmdGetOriginRegions.UseVisualStyleBackColor = True
        '
        'lstSearchResults
        '
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.Location = New System.Drawing.Point(345, 50)
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(235, 316)
        Me.lstSearchResults.TabIndex = 23
        '
        'cmdGetComm
        '
        Me.cmdGetComm.Location = New System.Drawing.Point(165, 73)
        Me.cmdGetComm.Name = "cmdGetComm"
        Me.cmdGetComm.Size = New System.Drawing.Size(24, 23)
        Me.cmdGetComm.TabIndex = 4
        Me.cmdGetComm.Text = ">"
        Me.cmdGetComm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Commodity"
        '
        'optLoad
        '
        Me.optLoad.AutoSize = True
        Me.optLoad.Location = New System.Drawing.Point(15, 31)
        Me.optLoad.Name = "optLoad"
        Me.optLoad.Size = New System.Drawing.Size(49, 17)
        Me.optLoad.TabIndex = 0
        Me.optLoad.TabStop = True
        Me.optLoad.Text = "Load"
        Me.optLoad.UseVisualStyleBackColor = True
        '
        'optMTY
        '
        Me.optMTY.AutoSize = True
        Me.optMTY.Location = New System.Drawing.Point(74, 31)
        Me.optMTY.Name = "optMTY"
        Me.optMTY.Size = New System.Drawing.Size(48, 17)
        Me.optMTY.TabIndex = 1
        Me.optMTY.TabStop = True
        Me.optMTY.Text = "MTY"
        Me.optMTY.UseVisualStyleBackColor = True
        '
        'chkBuildRecipWB
        '
        Me.chkBuildRecipWB.AutoSize = True
        Me.chkBuildRecipWB.Location = New System.Drawing.Point(134, 32)
        Me.chkBuildRecipWB.Name = "chkBuildRecipWB"
        Me.chkBuildRecipWB.Size = New System.Drawing.Size(180, 17)
        Me.chkBuildRecipWB.TabIndex = 2
        Me.chkBuildRecipWB.Text = "Create Reciprocal MTY Waybill?"
        Me.chkBuildRecipWB.UseVisualStyleBackColor = True
        '
        'cmdGetOriginInd
        '
        Me.cmdGetOriginInd.Location = New System.Drawing.Point(165, 153)
        Me.cmdGetOriginInd.Name = "cmdGetOriginInd"
        Me.cmdGetOriginInd.Size = New System.Drawing.Size(24, 23)
        Me.cmdGetOriginInd.TabIndex = 9
        Me.cmdGetOriginInd.Text = ">"
        Me.cmdGetOriginInd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Origin Industry"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Car Type"
        '
        'cboCarType
        '
        Me.cboCarType.FormattingEnabled = True
        Me.cboCarType.Location = New System.Drawing.Point(219, 73)
        Me.cboCarType.Name = "cboCarType"
        Me.cboCarType.Size = New System.Drawing.Size(88, 21)
        Me.cboCarType.TabIndex = 15
        '
        'cmdGetDestRegion
        '
        Me.cmdGetDestRegion.Location = New System.Drawing.Point(165, 204)
        Me.cmdGetDestRegion.Name = "cmdGetDestRegion"
        Me.cmdGetDestRegion.Size = New System.Drawing.Size(24, 23)
        Me.cmdGetDestRegion.TabIndex = 11
        Me.cmdGetDestRegion.Text = ">"
        Me.cmdGetDestRegion.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Destination Region"
        '
        'cmdGetDestInd
        '
        Me.cmdGetDestInd.Location = New System.Drawing.Point(165, 244)
        Me.cmdGetDestInd.Name = "cmdGetDestInd"
        Me.cmdGetDestInd.Size = New System.Drawing.Size(24, 23)
        Me.cmdGetDestInd.TabIndex = 14
        Me.cmdGetDestInd.Text = ">"
        Me.cmdGetDestInd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Destination Industry"
        '
        'cmdShowMap1
        '
        Me.cmdShowMap1.Location = New System.Drawing.Point(219, 111)
        Me.cmdShowMap1.Name = "cmdShowMap1"
        Me.cmdShowMap1.Size = New System.Drawing.Size(88, 23)
        Me.cmdShowMap1.TabIndex = 7
        Me.cmdShowMap1.Text = "Show Map"
        Me.cmdShowMap1.UseVisualStyleBackColor = True
        '
        'cmdShowMap2
        '
        Me.cmdShowMap2.Location = New System.Drawing.Point(219, 204)
        Me.cmdShowMap2.Name = "cmdShowMap2"
        Me.cmdShowMap2.Size = New System.Drawing.Size(88, 23)
        Me.cmdShowMap2.TabIndex = 12
        Me.cmdShowMap2.Text = "Show Map"
        Me.cmdShowMap2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Or"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(195, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Or"
        '
        'cboBillCount
        '
        Me.cboBillCount.FormattingEnabled = True
        Me.cboBillCount.Location = New System.Drawing.Point(219, 153)
        Me.cboBillCount.Name = "cboBillCount"
        Me.cboBillCount.Size = New System.Drawing.Size(88, 21)
        Me.cboBillCount.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Bill Count"
        '
        'cboStagingOn
        '
        Me.cboStagingOn.FormattingEnabled = True
        Me.cboStagingOn.Location = New System.Drawing.Point(12, 302)
        Me.cboStagingOn.Name = "cboStagingOn"
        Me.cboStagingOn.Size = New System.Drawing.Size(147, 21)
        Me.cboStagingOn.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Staging Point On RR"
        '
        'cboStagingOff
        '
        Me.cboStagingOff.FormattingEnabled = True
        Me.cboStagingOff.Location = New System.Drawing.Point(15, 343)
        Me.cboStagingOff.Name = "cboStagingOff"
        Me.cboStagingOff.Size = New System.Drawing.Size(144, 21)
        Me.cboStagingOff.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Staging Point Off RR"
        '
        'cboOffRR
        '
        Me.cboOffRR.FormattingEnabled = True
        Me.cboOffRR.Location = New System.Drawing.Point(177, 343)
        Me.cboOffRR.Name = "cboOffRR"
        Me.cboOffRR.Size = New System.Drawing.Size(144, 21)
        Me.cboOffRR.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(174, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Interchange RR"
        '
        'cboOnRR
        '
        Me.cboOnRR.FormattingEnabled = True
        Me.cboOnRR.Location = New System.Drawing.Point(174, 302)
        Me.cboOnRR.Name = "cboOnRR"
        Me.cboOnRR.Size = New System.Drawing.Size(147, 21)
        Me.cboOnRR.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(171, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Interchange RR"
        '
        'cmdClearFields
        '
        Me.cmdClearFields.Location = New System.Drawing.Point(245, 419)
        Me.cmdClearFields.Name = "cmdClearFields"
        Me.cmdClearFields.Size = New System.Drawing.Size(110, 23)
        Me.cmdClearFields.TabIndex = 21
        Me.cmdClearFields.Text = "Clear Fields"
        Me.cmdClearFields.UseVisualStyleBackColor = True
        '
        'cmdSaveWaybill
        '
        Me.cmdSaveWaybill.Location = New System.Drawing.Point(471, 419)
        Me.cmdSaveWaybill.Name = "cmdSaveWaybill"
        Me.cmdSaveWaybill.Size = New System.Drawing.Size(110, 23)
        Me.cmdSaveWaybill.TabIndex = 22
        Me.cmdSaveWaybill.Text = "Save to Catalog"
        Me.cmdSaveWaybill.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(342, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Double-Click to Select an item,"
        '
        'lblComm
        '
        Me.lblComm.BackColor = System.Drawing.SystemColors.Window
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblComm.Location = New System.Drawing.Point(12, 73)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(147, 21)
        Me.lblComm.TabIndex = 39
        '
        'lblOriginRegion
        '
        Me.lblOriginRegion.BackColor = System.Drawing.SystemColors.Window
        Me.lblOriginRegion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOriginRegion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblOriginRegion.Location = New System.Drawing.Point(12, 111)
        Me.lblOriginRegion.Name = "lblOriginRegion"
        Me.lblOriginRegion.Size = New System.Drawing.Size(147, 21)
        Me.lblOriginRegion.TabIndex = 40
        '
        'lblOriginInd
        '
        Me.lblOriginInd.BackColor = System.Drawing.SystemColors.Window
        Me.lblOriginInd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOriginInd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblOriginInd.Location = New System.Drawing.Point(12, 153)
        Me.lblOriginInd.Name = "lblOriginInd"
        Me.lblOriginInd.Size = New System.Drawing.Size(147, 34)
        Me.lblOriginInd.TabIndex = 41
        '
        'lblDestRegion
        '
        Me.lblDestRegion.BackColor = System.Drawing.SystemColors.Window
        Me.lblDestRegion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDestRegion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDestRegion.Location = New System.Drawing.Point(12, 204)
        Me.lblDestRegion.Name = "lblDestRegion"
        Me.lblDestRegion.Size = New System.Drawing.Size(147, 21)
        Me.lblDestRegion.TabIndex = 42
        '
        'lblDestInd
        '
        Me.lblDestInd.BackColor = System.Drawing.SystemColors.Window
        Me.lblDestInd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDestInd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDestInd.Location = New System.Drawing.Point(12, 244)
        Me.lblDestInd.Name = "lblDestInd"
        Me.lblDestInd.Size = New System.Drawing.Size(147, 34)
        Me.lblDestInd.TabIndex = 43
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Location = New System.Drawing.Point(12, 372)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(116, 13)
        Me.lblRouting.TabIndex = 45
        Me.lblRouting.Text = "Routing Data (editable)"
        '
        'lblRoutingRecip
        '
        Me.lblRoutingRecip.Location = New System.Drawing.Point(174, 372)
        Me.lblRoutingRecip.Name = "lblRoutingRecip"
        Me.lblRoutingRecip.Size = New System.Drawing.Size(165, 13)
        Me.lblRoutingRecip.TabIndex = 47
        Me.lblRoutingRecip.Text = "Routing Data (Return, editable)"
        '
        'txtRouting
        '
        Me.txtRouting.Location = New System.Drawing.Point(15, 387)
        Me.txtRouting.Name = "txtRouting"
        Me.txtRouting.Size = New System.Drawing.Size(144, 20)
        Me.txtRouting.TabIndex = 48
        '
        'txtRoutingRecip
        '
        Me.txtRoutingRecip.Location = New System.Drawing.Point(177, 387)
        Me.txtRoutingRecip.Name = "txtRoutingRecip"
        Me.txtRoutingRecip.Size = New System.Drawing.Size(144, 20)
        Me.txtRoutingRecip.TabIndex = 49
        '
        'cmdShowRouting
        '
        Me.cmdShowRouting.Location = New System.Drawing.Point(15, 419)
        Me.cmdShowRouting.Name = "cmdShowRouting"
        Me.cmdShowRouting.Size = New System.Drawing.Size(110, 23)
        Me.cmdShowRouting.TabIndex = 50
        Me.cmdShowRouting.Text = "Show Routing"
        Me.cmdShowRouting.UseVisualStyleBackColor = True
        '
        'frmBuildThruWBs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(601, 454)
        Me.Controls.Add(Me.cmdShowRouting)
        Me.Controls.Add(Me.txtRoutingRecip)
        Me.Controls.Add(Me.txtRouting)
        Me.Controls.Add(Me.lblRoutingRecip)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.lblDestInd)
        Me.Controls.Add(Me.lblDestRegion)
        Me.Controls.Add(Me.lblOriginInd)
        Me.Controls.Add(Me.lblOriginRegion)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdClearFields)
        Me.Controls.Add(Me.cmdSaveWaybill)
        Me.Controls.Add(Me.cboOffRR)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboOnRR)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboStagingOff)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboStagingOn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboBillCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdShowMap2)
        Me.Controls.Add(Me.cmdShowMap1)
        Me.Controls.Add(Me.cmdGetDestInd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdGetDestRegion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCarType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdGetOriginInd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkBuildRecipWB)
        Me.Controls.Add(Me.optMTY)
        Me.Controls.Add(Me.optLoad)
        Me.Controls.Add(Me.cmdGetComm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSearchResults)
        Me.Controls.Add(Me.cmdGetOriginRegions)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuildThruWBs"
        Me.Text = "Catalog - Build Through Waybills"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGetOriginRegions As System.Windows.Forms.Button
    Friend WithEvents lstSearchResults As System.Windows.Forms.ListBox
    Friend WithEvents cmdGetComm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optLoad As System.Windows.Forms.RadioButton
    Friend WithEvents optMTY As System.Windows.Forms.RadioButton
    Friend WithEvents chkBuildRecipWB As System.Windows.Forms.CheckBox
    Friend WithEvents cmdGetOriginInd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCarType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGetDestRegion As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdGetDestInd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdShowMap1 As System.Windows.Forms.Button
    Friend WithEvents cmdShowMap2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboBillCount As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboStagingOn As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboStagingOff As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboOffRR As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboOnRR As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdClearFields As System.Windows.Forms.Button
    Friend WithEvents cmdSaveWaybill As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblComm As System.Windows.Forms.Label
    Friend WithEvents lblOriginRegion As System.Windows.Forms.Label
    Friend WithEvents lblOriginInd As System.Windows.Forms.Label
    Friend WithEvents lblDestRegion As System.Windows.Forms.Label
    Friend WithEvents lblDestInd As System.Windows.Forms.Label
    Friend WithEvents lblRouting As System.Windows.Forms.Label
    Friend WithEvents lblRoutingRecip As System.Windows.Forms.Label
    Friend WithEvents txtRouting As System.Windows.Forms.TextBox
    Friend WithEvents txtRoutingRecip As System.Windows.Forms.TextBox
    Friend WithEvents cmdShowRouting As System.Windows.Forms.Button
End Class
