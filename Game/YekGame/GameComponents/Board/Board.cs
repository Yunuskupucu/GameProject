//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.GameComponents.Levels;
using YekGame.GameComponents.Players;

namespace YekGame.GameComponents.Board
{   // Oyun alanını oluştur
    public class Board
    {
        private readonly int _width = 10;
        private readonly int _height = 3;


        // Oyun içindeki tüm pictureBox ların listesini döndür

        public List<PictureBox> GenerateBoard(List<(int, int)> obstacleLocations, Player player)
        {
            List<PictureBox> boardPictureBoxes = new List<PictureBox>();

            for (int i = 1; i <= _width; i++)
            {

                if (player.Level.Name == "Level 1")
                {
                    player.Level = new FirstLevel();
                }

                for (int j = 0; j < _height; j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = obstacleLocations.Contains((i,j)) ? player.Level.Obstacle.ObstacleImage : Image.FromFile("Assets\\paving.png"),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.None,
                        Location = new Point(i * 75, j * 75),
                    };

                    boardPictureBoxes.Add(pictureBox);
                }
            }

            PictureBox flagPictureBox = new PictureBox()
            {
                Image = Image.FromFile("Assets\\finish-flag.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.None,
                Location = new Point(825, 75),
            };

            boardPictureBoxes.Add(flagPictureBox);

            return boardPictureBoxes;
        }
    }
}
