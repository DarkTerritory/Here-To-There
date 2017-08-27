Imports System.Data.SQLite

Public Class clsSQLiteDB

    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")>
    <CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Public Shared Function GetDataTable(ByVal SQL As String, ByVal Conn As SQLiteConnection) As DataTable

        Dim dt As New DataTable

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Dim Adpt As New SQLiteDataAdapter(SQL, Conn)
            Adpt.Fill(dt)
            Conn.Close()

        Catch ex As Exception
            WriteLog("Error (GetDataTable):" & Date.Now.ToString & " | " & ex.Message)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            'Stop

        End Try

        Return dt

    End Function


    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")>
    <CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Public Shared Function ExecuteNonQuery(ByVal SQL As String, ByVal Conn As SQLiteConnection) As Integer

        Dim iRowsUpdated As Integer = 0

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Dim cmd As New SQLiteCommand(SQL, Conn)
            iRowsUpdated = cmd.ExecuteNonQuery
            Conn.Close()

        Catch ex As Exception
            WriteLog("Error (ExecNonQuery):" & Date.Now.ToString & " | " & ex.Message)

            MsgBox(ex.Message)

            Stop

            If Conn.State = ConnectionState.Open Then Conn.Close()

        End Try

        Return iRowsUpdated

    End Function


    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")>
    <CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Public Shared Function ExecuteScalar(ByVal SQL As String, ByVal Conn As SQLiteConnection) As String

        Dim sDataValue As String = ""

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Dim cmd As New SQLiteCommand(SQL, Conn)
            sDataValue = cmd.ExecuteScalar
            Conn.Close()


        Catch ex As Exception
            WriteLog("Error (ExecScalar):" & Date.Now.ToString & " | " & ex.Message)

            MsgBox(ex.Message)

            Stop

            If Conn.State = ConnectionState.Open Then Conn.Close()

        End Try

        If Not sDataValue = Nothing Then
            Return sDataValue

        Else
            Return ""

        End If

    End Function


End Class

