//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.GameComponents.Obstacles;

namespace YekGame.GameComponents.Levels
{
    public class SecondLevel : Level // Level sınıfı miras alındı
    {
        public SecondLevel() : base(new Bomb(), 3, "Level 2")
        {
        }
    }
}
