Imports System
Imports System.Data
Imports System.Data.OleDb


Public Class frmLocalInd

    Private dtSelectInds As DataTable
    Private dtFrequency As New DataTable
    Private dtTowns As New DataTable
    Private dtSiding As New DataTable
    Private dtInd As New DataTable
    Private dtComm As New DataTable
    Private dtCarType As New DataTable
    Private dtCatalogList As New DataTable
    Private dtCat As New DataTable
    Private dvSelectedInds As New DataView(dtCatalogList)
    Private bSkipTownLoad As Boolean = False
    Private bSkipSidingLoad As Boolean = False
    Private bSkipIndLoad As Boolean = False
    Private bSkipCommLoad As Boolean = False
    Private bAnyInd As Boolean = False
    Private iSidingID As Integer
    Private sSelectedCLIC As String
    Private msSelectedInd As Long
    Private mbResponse As DialogResult

    Private Enum TrafficLight
        TownRed
        TownYellow
        TownGreen
        SidingRed
        SidingYellow
        SidingGreen
        IndRed
        IndYellow
        IndGreen
        CommRed
        CommYellow
        CommGreen

    End Enum


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        PopulateMasterList()
        LoadTowns()

        'Refresh the selected records grid
        refreshSelectedGrid()


    End Sub


    Public Sub PopulateMasterList()

        'reload the Local Industry list to only select the LOCAL records tagged with the ACTIVE flag.
        dtCatalogList = DataAccess_Misc.spCatFillGrid
        lblRecsReturned.Text = dtCatalogList.Rows.Count & " Records Returned"

    End Sub


    Private Sub LoadTowns()

        Dim str As String = ""

        'Load all the town values into the Town Combo box
        dtTowns = DataAccess_LI.spLIFillTowns

        bSkipTownLoad = True
        With cboTown
            .DataSource = dtTowns
            .DisplayMember = "TownName"
            .ValueMember = "TownCallSign"
        End With
        bSkipTownLoad = False

        pbxTown.Image = imlLI.Images(TrafficLight.TownYellow)
        lblTownLight.Text = "Y"
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingYellow)
        lblSidingLight.Text = "Y"
        pbxInd.Image = imlLI.Images(TrafficLight.IndYellow)
        lblIndLight.Text = "Y"
        pbxComm.Image = imlLI.Images(TrafficLight.CommYellow)
        lblCommLight.Text = "Y"
        cmdCopyToCatalog.Enabled = False
        pnlDetails.Enabled = False

    End Sub


    Private Sub cboTown_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTown.SelectedValueChanged

        TownChanged()

    End Sub


    Private Sub TownChanged()

        'Skip comboBox load if performing intial data load
        If bSkipTownLoad Then Exit Sub
        If cboTown.SelectedIndex = -1 Then Exit Sub

        'Clear the combo boxes of previous values
        'And update the traffic lights
        pbxTown.Image = imlLI.Images(TrafficLight.TownGreen)
        lblTownLight.Text = "G"

        dtSiding.Clear()
        dtInd.Clear()
        dtComm.Clear()

        dtCarType.Clear()
        cmdCopyToCatalog.Enabled = False
        pnlDetails.Enabled = False

        nudCarloads.Value = Nothing
        cboFrequency.SelectedIndex = -1
        cboFrequency.Text = ""

        lblCarTypeDesc.Text = ""

        'Take the town name and bring back the sidings that are associated with it. Fill the Siding Combo Box with values.
        dtSiding = DataAccess_LI.spLIFillSidings(PrepStrForQuery(dtTowns.Rows(cboTown.SelectedIndex).Item("TownCallSign")))

        If cboSiding.SelectedIndex <> -1 Then
            bSkipSidingLoad = True
            cboSiding.SelectedIndex = -1
            bSkipSidingLoad = False
        End If
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingYellow)
        lblSidingLight.Text = "Y"

        If cboIndustry.SelectedIndex <> -1 Then
            bSkipIndLoad = True
            cboIndustry.SelectedIndex = -1
            bSkipIndLoad = False
        End If
        pbxInd.Image = imlLI.Images(TrafficLight.IndYellow)
        lblIndLight.Text = "Y"

        If cboCommodity.SelectedIndex <> -1 Then
            bSkipCommLoad = True
            cboCommodity.SelectedIndex = -1
            bSkipCommLoad = False
        End If
        pbxComm.Image = imlLI.Images(TrafficLight.CommYellow)
        lblCommLight.Text = "Y"

        'if Count is 0, post a message indicating there are no values to choose from.
        If dtSiding.Rows.Count = 0 Then
            MsgBox("There are no sidings located in " & cboTown.Text & ". Please try another town.", , "No Sidings")
            pbxSiding.Image = imlLI.Images(TrafficLight.SidingRed)
            lblSidingLight.Text = "R"
            Exit Sub
        End If

        bSkipSidingLoad = True
        With cboSiding
            .DataSource = dtSiding
            .DisplayMember = "SidingNotes"
            .ValueMember = "SidingID"
        End With

        'Reset the SelectedIndex Property of the Siding ComboBox to -1
        cboSiding.SelectedIndex = -1

        bSkipSidingLoad = False

        If dtSiding.Rows.Count = 1 Then cboSiding.SelectedIndex = 0

    End Sub


    Private Sub cboSiding_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSiding.SelectedIndexChanged

        If Not bSkipSidingLoad = True Then SidingChanged()

    End Sub


    Private Sub SidingChanged()

        'Skip comboBox load if performing intial data load
        If bSkipSidingLoad Then Exit Sub
        If cboSiding.SelectedIndex = -1 Then Exit Sub

        'Clear the combo boxes of previous values
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingGreen)
        lblSidingLight.Text = "G"

        dtInd.Clear()
        dtComm.Clear()
        dtCarType.Clear()
        cmdCopyToCatalog.Enabled = False
        pnlDetails.Enabled = False

        nudCarloads.Value = Nothing
        cboFrequency.SelectedIndex = -1
        cboFrequency.Text = ""

        lblCarTypeDesc.Text = ""

        'determine if there is room in the selected siding before displaying.
        'Commented 10/11/2011 CJB No longer needed for Catalog building, may be useful for train building when generating op sessions.
        'lblSpotsAllocated.Text = ExeScalar("SELECT SUM(Allocated) FROM Industry WHERE Siding = " & PrepStrForQuery(dtSiding.Rows(cboSiding.SelectedIndex).Item("SidingID")) & ";")

        'If lblSpotsAllocated.Text = "" Then lblSpotsAllocated.Text = "0"

        'If CType(lblSpotsAvailable.Text, Integer) > CType(lblSpotsAllocated.Text, Integer) Then

        'Take the siding name and bring back the Industries that are associated with it. Fill the Industry Combo Box with values.
        dtInd = DataAccess_LI.spLIFillInd(dtSiding.Rows(cboSiding.SelectedIndex).Item("SidingID"))

        If cboIndustry.SelectedIndex <> -1 Then
            bSkipIndLoad = True
            cboIndustry.SelectedIndex = -1
            bSkipIndLoad = False
        End If
        pbxInd.Image = imlLI.Images(TrafficLight.IndYellow)
        lblIndLight.Text = "Y"

        If cboCommodity.SelectedIndex <> -1 Then
            bSkipCommLoad = True
            cboCommodity.SelectedIndex = -1
            bSkipCommLoad = False
        End If
        pbxComm.Image = imlLI.Images(TrafficLight.CommYellow)
        lblCommLight.Text = "Y"

        'if table Count is 0, post a message indicating there are no values to choose from.
        If dtInd.Rows.Count = 0 Then
            MsgBox("There are no Industries associated with the " & cboSiding.Text & " Siding. Please try another Siding.", , "No Sidings")
            pbxInd.Image = imlLI.Images(TrafficLight.IndRed)
            lblIndLight.Text = "R"
            Exit Sub
        End If

        bSkipIndLoad = True
        With cboIndustry
            .DataSource = dtInd
            bSkipIndLoad = True
            .DisplayMember = "indName"
        End With

        'Reset the SelectedIndex Property of the Industry ComboBox to -1
        cboIndustry.SelectedIndex = -1

        bSkipIndLoad = False

        If dtInd.Rows.Count = 1 Then cboIndustry.SelectedIndex = 0

        'Else
        'MsgBox("There are no more available spots on this siding, please select another.", MsgBoxStyle.Information, "Siding is Full")
        'pbxSiding.Image = imlLI.Images(TrafficLight.SidingRed)
        'lblSidingLight.Text = "R"
        'End If

    End Sub


    Private Sub cboIndustry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIndustry.SelectedIndexChanged

        If Not bSkipIndLoad = True Then IndChanged()

    End Sub


    Private Sub IndChanged()

        'Skip comboBox load if performing intial data load
        If bSkipIndLoad Then Exit Sub
        If cboIndustry.SelectedIndex = -1 Then Exit Sub

        'Clear the combo boxes of previous values
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingGreen)
        lblSidingLight.Text = "G"
        pbxInd.Image = imlLI.Images(TrafficLight.IndGreen)
        lblIndLight.Text = "G"

        dtComm.Clear()
        dtCarType.Clear()
        bAnyInd = False
        cmdCopyToCatalog.Enabled = False
        pnlDetails.Enabled = False

        nudCarloads.Value = Nothing
        cboFrequency.SelectedIndex = -1
        cboFrequency.Text = ""

        lblCarTypeDesc.Text = ""

        'Take the siding name and bring back the Industries that are associated with it. 
        'Leave out industries already selected. 
        'Fill the Commodity Combo Box with values.
        'dtComm = FillDt("SELECT Ind.IndID, Ind.CLIC, Ind.Commodity, Lookup.LkDesc AS Shiprecv, Ind.Spots FROM Industry AS Ind LEFT JOIN Lookup ON Ind.ShipRecv = Lookup.LkCode WHERE Lookup.LkGroup = 'ShipRecv' AND Ind.IndName = '" & PrepStrForQuery(dtInd.Rows(cboIndustry.SelectedIndex).Item("IndName")) & "' AND Ind.IndCity = '" & PrepStrForQuery(cboTown.Text) & "' and Ind.Siding = " & dtSiding.Rows(cboSiding.SelectedIndex).Item("SidingID") & ";")
        dtComm = DataAccess_LI.spLIFillComm(PrepStrForQuery(dtInd.Rows(cboIndustry.SelectedIndex).Item("IndName")), PrepStrForQuery(cboTown.Text), dtSiding.Rows(cboSiding.SelectedIndex).Item("SidingID"))

        If cboCommodity.SelectedIndex <> -1 Then
            bSkipCommLoad = True
            cboCommodity.SelectedIndex = -1
            bSkipCommLoad = False
        End If
        pbxComm.Image = imlLI.Images(TrafficLight.CommYellow)
        lblCommLight.Text = "Y"

        'if Count is 0, post a message indicating there are no values to choose from.
        If dtComm.Rows.Count = 0 Then
            MsgBox("There are no commodities associated with " & cboIndustry.Text & ". Please try another industry.", , "No Commodities")
            pbxComm.Image = imlLI.Images(TrafficLight.CommRed)
            lblCommLight.Text = "R"
            Exit Sub
        End If

        '10/11/2011 CJB Commented to allow selection of 'Any' commodity value.
        ''If the Commodity value returned is an asterisk (Any), do the select again and bring back ALL commodities
        'If dtComm.Rows(0).Item("Commodity").ToString = "Any" Then
        '    'Plug the mod level CLIC value here or there won't be a value to reference later.
        '    sSelectedCLIC = dtComm.Rows(0).Item("CLIC").ToString
        '    'dtComm = FillDt("SELECT '" & sSelectedCLIC & "' AS CLIC, CommodityName AS Commodity,  'B' AS ShipRecv, 1 AS Spots FROM Commodity WHERE CommUse = 'X';")
        '    dtComm = FillDtSp("spLIFillCommAny", sSelectedCLIC)
        '    bAnyInd = True
        'End If

        bSkipCommLoad = True
        With cboCommodity
            .DataSource = dtComm
            .DisplayMember = "Commodity"
        End With

        'Reset the SelectedIndex Property of the Commodity ComboBox to -1
        cboCommodity.SelectedIndex = -1

        bSkipCommLoad = False

        If dtComm.Rows.Count = 1 Then cboCommodity.SelectedIndex = 0

    End Sub


    Private Sub cboCommodity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCommodity.SelectedIndexChanged

        If Not bSkipCommLoad = True Then CommodityChanged()

    End Sub


    Private Sub CommodityChanged()

        Dim sStr As String = ""

        If bSkipCommLoad Then Exit Sub
        If cboCommodity.SelectedIndex = -1 Then Exit Sub

        'Load the CarType ComboBox
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingGreen)
        lblSidingLight.Text = "G"
        pbxInd.Image = imlLI.Images(TrafficLight.IndGreen)
        lblIndLight.Text = "G"
        pbxComm.Image = imlLI.Images(TrafficLight.CommGreen)
        lblCommLight.Text = "G"
        dtCarType.Clear()
        cboCarType.Items.Clear()
        cboCarType.Text = ""

        If bAnyInd = True Then
            Dim dtAllCarTypes As New DataTable
            dtAllCarTypes = DataAccess_Get.spGetAARCarTypeCd
            Dim drRowz As DataRow
            For Each drRowz In dtAllCarTypes.Rows
                cboCarType.Items.Add(drRowz.Item("AARCode").ToString)
            Next

        Else
            'dtCarType = FillDt("SELECT commAARType1, commAARType2, commAARType3 FROM Commodity WHERE CommodityName = '" & PrepStrForQuery(dtComm.Rows(cboCommodity.SelectedIndex).Item("Commodity")) & "';")
            dtCarType = DataAccess_LI.spLICarType(PrepStrForQuery(dtComm.Rows(cboCommodity.SelectedIndex).Item("Commodity")))

            'If returned rows = 0, the commodity Name could not be found.
            If dtCarType.Rows.Count = 0 Then
                MsgBox("Sorry, the commodity you're looking for was not found. Please try another one.", MsgBoxStyle.Critical, "Commodity Not Found")
                Exit Sub
            End If

            'Load the car types (if any) into the combobox
            If Not dtCarType.Rows(0).Item(0).ToString = "" Then
                cboCarType.Items.Add(dtCarType.Rows(0).Item(0).ToString)
            End If

            If Not dtCarType.Rows(0).Item(1).ToString = "" Then
                cboCarType.Items.Add(dtCarType.Rows(0).Item(1).ToString)
            End If

            If Not dtCarType.Rows(0).Item(2).ToString = "" Then
                cboCarType.Items.Add(dtCarType.Rows(0).Item(2).ToString)
            End If

        End If

        'Select the first car type as a default
        cboCarType.SelectedIndex = 0

        If Not dtComm.Rows(cboCommodity.SelectedIndex).Item("ShipRecv").ToString = "" Then
            lblShipRecv.Text = dtComm.Rows(cboCommodity.SelectedIndex).Item("ShipRecv").ToString
        End If

        'Clear the Spots field and reset the value to 1
        nudCarloads.Value = 1

        'Reset the Frequency combobox and set it to the least frequent value
        cboFrequency.SelectedIndex = 1

        'identify the specific Industry record to get the right CLIC value
        msSelectedInd = DataAccess_Get.spGetIndID(PrepStrForQuery(cboIndustry.Text), PrepStrForQuery(cboCommodity.Text), PrepStrForQuery(cboTown.Text))

        cmdCopyToCatalog.Enabled = True
        pnlDetails.Enabled = True

    End Sub


    Private Sub cmdCopyToCatalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopyToCatalog.Click

        Dim sVal As String
        Dim sPriTownCallSign As String = ""
        Dim sPriDivName As String = ""
        Dim sPriServedBy As String = ""
        Dim iCatCommIndex As Integer

        'Just in case the Spots amount is 0, change to 1
        If nudCarloads.Value = 0 Then nudCarloads.Value = 1

        'Set the Frequency to once a week if nothing was selected
        If cboFrequency.SelectedIndex = -1 Then cboFrequency.SelectedValue = 0

        'Get the correct CLIC code by using the City, Industry and Commodity items.
        sSelectedCLIC = DataAccess_Get.spGetIndCLIC(PrepStrForQuery(cboIndustry.Text), PrepStrForQuery(cboCommodity.Text), PrepStrForQuery(cboTown.Text))

        Dim dtInd As New DataTable
        dtInd = DataAccess_LI.spLIIndDetail(sSelectedCLIC)

        'Update the selected CarType from the ComboBox on the window, Value does not come from Industry Table
        dtInd.Rows(0).Item("CarType") = cboCarType.Text

        'Set Comm Index
        sVal = DataAccess_Get.spGetCatCommIdx(sSelectedCLIC)
        If Not sVal = "" Then
            iCatCommIndex = CType(sVal, Integer) + 1
        Else
            iCatCommIndex = 0
        End If

        'Get the Division Name and Served By data
        If Mid(sSelectedCLIC, 3, 1) = "-" Then
            sPriTownCallSign = Mid(sSelectedCLIC, 1, 2)
        ElseIf Mid(sSelectedCLIC, 2, 1) = "-" Then
            sPriTownCallSign = Mid(sSelectedCLIC, 1, 1)
        Else
            sPriTownCallSign = Mid(sSelectedCLIC, 1, 3)
        End If

        Dim dtTemp As New DataTable
        dtTemp = DataAccess_Get.spGetTown(sPriTownCallSign)
        sPriDivName = DataAccess_Get.spGetDivName(sPriTownCallSign)
        sPriServedBy = dtTemp.Rows(0).Item("TownServedBy").ToString

        sVal = ""

        'Check to see if this row already has an allocated value
        sVal = DataAccess_Misc.spCheckPriorCLICVal(sSelectedCLIC) 'TODO: Copy over this procedure to the MISC group
        If Not sVal = "" Then
            mbResponse = MsgBox("This industry / commodity set is already in the catalog. However, " & _
                "it may call for a different car type, customer or number of loads. " & vbNewLine & vbNewLine & _
                "Adding another record " & _
                "will cause this Industry / Commodity set to be selected more often AND perhaps use " & _
                "different car types / numbers of carloads. " & vbNewLine & vbNewLine & _
                "Click Yes to add add it again or No abort the request.", MsgBoxStyle.YesNo, _
                "Add another Industry / Commodity pair of the same type?")
            If mbResponse = Windows.Forms.DialogResult.No Then
                Exit Sub

            End If

        End If

        'Get the user-selected values from the selection screen
        dtInd.Rows(0).Item("Frequency") = cboFrequency.SelectedValue
        dtInd.Rows(0).Item("Spots") = nudCarloads.Value

        'Insert the record into the Catalog table
        DataAccess_LI.spLICatUpdate(dtInd.Rows(0).Item("IndID"), _
                  iCatCommIndex, _
                  dtInd.Rows(0).Item("CarType"), _
                  dtInd.Rows(0).Item("Commodity"), _
                  dtInd.Rows(0).Item("Notes") & "", _
                  dtInd.Rows(0).Item("IndShipRecv"), _
                  dtInd.Rows(0).Item("Frequency"), _
                  dtInd.Rows(0).Item("Spots"), _
                  dtInd.Rows(0).Item("IndRR"), _
                  dtInd.Rows(0).Item("IndName"), _
                  dtInd.Rows(0).Item("IndCity"), _
                  dtInd.Rows(0).Item("IndState"), _
                  dtInd.Rows(0).Item("CLIC"), _
                  dtInd.Rows(0).Item("Siding"), _
                  sPriDivName, _
                  sPriServedBy)


        'RefreshCounts()
        'refreshSelectedGrid()
        pbxTown.Image = imlLI.Images(TrafficLight.TownGreen)
        lblTownLight.Text = "G"
        pbxSiding.Image = imlLI.Images(TrafficLight.SidingYellow)
        lblSidingLight.Text = "Y"
        pbxInd.Image = imlLI.Images(TrafficLight.IndYellow)
        lblIndLight.Text = "Y"
        pbxComm.Image = imlLI.Images(TrafficLight.CommYellow)
        lblCommLight.Text = "Y"
        cmdCopyToCatalog.Enabled = False
        pnlDetails.Enabled = False
        sSelectedCLIC = Nothing

    End Sub


    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Hide()

    End Sub

    ' 10/11/2011 CJB This procedure no longer needed
    'Private Sub RefreshCounts()

    '    lblSpotsAllocated.Text = ExeScalar("SELECT SUM(Allocated) FROM wkIndustry WHERE Siding = " & dtSiding.Rows(cboSiding.SelectedIndex).Item("SidingID") & " AND Selected <> '';")

    '    If lblSpotsAllocated.Text = "" Then lblSpotsAllocated.Text = "0"

    '    If CType(lblSpotsAvailable.Text, Integer) <= CType(lblSpotsAllocated.Text, Integer) Then
    '        MsgBox("This siding is now full. Please select another siding to continue.", MsgBoxStyle.Information, "Siding is Full")
    '    End If

    'End Sub


    Private Sub refreshSelectedGrid()

        dtCatalogList.Clear()
        PopulateMasterList()
        dgvLocalCatalog.DataSource = dtCatalogList


    End Sub


    Private Sub cmdNextStep_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Hide()

    End Sub


    Private Sub cboCarType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCarType.SelectedIndexChanged

        If cboCarType.Text = "" Then
            lblCarTypeDesc.Text = ""
        Else
            'Display ther car type description in the label next to the drop-down combo
            lblCarTypeDesc.Text = DataAccess_Get.spGetCarTypeDesc(cboCarType.Text)
        End If

    End Sub


    Private Sub frmLocalInd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dtFrequency = DataAccess_Fill.spFillLookupDT("Frequency")
        cboFrequency.DataSource = dtFrequency
        cboFrequency.DisplayMember = "LkDesc"
        cboFrequency.ValueMember = "LkCode"

    End Sub


    Private Sub dgvLocalCatalog_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvLocalCatalog.CellFormatting
        Dim drv As DataRowView
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dtCatalogList.Rows.Count - 1 Then
                drv = dtCatalogList.DefaultView.Item(e.RowIndex)
                Dim c As Color
                If Len(drv.Item("SecRR").ToString) <= 0 Then
                    c = Color.LightBlue
                Else
                    c = Color.White
                End If
                e.CellStyle.BackColor = c
            End If
        End If
    End Sub


    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


End Class