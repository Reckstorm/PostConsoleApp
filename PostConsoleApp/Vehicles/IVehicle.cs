using PostConsoleApp.Boxes;

namespace PostConsoleApp.Vehicles
{
    internal interface IVehicle
    {
        public void Load(List<Box> boxes, Warehouse wh);
        public void Unload(List<Box> boxes, Warehouse wh);
        public string Arrive();
        public string Depart();
    }
}
