<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaybillView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaybillView))
        Me.Waybill1_1 = New Here_To_There.Waybill1
        Me.Waybill2_1 = New Here_To_There.Waybill2
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetUpWaybillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmptysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintAllWaybillSheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSingleWaybillsSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.crvLoads = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crvMTYs = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1032, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetUpWaybillsToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'SetUpWaybillsToolStripMenuItem
        '
        Me.SetUpWaybillsToolStripMenuItem.Name = "SetUpWaybillsToolStripMenuItem"
        Me.SetUpWaybillsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SetUpWaybillsToolStripMenuItem.Text = "Set Up Waybills"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadsToolStripMenuItem, Me.EmptysToolStripMenuItem, Me.ToolStripSeparator1})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LoadsToolStripMenuItem
        '
        Me.LoadsToolStripMenuItem.Name = "LoadsToolStripMenuItem"
        Me.LoadsToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LoadsToolStripMenuItem.Text = "Loads"
        '
        'EmptysToolStripMenuItem
        '
        Me.EmptysToolStripMenuItem.Name = "EmptysToolStripMenuItem"
        Me.EmptysToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EmptysToolStripMenuItem.Text = "Emptys"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllWaybillSheetsToolStripMenuItem, Me.PrintSingleWaybillsSheetToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintAllWaybillSheetsToolStripMenuItem
        '
        Me.PrintAllWaybillSheetsToolStripMenuItem.Name = "PrintAllWaybillSheetsToolStripMenuItem"
        Me.PrintAllWaybillSheetsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintAllWaybillSheetsToolStripMenuItem.Text = "Print All Waybill Sheets"
        '
        'PrintSingleWaybillsSheetToolStripMenuItem
        '
        Me.PrintSingleWaybillsSheetToolStripMenuItem.Name = "PrintSingleWaybillsSheetToolStripMenuItem"
        Me.PrintSingleWaybillsSheetToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PrintSingleWaybillsSheetToolStripMenuItem.Text = "Print Single Waybills Sheet"
        '
        'crvLoads
        '
        Me.crvLoads.ActiveViewIndex = 0
        Me.crvLoads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLoads.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLoads.Location = New System.Drawing.Point(0, 24)
        Me.crvLoads.Name = "crvLoads"
        Me.crvLoads.ReportSource = Me.Waybill1_1
        Me.crvLoads.Size = New System.Drawing.Size(1032, 593)
        Me.crvLoads.TabIndex = 7
        '
        'crvMTYs
        '
        Me.crvMTYs.ActiveViewIndex = 0
        Me.crvMTYs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvMTYs.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvMTYs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvMTYs.Location = New System.Drawing.Point(0, 24)
        Me.crvMTYs.Name = "crvMTYs"
        Me.crvMTYs.ReportSource = Me.Waybill2_1
        Me.crvMTYs.Size = New System.Drawing.Size(1032, 593)
        Me.crvMTYs.TabIndex = 8
        '
        'frmWaybillView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 617)
        Me.Controls.Add(Me.crvMTYs)
        Me.Controls.Add(Me.crvLoads)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWaybillView"
        Me.Text = "Generate, Review and Print Waybills"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
