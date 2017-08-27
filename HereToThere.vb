Imports System.Data.SQLite
Imports System.IO
Imports System.Configuration

Module HereToThere

    'Public cnHTT As New SQLiteConnection("Data Source=C:\Users\Craig\Documents\Visual Studio 2008\Projects\Here To There\HereToThere.db;Version=3;")
    Public cnHTT As SQLiteConnection

    'Old OLDEB objects
    Public csConnString As String
    Public sMasterRegKey As String

    Public gsKeyPath = "HKEY_CURRENT_USER\Software\AmesvilleShops\HereToThere\"
    Public gsConnStr As String
    Public gsDBPath As String
    Public gsDBName As String
    Public gsAppPath As String
    Public gsRptPath As String
    Public gsHelpPath As String
    Public gsMyRR_ID As String
    Public gsMode As String
    Public gsMyRRName As String
    Public gsMyRRInitials As String

    'Needed for reading and writing to App.Config file
    Private cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(My.Application.Info.AssemblyName + ".exe")
    Private asSettings As AppSettingsSection = cAppConfig.AppSettings



    'Public Const gsMyRRName As String = "Housatonic Railroad"
    'Public Const gsMyRRInitials As String = "HRR"


    Public Sub Housekeeping()

        Dim dtMyRR As DataTable

        gsAppPath = My.Application.Info.DirectoryPath
        Console.WriteLine(gsAppPath)
        Dim appSetting = ConfigurationManager.AppSettings
        gsRptPath = My.Application.Info.DirectoryPath & "\Reports"
        gsHelpPath = My.Application.Info.DirectoryPath & "\Help"
        gsDBPath = Path.GetPathRoot(My.Application.Info.DirectoryPath) & "ProgramData\AmesvilleShops\"
        gsDBName = appSetting("DBName")

        'Build the Connection string
        csConnString = "Data Source=" & gsDBPath & "\" & gsDBName & ";Version=3;"

        cnHTT = New SQLiteConnection(csConnString)
        ' Open the database.
        cnHTT.Open()
        cnHTT.Close()

        gsMyRR_ID = appSetting("MyRR_ID")
        'get the Global Active Railroad settings
        dtMyRR = DataAccess_Get.spGetMyRR(gsMyRR_ID)
        gsMyRRName = dtMyRR.Rows(0).Item("RRName").ToString
        gsMyRRInitials = dtMyRR.Rows(0).Item("RRInitials").ToString

        'TODO: Create a Preferences window to allow users to change the Application values.

    End Sub


    ''Write a setting to the App.Config file
    '   Dim appSetting = ConfigurationManager.AppSettings
    '   appSetting.Settings.Item("TestKey").Value = gsTestValue
    '   cAppConfig.Save(ConfigurationSaveMode.Modified)


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

