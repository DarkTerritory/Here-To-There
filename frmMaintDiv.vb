Public Class frmMaintDiv

    Private dtDiv As New DataTable
    Private dtDivEndPtEast As New DataTable
    Private dtDivEndPtWest As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miDisplayRecIdx As Int32


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", ".", "for " & msMode & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub GetDiv()

        dtDiv.Clear()

        dtDiv = DataAccess_Get.spGetDivisions

        dgvDiv.DataSource = dtDiv

        msMode = "Browse"


    End Sub


    Private Sub cmdDivNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivNew.Click

        EnableDisableEditFields(True)
        ClearEditFields()

        msMode = "New"
        cmdDivNew.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdDivEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivEdit.Click

        If dgvDiv.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdDivEdit.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdDivDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvDiv.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMDivDelRec(dgrSelRow.Cells("DivNum").Value.ToString)

        GetDiv()

        'Return to the same place in the grid
        dgvDiv.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdDivSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateDiv()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMDivUpdate(PrepStrForQuery(txtDivNum.Text), _
                       PrepStrForQuery(txtDivName.Text), _
                       cboEndPointEast.SelectedValue, _
                       cboEndPointWest.SelectedValue)

        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMDivIns(PrepStrForQuery(txtDivNum.Text), _
                       PrepStrForQuery(txtDivName.Text), _
                       cboEndPointEast.SelectedValue, _
                       cboEndPointWest.SelectedValue)

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        EnableDisableEditFields(False)
        msMode = "Browse"

        GetDiv()

        'Return to the edited record
        dgvDiv.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdDivHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivHelp.Click

    End Sub

    Private Sub cmdDivReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDivReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtDivNum.Enabled = True
            txtDivName.Enabled = True
            cboEndPointEast.Enabled = True
            cboEndPointWest.Enabled = True

        Else
            txtDivNum.Enabled = False
            txtDivName.Enabled = False
            cboEndPointEast.Enabled = False
            cboEndPointWest.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtDivNum.Text = ""
        txtDivName.Text = ""
        cboEndPointEast.Text = ""
        cboEndPointWest.Text = ""

    End Sub

    Private Sub dgvRRName_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDiv.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvDiv.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvDiv.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtDivNum.Text = dgrSelRow.Cells("DivNum").Value.ToString
        txtDivName.Text = dgrSelRow.Cells("DivName").Value.ToString
        cboEndPointEast.Text = dgrSelRow.Cells("DivEndPointEast").Value.ToString
        cboEndPointWest.Text = dgrSelRow.Cells("DivEndPointWest").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdDivEdit.BackColor = SystemColors.Control
        cmdDivHelp.BackColor = SystemColors.Control
        cmdDivNew.BackColor = SystemColors.Control
        cmdDivSave.BackColor = SystemColors.Control
        cmdDivDelete.BackColor = SystemColors.Control
        cmdDivReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateDiv() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0
        Dim mbResponse As MsgBoxResult

        If txtDivNum.Text = "" Then
            sStr += "Division Number is blank. " & vbNewLine
        End If

        If msMode = "New" Then
            iVal = DataAccess_Misc.spValidateDivNum(txtDivNum.Text)
            If iVal > 0 Then
                sStr += "Can't add this record, another with the same division number already exists. "
            End If
        End If

        If msMode.ToUpper = "EDIT" Then
            iVal = DataAccess_Misc.spValidateDivNum(txtDivNum.Text)
            If iVal = 0 Then
                sStr += "Can't Edit this record, No existing entry with the same division number exists. "
            Else
                If dgrSelRow.Cells("DivNum").Value.ToString <> CType(txtDivNum.Text, Integer) Then
                    sStr += "You are trying to change the division number to one that already exists. This is not allowed. Change the value back or choose another value that is not in the table. "
                End If
            End If
        End If

        If txtDivName.Text = "" Then
            sStr += "Division Name is blank. " & vbNewLine
        End If

        If cboEndPointEast.Text = "" Then
            mbResponse = MsgBox("There is no entry for Division End Point East - if this is because you have not entered Town information yet, click Yes. Otherwise, click No.", MsgBoxStyle.YesNo, "Division End Point not selected")
            If mbResponse = MsgBoxResult.Yes Then
                Return sStr
                Exit Function
            Else
                sStr += "End Point East is not selected. " & vbNewLine
            End If
        End If

        If cboEndPointWest.Text = "" Then
            mbResponse = MsgBox("There is no entry for Division End Point West - if this is because you have not entered Town information yet, click Yes. Otherwise, click No.", MsgBoxStyle.YesNo, "Division End Point not selected")
            If mbResponse = MsgBoxResult.Yes Then
                Return sStr
                Exit Function
            Else
                sStr += "End Point West is not selected.  " & vbNewLine
            End If
        End If

        Return sStr

    End Function


    Private Sub frmMaintDiv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Maintain - Divisions - " & gsMyRRName

        GetDiv()

        dtDivEndPtEast = DataAccess_Get.spGetTownNameCallSign
        cboEndPointEast.DataSource = dtDivEndPtEast
        cboEndPointEast.DisplayMember = "TownName"
        cboEndPointEast.ValueMember = "TownCallSign"

        dtDivEndPtWest = DataAccess_Get.spGetTownNameCallSign
        cboEndPointWest.DataSource = dtDivEndPtWest
        cboEndPointWest.DisplayMember = "TownName"
        cboEndPointWest.ValueMember = "TownCallSign"

        ttpMaintDiv.SetToolTip(lblDivNum, "The I.D. Number of the Division. This cannot be changed.")
        ttpMaintDiv.SetToolTip(lblDivName, "The Name of the Division, a continuous section of railroad encompassing two or more towns.")
        ttpMaintDiv.SetToolTip(lblDivEndPointEast, "The Name of the Town at the Eastern- or Northern-most end of the Division.")
        ttpMaintDiv.SetToolTip(lblDivEndPointWest, "The Name of the Town at the Western- or Southern-most end of the Division.")

        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

    End Sub


End Class
