Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb

Public Class frmSelectPartner

    Private msCommodity As String
    Private msPartnerShipRecv As String
    Private msStateList As String
    Private dtPartners As New DataTable
    Private dtComm As New DataTable
    Private msQryFilter As String
    Private msSelection(8) As String
    Private msSearchValues(8) As String


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ''Copy the selected partner data back to the calling form
        frmMatchup.msSelectedPartner = msSelection

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub


    Public Sub ShowSelections(ByVal Commodity As String, ByVal ShipRecv As String, Optional ByVal StateList As String = "")

        Dim sCommodity As String

        'When making changes to this procedure, be sure to review the sub ShowLCLTerminals as well
        'which uses similar logic farther down in the code of this form.  

        'Copy the passed values to the module level variables
        If Commodity = "Any" Then
            sCommodity = ""
            msCommodity = "Any"
            msSearchValues(1) = ""
            msStateList = StateList

        ElseIf Mid(Commodity, 1, 3) <> "LCL" Then
            sCommodity = Commodity
            msCommodity = Commodity
            msSearchValues(1) = Commodity
            msStateList = StateList

        Else
            msCommodity = Commodity
            'Override regular processing and show LCL Terminals instead
            ShowLCLTerminals()

            Exit Sub

        End If

        'Search for a partner opposite of the one sent
        If ShipRecv = "Shipper" Then
            msPartnerShipRecv = "Receiver"
        ElseIf ShipRecv = "Receiver" Then
            msPartnerShipRecv = "Shipper"
        Else
            msPartnerShipRecv = "Industry"
        End If

        'Change the window title to Shipper or Receiver depending on what's being looked for
        Me.Text = "Select a " & msPartnerShipRecv

        'Reset all the filters
        cboCommodity.Items.Clear()
        chkOnline.Checked = False
        chkOffline.Checked = True
        chkLCL.Checked = False
        chkShowAny.Checked = False
        cboFilterBy.Text = "No Filter"
        cboFilterByValue.Items.Clear()
        'dgvPartners.Rows.Clear()

        'Copy the Commodity to the Commodity combo box
        cboCommodity.Items.Add(msCommodity)
        cboCommodity.SelectedIndex = 0

        Select Case msPartnerShipRecv
            Case "Shipper"
                optShippers.Checked = True
                msQryFilter = "S"

            Case "Receiver"
                optReceivers.Checked = True
                msQryFilter = "R"

            Case Else
                optAll.Checked = True
                msQryFilter = "I"

        End Select


        'Copy the Commodity to the combo box and get the list of items from the grid.
        dtPartners = DataAccess_Fill.spFillGrid(sCommodity, msQryFilter, StateList)

        dgvPartners.DataSource = dtPartners

    End Sub


    Private Sub SetSearchFilter()

        'Parameter(Assignments)
        'Par1 - Commodity
        'Par2 - ShipRecv
        'Par3 - CLIC Like
        'Par4 - CLIC NOT Like
        'Par5 - Industry Name
        'Par6 - Industry City
        'Par7 - Industry State
        'Par8 - Industry Railroad

        Dim X As Integer

        For X = 0 To 8
            msSearchValues(X) = ""
        Next X


        'Commodity


        If cboCommodity.Text = "Any" Then
            msSearchValues(1) = ""

        ElseIf cboCommodity.Text <> "" Then
            msSearchValues(1) = cboCommodity.Text

        Else
            msSearchValues(1) = msCommodity

        End If

        'if nothing or Any is selected do not filter by Commodity

        'On-line / Off-line

        If chkOnline.Checked = False And chkOffline.Checked = False Then
            MsgBox("No selection for On-Line / Off-Line, defaulting to Off-Line.", MsgBoxStyle.Information, "Search - Default to Off-Line")
            chkOffline.Checked = True

        End If

        If Not (chkOnline.Checked = True And chkOffline.Checked = True) Then

            If chkOffline.Checked = True Then
                msSearchValues(3) = "O/L%"

            Else ' Online checked
                msSearchValues(4) = "O/L%"

            End If
            'If both Online and Offline are checked do not filter by Online / Offline

        End If

        'Shipper or Receiver

        If optShippers.Checked Then
            msSearchValues(2) = "S"

        ElseIf optReceivers.Checked Then
            msSearchValues(2) = "R"

            'if optAll is checked do not filter by ShipRecv

        End If

        'If msStateList is not blank, pre-load the search value with the list.
        'If a specific State is selected by the user it will override the State List. 8/10/2012 CJB
        If msStateList <> "" Then
            msSearchValues(7) = msStateList

        End If

        'Filter By option

        If Not cboFilterBy.Text = "No Filter" Then

            If Trim(cboFilterByValue.Text) <> "" Then

                Select Case cboFilterBy.Text
                    Case "CLIC"
                        msSearchValues(3) = cboFilterByValue.Text & "%"

                    Case "Industry Name"
                        msSearchValues(5) = cboFilterByValue.Text & "%"

                    Case "City"
                        msSearchValues(6) = cboFilterByValue.Text & "%"

                    Case "State"
                        If msQryFilter <> "I" Then
                            msSearchValues(7) = cboFilterByValue.Text & "%"
                        Else
                            msSearchValues(7) = msStateList
                        End If

                    Case "Home Road"
                        msSearchValues(8) = cboFilterByValue.Text & "%"

                End Select

            End If

        End If

    End Sub


    Private Sub dgvPartners_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPartners.CellClick

        If e.RowIndex = -1 Then Exit Sub

        msSelection(0) = dgvPartners.Rows(e.RowIndex).Cells("CLIC").Value & ""
        msSelection(1) = dgvPartners.Rows(e.RowIndex).Cells("IndName").Value & ""
        msSelection(2) = dgvPartners.Rows(e.RowIndex).Cells("IndCity").Value & ""
        msSelection(3) = dgvPartners.Rows(e.RowIndex).Cells("IndState").Value & ""
        msSelection(4) = dgvPartners.Rows(e.RowIndex).Cells("IndRR").Value & ""
        msSelection(5) = dgvPartners.Rows(e.RowIndex).Cells("Commodity").Value & ""
        msSelection(6) = dgvPartners.Rows(e.RowIndex).Cells("ShipRecv").Value & ""
        If Not dgvPartners.Rows(e.RowIndex).Cells("Siding").Value Is DBNull.Value Then
            msSelection(7) = dgvPartners.Rows(e.RowIndex).Cells("Siding").Value & ""
        Else
            msSelection(7) = ""
        End If
        If Not dgvPartners.Rows(e.RowIndex).Cells("Notes").Value Is DBNull.Value Then
            msSelection(8) = dgvPartners.Rows(e.RowIndex).Cells("Notes").Value & ""
        Else
            msSelection(8) = ""
        End If

    End Sub


    Private Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

        dtPartners.Clear()

        SetSearchFilter()

        dtPartners = DataAccess_Fill.spFillGridPlus( _
                               msSearchValues(1), _
                               msSearchValues(2), _
                               msSearchValues(3), _
                               msSearchValues(4), _
                               msSearchValues(5), _
                               msSearchValues(6), _
                               msSearchValues(7), _
                               msSearchValues(8))

        dgvPartners.DataSource = dtPartners

    End Sub


    Public Overloads Function ShowDialog(ByVal Commodity As String, ByVal ShipRecv As String, Optional ByVal StateList As String = "") As String()

        ShowSelections(Commodity, ShipRecv, StateList)

        If MyBase.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Return msSelection
        Else
            Return Nothing
        End If

    End Function


    Private Sub cmdChangeComm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdChangeComm.Click

        dtComm.Clear()

        'TODO: When Stored Proc for Maintain Commodity is written use here to get Commodity names.
        dtComm = DataAccess_Misc.spCommCombo

        cboCommodity.DataSource = dtComm
        cboCommodity.DisplayMember = "CommodityName"

    End Sub


    Private Sub ShowLCLTerminals()

        'this is an override to show LCL Terminals in place of the regular receivers.
        'It is called from ShowSelections. The code is very similar.
        msPartnerShipRecv = "Receiver"

        'Change the window title to Shipper or Receiver depending on what's being looked for
        Me.Text = "Select a " & msPartnerShipRecv

        'Copy the Commodity to the Commodity combo box
        cboCommodity.Items.Add(msCommodity)
        cboCommodity.SelectedIndex = 0

        'Reset all the filters
        cboCommodity.Items.Clear()
        chkOnline.Checked = False
        chkOffline.Checked = True
        cboFilterBy.Text = "No Filter"
        cboFilterByValue.Items.Clear()
        dgvPartners.Rows.Clear()

        optReceivers.Checked = True
        msQryFilter = "R"

        'Copy the Commodity to the combo box and get the list of items from the grid.
        cboCommodity.Items.Add(msCommodity)
        cboCommodity.Text = msCommodity
        dtPartners = DataAccess_Fill.spFillGrid("LCL Terminal", msQryFilter)

        dgvPartners.DataSource = dtPartners

    End Sub


    Private Sub frmSelectPartner_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set Tooltip parameters
        ttpSelPartner.AutoPopDelay = 2000
        ttpSelPartner.ReshowDelay = 500
        ttpSelPartner.InitialDelay = 5000
        ttpSelPartner.SetToolTip(chkLCL, "For loads bound for more than one receiver, place check here to select an LCL terminal instead of a single receiver.")
        ttpSelPartner.SetToolTip(chkShowAny, "When checked, show destinations that will accept Any Load - major distributor, warehouse etc.")

    End Sub


End Class
