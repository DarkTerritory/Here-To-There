Public Class WaitCursor
    Implements IDisposable

    Public Sub New()
        Me.SetCursorAllForms(Cursors.WaitCursor)
    End Sub

    Public Sub SetCursorAllForms(ByVal cursor As Cursor)
        Dim frm As Form
        For Each frm In Application.OpenForms
            frm.Cursor = cursor
        Next
    End Sub

    <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")>
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Class must implement Idisposable.Dispose() so that
        ' Using construct may be employed
        Me.SetCursorAllForms(Cursors.Default)
    End Sub



    '    To deploy this class:
    'Create a new class and paste the above code in. Then when you need a wait cursor, insert the following:
    'Using WC As New WaitCursor
    '    ' do your long operation
    '    ' optionally you can change the cursor at any time with e.g.:
    '    WC.SetCursorAllForms(Cursors.Help)
    '    ' complete your long operation
    'End Using


End Class
