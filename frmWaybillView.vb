Imports CrystalDecisions.Shared
Imports System.Data.SQLite

Public Class frmWaybillView

    Private dtWBPrint As DataTable
    Private dtWBSort As DataTable
    Private dtWBLoads As DataTable
    Private dtWBList As DataTable
    Private dtWBPage As DataTable
    Private dtWBMTYs As DataTable
    Private wbLoad As stWBLoad
    Private wbMTY As stWBMTY
    'Private bFormatted As Boolean = False
    Private m_crvPaneShowing As String
    Private mbResponse As MsgBoxResult


    Private Structure stWBLoad
        Dim PriRR As String
        Dim PriAAR As String
        Dim PriInd As String
        Dim PriCity As String
        Dim PriState As String
        Dim Comm As String
        Dim SecInd As String
        Dim SecCity As String
        Dim SecState As String
        Dim Cartype As String
        Dim Routing As String
        Dim Via As String
        Dim Notes As String
        Dim SerialNum As String
        Dim LoadSide1 As String

    End Structure

    Private Structure stWBMTY
        Dim LoadSide1 As String
        Dim PriRR As String
        Dim MTYForHome As String
        Dim Cartype As String
        Dim IndAgent As String
        Dim Location As String
        Dim Routing As String
        Dim SerialNum As String

    End Structure


    Private Sub SetUpWaybillPages()

        Dim sLoadSide1 As String = ""
        Dim sMTYForHome As String = ""
        Dim iPrintPage As Integer = 1
        Dim iPrintPageSeq As Integer = 1
        Dim sSerialNum As String = ""
        Dim sBillType As String = ""
        Dim sSeq As String
        Dim iPageMax As Integer

        'Serial Number breakdown - A12345678
        'A = Bill Type -- "S" Staging Select, "A" Freight Agent Select, "R" Road, "T" Through, "I" Start at Industry
        '12 = Print Page Number 01-99
        '3 = Print Page Sequence 1-0 (10)
        '456 = Train Number 001-999
        '78 = In Train Sequence Number 01-99


        'Clear the WBPrintPage tables for loading
        DataAccess_Waybill.spWBViewClearPages()

        'The following data table will have all the waybills in order - All non-train assigned bills first then
        'all train-assigned bills in train number order and in train sequence.
        dtWBList = DataAccess_Waybill.spWBViewGetWBList
        Dim drWBList As DataRow

        For Each drWBList In dtWBList.Rows

            sBillType = ""
            sLoadSide1 = ""
            sMTYForHome = ""
            sSerialNum = ""

            'Assign Print Page and Sequence values, build Serial Number   
            dtWBPrint = DataAccess_Waybill.spWBViewGetRawWB(drWBList.Item(0))


            If dtWBPrint.Rows(0).Item("RouteVerso").ToString = "Staging Select" Then
                sBillType = "S" ' Staging Select

            ElseIf dtWBPrint.Rows(0).Item("RouteVerso").ToString = "Freight Agent Select" Then
                sBillType = "A" ' Freight Agent Select

            ElseIf dtWBPrint.Rows(0).Item("RouteVerso").ToString = "Start at Industry" Then
                sBillType = "I" ' Start at Industry

            ElseIf dtWBPrint.Rows(0).Item("RouteVerso").ToString = "MTY Return Route" Then
                sBillType = "R" ' MTY Return Route

            ElseIf dtWBPrint.Rows(0).Item("RouteVerso").ToString = "Through" Then
                sBillType = "T" ' Through

            Else
                sBillType = "R" ' MTY Return Route

            End If

            sSerialNum = sBillType

            'Insert the Page and Sequence into the Serial Number
            sSerialNum += Format(iPrintPage, "00") & IIf(iPrintPageSeq >= 10, "0", CType(iPrintPageSeq, String))

            Select Case sBillType
                Case "S", "R", "T"
                    'Insert the Train Number and Train Sequence Number into the Serial Number
                    sSerialNum += Format(dtWBPrint.Rows(0).Item("TrainAssignment"), "000") & Format(dtWBPrint.Rows(0).Item("InTrainSeq"), "00")

                Case Else
                    'Insert a random 5-digit number for Staging or Agent select bills
                    sSerialNum += Format(RandomNumber(0, 99999), "00000")

            End Select

            DataAccess_Waybill.spWBViewUpdateWBSeq(iPrintPage, _
                      iPrintPageSeq, _
                      sSerialNum, _
                      dtWBPrint.Rows(0).Item("WaybillID"))

            iPrintPageSeq += 1
            If iPrintPageSeq = 11 Then
                iPrintPage += 1
                iPrintPageSeq = 1
            End If

        Next

        'Now go through the table again in Print Page / Seq order, 1 page at a time,
        'and write the records to the print page tables.

        'Clear the printpage tables
        DataAccess_Waybill.spWBViewClearPages()

        Try
            iPageMax = CType(DataAccess_Misc.spPrintGetMaxPage, Integer)

        Catch ex As Exception

            mbResponse = MsgBox("There are no generated waybills to display.  Please try again.", MsgBoxStyle.Exclamation, "No Waybills Generated For Session")
            Exit Sub

        End Try

        For iPrintPage = 1 To iPageMax

            dtWBPage = DataAccess_Waybill.spWBViewGetFinishedWB(iPrintPage)
            Dim drWBPage As DataRow

            ClearWBLoad()
            ClearWBMTY()

            'Process the selected waybill records and populate the WBLoadPrintPage table and WBMTYPrintPage table from them.  

            'Create the record that will be filled with Update statements
            DataAccess_Waybill.spWBViewSetPageNum(iPrintPage)

            For Each drWBPage In dtWBPage.Rows

                sSeq = Format(drWBPage.Item("PrintPageSeq"), "00")


                If drWBPage.Item("wbPrimarySR").ToString = "S" Or drWBPage.Item("wbPrimarySR").ToString = "B" Then
                    With wbLoad
                        .LoadSide1 = drWBPage.Item("PrintLoadSide1").ToString
                        .PriRR = drWBPage.Item("PriRR").ToString
                        .PriAAR = drWBPage.Item("PriAARCode").ToString
                        .PriInd = drWBPage.Item("PriInd").ToString
                        .PriCity = drWBPage.Item("PriCity").ToString
                        .PriState = drWBPage.Item("PriState").ToString
                        .SecInd = drWBPage.Item("SecInd").ToString
                        .SecCity = drWBPage.Item("SecCity").ToString
                        .SecState = drWBPage.Item("SecState").ToString
                        .Comm = drWBPage.Item("wbComm").ToString
                        .Cartype = drWBPage.Item("wbCarType").ToString
                        .Routing = drWBPage.Item("RouteIntVia").ToString
                        .Via = GetTownName(drWBPage.Item("RouteIntOffAt").ToString) & ", " & drWBPage.Item("RouteIntOffWith").ToString & ""
                        .Notes = drWBPage.Item("wbNotes").ToString
                        .SerialNum = drWBPage.Item("PrintSerialNum").ToString

                    End With

                    With wbMTY 'For Loading
                        .LoadSide1 = drWBPage.Item("PrintLoadSide1").ToString
                        .PriRR = drWBPage.Item("PriRR").ToString
                        .MTYForHome = drWBPage.Item("PrintMTYForHome").ToString
                        .IndAgent = drWBPage.Item("PriInd").ToString
                        .Location = drWBPage.Item("PriCity").ToString & ", " & drWBPage.Item("PriState").ToString & ""
                        .Cartype = drWBPage.Item("wbCarType").ToString
                        .Routing = ""
                        .SerialNum = drWBPage.Item("PrintSerialNum").ToString

                    End With

                ElseIf drWBPage.Item("wbPrimarySR").ToString = "R" Then
                    With wbLoad
                        .LoadSide1 = drWBPage.Item("PrintLoadSide1").ToString
                        .PriRR = drWBPage.Item("SecRR").ToString
                        .PriAAR = drWBPage.Item("SecAARCode").ToString
                        .PriInd = drWBPage.Item("SecInd").ToString
                        .PriCity = drWBPage.Item("SecCity").ToString
                        .PriState = drWBPage.Item("SecState").ToString
                        .SecInd = drWBPage.Item("PriInd").ToString
                        .SecCity = drWBPage.Item("PriCity").ToString
                        .SecState = drWBPage.Item("PriState").ToString
                        .Comm = drWBPage.Item("wbComm").ToString
                        .Cartype = drWBPage.Item("wbCarType").ToString
                        .Routing = drWBPage.Item("RouteIntVia").ToString
                        .Via = GetTownName(drWBPage.Item("RouteIntOnAt").ToString) & ", " & drWBPage.Item("RouteIntOnWith").ToString & ""
                        .Notes = drWBPage.Item("wbNotes").ToString
                        .SerialNum = drWBPage.Item("PrintSerialNum").ToString

                    End With

                    With wbMTY ' For Home
                        .LoadSide1 = drWBPage.Item("PrintLoadSide1").ToString
                        .PriRR = drWBPage.Item("SecRR").ToString
                        .MTYForHome = drWBPage.Item("PrintMTYForHome").ToString
                        .IndAgent = "Agent, " & drWBPage.Item("SecRRMark").ToString
                        If drWBPage.Item("wbComm").ToString <> "MTY" Then
                            .Location = GetTownName(drWBPage.Item("RouteIntOnAt").ToString) & ", " & drWBPage.Item("RouteIntOnWith").ToString & ""
                        Else
                            .Location = GetTownName(drWBPage.Item("RouteIntOffAt").ToString) & ", " & drWBPage.Item("RouteIntOffWith").ToString & ""
                        End If
                        .Cartype = drWBPage.Item("wbCarType").ToString
                        .Routing = ReverseRoute(drWBPage.Item("RouteIntVia").ToString)
                        .SerialNum = drWBPage.Item("PrintSerialNum").ToString

                    End With


                End If

                'Set up the Load and Empty pages
                DataAccess_Waybill.spWBViewLoadPrintPage(sSeq, _
                          wbLoad.PriRR, _
                          wbLoad.PriAAR, _
                          wbLoad.PriInd, _
                          wbLoad.PriCity, _
                          wbLoad.PriState, _
                          wbLoad.Comm, _
                          wbLoad.SecInd, _
                          wbLoad.SecCity, _
                          wbLoad.SecState, _
                          wbLoad.Cartype, _
                          wbLoad.Routing, _
                          wbLoad.Via, _
                          wbLoad.Notes, _
                          wbLoad.LoadSide1, _
                          wbLoad.SerialNum, _
                          iPrintPage, _
                          wbMTY.PriRR, _
                          wbMTY.MTYForHome, _
                          wbMTY.IndAgent, _
                          wbMTY.Location, _
                          wbMTY.Cartype, _
                          wbMTY.Routing, _
                          wbMTY.LoadSide1, _
                          wbMTY.SerialNum, _
                          iPrintPage)


                ClearWBLoad()
                ClearWBMTY()

            Next

            If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()


        Next

        'bFormatted = True
        SetUpWaybillsToolStripMenuItem.Enabled = False


    End Sub


    Private Sub PrintWaybills()

        Dim dtWBList As New DataTable

        'Get the pages (record IDs) from the tables, loop through each front and back page
        dtWBList = DataAccess_Waybill.spWBPrintGetLoadWBPage

        Dim drWBList As DataRow

        For Each drWBList In dtWBList.Rows

