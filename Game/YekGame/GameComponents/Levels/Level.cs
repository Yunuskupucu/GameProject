//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.GameComponents.Obstacles;

namespace YekGame.GameComponents.Levels
{
    // Level sınıfını abstract olarak tanımlandı
    public abstract class Level
    {
        private Obstacle _obstacle;
        private int _obstacleGenerateTime;
        private readonly string _name;

        protected Level(Obstacle obstacle, int obstacleGenerateTime, string name)
        {
            _obstacle = obstacle;
            _obstacleGenerateTime = obstacleGenerateTime;
            _name = name;
        }


        public int ObstacleGenerateTime { get => _obstacleGenerateTime; set => _obstacleGenerateTime = value; }
        public Obstacle Obstacle { get => _obstacle; set => _obstacle = value; }
        public string Name => _name;
    }
}
