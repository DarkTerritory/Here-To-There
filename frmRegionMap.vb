Imports System.Windows.Forms

Public Class frmRegionMap

    Private dtRegion As New DataTable

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub frmRegionMap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dtRegion = DataAccess_Get.spGetAarRegions
        cboFromRegion.DataSource = dtRegion
        cboFromRegion.DisplayMember = "AARRegName"
        cboFromRegion.ValueMember = "AARCode"
        cboToRegion.DataSource = dtRegion
        cboToRegion.DisplayMember = "AARRegName"
        cboToRegion.ValueMember = "AARCode"


    End Sub
End Class
