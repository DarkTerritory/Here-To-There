Imports System.Data.SQLite

Module DataAccess_Reports

    Public Function spShipAndRecvByCommRpt(ByVal All As String) As DataTable

        Dim sSQL As String = "SELECT a.Commodity, (SELECT Count(*)  FROM Industry b WHERE (b.indShipRecv IN ('B', 'S')) and (b.Commodity = a.Commodity)) " & _
            "AS Shippers, (SELECT Count(*)  FROM Industry c WHERE (c.indShipRecv IN ('B', 'R')) And (c.Commodity = a.Commodity)) AS Receivers, a.active " & _
            "FROM Industry AS a " & IIf(All = "True", "WHERE a.Active ='X' ", "") & " AND a.RRID = '" & gsMyRR_ID & "' AND b.RRID = '" & gsMyRR_ID & "' " & _
            "AND c.RRID = '" & gsMyRR_ID & "' GROUP BY a.Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spIndustryRpt(ByVal All As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT IndName, IndCity, IndState, IndRR FROM Industry " & _
            IIf(All = "True", "WHERE Active = 'X'", "") & " AND RRID = '" & gsMyRR_ID & "' ORDER BY IndState, IndName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spIndustryRptWComms(ByVal All As String) As DataTable

        Dim sSQL As String = "SELECT IndName, IndCity, IndState, IndRR, IndShipRecv, Commodity, Frequency, Notes FROM Industry " & _
            IIf(All = "True", "WHERE Active = 'X'", "") & " AND RRID = '" & gsMyRR_ID & "' ORDER BY IndState, IndCity, IndName, Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrainList() As DataTable

        Dim sSql As String = "SELECT Train.TrName, Train.TrClass, Lookup.LkDesc AS TrDirection, Train.TrScope, Train.trMaxCars, " & _
            "Lookup_1.LkDesc AS TrOriginateOL, Town.TownName, Lookup_2.LkDesc AS TrWorkSOPU, Lookup_3.LkDesc AS TrWorkWorkIndustry " & _
            "FROM ((((Train INNER JOIN (TrainWork INNER JOIN Town ON TrainWork.TrWorkTown = Town.TownCallSign) ON Train.TrID = TrainWork.TrWorkTrainName) " & _
            "INNER JOIN Lookup ON Train.TrDirection = Lookup.LkCode) INNER JOIN Lookup AS Lookup_1 ON Train.TrOriginateOL = Lookup_1.LkCode) " & _
            "INNER JOIN Lookup AS Lookup_2 ON TrainWork.TrWorkSOPU = Lookup_2.LkCode) " & _
            "INNER JOIN Lookup AS Lookup_3 ON TrainWork.TrWorkWorkIndustry = Lookup_3.LkCode " & _
            "WHERE(((Lookup.LkGroup) = 'Direction') AND ((Lookup_1.LkGroup) = 'YesNo') AND ((Lookup_2.LkGroup) = 'YesNo') AND ((Lookup_3.LkGroup) = 'YesNo')) " & _
            "AND Train.RRID = '" & gsMyRR_ID & "' AND Town.RRID = '" & gsMyRR_ID & "' AND TrainWork.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY Train.TrName, TrainWork.TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spRailroadByRegionRpt(ByVal Region As String) As DataTable

        Dim sSql As String = "SELECT AARRegion.RegCode, AARRegionName.AARRegName, AARRRCode.AAR, AARRRCode.Railroad FROM (AARRegion " & _
            "INNER JOIN AARRRCode ON AARRegion.RegRR = AARRRCode.AAR) " & _
            "INNER JOIN AARRegionName ON AARRegion.RegCode = AARRegionName.AARCode " & _
            IIf(Region <> "", "WHERE AARRegion.RegCode = '" & Region & "' ", "") * "ORDER BY AARRegion.RegCode, AARRRCode.AAR;"
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function

End Module
