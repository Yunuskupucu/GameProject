//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.GameComponents.Obstacles
{
    public class Trap : Obstacle
    {
        private readonly int obstacleCount = 10;
        private readonly List<(int, int)> locationList = new List<(int, int)>();
        
        public Trap() : base(Image.FromFile("Assets\\trap_paving.png"))
        {
        }

        public override List<(int, int)> DetermineObstacleLocations()
        {
            for (int i = 1; i <= obstacleCount; i++)
            {
                Random rnd = new Random();

                if (i % 2 == 0)
                {
                    var tempY = -1;
                    for (int j = 0; j < 2; ++j)
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
            locationList.Clear();
            DetermineObstacleLocations();
            return locationList;
        }
    }
}
