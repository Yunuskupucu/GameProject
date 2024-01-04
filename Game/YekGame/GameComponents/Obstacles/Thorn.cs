//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.GameComponents.Obstacles
{
    public class Thorn : Obstacle
    {
        private readonly int obstacleCount = 10;
        private int y;
        private readonly List<(int, int)> locationList = new List<(int, int)>();

        public Thorn() : base(Image.FromFile("Assets\\thorn_paving.png"))
        {
        }

        public override List<(int, int)> DetermineObstacleLocations()
        {
            for (int i = 1; i <= obstacleCount; i++)
            {
                Random rnd = new Random();

                if(i % 2 == 0)
                {
                    var tempY = -1;
                    for (int j = 0; j<2; ++j)
                    {
                        var x = i;
                        var yLoc = rnd.Next(0, 3);
                        var y = yLoc == tempY ? 3 - yLoc : yLoc;
                        locationList.Add((x, y));
                        tempY = y;
                    }
                }
            }

            return locationList;
        }

        public override List<(int, int)> RefreshLocations()
        {
            return locationList;
        }
    }
}
