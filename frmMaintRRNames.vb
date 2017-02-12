Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmMaintRRNames

    Private dtRRName As New DataTable
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


    Private Sub GetRRName()

        dtRRName.Clear()

        dtRRName = DataAccess_Get.spGetRRRepMarkList

        dgvRRName.DataSource = dtRRName

        msMode = "Browse"


    End Sub


    Private Sub cmdRRNameNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRRNameNew.Click

        msMode = "New"

        EnableDisableEditFields(True)
        ClearEditFields()

        EnableDisableEditFields(True)
        cmdRRNameNew.BackColor = SystemColors.ActiveCaption
        cmdRRNameSave.BackColor = SystemColors.ButtonHighlight
        cmdRRNameReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdRRNameEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRRNameEdit.Click

        msMode = "Edit"

        If dgvRRName.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdRRNameEdit.BackColor = SystemColors.ActiveCaption
        cmdRRNameSave.BackColor = SystemColors.ButtonHighlight
        cmdRRNameReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdRRNameDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRRNameDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvRRName.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMAarRRDelRec(dgrSelRow.Cells("Railroad").Value.ToString)

        GetRRName()

        'Return to the same place in the grid
        dgvRRName.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdRRNameSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRRNameSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateRRName()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then

            DataAccess_Maintenance.spMAarRRUpdate(PrepStrForQuery(txtRRCode.Text), _
                      PrepStrForQuery(txtRRName.Text), _
                      PrepStrForQuery(txtRepMark.Text), _
                      PrepStrForQuery(dgrSelRow.Cells("Railroad").Value.ToString))

        End If

        If msMode = "New" Then

            DataAccess_Maintenance.spMAarRRIns(PrepStrForQuery(txtRRCode.Text), _
                      PrepStrForQuery(txtRRName.Text), _
                      PrepStrForQuery(txtRepMark.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetRRName()

        'Return to the edited record
        dgvRRName.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdRRNameHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRRNameHelp.Click

    End Sub


    Private Sub cmdRRNameReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRRNameReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"
        EnableDisableEditFields(False)

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtRRCode.Enabled = True
            txtRRName.Enabled = True
            txtRepMark.Enabled = True

        Else
            txtRRCode.Enabled = False
            txtRRName.Enabled = False
            txtRepMark.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtRRCode.Text = ""
        txtRRName.Text = ""
        txtRepMark.Text = ""

    End Sub

    Private Sub dgvRRName_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRRName.CellClick

        'Make the row the cell is in a selected row
        dgrSelRow = dgvRRName.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvRRName.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        'If Not dgrSelRow.Cells Is Nothing Then Exit Sub ' This should probably get deleted CJB 4/9/12
        txtRRCode.Text = dgrSelRow.Cells("AAR").Value.ToString
        txtRRName.Text = dgrSelRow.Cells("Railroad").Value.ToString
        txtRepMark.Text = dgrSelRow.Cells("ReportMark").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdRRNameEdit.BackColor = SystemColors.Control
        cmdRRNameHelp.BackColor = SystemColors.Control
        cmdRRNameNew.BackColor = SystemColors.Control
        cmdRRNameSave.BackColor = SystemColors.Control
        cmdRRNameDelete.BackColor = SystemColors.Control
        cmdRRNameReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateRRName() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0

        If txtRRCode.Text = "" Then
            sStr += "AAR Railroad Code is blank. " & vbNewLine
        End If

        If txtRRName.Text = "" Then
            sStr += "AAR Railroad Name is blank. " & vbNewLine
        End If

        If txtRepMark.Text = "" Then
            sStr += "Railroad Reporting Mark is blank. " & vbNewLine
        End If

        If msMode.ToUpper = "EDIT" Then
            If dgrSelRow.Cells("Railroad").Value = Nothing Then
                sStr += "Selected grid record contains no data to update. Use New process to add records. "
                Return sStr
                Exit Function
            End If

            If txtRRName.Text <> dgrSelRow.Cells("Railroad").Value.ToString Then
                sStr += "Railroad Name was changed, this is not allowed. If the Railroad Name " & _
                    "must be changed, first create a new record with the new name then delete the old record."
            End If

        End If

        Return sStr

    End Function


    Private Sub frmMaintRRNames_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetRRName()

        ttpMaintRRName.SetToolTip(lblAARCode, "The Numeric AAR Code assigned to the selected Railroad.")
        ttpMaintRRName.SetToolTip(lblRRName, "The Name of the Selected Railroad.")
        ttpMaintRRName.SetToolTip(lblRepMark, "The Reporting Marks of the Selected Railroad.")

    End Sub


End Class
