Imports System.Data.OleDb

Public Class frmMain

    Private mbResponse As MsgBoxResult
    Public dtReport As New DataTable


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Run Housekeeping procedure to load global values
        Housekeeping()

    End Sub


    Private Sub StartANewSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartANewSessionToolStripMenuItem.Click

        mbResponse = MsgBox("This will wipe out all existing waybill data and allow you to select " &
                            "a new group of waybills from the catalog for an operating session. " &
                            "Click OK to proceed. This process cannot be undone once started.",
                            MsgBoxStyle.OkCancel, "Warning - About to Destroy Existing Data")

        If mbResponse = MsgBoxResult.Cancel Then Exit Sub

        DataAccess_Misc.spClearWBTable()

        mbResponse = MsgBox("All waybill data is now removed, you may build a new operating session at any time.", MsgBoxStyle.Information)

    End Sub



    Private Sub ContinueAnExistingSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim MDIFrmLocalInd As New frmLocalInd
        MDIFrmLocalInd.MdiParent = Me
        MDIFrmLocalInd.Show()

    End Sub


    Private Sub AssignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim MDIFrmTrainAssign As New frmTrainAssign
        MDIFrmTrainAssign.MdiParent = Me
        MDIFrmTrainAssign.Show()

    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        End

    End Sub


    Private Sub MyRailroadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyRailroadToolStripMenuItem.Click

        Dim MDIFrmMaintMyRR As New frmMaintMyRR
        MDIFrmMaintMyRR.MdiParent = Me
        MDIFrmMaintMyRR.Show()

    End Sub


    Private Sub DivisionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivisionsToolStripMenuItem.Click

        Dim MDIfrmMaintDiv As New frmMaintDiv
        MDIfrmMaintDiv.MdiParent = Me
        MDIfrmMaintDiv.Show()

    End Sub


    Private Sub TownsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TownsToolStripMenuItem.Click

        Dim MDIFrmMaintTown As New frmMaintTown
        MDIFrmMaintTown.MdiParent = Me
        MDIFrmMaintTown.Show()

    End Sub


    Private Sub SidingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SidingsToolStripMenuItem.Click

        Dim MDIFrmMaintSiding As New frmMaintSiding
        MDIFrmMaintSiding.MdiParent = Me
        MDIFrmMaintSiding.Show()

    End Sub


    Private Sub AddEditCommoditiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditCommoditiesToolStripMenuItem.Click

        Dim MDIFrmMaintComm As New frmMaintComm
        MDIFrmMaintComm.MdiParent = Me
        MDIFrmMaintComm.Show()

    End Sub


    Private Sub AddEditDeleteIndustriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditIndustriesToolStripMenuItem.Click

        Dim MDIFrmMaintInd As New frmMaintInd
        MDIFrmMaintInd.MdiParent = Me
        MDIFrmMaintInd.Show()

    End Sub


    Private Sub TrainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainsToolStripMenuItem.Click

        Dim MDIFrmMaintTrain As New frmMaintTrain
        MDIFrmMaintTrain.MdiParent = Me
        MDIFrmMaintTrain.Show()

    End Sub


    Private Sub AARCarTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AARCarTypesToolStripMenuItem.Click

        Dim MDIFrmMaintCarType As New frmMaintCarType
        MDIFrmMaintCarType.MdiParent = Me
        MDIFrmMaintCarType.Show()

    End Sub


    Private Sub AARRailroadCodesAndNamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AARRailroadCodesAndNamesToolStripMenuItem.Click

        Dim MDIFrmMaintRRNames As New frmMaintRRNames
        MDIFrmMaintRRNames.MdiParent = Me
        MDIFrmMaintRRNames.Show()

    End Sub


    Private Sub AARRegionsAndNamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AARRegionsAndNamesToolStripMenuItem.Click

        Dim MDIfrmMaintRegion As New frmMaintRegion
        MDIfrmMaintRegion.MdiParent = Me
        MDIfrmMaintRegion.Show()

    End Sub

    Private Sub AARStatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AARStatesToolStripMenuItem.Click

        Dim MDIfrmMaintState As New frmMaintState
        MDIfrmMaintState.MdiParent = Me
        MDIfrmMaintState.Show()

    End Sub

    'Private Sub IndustriesByStateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndustriesByStateToolStripMenuItem.Click

    '    Dim objPS As New System.Drawing.Printing.PrinterSettings
    '    Dim frmRptView As New frmReportViewer
    '    Dim rptFile As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    rptFile.Load(Application.ExecutablePath & "\Reports\IndByState.rpt")
    '    dtReport = DataAccess_Misc.spMainRptIndByState
    '    rptFile.PrintOptions.PrinterName = objPS.PrinterName
    '    rptFile.SetDataSource(dtReport)
    '    frmRptView.crvIndsWithComms.ReportSource = rptFile
    '    frmRptView.crvIndsWithComms.Dock = DockStyle.Fill
    '    frmRptView.Show()

    '    'rptFile.PrintToPrinter(1, False, 0, 0)

    'End Sub


    Private Sub IndustriesByStateWithCommoditiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndustriesByStateWithCommoditiesToolStripMenuItem.Click

        Dim frmRptView As New frmReportView
        Dim rptFile As ReportDocument
        Dim dtDT As DataTable

        dtDT = DataAccess_Misc.spIndsWithCommsState
        dtDT.TableName = "Industry1"

        frmRptView = New frmReportView
        rptFile = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptFile.Load(Application.StartupPath & "\Reports\IndsWithComms.rpt")
        frmRptView.crvReport.ReportSource = rptFile

        rptFile.SetParameterValue("Railroad_ID", 1)
        rptFile.SetDataSource(dtDT)

        frmRptView.Show()

        'rptFile.PrintToPrinter(1, False, 0, 0)

    End Sub


    Private Sub CommodityBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommodityBalanceToolStripMenuItem.Click

        Dim frmRptView As New frmReportView
        Dim rptFile As ReportDocument

        frmRptView = New frmReportView
        rptFile = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptFile.Load(Application.StartupPath & "\Reports\IndsWithComms.rpt")
        rptFile.SetParameterValue("Railroad_ID", "1")
        'rptFile.SetParameterValue("Railroad_ID", gsMyRR_ID)
        frmRptView.crvReport.ReportSource = rptFile
        frmRptView.Show()


        '    Dim objPS As New System.Drawing.Printing.PrinterSettings
        '    Dim frmRptView As New frmReportViewer
        '    Dim rptFile As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        '    rptFile.Load(Application.ExecutablePath & "\Reports\CommBalance.rpt")
        '    dtReport = DataAccess_Misc.spMainRptCommBal()
        '    rptFile.PrintOptions.PrinterName = objPS.PrinterName
        '    rptFile.SetDataSource(dtReport)
        '    frmRptView.crvIndsWithComms.ReportSource = rptFile
        '    frmRptView.crvIndsWithComms.Dock = DockStyle.Fill
        '    frmRptView.Show()

    End Sub


    'Private Sub TrainReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainReportToolStripMenuItem.Click

    '    Dim objPS As New System.Drawing.Printing.PrinterSettings
    '    Dim frmRptView As New frmReportViewer
    '    Dim rptFile As New CrystalDecisions.CrystalReports.Engine.ReportDocument


    '    rptFile.Load(Application.ExecutablePath & "\Reports\TrainReport.rpt")
    '    dtReport = DataAccess_Misc.spTrainReport
    '    rptFile.PrintOptions.PrinterName = objPS.PrinterName
    '    rptFile.SetDataSource(dtReport)
    '    frmRptView.crvIndsWithComms.ReportSource = rptFile
    '    frmRptView.crvIndsWithComms.Dock = DockStyle.Fill
    '    frmRptView.Show()

    'End Sub


    Private Sub SaveCurrentSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCurrentSessionToolStripMenuItem.Click

        'TODO: Make this work!

        'Get the name the user wants to save the session data file as


        'Copy the existing empty Session data file to the name and place the user wants it

        'Open a connection to the new save file

        'Copy the wkIndustry, wkSiding and Waybills table to the new save file
        Dim conn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim SQLStr As String = ""

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DestinationDB.mdb;Persist Security Info=False;")

        'clear any existing data from the destination table
        SQLStr = "Delete from DestinationTable"

        conn.Open()

        cmd = New OleDbCommand(SQLStr, conn)
        cmd.ExecuteNonQuery()

        SQLStr = "Insert Into DestinationTable Select * from SourceTable IN 'C:\SourceDatabase.mdb'"
        cmd = New OleDbCommand(SQLStr, conn)
        cmd.ExecuteNonQuery()
        'Close the connection

    End Sub


    Private Sub LoadSavedSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadSavedSessionToolStripMenuItem.Click

        Dim sSessionFilePath As String

        'Get the name of the saved data file the user wants to load
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Select a Saved Here To There Session to Open"
        fdlg.InitialDirectory = gsAppPath
        fdlg.Filter = "Here To There Files (*.htt)|*.htt|All files (*.*)|*.*"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            sSessionFilePath = fdlg.FileName
        End If
        'Clear the session tables currently in the mail DB

        'Open a connection to the save file

        'Copy the saved Session data tables to the primary DB

        'Close the connection

    End Sub


    Private Sub InterchangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterchangesToolStripMenuItem.Click

        Dim MDIFrmMaintInt As New frmMaintInt
        MDIFrmMaintInt.MdiParent = Me
        MDIFrmMaintInt.Show()

    End Sub


    'Private Sub ImportIndustryDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportIndustryDataToolStripMenuItem.Click

    '    Dim sSessionFilePath As String
    '    Dim dtInput As New DataTable
    '    Dim sSheetName As String

    '    Dim sList As String
    '    Dim sEra As String
    '    Dim sInd As String
    '    Dim sCity As String
    '    Dim sState As String
    '    Dim sRR As String
    '    Dim sSR As String
    '    Dim sComm As String
    '    Dim sSTCC As String
    '    Dim sRecip As String
    '    Dim sContrib As String

    '    'Get the name of the saved data file the user wants to load
    '    Dim fdlg As OpenFileDialog = New OpenFileDialog()
    '    fdlg.Title = "Select a Saved Here To There Session to Open"
    '    fdlg.InitialDirectory = gsAppPath
    '    fdlg.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*"
    '    fdlg.FilterIndex = 2
    '    fdlg.RestoreDirectory = True
    '    If fdlg.ShowDialog() = DialogResult.OK Then
    '        sSessionFilePath = fdlg.FileName
    '    End If

    '    If sSessionFilePath = "" Then Exit Sub

    '    sSheetName = InputBox("Please provide the name of the worksheet to draw data from", "Input Data - Worksheet Name")


    '    'Create a connection to the Excel spreadsheet
    '    Dim conn As New OleDbConnection

    '    Dim cmd As New OleDbCommand("SELECT * FROM [" & sSheetName & "$]", conn)

    '    'SQL syntax "SELECT [Column Name One], [Column Name Two] FROM [Sheet One$]". I.e. excel worksheet name followed by a "$" and wrapped in "[" "]" brackets.

    '    conn.ConnectionString = "OLEDB;Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sSessionFilePath & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"
    '    conn.Open()
    '    Dim drdInput As OleDbDataReader
    '    drdInput = cmd.ExecuteReader
    '    While drdInput.Read


    '    End While
    '    conn.Close()



    'End Sub


    Private Sub mnuCatalogSelectIndComm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCatalogSelectIndComm.Click

        Dim MDIFrmLocalInd As New frmLocalInd
        MDIFrmLocalInd.MdiParent = Me
        MDIFrmLocalInd.Show()

    End Sub

    Private Sub mnuCatalogMatchInd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCatalogMatchInd.Click

        Dim MDIfrmMatchup As New frmMatchup
        MDIfrmMatchup.MdiParent = Me
        MDIfrmMatchup.RefreshSelIndGrid()
        MDIfrmMatchup.Show()

    End Sub


    Private Sub mnuCatalogReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCatalogReview.Click

        Dim MDIfrmWBCatalog As New frmWBCatalog
        MDIfrmWBCatalog.MdiParent = Me
        MDIfrmWBCatalog.RefreshCatGrid()
        MDIfrmWBCatalog.Show()

    End Sub


    Private Sub StagingAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StagingAreasToolStripMenuItem1.Click

        Dim MDIFrmMaintStaging As New frmMaintStaging
        MDIFrmMaintStaging.MdiParent = Me
        MDIFrmMaintStaging.Show()

    End Sub


    Private Sub CreateThroughWaybillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateThroughWaybillsToolStripMenuItem.Click

        Dim MDIfrmBuildThruWBs As New frmBuildThruWBs
        MDIfrmBuildThruWBs.MdiParent = Me
        MDIfrmBuildThruWBs.Show()

    End Sub


    Private Sub PrintGeneratedSessionWaybillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        mbResponse = MsgBox("Please confirm that you have completed assigning waybills to trains by clicking Yes below. If not, click No to go back and finish.", MsgBoxStyle.YesNo, "Confirm Assignments are Completed")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        Dim MDIFrmWaybillView As New frmWaybillView
        MDIFrmWaybillView.MdiParent = Me
        MDIFrmWaybillView.Show()

    End Sub


    Private Sub GenerateLocalIndustryWaybillsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateLocalIndustryWaybillsToolStripMenuItem.Click

        Dim MDIfrmGenerate As New frmGenerate
        MDIfrmGenerate.MdiParent = Me
        frmGenerate.Show()

    End Sub

    Private Sub FineTuneCurrentSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FineTuneCurrentSessionToolStripMenuItem.Click

        Dim MDIFrmTrainAssign As New frmTrainAssign
        MDIFrmTrainAssign.MdiParent = Me
        MDIFrmTrainAssign.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintCurrentSessionWaybillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCurrentSessionWaybillsToolStripMenuItem.Click

        Dim MDIfrmWaybillView As New frmWaybillView
        MDIfrmWaybillView.MdiParent = Me
        MDIfrmWaybillView.Show()

    End Sub


    'Private Sub InboundTrainListByTrainIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InboundTrainListByTrainIDToolStripMenuItem.Click

    '    Dim objPS As New System.Drawing.Printing.PrinterSettings
    '    Dim frmRptView As New frmReportViewer
    '    Dim rptFile As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    rptFile.Load(Application.ExecutablePath & "\Reports\TrainListByID.rpt")
    '    'TODO: Find Stored Proc for this report - Access?
    '    'dtReport = DataAccess_Misc.spGenRptTrainListByID
    '    rptFile.PrintOptions.PrinterName = objPS.PrinterName
    '    rptFile.SetDataSource(dtReport)
    '    frmRptView.crvIndsWithComms.ReportSource = rptFile
    '    frmRptView.crvIndsWithComms.Dock = DockStyle.Fill
    '    frmRptView.Show()

    'End Sub

    'Private Sub InboundTrainListByDepartureTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InboundTrainListByDepartureTimeToolStripMenuItem.Click

    '    Dim objPS As New System.Drawing.Printing.PrinterSettings
    '    Dim frmRptView As New frmReportViewer
    '    Dim rptFile As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    rptFile.Load(Application.ExecutablePath & "\Reports\TrainListByDeparture.rpt")
    '    'TODO: Find Stored Proc for this report - Access?
    '    'dtReport = DataAccess_Report.[spGenRptTrainLstByDepart]
    '    rptFile.PrintOptions.PrinterName = objPS.PrinterName
    '    rptFile.SetDataSource(dtReport)
    '    frmRptView.crvIndsWithComms.ReportSource = rptFile
    '    frmRptView.crvIndsWithComms.Dock = DockStyle.Fill
    '    frmRptView.Show()

    'End Sub


End Class
