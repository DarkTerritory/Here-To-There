<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSelectRailroad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadSavedSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCurrentSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportIndustryDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportIndustryDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartANewSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateLocalIndustryWaybillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FineTuneCurrentSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintCurrentSessionWaybillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatalog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatalogReview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatalogSelectIndComm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatalogMatchInd = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateThroughWaybillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyRailroadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DivisionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TownsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SidingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterchangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StagingAreasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CommoditiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditCommoditiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndustriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditIndustriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportIndustriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportIndustriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AARDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AARRailroadCodesAndNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AARCarTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AARRegionsAndNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AARStatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndustriesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndustriesByStateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndustriesByStateWithCommoditiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommoditiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommodityBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboundTrainListByDepartureTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboundTrainListByTrainIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProcessToolStripMenuItem, Me.mnuCatalog, Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSelectRailroad, Me.ToolStripSeparator4, Me.LoadSavedSessionToolStripMenuItem, Me.SaveCurrentSessionToolStripMenuItem, Me.ToolStripSeparator5, Me.ImportIndustryDataToolStripMenuItem, Me.ExportIndustryDataToolStripMenuItem, Me.ToolStripSeparator6, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFileSelectRailroad
        '
        Me.mnuFileSelectRailroad.Name = "mnuFileSelectRailroad"
        Me.mnuFileSelectRailroad.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileSelectRailroad.Text = "Select Railroad"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(180, 6)
        '
        'LoadSavedSessionToolStripMenuItem
        '
        Me.LoadSavedSessionToolStripMenuItem.Enabled = False
        Me.LoadSavedSessionToolStripMenuItem.Name = "LoadSavedSessionToolStripMenuItem"
        Me.LoadSavedSessionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LoadSavedSessionToolStripMenuItem.Text = "Load Saved Session"
        '
        'SaveCurrentSessionToolStripMenuItem
        '
        Me.SaveCurrentSessionToolStripMenuItem.Enabled = False
        Me.SaveCurrentSessionToolStripMenuItem.Name = "SaveCurrentSessionToolStripMenuItem"
        Me.SaveCurrentSessionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SaveCurrentSessionToolStripMenuItem.Text = "Save Current Session"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(180, 6)
        '
        'ImportIndustryDataToolStripMenuItem
        '
        Me.ImportIndustryDataToolStripMenuItem.Enabled = False
        Me.ImportIndustryDataToolStripMenuItem.Name = "ImportIndustryDataToolStripMenuItem"
        Me.ImportIndustryDataToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ImportIndustryDataToolStripMenuItem.Text = "Import Industry Data"
        '
        'ExportIndustryDataToolStripMenuItem
        '
        Me.ExportIndustryDataToolStripMenuItem.Enabled = False
        Me.ExportIndustryDataToolStripMenuItem.Name = "ExportIndustryDataToolStripMenuItem"
        Me.ExportIndustryDataToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExportIndustryDataToolStripMenuItem.Text = "Export Industry Data"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CloseToolStripMenuItem.Text = "Close Here to There"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartANewSessionToolStripMenuItem, Me.GenerateLocalIndustryWaybillsToolStripMenuItem, Me.FineTuneCurrentSessionToolStripMenuItem, Me.PrintCurrentSessionWaybillsToolStripMenuItem})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProcessToolStripMenuItem.Text = "Create"
        '
        'StartANewSessionToolStripMenuItem
        '
        Me.StartANewSessionToolStripMenuItem.Name = "StartANewSessionToolStripMenuItem"
        Me.StartANewSessionToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.StartANewSessionToolStripMenuItem.Text = "Start a New Session"
        '
        'GenerateLocalIndustryWaybillsToolStripMenuItem
        '
        Me.GenerateLocalIndustryWaybillsToolStripMenuItem.Name = "GenerateLocalIndustryWaybillsToolStripMenuItem"
        Me.GenerateLocalIndustryWaybillsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.GenerateLocalIndustryWaybillsToolStripMenuItem.Text = "Begin Waybill Generation "
        '
        'FineTuneCurrentSessionToolStripMenuItem
        '
        Me.FineTuneCurrentSessionToolStripMenuItem.Name = "FineTuneCurrentSessionToolStripMenuItem"
        Me.FineTuneCurrentSessionToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.FineTuneCurrentSessionToolStripMenuItem.Text = "Fine-Tune Current Session"
        '
        'PrintCurrentSessionWaybillsToolStripMenuItem
        '
        Me.PrintCurrentSessionWaybillsToolStripMenuItem.Name = "PrintCurrentSessionWaybillsToolStripMenuItem"
        Me.PrintCurrentSessionWaybillsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PrintCurrentSessionWaybillsToolStripMenuItem.Text = "Print Current Session Waybills"
        '
        'mnuCatalog
        '
        Me.mnuCatalog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCatalogReview, Me.mnuCatalogSelectIndComm, Me.mnuCatalogMatchInd, Me.CreateThroughWaybillsToolStripMenuItem})
        Me.mnuCatalog.Name = "mnuCatalog"
        Me.mnuCatalog.Size = New System.Drawing.Size(60, 20)
        Me.mnuCatalog.Text = "Catalog"
        '
        'mnuCatalogReview
        '
        Me.mnuCatalogReview.Name = "mnuCatalogReview"
        Me.mnuCatalogReview.Size = New System.Drawing.Size(317, 22)
        Me.mnuCatalogReview.Text = "Review Waybill Catalog"
        '
        'mnuCatalogSelectIndComm
        '
        Me.mnuCatalogSelectIndComm.Name = "mnuCatalogSelectIndComm"
        Me.mnuCatalogSelectIndComm.Size = New System.Drawing.Size(317, 22)
        Me.mnuCatalogSelectIndComm.Text = "Select Online Industries and Commodities"
        '
        'mnuCatalogMatchInd
        '
        Me.mnuCatalogMatchInd.Name = "mnuCatalogMatchInd"
        Me.mnuCatalogMatchInd.Size = New System.Drawing.Size(317, 22)
        Me.mnuCatalogMatchInd.Text = "Match Industries / Commodities with Partners"
        '
        'CreateThroughWaybillsToolStripMenuItem
        '
        Me.CreateThroughWaybillsToolStripMenuItem.Name = "CreateThroughWaybillsToolStripMenuItem"
        Me.CreateThroughWaybillsToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.CreateThroughWaybillsToolStripMenuItem.Text = "Create Through Waybills "
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyRailroadToolStripMenuItem, Me.ToolStripSeparator1, Me.DivisionsToolStripMenuItem, Me.TownsToolStripMenuItem, Me.SidingsToolStripMenuItem, Me.InterchangesToolStripMenuItem, Me.StagingAreasToolStripMenuItem1, Me.ToolStripSeparator2, Me.CommoditiesToolStripMenuItem, Me.IndustriesToolStripMenuItem, Me.TrainsToolStripMenuItem, Me.AARDataToolStripMenuItem, Me.ToolStripSeparator3, Me.OtherToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ReportsToolStripMenuItem.Text = "Maintain"
        '
        'MyRailroadToolStripMenuItem
        '
        Me.MyRailroadToolStripMenuItem.Name = "MyRailroadToolStripMenuItem"
        Me.MyRailroadToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.MyRailroadToolStripMenuItem.Text = "My Railroad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'DivisionsToolStripMenuItem
        '
        Me.DivisionsToolStripMenuItem.Name = "DivisionsToolStripMenuItem"
        Me.DivisionsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DivisionsToolStripMenuItem.Text = "Divisions"
        '
        'TownsToolStripMenuItem
        '
        Me.TownsToolStripMenuItem.Name = "TownsToolStripMenuItem"
        Me.TownsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TownsToolStripMenuItem.Text = "Towns"
        '
        'SidingsToolStripMenuItem
        '
        Me.SidingsToolStripMenuItem.Name = "SidingsToolStripMenuItem"
        Me.SidingsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SidingsToolStripMenuItem.Text = "Sidings"
        '
        'InterchangesToolStripMenuItem
        '
        Me.InterchangesToolStripMenuItem.Name = "InterchangesToolStripMenuItem"
        Me.InterchangesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InterchangesToolStripMenuItem.Text = "Interchanges"
        '
        'StagingAreasToolStripMenuItem1
        '
        Me.StagingAreasToolStripMenuItem1.Name = "StagingAreasToolStripMenuItem1"
        Me.StagingAreasToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.StagingAreasToolStripMenuItem1.Text = "Staging Areas"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'CommoditiesToolStripMenuItem
        '
        Me.CommoditiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditCommoditiesToolStripMenuItem})
        Me.CommoditiesToolStripMenuItem.Name = "CommoditiesToolStripMenuItem"
        Me.CommoditiesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CommoditiesToolStripMenuItem.Text = "Commodities"
        '
        'AddEditCommoditiesToolStripMenuItem
        '
        Me.AddEditCommoditiesToolStripMenuItem.Name = "AddEditCommoditiesToolStripMenuItem"
        Me.AddEditCommoditiesToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AddEditCommoditiesToolStripMenuItem.Text = "Add / Edit Commodities"
        '
        'IndustriesToolStripMenuItem
        '
        Me.IndustriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditIndustriesToolStripMenuItem, Me.ImportIndustriesToolStripMenuItem, Me.ExportIndustriesToolStripMenuItem})
        Me.IndustriesToolStripMenuItem.Name = "IndustriesToolStripMenuItem"
        Me.IndustriesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.IndustriesToolStripMenuItem.Text = "Industries"
        '
        'AddEditIndustriesToolStripMenuItem
        '
        Me.AddEditIndustriesToolStripMenuItem.Name = "AddEditIndustriesToolStripMenuItem"
        Me.AddEditIndustriesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AddEditIndustriesToolStripMenuItem.Text = "Add / Edit Industries"
        '
        'ImportIndustriesToolStripMenuItem
        '
        Me.ImportIndustriesToolStripMenuItem.Name = "ImportIndustriesToolStripMenuItem"
        Me.ImportIndustriesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ImportIndustriesToolStripMenuItem.Text = "Import Industries (Excel)"
        '
        'ExportIndustriesToolStripMenuItem
        '
        Me.ExportIndustriesToolStripMenuItem.Name = "ExportIndustriesToolStripMenuItem"
        Me.ExportIndustriesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ExportIndustriesToolStripMenuItem.Text = "Export Industries (Excel)"
        '
        'TrainsToolStripMenuItem
        '
        Me.TrainsToolStripMenuItem.Name = "TrainsToolStripMenuItem"
        Me.TrainsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TrainsToolStripMenuItem.Text = "Trains"
        '
        'AARDataToolStripMenuItem
        '
        Me.AARDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AARRailroadCodesAndNamesToolStripMenuItem, Me.AARCarTypesToolStripMenuItem, Me.AARRegionsAndNamesToolStripMenuItem, Me.AARStatesToolStripMenuItem})
        Me.AARDataToolStripMenuItem.Name = "AARDataToolStripMenuItem"
        Me.AARDataToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AARDataToolStripMenuItem.Text = "AAR Data"
        '
        'AARRailroadCodesAndNamesToolStripMenuItem
        '
        Me.AARRailroadCodesAndNamesToolStripMenuItem.Name = "AARRailroadCodesAndNamesToolStripMenuItem"
        Me.AARRailroadCodesAndNamesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AARRailroadCodesAndNamesToolStripMenuItem.Text = "AAR Railroad Codes and Names"
        '
        'AARCarTypesToolStripMenuItem
        '
        Me.AARCarTypesToolStripMenuItem.Name = "AARCarTypesToolStripMenuItem"
        Me.AARCarTypesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AARCarTypesToolStripMenuItem.Text = "AAR Car Types"
        '
        'AARRegionsAndNamesToolStripMenuItem
        '
        Me.AARRegionsAndNamesToolStripMenuItem.Name = "AARRegionsAndNamesToolStripMenuItem"
        Me.AARRegionsAndNamesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AARRegionsAndNamesToolStripMenuItem.Text = "AAR Regions and Names"
        '
        'AARStatesToolStripMenuItem
        '
        Me.AARStatesToolStripMenuItem.Name = "AARStatesToolStripMenuItem"
        Me.AARStatesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AARStatesToolStripMenuItem.Text = "AAR States"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndustriesToolStripMenuItem1, Me.CommoditiesToolStripMenuItem1, Me.TrainsToolStripMenuItem1})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'IndustriesToolStripMenuItem1
        '
        Me.IndustriesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndustriesByStateToolStripMenuItem, Me.IndustriesByStateWithCommoditiesToolStripMenuItem})
        Me.IndustriesToolStripMenuItem1.Name = "IndustriesToolStripMenuItem1"
        Me.IndustriesToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.IndustriesToolStripMenuItem1.Text = "Industries"
        '
        'IndustriesByStateToolStripMenuItem
        '
        Me.IndustriesByStateToolStripMenuItem.Name = "IndustriesByStateToolStripMenuItem"
        Me.IndustriesByStateToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.IndustriesByStateToolStripMenuItem.Text = "Industries by State"
        '
        'IndustriesByStateWithCommoditiesToolStripMenuItem
        '
        Me.IndustriesByStateWithCommoditiesToolStripMenuItem.Name = "IndustriesByStateWithCommoditiesToolStripMenuItem"
        Me.IndustriesByStateWithCommoditiesToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.IndustriesByStateWithCommoditiesToolStripMenuItem.Text = "Industries by State With Commodities"
        '
        'CommoditiesToolStripMenuItem1
        '
        Me.CommoditiesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommodityBalanceToolStripMenuItem})
        Me.CommoditiesToolStripMenuItem1.Name = "CommoditiesToolStripMenuItem1"
        Me.CommoditiesToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.CommoditiesToolStripMenuItem1.Text = "Commodities"
        '
        'CommodityBalanceToolStripMenuItem
        '
        Me.CommodityBalanceToolStripMenuItem.Name = "CommodityBalanceToolStripMenuItem"
        Me.CommodityBalanceToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CommodityBalanceToolStripMenuItem.Text = "Commodity Balance"
        '
        'TrainsToolStripMenuItem1
        '
        Me.TrainsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrainReportToolStripMenuItem, Me.InboundTrainListByDepartureTimeToolStripMenuItem, Me.InboundTrainListByTrainIDToolStripMenuItem})
        Me.TrainsToolStripMenuItem1.Name = "TrainsToolStripMenuItem1"
        Me.TrainsToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.TrainsToolStripMenuItem1.Text = "Trains"
        '
        'TrainReportToolStripMenuItem
        '
        Me.TrainReportToolStripMenuItem.Name = "TrainReportToolStripMenuItem"
        Me.TrainReportToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TrainReportToolStripMenuItem.Text = "Train Report"
        '
        'InboundTrainListByDepartureTimeToolStripMenuItem
        '
        Me.InboundTrainListByDepartureTimeToolStripMenuItem.Enabled = False
        Me.InboundTrainListByDepartureTimeToolStripMenuItem.Name = "InboundTrainListByDepartureTimeToolStripMenuItem"
        Me.InboundTrainListByDepartureTimeToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.InboundTrainListByDepartureTimeToolStripMenuItem.Text = "Train List by Departure Time"
        '
        'InboundTrainListByTrainIDToolStripMenuItem
        '
        Me.InboundTrainListByTrainIDToolStripMenuItem.Enabled = False
        Me.InboundTrainListByTrainIDToolStripMenuItem.Name = "InboundTrainListByTrainIDToolStripMenuItem"
        Me.InboundTrainListByTrainIDToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.InboundTrainListByTrainIDToolStripMenuItem.Text = "Inbound Train List by Train ID"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 862)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Here To There - Car Forwarding with Waybills"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyRailroadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DivisionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TownsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SidingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CommoditiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndustriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditCommoditiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditIndustriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportIndustriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportIndustriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AARDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AARRailroadCodesAndNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AARCarTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AARRegionsAndNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AARStatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoadSavedSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveCurrentSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IndustriesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndustriesByStateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndustriesByStateWithCommoditiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommoditiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommodityBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterchangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCatalog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCatalogSelectIndComm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCatalogMatchInd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCatalogReview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StagingAreasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateThroughWaybillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportIndustryDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportIndustryDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GenerateLocalIndustryWaybillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FineTuneCurrentSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InboundTrainListByDepartureTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InboundTrainListByTrainIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSelectRailroad As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents PrintCurrentSessionWaybillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartANewSessionToolStripMenuItem As ToolStripMenuItem
End Class
