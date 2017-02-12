Imports System.Data.SQLite

Module DataAccess_Build


    Public Function spBuildAgentWBs() As DataTable

        Dim sSQL As String = "SELECT CatalogID, RouteVerso, CatComm, PriInd, PriCity, PriState, CatSpots FROM Catalog WHERE RouteVerso IN ('Freight Agent Select', 'Start at Industry') AND  SessionSelect NOT IN ('N', 'S', 'Y') AND RRID = '" & gsMyRR_ID & "' ORDER BY PriState, PriCity, PriInd;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function

    Public Function spBuildCatForTrain(ByVal StagingAreaName As String, ByVal TrainType As String, ByVal TrainName As String, ByVal PageMode As Integer) As DataTable

        Dim sSQL As String = ""
        Dim sSQL1 As String
        Dim sSQL2 As String
        Dim daFillDt As SQLiteDataAdapter
        Dim dt As New DataTable


        If PageMode = "1" Then

            sSQL = "SELECT COUNT(*) FROM LoadRestrict WHERE lrTrainType = '" & TrainType & "';"
            daFillDt = New SQLiteDataAdapter(sSQL, cnHTT)
            If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
            daFillDt.Fill(dt)
            If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()
            If Not dt Is Nothing Then

                sSQL1 = "SELECT CatalogID, ABS(RANDOM() % 1000) AS RandID FROM Catalog Cat " & _
                    "WHERE Cat.SessionSelect NOT IN ('N', 'S', 'Y') AND RRID = '" & gsMyRR_ID & "' " & _
                    "AND Cat.CatComm NOT IN (SELECT LrCommodity FROM LoadRestrict WHERE lrTrainType = '" & TrainType & "')"
                sSQL2 = "AND Cat.RouteIntDir = '" & StagingAreaName & "'"

                sSQL = sSQL1 & " AND Cat.PrintLoadSide1 = 'Y' AND Cat.RouteIntOffAt = '' " & sSQL2 & " UNION " & _
                    sSQL1 & " AND Cat.PrintLoadSide1 = 'N' AND Cat.RouteIntOnAt = ''" & _
                    "AND Cat.RouteVerso <> 'Start at Industry' " & sSQL2 & " ORDER BY RandID;"

            Else

                sSQL1 = "SELECT CatalogID, ABS(RANDOM() % 1000) AS RandID  FROM Catalog Cat WHERE Cat.SessionSelect NOT IN ('N', 'S', 'Y') " & _
                    "AND RRID = '" & gsMyRR_ID & "' AND Cat.PrintLoadSide1 = "
                sSQL2 = "AND Cat.RouteIntDir = '" & StagingAreaName & "'"

                sSQL = sSQL1 & "'Y' AND Cat.RouteIntOffAt = '' " & sSQL2 & " UNION " & sSQL1 & _
                    "'N' AND Cat.RouteIntOnAt = '' AND Cat.RouteVerso <> 'Start at Industry' " & sSQL2 & " ORDER BY RandID;"
            End If

        ElseIf PageMode = "2" Then

            sSQL = "SELECT CatalogID,  ABS(RANDOM() % 1000) AS RandID  FROM Catalog cat WHERE Cat.SessionSelect NOT IN ('N', 'S', 'Y')" & _
                " AND RRID = '" & gsMyRR_ID & "' AND Cat.RouteVerso = 'Through' AND Cat.RouteIntDir = '" & StagingAreaName & "' ORDER BY RandID;"



        ElseIf PageMode = "3" Then

            sSQL = "SELECT CatalogID,  ABS(RANDOM() % 1000) AS RandID  FROM Catalog cat WHERE Cat.SessionSelect NOT IN ('N', 'S', 'Y')" & _
                " AND RRID = '" & gsMyRR_ID & "' AND Cat.RouteVerso IN ('Freight Agent Select', 'Start at Industry') ORDER BY RandID;"


        End If

        daFillDt = New SQLiteDataAdapter(sSQL, cnHTT)


        If cnHTT.State <> ConnectionState.Open Then cnHTT.Open()
        daFillDt.Fill(dt)
        If cnHTT.State <> ConnectionState.Closed Then cnHTT.Close()

        Return dt

    End Function


    Public Function spBuildClearSelectionsFromCat(ByRef SelectValue As String) As Integer

        Dim sSQL As String = "UPDATE Catalog SET SessionSelect = '' WHERE SessionSelect = '" & SelectValue & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spBuildCopyCatRecToWB(ByVal CatalogID As String, ByRef InTrainSequence As Integer, ByVal TrainAssignment As String) As Integer

        Dim sSQL As String = "INSERT INTO Waybill (wbCarType, wbComm, wbNotes, wbPrimarySR, PriRR, PriInd, PriCity, PriState, PriCLIC, PriSiding, PriDiv, PriServBy, " & _
            "SecRR, SecInd, SecCity, SecState, SecCLIC, SecSiding, SecDiv, SecServBy, RouteIntOnWith, RouteIntOnAt, RouteIntOffWith, " & _
            "RouteIntOffAt, RouteIntVia, RouteIntDir, RouteVerso, PrintLoadSide1, PrintMTYForHome, InTrainSeq, TrainAssignment, RRID) " & _
            "SELECT  CatCarType, CatComm, CatNotes, CatPrimarySR, PriRR, PriInd, PriCity, PriState, PriCLIC, PriSiding, PriDiv, " & _
            "PriServBy, SecRR, SecInd, SecCity, SecState, SecCLIC, SecSiding, SecDiv, SecServBy, RouteIntOnWith, RouteIntOnAt, RouteIntOffWith, " & _
            "RouteIntOffAt, RouteIntVia, RouteIntDir, RouteVerso, PrintLoadSide1, PrintMTYForHome, '" & TrainAssignment & "', '" & InTrainSequence & "', '" & gsMyRR_ID & "' " & _
            "FROM Catalog WHERE CatalogID = '" & CatalogID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spBuildGetCommPriority(ByVal CommodityName As String) As String

        Dim sSQL As String = "SELECT CommPriority FROM Commodity WHERE CommodityName = '" & CommodityName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spBuildGetTownName(ByVal TownName As String) As String

        Dim sSQL As String = "SELECT TownCallSign FROM Town WHERE TownName = '" & TownName & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spBuildGetTrCarCount(ByVal TrainAssignment As String) As String

        Dim sSQL As String = "SELECT COUNT(*) FROM Waybill WHERE TrainAssignment = '" & TrainAssignment & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spBuildGetTrStops(ByVal TrainID As String, ByVal WorkTownCallSign As String) As String

        Dim sSQL As String = "SELECT Tw.TrWorkID FROM TrainWork Tw LEFT JOIN Town Tn ON tw.TrWorkTown = Tn.TownCallSign WHERE Tw.TrWorkTrainName = '" & TrainID & "' AND Tw.TrWorkTown = '" & WorkTownCallSign & "' AND Tw.RRID = '" & gsMyRR_ID & "' AND Tn.TownLocal = 'N' AND Tn.RRID = '" & gsMyRR_ID & "'"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spBuildOLTrains() As DataTable

        Dim sSQL As String = "SELECT TrID, TrName, TrDirection, TrType, TrClass, TrScope, trMaxCars, TrOriginateOL, TrAllowLowPriority, " & _
            "TrPctThru, trDepartTime, TIME(trDepartTime) AS dtDepartTime, TrFromStagingArea " & _
            "FROM Train WHERE TrOriginateOL = 'Y' AND RRID = '" & gsMyRR_ID & "' AND (TrType <> 'P' OR TrType <> 'A') ORDER BY dtDepartTime;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spBuildSingleCatRecord(ByVal CatalogID As String) As DataTable

        Dim sSQL As String = "SELECT * FROM Catalog WHERE CatalogID = '" & CatalogID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spBuildTagRecSelect(ByVal CatalogID As String, ByVal SessionSelect As String) As Integer

        Dim sSQL As String = "UPDATE Catalog SET SessionSelect = '" & SessionSelect & "' WHERE CatalogID = '" & CatalogID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spBuildTrainWBCount(ByVal TrainType As String) As DataTable

        Dim sSQL As String = ""

        If TrainType = "Local" Then
            sSQL = "SELECT  Tr.TrID, Tr.TrName, ROUND(Tr.trMaxCars * (Tr.TrPctThru * 0.01)) AS TrCarLimit, wb.WaybillCount, Lk.LkDesc " & _
                "FROM Train Tr LEFT JOIN (Select TrainAssignment, Count(WayBillId) As WayBillCount From(WayBill) Group By TrainAssignment) As wb " & _
                "ON tr.TrID = wb.TrainAssignment LEFT JOIN Lookup Lk ON tr.TrFromStagingArea = Lk.Lkcode WHERE Tr.TrOriginateOL = 'Y' AND Lk.LkGroup = 'StagingArea' AND Tr.RRID = '" & gsMyRR_ID & "';"

        Else ' TrainType = "Thru"
            sSQL = "SELECT  Tr.TrID, Tr.TrName, Tr.trMaxCars AS TrCarLimit, wb.WaybillCount, Lk.LkDesc " & _
                "FROM Train Tr LEFT JOIN (Select TrainAssignment, Count(WayBillId) As WayBillCount From(WayBill) Group By TrainAssignment) As wb " & _
                "ON tr.TrID = wb.TrainAssignment LEFT JOIN Lookup Lk ON tr.TrFromStagingArea = Lk.Lkcode WHERE Tr.TrOriginateOL = 'Y' AND Lk.LkGroup = 'StagingArea' AND RRID = '" & gsMyRR_ID & "';"

        End If

        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)


    End Function


    Public Function spBuildTrainWork(ByVal TrainName As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT tw.TrWorkID, tw.TrWorkTrainName, tw.TrWorkStopNum, tw.TrWorkDirofTravel, tw.TrWorkTown, tw.TrWorkSOPU, tw.TrWorkWorkIndustry, " & _
            "tn.TownLocal, IFNULL(ic.IntNearestOnLineInt, tw.TrWorkTown) AS ClosestOmLnTown FROM TrainWork tw LEFT JOIN Interchange ic ON tw.TrWorkTown = ic.intTown " & _
            "LEFT JOIN Town tn ON TW.TrWorkTown = tn.TownName WHERE tw.TrWorkTrainName = '" & TrainName & "' AND Tw.RRID = '" & gsMyRR_ID & "' AND Tn.RRID = '" & gsMyRR_ID & "' AND Ic.RRID = '" & gsMyRR_ID & "' ORDER BY tw.TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


End Module