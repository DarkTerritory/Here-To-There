Public Class frmMaintStaging

    Private dtStg As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miStgID As Integer
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


    Private Sub GetStg()

        dtStg.Clear()

        dtStg = DataAccess_Get.spGetStagingAreas

        dgvStg.DataSource = dtStg

        msMode = "Browse"


    End Sub


    Private Sub cmdStgNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStgNew.Click

        EnableDisableEditFields(True)
        ClearEditFields()

        msMode = "New"
        cmdStgNew.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdStgEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStgEdit.Click

        If dgvStg.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdStgEdit.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdStgDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStgDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvStg.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMStagingDelRec(dgrSelRow.Cells("DivNum").Value.ToString) 'TODO: Create this SP

        GetStg()

        'Return to the same place in the grid
        dgvStg.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdStgSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStgSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateStg()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMStagingUpdate(miStgID, PrepStrForQuery(txtStgAreaCode.Text), _
                       PrepStrForQuery(txtStagingDesc.Text))

        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMStagingIns(PrepStrForQuery(txtStgAreaCode.Text), _
                       PrepStrForQuery(txtStagingDesc.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        EnableDisableEditFields(False)
        msMode = "Browse"

        GetStg()

        'Return to the edited record
        dgvStg.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdStgHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStgHelp.Click

    End Sub

    Private Sub cmdStgReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStgReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtStgAreaCode.Enabled = True
            txtStagingDesc.Enabled = True

        Else
            txtStgAreaCode.Enabled = False
            txtStagingDesc.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtStgAreaCode.Text = ""
        txtStagingDesc.Text = ""

    End Sub

    Private Sub dgvStg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStg.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvStg.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvStg.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        miStgID = dgrSelRow.Cells("StgID").Value
        txtStgAreaCode.Text = dgrSelRow.Cells("StagingCode").Value.ToString
        txtStagingDesc.Text = dgrSelRow.Cells("StagingDesc").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdStgEdit.BackColor = SystemColors.Control
        cmdStgHelp.BackColor = SystemColors.Control
        cmdStgNew.BackColor = SystemColors.Control
        cmdStgSave.BackColor = SystemColors.Control
        cmdStgDelete.BackColor = SystemColors.Control
        cmdStgReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateStg() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0
        'Dim mbResponse As MsgBoxResult

        If txtStgAreaCode.Text = "" Then
            sStr += "Staging Area Code is blank. " & vbNewLine
        End If

        If txtStagingDesc.Text = "" Then
            sStr += "Staging Yard Derscription is blank. " & vbNewLine
        End If



        Return sStr

    End Function


    Private Sub frmMaintDiv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Maintain - Staging - " & gsMyRRName

        GetStg()

        ttpMaintStg.SetToolTip(lblStgCode, "The Text Code Value of the Staging Area. Alpha-Numeric, No Spaces permitted.")
        ttpMaintStg.SetToolTip(lblStgName, "The Name or Description of the Staging Area, appears in other parts of the program.")

        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

    End Sub


End Class

