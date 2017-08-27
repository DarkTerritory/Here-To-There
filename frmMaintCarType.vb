Public Class frmMaintCarType

    Private dtCarType As New DataTable
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


    Private Sub GetCarType()

        dtCarType.Clear()

        dtCarType = DataAccess_Get.spGetAARCarType

        dgvCarType.DataSource = dtCarType

        msMode = "Browse"


    End Sub


    Private Sub cmdCarTypeNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarTypeNew.Click

        msMode = "Add"

        EnableDisableEditFields(True)
        ClearEditFields()

        cmdCarTypeNew.BackColor = SystemColors.ActiveCaption
        cmdCarTypeSave.BackColor = SystemColors.ButtonHighlight
        cmdCarTypeReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdCarTypeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarTypeEdit.Click

        msMode = "Edit"

        If dgvCarType.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        EnableDisableEditFields(True)
        FillEditFields()

        cmdCarTypeEdit.BackColor = SystemColors.ActiveCaption
        cmdCarTypeSave.BackColor = SystemColors.ButtonHighlight
        cmdCarTypeReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdCarTypeDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarTypeDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvCarType.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMCarTypeDelRec(dgrSelRow.Cells("ID").Value.ToString)

        GetCarType()

        'Return to the same place in the grid
        dgvCarType.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdCarTypeSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarTypeSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "Add" Then Exit Sub

        sErrText = ValidateCarType()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then

            DataAccess_Maintenance.spMCarTypeUpdate(PrepStrForQuery(txtCarTypeCode.Text), PrepStrForQuery(txtCarTypeDesc.Text), dgrSelRow.Cells("ID").Value.ToString)

        End If

        If msMode.ToUpper = "ADD" Then

            DataAccess_Maintenance.spMCarTypeIns(PrepStrForQuery(txtCarTypeCode.Text), PrepStrForQuery(txtCarTypeDesc.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        EnableDisableEditFields(False)
        ClearEditFields()
        msMode = "Browse"

        GetCarType()

        'Return to the edited record
        dgvCarType.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdCarTypeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarTypeHelp.Click

    End Sub

    Private Sub cmdCarTypeReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCarTypeReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        EnableDisableEditFields(False)
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtCarTypeCode.Enabled = True
            txtCarTypeDesc.Enabled = True

        Else
            txtCarTypeCode.Enabled = False
            txtCarTypeDesc.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtCarTypeCode.Text = ""
        txtCarTypeDesc.Text = ""

    End Sub

    Private Sub dgvCarType_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCarType.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvCarType.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvCarType.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtCarTypeCode.Text = dgrSelRow.Cells("AARCode").Value.ToString
        txtCarTypeDesc.Text = dgrSelRow.Cells("AARDesc").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdCarTypeEdit.BackColor = SystemColors.Control
        cmdCarTypeHelp.BackColor = SystemColors.Control
        cmdCarTypeNew.BackColor = SystemColors.Control
        cmdCarTypeSave.BackColor = SystemColors.Control
        cmdCarTypeDelete.BackColor = SystemColors.Control
        cmdCarTypeReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateCarType() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0

        If txtCarTypeCode.Text = "" Then
            sStr += "AAR Car Type Code is blank. " & vbNewLine
        End If

        If txtCarTypeDesc.Text = "" Then
            sStr += "AAR Car Type Description is blank. " & vbNewLine
        End If

        Return sStr

    End Function


    Private Sub frmMaintCarType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetCarType()

        ttpMaintCarType.SetToolTip(lblCarTypeCode, "The AAR Code for the type of car described.")
        ttpMaintCarType.SetToolTip(lblCarTypeDesc, "The Description of the type of car identified by the AAR Code.")

    End Sub


End Class
