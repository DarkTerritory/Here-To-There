Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Data.OleDb


Public Class frmMaintSiding

    Private dtSiding As New DataTable
    Private dtTown As New DataTable
    Private dtRR As New DataTable
    Private dtSidingFaces As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miDisplayRecIdx As Int32

    'Button BackColor Standard is Control
    'Button Highlight for mode is ButtonHighlight

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", "(New).", "for " & msMode & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub GetSidings()

        dtSiding.Clear()

        dtSiding = DataAccess_Maintenance.spMSidFillGrid
        dgvSiding.DataSource = dtSiding
        msMode = "Browse"


    End Sub


    Private Sub cmdSidNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSidNew.Click

        msMode = "New"

        ClearEditFields()
        GreyOutButtons()

        EnableDisableEditFields(True)
        cmdSidNew.BackColor = SystemColors.ButtonHighlight
        cmdSidSave.BackColor = SystemColors.ButtonHighlight
        cmdSidReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdSidEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSidEdit.Click

        msMode = "EDIT"

        If dgvSiding.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdSidEdit.BackColor = SystemColors.ButtonHighlight
        cmdSidSave.BackColor = SystemColors.ButtonHighlight
        cmdSidReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdSidDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSidDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvSiding.SelectedRows.Count = 0 Then Exit Sub

        If TxtSidNum.Text = "99" Then
            MsgBox("Siding Number 99 is reserved and cannot be deleted.")
            Exit Sub
        End If

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMSidDelRec(dgrSelRow.Cells("SidingID").Value.ToString)

        GetSidings()

        'Return to the same place in the grid
        dgvSiding.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdSidSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSidSave.Click

        Dim sErrText As String = ""

        If msMode.ToUpper <> "EDIT" And msMode.ToUpper <> "NEW" Then Exit Sub

        sErrText = ValidateSiding()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMSidUpdate(PrepStrForQuery(txtSidName.Text), _
                      PrepStrForQuery(TxtSidNum.Text), _
                      cboSidRR.SelectedValue, _
                      cboSidTown.SelectedValue, _
                      nudSidCarLimit.Value.ToString, _
                      cboSidFaces.SelectedValue, _
                      PrepStrForQuery(dgrSelRow.Cells("SidingID").Value.ToString))

        End If

        If msMode = "New" Then

            DataAccess_Maintenance.spMSidInsert(PrepStrForQuery(TxtSidNum.Text), _
                      PrepStrForQuery(txtSidName.Text), _
                      cboSidRR.SelectedValue, _
                      cboSidTown.SelectedValue, _
                      nudSidCarLimit.Value.ToString, _
                      cboSidFaces.SelectedValue)

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        EnableDisableEditFields(False)
        msMode = "Browse"

        GetSidings()

        'Return to the edited record
        dgvSiding.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdSidHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSidHelp.Click

    End Sub


    Private Sub cmdSidReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSidReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtSidName.Enabled = True
            TxtSidNum.Enabled = True
            cboSidRR.Enabled = True
            cboSidTown.Enabled = True
            nudSidCarLimit.Enabled = True
            cboSidFaces.Enabled = True

        Else
            txtSidName.Enabled = False
            TxtSidNum.Enabled = False
            cboSidRR.Enabled = False
            cboSidTown.Enabled = False
            nudSidCarLimit.Enabled = False
            cboSidFaces.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtSidName.Text = ""
        TxtSidNum.Text = ""
        cboSidRR.Text = ""
        cboSidTown.Text = ""
        nudSidCarLimit.Text = ""
        cboSidFaces.Text = ""

    End Sub

    Private Sub dgvSiding_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSiding.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvSiding.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvSiding.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtSidName.Text = dgrSelRow.Cells("SidingNotes").Value.ToString
        TxtSidNum.Text = dgrSelRow.Cells("SidingID").Value.ToString
        cboSidRR.Text = dgrSelRow.Cells("SidingRR").Value.ToString
        cboSidTown.Text = dgrSelRow.Cells("SidingTown").Value.ToString
        nudSidCarLimit.Text = dgrSelRow.Cells("SidingCars").Value.ToString
        cboSidFaces.Text = dgrSelRow.Cells("SidingFaces").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdSidEdit.BackColor = SystemColors.Control
        cmdSidHelp.BackColor = SystemColors.Control
        cmdSidNew.BackColor = SystemColors.Control
        cmdSidSave.BackColor = SystemColors.Control
        cmdSidDelete.BackColor = SystemColors.Control
        cmdSidReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateSiding() As String

        Dim sStr As String = ""

        If txtSidName.Text = "" Then
            sStr += "Siding Name is blank. " & vbNewLine
        End If

        'If TxtSidNum.Text = "" Then
        '    sStr += "Siding Number is blank. " & vbNewLine
        'ElseIf Not IsNumeric(TxtSidNum.Text) Then
        '    sStr += "Siding Number is not numeric. " & vbNewLine
        'ElseIf TxtSidNum.Text = "99" And msMode.ToUpper = "EDIT" Then
        '    sStr += "Siding Number 99 is reserved and cannot be changed. " & vbNewLine
        'End If

        If cboSidRR.SelectedIndex = -1 Then
            sStr += "No selection for Controlling Railroad. " & vbNewLine
        End If

        If cboSidTown.SelectedIndex = -1 Then
            sStr += "No selection for Town. " & vbNewLine
        End If

        If nudSidCarLimit.Text = "" Then
            sStr += "Car Limit is blank. " & vbNewLine
        ElseIf Not IsNumeric(nudSidCarLimit.Text) Then
            sStr += "Car Limit is not numeric. " & vbNewLine
        ElseIf CType(nudSidCarLimit.Text, Integer) <= 0 Then
            sStr += "Car Limit must be greater than zero. " & vbNewLine
        End If

        If cboSidFaces.SelectedIndex = -1 Then
            sStr += "No selection for Siding Faces Direction. " & vbNewLine
        End If

        Return sStr

    End Function


    Private Sub frmMaintSiding_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetSidings()

        dtTown = DataAccess_Maintenance.spMSidTown
        cboSidTown.DataSource = dtTown
        cboSidTown.DisplayMember = "TownName"
        cboSidTown.ValueMember = "TownCallSign"

        dtRR = DataAccess_Maintenance.spMSidAARCode
        cboSidRR.DataSource = dtRR
        cboSidRR.DisplayMember = "Railroad"
        cboSidRR.ValueMember = "ReportMark"

        dtSidingFaces = DataAccess_Fill.spFillLookupDT("SidingFaces")
        cboSidFaces.DataSource = dtSidingFaces
        cboSidFaces.DisplayMember = "LkDesc"
        cboSidFaces.ValueMember = "LkCode"

        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        ttpMaintSiding.SetToolTip(lblSidName, "The descriptive Name of the Siding. Can be industry names or purpose such as Team Track.")
        ttpMaintSiding.SetToolTip(lblSidRR, "The primary railroad the Siding belongs to.")
        ttpMaintSiding.SetToolTip(lblSidTown, "The Name of the Town the Siding is located in.")
        ttpMaintSiding.SetToolTip(lblSidCarLimit, "The maximum number of cars that can be served on the Siding during an operating session.")
        ttpMaintSiding.SetToolTip(lblSidFaces, "The direction the switchpoints face to enter the Siding. If Siding is double-ended, choose Both.")


    End Sub




End Class
