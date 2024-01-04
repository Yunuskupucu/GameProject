//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu


using YekGame.GameComponents.Players;
using YekGame.GameComponents.Levels;
using YekGame.Forms;

namespace YekGame.GameComponents.GameRules
{
    public class GameRule
    {
        private int currentScore = 2500;
        private readonly Player player;

        public GameRule(Player player)
        {
            this.player = player;
        }

        public int CurrentScore { get => currentScore; set => currentScore = value; }

        // Skor hesaplama
        public void ScoreCalculation(int time, int health)
        {
            CurrentScore = health * 500 + (1000 - time);
        }

        // Oyunucu ile engellerin çarpışma kontrolü
        public void CollisionControl(List<(int, int)> obstacleLocations)
        {   
            // Engellerin bulunduğu konum ile oyuncunun bulunduğu konum aynı olduğunda çarpışma gerçekleşir
            if(obstacleLocations.Contains((player.X, player.Y)))
            {
                player.Health -= 1;
            }
            else
            {

            }
        }

        public bool LevelControl()
        {

            if (player.X == 11)
            {
                if(player.Level.Name == "Level 1")
                {
                    player.Level = new SecondLevel();
                }else if(player.Level.Name == "Level 2")
                {
                    player.Level = new ThirdLevel();
                }
                else
                {
                    GameWin gameWin = new GameWin(player.Name, currentScore.ToString());
                    gameWin.Show();
                    return true;
                }

                // Oyuncuyu başa döndür 
                player.X = 0;
                player.Y = 1;
                player.PictureBox.Left = 0;
                player.PictureBox.Top = 75;

            }

            return false;
        }

        // Kazanma kontrolü
        public bool WinControl(bool isWin)
        {
            if (player.Health == 0 || CurrentScore == 0)
            {
                GameOver gameOver = new GameOver();
                gameOver.Show();

                return true;
            }

            return LevelControl();
        }
    }
}
