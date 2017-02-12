Imports System.Windows.Forms
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmMaintTrain

    Private dtTrain As New DataTable
    Private dtDir As New DataTable
    Private dtType As New DataTable
    Private dtClass As New DataTable
    Private dtScope As New DataTable
    Private dtOrigOL As New DataTable
    Private dtLowPriority As New DataTable
    Private dtStaging As New DataTable
    Private dgrSelRow As New DataGridViewRow
    Private miRowIndex As Integer
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


    Private Sub GetTrains()

        dtTrain.Clear()
        dtTrain = DataAccess_Get.spGetTrains
        dgvTrain.DataSource = dtTrain

        msMode = "Browse"


    End Sub


    Private Sub cmdTrainNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainNew.Click

        msMode = "New"

        EnableDisableEditFields(True)
        ClearEditFields()

        cmdTrainNew.BackColor = SystemColors.ActiveCaption
        cmdTrainSave.BackColor = SystemColors.ButtonHighlight
        cmdTrainReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdTrainEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainEdit.Click

        msMode = "Edit"

        If dgvTrain.SelectedRows.Count = 0 Then
            MsgBox("Select a row in the grid to edit.")
            Exit Sub
        End If

        ClearEditFields()
        GreyOutButtons()
        FillEditFields()

        EnableDisableEditFields(True)
        cmdTrainEdit.BackColor = SystemColors.ActiveCaption
        cmdTrainSave.BackColor = SystemColors.ButtonHighlight
        cmdTrainReset.BackColor = SystemColors.ButtonHighlight

    End Sub


    Private Sub cmdTrainDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainDelete.Click

        Dim mbResponse As MsgBoxResult

        If dgvTrain.SelectedRows.Count = 0 Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to permanently delete this record?", MsgBoxStyle.YesNo)
        If mbResponse = MsgBoxResult.No Then Exit Sub

        DataAccess_Maintenance.spMTrainDelRec(dgrSelRow.Cells("TrID").Value.ToString)

        GetTrains()

        'Return to the same place in the grid
        dgvTrain.FirstDisplayedScrollingRowIndex = miDisplayRecIdx

    End Sub


    Private Sub cmdTrainSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainSave.Click

        Dim sErrText As String = ""

        If msMode <> "Edit" And msMode <> "New" Then Exit Sub

        sErrText = ValidateTrain()
        If sErrText <> "" Then
            MsgBox("Can't save record, there were errors:" & vbNewLine & sErrText & "Please correct the problems and try again.")
            Exit Sub
        End If

        If msMode.ToUpper = "EDIT" Then
            DataAccess_Maintenance.spMTrainUpdate(txtTrainName.Text, _
                      cboTrainDir.SelectedValue, _
                      cboTrainType.SelectedValue, _
                      cboTrainClass.Text, _
                      cboTrainScope.Text, _
                      nudTrainCars.Value.ToString, _
                      nudThruCars.Value.ToString, _
                      cboLowPriority.SelectedValue, _
                      cboTrainOrigOL.SelectedValue, _
                      cboTrainDepartTime.Text, _
                      cboFromStagingArea.SelectedValue, _
                      PrepStrForQuery(txtTrainID.Text))
        End If

        If msMode = "New" Then
            DataAccess_Maintenance.spMTrainIns(PrepStrForQuery(txtTrainName.Text), _
                      cboTrainDir.SelectedValue, _
                      cboTrainType.SelectedValue, _
                      cboTrainClass.Text, _
                      cboTrainScope.Text, _
                      nudTrainCars.Value.ToString, _
                      nudThruCars.Value.ToString, _
                      cboLowPriority.SelectedValue, _
                      cboTrainOrigOL.SelectedValue, _
                      cboTrainDepartTime.Text, _
                      cboFromStagingArea.SelectedValue)

        End If

        'Reset the edit fields and controls
        GreyOutButtons()
        ClearEditFields()
        msMode = "Browse"

        GetTrains()

        'Return to the edited record
        dgvTrain.FirstDisplayedScrollingRowIndex = miDisplayRecIdx


    End Sub


    Private Sub cmdTrainHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainHelp.Click

    End Sub

    Private Sub cmdTrainReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTrainReset.Click

        'Clear the edit fields, set mode to Browse and gray out all buttons.
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)
        msMode = "Browse"

    End Sub


    Private Sub EnableDisableEditFields(ByVal bEnable As Boolean)

        If bEnable = True Then
            txtTrainID.Enabled = False
            txtTrainName.Enabled = True
            cboTrainDir.Enabled = True
            cboTrainType.Enabled = True
            cboTrainClass.Enabled = True
            cboTrainScope.Enabled = True
            nudTrainCars.Enabled = True
            nudThruCars.Enabled = True
            cboLowPriority.Enabled = True
            cboTrainOrigOL.Enabled = True
            cboTrainDepartTime.Enabled = True
            cboFromStagingArea.Enabled = True

        Else
            txtTrainID.Enabled = False
            txtTrainName.Enabled = False
            cboTrainDir.Enabled = False
            cboTrainType.Enabled = False
            cboTrainClass.Enabled = False
            cboTrainScope.Enabled = False
            nudTrainCars.Enabled = False
            nudThruCars.Enabled = False
            cboLowPriority.Enabled = False
            cboTrainOrigOL.Enabled = False
            cboTrainDepartTime.Enabled = False
            cboFromStagingArea.Enabled = False

        End If

    End Sub

    Private Sub ClearEditFields()

        txtTrainID.Text = ""
        txtTrainName.Text = ""
        cboTrainDir.Text = ""
        cboTrainType.Text = ""
        cboTrainClass.Text = ""
        cboTrainScope.Text = ""
        nudTrainCars.Value = 0
        nudThruCars.Value = 0
        cboLowPriority.Text = ""
        cboTrainOrigOL.Text = ""
        cboTrainDepartTime.Text = ""
        cboFromStagingArea.Text = ""

    End Sub

    Private Sub dgvTtrain_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTrain.CellClick

        If e.RowIndex = -1 Then Exit Sub

        'Make the row the cell is in a selected row
        dgrSelRow = dgvTrain.Rows(e.RowIndex)
        miRowIndex = e.RowIndex
        dgrSelRow.Selected = True

        'Reset the edit fields to disabled and the form mode to Browse
        msMode = "Browse"
        ClearEditFields()
        GreyOutButtons()
        EnableDisableEditFields(False)

        'capture the selected row so we can return to it after editing
        miDisplayRecIdx = dgvTrain.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

    End Sub

    Private Sub FillEditFields()

        txtTrainID.Text = dgrSelRow.Cells("TrID").Value.ToString
        txtTrainName.Text = dgrSelRow.Cells("TrName").Value.ToString
        cboTrainDir.Text = dgrSelRow.Cells("TrDirection").Value.ToString
        cboTrainType.Text = dgrSelRow.Cells("TrType").Value.ToString
        cboTrainClass.Text = dgrSelRow.Cells("TrClass").Value.ToString
        cboTrainScope.Text = dgrSelRow.Cells("TrScope").Value.ToString
        nudTrainCars.Value = CType(dgrSelRow.Cells("TrMaxCars").Value.ToString, Integer)
        nudThruCars.Value = CType(dgrSelRow.Cells("TrPctThru").Value.ToString, Integer)
        cboLowPriority.Text = dgrSelRow.Cells("TrAllowLowPriority").Value.ToString
        cboTrainOrigOL.Text = dgrSelRow.Cells("TrOrigOL").Value.ToString
        cboTrainDepartTime.Text = dgrSelRow.Cells("TrDepartTime").Value.ToString
        cboFromStagingArea.Text = dgrSelRow.Cells("TrFromStagingArea").Value.ToString

    End Sub


    Private Sub GreyOutButtons()

        cmdTrainEdit.BackColor = SystemColors.Control
        cmdTrainHelp.BackColor = SystemColors.Control
        cmdTrainNew.BackColor = SystemColors.Control
        cmdTrainSave.BackColor = SystemColors.Control
        cmdTrainDelete.BackColor = SystemColors.Control
        cmdTrainReset.BackColor = SystemColors.Control

    End Sub


    Private Function ValidateTrain() As String

        Dim sStr As String = ""

        'Train ID Is now assigned by the database, this value no longer validated CJB 4/9/2012
        'If txtTrainID.Text = "" Then
        '    sStr += "Train ID Number is blank. " & vbNewLine
        'End If

        If txtTrainName.Text = "" Then
            sStr += "Train Name is blank. " & vbNewLine
        End If

        If cboTrainDir.Text = "" Then
            sStr += "Town State is blank. " & vbNewLine
        End If

        If cboTrainType.Text = "" Then
            sStr += "Train type is blank. " & vbNewLine
        End If

        If cboTrainClass.Text = "" Then
            sStr += "Train Class is blank. " & vbNewLine
        End If

        If cboTrainScope.Text = "" Then
            sStr += "Train Scope is blank. " & vbNewLine
        End If

        If nudTrainCars.Value <= 0 Then
            sStr += "Car Limit must be greater than zero. " & vbNewLine
        End If

        If cboLowPriority.Text = "" Then
            sStr += "Accept Lower Priority Assignments is blank. " & vbNewLine
        End If

        If cboTrainOrigOL.Text = "" Then
            sStr += "Train Originates Off-Line is blank. " & vbNewLine
        End If

        If cboFromStagingArea.Text = "" Then
            sStr += "From Staging Area is blank. " & vbNewLine
        End If

        If cboTrainDepartTime.Text = "" Then
            MsgBox("Departure Time is blank. You may go back and add this later.")
        End If

        Return sStr

    End Function


    Private Sub frmMaintTrain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetTrains()

        dtDir = DataAccess_Fill.spFillLookupDT("Direction")
        cboTrainDir.DataSource = dtDir
        cboTrainDir.DisplayMember = "LkDesc"
        cboTrainDir.ValueMember = "LkCode"

        dtType = DataAccess_Fill.spFillLookupDT("TrainType")
        If dtType.Rows.Count > 0 Then
            cboTrainType.DataSource = dtType
            cboTrainType.DisplayMember = "LkDesc"
            cboTrainType.ValueMember = "LkCode"
        End If

        dtClass = DataAccess_Fill.spFillLookupDT("TrainClass")
        If dtType.Rows.Count > 0 Then
            cboTrainClass.DataSource = dtClass
            cboTrainClass.DisplayMember = "LkDesc"
        End If

        dtScope = DataAccess_Fill.spFillLookupDT("TrainScope")
        If dtType.Rows.Count > 0 Then
            cboTrainScope.DataSource = dtScope
            cboTrainScope.DisplayMember = "LkDesc"
        End If

        dtOrigOL = DataAccess_Fill.spFillLookupDT("YesNo")
        cboTrainOrigOL.DataSource = dtOrigOL
        cboTrainOrigOL.DisplayMember = "LkDesc"
        cboTrainOrigOL.ValueMember = "LkCode"

        dtLowPriority = DataAccess_Fill.spFillLookupDT("YesNo")
        cboLowPriority.DataSource = dtLowPriority
        cboLowPriority.DisplayMember = "LkDesc"
        cboLowPriority.ValueMember = "LkCode"

        dtStaging = DataAccess_Fill.spFillLookupDT("StagingArea")
        cboFromStagingArea.DataSource = dtStaging
        cboFromStagingArea.DisplayMember = "LkDesc"
        cboFromStagingArea.ValueMember = "LkCode"


        ttpMaintTrain.SetToolTip(lblTrainName, "The Name or Number of the Train, used by operators to identify it.")
        ttpMaintTrain.SetToolTip(lblTrainID, "The ID Number of the Train, used to identify the train on Waybill cards.")
        ttpMaintTrain.SetToolTip(lblTrainDir, "The Direction the Train moves in when running.")
        ttpMaintTrain.SetToolTip(lblTrainType, "A description of the Type of Train. Examples: Passenger, Freight.")
        ttpMaintTrain.SetToolTip(lblTrainClass, "The Class of the Train. May be First, Second, Third or Extra.")
        ttpMaintTrain.SetToolTip(lblTrainScope, "The Scope of the train. Examples: Through, Local.")
        ttpMaintTrain.SetToolTip(lblTrainCarLimit, "The maximum number of cars that may be assigned to the train.")
        ttpMaintTrain.SetToolTip(lblPctThru, "Approximate percentage of how much of the train should be made up of through cars.")
        ttpMaintTrain.SetToolTip(lblLowPriority, "Whether the train should accept assignments of lower priority freight, Yes or No.")
        ttpMaintTrain.SetToolTip(lblTrainOriginOL, "Whether the Train originates Off-Line, Yes or No.")
        ttpMaintTrain.SetToolTip(lblTrainDepartTime, "The time or sequence number indicating in what order the train is to be called or run.")
        ttpMaintTrain.SetToolTip(lblFromStagingArea, "The Name of the Staging Area where an Off-Line train comes from. Represents an Off-Line origin and not necessarily a physical yard or track.")

        ClearEditFields()

    End Sub



    Private Sub cmdEditTrainWork_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditTrainWork.Click

        If dgvTrain.SelectedRows.Count = 0 Then

            Dim mbResponse As MsgBoxResult
            mbResponse = MsgBox("No Train Row selected.")
            Exit Sub

        End If

        Dim MDIFrmMaintTrWork As New frmMaintTrWork
        MDIFrmMaintTrWork.MdiParent = frmMain
        MDIFrmMaintTrWork.Tag = dgrSelRow.Cells("TrID").Value
        MDIFrmMaintTrWork.Show()

    End Sub


End Class
