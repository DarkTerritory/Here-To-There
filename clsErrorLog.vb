Imports System
Imports System.IO
Imports System.Data
Imports System.Environment

Public Module clsErrorLog

    Private filePath As String
    Private fileStream As FileStream
    Private streamWriter As StreamWriter

    Public Sub OpenFile()

        'Dim strPath As String = My.Computer.FileSystem. & "\HTT_Error.log"
        Dim strPath As String = GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\AmesvilleShops\HTT_Error.log"

        If System.IO.File.Exists(strPath) Then
            fileStream = New FileStream(strPath, FileMode.Append, FileAccess.Write)

        Else
            fileStream = New FileStream(strPath, FileMode.Create, FileAccess.Write)

        End If

        streamWriter = New StreamWriter(fileStream)

    End Sub


    Public Sub WriteLog(ByVal strComments As String)

        OpenFile()
        streamWriter.WriteLine(strComments)
        CloseFile()

    End Sub


    Public Sub CloseFile()

        streamWriter.Close()
        fileStream.Close()

    End Sub

End Module

'Syntax in which to use error log

'Try
'    <datatable> = <DataAccess_Group>.<ProcName>
'Catch ex As Exception
'    WriteLog("Error :" & Date.Today.ToString & " | " & _
'        Me.Name & " | " & "<DataAccess_Group>.<ProcName>" & _
'        " | " & ex.Message)
'    'Stop

'End Try



