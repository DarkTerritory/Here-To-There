Public Class frmOptions

    Private bOptionsTimerIsOn As Boolean = False

    Private Sub cmdSaveScreenDimensions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveScreenDimensions.Click

        Dim iScreenHeight As Integer
        Dim iScreenWidth As Integer

        'Collect the values in the textbox and validate
        If txtScreenHeight.Text = "" And txtScreenWidth.Text = "" Then MsgBox("Nothing to save! Enter two numeric values separated by a comma (Height, Width)", MsgBoxStyle.Exclamation, "Invalid Values")

        'Parse the two values entered
        If IsNumeric(txtScreenHeight.Text) Then
            iScreenHeight = Trim(txtScreenHeight.Text)

        Else
            MsgBox("The height value could not be understood as numeric. Please check it and try again.", MsgBoxStyle.Exclamation, "Invalid Values")
            Exit Sub

        End If

        If iScreenHeight > Screen.PrimaryScreen.Bounds.Height Then
            MsgBox("The screen height requested is larger than your monitor can display, try again.", MsgBoxStyle.Exclamation, "Invalid Values")
            Exit Sub

        End If

        If IsNumeric(txtScreenWidth.Text) Then
            iScreenWidth = Trim(txtScreenWidth.Text)

        Else
            MsgBox("The width value could not be understood as numeric. Please check it and try again.", MsgBoxStyle.Exclamation, "Invalid Values")
            Exit Sub

        End If

        If iScreenWidth > Screen.PrimaryScreen.Bounds.Width Then
            MsgBox("The screen width requested is larger than your monitor can display, try again.", MsgBoxStyle.Exclamation, "Invalid Values")
            Exit Sub
        End If

        'Set the value of the screen size in the Registry key
        SetRegValue(gsKeyPath, "ScreenHeight", iScreenHeight)
        SetRegValue(gsKeyPath, "ScreenWidth", iScreenWidth)

        'Set the screen size if it isn't already set
        If frmMain.Height <> iScreenHeight Then frmMain.Height = iScreenHeight
        If frmMain.Width <> iScreenWidth Then frmMain.Width = iScreenWidth

        'At end of Save process enable the Options timer
        tmrOptions.Enabled = True
        bOptionsTimerIsOn = True

    End Sub


    Private Sub frmOptions_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If bOptionsTimerIsOn Then Exit Sub
        If bOptionsTimerIsOn = False Then bOptionsTimerIsOn = True

    End Sub


    Private Sub frmOptions_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

        bOptionsTimerIsOn = False

    End Sub


    Private Sub tmrOptions_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrOptions.Tick

        'Main screen size
        If Not txtScreenHeight.Focused Then
            txtScreenHeight.Text = CType(Me.Height, String) & ", " & CType(Me.Width, String)

        End If

    End Sub



End Class