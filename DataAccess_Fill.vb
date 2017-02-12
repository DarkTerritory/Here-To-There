Imports System.Data.SQLite

Module DataAccess_Fill

    Public Function spFillLookupDT(ByVal LookupGroup As String) As DataTable

        Dim sSQL As String = "SELECT LkCode, LkDesc FROM Lookup Where LkGroup = '" & LookupGroup & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spFillOutAssnMTYIns(ByVal Commodity As String, ByVal Notes As String, ByVal RouteIntOnAt As String, _
                                    ByVal RouteIntOffAt As String, ByVal RouteIntDir As String, ByVal RouteVerso As String, _
                                    ByVal TrainAssignment As String, ByVal InTrainSeq As String) As Integer

        Dim sSQL As String = "INSERT INTO Waybill (wbComm, wbNotes, RouteIntOnAt, RouteIntOffAt, RouteIntDir, RouteVerso, TrainAssignment, InTrainSeq)" & _
            "VALUES ('" & Commodity & "', '" & Notes & "', '" & RouteIntOnAt & "', '" & RouteIntOffAt & "', '" & RouteIntDir & _
            "', '" & RouteVerso & "', '" & TrainAssignment & "', '" & InTrainSeq & "');"
        Return clsSQLiteDB.ExecuteNonQuery(sSQL, cnHTT)

    End Function


    Public Function spFillOutGetFullTrList() As DataTable

        Dim sSQL As String = "SELECT Trn.TrID, Trn.TrName, Trn.TrDirection, Trn.TrType, Trn.TrClass, Trn.TrScope, Trn.trMaxCars, Trn.TrOriginateOL, " & _
            "Way.WaybillID, Way.WbCarType, Way.wbComm, Way.wbNotes, Way.wbPrimarySR, Way.PriRR, Way.PriInd, Way.PriCity, Way.PriState, " & _
            "Way.SecRR, Way.SecInd, Way.SecCity, Way.SecState, Way.RouteIntVia, Way.RouteIntDir, Way.RouteVerso, Way.TrainAssignment, Way.InTrainSeq " & _
            "FROM Waybill AS Way LEFT OUTER JOIN Train AS Trn ON Way.TrainAssignment = Trn.TrID  AND Trn.RRID = '" & gsMyRR_ID & "'  AND Way.RRID = '" & gsMyRR_ID & "'ORDER BY Trn.TrID, Way.InTrainSeq;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spFillOutGetIntrchgList() As DataTable

        Dim sSQL As String = "SELECT Itr.IntForeignRR || ' - ' || Tn.TownName AS IntPt FROM Town Tn, Interchange Itr WHERE Tn.TownCallSign = Itr.IntTown  AND En.RRID = '" & gsMyRR_ID & "' AND Itr.RRID = '" & gsMyRR_ID & "';"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spFillOutGetTrWrkData(ByVal WorkTrainName As String) As DataTable

        Dim sSQL As String = "SELECT TrWorkID, TrWorkTrainName, TrWorkStopNum, TrWorkDirofTravel, trWorkTown, TrWorkSOPU, TrWorkWorkIndustry " & _
            "FROM TrainWork WHERE TrWorkTrainName = '" & WorkTrainName & "' AND RRID = '" & gsMyRR_ID & "' ORDER BY TrWorkStopNum;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spFillOutStateChg(ByVal ListType As String) As DataTable

        Dim sSql As String = ""

        If ListType = "AAR" Then
            sSql = "SELECT AARCode, AARRegName FROM AARRegionName;"
        Else
            sSql = "SELECT AARState, AARStateName FROM AARState ORDER BY AARStateName;"
        End If
        Return clsSQLiteDB.GetDataTable(sSql, cnHTT)

    End Function


    Public Function spFillGrid(ByVal Commodity As String, ByVal ShipRecv As String, Optional ByVal IndState As String = "") As DataTable

        Dim sSQL As String = ""

        If ShipRecv <> "I" Then
            sSQL = "SELECT CLIC, IndName, IndCity, IndState, IndRR, IndShipRecv, Siding, Commodity, Notes FROM Industry WHERE ((NullIf('" & Commodity & "', '') IS NULL) OR Commodity = '" & Commodity & "') AND IndShipRecv IN ('" & ShipRecv & "', 'B') AND CLIC LIKE 'O/L%'  AND RRID = '" & gsMyRR_ID & "' AND Active = 'X' ORDER BY IndName;"

        Else
            sSQL = "SELECT CLIC, IndName, IndCity, IndState, IndRR, IndShipRecv, Siding, Commodity, Notes FROM Industry WHERE Commodity = '" & Commodity & "' AND IndState IN( '" & IndState & "') AND CLIC LIKE 'O/L%' AND RRID = '" & gsMyRR_ID & "' AND Active = 'X' ORDER BY IndName;"

        End If

        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function


    Public Function spFillGridPlus(ByVal Commodity As String, ByVal ShipRecv As String, ByVal CLIC_A As String, _
                                    ByVal CLIC_B As String, ByVal IndName As String, ByVal IndCity As String, _
                                    ByVal IndState As String, ByVal IndRR As String) As DataTable

        Dim sSQL As String = "   SELECT CLIC, IndName, IndCity, IndState, IndRR, IndShipRecv, Siding, Commodity, Notes FROM Industry " & _
            "WHERE Active = 'X' AND ((NullIf('" & Commodity & "', '') IS NULL) OR Commodity = '" & Commodity & "') " & _
            "AND ((NullIf('" & ShipRecv & "', '') IS NULL) OR IndShipRecv IN ('" & ShipRecv & "', 'B')) " & _
            "AND ((NullIf('" & CLIC_A & "', '') IS NULL) OR CLIC LIKE '" & CLIC_A & "' || '%') " & _
            "AND ((NullIf('" & CLIC_B & "', '') IS NULL) OR CLIC NOT LIKE '" & CLIC_B & "' || '%') " & _
            "AND ((NullIf('" & IndName & "', '') IS NULL) OR IndName LIKE '" & IndName & "' || '%') " & _
            "AND ((NullIf('" & IndCity & "', '') IS NULL) OR IndCity LIKE '" & IndCity & "' || '%') " & _
            "AND ((NullIf('" & IndState & "', '') IS NULL) OR IndState LIKE '" & IndState & "' || '%') " & _
            "AND ((NullIf('" & IndRR & "', '') IS NULL) OR IndRR LIKE '" & IndRR & "' || '%') " & _
            "AND RRID = '" & gsMyRR_ID & "' " & _
            "ORDER BY IndName;"
        Return clsSQLiteDB.GetDataTable(sSQL, cnHTT)

    End Function

End Module