Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmMaintInd

    Private dtInd As New DataTable
    Private dtRailroad As New DataTable
    Private dtShipRecv As New DataTable
    Private dtState As New DataTable
    Private dtComm As New DataTable
    Private dtSiding As New DataTable
    Private dtFreq As New DataTable
    Private dtActive As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private bsSearch As New BindingSource
    Private msMode As String
    Private miDisplayRecIdx As Int32


    Private Sub GetIndustries()

        dtInd.Clear()
        dtInd = DataAccess_Get.spGetIndustries
        dgvInd.DataSource = dtInd
        dgvInd.Refresh()

    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Dim mbresponse As MsgBoxResult

        If msMode.ToUpper = "EDIT" Or msMode.ToUpper = "ADD" Or msMode.ToUpper = "NEW" Then
            mbresponse = MsgBox("You have a record open " & IIf(msMode.ToUpper = "NEW", "(New).", "for " & msMode.ToLower & "ing.") & " Do you really want to abandon your changes?", MsgBoxStyle.YesNo, "Abandon " & msMode & "?")
            If mbresponse = MsgBoxResult.No Then Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub cmdIndNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndNew.Click

        msMode = "New"

        ClearEditFields()
        GreyOutButtons()

        EnableDisableEditFields(True)
        cmdIndNew.BackColor = SystemColors.ActiveCaption
        cmdIndSave.BackColor = SystemColors.ButtonHighlight
        cmdIndReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdIndEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndEdit.Click

        msMode = "Edit"

        If dgvInd.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdIndEdit.BackColor = SystemColors.ActiveCaption
        cmdIndSave.BackColor = SystemColors.ButtonHighlight
        cmdIndReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdIndCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndCopy.Click

        Dim dtCLIC As DataTable
        Dim iClicRecNum As Integer

        msMode = "Copy"

        If dgvInd.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to Copy.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        'If the CLIC is not Off-Line, get the last two digits, find out what the highest CLIC value is
        'For that industry and increment it one higher.
        If Microsoft.VisualBasic.Left(txtIndCLIC.Text, 3) <> "O/L" Then
            dtCLIC = DataAccess_Maintenance.spMIndHighClic(Mid(txtIndCLIC.Text, 1, 5))
            iClicRecNum = CType(Microsoft.VisualBasic.Right(dtCLIC.Rows(0).Item(0).ToString, 2), Integer) + 1
            txtIndCLIC.Text = Mid(txtIndCLIC.Text, 1, 5) & "-" & Format(iClicRecNum, "00")

        End If

        EnableDisableEditFields(True)
        cmdIndEdit.BackColor = SystemColors.ButtonHighlight
        cmdIndSave.BackColor = SystemColors.ButtonHighlight
        cmdIndReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdIndDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvInd.SelectedRows.Count = -1 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMIndDelRec(dgrSelRow.Cells("IndID").Value.ToString)

        GetIndustries()

        'Return to the same place in the grid
        dgvInd.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdIndSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndSave.Click

        Dim sErrText As String = ""
        Dim sOLSiding As String = ""
        Dim sOLFrequency As String = ""
        Dim sOLSpots As String = ""

        If msMode <> "Edit" And msMode <> "New" And msMode <> "Copy" Then Exit Sub

        'If Generate CLIC flag = True and no CLIC value exists, Create one
        If chkAutoGenCLIC.CheckState = CheckState.Checked Then
            txtIndCLIC.Text = GenerateCLICCode(txtIndCity.Text, cboIndState.Text, txtIndName.Text)
        End If

        sErrText = ValidateInd()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then

            sOLSiding = IIf(cboIndSiding.SelectedIndex = -1, "", cboIndSiding.SelectedValue)
            sOLFrequency = IIf(cboIndFrequency.SelectedIndex = -1, "", cboIndFrequency.SelectedValue)
            sOLSpots = IIf(nudSpots.Value.ToString = "0", "", nudSpots.Value.ToString)

            If Mid(txtIndCLIC.Text, 1, 3) = "O/L" Then ' Off-line

                DataAccess_Maintenance.spMIndUpdate(IIf(cboIndActive.SelectedValue = "Y", "X", ""), _
                          PrepStrForQuery(txtIndCLIC.Text), _
                          PrepStrForQuery(txtIndName.Text), _
                          PrepStrForQuery(txtIndCity.Text), _
                          PrepStrForQuery(cboIndState.Text), _
                          cboIndRR.SelectedValue, _
                          cboIndShipRecv.SelectedValue, _
                          PrepStrForQuery(cboIndComm.Text), _
                          PrepStrForQuery(txtIndNotes.Text), _
                          dgrSelRow.Cells("IndID").Value.ToString)

            Else 'On-line

                DataAccess_Maintenance.spMIndUpdateOnLine(IIf(cboIndActive.SelectedValue = "Y", "X", ""), _
                          PrepStrForQuery(txtIndCLIC.Text), _
                          PrepStrForQuery(txtIndName.Text), _
                          PrepStrForQuery(txtIndCity.Text), _
                          PrepStrForQuery(cboIndState.Text), _
                          cboIndRR.SelectedValue, _
                          cboIndShipRecv.SelectedValue, _
                          PrepStrForQuery(cboIndComm.Text), _
                          PrepStrForQuery(txtIndNotes.Text), _
                          sOLSiding, _
                          sOLFrequency, _
                          sOLSpots, _
                          dgrSelRow.Cells("IndID").Value.ToString)

            End If

        End If


        If msMode = "New" Or msMode = "Copy" Then

            If Mid(txtIndCLIC.Text, 1, 3) = "O/L" Then ' Off-line

                DataAccess_Maintenance.spMIndInsert(IIf(cboIndActive.SelectedValue = "Y", "X", ""), _
                          PrepStrForQuery(txtIndCLIC.Text), _
                          PrepStrForQuery(txtIndName.Text), _
                          PrepStrForQuery(txtIndCity.Text), _
                          PrepStrForQuery(cboIndState.Text), _
                          cboIndRR.SelectedValue, _
                          cboIndShipRecv.SelectedValue, _
                          PrepStrForQuery(cboIndComm.Text), _
                          PrepStrForQuery(txtIndNotes.Text))

            Else 'On-line

                DataAccess_Maintenance.spMIndInsertOnLine(IIf(cboIndActive.SelectedValue = "Y", "X", ""), _
                          PrepStrForQuery(txtIndCLIC.Text), _
                          PrepStrForQuery(txtIndName.Text), _
                          PrepStrForQuery(txtIndCity.Text), _
                          PrepStrForQuery(cboIndState.Text), _
                          cboIndRR.SelectedValue, _
                          cboIndShipRecv.SelectedValue, _
                          PrepStrForQuery(cboIndComm.Text), _
                          PrepStrForQuery(txtIndNotes.Text), _
                          cboIndSiding.SelectedValue, _
                          cboIndFrequency.SelectedValue, _
                          nudSpots.Value)

            End If

        End If


        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        EnableDisableEditFields(False)
        msMode = "Browse"

        dtInd.AcceptChanges()

        'Refresh the grid
        GetIndustries()

        'Return to the edited record
        dgvInd.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdIndHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIndHelp.Click

    End Sub


    Private Sub cmdIndReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIndReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        msMode = "Browse"
        GreyOutButtons()

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            cboIndActive.Enabled = True
            txtIndCLIC.Enabled = True
            txtIndName.Enabled = True
            txtIndCity.Enabled = True
            cboIndState.Enabled = True
            cboIndRR.Enabled = True
            cboIndShipRecv.Enabled = True
            cboIndComm.Enabled = True

            If Mid(txtIndCLIC.Text, 1, 3) = "O/L" Then
                cboIndSiding.Enabled = False
                cboIndFrequency.Enabled = False
                nudSpots.Enabled = False
                txtIndNotes.Enabled = False

            Else
                cboIndSiding.Enabled = True
                cboIndFrequency.Enabled = True
                nudSpots.Enabled = True
                txtIndNotes.Enabled = True

            End If


        Else
            cboIndActive.Enabled = False
            txtIndCLIC.Enabled = False
            txtIndName.Enabled = False
            txtIndCity.Enabled = False
            cboIndState.Enabled = False
            cboIndRR.Enabled = False
            cboIndShipRecv.Enabled = False
            cboIndComm.Enabled = False
            cboIndSiding.Enabled = False
            cboIndFrequency.Enabled = False
            nudSpots.Enabled = False
            txtIndNotes.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        cboIndActive.Text = ""
        cboIndActive.SelectedIndex = -1
        txtIndCLIC.Text = ""
        txtIndName.Text = ""
        txtIndCity.Text = ""
        cboIndState.Text = ""
        cboIndRR.Text = ""
        cboIndShipRecv.Text = ""
        cboIndComm.Text = ""
        cboIndSiding.Text = ""
        cboIndFrequency.Text = ""
        nudSpots.Value = 0
        txtIndNotes.Text = ""

    End Sub

    Private Sub dgvind_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInd.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvInd.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvInd.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub


    Private Sub dgvInd_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvInd.CellFormatting

        Dim iColRR As Integer = 6
        Dim iColComm As Integer = 8
        Dim bFound As Boolean = False

        Dim drFoundRows() As DataRow
        Dim Rowz As DataRow

        If e.ColumnIndex = iColComm Then
            Try
                drFoundRows = dtComm.Select("CommodityName LIKE '" & e.Value & "'")

                For Each Rowz In drFoundRows
                    bFound = True
                    Exit For
                Next
            Catch

            End Try

            If bFound = False Then
                dgvInd.Rows(e.RowIndex).Cells(iColComm).Style.ForeColor = Color.Red()

            End If

        End If

        drFoundRows = Nothing
        bFound = False

        If e.ColumnIndex = iColRR Then
            drFoundRows = dtRailroad.Select("Railroad LIKE '" & e.Value & "'")

            For Each Rowz In drFoundRows
                bFound = True
                Exit For
            Next

            If bFound = False Then
                dgvInd.Rows(e.RowIndex).Cells(iColRR).Style.ForeColor = Color.Red()

            End If

        End If

    End Sub


    Private Sub FillEditFields()

        cboIndActive.SelectedValue = IIf(dgrSelRow.Cells("Active").Value.ToString = "X", "Y", "N")
        txtIndCLIC.Text = dgrSelRow.Cells("CLIC").Value.ToString
        txtIndName.Text = dgrSelRow.Cells("IndName").Value.ToString
        txtIndCity.Text = dgrSelRow.Cells("IndCity").Value.ToString
        cboIndState.Text = dgrSelRow.Cells("IndState").Value.ToString
        cboIndRR.Text = dgrSelRow.Cells("Railroad").Value.ToString
        cboIndSiding.Text = dgrSelRow.Cells("Siding").Value.ToString

        If msMode.ToUpper = "EDIT" Then ' Don't fill these values if the Copy option is selected
            cboIndShipRecv.Text = dgrSelRow.Cells("ShipRecv").Value.ToString
            cboIndComm.Text = dgrSelRow.Cells("Commodity").Value.ToString
            cboIndFrequency.Text = dgrSelRow.Cells("Frequency").Value.ToString
            nudSpots.Value = IIf(IsNumeric(dgrSelRow.Cells("Spots").Value.ToString), dgrSelRow.Cells("Spots").Value.ToString, 0)
            txtIndNotes.Text = dgrSelRow.Cells("Notes").Value.ToString
        End If

    End Sub


    Private Sub GreyOutButtons()

        cmdIndEdit.BackColor = SystemColors.Control
        cmdIndHelp.BackColor = SystemColors.Control
        cmdIndNew.BackColor = SystemColors.Control
        cmdIndSave.BackColor = SystemColors.Control
        cmdIndDelete.BackColor = SystemColors.Control
        cmdIndReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateInd() As String

        Dim sStr As String = ""

        'If txtIndCLIC.Text = "" Then
        '    sStr += "CLIC Code is blank. " & vbNewLine
        'End If

        If txtIndName.Text = "" Then
            sStr += "Industry Name is blank. " & vbNewLine
        End If

        If txtIndCity.Text = "" Then
            sStr += "City Name is blank. " & vbNewLine
        End If

        If cboIndState.SelectedIndex = -1 Then
            sStr += "No selection for Industry State. " & vbNewLine
        End If

        If cboIndRR.SelectedIndex = -1 Then
            sStr += "No selection for Industry Home Railroad. " & vbNewLine
        End If

        'Check and see if Railroad Name is recognized
        Dim drFoundRows() As DataRow
        Dim Rowz As DataRow
        Dim bFound As Boolean

        drFoundRows = dtRailroad.Select("Railroad LIKE '" & cboIndRR.Text & "'")

        For Each Rowz In drFoundRows
            bFound = True
            Exit For
        Next

        If bFound = False Then
            sStr += "Railroad is not recognized. Select a valid railroad name from the drop-down list. " & vbNewLine
        End If

        If cboIndShipRecv.SelectedIndex = -1 Then
            sStr += "No selection for Industry Ship/Recv. " & vbNewLine
        End If

        If cboIndComm.SelectedIndex = -1 Then
            sStr += "No selection for Commodity. " & vbNewLine
        End If

        'Check and see if Commodity is recognized
        drFoundRows = Nothing
        bFound = False

        drFoundRows = dtComm.Select("CommodityName LIKE '" & cboIndComm.Text & "'")

        For Each Rowz In drFoundRows
            bFound = True
            Exit For
        Next

        If bFound = False Then
            sStr += "Commodity is not recognized. Select a valid Commodity from the drop-down list. " & vbNewLine
        End If

        If Mid(txtIndCLIC.Text, 1, 3) <> "O/L" Then ' only process for On-Line industries

            If cboIndFrequency.SelectedIndex = -1 Then
                sStr += "No selection for Load Frequency. " & vbNewLine
            End If

            If nudSpots.Value < 0 Or nudSpots.Value > 21 Then
                sStr += "Invalid selection for Spots. Must be greater than 0 and less than 20. " & vbNewLine
            End If

        End If

        Return sStr

    End Function


    Private Sub frmMaintInd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        msMode = "Browse"

        GetIndustries()

        dtActive = DataAccess_Fill.spFillLookupDT("YesNo")
        cboIndActive.DataSource = dtActive
        cboIndActive.DisplayMember = "LkDesc"
        cboIndActive.ValueMember = "LkCode"

        dtState = DataAccess_Maintenance.spMIndStateList
        cboIndState.DataSource = dtState
        cboIndState.DisplayMember = "AARState"

        dtRailroad = DataAccess_Get.spGetRRRepMarkList
        cboIndRR.DataSource = dtRailroad
        cboIndRR.DisplayMember = "Railroad"
        cboIndRR.ValueMember = "ReportMark"

        dtShipRecv = DataAccess_Fill.spFillLookupDT("ShipRecv")
        cboIndShipRecv.DataSource = dtShipRecv
        cboIndShipRecv.DisplayMember = "lkDesc"
        cboIndShipRecv.ValueMember = "LkCode"

        dtComm = DataAccess_Get.spGetAllComms
        cboIndComm.DataSource = dtComm
        cboIndComm.DisplayMember = "CommodityName"

        dtFreq = DataAccess_Fill.spFillLookupDT("Frequency")
        cboIndFrequency.DataSource = dtFreq
        cboIndFrequency.DisplayMember = "LkDesc"
        cboIndFrequency.ValueMember = "LkCode"

        dtSiding = DataAccess_Get.spGetSidings
        cboIndSiding.DataSource = dtSiding
        cboIndSiding.DisplayMember = "SidingNotes"
        cboIndSiding.ValueMember = "SidingID"

        ttpMaintInd.SetToolTip(lblIndActive, "When Unchecked, the Industry/Commodity record will be hidden and unavailable for use.")
        ttpMaintInd.SetToolTip(lblIndCLIC, "A Unique Town/Industry/Commodity identifier. See Help > CLIC Codes for more information.")
        ttpMaintInd.SetToolTip(lblIndName, "The Name of the Industry.")
        ttpMaintInd.SetToolTip(lblIndCity, "The City where the Industry is Located.")
        ttpMaintInd.SetToolTip(lblIndState, "The State where the Industry is located.")
        ttpMaintInd.SetToolTip(lblIndRR, "The Railroad that serves the Industry.")
        ttpMaintInd.SetToolTip(lblIndSR, "Describes whether the Industry is a Shipper or Receiver, or Both, of the selected Commodity.")
        ttpMaintInd.SetToolTip(lblIndComm, "The Name of the Commodity the Industry is a consumer or producer of.")
        ttpMaintInd.SetToolTip(lblIndSiding, "If Local (Served by an actual train), the Siding the Industry is located on.")
        ttpMaintInd.SetToolTip(lblIndFreq, "If Local (Served by an actual train), the Frequency with which the Industry/Commodity is served.")
        ttpMaintInd.SetToolTip(lblIndSpots, "If Local (Served by an actual train), the number of carloads moved when the Industry is served.")
        ttpMaintInd.SetToolTip(lblIndNotes, "If Local (Served by an actual train), Any handling or spotting notes. Examples: Team Track, Freight House.")

        ClearEditFields()

        bsSearch = New BindingSource
        bsSearch.DataSource = dtInd
        bsSearch.DataMember = dtInd.TableName
        bsSearch.Filter = ""

        ''Load the Search Combo
        'With cboSearch.Items

        '    .Add(New CboItemValue("Active?", "Active"))
        '    .Add(New CboItemValue("CLIC", "CLIC"))
        '    .Add(New CboItemValue("Industry Name", "IndName"))
        '    .Add(New CboItemValue("City", "IndCity"))
        '    .Add(New CboItemValue("State", "IndState"))
        '    .Add(New CboItemValue("Railroad", "Railroad"))
        '    .Add(New CboItemValue("Ship/Recv", "ShipRecv"))
        '    .Add(New CboItemValue("Commodity", "Commodity"))
        '    .Add(New CboItemValue("Siding", "Siding"))
        '    .Add(New CboItemValue("Frequency", "Frequency"))
        '    .Add(New CboItemValue("Spots", "Spots"))
        '    .Add(New CboItemValue("Notes", "Notes"))

        'End With






    End Sub


    Private Sub txtIndCLIC_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIndCLIC.LostFocus

        If msMode.ToUpper = "ADD" Then
            If Mid(txtIndCLIC.Text, 1, 3) = "O/L" Then
                cboIndSiding.Enabled = False
                cboIndFrequency.Enabled = False
                nudSpots.Enabled = False
                txtIndNotes.Enabled = False

            End If

        End If

    End Sub



    Private Sub cboIndState_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIndState.LostFocus

        If msMode = "New" Then
            If txtIndCLIC.Text = "" And cboIndState.Text <> "" Then
                txtIndCLIC.Text = "O/L " & cboIndState.Text

            End If

        End If

    End Sub

    Private Function GenerateCLICCode(ByVal IndCity As String, ByVal IndState As String, ByVal IndName As String) As String

        Dim mbResponse As MsgBoxResult
        Dim IndTownCallSign As String = ""

        mbResponse = MsgBox("Is this industry On-Line (Modeled)? Click Yes, or click No if Off-Line.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Industry On-Line or Off-Line?")
        If mbResponse = MsgBoxResult.No Then
            Return "O/L"

        Else
            IndTownCallSign = DataAccess_Get.spGetTownCallSign(IndCity)


            Return DataAccess_Misc.spValidateCLIC(IndName, IndCity)

        End If


    End Function

End Class
