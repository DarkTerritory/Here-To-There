Imports System.Configuration

Public Class frmMaintMyRR

    'Needed for reading and writing to App.Config file
    Private cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(My.Application.Info.AssemblyName + ".exe")
    'Private asSettings As AppSettingsSection = cAppConfig.AppSettings

    Private dtMyRR As DataTable
    Private dtRailroads As DataTable
    Private mbResponse As MsgBoxResult
    Private msMode As String
    Private dgrSelectedRow As New DataGridViewRow
    Private msRailroadID_Selected As String = ""



    Private Sub frmMaintMyRR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set the window Title with the Active RR
        Me.Text = "Maintain - My Railroad (Layout) - " & gsMyRRName

        'Load the My RR Values from the database
        dtMyRR = DataAccess_Get.spGetMyRR()
        dgvRailroads.DataSource = dtMyRR

        RefreshGrid(gsMyRR_ID)

        msMode = "Browse"


    End Sub


    Private Sub cmdAddRR_Click(sender As Object, e As EventArgs) Handles cmdAddRR.Click

        'Enable Controls
        txtMaintMyRRName.Enabled = True
        txtMaintMyRRRepMarks.Enabled = True
        txtMaintMyRRSlogan.Enabled = True
        txtMaintMyRRState.Enabled = True
        txtMaintMyRREra.Enabled = True
        optPrototype.Enabled = True
        OptFreelanced.Enabled = True

        txtMaintMyRRName.Text = ""
        txtMaintMyRRRepMarks.Text = ""
        txtMaintMyRRSlogan.Text = ""
        txtMaintMyRRState.Text = ""
        txtMaintMyRREra.Text = ""
        optPrototype.Checked = False
        OptFreelanced.Checked = True

        cmdDeleteRR.Enabled = False
        cmdEditRR.Enabled = False
        cmdCancel.Enabled = True
        cmdSave.Enabled = True

        msMode = "Add"

    End Sub


    Private Sub cmdEditRR_Click(sender As Object, e As EventArgs) Handles cmdEditRR.Click

        'Enable Controls
        txtMaintMyRRName.Enabled = True
        txtMaintMyRRRepMarks.Enabled = True
        txtMaintMyRRSlogan.Enabled = True
        txtMaintMyRRState.Enabled = True
        txtMaintMyRREra.Enabled = True
        optPrototype.Enabled = True
        OptFreelanced.Enabled = True

        cmdDeleteRR.Enabled = False
        cmdAddRR.Enabled = False
        cmdEditRR.Enabled = False
        cmdCancel.Enabled = True
        cmdSave.Enabled = True

        msMode = "Edit"

    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        'Prompt Are You Sure before Canceling
        mbResponse = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cancel Operation?")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        'Disable Controls
        txtMaintMyRRName.Enabled = False
        txtMaintMyRRRepMarks.Enabled = False
        txtMaintMyRRSlogan.Enabled = False
        txtMaintMyRRState.Enabled = False
        txtMaintMyRREra.Enabled = False
        optPrototype.Enabled = False
        OptFreelanced.Enabled = False

        txtMaintMyRRName.Text = ""
        txtMaintMyRRRepMarks.Text = ""
        txtMaintMyRRSlogan.Text = ""
        txtMaintMyRRState.Text = ""
        txtMaintMyRREra.Text = ""
        optPrototype.Checked = False
        OptFreelanced.Checked = False

        cmdDeleteRR.Enabled = True
        cmdAddRR.Enabled = True
        cmdEditRR.Enabled = True
        cmdCancel.Enabled = False
        cmdSave.Enabled = False

        'Reload Grid
        dgvRailroads.DataSource = dtMyRR
        msMode = "Browse"

    End Sub


    Private Function ValidateFields() As String

        ValidateFields = ""
        If txtMaintMyRRName.Text = "" Or txtMaintMyRRRepMarks.Text = "" Then
            ValidateFields = "The Railroad Name and Reporting Marks must both be filled in. " & vbNewLine

        ElseIf Not IsNumeric(txtMaintMyRREra.Text) Or Len(txtMaintMyRREra.Text) <> 4 Then
            ValidateFields += "The Era must be a numeric value in YYYY (Year) format. " & vbNewLine

        ElseIf optPrototype.Checked = False And OptFreelanced.Checked - False Then
            ValidateFields += "Either the Prototype or Freelance button must be selected. " & vbNewLine

        End If

        If Len(ValidateFields) = 0 Then
            Return ""
        Else
            Return ValidateFields
        End If

    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim sErrors As String = ""
        Dim sPrototype As String
        Dim RetVal As Integer
        Dim sRRNumber As String

        sErrors = ValidateFields()
        If Len(sErrors) > 0 Then
            mbResponse = MsgBox("There were problems trying to save the railroad:" & vbNewLine & sErrors & "Fix the errors and try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error saving Railroad")
            Exit Sub

        End If

        'Get the next available ID Number
        If msMode = "Add" Then
            sRRNumber = CStr(DataAccess_Get.spGetNextMyRRNum + 1)
        Else
            sRRNumber = dtMyRR.Rows(0).Item("RRID").ToString
        End If

        If optPrototype.Checked Then sPrototype = "-1" Else sPrototype = "0"

        If msMode = "Add" Then

            RetVal = DataAccess_Maintenance.spMyRRInsert(sRRNumber, txtMaintMyRRName.Text, txtMaintMyRRRepMarks.Text, txtMaintMyRRSlogan.Text, txtMaintMyRRState.Text, txtMaintMyRREra.Text, sPrototype)
            MsgBox("Saved new railroad.")

        ElseIf msMode = "Edit" Then
            RetVal = DataAccess_Maintenance.spMyRRUpdate(sRRNumber, txtMaintMyRRName.Text, txtMaintMyRRRepMarks.Text, txtMaintMyRRSlogan.Text, txtMaintMyRRState.Text, txtMaintMyRREra.Text, sPrototype)
            MsgBox("Saved railroad changes.")

        End If


        txtMaintMyRRName.Enabled = False
        txtMaintMyRRRepMarks.Enabled = False
        txtMaintMyRRSlogan.Enabled = False
        txtMaintMyRRState.Enabled = False
        txtMaintMyRREra.Enabled = False
        optPrototype.Enabled = False
        OptFreelanced.Enabled = False

        txtMaintMyRRName.Text = ""
        txtMaintMyRRRepMarks.Text = ""
        txtMaintMyRRSlogan.Text = ""
        txtMaintMyRRState.Text = ""
        txtMaintMyRREra.Text = ""
        optPrototype.Checked = False
        OptFreelanced.Checked = False

        cmdDeleteRR.Enabled = True
        cmdAddRR.Enabled = True
        cmdEditRR.Enabled = True
        cmdCancel.Enabled = False
        cmdSave.Enabled = False

        'Reload Grid
        dgvRailroads.DataSource = dtMyRR
        msMode = "Browse"

    End Sub

    Private Sub dgvRailroads_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRailroads.CellDoubleClick

        dgrSelectedRow = dgvRailroads.Rows(e.RowIndex)

        'Get the Railroad ID for the row clicked
        msRailroadID_Selected = dgrSelectedRow.Cells("RRID").Value.ToString
        RefreshGrid(msRailroadID_Selected)

        cmdEditRR.Enabled = True
        cmdDeleteRR.Enabled = True
        cmdAddRR.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        cmdSelect.Enabled = True

    End Sub

    Private Sub RefreshGrid(RRID As String)

        If RRID = "" Then Exit Sub

        txtMaintMyRRName.Text = dtMyRR.Rows(RRID).Item("RRName").ToString
        txtMaintMyRRRepMarks.Text = dtMyRR.Rows(RRID).Item("RRInitials").ToString
        txtMaintMyRRSlogan.Text = dtMyRR.Rows(RRID).Item("RRNickname").ToString
        txtMaintMyRRState.Text = dtMyRR.Rows(RRID).Item("RRState").ToString
        txtMaintMyRREra.Text = dtMyRR.Rows(RRID).Item("RREra").ToString
        If dtMyRR.Rows(RRID).Item("RRPrototype") = "-1" Then optPrototype.Checked = True Else OptFreelanced.Checked = True

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        'Prompt for are you sure you want to change the Railroad?
        mbResponse = MsgBox("Are you sure you want to change the active railroad layout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Changing Active Railroad Layout")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        'Update the Global Railroad ID value and save it to the App.config file
        gsMyRR_ID = dgrSelectedRow.Cells("RRID").Value.ToString
        gsMyRRName = dgrSelectedRow.Cells("RRName").Value.ToString
        gsMyRRInitials = dgrSelectedRow.Cells("RRInitials").Value.ToString

        'Dim settings = System.Configuration.ConfigurationManager.AppSettings
        'settings.set("MyRR_ID", gsMyRR_ID)

        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.AppSettings.Settings("MyRR_ID").Value = gsMyRR_ID
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")


    End Sub

    Private Sub cmdDeleteRR_Click(sender As Object, e As EventArgs) Handles cmdDeleteRR.Click

        Dim Retval As Integer
        Dim sRRNumber As String = ""

        If msRailroadID_Selected = "" Then Exit Sub

        mbResponse = MsgBox("Are you sure you want to DELETE the layout " & dgrSelectedRow.Cells("RRName").Value.ToString & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Railroad Layout?")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        mbResponse = MsgBox("Are you REALLY sure you want to DELETE the layout " & dgrSelectedRow.Cells("RRName").Value.ToString & "?" & vbNewLine & vbNewLine & "There is no going back after this. ALL Data associated with the layout " & dgrSelectedRow.Cells("RRName").Value.ToString &
                            " will be lost.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "FINAL WARNING: DELETING RAILROAD LAYOUT")
        If mbResponse = MsgBoxResult.No Then Exit Sub

        retval = DataAccess_Maintenance.spMyRRDelete(dgrSelectedRow.Cells("RRID").Value.ToString)

        MsgBox("Railroad Deleted. If the deleted railroad was the Active Railroad, be sure to select a different railroad before leaving this screen.")

        ' The record deleted might have been the active RR. If it was, get any other layout and set it as the Active layout, if possible
        sRRNumber = CStr(DataAccess_Get.spGetNextMyRRNum)
        If Len(sRRNumber) > 0 Then
            dtMyRR = DataAccess_Get.spGetMyRR()
            dgvRailroads.DataSource = dtMyRR
            RefreshGrid(sRRNumber)

        End If

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        cmdSelect.Enabled = False
        Me.Close()


    End Sub

End Class
