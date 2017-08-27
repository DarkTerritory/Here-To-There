Public Class frmMaintState

    Private dtState As New DataTable
    Private dtRegion As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miDisplayRecIdx As Int32


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", "(New).", "for " & msMode.ToLower & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub GetState()

        dtState.Clear()

        dtState = DataAccess_Get.spGetAarStates

        dgvState.DataSource = dtState

        msMode = "Browse"


    End Sub


    Private Sub cmdStateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStateNew.Click

        msMode = "New"

        ClearEditFields()
        GreyOutButtons()

        EnableDisableEditFields(True)
        cmdStateNew.BackColor = SystemColors.ActiveCaption
        cmdStateSave.BackColor = SystemColors.ButtonHighlight
        cmdStateReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdStateEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStateEdit.Click

        msMode = "Edit"

        If dgvState.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdStateEdit.BackColor = SystemColors.ActiveCaption
        cmdStateSave.BackColor = SystemColors.ButtonHighlight
        cmdStateReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdStateDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStateDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvState.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record? If this table is incomplete it could cause the program to not work properly.", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMAarStateDelRec(dgrSelRow.Cells("AARState").Value.ToString)

        GetState()

        'Return to the same place in the grid
        dgvState.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdStateSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStateSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateState()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMAarStateUpdate(cboAARRegion.SelectedValue, _
                      PrepStrForQuery(txtStateCode.Text), _
                      PrepStrForQuery(txtStateName.Text), _
                      PrepStrForQuery(dgrSelRow.Cells("AARState").Value.ToString))

        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMAarStateIns(cboAARRegion.SelectedValue, _
                      PrepStrForQuery(txtStateCode.Text), _
                      PrepStrForQuery(txtStateName.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetState()

        'Return to the edited record
        dgvState.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdStateHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStateHelp.Click

    End Sub

    Private Sub cmdStateReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStateReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtStateCode.Enabled = True
            txtStateName.Enabled = True
            cboAARRegion.Enabled = True

        Else
            txtStateCode.Enabled = False
            txtStateName.Enabled = False
            cboAARRegion.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtStateCode.Text = ""
        txtStateName.Text = ""
        cboAARRegion.Text = ""

    End Sub

    Private Sub dgvCarType_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvState.CellClick

        'Make the row the cell is in a selected row
        dgrSelRow = dgvState.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvState.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtStateCode.Text = dgrSelRow.Cells("AARState").Value.ToString
        txtStateName.Text = dgrSelRow.Cells("AARStateName").Value.ToString
        cboAARRegion.Text = dgrSelRow.Cells("AARRegion").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdStateEdit.BackColor = SystemColors.Control
        cmdStateHelp.BackColor = SystemColors.Control
        cmdStateNew.BackColor = SystemColors.Control
        cmdStateSave.BackColor = SystemColors.Control
        cmdStateDelete.BackColor = SystemColors.Control
        cmdStateReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateState() As String

        Dim sStr As String = ""
        Dim iRecCount As Integer

        If txtStateCode.Text = "" Then
            sStr += "AAR State Code is blank. " & vbNewLine
        End If

        If txtStateName.Text = "" Then
            sStr += "AAR State Name is blank. " & vbNewLine
        End If

        If cboAARRegion.Text = "" Then
            sStr += "AAR Region Member not selected. "
        End If

        iRecCount = DataAccess_Maintenance.spMAarStateValdt(txtStateCode.Text)

        If msMode.ToUpper = "ADD" And iRecCount > 0 Then
            sStr += "Can't add this record, another with the same State Code already exists. "
        End If

        If msMode.ToUpper = "EDIT" And iRecCount = 0 Then
            sStr += "Can't Edit this record, No existing entry with the same State Code exists. "
        End If

        Return sStr

    End Function


    Private Sub frmStateRegion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetState()

        dtRegion = DataAccess_Get.spGetAarRegNameCd()

        cboAARRegion.DataSource = dtRegion
        cboAARRegion.DisplayMember = "AARRegName"
        cboAARRegion.ValueMember = "AARCode"

        ttpMaintAARState.SetToolTip(lblStateCode, "The Two-Letter State (or Province) Code Abbreviation for the Selected State.")
        ttpMaintAARState.SetToolTip(lblStateName, "The Name of the Selected State or Province.")
        ttpMaintAARState.SetToolTip(lblAARReg, "The Name of the AAR Region the State belongs in.")

        ClearEditFields()

    End Sub


End Class
