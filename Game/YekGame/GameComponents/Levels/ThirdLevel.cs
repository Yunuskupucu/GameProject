//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.GameComponents.Obstacles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace YekGame.GameComponents.Levels
{
    public class ThirdLevel : Level // Level sınıfı miras alındı
    {
        public ThirdLevel() : base(new Enemy(), 2, "Level 3")
        {
        }
    }
}
