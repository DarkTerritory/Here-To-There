Public Class frmMaintInt

    Private dtInt As New DataTable
    Private dtPrimaryRR As New DataTable
    Private dtForeignRR As New DataTable
    Private dtTown1 As New DataTable
    Private dtTown2 As New DataTable
    Private dtOrientation As New DataTable
    Private dtStagingArea As New DataTable
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


    Private Sub GetInt()

        dtInt.Clear()

        dtInt = DataAccess_Get.spGetInterchanges

        dgvInt.DataSource = dtInt

        msMode = "Browse"

    End Sub


    Private Sub cmdIntNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntNew.Click

        EnableDisableEditFields(True)
        ClearEditFields()

        msMode = "New"
        cmdIntNew.BackColor = SystemColors.ActiveCaption
        cmdIntSave.BackColor = SystemColors.ButtonHighlight
        cmdIntReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdIntEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntEdit.Click

        If dgvInt.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdIntEdit.BackColor = SystemColors.ActiveCaption
        cmdIntSave.BackColor = SystemColors.ButtonHighlight
        cmdIntReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdIntDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvInt.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMIntDelRec(dgrSelRow.Cells("intID").Value.ToString)

        GetInt()

        'Return to the same place in the grid
        dgvInt.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdIntSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateInt()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMIntUpdate(cboIntTown.SelectedValue, _
                      cboIntPriRR.SelectedValue, _
                      cboIntForRR.SelectedValue, _
                      cboIntForRRDir.SelectedValue, _
                      cboIntNearestOLInt.SelectedValue & "", _
                      cboIntStagingArea.SelectedValue & "", _
                      PrepStrForQuery(dgrSelRow.Cells("IntID").Value.ToString))

        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMIntInsert(cboIntTown.SelectedValue, _
                      cboIntPriRR.SelectedValue, _
                      cboIntForRR.SelectedValue, _
                      cboIntForRRDir.SelectedValue, _
                      cboIntNearestOLInt.SelectedValue & "", _
                      cboIntStagingArea.SelectedValue & "")

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        EnableDisableEditFields(False)
        msMode = "Browse"

        GetInt()

        'Return to the edited record
        dgvInt.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdIntHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIntHelp.Click

    End Sub

    Private Sub cmdIntReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIntReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            cboIntTown.Enabled = True
            cboIntPriRR.Enabled = True
            cboIntForRR.Enabled = True
            cboIntForRRDir.Enabled = True
            cboIntNearestOLInt.Enabled = True
            cboIntStagingArea.Enabled = True

        Else
            cboIntTown.Enabled = False
            cboIntPriRR.Enabled = False
            cboIntForRR.Enabled = False
            cboIntForRRDir.Enabled = False
            cboIntNearestOLInt.Enabled = False
            cboIntStagingArea.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        cboIntTown.Text = ""
        cboIntPriRR.Text = ""
        cboIntForRR.Text = ""
        cboIntForRRDir.Text = ""
        cboIntNearestOLInt.Text = ""
        cboIntStagingArea.Text = ""


    End Sub

    Private Sub dgvInt_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInt.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvInt.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvInt.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        cboIntTown.Text = dgrSelRow.Cells("IntTown").Value.ToString
        cboIntPriRR.Text = dgrSelRow.Cells("intPrimaryRR").Value.ToString
        cboIntForRR.Text = dgrSelRow.Cells("IntForeignRR").Value.ToString
        cboIntForRRDir.Text = dgrSelRow.Cells("IntForeignRRDir").Value.ToString
        cboIntNearestOLInt.Text = dgrSelRow.Cells("IntNearestOnLineInt").Value.ToString
        cboIntStagingArea.Text = dgrSelRow.Cells("IntStagingArea").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdIntEdit.BackColor = SystemColors.Control
        cmdIntHelp.BackColor = SystemColors.Control
        cmdIntNew.BackColor = SystemColors.Control
        cmdIntSave.BackColor = SystemColors.Control
        cmdIntDelete.BackColor = SystemColors.Control
        cmdIntReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateInt() As String

        Dim sStr As String = ""

        If cboIntTown.Text = "" Then
            sStr += "Town is blank. " & vbNewLine
        End If

        If cboIntPriRR.Text = "" Then
            sStr += "Primary Railroad is blank. " & vbNewLine
        End If

        If cboIntForRR.Text = "" Then
            sStr += "Foreign Railroad is blank. " & vbNewLine
        End If

        If cboIntForRRDir.Text = "" Then
            sStr += "Foreign Railroad Orientation is blank. " & vbNewLine
        End If

        If cboIntNearestOLInt.Text <> "" Then
            MsgBox("You placed the town " & cboIntNearestOLInt.Text & " in the Nearest On-Line " & _
                   "Interchange field. This field is only supposed to be used for Interchanges that " & _
                   "get no direct service from trains that actually run on the layout. " & _
                   "Before adding this value, be sure to read and understand the explanation in the Help file " & _
                   "or unexpected results may occur.", MsgBoxStyle.Information, _
                   "Nearest On-Line Interchange value is nor blank")
        End If

        If cboIntStagingArea.Text = "" Then
            sStr += "Staging Area is blank. " & vbNewLine
        End If

        Return sStr

    End Function


    Private Sub frmMaintDiv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Maintain - Interchanges - " & gsMyRRName

        GetInt()

        dtPrimaryRR = DataAccess_Get.spGetRRRepMarkList
        cboIntPriRR.DataSource = dtPrimaryRR
        cboIntPriRR.DisplayMember = "Railroad"
        cboIntPriRR.ValueMember = "ReportMark"

        dtForeignRR = DataAccess_Get.spGetRRRepMarkList
        cboIntForRR.DataSource = dtForeignRR
        cboIntForRR.DisplayMember = "Railroad"
        cboIntForRR.ValueMember = "ReportMark"

        dtTown1 = DataAccess_Get.spGetTownNameCallSign
        cboIntTown.DataSource = dtTown1
        cboIntTown.DisplayMember = "TownName"
        cboIntTown.ValueMember = "TownCallSign"

        dtTown2 = DataAccess_Get.spGetTownNameCallSign
        cboIntNearestOLInt.DataSource = dtTown2
        cboIntNearestOLInt.DisplayMember = "TownName"
        cboIntNearestOLInt.ValueMember = "TownCallSign"

        dtOrientation = DataAccess_Fill.spFillLookupDT("Orientation")
        cboIntForRRDir.DataSource = dtOrientation
        cboIntForRRDir.DisplayMember = "LkDesc"
        cboIntForRRDir.ValueMember = "LkCode"

        dtStagingArea = DataAccess_Fill.spFillLookupDT("StagingArea")
        cboIntStagingArea.DataSource = dtStagingArea
        cboIntStagingArea.DisplayMember = "LkDesc"
        cboIntStagingArea.ValueMember = "LkCode"

        ttpMaintInt.SetToolTip(lblIntTown, "Name of the town where the Interchange is located.")
        ttpMaintInt.SetToolTip(lblIntPriRR, "Name of the Home Railroad, or the Primary railroad.")
        ttpMaintInt.SetToolTip(lblIntForRRDir, "Name of the Foreign Railroad being Interchanged with.")
        ttpMaintInt.SetToolTip(lblIntForRRDir, "The Direction(s) the Foreign railroad runs in.")
        ttpMaintInt.SetToolTip(lblIntNearestOLInt, "If the Interchange is not Local, the Local (On-Line) Interchange closest to it.")

        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

    End Sub

End Class