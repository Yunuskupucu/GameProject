//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

using YekGame.Forms;
using YekGame.GameComponents.GameRules;
using YekGame.GameComponents.Levels;

namespace YekGame.GameComponents.Players
{
    public class Player
    {
        private string name;
        private int x = 0;
        private int y = 1;
        private int health = 3;
        private Level level = new FirstLevel();
        private int score = 0;
        private PictureBox pictureBox;
        private static DateTime lastUpdateTime = DateTime.MinValue; // tuşa basılan son zaman
        private static readonly TimeSpan minKeyPressInterval = TimeSpan.FromSeconds(0.5); // tuşa basma aralığı (0.5 sn)

        public Player(string name)
        {
            this.name = name;
            PictureBox = new PictureBox
            {
                Image = Image.FromFile("Assets\\man_paving.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.None,
                Location = new Point(0, 75),
            };
        }


        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public Level Level { get => level; set => level = value; }
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value < 0 ? 0 : value; }


        // Oyuncuyu hareket ettirme ve konumunu kısıtlama
        public void Move(object sender, KeyEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hareketMiktari = 75;

            if (currentTime - lastUpdateTime >= minKeyPressInterval)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (PictureBox.Top == 0)
                    {
                        PictureBox.Top = 0;
                        Y = 0;
                    }
                    else
                    {
                        PictureBox.Top -= hareketMiktari;
                        Y -= 1;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (PictureBox.Top == 150)
                    {
                        PictureBox.Top = 150;
                        Y = 2;
                    }
                    else
                    {
                        PictureBox.Top += hareketMiktari;
                        Y += 1;
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (PictureBox.Left == 75 || PictureBox.Left == 0)
                    {

                    }
                    else
                    {
                        PictureBox.Left -= hareketMiktari;
                        X -= 1;
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (PictureBox.Left == 825)
                    {
                        PictureBox.Left = 825;
                        X = 11;
                    }
                    else
                    {
                        PictureBox.Left += hareketMiktari;
                        X += 1;
                    }
                }
                lastUpdateTime = currentTime;
            }
        }
    }
}
