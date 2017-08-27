<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWaybillView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaybillView))
        Me.crwMTY = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Waybill21 = New Here_To_There.Waybill2()
        Me.Waybill22 = New Here_To_There.Waybill2()
        Me.crvLoad = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Waybill12 = New Here_To_There.Waybill1()
        Me.Waybill11 = New Here_To_There.Waybill1()
        Me.SuspendLayout()
        '
        'crwMTY
        '
        Me.crwMTY.ActiveViewIndex = 0
        Me.crwMTY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crwMTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crwMTY.Cursor = System.Windows.Forms.Cursors.Default
        Me.crwMTY.EnableDrillDown = False
        Me.crwMTY.Location = New System.Drawing.Point(0, 400)
        Me.crwMTY.Name = "crwMTY"
        Me.crwMTY.ReportSource = "C:\Users\Craig\Documents\Visual Studio 2015\Projects\Here To There\Waybill2.rpt"
        Me.crwMTY.ShowCopyButton = False
        Me.crwMTY.ShowGroupTreeButton = False
        Me.crwMTY.ShowLogo = False
        Me.crwMTY.ShowParameterPanelButton = False
        Me.crwMTY.ShowRefreshButton = False
        Me.crwMTY.Size = New System.Drawing.Size(1200, 400)
        Me.crwMTY.TabIndex = 1
        Me.crwMTY.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Waybill22
        '
        Me.Waybill22.FileName = "rassdk://C:\Users\Craig\AppData\Local\Temp\temp_843e561b-23be-4854-870d-d6bd55740" &
    "343.rpt"
        '
        'crvLoad
        '
        Me.crvLoad.ActiveViewIndex = 0
        Me.crvLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLoad.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLoad.EnableDrillDown = False
        Me.crvLoad.Location = New System.Drawing.Point(0, 0)
        Me.crvLoad.Name = "crvLoad"
        Me.crvLoad.ReportSource = "C:\Users\Craig\Documents\Visual Studio 2015\Projects\Here To There\Waybill1.rpt"
        Me.crvLoad.ReuseParameterValuesOnRefresh = True
        Me.crvLoad.ShowCopyButton = False
        Me.crvLoad.ShowGroupTreeButton = False
        Me.crvLoad.ShowLogo = False
        Me.crvLoad.ShowParameterPanelButton = False
        Me.crvLoad.ShowRefreshButton = False
        Me.crvLoad.Size = New System.Drawing.Size(1200, 400)
        Me.crvLoad.TabIndex = 0
        Me.crvLoad.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Waybill11
        '
        Me.Waybill11.FileName = "rassdk://C:\Users\Craig\AppData\Local\Temp\temp_3c36a812-0376-4ac7-b790-c805ed1d9" &
    "d12.rpt"
        '
        'frmWaybillView
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1204, 803)
        Me.Controls.Add(Me.crwMTY)
        Me.Controls.Add(Me.crvLoad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWaybillView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Waybill1_1 As Here_To_There.Waybill1
    Friend WithEvents Waybill2_1 As Here_To_There.Waybill2
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmptysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetUpWaybillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllWaybillSheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSingleWaybillsSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents crvLoads As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvMTYs As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvLoad As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crwMTY As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Waybill22 As Waybill2
    Friend WithEvents Waybill11 As Waybill1
    Friend WithEvents Waybill21 As Waybill2
    Friend WithEvents Waybill12 As Waybill1
End Class
