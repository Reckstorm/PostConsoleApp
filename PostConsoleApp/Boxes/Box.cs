using System.Net.NetworkInformation;

namespace PostConsoleApp.Boxes
{
    internal abstract class Box : IComparable<Box>
    {
        public string? Name { get; private set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Height { get; private set; }

        public int Volume { get; private set; }
        private Box() { }

        public Box(int width, int length, int height, string name)
        {
            Width = width;
            Length = length;
            Height = height;
            Name = name;
            Volume = Width * Length * Height;
        }

        public int CompareTo(Box? other)
        {
            if (other == null) throw new ArgumentException("Некорректное значение параметра");
            return Volume - other.Volume;
        }
    }
}
