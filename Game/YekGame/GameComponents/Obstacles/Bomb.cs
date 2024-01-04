//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.GameComponents.Obstacles
{
    public class Bomb : Obstacle // Obstacle sınıfı miras alındı
    {
        private readonly int obstacleCount = 10;

        public Bomb() : base(Image.FromFile("Assets\\bomb_paving.png"))
        {
        }

        public override List<(int, int)> DetermineObstacleLocations() // Konumlar için location list oluşturuldu
        {
            var locationList = new List<(int, int)>();

            // engelleri düzenleyerek oyunun oynanabilirliği artırıldı

            for(int i = 1; i<= obstacleCount; i++) 
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

        // Bombaların konumlarını yeniden belirler
        public override List<(int, int)> RefreshLocations()
        {
            return DetermineObstacleLocations();
        }
    }
}
