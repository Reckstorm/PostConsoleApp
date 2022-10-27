using PostConsoleApp.Boxes;

namespace PostConsoleApp
{
    internal class Warehouse
    {
        public List<Box> Boxes;

        private Random random;

        public ManipulatedBoxList ManipulatedBoxList = new ManipulatedBoxList();

        public Warehouse()
        {
            random = new Random();
            List<Box> temp = new List<Box>();
            for (int i = 0; i < 3; i++)
            {
                int boxCount = random.Next(1, 50);
                if (i == 0)
                {
                    for (int j = 0; j < boxCount; j++)
                    {
                        temp.Add(new SmallBox());
                        ManipulatedBoxList.IncreaceCount(temp[temp.Count - 1]);
                    }
                }
                if (i == 1)
                {
                    for (int j = 0; j < boxCount; j++)
                    {
                        temp.Add(new AvgBox());
                        ManipulatedBoxList.IncreaceCount(temp[temp.Count - 1]);
                    }
                }
                if (i == 2)
                {
                    for (int j = 0; j < boxCount; j++)
                    {
                        temp.Add(new LargeBox());
                        ManipulatedBoxList.IncreaceCount(temp[temp.Count - 1]);
                    }
                }
            }
            Boxes = temp;
        }
    }
}
