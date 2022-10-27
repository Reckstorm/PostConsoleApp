using PostConsoleApp.Boxes;

namespace PostConsoleApp
{
    internal class ManipulatedBoxList
    {
        public int SmallBoxCount { get; set; }
        public int AvgBoxCount { get; set; }
        public int LargeBoxCount { get; set; }

        public ManipulatedBoxList()
        {
            ManipulatedBoxListClear();
        }

        public void IncreaceCount(Box box)
        {
            if (box.Name == "SmallBox")
            {
                SmallBoxCount++;
            }
            else if (box.Name == "AvgBox")
            {
                AvgBoxCount++;
            }
            else if (box.Name == "LargeBox")
            {
                LargeBoxCount++;
            }
        }

        public void DecreaceCount(Box box)
        {
            if (box.Name == "SmallBox")
            {
                SmallBoxCount--;
            }
            else if (box.Name == "AvgBox")
            {
                AvgBoxCount--;
            }
            else if (box.Name == "LargeBox")
            {
                LargeBoxCount--;
            }
        }
        public void ManipulatedBoxListClear()
        {
            SmallBoxCount = 0;
            AvgBoxCount = 0;
            LargeBoxCount = 0;
        }
    }
}
