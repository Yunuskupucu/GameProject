namespace YekGame.Forms
{
    public partial class GameWin : Form
    {
        private readonly string playerName;
        private readonly string score;
        private readonly string filePath = "scores.txt";
        private Dictionary<string, int> scoreDict; // isimleri ve skorları tutan yapı


        public GameWin(string playerName, string score)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.score = score;
            this.scoreDict = new Dictionary<string, int>();

            playerNameLabel.Text = playerName;  
            scoreLabel.Text += score;

            KeepScore();
        }
        // skorları ve oyuncunun isimlerini dosyadan ekler dictionary e ekler
        private void ReadScoresAndPlayersFromFile()
        {
            try
            {
                using StreamReader reader = new StreamReader(FilePath);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var splittedLine = line.Split("/");
                    var playerNameInFile = splittedLine[0];
                    var scoreInFile = Convert.ToInt32(splittedLine[1]);

                    scoreDict.Add(playerNameInFile, scoreInFile);
                }
            } catch(FileNotFoundException) {
                WriteScoreToFile();
            }
        }

        // Oyuncu isimlerini ve skorlarını listeye dönüştürüp dosyaya yazma 
        private void WriteScoreToFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(FilePath))
            {
                List<string> playerNameList = scoreDict.Keys.ToList();
                List<int> scoreList = scoreDict.Values.ToList();

                for (int i = 0; i < scoreDict.Count(); ++i)
                {
                    streamWriter.WriteLine(playerNameList[i] + "/ " + scoreList[i]);
                }
            }
        }

        // Aynı isimli oyuncunun skorunu yeniden değerlendirip sıralar sonra dosyaya yazar
        private void AppendCurrentScoreToScoreDict()
        {
            try
            {
                scoreDict.Add(playerName, Convert.ToInt32(score));
            }
            catch (ArgumentException)
            {
                int oldScore;
                scoreDict.TryGetValue(playerName, out oldScore);
                if (oldScore < Convert.ToInt32(score))
                {
                    scoreDict[playerName] = Convert.ToInt32(score);
                }
            }

            var sortedDict = scoreDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            if (sortedDict.Last().Key == playerName && sortedDict.Last().Value == Convert.ToInt32(score) && sortedDict.Count > 5)
            {
                sortedDict.Remove(sortedDict.Last().Key);
            }

            scoreDict = sortedDict;
        }

        private void KeepScore()
        {
            ReadScoresAndPlayersFromFile();

            if (scoreDict.Count == 0) 
            {
                scoreDict.Add(playerName, Convert.ToInt32(score));
                WriteScoreToFile();
                return;
            }

            AppendCurrentScoreToScoreDict();
            WriteScoreToFile();
        }

        public string PlayerName => playerName;

        public string Score => score;

        public string FilePath => filePath;
    }
}
