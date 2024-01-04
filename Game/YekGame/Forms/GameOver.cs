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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void tryAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaMenu mainMenu = new AnaMenu();
            mainMenu.Show();
        }
    }
}
