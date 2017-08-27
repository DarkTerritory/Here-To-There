Train List

Select tr.trName, 
	tr.trClass, 
	tr.TrDirection, 
	tr.trDepartTime, 
	tr.TrScope, 
	tr.TrMaxCars, 
	tr.TrOriginateOL, 
	tw.TrWorkStopNum, 
	town.TownName, 
	tw.TrWorkWorkIndustry, 
	tw.TrWorkSOPU
FROM Train tr, TrainWork tw, Town 
WHERE tr.trid = tw.TrWorkTrainName
	AND tw.trWorkTown = town.TownCallSign
	AND tr.RRID = 0
	AND tw.RRID = 0
	AND town.RRID = 0
ORDER BY tr.TrID, tw.TrWorkStopNum


Waybill Balance

Select RouteIntDir As Staging, 
	Count(RouteIntDir) as Waybills 
from Catalog 
WHERE RouteVerso NOT NULL 
Group BY RouteIntDir;

SELECT TrFromStagingArea AS Staging, 
	Sum(trMaxCars) as Slots 
FROM Train 
Where TrFromStagingArea <> 'OnLine' 
Group By TrFromStagingArea;