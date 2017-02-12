Imports System
Imports System.Data
Imports System.Data.SQLite
Imports System.IO
Imports Microsoft.Win32
Imports System.Environment

Module HereToThere

    'Public cnHTT As New SQLiteConnection("Data Source=C:\Users\Craig\Documents\Visual Studio 2008\Projects\Here To There\HereToThere.db;Version=3;")
    Public cnHTT As SQLiteConnection

    'Old OLDEB objects
    Public csConnString As String
    Public sMasterRegKey As String

    Public gsKeyPath = "HKEY_CURRENT_USER\Software\AmesvilleShops\HereToThere\"
    Public gsDBPath As String
    Public gsDBName As String
    Public gsAppPath As String
    Public gsRptPath As String
    Public gsMyRR_ID As String
    Public gsMode As String
    Public gsMyRRName As String
    Public gsMyRRInitials As String


    'Public Const gsMyRRName As String = "Housatonic Railroad"
    'Public Const gsMyRRInitials As String = "HRR"


    Public Sub Housekeeping()

        Dim sStr As String

        gsDBPath = Path.GetPathRoot(My.Application.Info.DirectoryPath) & "ProgramData\AmesvilleShops\"
        gsDBName = GetRegValue(gsKeyPath, "DBName")
        sStr = GetRegValue(gsKeyPath, "ConnStr")

        'Build the Connection string
        csConnString = "Data Source=" & gsDBPath & "HereToThere.s3db;Version=3;"

        cnHTT = New SQLiteConnection(csConnString)
        ' Open the database.
        cnHTT.Open()
        cnHTT.Close()

        sStr = GetRegValue(gsKeyPath, "AppPath")
        If sStr = "default" Then gsAppPath = Environment.CurrentDirectory Else gsAppPath = sStr
        sStr = GetRegValue(gsKeyPath, "RptPath")
        If sStr = "default" Then gsRptPath = gsAppPath & "\Reports" Else gsRptPath = sStr
        sStr = GetRegValue(gsKeyPath, "MyRR_ID")
        If sStr = "default" Then gsMyRR_ID = "0" Else gsMyRR_ID = sStr

        'TODO: Create a Preferences window to allow users to change the registry values.


    End Sub

 

    Public Function GetRegValue(ByVal sKeyName As String, ByVal sKeyNameValue As String) As String

        GetRegValue = (My.Computer.Registry.GetValue(sKeyName, sKeyNameValue, "default"))

    End Function


    Public Sub SetRegValue(ByVal sKeyName As String, ByVal sKeyNameValue As String, ByVal sValue As String)

        My.Computer.Registry.SetValue(sKeyName, sKeyNameValue, sValue)

    End Sub


    Public Function PrepStrForQuery(ByVal str As String) As String

        If str <> "" Then str = Replace(str, "'", "''")
        If str Is System.DBNull.Value Then str = ""
        PrepStrForQuery = str

    End Function


    Public Function GetDivisionName(ByVal sTownCallSign As String) As String

        GetDivisionName = DataAccess_Get.spGetDivName(PrepStrForQuery(sTownCallSign))

    End Function


    Public Function GetSidingNotes(ByVal iSidingID As Integer) As String

        GetSidingNotes = DataAccess_Get.spGetSidingNotes(iSidingID)

    End Function

    Public Function GetFreightHub(ByVal sTownCallSign As String) As String

        GetFreightHub = DataAccess_Get.spGetFrtHub(PrepStrForQuery(sTownCallSign))

    End Function

    Public Function GetTownName(ByVal sTownCallSign As String) As String

        GetTownName = DataAccess_Get.spGetTownName(PrepStrForQuery(sTownCallSign))

    End Function


    Public Function GetTownCallSign(ByVal sTownName As String) As String

        GetTownCallSign = DataAccess_Get.spGetTownCallSign(PrepStrForQuery(sTownName))

    End Function


    Public Function GetCarsAllocated(ByVal TrainName As String) As String

        Dim dtAlloc As New DataTable

        dtAlloc = DataAccess_Get.spGetAllocWB4Train(TrainName)

        If dtAlloc.Rows(0).Item(0) Is DBNull.Value Then
            GetCarsAllocated = 0
        Else
            GetCarsAllocated = dtAlloc.Rows(0).Item(0).ToString
        End If

    End Function


    Public Function ReturnAlpha(ByVal sText As String) As Boolean
        'PURPOSE: To return only the alpha characters A-Z or a-z and spaces in a string.
        Dim iTextLen As Integer = Len(sText)
        Dim n As Integer 'loop counter
        Dim sChar As String = ""

        For n = 1 To iTextLen 'from first to last characters
            sChar = Mid(sText, n, 1)
            If IsAlpha(sChar) Then
                ReturnAlpha = True
                Exit For
            End If

        Next
    End Function


    Private Function IsAlpha(ByVal sChr As String) As Boolean

        IsAlpha = sChr Like "[A-Za-z()]"

    End Function


    Public Function GetPrimaryWBSide(ByVal RouteVerso As String) As String

        If RouteVerso = "MTY Return Route" Or "Start at Industry" Then
            Return "A"
        Else ' "Staging Select", "Freight Agent Select"
            Return "B"
        End If

    End Function


    'Public Function FillLookupDt(ByVal sGroup As String) As DataTable

    '    Dim dcLk As New SQLiteCommand("spFillLookupDt", cnHTT)
    '    'Dim dcLk As New MySqlCommand("spFillLookupDt", cnHTT)
    '    dcLk.CommandType = CommandType.StoredProcedure
    '    dcLk.Parameters.AddWithValue("Par1", sGroup)

    '    'Dim daLk As New MySqlDataAdapter(dcLk)
    '    Dim daLk As New SQLiteDataAdapter(dcLk)
    '    Dim dt1 As New DataTable

    '    If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
    '    daLk.Fill(dt1)
    '    If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

    '    Return dt1

    'End Function


    'Public Function FillDtSp(ByVal ProcName As String, _
    '                         Optional ByVal Param1 As String = "ZZZ", _
    '                         Optional ByVal Param2 As String = "ZZZ", _
    '                         Optional ByVal Param3 As String = "ZZZ", _
    '                         Optional ByVal Param4 As String = "ZZZ", _
    '                         Optional ByVal Param5 As String = "ZZZ", _
    '                         Optional ByVal Param6 As String = "ZZZ", _
    '                         Optional ByVal Param7 As String = "ZZZ", _
    '                         Optional ByVal Param8 As String = "ZZZ", _
    '                         Optional ByVal Param9 As String = "ZZZ", _
    '                         Optional ByVal Param10 As String = "ZZZ", _
    '                         Optional ByVal Param11 As String = "ZZZ", _
    '                         Optional ByVal Param12 As String = "ZZZ", _
    '                         Optional ByVal Param13 As String = "ZZZ", _
    '                         Optional ByVal Param14 As String = "ZZZ") As DataTable

    '    'Dim dcLk As New SqlCommand(ProcName, cnHTT)
    '    Dim dcLk As New MySqlClient.MySqlCommand(ProcName, cnHTT)
    '    dcLk.CommandType = CommandType.StoredProcedure
    '    If Param1 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par1", Param1)
    '    If Param2 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par2", Param2)
    '    If Param3 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par3", Param3)
    '    If Param4 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par4", Param4)
    '    If Param5 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par5", Param5)
    '    If Param6 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par6", Param6)
    '    If Param7 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par7", Param7)
    '    If Param8 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par8", Param8)
    '    If Param9 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par9", Param9)
    '    If Param10 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par10", Param10)
    '    If Param11 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par11", Param11)
    '    If Param12 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par12", Param12)
    '    If Param13 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par13", Param13)
    '    If Param14 <> "ZZZ" Then dcLk.Parameters.AddWithValue("Par14", Param14)

    '    Dim daFillDt As New MySqlDataAdapter(dcLk)
    '    Dim dt1 As New DataTable

    '    If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()

    '    daFillDt.Fill(dt1)
    '    If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

    '    Return dt1

    'End Function


    'Public Function ExeScalar_Sp(ByVal ProcName As String, _
    '                            Optional ByVal Param1 As String = "ZZZ", _
    '                            Optional ByVal Param2 As String = "ZZZ", _
    '                            Optional ByVal Param3 As String = "ZZZ", _
    '                            Optional ByVal Param4 As String = "ZZZ") As String
    '    'NOTE: Output Parameter is ALWAYS Param1 (@Par2 in procedure)

    '    Dim sResult As String
    '    Dim cmExeScalar As New MySqlCommand(ProcName, cnHTT)
    '    Dim parReturn As New MySqlParameter("Par2", SqlDbType.VarChar, 100)
    '    Dim Par3 As New MySqlParameter("Par3", SqlDbType.VarChar, 100)
    '    Dim Par4 As New MySqlParameter("Par4", SqlDbType.VarChar, 100)
    '    Dim Par5 As New MySqlParameter("Par5", SqlDbType.VarChar, 100)


    '    cmExeScalar.CommandType = CommandType.StoredProcedure

    '    If Param1 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par1", Param1)

    '    parReturn.Direction = ParameterDirection.Output
    '    cmExeScalar.Parameters.Add(parReturn)

    '    If Param2 <> "ZZZ" Then
    '        cmExeScalar.Parameters.AddWithValue("Par3", Param2)
    '        Par3.Direction = ParameterDirection.Input
    '    End If

    '    If Param3 <> "ZZZ" Then
    '        cmExeScalar.Parameters.AddWithValue("Par4", Param3)
    '        Par4.Direction = ParameterDirection.Input
    '    End If

    '    If Param4 <> "ZZZ" Then
    '        cmExeScalar.Parameters.AddWithValue("Par5", Param4)
    '        Par5.Direction = ParameterDirection.Input
    '    End If

    '    If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
    '    cmExeScalar.ExecuteScalar()
    '    sResult = cmExeScalar.Parameters("Par2").Value.ToString
    '    If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

    '    Return sResult

    'End Function


    'Public Function ExeScalarSp(ByVal ProcName As String, _
    '                     Optional ByVal Param1 As String = "ZZZ", _
    '                     Optional ByVal Param3 As String = "ZZZ", _
    '                     Optional ByVal Param4 As String = "ZZZ", _
    '                     Optional ByVal Param5 As String = "ZZZ", _
    '                     Optional ByVal Param6 As String = "ZZZ", _
    '                     Optional ByVal Param7 As String = "ZZZ", _
    '                     Optional ByVal Param8 As String = "ZZZ", _
    '                     Optional ByVal Param9 As String = "ZZZ", _
    '                     Optional ByVal Param10 As String = "ZZZ", _
    '                     Optional ByVal Param11 As String = "ZZZ", _
    '                     Optional ByVal Param12 As String = "ZZZ", _
    '                     Optional ByVal Param13 As String = "ZZZ", _
    '                     Optional ByVal Param14 As String = "ZZZ") As String

    '    Dim cmExeScalar As New MySqlCommand(ProcName, cnHTT)
    '    cmExeScalar.CommandType = CommandType.StoredProcedure
    '    Dim sResult As String
    '    Dim par2 As New MySqlParameter("Par2", SqlDbType.VarChar, 100)
    '    par2.Direction = ParameterDirection.Output

    '    If Param1 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par1", Param1)
    '    cmExeScalar.Parameters.Add(par2)
    '    'If Param2 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par2", Param2)
    '    If Param3 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par3", Param3)
    '    If Param4 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par4", Param4)
    '    If Param5 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par5", Param5)
    '    If Param6 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par6", Param6)
    '    If Param7 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par7", Param7)
    '    If Param8 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par8", Param8)
    '    If Param9 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par9", Param9)
    '    If Param10 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par10", Param10)
    '    If Param11 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par11", Param11)
    '    If Param12 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par12", Param12)
    '    If Param13 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par13", Param13)
    '    If Param14 <> "ZZZ" Then cmExeScalar.Parameters.AddWithValue("Par14", Param14)

    '    Dim daFillDt As New MySqlDataAdapter(cmExeScalar)

    '    If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
    '    cmExeScalar.ExecuteScalar()
    '    If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

    '    sResult = cmExeScalar.Parameters("Par2").Value.ToString

    '    Return sResult

    'End Function

    'Public Function ExeNonQsp(ByVal ProcName As String, _
    '                         Optional ByVal Param1 As String = "ZZZ", _
    '                         Optional ByVal Param2 As String = "ZZZ", _
    '                         Optional ByVal Param3 As String = "ZZZ", _
    '                         Optional ByVal Param4 As String = "ZZZ", _
    '                         Optional ByVal Param5 As String = "ZZZ", _
    '                         Optional ByVal Param6 As String = "ZZZ", _
    '                         Optional ByVal Param7 As String = "ZZZ", _
    '                         Optional ByVal Param8 As String = "ZZZ", _
    '                         Optional ByVal Param9 As String = "ZZZ", _
    '                         Optional ByVal Param10 As String = "ZZZ", _
    '                         Optional ByVal Param11 As String = "ZZZ", _
    '                         Optional ByVal Param12 As String = "ZZZ", _
    '                         Optional ByVal Param13 As String = "ZZZ", _
    '                         Optional ByVal Param14 As String = "ZZZ", _
    '                         Optional ByVal Param15 As String = "ZZZ", _
    '                         Optional ByVal Param16 As String = "ZZZ", _
    '                         Optional ByVal Param17 As String = "ZZZ", _
    '                         Optional ByVal Param18 As String = "ZZZ", _
    '                         Optional ByVal Param19 As String = "ZZZ", _
    '                         Optional ByVal Param20 As String = "ZZZ", _
    '                         Optional ByVal Param21 As String = "ZZZ", _
    '                         Optional ByVal Param22 As String = "ZZZ", _
    '                         Optional ByVal Param23 As String = "ZZZ", _
    '                         Optional ByVal Param24 As String = "ZZZ", _
    '                         Optional ByVal Param25 As String = "ZZZ", _
    '                         Optional ByVal Param26 As String = "ZZZ", _
    '                         Optional ByVal Param27 As String = "ZZZ", _
    '                         Optional ByVal Param28 As String = "ZZZ", _
    '                         Optional ByVal Param29 As String = "ZZZ") As Boolean

    '    Dim bResult As Boolean = False

    '    Dim cmExeNonQ As New MySqlCommand(ProcName, cnHTT)
    '    cmExeNonQ.CommandType = CommandType.StoredProcedure
    '    If Param1 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par1", Param1)
    '    If Param2 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par2", Param2)
    '    If Param3 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par3", Param3)
    '    If Param4 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par4", Param4)
    '    If Param5 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par5", Param5)
    '    If Param6 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par6", Param6)
    '    If Param7 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par7", Param7)
    '    If Param8 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par8", Param8)
    '    If Param9 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par9", Param9)
    '    If Param10 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par10", Param10)
    '    If Param11 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par11", Param11)
    '    If Param12 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par12", Param12)
    '    If Param13 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par13", Param13)
    '    If Param14 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par14", Param14)
    '    If Param15 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par15", Param15)
    '    If Param16 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par16", Param16)
    '    If Param17 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par17", Param17)
    '    If Param18 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par18", Param18)
    '    If Param19 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par19", Param19)
    '    If Param20 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par20", Param20)
    '    If Param21 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par21", Param21)
    '    If Param22 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par22", Param22)
    '    If Param23 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par23", Param23)
    '    If Param24 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par24", Param24)
    '    If Param25 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par25", Param25)
    '    If Param26 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par26", Param26)
    '    If Param27 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par27", Param27)
    '    If Param28 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par28", Param28)
    '    If Param29 <> "ZZZ" Then cmExeNonQ.Parameters.AddWithValue("Par29", Param29)

    '    If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
    '    bResult = cmExeNonQ.ExecuteNonQuery
    '    If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

    '    bResult = True

    '    Return bResult

    'End Function


    Public Function RandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer

        Dim random As New Random()
        Return random.Next(min, max)

    End Function 'RandomNumber 



    Public Function ReverseRoute(ByVal sRouting As String) As String

        Dim sStr As String
        Dim sName As String = ""
        Dim bTouching As Boolean = True
        Dim X As Integer

        'Loop through the sRouting string backwards,
        'keep any adjacent characters together and copy to output string

        ReverseRoute = ""

        For X = Len(sRouting) To 1 Step -1
            sStr = Mid(sRouting, X, 1)

            If sStr = " " Then bTouching = False Else bTouching = True

            If bTouching Then ' Add letter to name
                sName = sStr & sName
                bTouching = True

            Else 'Copy name to return string
                ReverseRoute += sName & " "
                sName = ""

            End If

        Next

        ReverseRoute += sName

        Return ReverseRoute

    End Function


    Public Function FindDGVRow(ByRef dgv As DataGridView, ByVal CellName As String, ByVal SearchVal As Object) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells.Item(CellName).Value = SearchVal Then
                Return row
            End If
        Next
        Return Nothing
    End Function

End Module

