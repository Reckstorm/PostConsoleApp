using PostConsoleApp.Boxes;
using PostConsoleApp.Vehicles;

namespace PostConsoleApp
{
    internal class WhKeeper
    {
        public string Name { get; private set; }
        public ManipulatedBoxList ManipulatedBoxList = new ManipulatedBoxList();
        public WhKeeper(string name)
        {
            Name = name;
        }

        public void LoadVehicle(Vehicle vehicle, Warehouse wh)
        {
            List<Box> temp = new List<Box>();
            for (int i = 0; i < wh.Boxes.Count; i++)
            {
                if (vehicle.Volume >= wh.Boxes[i].Volume)
                {
                    Box tempBox = wh.Boxes[i];
                    wh.Boxes.Remove(tempBox);
                    temp.Add(tempBox);
                    vehicle.Volume -= tempBox.Volume;
                    ManipulatedBoxList.IncreaceCount(tempBox);
                    wh.ManipulatedBoxList.DecreaceCount(tempBox);
                    i--;
                }
                else
                {
                    break;
                }
            }
            if (temp.Count > 0)
            {
                vehicle.Load(temp, wh);
            } 
        }

        public void UnloadVehicle(Vehicle vehicle, Warehouse wh)
        {
            List<Box> temp = new List<Box>();
            for (int i = 0; i < vehicle.Cargo.Count; i++)
            {
                temp.Add(vehicle.Cargo[i]);
                ManipulatedBoxList.IncreaceCount(temp[i]);
                wh.ManipulatedBoxList.IncreaceCount(temp[i]);
            }
            if (temp.Count > 0)
            {
                vehicle.Unload(temp, wh);
            }
            vehicle.Cargo.Clear();
        }
    }
}
