using YekGame.GameComponents.Board;
using YekGame.GameComponents.GameRules;
using YekGame.GameComponents.Levels;
using YekGame.GameComponents.Players;
using Timer = System.Windows.Forms.Timer;

namespace YekGame.Forms
{
    public partial class OyunEkrani : Form
    {
        private readonly Board _board;
        private readonly Timer timer = new Timer();
        private readonly Player player;
        private readonly GameRule gameRules;
        private int pauseKeyPress = 0;

        private List<(int, int)> obstacleLocations;

        private double time = 0;
        private Level level;

        public OyunEkrani(string name)
        {
            _board = new Board();
            player = new Player(name);
            gameRules = new GameRule(player);

            // Form üzerindeki KeyDown olayını dinleyerek klavye tuşlarına tepki verebiliriz.
            //this.KeyDown += player.Move;
            this.KeyUp += player.Move;
            this.KeyPress += PauseGame;

            // Form üzerindeki KeyPreview özelliğini true olarak ayarlayarak formun klavye olaylarını dinlemesini sağlarız.
            this.KeyPreview = true;

            // Engellerin konumunu belirle
            obstacleLocations = player.Level.Obstacle.DetermineObstacleLocations();
            InitializeComponent();
        }

        // Oyun durdurma (P ye basma sayısına göre)
        private void PauseGame(object? sender, KeyPressEventArgs e)
        {
            pauseKeyPress += 1;
            if ((e.KeyChar == 'p' || e.KeyChar == 'P') && pauseKeyPress % 2 == 1)
            {
                timer.Stop();
                this.KeyUp -= player.Move;
            }else
            {
                timer.Start();
                this.KeyUp += player.Move;
            }
        }

        private void OyunEkrani_Load(object sender, EventArgs e)
        {
            timer.Interval = 500; // 1000 milisaniye = 1 saniye
            timer.Tick += TimerTick;
            timer.Start(); // Timer'ı başlat

            gecenSureVariableLabel.Text = time.ToString();
            kalanCanVariableLabel.Text = player.Health.ToString();
            puanVariableLabel.Text = gameRules.CurrentScore.ToString();
            seviyeVariableLabel.Text = player.Level.Name;
            oyuncuVariableLabel.Text = player.Name;
        }


        private void TimerTick(object? sender, EventArgs e)
        {
            // Kazanma durumu
            var win = gameRules.WinControl(false);
            if (win)
            {
                timer.Stop();
                this.Close();
            }
            
            seviyeVariableLabel.Text = player.Level.Name; // seviyeyi label a yazma

            // Oyuncu alana girmeden süre başlatmama
            if (player.PictureBox.Left == 0 && time == 0)
            {
                DrawBoard();
                return;
            }

            // Tam sayı zaman dilimlerini gösterir. (Oyun 500 ms de bir akar.)
            if (time - (int)time == 0)
            {
                gecenSureVariableLabel.Text = time.ToString();
            }
            DrawBoard();

            // Level oynanışlarını belirle
            if (player.Level.Name == "Level 1")
            {
                FirstLevelGamePlay();
            }
            else if (player.Level.Name == "Level 2")
            {
                SecondLevelGamePlay();
            }
            else if (player.Level.Name == "Level 3")
            {
                ThirdLevelGamePlay();
            }
            time += 0.5;

            // Çarpışma ve skor hesaplamalarını saniye başı kontrol eder.
            if(time - (int)time == 0)
            {
                gameRules.CollisionControl(obstacleLocations);
                kalanCanVariableLabel.Text = player.Health.ToString();

                gameRules.ScoreCalculation((int)time, player.Health);
                puanVariableLabel.Text = gameRules.CurrentScore.ToString();
            }

        }
        // Üçüncü seviyenin oynanışı
        public void ThirdLevelGamePlay()
        {
            boardPanel.Controls.Clear();

            // belirlenen zaman aralığının katlarına denk eldiğinde engel üret
            if (time % player.Level.ObstacleGenerateTime == 0)
            {
                player.Level.Obstacle.DetermineObstacleLocations();
            }

            // Üçüncü seviyede engellerin bulunduğu konumları yeniden hesaplayıp tahtayı oluştur
            obstacleLocations = player.Level.Obstacle.RefreshLocations();
            DrawBoard();
        }

        public void FirstLevelGamePlay()
        {
        }

        public void SecondLevelGamePlay()
        {
            player.PictureBox.BringToFront(); // Player resmini ön planda tut
            if (time % player.Level.ObstacleGenerateTime == 0)
            {
                boardPanel.Controls.Clear();
                obstacleLocations = player.Level.Obstacle.RefreshLocations();
            }
            DrawBoard();
        }

        // Oyun alanındaki tüm pictureboxları çizer
        public List<PictureBox> DrawBoard()
        {
            var boardPictureBoxList = _board.GenerateBoard(obstacleLocations, player);

            foreach (var boardPicture in boardPictureBoxList)
            {
                boardPanel.Controls.Add(boardPicture);
            }
            boardPanel.Controls.Add(player.PictureBox);
            player.PictureBox.BringToFront();


            return boardPictureBoxList;
        }

    }
}


//TODO:
//Resimlerin yolları düzeltilecek
//Kazanma ve kaybetme durumlarında ekranlar gösterilecek
//Mümkünse yazdığın şu arap saçı gibi olan kodları düzelt az okunabilir hale getir
//En yüksek skora sahip 5 oyuncu listesini tut ve bunu ana menüde göster yada tuşa basıldığında göster
//Az yorum satırı da ekle kodu okuyana vahiy inmiycek ya
//Tüm bunları yaparken uygulamayı bozma (opsiyonel)