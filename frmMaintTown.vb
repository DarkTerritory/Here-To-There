Public Class frmMaintTown

    Private dtTown As New DataTable
    Private dtServedBy As New DataTable
    Private dtDiv As New DataTable
    Private dtEastOf As New DataTable
    Private dtWestOf As New DataTable
    Private dtFrtHub As New DataTable
    Private dtState As New DataTable
    Private dtLocal As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miDisplayRecIdx As Int32


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", "(New).", "for " & msMode & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub GetTown()

        dtTown.Clear()

        dtTown = DataAccess_Get.spGetTowns
        dgvTown.DataSource = dtTown

        msMode = "Browse"


    End Sub


    Private Sub cmdTownNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTownNew.Click

        EnableDisableEditFields(True)
        ClearEditFields()

        msMode = "New"
        cmdTownNew.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdTownEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTownEdit.Click

        If dgvTown.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdTownEdit.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdTownDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTownDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvTown.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        mbResponse = MsgBox("Records in the Town table are keys to many other data tables in Here to There. " & vbNewLine & vbNewLine & _
            "Deleting this record could cause problems with records being lost in the Industry, Interchange, Siding, Train and Train Work tables " & _
            "AND even interfere with existing or saved waybill records. " & vbNewLine & vbNewLine & _
            "Before proceding you should check each of those tables to make sure all references to the town are changed or deleted. " & vbNewLine & vbNewLine & _
            "Are you SURE you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "WARNING - Potentially critical data issues")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMTownDelRec(dgrSelRow.Cells("TownID").Value.ToString)

        GetTown()

        'Return to the same place in the grid
        dgvTown.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdTownSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTownSave.Click

        Dim sErrText As String = ""

        If msMode.ToUpper <> "EDIT" And msMode.ToUpper <> "NEW" Then Exit Sub

        sErrText = ValidateTown()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMTownUpdate(PrepStrForQuery(txtTownID.Text), _
                      PrepStrForQuery(txtTownName.Text), _
                      PrepStrForQuery(cboTownState.SelectedValue), _
                      PrepStrForQuery(TxtTownCallSign.Text), _
                      cboTownFrtHub.SelectedValue, _
                      cboTownServedBy.SelectedValue, _
                      cboTownDiv.SelectedValue, _
                      cboTownEastOf.SelectedValue, _
                      cboTownWestOf.SelectedValue, _
                      cboTownLocal.SelectedValue)

        End If

        If msMode.ToUpper = "NEW" Then
            DataAccess_Maintenance.spMTownIns(PrepStrForQuery(txtTownName.Text), _
                      cboTownState.SelectedValue, _
                      PrepStrForQuery(TxtTownCallSign.Text), _
                      cboTownFrtHub.SelectedValue, _
                      cboTownServedBy.SelectedValue, _
                      cboTownDiv.SelectedValue, _
                      cboTownEastOf.SelectedValue, _
                      cboTownWestOf.SelectedValue, _
                      cboTownLocal.SelectedValue)

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetTown()

        'Return to the edited record
        dgvTown.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdTownHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTownHelp.Click

    End Sub


    Private Sub cmdTownReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTownReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            If msMode.ToUpper = "EDIT" Then
                txtTownID.Enabled = False
                txtTownName.Enabled = False
                cboTownState.Enabled = True
                TxtTownCallSign.Enabled = False
                cboTownFrtHub.Enabled = True
                cboTownServedBy.Enabled = True
                cboTownDiv.Enabled = True
                cboTownEastOf.Enabled = True
                cboTownWestOf.Enabled = True
                cboTownLocal.Enabled = True

            ElseIf msMode.ToUpper = "NEW" Then
                txtTownID.Enabled = True
                txtTownName.Enabled = True
                cboTownState.Enabled = True
                TxtTownCallSign.Enabled = True
                cboTownFrtHub.Enabled = True
                cboTownServedBy.Enabled = True
                cboTownDiv.Enabled = True
                cboTownEastOf.Enabled = True
                cboTownWestOf.Enabled = True
                cboTownLocal.Enabled = True

            End If

        Else
            txtTownID.Enabled = False
            txtTownName.Enabled = False
            cboTownState.Enabled = False
            TxtTownCallSign.Enabled = False
            cboTownFrtHub.Enabled = False
            cboTownServedBy.Enabled = False
            cboTownDiv.Enabled = False
            cboTownEastOf.Enabled = False
            cboTownWestOf.Enabled = False
            cboTownLocal.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtTownID.Text = ""
        txtTownName.Text = ""
        cboTownState.Text = ""
        TxtTownCallSign.Text = ""
        cboTownFrtHub.Text = ""
        cboTownServedBy.Text = ""
        cboTownDiv.Text = ""
        cboTownEastOf.Text = ""
        cboTownWestOf.Text = ""
        cboTownLocal.Text = ""

    End Sub

    Private Sub dgvTown_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTown.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvTown.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvTown.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtTownID.Text = dgrSelRow.Cells("TownID").Value.ToString
        txtTownName.Text = dgrSelRow.Cells("TownName").Value.ToString
        cboTownState.Text = dgrSelRow.Cells("TownState").Value.ToString
        TxtTownCallSign.Text = dgrSelRow.Cells("TownCallSign").Value.ToString
        cboTownFrtHub.Text = dgrSelRow.Cells("TownFrtHub").Value.ToString
        cboTownServedBy.Text = dgrSelRow.Cells("TownServedBy").Value.ToString
        cboTownDiv.Text = dgrSelRow.Cells("TownDiv").Value.ToString
        cboTownEastOf.Text = dgrSelRow.Cells("TownEastOf").Value.ToString
        cboTownWestOf.Text = dgrSelRow.Cells("TownWestOf").Value.ToString
        cboTownLocal.Text = dgrSelRow.Cells("TownLocal").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdTownEdit.BackColor = SystemColors.Control
        cmdTownHelp.BackColor = SystemColors.Control
        cmdTownNew.BackColor = SystemColors.Control
        cmdTownSave.BackColor = SystemColors.Control
        cmdTownDelete.BackColor = SystemColors.Control
        cmdTownReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateTown() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0

        iVal = DataAccess_Misc.spValidateTown(txtTownID.Text)

        If txtTownID.Text = "" Then
            sStr += "Town ID Cannot be blank. " & vbNewLine

            'Town ID Must be Unique
        ElseIf msMode.ToUpper = "EDIT" And iVal = 0 Then
            sStr += "Can't change Town ID of an existing record. Delete record and add a new one to replace. "

        ElseIf msMode.ToUpper = "ADD" And iVal > 0 Then
            sStr += "Can't add this record, Town ID already exists in database. Try another Town ID. "

        ElseIf msMode.ToUpper = "EDIT" And iVal > 0 Then
            If TxtTownCallSign.Text <> dgrSelRow.Cells("TownCallSign").Value.ToString Then
                sStr += "You have changed the call sign of an existing town record. This is not allowed. Delete record and add a new one to replace. "

            End If

        End If

        If txtTownName.Text = "" Then
            sStr += "Town Name is blank. " & vbNewLine
        End If

        If cboTownState.Text = "" Then
            sStr += "Town State is blank. " & vbNewLine
        End If

        If TxtTownCallSign.Text = "" Then
            sStr += "Town Call Sign is blank. " & vbNewLine
        End If

        If cboTownFrtHub.Text = "" Then
            sStr += "Town Freight Hub is blank. " & vbNewLine
        End If

        If cboTownServedBy.Text = "" Then
            sStr += "Town Served By Freight Hub is blank. " & vbNewLine
        End If

        If cboTownDiv.Text = "" Then
            sStr += "Town Division is blank. " & vbNewLine
        End If

        If cboTownLocal.Text = "" Then
            sStr += "Town Local is blank. " & vbNewLine
        End If

        Return sStr

    End Function


    Private Sub dgvTown_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTown.CellFormatting

        Dim drv As DataRowView
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dtTown.Rows.Count - 1 Then
                drv = dtTown.DefaultView.Item(e.RowIndex)
                Dim c As Color
                If (drv.Item("TownLocal") = "Yes" Or drv.Item("TownLocal") = "Upline") And drv.Item("Sidings").ToString = "0" Then
                    c = Color.Yellow
                Else
                    c = Color.White

                End If
                e.CellStyle.BackColor = c
            End If
        End If

    End Sub


    Private Sub frmMaintTown_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Maintain - Town - " & gsMyRRName

        GetTown()

        dtFrtHub = DataAccess_Fill.spFillLookupDT("YesNo")
        cboTownFrtHub.DataSource = dtFrtHub
        cboTownFrtHub.DisplayMember = "LkDesc"
        cboTownFrtHub.ValueMember = "LkCode"

        dtLocal = DataAccess_Fill.spFillLookupDT("TownLocal")
        cboTownLocal.DataSource = dtLocal
        cboTownLocal.DisplayMember = "LkDesc"
        cboTownLocal.ValueMember = "LkCode"


        dtServedBy = DataAccess_Get.spGetTownFrtHubs

        If dtTown.Rows.Count > 0 Then
            cboTownServedBy.DataSource = dtServedBy
            cboTownServedBy.DisplayMember = "TownName"
            cboTownServedBy.ValueMember = "TownCallSign"
        End If

        dtDiv = DataAccess_Maintenance.spMTownDivNameCd

        If dtDiv.Rows.Count > 0 Then
            cboTownDiv.DataSource = dtDiv
            cboTownDiv.DisplayMember = "DivName"
            cboTownDiv.ValueMember = "DivNum"
        End If

        dtEastOf = DataAccess_Get.spGetTowns
        'Dim R As DataRow = dtEastOf.NewRow  'Commented when Staging and Terminal added to Towns in DB - CJB 4/19/2015
        'R("TownName") = "Staging"
        'R("TownCallSign") = "99"
        'dtEastOf.Rows.Add(R)
        'R = dtEastOf.NewRow
        'R("TownName") = "Terminal"
        'R("TownCallSign") = "00"
        'dtEastOf.Rows.Add(R)
        'dtEastOf.AcceptChanges()
        cboTownEastOf.DataSource = dtEastOf
        cboTownEastOf.DisplayMember = "TownName"
        cboTownEastOf.ValueMember = "TownCallSign"

        dtWestOf = DataAccess_Get.spGetTowns
        'Dim Z As DataRow = dtWestOf.NewRow  'Commented when Staging and Terminal added to Towns in DB - CJB 4/19/2015
        'R("TownName") = "Staging"
        'Z("TownName") = "Staging"
        'Z("TownCallSign") = "99"
        'dtWestOf.Rows.Add(Z)
        'Z = dtWestOf.NewRow
        'Z("TownName") = "Terminal"
        'Z("TownCallSign") = "00"
        'dtWestOf.Rows.Add(Z)
        'dtWestOf.AcceptChanges()
        cboTownWestOf.DataSource = dtWestOf
        cboTownWestOf.DisplayMember = "TownName"
        cboTownWestOf.ValueMember = "TownCallSign"

        dtState = DataAccess_Fill.spFillOutStateChg("")
        cboTownState.DataSource = dtState
        cboTownState.DisplayMember = "AARStateName"
        cboTownState.ValueMember = "AARState"

        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'Tooltip descriptions
        ttpMaintTown.SetToolTip(lblTownName, "The Name of the Town.")
        ttpMaintTown.SetToolTip(lblTownID, "The I.D. Number of the town. This cannot be changed.")
        ttpMaintTown.SetToolTip(lblTownState, "The State the Town is located in.")
        ttpMaintTown.SetToolTip(lblTownCallSign, "The two- or three-letter Call Sign of the town.")
        ttpMaintTown.SetToolTip(lblTownFreightHub, "Whether this Town is a Freight Hub, Yes or No. A Freight Hub is usually a town with a Yard that trains originare from to serve other towns.")
        ttpMaintTown.SetToolTip(lblTownServedBy, "The Town where freight trains originate from to serve this Town. If the Town is a Freight Hub, it should be the same name.")
        ttpMaintTown.SetToolTip(lblTownDivision, "The Name of the Division the Town is a part of, or served from. A Town can only belong to one Division.")
        ttpMaintTown.SetToolTip(lblEastOf, "The Name this town is to the East (or North) of. Other valid responses are Staging, or Terminal.")
        ttpMaintTown.SetToolTip(lblWestOf, "The Name this town is to the West (or South) of. Other valid responses are Staging, or Terminal.")
        ttpMaintTown.SetToolTip(lblTownLocal, "Whether the Town actually appears on the layout (Yes), is not modeled but has modeled trains that serve it (Upline), or is not modeled at all (No).")

    End Sub

End Class
