using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YekGame.Forms
{
    public partial class Scores : Form
    {
        private readonly string filePath = "scores.txt";

        public Scores()
        {
            InitializeComponent();

            scoresDataGridView.Columns.Add("playerName", "Oyuncu Adı");
            scoresDataGridView.Columns.Add("score", "Skor");
            GetHighestScores();   
        }

        public string FilePath => filePath;

        // Yüksek skorların dosyaya yazılması
        private void GetHighestScores()
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

                    scoresDataGridView.Rows.Add(playerNameInFile, scoreInFile);
                }
            }
            catch (FileNotFoundException)
            {
                ;
            }
        }
    }
}
