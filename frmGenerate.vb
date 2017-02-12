Public Class frmGenerate

    Private dtTrainLoads As DataTable
    Private dtCatForTrain As DataTable
    Private dtCatRec As DataTable
    Private dtAgent As DataTable
    Private mbresponse As DialogResult
    Private miSelectPassCount As Integer
    Private miPassCount(0) As Integer
    Private msPageMode As PageMode

    Private Enum PageMode
        AddLocal = 1
        AddThru = 2
        AddAgent = 3
        Close = 4

    End Enum


    Private Sub TrainSelectionPass()

        Dim sTrainID As String
        Dim sTrainPriority As String
        Dim sTrainLowPriority As String
        Dim sTrainDirection As String
        Dim sTrainOrigin As String
        Dim sTrainStops As String
        Dim sTrainRestrictions As String
        Dim sTrainScope As String
        Dim sBillPriority As String
        Dim sBillPrimaryTown As String
        Dim iLocalCarLimit As Integer
        Dim iFreq As Integer
        Dim iCarsAssigned As Integer
        Dim iMultiCarCount As Integer

        ''Prompt to check Catalog for pre-assigned waybills and assign now 
        'If iSelectPassCount = 0 Then
        '    mbresponse = MsgBox("Look for any pre-assigned waybills in the Catalog and assign them now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pre-Assigned Waybills")
        '    If mbresponse = System.Windows.Forms.DialogResult.Yes Then
        '        'TODO: Call pre-assigned process here
        '    End If
        'End If

        Using WC As New WaitCursor

            Do

                'Get the last three elements of iPassCount, if their combined total is less than 3 then display warning 
                If UBound(miPassCount) >= 3 Then
                    If miPassCount(UBound(miPassCount)) + miPassCount(UBound(miPassCount) - 1) + miPassCount(UBound(miPassCount) - 2) < 2 Then
                        Exit Do

                    End If

                End If

                'Add a new element
                ReDim Preserve miPassCount(UBound(miPassCount) + 1)

                'Fill the Off-Line Trains Dataset
                Dim dtOLTrains As DataTable
                Dim drTrain As DataRow
                dtOLTrains = DataAccess_Build.spBuildOLTrains

                'Start Train Loop

                For Each drTrain In dtOLTrains.Rows

                    'Reset loop variables
                    sTrainID = ""
                    sTrainPriority = ""
                    sTrainLowPriority = ""
                    sTrainDirection = ""
                    sTrainOrigin = ""
                    sTrainStops = ""
                    sTrainRestrictions = ""
                    sTrainScope = ""
                    sBillPriority = ""
                    sBillPrimaryTown = ""
                    iLocalCarLimit = 0
                    'iFreq = 0
                    sTrainID = drTrain.Item("TrID").ToString
                    sTrainOrigin = drTrain.Item("TrFromStagingArea").ToString

                    'See how many cars have already been assigned to this train
                    iCarsAssigned = CType(DataAccess_Build.spBuildGetTrCarCount(sTrainID), Integer)

                    Select Case drTrain.Item("TrType").ToString
                        Case "T", "M", "L" 'Time Freight, Mail, Milk
                            sTrainPriority = "H" ' High
                            sTrainLowPriority = "H"

                        Case "F" 'Freight 
                            sTrainPriority = "M" ' Medium
                            sTrainLowPriority = "M"

                        Case "D", "C" 'Drag Freight, Coal
                            sTrainPriority = "L" ' Low
                            sTrainLowPriority = "L"

                        Case "P" ' Passenger
                            GoTo NextTrain

                    End Select

                    If drTrain.Item("trAllowLowPriority").ToString = "Y" Then
                        Select Case sTrainPriority
                            Case "1"
                                sTrainLowPriority = "M"

                            Case "2"
                                sTrainLowPriority = "L"

                        End Select

                    End If

                    sTrainDirection = drTrain.Item("TrDirection").ToString
                    sTrainScope = drTrain.Item("TrScope").ToString

                    ' No Through cars go on Local trains
                    If sTrainScope = "Local" And msPageMode = PageMode.AddThru Then Exit For

                    'Get all the cars that could be carried by this train from the Catalog
                    dtCatForTrain = DataAccess_Build.spBuildCatForTrain(sTrainOrigin, drTrain.Item("TrType").ToString, sTrainID, msPageMode)

                    'If there are no waybills available for this train, go on to the next train.
                    If dtCatForTrain.Rows.Count = 0 Then GoTo NextTrain '2/10/2017 CJB

                    'Loop thru catalog, select cars for train 
                    If msPageMode = PageMode.AddLocal Then
                        'Limit is train length * (pct thru cars * 0.01) 
                        iLocalCarLimit = CType(drTrain.Item("TrMaxCars"), Single) * (CType(drTrain.Item("TrPctThru"), Single) * 0.01)

                    ElseIf msPageMode = PageMode.AddThru Then
                        'Limit is train length
                        iLocalCarLimit = CType(drTrain.Item("TrMaxCars"), Single)

                    End If
                    Dim drCatForTrain As DataRow
                    For Each drCatForTrain In dtCatForTrain.Rows

                        If Not drCatForTrain.Item("CatalogID").ToString = "" Then

                            If iLocalCarLimit <= iCarsAssigned Then Exit For ' Train already has max allotted local cars

                            iFreq += 1

                            'get the Individual catalog record based on the record ID
                            dtCatRec = DataAccess_Build.spBuildSingleCatRecord(drCatForTrain.Item("CatalogID").ToString)

                            'If the RouteVerso is Freight Agent Select or Start At Industry, then skip
                            If dtCatRec.Rows(0).Item("RouteVerso").ToString = "Freight Agent Select" Or _
                                dtCatRec.Rows(0).Item("RouteVerso").ToString = "Start at Industry" Then
                                DataAccess_Build.spBuildTagRecSelect(drCatForTrain.Item("CatalogID").ToString, "S") ' S = Skip
                                GoTo NextCatRec

                            End If

                            'See if the waybill's Comm Priority is OK for this train
                            sBillPriority = DataAccess_Build.spBuildGetCommPriority(dtCatRec.Rows(0).Item("CatComm").ToString)
                            If sBillPriority = sTrainPriority Or sBillPriority = sTrainLowPriority Then
                                DataAccess_Build.spBuildTagRecSelect(drCatForTrain.Item("CatalogID").ToString, "N") ' N = Not Qualified
                                GoTo NextCatRec

                            End If

                            'Compare the Current Frequency value against the records' Frequency rate; if <=, assign
                            If iFreq > dtCatRec.Rows(0).Item("CatFrequency").ToString Then
                                DataAccess_Build.spBuildTagRecSelect(drCatForTrain.Item("CatalogID").ToString, "S") ' S = Skip
                                GoTo NextCatRec

                            End If

                            'If train is a local then Primary Town must be in the list of stops
                            If msPageMode = PageMode.AddLocal Then
                                If sTrainScope = "Local" Then
                                    sBillPrimaryTown = DataAccess_Build.spBuildGetTownName(dtCatRec.Rows(0).Item("PriCity").ToString)
                                    sTrainStops = DataAccess_Build.spBuildGetTrStops(sTrainID, sBillPrimaryTown)

                                    If sTrainStops = "" Then  'Does Not Appear in list
                                        DataAccess_Build.spBuildTagRecSelect(drCatForTrain.Item("CatalogID").ToString, "S") ' S = Skip
                                        GoTo NextCatRec

                                    End If

                                End If

                            End If

                            'Passed all tests, assign waybill to train

                            'Repeat for as many spots as there are to fill, as long as the train doesn't get overfilled
                            For iMultiCarCount = 1 To dtCatRec.Rows(0).Item("catspots")
                                DataAccess_Build.spBuildTagRecSelect(drCatForTrain.Item("CatalogID").ToString, "Y") ' Y = Selected
                                iCarsAssigned += 1
                                miPassCount(UBound(miPassCount)) += 1

                                'Copy record from Catalog to Waybill table, update Train Assignment on new record
                                DataAccess_Build.spBuildCopyCatRecToWB(drCatForTrain.Item("CatalogID").ToString, sTrainID, iCarsAssigned)

                                If iLocalCarLimit <= iCarsAssigned Then Exit For ' Train already has max allotted local cars



                            Next 'iMultiCarCount

                            If iLocalCarLimit <= iCarsAssigned Then Exit For ' Train already has max allotted local cars

