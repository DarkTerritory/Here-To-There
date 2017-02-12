Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmTrainAssign


    Private dtTrainList As New DataTable
    Private dtTrainWork As New DataTable
    Private dtAssignedWB As New DataTable
    Private dtWBList As New DataTable
    Private drTrainList As DataRow
    Private msTrStopList As String
    Private miTrainID As Integer
    Private bSkipTrainDetailLoad As Boolean = False
    Private mbResponse As DialogResult
    Private msWBIDList As String
    Private miDisplayRecIdx As Int32


    Private Sub FillTrainList()

        Dim dtTrainList As DataTable

        dtTrainList = DataAccess_Get.spGetTrainList

        bSkipTrainDetailLoad = True

        With cboTrainName
            .DataSource = dtTrainList
            .DisplayMember = "TrName"
            .Text = ""
            .SelectedIndex = -1
        End With

        bSkipTrainDetailLoad = False

    End Sub


    Private Sub cboTrainName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTrainName.SelectedValueChanged

        Dim X As Short

        If bSkipTrainDetailLoad Then Exit Sub

        ClearTrainFields()
        dtTrainWork.Clear()
        msWBIDList = ""

        drTrainList = dtTrainList.Rows(cboTrainName.SelectedIndex)

        'Get the Train's Working info 
        miTrainID = drTrainList.Item("TrID")

        'Get the Train's Working data
        dtTrainWork = DataAccess_Misc.spTrAssnGetTrWork(miTrainID)

        'Fill out the train description fields 
        lblTrainClass.Text = drTrainList.Item("trClass").ToString
        lblTrainType.Text = drTrainList.Item("trType").ToString
        lblMaxCars.Text = drTrainList.Item("trMaxCars").ToString

        Select Case drTrainList.Item("trDirection").ToString
            Case "N"
                lblDirection.Text = "North"
            Case "S"
                lblDirection.Text = "South"
            Case "E"
                lblDirection.Text = "East"
            Case "W"
                lblDirection.Text = "West"
        End Select

        Dim iTrWorkRows As Short = dtTrainWork.Rows.Count - 1
        Dim sTownDesc As String = ""
        Dim sTownCode As String = ""

        lblOrigin.Text = GetTownName(dtTrainWork.Rows(0).Item("trWorkTown").ToString)
        lblDestination.Text = GetTownName(dtTrainWork.Rows(iTrWorkRows).Item("trWorkTown").ToString)

        For X = 0 To iTrWorkRows
            sTownDesc = GetTownName(dtTrainWork.Rows(X).Item("trWorkTown").ToString)
            lblTrainStops.Text += sTownDesc
            If X <> iTrWorkRows Then
                lblTrainStops.Text += ", "
            End If

            sTownCode = dtTrainWork.Rows(X).Item("trWorkTown").ToString
            If InStr(msTrStopList, sTownCode) = 0 Then
                sTownCode = "'" & sTownCode & "'"
                msTrStopList += sTownCode
                If X <> iTrWorkRows Then
                    msTrStopList += ", "
                End If

            End If

        Next

        'Remove ", " at the end of the msTrStopList string, if any
        If Mid(msTrStopList, Len(msTrStopList) - 1, 2) = ", " Then
            msTrStopList = Mid(msTrStopList, 1, Len(msTrStopList) - 2)
        End If

        UpdateAssignedGrid(miTrainID)


    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dgvWbAssigned.AutoGenerateColumns = False

        FillTrainList()

    End Sub

    Private Sub ClearTrainFields()

        lblTrainClass.Text = ""
        lblTrainType.Text = ""
        lblTrainClass.Text = ""
        lblTrainType.Text = ""
        lblMaxCars.Text = ""
        lblAllocated.Text = ""
        lblOrigin.Text = ""
        lblDestination.Text = ""
        lblDirection.Text = ""
        lblTrainStops.Text = ""
        msTrStopList = ""

    End Sub


    Private Sub UpdateAssignedGrid(ByVal iTrainID As Integer)

        dtAssignedWB.Clear()

        dtAssignedWB = DataAccess_Misc.spTrAssnUpdAssnGrid(iTrainID)
        dgvWbAssigned.DataSource = dtAssignedWB
        lblAllocated.Text = dtAssignedWB.Rows.Count.ToString

    End Sub


    Private Sub dgvWbAssigned_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvWbAssigned.CellClick

        Dim dgrSelRow As New DataGridViewRow

        If Not dgvWbAssigned.Rows.Count <= 0 Then

            'Make the row the cell is in a selected row
            dgrSelRow = dgvWbAssigned.Rows(e.RowIndex)
            dgrSelRow.Selected = True

            'capture the selected row so we can return to it after editing
            miDisplayRecIdx = dgvWbAssigned.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

        End If

    End Sub


    Private Sub cmdMoveWBUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveWBUp.Click


        If Not dgvWbAssigned.Rows.Count <= 0 Then

            Dim sWbAId As String = ""
            Dim iWbASeqNo As Integer
            Dim sWbBId As String = ""
            Dim iWbBSeqNo As Integer

            sWbAId = dgvWbAssigned.CurrentRow.Cells("WaybillID").Value
            iWbASeqNo = dgvWbAssigned.CurrentRow.Cells("InTrainSeq").Value

            If iWbASeqNo = 1 Then Exit Sub ' Can't go higher than 1
            If dgvWbAssigned.Rows.Count <= 1 Then Exit Sub ' Exit if only one row

            iWbBSeqNo = iWbASeqNo - 1

            Dim dgrFindRow As DataGridViewRow

            dgrFindRow = FindDGVRow(dgvWbAssigned, "InTrainSeq", iWbBSeqNo)
            sWbBId = dgrFindRow.Cells("WaybillID").Value

            MoveWB(sWbAId, iWbASeqNo, sWbBId, iWbBSeqNo)

            UpdateAssignedGrid(miTrainID)

            'Return to the same place in the grid
            dgrFindRow = FindDGVRow(dgvWbAssigned, "InTrainSeq", iWbBSeqNo)
            dgvWbAssigned.CurrentCell = dgrFindRow.Cells(0)
            dgvWbAssigned.CurrentCell.Selected = True

        End If


    End Sub


    Private Sub cmdMoveWBDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMoveWBDown.Click

        If Not dgvWbAssigned.Rows.Count <= 0 Then

            Dim sWbAId As String = ""
            Dim iWbASeqNo As Integer
            Dim sWbBId As String = ""
            Dim iWbBSeqNo As Integer

            sWbAId = dgvWbAssigned.CurrentRow.Cells("WaybillID").Value
            iWbASeqNo = dgvWbAssigned.CurrentRow.Cells("InTrainSeq").Value

            If iWbASeqNo >= dgvWbAssigned.Rows.Count Then Exit Sub ' Can't go lower than last
            If dgvWbAssigned.Rows.Count <= 1 Then Exit Sub ' Exit if only one row

            iWbBSeqNo = iWbASeqNo + 1

            Dim dgrFindRow As DataGridViewRow

            For Each dgrFindRow In dgvWbAssigned.Rows
                If dgrFindRow.Cells("InTrainSeq").Value = iWbBSeqNo Then
                    sWbBId = dgrFindRow.Cells("WaybillID").Value
                    Exit For
                End If
            Next

            MoveWB(sWbAId, iWbASeqNo, sWbBId, iWbBSeqNo)

            UpdateAssignedGrid(miTrainID)

            'Return to the same place in the grid
            dgrFindRow = FindDGVRow(dgvWbAssigned, "InTrainSeq", iWbBSeqNo)
            dgvWbAssigned.CurrentCell = dgrFindRow.Cells(0)
            dgvWbAssigned.CurrentCell.Selected = True

        End If

    End Sub


    Private Sub MoveWB(ByVal AID As String, ByVal ASeqNo As Integer, ByVal BID As String, ByVal BSeqNo As Integer)

        DataAccess_Misc.spTrAssnMoveWB(BSeqNo, AID)
        DataAccess_Misc.spTrAssnMoveWB(ASeqNo, BID)

    End Sub


    'Private Sub dgvWbAssigned_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvWbAssigned.CellFormatting
    '    If e.ColumnIndex = 1 Then
    '        If e.Value Is DBNull.Value Then Exit Sub
    '        Dim strVal As String = CType(e.Value, String)
    '        If strVal = "" Then e.Value = "MTY Request"
    '    End If


    'End Sub


    Private Sub frmTrainAssign_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dtTrainList = DataAccess_Get.spGetTrainList

    End Sub

    Private Sub cndRemoveWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveWB.Click

        If Not dgvWbAssigned.Rows.Count <= 0 Then

            mbResponse = MsgBox("Are you sure you want to remove this waybill from the train and return it to the Catalog?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Remove Waybill From Train?")
            If mbResponse = Windows.Forms.DialogResult.No Then Exit Sub

            DataAccess_Misc.spTrAssnDelWB(dgvWbAssigned.CurrentRow.Cells("WaybillID").Value)

            UpdateAssignedGrid(miTrainID)

        End If

    End Sub


End Class
