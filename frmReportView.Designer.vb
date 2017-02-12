<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportView))
        Me.AAR_Region1 = New Here_To_There.AAR_Region
        Me.HereToThereReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'HereToThereReportViewer
        '
        Me.HereToThereReportViewer.ActiveViewIndex = -1
        Me.HereToThereReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HereToThereReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.HereToThereReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HereToThereReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.HereToThereReportViewer.Name = "HereToThereReportViewer"
        Me.HereToThereReportViewer.Size = New System.Drawing.Size(909, 632)
        Me.HereToThereReportViewer.TabIndex = 0
        '
        'frmReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 632)
        Me.Controls.Add(Me.HereToThereReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportView"
        Me.Text = "Here to There Report:"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IndByStateWComms1 As Here_To_There.IndByStateWComms
    Friend WithEvents CommBalance1 As Here_To_There.CommBalance
    Friend WithEvents AAR_Region1 As Here_To_There.AAR_Region
    Friend WithEvents HereToThereReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
