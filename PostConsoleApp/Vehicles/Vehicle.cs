using PostConsoleApp.Boxes;

namespace PostConsoleApp.Vehicles
{
    internal class Vehicle : IVehicle
    {
        public string? Name { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Height { get; private set; }
        public int Volume { get; set; }
        public bool CargoFlag { get; private set; }
        public List<Box>? Cargo { get; set; }

        Random random = new Random();
        private Vehicle() { }

        public Vehicle(int width, int length, int height, string name)
        {
            Width = width;
            Length = length;
            Height = height;
            Name = name;
            Volume = Width * Length * Height;
            CargoFlag = false;
        }
        public string Arrive()
        {
            return $"**{Name}** arrived to Warehouse";
        }

        public string Depart()
        {
            return $"**{Name}** departed from Warehouse";
        }

        public void Load(List<Box> boxes, Warehouse wh)
        {
            Cargo = boxes;
            CargoFlag = true;
        }

        public void Unload(List<Box> boxes, Warehouse wh)
        {
            wh.Boxes.AddRange(boxes);
            wh.Boxes.Sort();
            CargoFlag = false;
        }

        public void FullVehicle()
        {
            List<Box> temp = new List<Box>();
            Box? tempBox;
            while (true)
            {
                int boxType = random.Next(1, 4);
                if (boxType == 1)
                {
                    tempBox = new SmallBox();
                    if (Volume > tempBox.Volume)
                    {
                        temp.Add(tempBox);
                        Volume -= tempBox.Volume;
                    }
                    else
                    {
                        break;
                    }
                }
                if (boxType == 2)
                {
                    tempBox = new AvgBox();
                    if (Volume > tempBox.Volume)
                    {
                        temp.Add(tempBox);
                        Volume -= tempBox.Volume;
                    }
                    else
                    {
                        break;
                    }
                }
                if (boxType == 3)
                {
                    tempBox = new LargeBox();
                    if (Volume > tempBox.Volume)
                    {
                        temp.Add(tempBox);
                        Volume -= tempBox.Volume;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Cargo = temp;
            CargoFlag = true;
        }
    }
}