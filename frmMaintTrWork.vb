Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmMaintTrWork

    Private dtWork As New DataTable
    Private dtTrain As New DataTable
    Private dtDir As New DataTable
    Private dtTown As New DataTable
    Private dtSOPU As New DataTable
    Private dtWkInd As New DataTable
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


    Private Sub GetWork()


        dtWork.Clear()
        dtWork = DataAccess_Get.spGetTrainWork(Me.Tag)
        dgvWork.DataSource = dtWork

        EnableDisableEditFields(False)

        msMode = "Browse"


    End Sub


    Private Sub cmdWorkNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWorkNew.Click

        ClearEditFields()
        GreyOutButtons()

        msMode = "New"
        EnableDisableEditFields(True)
        cmdWorkNew.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdWorkEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWorkEdit.Click

        If dgvWork.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        msMode = "Edit"
        EnableDisableEditFields(True)
        cmdWorkEdit.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdWorkDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWorkDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvWork.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMTrWorkDelRec(dgrSelRow.Cells("TrWorkID").Value.ToString)

        GetWork()

        'Return to the same place in the grid
        dgvWork.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdWorkSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWorkSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateTrainWork()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        Try

            If msMode.ToUpper = "EDIT" Then
                DataAccess_Maintenance.spMTrWorkUpdate(nudWorkStop.Value.ToString, _
                          cboWorkDirOfTravel.SelectedValue, _
                          cboWorkTown.SelectedValue, _
                          cboWorkSOPU.SelectedValue, _
                          cboWorkInd.SelectedValue, _
                          PrepStrForQuery(dgrSelRow.Cells("TrWorkID").Value.ToString))

            End If

            If msMode = "New" Then
                DataAccess_Maintenance.spMTrWorkIns(Me.Tag, _
                          nudWorkStop.Value.ToString, _
                          cboWorkDirOfTravel.SelectedValue, _
                          cboWorkTown.SelectedValue, _
                          cboWorkSOPU.SelectedValue, _
                          cboWorkInd.SelectedValue)

            End If

        Catch ex As Exception

            MsgBox("An error occurred when trying to save the data.  Please clear the fields and try again.", MsgBoxStyle.Critical, "Could not Save Data")
            Exit Sub

        End Try

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetWork()

        'Return to the edited record
        dgvWork.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdWorkHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWorkHelp.Click

    End Sub

    Private Sub cmdWorkReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdWorkReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)
        msMode = "Browse"

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvWork.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then

            nudWorkStop.Enabled = True
            cboWorkDirOfTravel.Enabled = True
            cboWorkTown.Enabled = True
            cboWorkSOPU.Enabled = True
            cboWorkInd.Enabled = True

        Else
            nudWorkStop.Enabled = False
            cboWorkDirOfTravel.Enabled = False
            cboWorkTown.Enabled = False
            cboWorkSOPU.Enabled = False
            cboWorkInd.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        nudWorkStop.Value = 0
        cboWorkDirOfTravel.Text = ""
        cboWorkTown.Text = ""
        cboWorkSOPU.Text = ""
        cboWorkInd.Text = ""

    End Sub

    Private Sub dgvWork_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvWork.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvWork.Rows(e.RowIndex)
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvWork.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        nudWorkStop.Value = dgrSelRow.Cells("TrWorkStopNum").Value.ToString
        cboWorkDirOfTravel.Text = dgrSelRow.Cells("TrWorkDirOfTravel").Value.ToString
        cboWorkTown.Text = dgrSelRow.Cells("TrWorkTown").Value.ToString
        cboWorkSOPU.Text = dgrSelRow.Cells("TrWorkSOPU").Value.ToString
        cboWorkInd.Text = dgrSelRow.Cells("TrWorkWorkIndustry").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdWorkEdit.BackColor = SystemColors.Control
        cmdWorkHelp.BackColor = SystemColors.Control
        cmdWorkNew.BackColor = SystemColors.Control
        cmdWorkSave.BackColor = SystemColors.Control
        cmdWorkDelete.BackColor = SystemColors.Control
        cmdWorkReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateTrainWork() As String

        Dim sStr As String = ""
        Dim iVal As Integer = 0

        'These fields nay not be required to go under validation because they come from another edit group (Train)
        'If txtWorkTrainID.Text = "" Then
        '    sStr += "Train ID Number is blank. " & vbNewLine
        'End If

        'If cboWorkTrainName.Text = "" Then
        '    sStr += "Train Name is blank. " & vbNewLine
        'End If

        'If cboWorkTrainDir.Text = "" Then
        '    sStr += "Town State is blank. " & vbNewLine
        'End If

        If nudWorkStop.Value <= 0 Then
            sStr += "Stop Number cannot be less than 1. " & vbNewLine
        End If

        If msMode.ToUpper = "ADD" Then
            iVal = DataAccess_Misc.spValidateTrWork(Me.Tag, nudWorkStop.Value)

            If iVal > 0 Then
                sStr += "Stop Number for this train already exists. Change number and re-try. "
            End If

        End If

        If cboWorkTown.Text = "" Then
            sStr += "Town Name is blank. " & vbNewLine
        End If

        If cboWorkSOPU.Text = "" Then
            sStr += "Sets Out / Picks Up must be Yes (Y) or No (N). " & vbNewLine
        End If

        If cboWorkInd.Text = "" Then
            sStr += "Train Works Local Industries must be Yes (Y) or No (N). " & vbNewLine
        End If

        Return sStr

    End Function


    Private Sub frmMaintTrWork_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtName As DataTable

        GetWork()

        dtName = DataAccess_Get.spGetTrainName(Me.Tag)
        Me.Text = "Maintain Train Work - " & dtName.Rows(0).Item(0).ToString

        dtTown = DataAccess_Get.spGetTownNameCallSign
        If dtTown.Rows.Count > 0 Then
            cboWorkTown.DataSource = dtTown
            cboWorkTown.DisplayMember = "TownName"
            cboWorkTown.ValueMember = "TownCallSign"
        End If

        dtSOPU = DataAccess_Fill.spFillLookupDT("YesNo")
        cboWorkSOPU.DataSource = dtSOPU
        cboWorkSOPU.DisplayMember = "LkDesc"
        cboWorkSOPU.ValueMember = "LkCode"

        dtWkInd = DataAccess_Fill.spFillLookupDT("YesNo")
        cboWorkInd.DataSource = dtWkInd
        cboWorkInd.DisplayMember = "LkDesc"
        cboWorkInd.ValueMember = "LkCode"

        dtDir = DataAccess_Fill.spFillLookupDT("Direction")
        cboWorkDirOfTravel.DataSource = dtDir
        cboWorkDirOfTravel.DisplayMember = "LkDesc"
        cboWorkDirOfTravel.ValueMember = "LkCode"

        'ttpMaintTrainWork.SetToolTip(lblTWName, "The Name of the Train to be assigned a Work Location.")
        ttpMaintTrainWork.SetToolTip(lblTWDir, "The Direction of the Train's movement at the Work Location.")
        ttpMaintTrainWork.SetToolTip(lblTWStop, "The Stop number (start at 1 and increase each stop by 1).")
        ttpMaintTrainWork.SetToolTip(lblTWTown, "The Name of the Town where the Work is to be done.")
        ttpMaintTrainWork.SetToolTip(lblTWSOPU, "Whether the train should Set Out and Pick Up at this Town, Yes or No.")
        ttpMaintTrainWork.SetToolTip(lblTWWorkInd, "Whether the train should Work the Industries at this Town, Yes or No.")

        ClearEditFields()

    End Sub


End Class
