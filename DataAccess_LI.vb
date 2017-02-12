Imports System.Data.SQLite

Module DataAccess_LI

    Public Function spLICarType(ByVal CommName As String) As DataTable

        Dim sSQL As String = "SELECT commAARType1, commAARType2, commAARType3 FROM Commodity WHERE UPPER(CommodityName) = UPPER('" & CommName & "') AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLICatUpdate(ByVal CommID As String, ByVal CommIdx As String, ByVal CarType As String, _
                                   ByVal Comm As String, ByVal Notes As String, ByVal ShipRecv As String, _
                                   ByVal Freq As Integer, ByVal Spots As Integer, ByVal PriRR As String, _
                                   ByVal PriInd As String, ByVal PriCity As String, ByVal PriState As String, _
                                   ByVal CLIC As String, ByVal Siding As String, ByVal PriDiv As String, _
                                   ByVal ServBy As String) As Integer

        Dim sSQL As String = "INSERT INTO Catalog (RRID, CatCommID, CatCommIdx, CatCommSeq, CatCarType, CatComm, CatNotes, " & _
            "CatPrimarySR, CatFrequency, CatSpots, PriRR, PriInd, PriCity, PriState, PriCLIC, PriSiding, PriDiv, PriServBy) " & _
            "VALUES ('" & gsMyRR_ID & "', '" & CommID & "', '" & CommIdx & "', 0, '" & CarType & "', '" & Comm & "', '" & Notes & "', '" & _
            ShipRecv & "', '" & Freq & "', '" & Spots & "', '" & PriRR & "', '" & PriInd & "', '" & PriCity & "', '" & _
            PriState & "', '" & CLIC & "', '" & Siding & "', '" & PriDiv & "', '" & ServBy & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spCatFillGrid() As DataTable

        Dim sSQL As String = "SELECT CatalogID, CatCommID, CatCommIdx, CatCarType, CatComm, CatNotes, CatPrimarySR, PriRR, " & _
            "PriInd, PriCity, PriState, PriCLIC, PriSiding, PriDiv, PriServBy, SecRR, SecInd, SecCity, SecState, SecCLIC, " & _
            "SecSiding, SecDiv, SecServBy, RouteIntOnWith, RouteIntOnAt, RouteIntOffWith, RouteIntOffAt, RouteIntVia, " & _
            "RouteIntDir, RouteVerso, PrintLoadSide1, PrintMTYForHome FROM Catalog WHERE RRID = '" & gsMyRR_ID & "' ORDER BY PriState, PriCity, PriInd;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillComm(ByVal IndName As String, ByVal IndCity As String, ByVal IndSiding As String) As DataTable

        Dim sSQL As String = "SELECT Ind.IndID, Ind.CLIC, Ind.Commodity, Lookup.LkDesc AS Shiprecv, Ind.Spots " & _
            "FROM Industry AS Ind LEFT JOIN Lookup ON Ind.IndShipRecv = Lookup.LkCode WHERE Lookup.LkGroup = 'ShipRecv' " & _
            "AND Ind.IndName = '" & IndName & "' AND Ind.IndCity = '" & IndCity & "' and Ind.Siding = '" & IndSiding & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillCommAny() As DataTable

        Dim sSQL As String = "SELECT CLIC, CommodityName AS Commodity,  'B' AS ShipRecv, 1 AS Spots FROM Commodity WHERE CommUse = 'X';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillGrid() As DataTable

        Dim sSQL As String = "SELECT Ind.IndID, Ind.Active, Ind.UseRec, Ind.Selected, Ind.CLIC, Ind.IndName, " & _
            "Ind.IndCity, Ind.IndState, Ind.IndRR, Lookup.LkDesc As ShipRecv, Ind.Commodity, Ind.Cartype, " & _
            "Siding.SidingNotes AS Siding, Ind.Frequency, Ind.Spots, Ind.Allocated, Ind.Notes " & _
            "FROM Industry(Ind)	LEFT OUTER JOIN Siding ON Ind.Siding = Siding.SidingID " & _
            "LEFT OUTER JOIN Lookup ON Ind.IndShipRecv = Lookup.LkCode AND Lookup.LkGroup = 'ShipRecv' " & _
            "WHERE Ind.Active = 'X' AND LEFT(Ind.CLIC, 3) <> 'O/L' AND Ind.RRID = '" & gsMyRR_ID & "' " & _
            "AND Siding.RRID = '" & gsMyRR_ID & "' ORDER BY CLIC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillInd(ByVal IndSiding As String) As DataTable

        Dim sSQL As String = "SELECT DISTINCT indName FROM Industry WHERE Siding = '" & IndSiding & "' AND Active = 'X' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillSidings(ByVal SidingTown As String) As DataTable

        Dim sSQL As String = "SELECT SidingNotes, SidingID, SidingTown, SidingCars, SidingFaces FROM Siding WHERE SidingTown = '" & SidingTown & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIFillTowns() As DataTable

        Dim sSQL As String = "SELECT TownName, TownState, TownCallSign, TownFrtHub, TownservedBy, TownDiv FROM Town WHERE TownLocal IN ('Y', 'U') AND RRID = '" & gsMyRR_ID & "' ORDER BY TownName"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spLIIndDetail(ByVal CLIC As String) As DataTable

        Dim sSQL As String = "SELECT IndID, CLIC, IndName, IndCity, IndState, IndRR, IndShiprecv, Commodity, Cartype, Siding, Frequency, Spots, Notes FROM Industry WHERE CLIC = '" & CLIC & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function










End Module
