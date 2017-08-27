Module DataAccess_Misc

    Public Function spCatDelRec(ByVal CatalogID As String) As Integer

        Dim sSQL As String = "DELETE FROM Catalog WHERE CatalogID = '" & CatalogID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spCatFillGrid() As DataTable

        Dim sSQL As String = "SELECT CatalogID, CatCommID, CatCommIdx, CatCarType, CatComm, CatNotes, CatPrimarySR, PriRR, PriInd, " & _
            "PriCity, PriState, PriCLIC, PriSiding, PriDiv, PriServBy, SecRR, SecInd, SecCity, SecState, SecCLIC, " & _
            "SecSiding, SecDiv, SecServBy, RouteIntOnWith, RouteIntOnAt, RouteIntOffWith, RouteIntOffAt, RouteIntVia, " & _
            "RouteIntDir, RouteVerso, PrintLoadSide1, PrintMTYForHome FROM Catalog WHERE RRID = '" & gsMyRR_ID & "' ORDER BY PriState, PriCity, PriInd;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spCheckPriorCLICVal(ByVal PrimaryCLIC As String) As String

        Dim sSQL As String = "SELECT IFNULL(PriCLIC, '') FROM Catalog WHERE PriCLIC =  '" & PrimaryCLIC & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spClearWBTable() As Integer

        Dim sSQL As String = ""
        Dim i As Integer

        sSQL = "UPDATE Catalog SET SessionSelect = '' WHERE RRID = '" & gsMyRR_ID & "';"
        i = clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

        sSQL = "DELETE FROM Waybill" ';"
        i = clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)
        Return i

    End Function


    Public Function spMainRptCommBal() As DataTable

        Dim sSQL As String = "SELECT A.Commodity, (SELECT Count(*) FROM Industry B " & _
            "WHERE B.IndShipRecv IN ('B', 'S') AND B.Commodity = A.Commodity) AS Shippers, (SELECT Count(*) " & _
            "FROM Industry C WHERE C.IndShipRecv IN ('B', 'R') AND C.Commodity = A.Commodity) AS Receivers " & _
            "FROM Industry AS A WHERE A.Active = 'X' AND B.RRID = '" & gsMyRR_ID & "' AND C.RRID = '" & gsMyRR_ID & "' GROUP BY A.Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMainRptIndByState() As DataTable

        Dim sSQL As String = "SELECT DISTINCT IndName, IndCity, IndState, IndRR FROM Industry " & _
            "WHERE Active = 'X' AND RRID = '" & gsMyRR_ID & "' ORDER BY IndState, IndName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMainRptIndByStateWComm() As DataTable

        Dim sSQL As String = "SELECT IndName, IndCity, IndState, IndRR, IndShipRecv, Commodity, Frequency, Notes " &
            "FROM Industry AS Industry1 WHERE Active = 'X' AND RRID = '" & gsMyRR_ID & "' ORDER BY IndState, IndCity, IndName, Commodity;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMatchCatUpdate(ByRef PriDiv As String, ByVal PriServBy As String, _
                                    ByVal SecRR As String, ByVal SecInd As String, _
                                    ByVal SecCity As String, ByVal SecState As String, _
                                    ByVal SecCLIC As String, ByVal SecSiding As String, _
                                    ByVal SecDiv As String, ByVal SecServBy As String, _
                                    ByVal routeIntOnWith As String, ByVal routeIntOnAt As String, _
                                    ByVal routeIntOffWith As String, ByVal routeIntOffAt As String, _
                                    ByVal routeIntVia As String, ByVal routeIntDir As String, _
                                    ByVal routeVerso As String, ByVal PrintLoadSide1 As String, _
                                    ByVal CatComm As String, ByVal CatPrimarySR As String, _
                                    ByVal SessionSelect As String, ByVal PrintMTYForHome As String, _
                                    ByVal CatalogID As Integer) As Integer

        Dim sSQL As String = "UPDATE Catalog SET PriDiv='" & PriDiv & "', PriServBy='" & PriServBy & _
            "', SecRR='" & SecRR & "', SecInd='" & SecInd & "', SecCity='" & SecCity & "', SecState='" & SecState & _
            "', SecCLIC='" & SecCLIC & "', SecSiding='" & SecSiding & "', SecDiv='" & SecDiv & _
            "', SecServBy='" & SecServBy & "', routeIntOnWith='" & routeIntOnWith & _
            "', routeIntOnAt='" & routeIntOnAt & "', routeIntOffWith='" & routeIntOffWith & _
            "', routeIntOffAt='" & routeIntOffAt & "', routeIntVia='" & routeIntVia & "', routeIntDir='" & routeIntDir & _
            "', routeVerso='" & routeVerso & "', PrintLoadSide1='" & PrintLoadSide1 & "', CatComm='" & CatComm & _
            "', CatPrimarySR='" & CatPrimarySR & "', SessionSelect='" & SessionSelect & "'," & _
            "PrintMTYForHome='" & PrintMTYForHome & "' WHERE CatalogID = " & CatalogID & " AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMatchCommNotes(ByRef CommName As String) As String

        Dim sSQL As String = "SELECT IFNULL(CommNotes, '') AS CommNotes FROM Commodity WHERE CommodityName = '" & CommName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spMatchFillGrid() As DataTable

        Dim sSQL As String = "SELECT Cat.CatalogID, Cat.CatCommID, Cat.CatCommIdx, Cat.CatCommSeq, Cat.CatCarType, " & _
        "Cat.CatComm AS CatComm, Cat.CatNotes, Lookup2.LkDesc AS CatPrimarySR, Lookup1.LkDesc AS CatFrequency, Cat.CatSpots, " & _
        "Cat.PriRR, Cat.PriInd, Cat.PriCity, Cat.PriState, Cat.PriCLIC, Siding.SidingNotes AS PriSiding, " & _
        "Cat.PriDiv, Town.TownName as PriServBy " & _
        "FROM Catalog Cat LEFT OUTER JOIN Lookup AS LookUp2 ON Cat.CatPrimarySR = Lookup2.LkCode AND Lookup2.LkGroup = 'ShipRecv' " & _
        "LEFT OUTER JOIN Lookup AS Lookup1 ON Cat.CatFrequency = Lookup1.LkCode AND Lookup1.LkGroup = 'Frequency' " & _
        "LEFT OUTER JOIN Siding  ON Cat.PriSiding = Siding.SidingID " & _
        "LEFT OUTER JOIN Town ON Cat.PriServBy = Town.TownCallSign WHERE Cat.SecInd is null " & _
        "AND Siding.RRID = '" & gsMyRR_ID & "' AND Town.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMatchIntRR() As DataTable

        'Dim sSQL As String = "SELECT DISTINCT Int.IntForeignRR || ' - ' || T.TownName AS RRTown, Int.IntForeignRRAlias AS IntAlias " & _
        '    "FROM Interchange Int LEFT JOIN Town T ON T.TownCallSign = Int.IntTown " & _
        '     "AND Int.RRID = '" & gsMyRR_ID & "' AND T.RRID = '" & gsMyRR_ID & "';"
        Dim sSQL As String = "SELECT DISTINCT Int.IntForeignRR || ' - ' || T.TownName AS RRTown, Int.IntID AS IntAlias " &
            "FROM Interchange Int LEFT JOIN Town T ON T.TownCallSign = Int.IntTown " &
             "AND Int.RRID = '" & gsMyRR_ID & "' AND T.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    'Public Function spMatchIntRRName(ByRef ForeignRRAlias As String) As String

    '    Dim sSQL As String = "SELECT intForeignRR From Interchange WHERE intForeignRRAlias = '" & ForeignRRAlias & "';"
    '    Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    'End Function


    Public Function spMatchIntRRInitials(ByRef IntID As String) As String

        Dim sSQL As String = "SELECT intForeignRR From Interchange WHERE intID = '" & IntID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spMatchIntTown(ByVal ForeignRR As String) As String

        Dim sSQL As String = "SELECT Town.TownName FROM Town LEFT JOIN Interchange ON Interchange.IntTown = town.TownCallSign " & _
            "WHERE Interchange.intForeignRR = '" & ForeignRR & "' " & _
            "AND Town.RRID = '" & gsMyRR_ID & "' AND Interchange.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spMatchIntPoint(ByVal ForeignRRAlias As String) As String

        'Dim sSQL As String = "SELECT Town.TownName FROM Town LEFT JOIN Interchange ON Interchange.IntTown = Town.TownCallSign " & _
        '    "WHERE Interchange.intForeignRRAlias = '" & ForeignRRAlias & "' " & _
        '    "AND Town.RRID = '" & gsMyRR_ID & "' AND Interchange.RRID = '" & gsMyRR_ID & "';"
        Dim sSQL As String = "SELECT Town.TownName FROM Town LEFT JOIN Interchange ON Interchange.IntTown = Town.TownCallSign " &
            "WHERE Interchange.intID = '" & ForeignRRAlias & "' " &
            "AND Town.RRID = '" & gsMyRR_ID & "' AND Interchange.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spPrintGetMaxPage() As String

        Dim sSQL As String = "SELECT MAX(PrintPage) FROM Waybill WHERE RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spPrintGetWBLoadCount() As String

        Dim sSQL As String = "SELECT COUNT(*) FROM WBLoadPrintPage;"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spCommCombo() As DataTable

        Dim sSQL As String = "SELECT DISTINCT CommodityName FROM Commodity WHERE CommUse = 'X' ORDER BY CommodityName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spValidateDivNum(ByVal DivNum As String) As String

        Dim sResult As String = ""
        Dim sSQL As String = "SELECT COUNT(*) FROM Division WHERE DivNum = '" & DivNum & "' AND RRID = '" & gsMyRR_ID & "';"
        sResult = clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)
        If sResult Is Nothing Then
            Return 0
        Else
            Return sResult
        End If

    End Function


    Public Function spValidateRegCode(ByVal AARCode As String) As String

        Dim sResult As String = ""
        Dim sSQL As String = "SELECT COUNT(*) FROM AARRegionName WHERE AARCode =  '" & AARCode & "';"
        sResult = clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)
        If sResult Is Nothing Then
            Return 0
        Else
            Return sResult
        End If

    End Function


    Public Function spValidateTown(ByVal TownID As String) As String

        Dim sResult As String = ""
        Dim sSQL As String = "SELECT COUNT(*) FROM Town WHERE TownID = '" & TownID & "' AND RRID = '" & gsMyRR_ID & "';"
        sResult = clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)
        If sResult Is Nothing Then
            Return 0
        Else
            Return sResult
        End If

    End Function


    Public Function spValidateCLIC(ByVal IndName As String, ByVal City As String) As String

        Dim sResult As String = ""
        Dim sSQL As String = "SELECT CLIC FROM Industry WHERE IndName = '" & IndName & "' AND IndCity = '" & City & "' AND RRID = '" & gsMyRR_ID & "' LIMIT 1;"
        sResult = clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)
        If sResult Is Nothing Then


            Return 0


        ElseIf Mid(sResult, 1, 3) = "O/L" Then

            Return ""

        Else

            Return sResult
        End If

    End Function

    Public Function spValidateTrWork(ByVal WorkTrainName As String, ByVal WorkStopNum As String) As String

        Dim sResult As String = ""
        Dim sSQL As String = "SELECT COUNT(*) FROM TrainWork WHERE TrWorkTrainName = '" & WorkTrainName & _
        "' AND TrWorkStopNum = '" & WorkStopNum & "' AND RRID = '" & gsMyRR_ID & "';"
        sResult = clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)
        If sResult Is Nothing Then
            Return 0
        Else
            Return sResult
        End If

    End Function


    Public Function spThruCatIns(ByRef CommID As String, ByVal CommIdx As String, ByVal CommSeq As String,
                                   ByVal CarType As String, ByVal Comm As String,
                                   ByVal Notes As String, ByVal PrimarySR As String,
                                   ByVal Frequency As String, ByVal Spots As String,
                                   ByVal PriRR As String, ByVal PriInd As String,
                                   ByVal PriCity As String, ByVal PriState As String,
                                   ByVal PriClic As String,
                                   ByVal SecRR As String, ByVal SecInd As String,
                                   ByVal SecCity As String, ByVal SecState As String,
                                   ByVal SecCLIC As String,
                                   ByVal RouteIntOnAt As String, ByVal RouteIntOnWith As String,
                                   ByVal RouteIntOffAt As String, ByVal RouteIntOffWith As String,
                                   ByVal RouteIntDir As String,
                                   ByVal PrintLoadSide1 As String, ByVal RouteVerso As String,
                                   ByVal RouteIntVia As String, ByVal PrintMTYForHome As String) As Integer

        Dim sSQL As String = "INSERT INTO Catalog (RRID, CatCommID, CatCommIdx, CatCommSeq, CatCarType, CatComm, " &
            "CatNotes, CatPrimarySR, CatFrequency, CatSpots, PriRR, PriInd, PriCity, PriState, PriClic, SecRR, SecInd, " &
            "SecCity, SecState, SecClic, RouteIntOnAt, RouteIntOnWith, RouteIntOffAt, RouteIntOffWith, RouteIntDir, PrintLoadSide1, " &
            "RouteVerso, RouteIntVia, PrintMTYForHome) " &
            "VALUES ('" & gsMyRR_ID & "', '" & CommID & "', '" & CommIdx & "', '" & CommSeq & "', '" & CarType & "', '" & Comm & "', '" &
            Notes & "', '" & PrimarySR & "', '" & Frequency & "', '" & Spots & "', '" & PriRR & "', '" & PriInd & "', '" &
            PriCity & "', '" & PriState & "', '" & PriClic & "', '" & SecRR & "', '" & SecInd & "', '" & SecCity & "', '" &
            SecState & "', '" & SecCLIC & "', '" & RouteIntOnAt & "', '" & RouteIntOnWith & "', '" & RouteIntOffAt & "', '" &
            RouteIntOffWith & "', '" & RouteIntDir & "', '" & PrintLoadSide1 & "', '" & RouteVerso & "', '" & RouteIntVia & "', '" &
            PrintMTYForHome & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spThruInds(ByVal Comm As String, ByVal RegionCode As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT ind.indName || ', ' || ind.IndCity || ', ' || ind.IndState " & _
            "|| ' (' || ind.IndRR || ')' AS IndName, ind.IndID " & _
            "FROM Industry ind, AARState st WHERE ind.Commodity = '" & Comm & "' AND ind.Active = 'X' " & _
            "AND SUBSTR(ind.CLIC, 1, 3) = 'O/L' AND Ind.RRID = '" & gsMyRR_ID & "' " & _
            "AND ind.IndState IN (Select AARState FROM AARState WHERE AARRegionCode = '" & RegionCode & "');"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spThruIndsNoComm(ByVal RegionCode As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT ind.indName || ', ' || ind.IndCity || ', ' || ind.IndState " & _
            "|| ' (' || ind.IndRR || ')' AS IndName, ind.IndID " & _
            "FROM Industry ind, AARState st WHERE ind.Active = 'X' AND SUBSTR(ind.CLIC, 1, 3) = 'O/L' AND ind.RRID = '" & gsMyRR_ID & "' " & _
         "AND ind.IndState IN (Select AARState FROM AARState WHERE AARRegionCode = '" & RegionCode & "');"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTownDivNameCd() As DataTable

        Dim sSQL As String = "SELECT DivNum, DivName FROM Division WHERE RRID = '" & gsMyRR_ID & "' ORDER BY DivName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrainReport() As DataTable

        Dim sSQL As String = "SELECT Tr.TrName, Tr.TrClass, Lookup.LkDesc AS TrDirection, Tr.TrScope, " & _
            "Tr.trMaxCars, Lookup_1.LkDesc AS TrOriginateOL, Town.TownName, Lookup_2.LkDesc AS TrWorkSOPU, " & _
            "Lookup_3.LkDesc AS TrWorkWorkIndustry " & _
            "FROM Train Tr INNER JOIN TrainWork Tw ON Tr.TrID = Tw.TrWorkTrainName " & _
            "INNER JOIN Town ON Tw.TrWorkTown = Town.TownCallSign " & _
            "INNER JOIN Lookup ON Tr.TrDirection = Lookup.LkCode " & _
            "INNER JOIN Lookup AS Lookup_1 ON Tr.TrOriginateOL = Lookup_1.LkCode " & _
            "INNER JOIN Lookup AS Lookup_2 ON Tw.TrWorkSOPU = Lookup_2.LkCode " & _
            "INNER JOIN Lookup AS Lookup_3 ON Tw.TrWorkWorkIndustry = Lookup_3.LkCode " & _
            "WHERE Lookup.LkGroup='Direction' AND Lookup_1.LkGroup='YesNo' AND Lookup_2.LkGroup='YesNo' " & _
            "AND Lookup_3.LkGroup='YesNo' AND Tr.RRID = '" & gsMyRR_ID & "' AND Town.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY Tr.TrName, Tw.TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrAssnAssign2Tr(ByVal TrAssign As String, ByVal InTrainSeq As String, ByVal WaybillID As String) As Integer

        Dim sSQL As String = "UPDATE Waybill SET TrainAssignment='" & TrAssign & "', InTrainSeq= '" & InTrainSeq & "'" & _
            "WHERE WaybillID = '" & WaybillID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spTrAssnDelWB(ByRef WaybillID As String) As Integer

        Dim sSQL As String = " DELETE FROM Waybill WHERE WaybillID = '" & WaybillID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spTrAssnGetIntchgs() As DataTable

        Dim sSQL As String = "SELECT DISTINCT intTown, IntNearestOnLineInt FROM Interchange WHERE IntNearestOnLineInt <> '' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrAssnGetTrWork(ByRef TrWorkName As String) As DataTable

        Dim sSQL As String = "SELECT TrWorkID, TrWorkTrainName, TrWorkStopNum, TrWorkDirofTravel, trWorkTown, " & _
            "TrWorkSOPU, TrWorkWorkIndustry FROM TrainWork WHERE TrWorkTrainName = '" & TrWorkName & "' AND RRID = '" & gsMyRR_ID & "' ORDER BY TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrAssnMoveWB(ByVal InTrainSeq As String, ByVal WaybillID As String) As Integer

        Dim sSQL As String = "UPDATE Waybill SET InTrainSeq='" & InTrainSeq & "' WHERE WaybillID='" & WaybillID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spTrAssnUpdAssnGrid(ByRef TrainAssign As String) As DataTable

        Dim sSQL As String = "SELECT wb.WaybillID, wb.WbCarType, wb.wbComm, wb.wbNotes, wb.wbPrimarySR, wb.PriRR, " & _
            "wb.PriInd, wb.PriCity, wb.PriState, wb.PriCLIC, si.SidingNotes AS Siding, wb.PriDiv, wb.PriServBy, " & _
            "wb.SecRR, wb.SecInd, wb.SecCity, wb.SecState, wb.SecCLIC, wb.SecSiding, wb.SecDiv, wb.SecServBy, " & _
            "CASE wb.RouteVerso " & _
                "WHEN 'Through' THEN 'Through' " & _
                "WHEN 'Staging Select' THEN 'Inbound MTY' " & _
                "WHEN 'MTY Return Route' THEN 'Inbound Load' " & _
                "WHEN 'Freight Agent Select' THEN 'Freight Agent' " & _
                "WHEN 'Start at Industry' THEN 'Place at Industry' " & _
            "END AS Instructions, " & _
            "CASE " & _
                "WHEN wb.RouteVerso = 'Staging Select' AND wb.PrintLoadSide1 = 'N' THEN IFNULL(Town1.TownName, '') || '/' || IFNULL(wb.RouteIntOffWith, '') " & _
                "WHEN wb.RouteVerso = 'MTY Return Route' AND wb.PrintLoadSide1 = 'Y' THEN IFNULL(Town.TownName, '') || '/' || IFNULL(wb.RouteIntOnWith, '') " & _
                "WHEN wb.RouteVerso = 'Through' AND wb.PrintLoadSide1 = 'Y' THEN  IFNULL(Town.TownName, '') || '/' || IFNULL(wb.RouteIntOnWith, '') " & _
                "WHEN wb.RouteVerso = 'Through' AND wb.PrintLoadSide1 = 'N'  THEN IFNULL(Town1.TownName, '') || '/' || IFNULL(wb.RouteIntOffWith, '') " & _
                "WHEN wb.RouteVerso = 'Start at Industry' AND wb.PrintLoadSide1 = 'Y'  THEN IFNULL(Town1.TownName, '') || '/' || IFNULL(wb.RouteIntOffWith, '') " & _
                "WHEN wb.RouteVerso = 'Start at Industry' AND wb.PrintLoadSide1 = 'N' THEN  IFNULL(Town.TownName, '') || '/' || IFNULL(wb.RouteIntOnWith, '') " & _
                "WHEN wb.RouteVerso = 'Freight Agent Select' THEN  IFNULL(Town1.TownName, '') || '/' || IFNULL(wb.RouteIntOffWith, '') " & _
            "END AS OnOffRRAt, " & _
            "CASE " & _
                "WHEN wb.RouteVerso = 'Staging Select' THEN IFNULL(wb.PriCity, '') || ', ' || IFNULL(wb.PriState, '') " & _
                "WHEN wb.RouteVerso = 'MTY Return Route' THEN IFNULL(wb.PriCity, '') || ', ' || IFNULL(wb.PriState, '') " & _
                "WHEN wb.RouteVerso = 'Freight Agent Select'  THEN IFNULL(wb.PriCity, '') || ', ' || IFNULL(wb.PriState, '') " & _
                "WHEN wb.RouteVerso = 'Through' AND wb.PrintLoadSide1 = 'Y' THEN IFNULL(wb.SecCity, '') || ', ' || IFNULL(wb.SecState, '') " & _
                "WHEN wb.RouteVerso = 'Through' AND wb.PrintLoadSide1 = 'N' THEN IFNULL(Town1.TownName, '') || '/' || IFNULL(wb.RouteIntOffWith, '') " & _
            "END AS Destination, " & _
            "wb.RouteIntVia, wb.RouteIntDir, wb.RouteVerso, wb.TrainAssignment, wb.InTrainSeq " & _
            "FROM Waybill wb " & _
            "LEFT JOIN Town ON wb.RouteIntOnAt = Town.TownCallSign " & _
            "LEFT JOIN Town as Town1 ON wb.RouteIntOffAt = Town1.TownCallSign " & _
            "LEFT JOIN Siding Si ON wb.PriSiding = Si.SidingID " & _
            "WHERE wb.TrainAssignment = '" & TrainAssign & "' AND wb.RRID = '" & gsMyRR_ID & "' AND si.RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY wb.InTrainSeq;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spTrWorkTrainNameCd() As DataTable

        Dim sSQL As String = "SELECT TrName, TrID FROM Train WHERE RRID = '" & gsMyRR_ID & "' Order By TrName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spIndsWithCommsState() As DataTable

        Dim sSQL As String = "SELECT * FROM vwRptIndsWithCommsState;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function













End Module