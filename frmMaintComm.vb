Public Class frmMaintComm

    'Button BackColor Standard is Control
    'Button Highlight for mode is ButtonHighlight 

    Private dtComm As New DataTable
    Private dtCarType1 As New DataTable
    Private dtCarType2 As New DataTable
    Private dtCarType3 As New DataTable
    Private dtLookup As New DataTable
    Private msPriorityVal As String = ""
    Private dgrSelRow As New DataGridViewRow
    Private msMode As String
    Private miDisplayRecIdx As Int32


    Private Sub GetComms()

        dtComm.Clear()
        dtComm = DataAccess_Maintenance.spMCommFillGrid
        dgvComm.DataSource = dtComm
        msMode = "Browse"

    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", "(New).", "for " & msMode & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub cmdCommNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCommNew.Click

        ClearEditFields()
        EnableDisableEditFields(True)
        GreyOutButtons()

        msMode = "New"
        EnableDisableEditFields(True)
        cmdCommNew.BackColor = SystemColors.ActiveCaption
        cmdCommSave.BackColor = SystemColors.ButtonHighlight
        cmdCommReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdCommEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCommEdit.Click

        If dgvComm.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        EnableDisableEditFields(True)
        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdCommEdit.BackColor = SystemColors.ActiveCaption
        cmdCommSave.BackColor = SystemColors.ButtonHighlight
        cmdCommReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdCommDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCommDelete.Click

        Dim mbResponse As MsgBoxResult

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        'ExeNonQ("DELETE FROM Commodity WHERE CommodityName = '" & dgrSelRow.Cells("CommName").Value.ToString & "';")
        DataAccess_Maintenance.spMCommDelRec(dgrSelRow.Cells("CommName").Value.ToString)
        GetComms()

        'Return to the same place in the grid
        dgvComm.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdCommSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCommSave.Click

        Dim sErrText As String = ""
        Dim sPriority As String = ""
        Dim sCarType1 As String = ""
        Dim sCarType2 As String = ""
        Dim sCarType3 As String = ""


        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateComm()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If cboCommPriority.SelectedIndex = -1 Then
            sPriority = ""
        Else
            sPriority = cboCommPriority.SelectedValue.ToString
        End If

        If cboCommCarType1.SelectedIndex = -1 Then
            sCarType1 = ""
        Else
            sCarType1 = cboCommCarType1.SelectedValue.item(1).ToString
        End If

        If cboCommCarType2.SelectedIndex = -1 Then
            sCarType2 = ""
        Else
            sCarType2 = cboCommCarType2.SelectedValue.item(1).ToString
        End If

        If cboCommCarType3.SelectedIndex = -1 Then
            sCarType3 = ""
        Else
            sCarType3 = cboCommCarType3.SelectedValue.item(1).ToString
        End If

        If msMode.ToUpper = "EDIT" Then

            DataAccess_Maintenance.spMCommUpdate( _
                      IIf(chkUse.Checked = True, "X", ""), _
                      cboCommPriority.SelectedValue, _
                      sCarType1, _
                      sCarType2, _
                      sCarType3, _
                      txtCommNotes.Text, _
                      PrepStrForQuery(txtCommName.Text))

        End If

        If msMode = "New" Then

            DataAccess_Maintenance.spMCommInsert( _
                      IIf(chkUse.Checked = True, "X", ""), _
                      PrepStrForQuery(txtCommName.Text), _
                      cboCommPriority.SelectedValue.ToString, _
                      sCarType1, _
                      sCarType2, _
                      sCarType3, _
                      PrepStrForQuery(txtCommNotes.Text))

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        EnableDisableEditFields(False)
        ClearEditFields()
        msMode = "Browse"

        GetComms()

        'Return to the edited record
        dgvComm.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdCommHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCommHelp.Click

    End Sub


    Private Sub cmdCommReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCommReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        EnableDisableEditFields(False)
        GreyOutButtons()
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            chkUse.Enabled = True
            txtCommName.Enabled = True
            cboCommPriority.Enabled = True
            cboCommCarType1.Enabled = True
            cboCommCarType2.Enabled = True
            cboCommCarType3.Enabled = True
            txtCommNotes.Enabled = True

        Else
            chkUse.Checked = False
            chkUse.Enabled = False
            txtCommName.Enabled = False
            cboCommPriority.Enabled = False
            cboCommCarType1.Enabled = False
            cboCommCarType2.Enabled = False
            cboCommCarType3.Enabled = False
            txtCommNotes.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        chkUse.Checked = False
        txtCommName.Text = ""
        cboCommPriority.Text = ""
        cboCommCarType1.Text = ""
        cboCommCarType2.Text = ""
        cboCommCarType3.Text = ""
        cboCommCarType1.SelectedIndex = -1
        cboCommCarType2.SelectedIndex = -1
        cboCommCarType3.SelectedIndex = -1
        txtCommNotes.Text = ""
        msPriorityVal = ""

    End Sub

    Private Sub dgvComm_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComm.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvComm.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvComm.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        If dgrSelRow.Cells("CommUse").Value.ToString = "X" Then chkUse.Checked = True Else chkUse.Checked = False
        txtCommName.Text = dgrSelRow.Cells("CommodityName").Value.ToString
        cboCommPriority.Text = dgrSelRow.Cells("CommPriority").Value.ToString
        cboCommCarType1.Text = dgrSelRow.Cells("CommAARType1").Value.ToString
        cboCommCarType2.Text = dgrSelRow.Cells("CommAARType2").Value.ToString
        cboCommCarType3.Text = dgrSelRow.Cells("CommAARType3").Value.ToString
        txtCommNotes.Text = dgrSelRow.Cells("CommNotes").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdCommEdit.BackColor = SystemColors.Control
        cmdCommHelp.BackColor = SystemColors.Control
        cmdCommNew.BackColor = SystemColors.Control
        cmdCommSave.BackColor = SystemColors.Control
        cmdCommDelete.BackColor = SystemColors.Control
        cmdCommReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateComm() As String

        Dim sStr As String = ""
        Dim iRtn As Integer = 0
        Dim mbResponse As MsgBoxResult

        If txtCommName.Text = "" Then
            sStr += "Commodity Name is blank. " & vbNewLine
        End If

        If cboCommPriority.SelectedIndex = -1 Then
            sStr += "No selection for Commodity Priority. " & vbNewLine
        End If

        If cboCommCarType1.SelectedIndex = -1 Then
            sStr += "No selection for Car Type 1. " & vbNewLine
        End If

        'If mode = New see if the Commodity Name already exists
        If msMode = "New" Then

            iRtn = DataAccess_Get.spGetCommCount(txtCommName.Text)

            If iRtn > 0 Then
                sStr += "Can't add this, the Commodity already exists." & vbNewLine

            End If

        End If

        'If mode = Edit see if the commodity name changed
        If msMode.ToUpper = "EDIT" Then
            If dgrSelRow.Cells("CommodityName").ToString <> txtCommName.Text Then

                'See if the new name exists
                iRtn = DataAccess_Maintenance.spMCommNameCount(txtCommName.Text)
                'iRtn = ExeScalar("SELECT COUNT(*) FROM Commodity WHERE CommodityName = '" & txtCommName.Text & "';")

                If iRtn = 1 Then
                    mbResponse = MsgBox("You have changed the Commodity Name. The new name is not in the database, do you want to add it? ", MsgBoxStyle.YesNo)
                    If mbResponse = MsgBoxResult.No Then
                        sStr += "Can't edit new Commodity Name. " & vbNewLine
                    Else
                        msMode = "Add"
                    End If

                End If

            End If

        End If

        Return sStr

    End Function


    Private Sub frmMaintComm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GetComms()

        dtCarType1 = DataAccess_Fill.spFillLookupDT("spMCommCarType")
        cboCommCarType1.DataSource = dtCarType1
        cboCommCarType1.DisplayMember = "AARCode"
        'cboCommCarType1.DisplayMember = "AARDesc"
        'cboCommCarType1.ValueMember = "AARCode"

        dtCarType2 = DataAccess_Fill.spFillLookupDT("spMCommCarType")
        cboCommCarType2.DataSource = dtCarType2
        cboCommCarType2.DisplayMember = "AARCode"
        'cboCommCarType2.DisplayMember = "AARDesc"
        'cboCommCarType2.ValueMember = "AARCode"

        dtCarType3 = DataAccess_Fill.spFillLookupDT("spMCommCarType")
        cboCommCarType3.DataSource = dtCarType3
        cboCommCarType3.DisplayMember = "AARCode"
        'cboCommCarType3.DisplayMember = "AARDesc"
        'cboCommCarType3.ValueMember = "AARCode"

        dtLookup = DataAccess_Fill.spFillLookupDT("Priority")
        cboCommPriority.DataSource = dtLookup
        cboCommPriority.DisplayMember = "LkDesc"
        cboCommPriority.ValueMember = "LkCode"

        ttpMaintComm.SetToolTip(lblCommUse, "When Unchecked, the Commodity will be hidden and unavailable for use with waybills.")
        ttpMaintComm.SetToolTip(lblCommName, "The Descriptive Name of the Commodity. Must be only one item.")
        ttpMaintComm.SetToolTip(lblCommPriority, "Describes the speed and urgency with which the Commodity must be moved from here to there.")
        ttpMaintComm.SetToolTip(lblCommCarType1, "The Primary Car Type used to carry the Commodity. This will be the default Car Type when waybills are created.")
        ttpMaintComm.SetToolTip(lblCommCarType2, "The Secondary Car Type used to carry the Commodity, Optional. Will be available for selection as an alternative.")
        ttpMaintComm.SetToolTip(lblCommCarType3, "The Tertiary Car Type used to carry the Commodity, Optional. Will be available for selection as an alternative.")
        ttpMaintComm.SetToolTip(lblCommNotes, "An additional Comment about the Commodity that will appear on the Waybill. Examples: Dangerous, Perishable.")

        ClearEditFields()

    End Sub


End Class
