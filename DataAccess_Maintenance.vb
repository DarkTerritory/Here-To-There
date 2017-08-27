Module DataAccess_Maintenance


    Public Function spMAarRegNameDelRec(ByRef AARCode As String) As Integer

        Dim sSQL As String = "DELETE FROM AARRegionName WHERE AARCode = '" & AARCode & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarRegNameIns(ByRef AARCode As String, ByVal RegionName As String) As Integer

        Dim sSQL As String = "INSERT INTO AARRegionName(AARCode, AARRegName) VALUES ('" & AARCode & "', '" & RegionName & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarRegNameUpdate(ByRef AARCode As String, ByVal RegionName As String) As Integer

        Dim sSQL As String = "UPDATE AARRegionName SET AARCode = '" & AARCode & "', AARRegName = '" & RegionName & "' WHERE AARCode = '" & AARCode & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarRRDelRec(ByRef Railroad As String) As Integer

        Dim sSQL As String = "DELETE FROM AARRRCode WHERE Railroad = '" & Railroad & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarRRIns(ByRef AAR As String, ByVal Railroad As String, ByVal ReportMark As String) As Integer

        Dim sSQL As String = "INSERT INTO AARRRCode(AAR, Railroad, ReportMark)" & _
            "VALUES ('" & AAR & "', '" & Railroad & "', '" & ReportMark & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarRRUpdate(ByRef AAR As String, ByVal Railroad As String, _
                                    ByVal ReportMark As String, ByVal UpdRailroad As String) As Integer

        Dim sSQL As String = "UPDATE AARRRCode SET AAR='" & AAR & "', Railroad='" & Railroad & "', ReportMark='" & _
            ReportMark & "' WHERE Railroad = '" & UpdRailroad & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarStateDelRec(ByRef AARState As String) As Integer

        Dim sSQL As String = "DELETE FROM AARState WHERE AARState = '" & AARState & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarStateIns(ByRef Region As String, ByVal State As String, ByVal StateName As String) As Integer

        Dim sSQL As String = "INSERT INTO AARState(AARRegionCode, AARState, AARStateName) " & _
            "VALUES ('" & Region & "', '" & State & "', '" & StateName & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarStateUpdate(ByRef Region As String, ByVal State As String, _
                                    ByVal StateName As String, ByVal UpdState As String) As Integer

        Dim sSQL As String = "UPDATE AARState SET AARRegionCode='" & Region & "', AARState='" & _
            State & "', AARStateName='" & StateName & "' WHERE AARState='" & UpdState & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMAarStateValdt(ByRef AARState As String) As String

        Dim sSQL As String = "SELECT  Count(*) FROM AARState WHERE AARState = '" & AARState & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spMCarTypeDelRec(ByRef CarTypeID As String) As Integer

        Dim sSQL As String = "DELETE FROM AARCarTypes WHERE ID = '" & CarTypeID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMCarTypeIns(ByRef AARCode As String, ByVal AARDesc As String) As Integer

        Dim sSQL As String = "INSERT INTO AARCartypes (AARCode, AARDesc) VALUES ('" & AARCode & "', '" & AARDesc & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMCarTypeUpdate(ByRef AARCode As String, ByVal AARDesc As String, _
                                    ByRef CarTypeID As String) As Integer

        Dim sSQL As String = "UPDATE AARCartypes SET AARCode='" & AARCode & "', AARDesc='" & AARDesc & "' WHERE ID = '" & CarTypeID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMCommCarType() As DataTable

        Dim sSQL As String = "SELECT AARDesc, AARCode FROM AARCarTypes ORDER BY AARDesc;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMCommDelRec(ByRef CommName As String) As Integer

        Dim sSQL As String = "DELETE FROM Commodity WHERE CommodityName = '" & CommName & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMCommFillGrid() As DataTable

        Dim sSQL As String = "SELECT Commodity.CommUse, Commodity.CommodityName, Lookup.LkDesc AS CommPriority, " & _
            "Commodity.CommAARType1, Commodity.CommAARType2, Commodity.CommAARType3, Commodity.CommNotes " & _
            "FROM Commodity LEFT JOIN Lookup ON Commodity.CommPriority = Lookup.LkCode WHERE Lookup.LkGroup = 'Priority' " & _
            "ORDER BY Commodity.CommodityName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMCommInsert(ByRef CommUse As String, ByVal CommName As String, ByVal CommPriority As String, _
                                   ByVal CarType1 As String, ByVal CarType2 As String, ByVal CarType3 As String, _
                                   ByVal Notes As String) As Integer

        Dim sSQL As String = "INSERT INTO Commodity (CommUse, CommodityName, CommPriority, CommAARCarType1, " & _
            "CommAARCarType2, CommAARCarType3, CommNotes)" & _
        "VALUES ('" & CommUse & "', '" & CommName & "', '" & CommPriority & "', '" & CarType1 & "', '" & CarType2 & _
        "', '" & CarType3 & "', '" & Notes & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMCommNameCount(ByRef CommName As String) As String

        Dim sSQL As String = "SELECT Count(*) FROM Commodity WHERE CommodityName = '" & CommName & "';"
        Return clsSQLiteDB.ExecuteScalar(sSQL, cnHTT)

    End Function


    Public Function spMCommUpdate(ByRef CommUse As String, ByVal CommPriority As String, _
                                   ByVal CarType1 As String, ByVal CarType2 As String, ByVal CarType3 As String, _
                                   ByVal Notes As String, ByVal CommName As String) As Integer

        Dim sSQL As String = "UPDATE Commodity SET CommUse='" & CommUse & "', CommPriority='" & CommPriority & _
            "', CommAARCarType1='" & CarType1 & "', CommAARCarType2='" & CarType2 & "', CommAARCarType3='" & CarType3 & _
            "', CommNotes='" & Notes & "' WHERE CommodityName='" & CommName & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMDivDelRec(ByRef DivisionNum As String) As Integer

        Dim sSQL As String = "DELETE FROM Division WHERE DivNum = '" & DivisionNum & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMDivIns(ByRef DivNum As String, ByVal DivName As String, ByVal DivEndPointEast As String, _
                                   ByVal DivEndPointWest As String) As Integer

        Dim sSQL As String = "INSERT INTO Division (RRID, DivNum, DivName, DivEndPointEast, DivEndPointWest)" & _
            "VALUES ('" & gsMyRR_ID & "', '" & DivNum & "', '" & DivName & "', '" & DivEndPointEast & "', '" & DivEndPointWest & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMDivUpdate(ByVal DivName As String, ByVal DivEndPointEast As String, _
                                   ByVal DivEndPointWest As String, ByRef DivNum As String) As Integer

        Dim sSQL As String = "UPDATE Division SET DivName='" & DivName & "', DivEndPointEast='" & DivEndPointEast & _
            "', DivEndPointWest='" & DivEndPointWest & "' WHERE DivNum = '" & DivNum & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIndDelRec(ByRef IndNum As String) As Integer

        Dim sSQL As String = "DELETE FROM Industry WHERE IndID = '" & IndNum & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIndHighClic(ByVal CLIC As String) As DataTable

        Dim sSQL As String = "SELECT CLIC FROM Industry WHERE CLIC LIKE '" & CLIC & "%'  AND RRID = '" & gsMyRR_ID & "' ORDER BY CLIC DESC;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMIndInsert(ByRef Active As String, ByVal CLIC As String, ByVal IndName As String, _
                                   ByVal IndCity As String, ByVal IndState As String, _
                                   ByVal IndRR As String, ByVal ShipRecv As String, _
                                   ByVal Commodity As String, ByVal Notes As String) As Integer

        Dim sSQL As String = "INSERT INTO Industry (RRID, Active, CLIC, IndName, IndCity, IndState, IndRR, IndShipRecv, Commodity, Notes) " & _
            "VALUES ('" & gsMyRR_ID & "', '" & Active & "', '" & CLIC & "', '" & IndName & "', '" & IndCity & "', '" & IndState & _
            "', '" & IndRR & "', '" & ShipRecv & "', '" & Commodity & "', '" & Notes & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIndInsertOnLine(ByRef Active As String, ByVal CLIC As String, ByVal IndName As String, _
                                   ByVal IndCity As String, ByVal IndState As String, _
                                   ByVal IndRR As String, ByVal ShipRecv As String, _
                                   ByVal Commodity As String, ByVal Notes As String, _
                                   ByVal Siding As String, ByVal Frequency As String, _
                                   ByVal Spots As String) As Integer

        Dim sSQL As String = "INSERT INTO Industry (RRID, Active, CLIC, IndName, IndCity, IndState, IndRR, IndShipRecv, " & _
            "Commodity, Notes, Siding, Frequency, Spots) " & _
            "VALUES ('" & gsMyRR_ID & "', '" & Active & "', '" & CLIC & "', '" & IndName & "', '" & IndCity & "', '" & IndState & _
            "', '" & IndRR & "', '" & ShipRecv & "', '" & Commodity & "', '" & Notes & "', '" & Siding & _
            "', '" & Frequency & "', '" & Spots & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIndStateList() As DataTable

        Dim sSQL As String = "SELECT AARState FROM AARState ORDER BY AARState;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMIndUpdate(ByRef Active As String, ByVal CLIC As String, _
                                   ByVal IndName As String, ByVal IndCity As String, ByVal IndState As String, _
                                   ByVal IndRR As String, ByVal ShipRecv As String, _
                                   ByVal Comm As String, ByVal Notes As String, ByVal IndID As String) As Integer

        Dim sSQL As String = "UPDATE Industry SET Active='" & Active & "', CLIC='" & CLIC & "', IndName='" & IndName & _
            "', IndCity='" & IndCity & "', IndState='" & IndState & "', IndRR='" & IndRR & "', IndShipRecv='" & ShipRecv & _
            "', Commodity='" & Comm & "', Notes= '" & Notes & "' WHERE IndID='" & IndID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIndUpdateOnLine(ByRef Active As String, ByVal CLIC As String, _
                                   ByVal IndName As String, ByVal IndCity As String, ByVal IndState As String, _
                                   ByVal IndRR As String, ByVal ShipRecv As String, _
                                   ByVal Comm As String, ByVal Notes As String, ByVal IndID As String, _
                                   ByVal Siding As String, ByVal Frequency As String, _
                                   ByVal Spots As String) As Integer

        Dim sSQL As String = "UPDATE Industry SET Active='" & Active & "', CLIC='" & CLIC & "', IndName='" & IndName & _
            "', IndCity='" & IndCity & "', IndState='" & IndState & "', IndRR='" & IndRR & "', IndShipRecv='" & ShipRecv & _
            "', Commodity='" & Comm & "', Notes= '" & Notes & "' , Siding='" & Siding & "', Frequency='" & Frequency & _
            "', Spots='" & Spots & "' WHERE IndID='" & IndID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIntDelRec(ByRef IntID As String) As Integer

        Dim sSQL As String = "DELETE FROM Interchange WHERE IntID = '" & IntID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIntInsert(ByRef IntTown As String, ByVal IntPrimaryRR As String, ByVal IntForeignRR As String, _
                                   ByVal IntForeignRRDir As String, ByVal IntNearestOnLineInt As String, _
                                   ByVal IntStagingArea As String) As Integer

        Dim sSQL As String = "INSERT INTO Interchange (RRID, IntTown, IntPrimaryRR, IntForeignRR, IntForeignRRDir, " & _
            "IntNearestOnLineInt, IntStagingArea) " & _
            "VALUES ('" & gsMyRR_ID & "', '" & IntTown & "', '" & IntPrimaryRR & "', '" & IntForeignRR & "', '" & IntForeignRRDir & _
            "', '" & IntNearestOnLineInt & "', '" & IntStagingArea & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMIntUpdate(ByRef IntTown As String, ByVal IntPrimaryRR As String, ByVal IntForeignRR As String, _
                                   ByVal IntForeignRRDir As String, ByVal IntNearestOnLineInt As String, _
                                   ByVal IntStagingArea As String, ByVal IntID As String) As Integer

        Dim sSQL As String = "UPDATE Interchange SET IntTown='" & IntTown & "', IntPrimaryRR='" & IntPrimaryRR & _
            "', IntForeignRR='" & IntForeignRR & "', IntForeignRRDir='" & IntForeignRRDir & _
            "', IntNearestOnLineInt='" & IntNearestOnLineInt & "', IntStagingArea='" & IntStagingArea & _
            "' WHERE IntID='" & IntID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMSidAARCode() As DataTable

        Dim sSQL As String = "SELECT Railroad, ReportMark FROM AARRRCode;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMSidDelRec(ByRef SidingID As String) As Integer

        Dim sSQL As String = "DELETE FROM Siding WHERE SidingID =  '" & SidingID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMSidFillGrid() As DataTable

        Dim sSQL As String = "SELECT Sid.SidingID, Sid.SidingNotes, RR.Railroad AS SidingRR, " & _
            "Town.TownName AS SidingTown, Sid.SidingCars, Lk.LkDesc AS SidingFaces " & _
            "FROM Siding AS Sid LEFT JOIN Town ON Sid.SidingTown = Town.TownCallSign " & _
            "LEFT JOIN AARRRCode AS RR ON Sid.SidingRR = RR.ReportMark " & _
            "INNER JOIN Lookup AS Lk ON Sid.SidingFaces = Lk.LkCode WHERE Lk.LkGroup = 'SidingFaces' " & _
            "AND sid.RRID = '" & gsMyRR_ID & "' ORDER BY Sid.SidingNotes, Sid.SidingID;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMSidInsert(ByRef SidingID As String, ByVal SidingNotes As String, ByVal SidingRR As String, _
                                   ByVal SidingTown As String, ByVal SidingCars As String, _
                                   ByVal SidingFaces As String) As Integer

        Dim sSQL As String = "INSERT INTO Siding (RRID, SidingNotes, SidingRR, SidingTown, SidingCars, SidingFaces)" & _
            "VALUES ('" & gsMyRR_ID & "', '" & SidingNotes & "', '" & SidingRR & "', '" & SidingTown & _
            "', '" & SidingCars & "', '" & SidingFaces & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMSidTown() As DataTable

        Dim sSQL As String = "SELECT TownCallSign, TownName FROM Town Where RRID = '" & gsMyRR_ID & "' ORDER BY TownName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMSidUpdate(ByVal SidingNotes As String, ByRef SidingID As String, ByVal SidingRR As String, _
                                   ByVal SidingTown As String, ByVal SidingCars As String, _
                                   ByVal SidingFaces As String, ByRef UpdSidingID As String) As Integer

        Dim sSQL As String = "UPDATE Siding SET SidingNotes='" & SidingNotes & _
            "', SidingRR='" & SidingRR & "', SidingTown='" & SidingTown & "', SidingCars='" & SidingCars & _
            "', SidingFaces='" & SidingFaces & "' WHERE SidingID='" & SidingID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMStagingDelRec(ByRef StgID As Integer) As Integer

        Dim sSQL As String = "DELETE FROM StagingArea WHERE StgID = " & StgID & " AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMStagingIns(ByRef LkCode As String, ByVal LkDesc As String) As Integer

        Dim sSQL As String = "INSERT INTO StagingArea (StagingCode, StagingDesc, RRID) " & _
            "VALUES ('" & LkCode & "', '" & LkDesc & "', '" & gsMyRR_ID & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMStagingUpdate(ByVal StgID As Integer, ByRef LkCode As String, ByVal LkDesc As String) As Integer

        Dim sSQL As String = "UPDATE StagingArea SET StagingCode = '" & LkCode & "', StagingDesc = '" & LkDesc & "' " & _
            "WHERE StgID = '" & StgID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTownDelRec(ByRef TownID As String) As Integer

        Dim sSQL As String = "DELETE FROM Town WHERE TownID = '" & TownID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTownDivNameCd() As DataTable

        Dim sSQL As String = "SELECT DivNum, DivName FROM Division WHERE RRID = '" & gsMyRR_ID & "'ORDER BY DivName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spMTownIns(ByVal TownName As String, ByVal TownState As String, _
                                   ByVal TownCallSign As String, ByVal TownFrtHub As String, _
                                   ByVal TownServedBy As String, ByVal TownDiv As String, _
                                   ByVal TownEastOf As String, ByVal TownWestOf As String, ByVal TownLocal As String) As Integer

        Dim sSQL As String = "INSERT INTO Town (RRID, TownID, TownName, TownState, TownCallSign, TownFrtHub, TownServedBy, " & _
            "TownDiv, TownEastOf, TownWestOf, TownLocal) VALUES ('" & gsMyRR_ID & "', '" & TownName & "', '" & TownState & "', '" & _
            TownCallSign & "', '" & TownFrtHub & "', '" & TownServedBy & "', '" & TownDiv & "', '" & TownEastOf & "', '" & TownWestOf & "', '" & TownLocal & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTownUpdate(ByRef TownID As String, ByVal TownName As String, ByVal TownState As String, _
                                   ByVal TownCallSign As String, ByVal TownFrtHub As String, _
                                   ByVal TownServedBy As String, ByVal TownDiv As String, _
                                   ByVal TownEastOf As String, ByVal TownWestOf As String, ByVal TownLocal As String) As Integer

        Dim sSQL As String = "UPDATE Town SET TownID='" & TownID & "', TownName='" & TownName & "', TownState='" & TownState & _
            "', TownCallSign='" & TownCallSign & "', TownFrtHub='" & TownFrtHub & "', TownServedBy='" & TownServedBy & _
            "', TownDiv='" & TownDiv & "', TownEastOf='" & TownEastOf & "', TownWestOf='" & TownWestOf & _
            "', TownLocal='" & TownLocal & "' WHERE TownID='" & TownID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrainDelRec(ByRef TrainID As String) As Integer

        Dim sSQL As String = "DELETE FROM Train WHERE TrID = '" & TrainID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrainIns(ByRef TrName As String, ByVal TrDirection As String, ByVal TrType As String, _
                                   ByVal TrClass As String, ByVal TrScope As String, _
                                   ByVal TrMaxCars As String, ByVal TrPctThru As String, ByVal TrAllowLowPriority As String, _
                                   ByVal TrOriginateOL As String, ByVal trDepartTime As String, _
                                   ByVal FromStagingArea As String) As Integer

        Dim sSQL As String = "INSERT INTO Train (RRID, TrName, TrDirection, TrType, TrClass, TrScope, TrMaxCars, " & _
            "TrPctThru, TrAllowLowPriority, TrOriginateOL, trDepartTime, TrFromStagingArea)" & _
            "VALUES ('" & gsMyRR_ID & "', '" & TrName & "', '" & TrDirection & "', '" & TrType & "', '" & TrClass & "', '" & TrScope & _
            "', '" & TrMaxCars & "', '" & TrPctThru & "', '" & TrAllowLowPriority & "', '" & TrOriginateOL & _
            "', '" & trDepartTime & "', '" & FromStagingArea & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrainUpdate(ByRef TrName As String, ByVal TrDirection As String, ByVal TrType As String, _
                                   ByVal TrClass As String, ByVal TrScope As String, _
                                   ByVal TrMaxCars As String, ByVal TrPctThru As String, _
                                   ByVal TrAllowLowPriority As String, ByVal TrOriginateOL As String, _
                                   ByVal trDepartTime As String, ByVal FromStagingArea As String, _
                                   ByVal TrainID As String) As Integer

        Dim sSQL As String = "UPDATE Train SET TrName='" & TrName & "', TrDirection='" & TrDirection & _
            "', TrType='" & TrType & "', TrClass='" & TrClass & "', TrScope='" & TrScope & _
            "', trMaxCars='" & TrMaxCars & "', TrPctThru='" & TrPctThru & "', TrAllowLowPriority='" & TrAllowLowPriority & _
            "', TrOriginateOL='" & TrOriginateOL & "', TrDepartTime='" & trDepartTime & _
            "', TrFromStagingArea='" & FromStagingArea & "' WHERE TrID='" & TrainID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrWorkDelRec(ByRef TrainWorkID As String) As Integer

        Dim sSQL As String = "DELETE FROM TrainWork WHERE TrWorkID = '" & TrainWorkID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrWorkIns(ByRef TrWorkTrainName As String, ByVal TrWorkStopNum As String, _
                                   ByVal TrWorkDirOfTravel As String, ByVal TrWorkTown As String, _
                                   ByVal TrWorkSOPU As String, ByVal TrWorkWorkIndustry As String) As Integer

        Dim sSQL As String = "INSERT INTO TrainWork (RRID, TrWorkTrainName, TrWorkStopNum, TrWorkDirOfTravel, " & _
            "TrWorkTown, TrWorkSOPU, TrWorkWorkIndustry) VALUES ('" & gsMyRR_ID & "', '" & TrWorkTrainName & "', '" & TrWorkStopNum & _
            "', '" & TrWorkDirOfTravel & "', '" & TrWorkTown & "', '" & TrWorkSOPU & "', '" & TrWorkWorkIndustry & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMTrWorkUpdate(ByVal TrWorkStopNum As String, ByVal TrWorkDirOfTravel As String, _
                                     ByVal TrWorkTown As String, ByVal TrWorkSOPU As String, _
                                     ByVal TrWorkWorkIndustry As String, ByVal TrWorkID As String) As Integer

        Dim sSQL As String = "UPDATE TrainWork SET TrWorkStopNum='" & TrWorkStopNum & "', " & _
            "TrWorkDirofTravel='" & TrWorkDirOfTravel & "', TrWorkTown='" & TrWorkTown & "', " & _
            "TrWorkSOPU='" & TrWorkSOPU & "', TrWorkWorkIndustry='" & TrWorkWorkIndustry & "' WHERE TrWorkID='" & TrWorkID & "' AND RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMyRRUpdate(ByVal RRID As Integer, ByVal RRName As String, ByVal RRInitials As String,
                                     ByVal RRNickname As String, ByVal RRState As String,
                                     ByVal RREra As String, ByVal RRPrototype As String) As Integer

        Dim sSQL As String = "UPDATE MyRR SET RRName = '" & RRName & "', RRInitials = '" & RRInitials & "', " &
            "RRNickname = '" & RRNickname & "', RRState = '" & RRState & "', RREra = '" & RREra & "', RRPrototype = '" & RRPrototype & "' " &
            "WHERE RRID = " & RRID & ";"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMyRRInsert(ByVal RRID As Integer, ByVal RRName As String, ByVal RRInitials As String,
                                     ByVal RRNickname As String, ByVal RRState As String,
                                     ByVal RREra As String, ByVal RRPrototype As String) As Integer

        Dim sSQL As String = "INSERT INTO MyRR (RRID, RRName, RRInitials, RRNickname, RRState, RREra, RRPrototype)  " &
            "VALUES ('" & RRID & "', '" & RRName & "', '" & RRInitials & "', '" & RRNickname & "', '" & RRState &
            "', '" & RREra & "', '" & RRPrototype & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spMyRRDelete(ByVal RRID As Integer) As Integer

        Dim sSQL As String = "DELETE FROM MyRR WHERE RRID = " & RRID & ";"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function






















































End Module