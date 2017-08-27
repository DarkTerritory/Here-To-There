Public Class frmShipOrRecv

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If optShipper.Checked = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.No
        End If
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
