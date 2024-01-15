

//Планируемые затраты на плитку

decimal plannedCostOfTiles1, plannedCostOfTiles2, plannedCostOfTiles3;

{
    decimal sandForTail1 = 5, sandForTail2 = 3, sandForTail3 = 2;

    decimal clayForTail1 = 4, clayForTail2 = 7, clayForTail3 = 6;

    decimal sandPrice = 70, clayPrice = 50; // rub.kg

    //Планируемый объем плитки
    decimal plannedVolumeOfTiles1 = 80, plannedVolumeOfTiles2 = 140, plannedVolumeOfTiles3 = 60;

    //Расчитать планируемые затраты на Плитку: 1-2-3
    plannedCostOfTiles1 = (sandForTail1 * sandPrice + clayForTail1 * clayPrice) * plannedVolumeOfTiles1;
    plannedCostOfTiles2 = (sandForTail2 * sandPrice + clayForTail2 * clayPrice) * plannedVolumeOfTiles2;
    plannedCostOfTiles3 = (sandForTail3 * sandPrice + clayForTail3 * clayPrice) * plannedVolumeOfTiles3;
}

decimal totalcost = plannedCostOfTiles1 + plannedCostOfTiles2 + plannedCostOfTiles3;

Console.WriteLine($"Общая стоимость сырья = {totalcost}");