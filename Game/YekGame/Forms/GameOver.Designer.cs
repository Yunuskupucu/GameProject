//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.Forms
{
    partial class GameOver
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
            gameOverLabel = new Label();
            tryAgainButton = new Button();
            SuspendLayout();
            // 
            // gameOverLabel
            // 
            gameOverLabel.AutoSize = true;
            gameOverLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(255, 191);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(288, 57);
            gameOverLabel.TabIndex = 0;
            gameOverLabel.Text = "KAYBETTİNİZ";
            // 
            // tryAgainButton
            // 
            tryAgainButton.Location = new Point(301, 276);
            tryAgainButton.Name = "tryAgainButton";
            tryAgainButton.Size = new Size(177, 29);
            tryAgainButton.TabIndex = 1;
            tryAgainButton.Text = "Tekrar Deneyin";
            tryAgainButton.UseVisualStyleBackColor = true;
            tryAgainButton.Click += tryAgainButton_Click;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(tryAgainButton);
            Controls.Add(gameOverLabel);
            Name = "GameOver";
            Text = "GameOver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameOverLabel;
        private Button tryAgainButton;
    }
}