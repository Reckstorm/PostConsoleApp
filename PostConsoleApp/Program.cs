using PostConsoleApp;
using PostConsoleApp.Boxes;
using PostConsoleApp.Vehicles;
using System;

Warehouse Warehouse = new Warehouse();
Random random = new Random();
string temp = "";

do
{
    Console.Clear();
    Console.WriteLine("Enter Warehouse Keeper name");
    temp = Console.ReadLine();
} while (temp.Length == 0);

WhKeeper WhKeeper = new WhKeeper(temp);
temp = "";

while (true)
{
    Console.Clear();
    Console.WriteLine($"Total amount of boxes within the warehouse:\n" +
            $"{Warehouse.ManipulatedBoxList.SmallBoxCount} small boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.AvgBoxCount} average boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.LargeBoxCount} large boxes;");
    Vehicle tempVehicle = new Car();
    int FullEmptyVehicle = random.Next(1, 3);
    if (FullEmptyVehicle == 1)
    {
        int vehicleType = random.Next(1, 4);
        if (vehicleType == 1)
        {
            tempVehicle = new Car();
            tempVehicle.FullVehicle();
        }
        if (vehicleType == 2)
        {
            tempVehicle = new Van();
            tempVehicle.FullVehicle();
        }
        if (vehicleType == 3)
        {
            tempVehicle = new Truck();
            tempVehicle.FullVehicle();
        }
    }
    if (FullEmptyVehicle == 2)
    {
        int vehicleType = random.Next(1, 1);
        if (vehicleType == 1)
        {
            tempVehicle = new Car();
        }
        if (vehicleType == 2)
        {
            tempVehicle = new Van();
        }
        if (vehicleType == 3)
        {
            tempVehicle = new Truck();
        }
    }
    Console.WriteLine(tempVehicle.Arrive());

    if (tempVehicle.CargoFlag)
    {
        Console.WriteLine($"\n\nWarehouse Keeper {WhKeeper.Name} **unloads** cargo");
        WhKeeper.UnloadVehicle(tempVehicle, Warehouse);
        Console.WriteLine($"{WhKeeper.Name} unloaded:\n" +
            $"{WhKeeper.ManipulatedBoxList.SmallBoxCount} small boxes;\n" +
            $"{WhKeeper.ManipulatedBoxList.AvgBoxCount} average boxes;\n" +
            $"{WhKeeper.ManipulatedBoxList.LargeBoxCount} large boxes;");
        Console.WriteLine($"\n\nTotal amount of boxes within the warehouse:\n" +
            $"{Warehouse.ManipulatedBoxList.SmallBoxCount} small boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.AvgBoxCount} average boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.LargeBoxCount} large boxes;");
        WhKeeper.ManipulatedBoxList.ManipulatedBoxListClear();
        Console.WriteLine(tempVehicle.Depart());
    }

    else if (!tempVehicle.CargoFlag)
    {
        Console.WriteLine($"\n\nWarehouse Keeper {WhKeeper.Name} **loads** cargo");
        WhKeeper.LoadVehicle(tempVehicle, Warehouse);
        Console.WriteLine($"{WhKeeper.Name} loaded:\n" +
            $"{WhKeeper.ManipulatedBoxList.SmallBoxCount} small boxes;\n" +
            $"{WhKeeper.ManipulatedBoxList.AvgBoxCount} average boxes;\n" +
            $"{WhKeeper.ManipulatedBoxList.LargeBoxCount} large boxes;");
        Console.WriteLine($"\n\nTotal amount of boxes within the warehouse:\n" +
            $"{Warehouse.ManipulatedBoxList.SmallBoxCount} small boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.AvgBoxCount} average boxes;\n" +
            $"{Warehouse.ManipulatedBoxList.LargeBoxCount} large boxes;");
        WhKeeper.ManipulatedBoxList.ManipulatedBoxListClear();
        Console.WriteLine(tempVehicle.Depart());
    }
    Console.ReadLine();

}