Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmBuildThruWBs

    Private dtOrigin As New DataTable
    Private dtOriginInd As New DataTable
    Private dtDest As New DataTable
    Private dtDestInd As New DataTable
    Private dtStagingOn As New DataTable
    Private dtStagingOff As New DataTable
    Private dtComm As New DataTable
    Private dtCarType As New DataTable
    Private dtInterchangeOnRR As New DataTable
    Private dtInterchangeOffRR As New DataTable
    Private mbLoading As Boolean = False
    Private mbResponse As MsgBoxResult

    Private msCommID As String = ""
    Private msCommIdx As String = ""
    Private msCommSeq As String = "0"
    Private msCarType As String = ""
    Private msComm As String = ""
    Private msNotes As String = ""
    Private msPrimarySR As String = ""
    Private msFrequency As String = "5"
    Private msSpots As String = "1"
    Private msPriRR As String = ""
    Private msPriInd As String = ""
    Private msPriCity As String = ""
    Private msPriState As String = ""
    Private msSecRR As String = ""
    Private msSecInd As String = ""
    Private msSecCity As String = ""
    Private msSecState As String = ""
    Private msIntOnAt As String = ""
    Private msIntOnWith As String = ""
    Private msIntOffAt As String = ""
    Private msIntOffWith As String = ""
    Private msRouteIntVia As String = ""
    Private msLoadSideOne As String = ""
    Private msVersoType As String = ""
    Private msPrintMTYForHome As String = ""

    Private msListMode As String = ""
    Private msOriginIndID As String = ""
    Private msDestIndID As String = ""

    Private miRegionOriginCode As Integer
    Private miRegionDestCode As Integer



    Private Sub frmBuildThruWBs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim x As Integer

        mbLoading = True

        dtStagingOn = DataAccess_Get.spGetInterchangeTownNames

        cboStagingOn.DataSource = dtStagingOn
        cboStagingOn.DisplayMember = "TownName"
        cboStagingOn.ValueMember = "IntTown"

        dtStagingOff = DataAccess_Get.spGetInterchangeTownNames

        cboStagingOff.DataSource = dtStagingOff
        cboStagingOff.DisplayMember = "TownName"
        cboStagingOff.ValueMember = "IntTown"

        dtOrigin = DataAccess_Get.spGetAarRegions

        dtDest = DataAccess_Get.spGetAarRegions

        dtComm = DataAccess_Get.spGetComms

        For x = 1 To 10
            cboBillCount.Items.Add(x)
        Next

        cboBillCount.Text = "1"

        dtCarType = DataAccess_Get.spGetAARCarTypeCd

        cboCarType.DataSource = dtCarType
        cboCarType.DisplayMember = "AARCode"

        cboCarType.Text = "XM"


        mbLoading = False

    End Sub


    Private Sub cmdGetOriginRegions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetOriginRegions.Click

        msListMode = "OriginRegion"
        If optMTY.Checked = True Then
            dtOrigin = DataAccess_Get.spGetAarRegions
            lstSearchResults.DataSource = dtOrigin
            lstSearchResults.DisplayMember = "AARRegName"
            lstSearchResults.ValueMember = "AARCode"

        Else
            dtOrigin = DataAccess_Get.spGetAarRegionsWComms(lblComm.Text)
            lstSearchResults.DataSource = dtOrigin
            lstSearchResults.DisplayMember = "AARRegName"
            lstSearchResults.ValueMember = "AARCode"

        End If

    End Sub


    Private Sub cmdGetDestRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDestRegion.Click

        msListMode = "DestRegion"
        If optMTY.Checked = True Then
            dtDest = DataAccess_Get.spGetAarRegions
            lstSearchResults.DataSource = dtDest
            lstSearchResults.DisplayMember = "AARRegName"
            lstSearchResults.ValueMember = "AARCode"

        Else
            dtDest = DataAccess_Get.spGetAarRegionsWComms(lblComm.Text)
            lstSearchResults.DataSource = dtDest
            lstSearchResults.DisplayMember = "AARRegName"
            lstSearchResults.ValueMember = "AARCode"

        End If

    End Sub


    Private Sub cmdGetComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetComm.Click

        If Not optLoad.Checked And Not optMTY.Checked Then
            mbResponse = MsgBox("Load or MTY button must be selected above to continue.", MsgBoxStyle.Information)
            Exit Sub
        End If
        msListMode = "Comm"
        lstSearchResults.DataSource = dtComm
        lstSearchResults.DisplayMember = "CommodityName"

    End Sub


    Private Sub optLoad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLoad.CheckedChanged

        'Enable the Reciprocal checkbox
        chkBuildRecipWB.Enabled = True
        cmdGetComm.Enabled = True

    End Sub

    Private Sub optMTY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMTY.CheckedChanged

        'Disable the Reciprocal checkbox and uncheck if checked
        chkBuildRecipWB.Enabled = False
        If chkBuildRecipWB.Checked = True Then chkBuildRecipWB.Checked = False
        lblComm.Text = "MTY"
        cmdGetComm.Enabled = False
        lblRoutingRecip.Visible = False
        txtRoutingRecip.Visible = False


    End Sub

    Private Sub cmdGetOriginInd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetOriginInd.Click

        'Origin Region and Commodity must be selected before the listbox can be populated.
        If lblComm.Text = "" Or lblOriginRegion.Text = "" Then
            mbResponse = MsgBox("Commodity and Originating Region muct be selected before an Industry can be chosen.", MsgBoxStyle.Information)
            Exit Sub
        End If

        msListMode = "OriginIndustry"
        If optMTY.Checked = True Then
            'select all industry names that match the Origin region. Region must be numeric!
            dtOriginInd = DataAccess_Misc.spThruIndsNoComm(miRegionOriginCode)
            lstSearchResults.DataSource = dtOriginInd
            lstSearchResults.DisplayMember = "IndName"
            lstSearchResults.ValueMember = "IndID"

        Else
            'select all industry names that match the commodity and Origin region. Region must be numeric!
            dtOriginInd = DataAccess_Misc.spThruInds(lblComm.Text, miRegionOriginCode)
            lstSearchResults.DataSource = dtOriginInd
            lstSearchResults.DisplayMember = "IndName"
            lstSearchResults.ValueMember = "IndID"
        End If

    End Sub


    Private Sub cmdGetDestInd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGetDestInd.Click

        'Destination Region and Commodity must be selected before the listbox can be populated.
        If lblComm.Text = "" Or lblDestRegion.Text = "" Then
            mbResponse = MsgBox("Commodity and Destination Region muct be selected before an Industry can be chosen.", MsgBoxStyle.Information)
            Exit Sub
        End If

        msListMode = "DestIndustry"
        If optMTY.Checked = True Then
            'Provide a list of railroad names from the region. Region must be numeric!
            dtDestInd = DataAccess_Get.spGetRRsInAarReg(miRegionDestCode)
            lstSearchResults.DataSource = dtDestInd
            lstSearchResults.DisplayMember = "Railroad"
            lstSearchResults.ValueMember = "ReportMark"

        Else
            'select all industry names that match the commodity and Destination region. Region must be numeric!
            dtDestInd = DataAccess_Misc.spThruInds(lblComm.Text, miRegionDestCode)
            lstSearchResults.DataSource = dtDestInd
            lstSearchResults.DisplayMember = "IndName"
            lstSearchResults.ValueMember = "IndID"
        End If

    End Sub


    Private Sub lstSearchResults_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSearchResults.DoubleClick

        Select Case msListMode

            Case "Comm"
                lblComm.Text = lstSearchResults.Text
                cboCarType.Text = DataAccess_Get.spGetCarTypeFromComm(lblComm.Text)

            Case "OriginRegion"
                lblOriginRegion.Text = lstSearchResults.Text
                miRegionOriginCode = CType(lstSearchResults.SelectedValue, Integer)
                'Launch the Get Origin Industry click automatically
                cmdGetOriginInd.PerformClick()

            Case "DestRegion"
                lblDestRegion.Text = lstSearchResults.Text
                miRegionDestCode = CType(lstSearchResults.SelectedValue, Integer)
                'Launch the Get Dest Industry click automatically
                cmdGetDestInd.PerformClick()

            Case "OriginIndustry"
                lblOriginInd.Text = lstSearchResults.Text
                msOriginIndID = lstSearchResults.SelectedValue.ToString

            Case "DestIndustry"
                lblDestInd.Text = lstSearchResults.Text
                msDestIndID = lstSearchResults.SelectedValue.ToString
        End Select

        lstSearchResults.DataSource = Nothing
        lstSearchResults.Items.Clear()

    End Sub


    Private Sub cboStagingOn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStagingOn.SelectedIndexChanged

        If mbLoading Then Exit Sub

        'Load the list of railroads at the selected staging point
        Dim dtStagingOnRR As New DataTable
        dtStagingOnRR = DataAccess_Get.spGetIntRRs(cboStagingOn.SelectedValue.ToString)
        cboOnRR.DataSource = dtStagingOnRR
        cboOnRR.DisplayMember = "Railroad"
        cboOnRR.ValueMember = "IntForeignRR"

    End Sub


    Private Sub cboStagingOff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStagingOff.SelectedIndexChanged

        If mbLoading Then Exit Sub

        'Load the list of railroads at the selected staging point
        Dim dtStagingOffRR As New DataTable
        dtStagingOffRR = DataAccess_Get.spGetIntRRs(cboStagingOff.SelectedValue.ToString)
        cboOffRR.DataSource = dtStagingOffRR
        cboOffRR.DisplayMember = "Railroad"
        cboOffRR.ValueMember = "IntForeignRR"

    End Sub



    Private Sub cmdClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearFields.Click

        mbResponse = MsgBox("Are you sure you want to clear all data fields and start again?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If mbResponse = Windows.Forms.DialogResult.No Then Exit Sub

        mbLoading = True
        ClearFields()
        optLoad.Checked = True
        mbLoading = False


    End Sub


    Private Sub ClearFields()

        lblOriginRegion.Text = ""
        lblDestRegion.Text = ""
        lblOriginInd.Text = ""
        lblDestInd.Text = ""
        lblComm.Text = ""
        cboCarType.SelectedIndex = -1
        cboBillCount.Text = "1"
        'optLoad.Checked = False
        'optMTY.Checked = False
        cboStagingOn.SelectedIndex = -1
        cboOnRR.DataSource = Nothing
        cboOnRR.Items.Clear()
        cboStagingOff.SelectedIndex = -1
        cboOffRR.DataSource = Nothing
        cboOffRR.Items.Clear()
        txtRouting.Text = ""
        txtRoutingRecip.Text = ""
        If optLoad.Checked = True And chkBuildRecipWB.Checked = True Then
            lblRoutingRecip.Visible = True
            txtRoutingRecip.Visible = True
        Else
            lblRoutingRecip.Visible = False
            txtRoutingRecip.Visible = False
        End If
        lstSearchResults.DataSource = Nothing
        lstSearchResults.Items.Clear()

        msCommID = ""
        msCommIdx = ""
        msCommSeq = "0"
        msCarType = ""
        msComm = ""
        msNotes = ""
        msPrimarySR = ""
        msFrequency = "5"
        msSpots = "1"
        msPriRR = ""
        msPriInd = ""
        msPriCity = ""
        msPriState = ""
        msSecRR = ""
        msSecInd = ""
        msSecCity = ""
        msSecState = ""
        msIntOnAt = ""
        msIntOnWith = ""
        msIntOffAt = ""
        msIntOffWith = ""
        msRouteIntVia = ""
        msLoadSideOne = ""
        msVersoType = ""
        msPrintMTYForHome = ""

    End Sub


    Private Function ValidateWaybill() As String

        Dim sStr As String = ""
        Dim sOriginRegionErrTxt As String = "The Origin region has not been selected."
        Dim sDestRegionErrTxt As String = "The Destination region has not been selected."
        Dim sCarErrTxt As String = "Either the Car Type or Bill Count fields are blank. The waybill can't be processed without these values. Please re-select."
        Dim sLoadMTYErrTxt As String = "Either the Load or MTY button must be selected."
        Dim sMTYCommErrTxt As String = "If the MTY button is selected the Commodity must be MTY."
        Dim sShipperErrTxt As String = "No Originating Industry data has been selected."
        Dim sReceiverErrTxt As String = "No Destination Industry has been selected."

        'Check the Origin and Destination fields for values
        If Not Len(lblOriginRegion.Text) > 0 Then
            sStr += sOriginRegionErrTxt & vbNewLine
        End If

        If Not Len(lblDestRegion.Text) > 0 Then
            sStr += sDestRegionErrTxt & vbNewLine
        End If

        'Check that car and commodity data is present
        If Not Len(cboCarType.Text) > 0 And _
            Len(cboBillCount.Text) > 0 And IsNumeric(cboBillCount.Text) > 0 Then
            sStr += sCarErrTxt & vbNewLine
        End If

        'Check the Load / MTY buttons, one must be checked
        If optLoad.Checked = False And optMTY.Checked = False Then
            sStr += sLoadMTYErrTxt & vbNewLine
        End If

        'Check that Commodity should be MTY when MTY option button is checked
        If lblComm.Text <> "MTY" And optMTY.Checked = True Then
            sStr += sMTYCommErrTxt & vbNewLine
        End If

        'Check the the Originating Industry has been selected
        If msOriginIndID = "" Then
            sStr += sShipperErrTxt & vbNewLine
        End If

        'Check the the Originating Industry has been selected
        If msDestIndID = "" Then
            sStr += sReceiverErrTxt & vbNewLine
        End If

        'The following expressions are to set the selected indicies of the four Staging combo boxes
        'If the user did not click them to select (was happy with the displayed value)
        If cboStagingOn.Text <> "" And cboStagingOn.SelectedIndex = -1 Then
            cboStagingOn.Text = cboStagingOn.Text
        End If

        If cboStagingOff.Text <> "" And cboStagingOff.SelectedIndex = -1 Then
            cboStagingOff.Text = cboStagingOff.Text
        End If

        If cboOnRR.Text <> "" And cboOnRR.SelectedIndex = -1 Then
            cboOnRR.Text = cboOnRR.Text
        End If

        If cboOffRR.Text <> "" And cboOffRR.SelectedIndex = -1 Then
            cboOffRR.Text = cboOffRR.Text
        End If

        Return sStr

    End Function


    Private Sub BuildWBRecord()

        Dim dtIndDetail As New DataTable

        Dim sValidationErrs As String = ""
        Dim sValidateSrc As String = ""

        If msListMode = "SaveWB" Then sValidateSrc = "Can't save waybill, there are errors -"
        If msListMode = "BuildWBRec" Then sValidateSrc = "Can't show Routing yet, please select values for all of the items listed below first - "

        sValidationErrs = ValidateWaybill()
        If Not sValidationErrs = "" Then
            MsgBox(sValidateSrc & vbNewLine & vbNewLine & _
                sValidationErrs & vbNewLine & vbNewLine & _
                "Please correct the errors and then save the record.", MsgBoxStyle.Information, "Errors in Waybill data")
            Exit Sub

        End If

        'Commodity Data
        msComm = lblComm.Text

        dtIndDetail = DataAccess_Get.spGetSingleInd(msOriginIndID)
        msCommID = dtIndDetail.Rows(0).Item("IndID").ToString
        msCommIdx = "0"
        msCommSeq = "0"
        msCarType = cboCarType.Text
        msNotes = ""
        msFrequency = "5" ' To be available as often as possible
        msSpots = cboBillCount.Text

        'Primary Industry
        msPriRR = dtIndDetail.Rows(0).Item("IndRR").ToString
        msPriInd = dtIndDetail.Rows(0).Item("IndName").ToString
        msPriCity = dtIndDetail.Rows(0).Item("IndCity").ToString
        msPriState = dtIndDetail.Rows(0).Item("IndState").ToString

        'Seconary Industry
        dtIndDetail = DataAccess_Get.spGetSingleInd(msDestIndID)
        If optMTY.Checked = True Then
            msSecRR = msDestIndID
            msSecInd = lblDestInd.Text
            msSecCity = ""
            msSecState = ""

        Else
            msSecRR = dtIndDetail.Rows(0).Item("IndRR").ToString
            msSecInd = dtIndDetail.Rows(0).Item("IndName").ToString
            msSecCity = dtIndDetail.Rows(0).Item("IndCity").ToString
            msSecState = dtIndDetail.Rows(0).Item("IndState").ToString
        End If

        'Interchanges
        msIntOffAt = cboStagingOff.SelectedValue.ToString
        msIntOffWith = cboOffRR.SelectedValue.ToString
        msIntOnAt = cboStagingOn.SelectedValue.ToString
        msIntOnWith = cboOnRR.SelectedValue.ToString

        msVersoType = "Through"


        If optLoad.Checked = True Then
            msLoadSideOne = "Y"
            msPrintMTYForHome = "N"
        Else
            msLoadSideOne = "N"
            msPrintMTYForHome = "Y"
        End If

        If optMTY.Checked = True Then
            msPrimarySR = "R"
        Else
            msPrimarySR = "S"
        End If

        'Set up Routing text if not already created

        If txtRouting.Text = "" Then

            If msPriRR = cboOnRR.SelectedValue.ToString Then
                txtRouting.Text = msPriRR & ">" & gsMyRRInitials & ">"

            Else
                txtRouting.Text = msPriRR & ">" & cboOnRR.SelectedValue.ToString & ">" & gsMyRRInitials & ">"

            End If

            If msSecRR = cboOffRR.SelectedValue.ToString Then
                txtRouting.Text += msSecRR

            Else
                txtRouting.Text += cboOffRR.SelectedValue.ToString & ">" & msSecRR

            End If

            If optLoad.Checked = True And chkBuildRecipWB.Checked = True Then
                txtRoutingRecip.Text = msSecRR & ">" & gsMyRRInitials & ">" & msPriRR

            End If

        End If

        msRouteIntVia = txtRouting.Text ' It routing text is edited by user, this will pick it up


    End Sub



    Private Sub cmdSaveWaybill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveWaybill.Click

        Dim dtIndDetail As New DataTable

        msListMode = "SaveWB"

        BuildWBRecord()

        SaveWaybill()

        If optLoad.Checked = True And chkBuildRecipWB.Checked = True Then
            'Build an Empty waybill with the same data Reversed for a return trip

            msComm = "MTY"
            msCommID = msDestIndID
            msCommIdx = "0"
            msCommSeq = "0"
            msCarType = cboCarType.Text
            msNotes = ""
            msFrequency = "5" ' To be available as often as possible
            msSpots = cboBillCount.Text

            'Primary Industry
            dtIndDetail = DataAccess_Get.spGetSingleInd(msDestIndID)
            msPriRR = dtIndDetail.Rows(0).Item("IndRR").ToString
            msPriInd = dtIndDetail.Rows(0).Item("IndName").ToString
            msPriCity = dtIndDetail.Rows(0).Item("IndCity").ToString
            msPriState = dtIndDetail.Rows(0).Item("IndState").ToString

            'Seconary Industry

            dtIndDetail = DataAccess_Get.spGetSingleInd(msOriginIndID)
            msSecRR = dtIndDetail.Rows(0).Item("IndRR").ToString
            msSecInd = ""
            msSecCity = ""
            msSecState = ""


            'Interchanges
            msIntOffAt = cboStagingOn.SelectedValue.ToString
            msIntOffWith = cboOnRR.SelectedValue.ToString
            msIntOnAt = cboStagingOff.SelectedValue.ToString
            msIntOnWith = cboOffRR.SelectedValue.ToString

            msVersoType = "Through"

            msLoadSideOne = "N"
            msPrimarySR = "R"

            'Set up Routing

            'msRouteIntVia = msSecRR & ">" & gsMyRRInitials & ">" & msPriRR
            msRouteIntVia = txtRoutingRecip.Text

            SaveWaybill()

        End If

        mbLoading = True

        ClearFields()

        mbLoading = False

    End Sub


    Private Sub SaveWaybill()

        DataAccess_Misc.spThruCatIns( _
        msCommID, _
        msCommIdx, _
        msCommSeq, _
        msCarType, _
        msComm, _
        msNotes, _
        msPrimarySR, _
        msFrequency, _
        msSpots, _
        msPriRR, _
        msPriInd, _
        msPriCity, _
        msPriState, _
        msSecRR, _
        msSecInd, _
        msSecCity, _
        msSecState, _
        msIntOnAt & "", _
        msIntOnWith & "", _
        msIntOffAt & "", _
        msIntOffWith & "", _
        msLoadSideOne, _
        msVersoType, _
        msRouteIntVia, _
        msPrintMTYForHome)

    End Sub

    Private Sub cmdShowRouting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowRouting.Click

        msListMode = "BuildWBRec"
        BuildWBRecord()

    End Sub


    Private Sub chkBuildRecipWB_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBuildRecipWB.CheckedChanged

        If chkBuildRecipWB.Checked = True Then
            lblRoutingRecip.Visible = True
            txtRoutingRecip.Visible = True

        Else
            lblRoutingRecip.Visible = False
            txtRoutingRecip.Visible = False

        End If

    End Sub
End Class