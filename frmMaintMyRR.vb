Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms


Public Class frmMaintMyRR

    'TODO: Add Functionality to display a list of Home Roads, and change the display items depending on what Home road is selected.

    Private dtMyRR As DataTable
    Private dtRailroads As DataTable


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        UpdateMyRR()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub frmMaintMyRR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sPrototype As String

        'ToDo: Code for multiple railroads to be stored, selected

        'Load the My RR Values from the database
        dtMyRR = DataAccess_Get.spGetMyRR(gsMyRR_ID)

        'Load the list of railroads
        dtRailroads = DataAccess_Get.spGetRRRepMarkList
        dgvRailroads.DataSource = dtRailroads
        dgvRailroads.Columns(0).Width = 270
        dgvRailroads.Columns(1).Width = 85

        txtMaintMyRRName.Text = dtMyRR.Rows(0).Item("RRName").ToString
        txtMaintMyRRRepMarks.Text = dtMyRR.Rows(0).Item("RRInitials").ToString
        txtMaintMyRRSlogan.Text = dtMyRR.Rows(0).Item("RRNickname").ToString
        txtMaintMyRRState.Text = dtMyRR.Rows(0).Item("RRState").ToString
        txtMaintMyRREra.Text = dtMyRR.Rows(0).Item("RREra").ToString
        txtMaintMyRROpSessionDate.Text = dtMyRR.Rows(0).Item("RROpSessionDate").ToString
        txtMaintMyRRPPwkDate.Text = dtMyRR.Rows(0).Item("RRPaperworkDate").ToString
        sPrototype = dtMyRR.Rows(0).Item("RRPrototype").ToString
        If sPrototype = "-1" Then optPrototype.Checked = True Else OptFreelanced.Checked = True

    End Sub

    Private Function ValidateMyRR() As String

        Dim sErrText As String = ""

        If txtMaintMyRRName.Text = "" Then sErrText = "Railroad Name cannot be blank. " & vbNewLine
        If txtMaintMyRRRepMarks.Text = "" Then sErrText += "Railroad Reporting Marks cannot be blank. " & vbNewLine
        'Slogan may be blank
        If txtMaintMyRRState.Text = "" Then sErrText += "Railroad State cannot be blank. " & vbNewLine
        If txtMaintMyRREra.Text = "" Then MsgBox("Era is not required, waybill style will default to 1950.")
        'Op Session Date may be blank
        'Paperwork Date may be blank 

        Return sErrText

    End Function

    Private Sub UpdateMyRR()

        Dim sErrText As String = ""
        Dim sUpdateText As String = ""

        sErrText = ValidateMyRR()
        If sErrText <> "" Then
            MsgBox("Railroad information could not be updated because: " & vbNewLine & _
            sErrText & vbNewLine & "Please correct the problems and try to save the information again.")
            Exit Sub
        End If

        'TODO: Change first value below to represent correct railroad ID being updated

        DataAccess_Maintenance.spMyRRUpdate(PrepStrForQuery(gsMyRR_ID), _
                  PrepStrForQuery(txtMaintMyRRName.Text), _
                  PrepStrForQuery(txtMaintMyRRRepMarks.Text), _
                  PrepStrForQuery(txtMaintMyRRSlogan.Text), _
                  PrepStrForQuery(txtMaintMyRRState.Text), _
                  PrepStrForQuery(txtMaintMyRREra.Text), _
                  PrepStrForQuery(txtMaintMyRROpSessionDate.Text), _
                  PrepStrForQuery(txtMaintMyRRPPwkDate.Text), _
                  PrepStrForQuery(IIf(optPrototype.Checked = True, -1, 0)))

    End Sub

End Class
