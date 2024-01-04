//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.GameComponents.Obstacles
{
    public abstract class Obstacle // obstacle abstract olarak tanımlandı
    {
        private readonly Image obstacleImage;
        private readonly int damage = 1;

        protected Obstacle(Image obstacleImage)
        {
            this.obstacleImage = obstacleImage;
        }

        public int Damage => damage;
        public Image ObstacleImage => obstacleImage;


        public abstract List<(int, int)> DetermineObstacleLocations();
        public abstract List<(int, int)> RefreshLocations();

    }
}
