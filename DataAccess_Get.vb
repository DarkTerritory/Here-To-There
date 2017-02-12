Imports System.Data.SQLite

Module DataAccess_Get

    Public Function spGetAARCarType() As DataTable

        Dim sSQL As String = "SELECT ID, AARCode, AARDesc FROM AARCartypes ORDER BY AARDesc;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAARCarTypeCd() As DataTable

        Dim sSQL As String = "SELECT AARCode FROM AARCarTypes ORDER BY AARCode;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAarRegions() As DataTable

        Dim sSQL As String = "SELECT AARCode, AARRegName FROM AARRegionName ORDER BY AARCode;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAarRegionsWComms(ByVal Commodity As String) As DataTable

        Dim sSQL As String = "SELECT z.AARCode, z.AARRegName || ' - ' || CAST(IFNULL((SELECT count(Reg.AARRegionCode) from Industry ind, AARState Reg " & _
            "WHERE(Reg.AARState = ind.IndState AND ind.RRID = '" & gsMyRR_ID & "') AND reg.AARRegionCode = z.AARCode and ind.Commodity =  '" & Commodity & "' " & _
            "AND Active = 'X' AND SUBSTR(ind.CLIC, 1, 3) = 'O/L' GROUP by reg.AARRegionCode), 0) as VarChar) as AARRegName " & _
            "FROM AARRegionName z ORDER BY AARCode;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAarRegNameCd() As DataTable
        Dim sSQL As String = "SELECT AARCode, AARRegName from AARRegionName ORDER BY AARCode;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAarStates() As DataTable

        Dim sSQL As String = "SELECT State.AARState, State.AARStateName, Reg.AARRegName AS RegionName FROM AARState AS State LEFT JOIN " & _
            "AARRegionName As Reg ON State.AARRegionCode = Reg.AARCode ORDER BY State.AARState;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAarStatesInRegion(ByVal AARCode As String) As DataTable

        Dim sSQL As String = "SELECT AARState from AARState WHERE AARRegionCode = '" & AARCode & "' ORDER BY AARState;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetActCommFromInd() As DataTable

        Dim sSQL As String = "SELECT DISTINCT Commodity FROM Industry WHERE Active = 'X' AND RRID = '" & gsMyRR_ID & "' ORDER BY Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAllComms() As DataTable

        Dim sSQL As String = "SELECT CommUse, CommodityName FROM Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetAllocWB4Train(ByVal TrainAssignment As String) As DataTable

        Dim sSQL As String = "SELECT MAX(InTrainSeq) FROM Waybill WHERE TrainAssignment =  '" & TrainAssignment & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetCarCntAssn2Train(ByVal TrainAssignment As String) As String

        Dim sSQL As String = "SELECT MAX(InTrainSeq) FROM Waybill WHERE TrainAssignment = '" & TrainAssignment & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetCarTypeDesc(ByVal AARCode As String) As String

        Dim sSQL As String = "SELECT AARDesc From AARCarTypes WHERE AARCode = '" & AARCode & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetCarTypeFromComm(ByVal CommodityName As String) As String

        Dim sSQL As String = "SELECT CommAARType1 From Commodity WHERE CommodityName = '" & CommodityName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetCatCommIdx(ByVal PrimaryCLIC As String) As String

        Dim sSQL As String = "SELECT Ifnull(MAX(CatCommIdx), '') FROM Catalog WHERE PriCLIC = '" & PrimaryCLIC & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetCommCount(ByVal CommodityName As String) As String

        Dim sSQL As String = "SELECT COUNT(*) FROM Commodity WHERE CommodityName =  '" & CommodityName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetComms() As DataTable

        Dim sSQL As String = "SELECT CommodityName FROM Commodity WHERE CommUse = 'X' ORDER BY CommodityName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetDivisions() As DataTable

        Dim sSQL As String = "SELECT Div.DivNum, Div.DivName, Town.TownName AS DivEndPointEast, Town_1.TownName AS DivEndPointWest " & _
            "FROM (Division AS Div INNER JOIN Town ON Div.DivEndPointEast = Town.TownCallSign) INNER JOIN Town AS Town_1 " & _
            "ON Div.DivEndPointWest = Town_1.TownCallSign WHERE Div.RRID = '" & gsMyRR_ID & "' AND Town.RRID = '" & gsMyRR_ID & "' ORDER BY Div.DivNum;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetDivName(ByVal TownCallSign As String) As String

        Dim sSQL As String = "SELECT Division.DivName FROM Town LEFT OUTER JOIN Division ON Town.TownDiv = Division.DivNum WHERE Town.TownCallSign =  '" & TownCallSign & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetFrtHub(ByVal TownCallSign As String) As String

        Dim sSQL As String = "SELECT TownServedBy FROM Town WHERE TownCallSign = '" & TownCallSign & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetIndCLIC(ByVal IndustryName As String, ByVal Commodity As String, ByVal City As String) As String

        Dim sSQL As String = "SELECT CLIC FROM Industry WHERE indName = '" & IndustryName & "' AND Commodity = '" & Commodity & "' AND IndCity = '" & City & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetIndID(ByVal IndustryName As String, ByVal Commodity As String, ByVal City As String) As String

        Dim sSQL As String = "SELECT IndID FROM Industry WHERE IndName = '" & IndustryName & "' AND Commodity = '" & Commodity & "' AND IndCity = '" & City & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetIndustries() As DataTable

        Dim sSQL As String = "SELECT Ind.IndID, Ind.Active, Ind.CLIC, Ind.IndName, Ind.IndCity, Ind.IndState, " & _
            "CASE AAR.Railroad WHEN NULL THEN Ind.IndRR ELSE AAR.Railroad END AS Railroad, Lk.LkDesc AS ShipRecv, Ind.Commodity, " & _
            "Sid.SidingNotes AS Siding, Frq.FreqDesc AS Frequency, Ind.Spots, Ind.Notes FROM Industry AS Ind " & _
            "LEFT JOIN AARRRCode AS AAR ON Ind.IndRR = AAR.ReportMark LEFT JOIN Siding AS Sid ON Ind.Siding = Sid.SidingID " & _
            "LEFT JOIN Frequency AS Frq ON Ind.Frequency = Frq.FreqID INNER JOIN Lookup AS Lk ON Ind.indShipRecv = Lk.LkCode WHERE Lk.LkGroup = 'ShipRecv' " & _
            "AND Ind.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetInterchanges() As DataTable

        Dim sSQL As String = "SELECT Interchange.IntID, Town.TownName AS IntTown, AARRRCode.Railroad AS IntPrimaryRR, AARRRCode_1.Railroad AS IntForeignRR, " & _
            "Lookup_2.LkDesc AS IntForeignRRDir, Town_1.TownName AS IntNearestOnLineInt, lookup_1.LkDesc AS IntStagingArea " & _
            "FROM (((((Interchange LEFT JOIN Town ON Interchange.IntTown = Town.TownCallSign) " & _
            "LEFT JOIN AARRRCode ON Interchange.IntPrimaryRR = AARRRCode.ReportMark) " & _
            "LEFT JOIN AARRRCode AS AARRRCode_1 ON Interchange.IntForeignRR = AARRRCode_1.ReportMark) " & _
            "LEFT JOIN Town AS Town_1 ON Interchange.IntNearestOnLineInt = Town_1.TownCallSign) " & _
            "LEFT JOIN Lookup AS Lookup_1 ON Interchange.IntStagingarea = Lookup_1.LkCode AND Lookup_1.LkGroup = 'StagingArea')" & _
            "LEFT JOIN Lookup AS Lookup_2 ON Interchange.IntForeignRRDir = Lookup_2.LkCode AND Lookup_2.LkGroup = 'Orientation' " & _
            "AND Interchange.RRID = '" & gsMyRR_ID & "'  AND Town.RRID = '" & gsMyRR_ID & "'  AND Town_1.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY Town.TownName, AARRRCode_1.Railroad;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetInterchangeTownNames() As DataTable

        Dim sSQL As String = "SELECT DISTINCT Town.TownName, Interchange.IntTown FROM Town, Interchange WHERE Interchange.IntTown = Town.TownCallSign AND Town.RRID = '" & gsMyRR_ID & "' AND Interchange.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetIntRRs(ByVal InterchangeTown As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT Interchange.IntForeignRR, AARRRCode.Railroad FROM Interchange, AARRRCode WHERE Interchange.IntForeignRR = AARRRCode.ReportMark " & _
            "AND Interchange.IntTown =  '" & InterchangeTown & "' AND Interchange.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetMyRR(ByVal RailroadID As String) As DataTable

        Dim sSQL As String = "SELECT RRName, RRState, RRInitials, RRNickname, RREra, RROpSessionDate, RRPaperworkDate, RRPrototype FROM MyRR WHERE RRID =  '" & RailroadID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetOLCatCommIdx(ByVal CatCommodity As String) As String

        Dim sSQL As String = "SELECT MAX(CatCommIdx) FROM Catalog WHERE CatComm =   '" & CatCommodity & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetOLIndCount(ByVal StateList As String, ByVal Commodity As String, ByVal ShipOrRecv As String) As String

        Dim sSQL As String = ""

        If ShipOrRecv = "S" Then

            If Commodity <> "" Then
                sSQL = "SELECT COUNT(*) FROM Industry WHERE IndShipRecv IN ('S', 'B') AND Commodity  '" & Commodity & "' " & _
                    "AND IndState IN '" & StateList & "' AND Active = 'X' AND SUBSTR(CLIC, 1, 3) = 'O/L' AND RRID = '" & gsMyRR_ID & "';"

            Else
                sSQL = "SELECT COUNT(*) FROM Industry WHERE IndShipRecv IN ('S', 'B') AND IndState IN '" & StateList & "' " & _
                    "AND Active = 'X' AND SUBSTR(CLIC, 1, 3) = 'O/L' AND RRID = '" & gsMyRR_ID & "';"

            End If

        Else

            If Commodity <> "" Then
                sSQL = "SELECT COUNT(*) FROM Industry WHERE IndShipRecv IN ('R', 'B') AND Commodity  '" & Commodity & "' " & _
                    "AND IndState IN '" & StateList & "' AND Active = 'X' AND SUBSTR(CLIC, 1, 3) = 'O/L' AND RRID = '" & gsMyRR_ID & "';"

            Else
                sSQL = "SELECT COUNT(*) FROM Industry WHERE IndShipRecv IN ('R', 'B') AND IndState IN '" & StateList & "' " & _
                    "AND Active = 'X' AND SUBSTR(CLIC, 1, 3) = 'O/L' AND RRID = '" & gsMyRR_ID & "';"

            End If

        End If

        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetRegionCode(ByVal AARRegionName As String) As String

        Dim sSQL As String = "SELECT AARCode FROM AARRegionName WHERE AARRegName = '" & AARRegionName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetRRNames() As DataTable

        Dim sSQL As String = "SELECT AAR, Railroad, ReportMark FROM AARRRCode ORDER BY Railroad;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetRRRepMarkList() As DataTable

        Dim sSQL As String = "SELECT AAR, Railroad, ReportMark FROM AARRRCode ORDER BY Railroad;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetRRsInAarReg(ByVal AARRegionCode As String) As DataTable

        Dim sSQL As String = "SELECT rr.Railroad, rr.ReportMark FROM AARRRCode rr, AARRegion rg " & _
            "WHERE rr.AAR = rg.RegRR AND rg.RegCode = '" & AARRegionCode & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spGetSidingNotes(ByVal SidingID As String) As String

        Dim sSQL As String = "SELECT SidingNotes FROM wkSiding WHERE SidingID = '" & SidingID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spGetSidings() As DataTable

        Dim sSql As String = "SELECT SidingID, SidingNotes FROM Siding ORDER BY SidingNotes;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetSidingTown(ByVal SidingID As String) As String

        Dim sSql As String = "SELECT SidingTown FROM wkSiding WHERE SidingID = '" & SidingID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSql, cnHTT)

    End Function


    Public Function spGetSingleInd(ByVal IndustryID As String) As DataTable

        Dim sSql As String = "SELECT Ind.IndID, Ind.Active, Ind.CLIC, Ind.IndName, Ind.IndCity, " & _
            "Ind.IndState, CASE AAR.Railroad WHEN NULL THEN Ind.IndRR ELSE AAR.Railroad END AS Railroad, " & _
            "Lk.LkDesc AS ShipRecv, Ind.Commodity, Sid.SidingNotes AS Siding, Frq.FreqDesc AS Frequency, " & _
            "Ind.IndRR, Ind.Spots, Ind.Notes FROM (((Industry AS Ind " & _
            "LEFT JOIN AARRRCode AS AAR ON Ind.IndRR = AAR.ReportMark) " & _
            "LEFT JOIN Siding AS Sid ON Ind.Siding = Sid.SidingID) " & _
            "LEFT JOIN Frequency AS Frq ON Ind.Frequency = Frq.FreqID) " & _
            "INNER JOIN Lookup AS Lk ON Ind.IndShipRecv = Lk.LkCode " & _
            "WHERE (((Lk.LkGroup)='ShipRecv'))" & _
            "AND Ind.IndID = '" & IndustryID & "' AND Ind.RRID = '" & gsMyRR_ID & "' AND Sid.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetStagingAreas() As DataTable

        Dim sSql As String = "SELECT StgID, StagingCode, StagingDesc FROM StagingArea WHERE RRID = '" & gsMyRR_ID & "' ORDER BY StagingDesc;" ' 2/6/2017 CJB
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTown(ByVal TownCallSign As String) As DataTable

        Dim sSql As String = "SELECT TownID, TownName, TownState, TownCallSign, TownFrtHub, TownServedBy, " & _
            "TownDiv, TownLocal FROM Town Where TownCallSign = '" & TownCallSign & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTownCallSign(ByVal TownName As String) As String

        Dim sSql As String = "SELECT TownCallSign FROM Town WHERE TownName  = '" & TownName & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSql, cnHTT)

    End Function


    Public Function spGetTownFrtHubs() As DataTable

        Dim sSql As String = "SELECT TownName, TownCallSign FROM Town WHERE TownFrtHub = 'Y' AND RRID = '" & gsMyRR_ID & "' ORDER BY TownName;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTownName(ByVal TownCallSign As String) As String

        Dim sSql As String = "SELECT TownName FROM Town WHERE TownCallSign = '" & TownCallSign & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSql, cnHTT)

    End Function


    Public Function spGetTownNameCallSign() As DataTable

        Dim sSql As String = "SELECT TownName, TownCallSign FROM Town WHERE RRID = '" & gsMyRR_ID & "' ORDER BY TownName;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTowns() As DataTable

        Dim sSql As String = "SELECT Town.TownID, Town.TownName, AARState.AARStateName AS TownState, " & _
           "Town.TownCallSign, Lookup.LkDesc AS TownFrtHub, Town_1.TownName AS TownServedBy, " & _
           "Division.DivName AS TownDiv, Town_2.TownName as TownEastOf, Town_3.TownName as TownWestOf, Lookup1.LkDesc AS TownLocal " & _
           "FROM Town LEFT OUTER JOIN Division ON Town.TownDiv = Division.DivNum " & _
           "LEFT JOIN Town AS Town_1 ON Town.TownServedBy = Town_1.TownCallSign " & _
           "LEFT JOIN AARState ON Town.TownState = AARState.AARState " & _
           "LEFT JOIN Lookup ON Town.TownFrtHub = Lookup.LkCode AND Lookup.LkGroup = 'YesNo' " & _
           "LEFT JOIN Lookup Lookup1 ON Town.TownLocal = Lookup1.LkCode AND Lookup1.LkGroup = 'YesNo' " & _
           "LEFT JOIN Town AS Town_2 ON Town.TownEastOf = Town_2.TownCallSign " & _
           "LEFT JOIN Town AS Town_3 ON Town.TownWestOf = Town_3.TownCallSign " & _
           "AND Town.RRID = '" & gsMyRR_ID & "' " & _
           "AND Town_1.RRID = '" & gsMyRR_ID & "' " & _
           "AND Town_2.RRID = '" & gsMyRR_ID & "' " & _
           "AND Town_3.RRID = '" & gsMyRR_ID & "' " & _
           "ORDER BY Town.TownName;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTrainList() As DataTable

        Dim sSql As String = "SELECT Tr.trID, Tr.trName, Tr.trDirection, Lk.LkDesc as trType, Tr.trClass, " & _
            "Tr.trScope, Tr.trMaxCars, Tr.trOriginateOL " & _
            "FROM Train Tr LEFT JOIN Lookup Lk ON Tr.TrType = LkCode AND LK.LkGroup = 'TrainType' " & _
            "WHERE Tr.trOriginateOL = 'Y' AND Tr.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTrainName(ByVal TrainID As String) As DataTable

        Dim sSql As String = "SELECT TrName FROM train WHERE TrID = '" & TrainID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTrains() As DataTable

        Dim sSql As String = "SELECT Tr.TrID, Tr.TrName, Lookup.LkDesc AS TrDirection, Lookup_3.LkDesc AS TrType, " & _
            "Tr.TrClass, Tr.TrScope, Tr.trMaxCars, Tr.TrPctThru, Lookup_2.LkDesc AS TrAllowLowPriority, " & _
            "Lookup_1.LkDesc AS TrOriginateOL, Tr.TrDepartTime, StagingArea.StagingDesc AS StagingArea " & _
            "FROM Train AS Tr " & _
            "LEFT JOIN Lookup ON Tr.TrDirection = Lookup.LkCode AND Lookup.LkGroup = 'Direction' " & _
            "LEFT JOIN Lookup AS Lookup_1 ON Tr.TrOriginateOL = Lookup_1.LkCode AND Lookup_1.LkGroup = 'YesNo' " & _
            "LEFT JOIN Lookup AS Lookup_2 ON Tr.TrAllowLowPriority = Lookup_2.LkCode AND Lookup_2.LkGroup = 'YesNo' " & _
            "LEFT JOIN Lookup AS Lookup_3 ON Tr.TrType = Lookup_3.LkCode AND Lookup_3.LkGroup = 'TrainType' " & _
            "LEFT JOIN StagingArea ON Tr.TrFromStagingArea = StagingArea.StagingCode " & _
            "AND Tr.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY TrDepartTime, Tr.TrName;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spGetTrainWork(ByVal TrainWorkName As String) As DataTable

        Dim sSql As String = "SELECT TrainWork.TrWorkID, Train.TrName AS TrWorkTrainName, " & _
            "TrainWork.TrWorkTrainName as TrWorkTrainID, TrainWork.TrWorkStopNum, Lookup.LkDesc AS TrWorkDirOfTravel,  " & _
            "Town.TownName AS TrWorkTown, Lookup_1.LkDesc AS TrWorkSOPU, Lookup_2.LkDesc AS TrWorkWorkIndustry " & _
            "FROM ((((TrainWork LEFT JOIN Train ON TrainWork.TrWorkTrainName = Train.TrID) " & _
            "LEFT JOIN Lookup ON TrainWork.TrWorkDirofTravel = Lookup.LkCode) " & _
            "LEFT JOIN Town ON TrainWork.TrWorkTown = Town.TownCallSign) " & _
            "LEFT JOIN Lookup AS Lookup_1 ON TrainWork.TrWorkSOPU = Lookup_1.LkCode) " & _
            "LEFT JOIN Lookup AS Lookup_2 ON TrainWork.TrWorkWorkIndustry = Lookup_2.LkCode " & _
            "WHERE Lookup.LkGroup = 'Direction' AND Lookup_1.LkGroup = 'YesNo' AND Lookup_2.LkGroup = 'YesNo' " & _
            "AND TrainWork.TrWorkTrainName = '" & TrainWorkName & "' " & _
            "AND TrainWork.RRID = '" & gsMyRR_ID & "' " & _
            "AND Train.RRID = '" & gsMyRR_ID & "' " & _
            "AND Town.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY TrainWork.TrWorkTrainName, TrainWork.TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function

















End Module