NextCatRec:

                            If iFreq = 5 Then iFreq = 0

                        End If ' Catalog ID <> 0

                    Next 'Catalog For Train

NextTrain:

                    'Clear the Skipped and Not Eligible flags from the Catalog Table before continuing
                    DataAccess_Build.spBuildClearSelectionsFromCat("S")
                    DataAccess_Build.spBuildClearSelectionsFromCat("N")

                Next 'Off-Line Train

            Loop

        End Using

    End Sub



    Private Sub cmdGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGo.Click

        Select Case msPageMode
            Case PageMode.AddLocal, PageMode.AddThru

                TrainSelectionPass()

                'Refresh the Train / Car count grid
                RefreshGrid()

                'After first selection pass change the Go Label text
                lblGo.Text = "To Run an Additional pass through the Catalog, click GO again"

            Case PageMode.AddAgent

                AddSelectedAgentWBs()

                dgvAgentAssign.Visible = False

                cmdNext.PerformClick()

        End Select

    End Sub


    Private Sub frmGenerate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Start off in Add Local Cars Mode

        msPageMode = PageMode.AddLocal
        lblInstructionTitle.Text = "Step One - Assign Local Traffic Waybills to Trains"
        lblInstructions.Text = "Clicking the GO button below will start a process that attempts " & _
            "to match up Waybills in the Catalog with trains that can bring them onto the layout.  " & _
            "Waybills are randomly checked for their frequency values, and some valid waybills " & _
            "may be skipped during selection.  If the trains are not filled to your satisfaction " & _
            "you may run additional passes by clicking GO again which will start the process over, " & _
            "checking the still unassigned waybills in the catalog.  When you are satisfied with " & _
            "the local assignments, click the Next button."
        lblGo.Text = ""
        lblNext.Text = "The next process assigns through cars to each train"

        Dim drTrainLoads As DataRow
        RefreshGrid()

        'See if there are any assigned waybills in the waybill table.  If there are, increment the pass count by one
        'and change the Go button Prompt text.
        For Each drTrainLoads In dtTrainLoads.Rows
            If Not drTrainLoads.Item("WaybillCount") Is DBNull.Value Then
                If drTrainLoads.Item("WaybillCount") > 0 Then
                    miSelectPassCount += 1
                    lblGo.Text = "To Run an Additional pass through the Catalog, click GO again"
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub RefreshGrid()

        Select Case msPageMode
            Case PageMode.AddLocal
                dtTrainLoads = DataAccess_Build.spBuildTrainWBCount("Local") ' TODO: Check that value sent is numeric and either 1 or 2

                With dgvTrainLoadCount
                    .Columns("trCarLimit").HeaderText = "Local Car Limit"
                    .DataSource = dtTrainLoads
                    .Top = 140
                    .Left = 104
                    .Width = 613
                    .Height = 199
                    .Visible = True
                End With

            Case PageMode.AddThru
                dtTrainLoads = DataAccess_Build.spBuildTrainWBCount("Thru") ' Should be "2"

                With dgvTrainLoadCount
                    .Columns("trCarLimit").HeaderText = "Max Car Limit"
                    .DataSource = dtTrainLoads
                    .Top = 140
                    .Left = 104
                    .Width = 613
                    .Height = 199
                    .Visible = True
                End With

            Case PageMode.AddAgent

                'TODO: Is this needed?

        End Select

    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click

        Select Case msPageMode

            Case PageMode.AddLocal
                'Change to Add Through Cars phase
                msPageMode = PageMode.AddThru

                'Reset the pass counter
                ReDim miPassCount(0)

                'Update the Instructions and prompts
                lblInstructionTitle.Text = "Step Two - Assign Through Traffic Waybills to Trains"
                lblInstructions.Text = "Clicking the GO button below will start a process that attempts " & _
                    "to match up Through Waybills in the Catalog with trains that can bring them onto the layout.  " & _
                    "Waybills are randomly checked for their frequency values, and some valid waybills " & _
                    "may be skipped during selection.  If the trains are not filled to your satisfaction " & _
                    "you may run additional passes by clicking GO again which will start the process over, " & _
                    "checking the still unassigned waybills in the catalog.  When you are satisfied with " & _
                    "the through assignments, click the Next button."
                lblGo.Text = ""
                lblNext.Text = "The next process creates Agent Select and Start at Industry Waybills"
                RefreshGrid()

            Case PageMode.AddThru
                'Change to Add Agent Select Cars phase
                msPageMode = PageMode.AddAgent

                'Reset the pass counter
                ReDim miPassCount(0)

                'Update the Instructions and prompts
                lblInstructionTitle.Text = "Step Three - Agent Select and Start at Industry Waybills"
                lblInstructions.Text = "Clicking the GO button below will start a process that attempts " & _
                    "to add Agent Select and Start at Industry Waybills from the Catalog that will be printed " & _
                    "along with the waybills already selected. Each click of the GO button will " & _
                    "run pass through the catalog for these waybillsadding them until you click next or " & _
                    "there are no more to add.When you are satisfied with the Agent and Industry assignments, " & _
                    "click the Next button."
                lblGo.Text = "Click to add these Waybills"
                lblNext.Text = "Click here when finished."
                ShowAgentBills()

            Case PageMode.AddAgent
                'Change to Close window phase
                msPageMode = PageMode.Close

                lblInstructionTitle.Text = ""
                lblInstructions.Text = "Congratulations! You have completed the automatic waybill generation process. " & _
                vbNewLine & vbNewLine & "From here you may use the Session Fine-Tuning window to review what bills have " & _
                "been selected for each train, change the car blocking order or remove and add specific waybills to " & _
                "trains. Select the Print Waybills option from the Process menu to print your session waybills."
                cmdNext.Text = "Close"
                dgvTrainLoadCount.Visible = False
                dgvAgentAssign.Visible = False
                lblGo.Text = ""
                cmdGo.Text = ""
                cmdGo.Enabled = False

            Case PageMode.Close
                Me.Close()

        End Select

    End Sub


    Private Sub ShowAgentBills()

        'Switch DataGridViews
        dgvTrainLoadCount.Visible = False
        dgvAgentAssign.Visible = True

        dtAgent = DataAccess_Build.spBuildAgentWBs
        dgvAgentAssign.DataSource = dtAgent


    End Sub


    Private Sub AddSelectedAgentWBs()

        Dim dgrAgent As DataGridViewRow
        Dim iMultiCarCount As Integer

        For Each dgrAgent In dgvAgentAssign.Rows

            If dgrAgent.Cells("ColChecked").Value = True Then
                'Repeat for as many spots as there are to fill, as long as the train doesn't get overfilled
                For iMultiCarCount = 1 To dgrAgent.Cells("CatSpots").Value

                    DataAccess_Build.spBuildTagRecSelect(dgrAgent.Cells("CatalogID").Value, "Y") ' Y = Selected
                    'Copy record from Catalog to Waybill table
                    DataAccess_Build.spBuildCopyCatRecToWB(dgrAgent.Cells("CatalogID").Value, "999", dgrAgent.Cells("catSpots").Value)

                Next

            End If

        Next


    End Sub


End Class
