using YekGame.Forms;

namespace YekGame
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void baslatButton_Click(object sender, EventArgs e)
        {
            using OyunEkrani oyunEkrani = new OyunEkrani(oyuncuAdiTextBox.Text);
            this.Hide();
            oyunEkrani.ShowDialog();
        }

        private void enYuksekSkorButton_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.Show();
        }
    }
}
