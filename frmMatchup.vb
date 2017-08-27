Public Class frmMatchup

    Private dtLocalInd As New DataTable
    Private dtInterchange As New DataTable
    Private dgrSelectedRow As New DataGridViewRow
    Private dtStaging As DataTable
    Private msShipRecv As String
    Public msSelectedPartner(8) As String
    'Array elements for msSelectedPartner:
    '0 - "CLIC"
    '1 - "IndName"
    '2 - "IndCity"
    '3 - "IndState"
    '4 - "IndRR"
    '5 - "Commodity"
    '6 - "ShipRecv"
    '7 - "Siding"
    '8 - "Notes"
    Private mbResponse As DialogResult
    Private msPrimaryCLIC As String
    Private msSecondaryCLIC As String
    Private msPrimarySR As String
    Private msRouteVia As String
    Private msInterchangeRR As String
    Private bSkipIntWithLoad As Boolean = False


    Public Sub RefreshSelIndGrid()

        'Load a new table with the incomplete data from the LocalInd step
        dtLocalInd.Clear()

        dtLocalInd = DataAccess_Misc.spMatchFillGrid
        dgvSelInd.DataSource = dtLocalInd

        'If Interchange box is not loaded then load the interchange points.
        If cboInterchangeWith.Items.Count = 0 Then
            'Load the Interchange points into the Interchange At combo box
            dtInterchange = DataAccess_Misc.spMatchIntRR

            bSkipIntWithLoad = True
            With cboInterchangeWith
                .DataSource = dtInterchange
                .DisplayMember = "RRTown"
                .ValueMember = "IntAlias"
                .SelectedIndex = -1
                .Text = ""
            End With
            bSkipIntWithLoad = False

        End If

    End Sub


    Private Sub dgvSelInd_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSelInd.CellDoubleClick

        Dim oDlgResult As DialogResult

        msShipRecv = ""

        ClearFields()

        dgrSelectedRow = dgvSelInd.Rows(e.RowIndex)

        'When a cell is clicked, get the industry data and copy it to the fields to the right.
        'Determine if Industry is a shipper or Receiver.
        msShipRecv = dgrSelectedRow.Cells("ShipRecv").Value.ToString

        If msShipRecv = "Both" Then
            'Call frmShipOrRecv to allow user to choose
            oDlgResult = frmShipOrRecv.ShowDialog

            If oDlgResult = DialogResult.No Then
                msShipRecv = "Receiver"

            Else ' Any other result default to Shipper
                msShipRecv = "Shipper"
                'TODO: Change ANY above to FAK - Freight All Kinds

            End If

        End If

        If msShipRecv <> "Shipper" And msShipRecv <> "Receiver" And msShipRecv <> "Both" Then
            MsgBox("The industry could not be identified as a shipper or receiver, so it will be treated as a shipper. You can change this while editing the waybill in a moment.", MsgBoxStyle.Information, "Industry Shipper or Receiver is Uncertain")
            msShipRecv = "Shipper"

        End If

        LoadPrimary()
        msPrimaryCLIC = dgrSelectedRow.Cells("CLIC").Value

        'Load the commodity, cartype and count data
        lblCommodity.Text = dgrSelectedRow.Cells("CatCommodity").Value
        lblCarType.Text = dgrSelectedRow.Cells("CarType").Value
        lblBillCount.Text = dgrSelectedRow.Cells("Spots").Value
        lblWaybillStatus.Text = "Editing"
        txtWbNotes.Text = DataAccess_Misc.spMatchCommNotes(dgrSelectedRow.Cells("CatCommodity").Value)

        'Call the Matchup screen to display for the selected commodity
        SelectSecondary()


    End Sub


    Private Sub LoadPrimary()

        'Load the Primary fields with values
        gbPrimary.Text = "Primary Industry - " & IIf(msShipRecv = "Shipper", "Shipper - ", "Receiver - ") & dgrSelectedRow.Cells("CLIC").Value
        lblPriInd.Text = dgrSelectedRow.Cells("indName").Value
        lblPriTownCd.Text = DataAccess_Get.spGetTownName(dgrSelectedRow.Cells("indCity").Value)
        lblPriTown.Text = dgrSelectedRow.Cells("indCity").Value
        lblPriState.Text = dgrSelectedRow.Cells("IndState").Value
        lblPriRR.Text = dgrSelectedRow.Cells("IndRR").Value
        lblPriServedByCd.Text = DataAccess_Get.spGetFrtHub(dgrSelectedRow.Cells("indCity").Value)
        lblPriServedBy.Text = DataAccess_Get.spGetTownName(lblPriServedByCd.Text)
        lblPriSiding.Text = dgrSelectedRow.Cells("siding").Value
        lblPriDivision.Text = GetDivisionName(lblPriTownCd.Text)
        If Not dgrSelectedRow.Cells("Notes").Value Is Nothing Then
            txtWbNotes.Text += dgrSelectedRow.Cells("Notes").Value & vbNewLine
        End If

        If msShipRecv = "Shipper" Then
            optVerso1.Enabled = True
            optverso2.Enabled = True
            optVerso3.Enabled = True
            optVerso1.Text = "Staging Select"
            optverso2.Text = "Start at Industry"
            optVerso3.Text = "Freight Agent Select"
            optVerso1.Checked = True
            chkLCL.Checked = False
            chkLCL.Visible = True
            lablLCL.Visible = True

        Else
            optVerso1.Enabled = True
            optverso2.Enabled = False
            optVerso3.Enabled = False
            optVerso1.Text = "MTY Return Route"
            optverso2.Text = ""
            optVerso3.Text = ""
            optVerso1.Checked = True
            chkLCL.Checked = False
            chkLCL.Visible = False
            lablLCL.Visible = False

        End If


    End Sub


    Private Sub cmdSelectSecondary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectSecondary.Click

        SelectSecondary()

    End Sub

    Private Sub SelectSecondary()

        Dim _strComm As String

        'If the LCL box is checked add 'LCL' to the beginning of the commodity name
        If chkLCL.Checked = True Then
            _strComm = "LCL" & lblCommodity.Text
        Else
            _strComm = lblCommodity.Text
        End If

        'Call the Select Partner dialog and pass the commodity

        Dim SelPartner As New frmSelectPartner
        msSelectedPartner = SelPartner.ShowDialog(_strComm, msShipRecv)

        If msSelectedPartner Is Nothing Then Exit Sub
        If msSelectedPartner(0) Is Nothing Then Exit Sub

        msSecondaryCLIC = msSelectedPartner(0).ToString
        gbSecondary.Text = "Secondary Industry - " & IIf(msShipRecv = "Shipper", "Receiver - ", "Shipper - ") & msSelectedPartner(0).ToString
        lblSecInd.Text = msSelectedPartner(1).ToString
        lblSecTown.Text = msSelectedPartner(2).ToString
        lblSecState.Text = msSelectedPartner(3).ToString
        lblSecRR.Text = msSelectedPartner(4).ToString

        If LCase(lblCommodity.Text) <> LCase(msSelectedPartner(5).ToString) Then
            mbResponse = MsgBox("The selected receiver has a different Commodity Type (" &
                msSelectedPartner(5).ToString & ") than the shipper (" &
                lblCommodity.Text & "). " & vbCrLf & vbCrLf & "Click Yes to use '" &
                lblCommodity.Text & "' or No use '" & msSelectedPartner(5).ToString & "'.",
                MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Commodity Change")
            If mbResponse = DialogResult.No Then
                lblCommodity.Text = msSelectedPartner(5).ToString
            End If
        End If

        If LCase(lblCommodity.Text) = "any" Then
            mbResponse = MsgBox("The Primary Industry has a Commodity Type of Any. " &
                "Change it to the more specific Secondary commodity (" &
                msSelectedPartner(5).ToString & ")?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Commodity Change")
            'TODO: Change ANY above to FAK - Freight All Kinds
            If mbResponse = DialogResult.Yes Then
                lblCommodity.Text = msSelectedPartner(5).ToString ' TODO: Is this working?
            End If
        End If

        'If the Receiver is an online indistry, get and copy the additional fields to the screen.
        If Not Mid(msSelectedPartner(0).ToString, 1, 3) = "O/L" Then
            If Not msSelectedPartner(7).ToString = "99" Then
                lblSecSiding.BackColor = Color.White
                lblSecDivision.BackColor = Color.White
                lblSecServedBy.BackColor = Color.White
                lblSecTownCd.Text = DataAccess_Get.spGetTownCallSign(msSelectedPartner(2).ToString)
                lblSecSiding.Text = DataAccess_Get.spGetSidingNotes(msSelectedPartner(7).ToString)
                lblSecDivision.Text = DataAccess_Get.spGetDivName(msSelectedPartner(2).ToString)
                lblSecServedByCd.Text = DataAccess_Get.spGetFrtHub(msSelectedPartner(2).ToString)
                lblSecServedBy.Text = DataAccess_Get.spGetTownName(GetFreightHub(msSelectedPartner(2).ToString))
                If msSelectedPartner(8).ToString <> "" Then
                    txtWbNotes.Text += msSelectedPartner(8).ToString & vbNewLine
                End If
            Else
                lblSecSiding.BackColor = System.Drawing.SystemColors.Window
                lblSecDivision.BackColor = System.Drawing.SystemColors.Window
                lblSecServedBy.BackColor = System.Drawing.SystemColors.Window
                lblSecSiding.Text = ""
                lblSecDivision.Text = ""
                lblSecServedBy.Text = ""

            End If

        End If

    End Sub


    Private Sub cmdClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearFields.Click

        mbResponse = MsgBox("Are you sure you want to clear all data fields and start again?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If mbResponse = DialogResult.No Then Exit Sub

        ClearFields()

    End Sub


    Private Sub cmdSaveWaybill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveWaybill.Click

        Dim sValidationErrs As String = ""
        Dim sVersoType As String
        Dim sIntOnAt As String = ""
        Dim sIntOnWith As String = ""
        Dim sIntOffAt As String = ""
        Dim sIntOffWith As String = ""
        Dim sLoadSideOne As String = ""
        Dim sMTYForHome As String = ""
        Dim sPrimarySR As String = ""
        Dim sSecDivName As String = ""
        Dim sSecTownCallSign As String = ""
        Dim sSecServedBy As String = ""

        If msShipRecv = "Shipper" Then
            sIntOffAt = PrepStrForQuery(GetTownCallSign(lblInterchangeAt.Text))
            sIntOffWith = msInterchangeRR
            sPrimarySR = "S"
        Else
            sIntOnAt = PrepStrForQuery(GetTownCallSign(lblInterchangeAt.Text))
            sIntOnWith = msInterchangeRR
            sPrimarySR = "R"
        End If


        sValidationErrs = ValidateWaybill()
        If Not sValidationErrs = "" Then
            MsgBox("Can't save waybill, there are errors -" & vbNewLine & vbNewLine & _
                sValidationErrs & vbNewLine & vbNewLine & _
                "Please correct the errors and then save the record.", MsgBoxStyle.Information, "Errors in Waybill record")
            Exit Sub

        End If

        lblWaybillStatus.Text = "Matched"

        If optVerso1.Checked = True Then
            sVersoType = optVerso1.Text
        ElseIf optverso2.Checked = True Then
            sVersoType = optverso2.Text
        Else
            sVersoType = optVerso3.Text
        End If

        'If both shipper and receiver are online, override normal settings and make it OnLine/Freight Agent Select
        If Mid(msPrimaryCLIC, 1, 3) <> "O/L" And Mid(msSecondaryCLIC, 1, 3) <> "O/L" Then
            msRouteVia = "OnLine"
            sVersoType = "Freight Agent Select"
        End If

        If sVersoType = "Start at Industry" Or sVersoType = "MTY Return Route" Then
            sLoadSideOne = "Y"
            sMTYForHome = "Y"
        Else '"Staging Select", "Freight Agent Select"
            sLoadSideOne = "N"
            sMTYForHome = "N"
        End If

        If msSelectedPartner(7).ToString <> "" Then
            Dim dtTemp As New DataTable
            sSecTownCallSign = DataAccess_Get.spGetSidingTown(msSelectedPartner(7).ToString)
            If sSecTownCallSign <> "" Then
                dtTemp = DataAccess_Get.spGetTown(sSecTownCallSign)
                sSecDivName = DataAccess_Get.spGetDivName(sSecTownCallSign)
                sSecServedBy = dtTemp.Rows(0).Item("TownServedBy").ToString
            End If
        End If

        Dim X As Short

        For X = 1 To CType(lblBillCount.Text, Integer)

            DataAccess_Misc.spMatchCatUpdate(PrepStrForQuery(lblPriDivision.Text), _
                PrepStrForQuery(lblPriServedByCd.Text), _
                PrepStrForQuery(lblSecRR.Text), _
                PrepStrForQuery(lblSecInd.Text), _
                PrepStrForQuery(lblSecTown.Text), _
                PrepStrForQuery(lblSecState.Text), _
                PrepStrForQuery(msSecondaryCLIC), _
                msSelectedPartner(7).ToString, _
                PrepStrForQuery(sSecDivName), _
                PrepStrForQuery(sSecServedBy), _
                sIntOnWith & "", _
                sIntOnAt & "", _
                sIntOffWith & "", _
                sIntOffAt & "", _
                PrepStrForQuery(msRouteVia), _
                cboStaging.SelectedValue, _
                PrepStrForQuery(sVersoType), _
                PrepStrForQuery(sLoadSideOne), _
                PrepStrForQuery(lblCommodity.Text), _
                sPrimarySR, _
                "", _
                sMTYForHome & "", _
                dgrSelectedRow.Cells("CatalogID").Value)

        Next X

        RefreshSelIndGrid()
        ClearFields()

    End Sub

    Private Function ValidateWaybill() As String

        Dim sStr As String = ""
        Dim sCommErrTxt As String = "Either the Commodity, Car Type or Bill Count fields are blank. The waybill can't be processed without these values. Try clearing and re-loading the selection from the grid."
        Dim sShipperErrTxt As String = "No Shipper data has been selected."
        Dim sShipperErrTxt2 As String = "At least one field in the Shipper data has a blank value. This may be due to a data error in the Industry table. Please check the industry and make sure the entries are complete."
        Dim sReceiverErrTxt As String = "No Receiver data has been selected."
        Dim sReceiverErrTxt2 As String = "At least one field in the Receiver data has a blank value. This may be due to a data error in the Industry table. Please check the industry and make sure the entries are complete."
        Dim sRoutingErrTxt As String = "At least one selection in the Routing information is blank. Please review and complete the selections before saving the record."
        Dim sStagingErrTxt As String = "No Staging Area has been selected."

        'Check that car and commodity data is present
        If Not Len(lblCommodity.Text) > 0 And Len(lblCarType.Text) > 0 And _
            Len(lblBillCount.Text) > 0 And IsNumeric(lblBillCount.Text) > 0 Then
            sStr += sCommErrTxt & vbNewLine

        End If

        'Check that Shipper data is complete
        If Len(lblPriInd.Text) = 0 And Len(lblPriTown.Text) = 0 And _
            Len(lblPriState.Text) = 0 And Len(lblPriRR.Text) = 0 Then
            sStr += sShipperErrTxt & vbNewLine

        ElseIf Not Len(lblPriInd.Text) > 0 And Len(lblPriTown.Text) > 0 And _
            Len(lblPriState.Text) > 0 And Len(lblPriRR.Text) > 0 Then
            sStr += sShipperErrTxt2 & vbNewLine

        ElseIf msShipRecv = "Shipper" Then
            If Not Len(lblPriSiding.Text) > 0 And Len(lblPriDivision.Text) > 0 And _
                Len(lblPriServedBy.Text) > 0 Then
                sStr += sShipperErrTxt2 & vbNewLine

            End If

        End If

        'Check that Receiver data is complete
        If Len(lblSecInd.Text) = 0 And Len(lblSecTown.Text) = 0 And _
            Len(lblSecState.Text) = 0 And Len(lblSecRR.Text) = 0 Then
            sStr += sReceiverErrTxt & vbNewLine

        ElseIf Not Len(lblSecInd.Text) > 0 And Len(lblSecTown.Text) > 0 And _
            Len(lblSecState.Text) > 0 And Len(lblSecRR.Text) > 0 Then
            sStr += sReceiverErrTxt2 & vbNewLine

        ElseIf msShipRecv = "receiver" Then
            If Not Len(lblSecSiding.Text) > 0 And Len(lblSecDivision.Text) > 0 And _
                Len(lblSecServedBy.Text) > 0 Then
                sStr += sReceiverErrTxt2 & vbNewLine

            End If

        End If

        'Check that Routing data is complete
        If Not Len(cboInterchangeWith.Text) > 0 And Len(lblInterchangeAt.Text) > 0 And _
            Len(cboStaging.Text) > 0 Then
            sStr += sRoutingErrTxt & vbNewLine
        End If

        'Check that a staging area is selected
        If Not Len(cboStaging.Text) > 0 Then
            sStr += sStagingErrTxt & vbNewLine
        End If
        Return sStr

    End Function


    Private Sub cboRouteVia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInterchangeWith.SelectedIndexChanged

        If bSkipIntWithLoad = True Then Exit Sub
        If cboInterchangeWith.Text = "" Then Exit Sub

        'When the index is changed by the user, change the Interchange At label 
        If cboInterchangeWith.SelectedIndex = -1 Then Exit Sub
        lblInterchangeAt.Text = DataAccess_Misc.spMatchIntPoint(cboInterchangeWith.SelectedValue)
        msInterchangeRR = DataAccess_Misc.spMatchIntRRInitials(cboInterchangeWith.SelectedValue)
        'Set up the Via RR routing        

        gbRouting.Text = "Routing: "

        If msShipRecv = "Shipper" Then
            'If either the Primary or Secondary RR matches the Interchange With value, just use the Pri & Sec
            If lblSecRR.Text = msInterchangeRR Or lblPriRR.Text = msInterchangeRR Then
                gbRouting.Text = EscapeAmpersands(lblPriRR.Text & " > " & lblSecRR.Text)
                msRouteVia = lblPriRR.Text & " > " & lblSecRR.Text
            Else
                gbRouting.Text = EscapeAmpersands(lblPriRR.Text & " > " & msInterchangeRR & " > " & lblSecRR.Text)
                msRouteVia = lblPriRR.Text & " > " & msInterchangeRR & " > " & lblSecRR.Text
            End If

        Else ' Receiver
            'If either the Primary or Secondary RR matches the Interchange With value, just use the Pri & Sec
            If lblSecRR.Text = msInterchangeRR Or lblPriRR.Text = msInterchangeRR Then
                gbRouting.Text = EscapeAmpersands(lblSecRR.Text & " > " & lblPriRR.Text)
                msRouteVia = lblSecRR.Text & " > " & lblPriRR.Text
            Else
                gbRouting.Text = EscapeAmpersands(lblSecRR.Text & " > " & msInterchangeRR & " > " & lblPriRR.Text)
                msRouteVia = lblSecRR.Text & " > " & msInterchangeRR & " > " & lblPriRR.Text
            End If

        End If

    End Sub

    Private Sub cmdEditVia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditVia.Click

        'Allows the user to edit the VIA data that will appear on the waybill

        Dim str As String

        str = InputBox("Type in the Via data you want to appear on the waybill and click OK.", "Waybill Via Data", msRouteVia)
        gbRouting.Text = "Routing: " & str
        msRouteVia = str

    End Sub

    Private Sub frmMatchup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Catalog - Match Local Industries With Partners - " & gsMyRRName

        dtStaging = DataAccess_Get.spGetStagingAreas
        cboStaging.DataSource = dtStaging
        cboStaging.DisplayMember = "StagingDesc"
        cboStaging.ValueMember = "StagingCode"

        'Set Tooltip parameters
        ttpMatchup.AutoPopDelay = 2000
        ttpMatchup.ReshowDelay = 500
        ttpMatchup.InitialDelay = 5000
        ttpMatchup.SetToolTip(chkLCL, "For loads bound for more than one receiver, place check here to select an LCL terminal instead of a single receiver.")
        ttpMatchup.SetToolTip(dgvSelInd, "Local Industries from the Catalog - Double-Click any line to select and complete a Waybill.")
        'ttpMatchup.SetToolTip(, )

    End Sub


    Private Sub ClearFields()

        Dim ctrl As Control

        For Each ctrl In Me.Controls
            If Mid(ctrl.Name, 1, 3) = "lbl" Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In gbPrimary.Controls
            If Mid(ctrl.Name, 1, 3) = "lbl" Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In gbSecondary.Controls
            If Mid(ctrl.Name, 1, 3) = "lbl" Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In gbRouting.Controls
            If Mid(ctrl.Name, 1, 3) = "lbl" Then
                ctrl.Text = ""
            End If
        Next

        msPrimaryCLIC = ""
        msSecondaryCLIC = ""
        msRouteVia = ""
        msInterchangeRR = ""
        gbPrimary.Text = "Primary"
        gbSecondary.Text = "Secondary"
        gbRouting.Text = "Routing"

        cboInterchangeWith.SelectedIndex = -1
        cboStaging.SelectedIndex = -1

        optVerso1.Checked = False
        optverso2.Checked = False
        optVerso3.Checked = False
        optVerso1.Text = ""
        optverso2.Text = ""
        optVerso3.Text = ""

        chkLCL.Checked = False

    End Sub


    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub dgvSelInd_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSelInd.CellFormatting

        Dim drv As DataRowView
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dtLocalInd.Rows.Count - 1 Then
                drv = dtLocalInd.DefaultView.Item(e.RowIndex)
                Dim c As Color
                If drv.Item("CatPrimarySR").ToString = "Shipper" Then
                    c = Color.Wheat
                ElseIf drv.Item("CatPrimarySR").ToString = "Receiver" Then
                    c = Color.LightYellow
                ElseIf drv.Item("CatPrimarySR").ToString = "Both" Then
                    c = Color.Lavender
                Else
                    c = Color.White

                End If
                e.CellStyle.BackColor = c
            End If
        End If

    End Sub


    Private Function EscapeAmpersands(RawString As String) As String

        Dim FormattedString As String = ""
        Dim X As Integer


        For X = 1 To Len(RawString)

            If Mid(RawString, X, 1) <> "&" Then
                FormattedString += Mid(RawString, X, 1)
            Else
                FormattedString += "&&"

            End If

        Next

        EscapeAmpersands = FormattedString

    End Function


End Class
