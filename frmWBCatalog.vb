Public Class frmWBCatalog

    Private dtCatalog As New DataTable
    Private dgrCatalog As New DataGridViewRow
    Private dgrSelRow As New DataGridViewRow
    'Private dgfTest As DataGridView
    Private miDisplayRecIdx As Int32


    Private Sub GetCatalog()

        dtCatalog.Clear()

        ''Call Stored Procedure spCatalogFillGrid and establish a filter after the data is returned in the grid.
        dtCatalog = DataAccess_Misc.spCatFillGrid
        dgvCatalog.DataSource = dtCatalog
        lblRecsReturned.Text = dtCatalog.Rows.Count & " Records Returned"

    End Sub


    Private Sub cmdCatDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCatDelete.Click

        Dim mbResponse As MsgBoxResult

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Misc.spCatDelRec(dgrSelRow.Cells("CatalogID").Value.ToString)

        GetCatalog()

        'Return to the same place in the grid
        dgvCatalog.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdCatHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCatHelp.Click

    End Sub


    'Private Sub dgvCatalog_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCatalog.CellClick

    '    'Make the row the cell is in a selected row
    '    dgrSelRow = dgvCatalog.Rows(e.RowIndex)
    '    dgrSelRow.Selected = True

    '    'capture the selected row so we can return to it after editing
    '    miDisplayRecIdx = dgvCatalog.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    'End Sub


    Public Sub RefreshCatGrid()

    End Sub


    Private Sub frmWBCatalog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Create - Waybill Catalog - " & gsMyRRName

        GetCatalog()

    End Sub


    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub dgvCatalog_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCatalog.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvCatalog.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvCatalog.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub


    Private Sub dgvCatalog_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCatalog.CellFormatting
        Dim drv As DataRowView
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dtCatalog.Rows.Count - 1 Then
                drv = dtCatalog.DefaultView.Item(e.RowIndex)
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

End Class