//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.Forms
{
    partial class GameWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameWinLabel = new Label();
            scoreLabel = new Label();
            playerNameLabel = new Label();
            SuspendLayout();
            // 
            // gameWinLabel
            // 
            gameWinLabel.AutoSize = true;
            gameWinLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            gameWinLabel.ForeColor = Color.Lime;
            gameWinLabel.Location = new Point(146, 187);
            gameWinLabel.Name = "gameWinLabel";
            gameWinLabel.Size = new Size(508, 57);
            gameWinLabel.TabIndex = 0;
            gameWinLabel.Text = "KAZANDINIZ TEBRİKLER";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(321, 265);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(90, 37);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Skor: ";
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            playerNameLabel.ForeColor = Color.White;
            playerNameLabel.Location = new Point(321, 137);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(0, 37);
            playerNameLabel.TabIndex = 2;
            // 
            // GameWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(playerNameLabel);
            Controls.Add(scoreLabel);
            Controls.Add(gameWinLabel);
            Name = "GameWin";
            Text = "GameWin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameWinLabel;
        private Label scoreLabel;
        private Label playerNameLabel;
    }
}