//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.GameComponents.Obstacles;

namespace YekGame.GameComponents.Levels 
{
    public class FirstLevel : Level // Level sınıfı miras alındı
    {
        public FirstLevel() : base(new Thorn(), 3, "Level 1")
        {
            GenerateRandomObstacle();
        }

        public void GenerateRandomObstacle()
        {
            Random rnd = new Random();
            var obstacleNumber = rnd.Next(0, 3);

            if(obstacleNumber == 0)
            {
                base.Obstacle = new Trap();
            }else if(obstacleNumber == 1)
            {
                base.Obstacle = new Thorn();
            }else if (obstacleNumber == 2)
            {
                base.Obstacle = new Fire();
            }
        }
    }
}