RePrintPage:

            MsgBox("Insert a new page into your printer to print side 1.")

            dtWBLoads = DataAccess_Waybill.spWBViewGetLoadWBPage(drWBList.Item("iPrintPage"))
            dtWBMTYs = DataAccess_Waybill.spWBViewGetMTYWBPage(drWBList.Item("iPrintPage"))

            'Send Load Page to print
            PrintLoadsPage()

            MsgBox("Turn the page over and feed it back into your printer to print side 2.")

            'Send MTY Page to print
            PrintMTYsPage()

            mbResponse = MsgBox("Did the page print out correctly? Click No to Re-Print the page, or Yes to continue.", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

            If mbResponse = vbNo Then GoTo RePrintPage

            'Stop ' Temporary, for debugging

        Next


    End Sub


    Private Sub PrintLoadsPage()

        Dim LoadsReport As New Waybill1
        Dim objPS As New System.Drawing.Printing.PrinterSettings
        Dim margins As PageMargins

        margins = LoadsReport.PrintOptions.PageMargins
        margins.bottomMargin = 320
        margins.leftMargin = 360
        margins.rightMargin = 340
        margins.topMargin = 380
        LoadsReport.PrintOptions.ApplyPageMargins(margins)
        crvMTYs.Visible = False
        LoadsReport.PrintOptions.PrinterName = objPS.PrinterName
        LoadsReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        LoadsReport.PrintOptions.PaperSource = PaperSource.Manual  'TODO: Testing
        LoadsReport.SetDataSource(dtWBLoads)
        crvLoads.ReportSource = LoadsReport
        crvLoads.Dock = DockStyle.Fill
        crvLoads.Width = 700
        crvLoads.Height = 450
        crvLoads.BringToFront()
        crvLoads.Visible = True
        LoadsReport.PrintToPrinter(1, False, 0, 0)

    End Sub


    Private Sub PrintMTYsPage()

        Dim MTYsReport As New Waybill2
        Dim objPS As New System.Drawing.Printing.PrinterSettings
        Dim margins As PageMargins

        margins = MTYsReport.PrintOptions.PageMargins
        margins.bottomMargin = 320
        margins.leftMargin = 360
        margins.rightMargin = 340
        margins.topMargin = 380
        MTYsReport.PrintOptions.ApplyPageMargins(margins)
        crvLoads.Visible = False
        MTYsReport.PrintOptions.PrinterName = objPS.PrinterName
        MTYsReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        MTYsReport.PrintOptions.PaperSource = PaperSource.Manual  'TODO: Testing
        MTYsReport.SetDataSource(dtWBMTYs)
        crvMTYs.ReportSource = MTYsReport
        crvMTYs.Dock = DockStyle.Fill
        crvMTYs.Width = 700
        crvMTYs.Height = 450
        crvMTYs.BringToFront()
        crvMTYs.Visible = True

        MTYsReport.PrintToPrinter(1, False, 0, 0)

    End Sub


    Private Sub ClearWBLoad()

        With wbLoad
            .Cartype = ""
            .Comm = ""
            .LoadSide1 = ""
            .Notes = ""
            .PriAAR = ""
            .PriCity = ""
            .PriInd = ""
            .PriRR = ""
            .PriState = ""
            .Routing = ""
            .SecCity = ""
            .SecInd = ""
            .SecState = ""
            .SerialNum = ""
        End With

    End Sub

    Private Sub ClearWBMTY()

        With wbMTY
            .PriRR = ""
            .MTYForHome = ""
            .IndAgent = ""
            .Location = ""
            .Cartype = ""
            .Routing = ""
            .LoadSide1 = ""
        End With

    End Sub


    Private Sub frmWaybillView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim iRecCount As Integer
        Me.Height = Me.Parent.Height - 5
        Me.Width = Me.Parent.Width - 5

        'Check to see if there are any waybills ready to be printed in the Print tables.
        iRecCount = CType(DataAccess_Misc.spPrintGetWBLoadCount, Integer) + 0

        SetUpWaybillsToolStripMenuItem.Enabled = True
        mbResponse = MsgBox("If any new waybills have been added they will not be included unless the entire set is formatted. " & _
            vbNewLine & vbNewLine & "Format all waybills for printing at this time?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Format Waybills Prior to Printing?")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        SetUpWaybillPages()
        'bFormatted = True
        SetUpWaybillsToolStripMenuItem.Enabled = False

    End Sub


    Private Sub ReviewWBs()

        If m_crvPaneShowing = "Loads" Then
            crvLoads.Visible = True
            crvMTYs.Visible = False

        Else
            crvMTYs.Visible = True
            crvLoads.Visible = False

        End If

    End Sub


    Private Sub cmdReviewWBs_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        ReviewWBs()

    End Sub


    Private Sub DisplayLoads()

        Dim LoadsReport As New Waybill1

        dtWBLoads = DataAccess_Waybill.spWBPrintGetLoadWBPage

        'Show Loads Pages 
        crvMTYs.Visible = False
        LoadsReport.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        LoadsReport.SetDataSource(dtWBLoads)
        With crvLoads
            .ReportSource = LoadsReport
            .Dock = DockStyle.Fill
            .Zoom(1)
            .BringToFront()
            .Visible = True
            .Show()
        End With


    End Sub


    Private Sub DisplayMTYs()

        Dim MTYsReport As New Waybill2

        dtWBMTYs = DataAccess_Waybill.spWBPrintGetMTYWBPage

        'Send MTY Page to print
        crvLoads.Visible = False
        MTYsReport.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        MTYsReport.SetDataSource(dtWBMTYs)
        crvMTYs.ReportSource = MTYsReport
        crvMTYs.Dock = DockStyle.Fill
        crvMTYs.Zoom(1)
        crvMTYs.BringToFront()
        crvMTYs.Visible = True
        crvMTYs.Show()

    End Sub


    Private Sub LoadsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoadsToolStripMenuItem.Click

        m_crvPaneShowing = "Loads"
        DisplayLoads()

    End Sub


    Private Sub EmptysToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmptysToolStripMenuItem.Click

        m_crvPaneShowing = "MTYs"
        DisplayMTYs()

    End Sub


    Private Sub SetUpWaybillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetUpWaybillsToolStripMenuItem.Click

        SetUpWaybillPages()

    End Sub

    Private Sub PrintAllWaybillSheetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllWaybillSheetsToolStripMenuItem.Click

        PrintWaybills()

    End Sub


    Private Sub PrintSingleWaybillsSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSingleWaybillsSheetToolStripMenuItem.Click


        Dim dtWBList As New DataTable
        Dim iRecCount As Integer
        Dim iPrintPageNum As Integer

        'Get the number of pages that make up the set
        dtWBList = DataAccess_Waybill.spWBPrintGetLoadWBPage
        iRecCount = dtWBList.Rows.Count

        iPrintPageNum = InputBox("Enter a page number between 1 and " & iRecCount & "to print.", "Print Single Waybill Page", "1")

        If iPrintPageNum > iRecCount Then Exit Sub
        If iPrintPageNum <= 0 Then Exit Sub

RePrintPage:

        MsgBox("Insert a new page into your printer to print side 1.")

        dtWBLoads = DataAccess_Waybill.spWBViewGetLoadWBPage(iPrintPageNum)
        dtWBMTYs = DataAccess_Waybill.spWBViewGetMTYWBPage(iPrintPageNum)

        'Send Load Page to print
        PrintLoadsPage()

        MsgBox("Turn the page over and feed it back into your printer to print side 2.")

        'Send MTY Page to print
        PrintMTYsPage()

        mbResponse = MsgBox("Did the page print out correctly? Click No to Re-Print the page, or Yes to continue.", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If mbResponse = vbNo Then GoTo RePrintPage

    End Sub


End Class