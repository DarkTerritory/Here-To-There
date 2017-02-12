Imports System.Data.SQLite

Module DataAccess_Waybill



    Public Function spWBPrintGetLoadWBPage() As DataTable

        Dim sSQL As String = "SELECT LoadID AS iPrintPage FROM WBLoadPrintPage ORDER BY LoadID ASC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBPrintGetMTYWBPage() As DataTable

        Dim sSQL As String = "SELECT MTYID AS iPrintPage FROM WBMTYPrintPage ORDER BY MTYID ASC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewClearPages() As Integer

        Dim sSQL As String = "DELETE FROM WBLoadPrintPage;"
        clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)
        sSQL = "DELETE FROM WBMTYPrintPage;"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spWBViewGetFinishedWB(ByRef PrintPage As String) As DataTable

        Dim sSQL As String = "SELECT wb.WbCarType, wb.wbComm, wb.wbNotes, wb.wbPrimarySR, rr1.Railroad AS PriRR, " & _
            "rr1.AAR AS PriAARCode, rr1.ReportMark AS PriRRMark, wb.PriInd, wb.PriCity, wb.PriState, wb.PriCLIC, " & _
            "rr2.Railroad AS SecRR, rr2.AAR AS SecAARCode, rr2.ReportMark AS SecRRMark, wb.SecInd, wb.SecCity, " & _
            "wb.SecState, wb.SecCLIC, wb.RouteIntOnWith, wb.RouteIntOnAt, wb.RouteIntOffWith, wb.RouteIntOffAt, " & _
            "wb.RouteIntVia, wb.RouteVerso, wb.TrainAssignment, wb.InTrainSeq, wb.PrintPage, wb.PrintPageSeq, " & _
            "wb.PrintSerialNum, wb.PrintLoadSide1, wb.PrintMTYForHome " & _
            "FROM (Waybill AS wb INNER JOIN AARRRCode AS rr1 ON wb.PriRR = rr1.ReportMark) " & _
            "INNER JOIN AARRRCode AS rr2 ON wb.SecRR = rr2.ReportMark " & _
            "WHERE wb.PrintPage = '" & PrintPage & "' " & _
            "AND wb.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY wb.PrintPageSeq ASC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewGetLoadWBPage(ByVal LoadID As String) As DataTable

        Dim sSQL As String = "SELECT * FROM WBLoadPrintPage WHERE LoadID = '" & LoadID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewGetMTYWBPage(ByVal MTYID As String) As DataTable

        Dim sSQL As String = "SELECT * FROM WBMTYPrintPage WHERE MTYID = '" & MTYID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewGetRawWB(ByVal WaybillID As String) As DataTable

        Dim sSQL As String = "SELECT WaybillID, wbPrimarySR, PriCLIC, SecCLIC, RouteVerso, TrainAssignment, " & _
            "CASE InTrainSeq WHEN NULL THEN 0 ELSE InTrainSeq END AS InTrainSeq FROM Waybill WHERE WaybillID = '" & WaybillID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewLoadPrintPage(ByVal Pos As String, ByVal PriRR As String, ByVal PriAARCode As String, _
                                          ByVal PriInd As String, ByVal PriCity As String, ByVal PriState As String, _
                                          ByVal Comm As String, ByVal SecInd As String, ByVal SecCity As String, _
                                          ByVal SecState As String, ByVal CarType As String, ByVal Routing As String, _
                                          ByVal Via As String, ByVal Notes As String, ByVal PrintLoadSide1 As String, _
                                          ByVal SerialNum As String, ByVal LoadID As String, ByVal MTYPriRR As String, _
                                          ByVal MTYForHome As String, ByVal IndAgent As String, ByVal Location As String, _
                                          ByVal MTYCarType As String, ByVal MTYRouting As String, ByVal MTYLoadSide1 As String, _
                                          ByVal MTYSerialNum As String, ByVal MTYID As String) As Integer


        Dim sSql As String = "UPDATE WBLoadPrintPage SET " & _
            "PriRR" & Pos & " = '" & PriRR & "', " & _
            "PriAARCode" & Pos & " = '" & PriAARCode & "', " & _
            "PriInd" & Pos & " = '" & PrepStrForQuery(PriInd) & "', " & _
            "PriCity" & Pos & " = '" & PriCity & "', " & _
            "PriState" & Pos & " = '" & PriState & "', " & _
            "Comm" & Pos & " = '" & PrepStrForQuery(Comm) & "', " & _
            "SecInd" & Pos & " = '" & PrepStrForQuery(SecInd) & "', " & _
            "SecCity" & Pos & " = '" & SecCity & "', " & _
            "SecState" & Pos & " = '" & SecState & "', " & _
            "CarType" & Pos & " = '" & CarType & "', " & _
            "Routing" & Pos & " = '" & Routing & "', " & _
            "Via" & Pos & " = '" & Via & "', " & _
            "Notes" & Pos & " = '" & PrepStrForQuery(Notes) & "', " & _
            "LoadSide1" & Pos & " = '" & PrintLoadSide1 & "', " & _
            "SerialNum" & Pos & " = '" & SerialNum & "' " & _
            "WHERE LoadID = '" & LoadID & "';"
        clsSQLiteDB.ExecuteNonQuery(sSql, cnHTT)

        sSql = "UPDATE WBMTYPrintPage SET " & _
            "PriRR" & Pos & " = '" & MTYPriRR & "', " & _
            "MTYForHome" & Pos & " = '" & MTYForHome & "', " & _
            "IndAgent" & Pos & " = '" & IndAgent & "', " & _
            "Location" & Pos & " = '" & PrepStrForQuery(Location) & "', " & _
            "CarType" & Pos & " = '" & MTYCarType & "', " & _
            "Routing" & Pos & " = '" & MTYRouting & "', " & _
            "LoadSide1" & Pos & " = '" & MTYLoadSide1 & "', " & _
            "SerialNum" & Pos & " = '" & MTYSerialNum & "' " & _
            "WHERE MtyID = '" & MTYID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSql, cnHTT)

    End Function


    Public Function spWBViewGetWBList() As DataTable

        Dim sSQL As String = "SELECT WaybillID FROM Waybill WHERE RRID = '" & gsMyRR_ID & "' ORDER BY TrainAssignment ASC, InTrainSEQ ASC, RouteVerso ASC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spWBViewSetPageNum(ByVal PrintPage As String) As Integer

        Dim sSQL As String = "INSERT INTO WBLoadPrintPage (LoadID) VALUES ('" & PrintPage & "');"
        clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)
        sSQL = "INSERT INTO WBMTYPrintPage (MTYID) VALUES ('" & PrintPage & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spWBViewUpdateWBSeq(ByVal PrintPage As String, ByVal Sequence As String, _
                                        ByVal SerialNum As String, ByVal WaybillID As String) As Integer

        Dim sSQL As String = "UPDATE Waybill SET PrintPage = '" & PrintPage & "', PrintPageSeq = '" & Sequence & "', PrintSerialNum = '" & SerialNum & "' WHERE WaybillID = '" & WaybillID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function



End Module
