Public Class frmMaintRegion

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


    Private Sub GetRegion()

        dtRegion.Clear()

        dtRegion = DataAccess_Get.spGetAarRegions

        dgvRegion.DataSource = dtRegion

        msMode = "Browse"


    End Sub


    Private Sub cmdRegionNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegionNew.Click

        msMode = "New"

        EnableDisableEditFields(True)
        ClearEditFields()

        cmdRegionNew.BackColor = SystemColors.ActiveCaption
        cmdRegionSave.BackColor = SystemColors.ButtonHighlight
        cmdRegionReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdRegionEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegionEdit.Click

        msMode = "Edit"

        If dgvRegion.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdRegionEdit.BackColor = SystemColors.ActiveCaption
        cmdRegionSave.BackColor = SystemColors.ButtonHighlight
        cmdRegionReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdRegionDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegionDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvRegion.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record? If this table is incomplete it could cause the program to not work properly.", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMAarRegNameDelRec(dgrSelRow.Cells("AARCode").Value.ToString)

        GetRegion()

        'Return to the same place in the grid
        dgvRegion.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdRegionSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegionSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateCarType()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMAarRegNameUpdate(PrepStrForQuery(txtRegionCode.Text), PrepStrForQuery(txtRegionName.Text))

        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMAarRegNameIns(PrepStrForQuery(txtRegionCode.Text), PrepStrForQuery(txtRegionName.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetRegion()

        'Return to the edited record
        dgvRegion.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdRegionHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegionHelp.Click

    End Sub

    Private Sub cmdRegionReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRegionReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtRegionCode.Enabled = True
            txtRegionName.Enabled = True

        Else
            txtRegionCode.Enabled = False
            txtRegionName.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtRegionCode.Text = ""
        txtRegionName.Text = ""

    End Sub

    Private Sub dgvRegion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRegion.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvRegion.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvRegion.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtRegionCode.Text = dgrSelRow.Cells("AARCode").Value.ToString
        txtRegionName.Text = dgrSelRow.Cells("AARRegName").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdRegionEdit.BackColor = SystemColors.Control
        cmdRegionHelp.BackColor = SystemColors.Control
        cmdRegionNew.BackColor = SystemColors.Control
        cmdRegionSave.BackColor = SystemColors.Control
        cmdRegionDelete.BackColor = SystemColors.Control
        cmdRegionReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateCarType() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0

        If txtRegionCode.Text = "" Then
            sStr += "AAR Region Code is blank. " & vbNewLine
        End If

        If txtRegionName.Text = "" Then
            sStr += "AAR Region Name is blank. " & vbNewLine
        End If

        If msMode = "New" Then
            iVal = DataAccess_Misc.spValidateRegCode(txtRegionCode.Text)
            If iVal > 0 Then
                sStr += "Can't add this record, another with the same AAR Code already exists. "
            End If
        End If

        If msMode.ToUpper = "EDIT" Then
            iVal = DataAccess_Misc.spValidateRegCode(txtRegionCode.Text)
            If iVal = 0 Then
                sStr += "Can't Edit this record, No existing entry with the same AAR Code exists. "
            Else
                If dgrSelRow.Cells("AARCode").Value.ToString <> CType(txtRegionCode.Text, Integer) Then
                    sStr += "You are trying to change the Region Code to one that already exists. This is not allowed. Change the value back or choose another value that is not in the table. "
                End If
            End If
        End If

        Return sStr

    End Function


    Private Sub frmMaintRegion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetRegion()

        ttpMaintRegion.SetToolTip(lblRegCode, "The Name of the AAR Region.")
        ttpMaintRegion.SetToolTip(lblRegName, "The Name of the Railroad that serves that AAR Region.")

    End Sub

End Class
