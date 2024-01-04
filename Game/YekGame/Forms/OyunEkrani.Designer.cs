//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.Forms
{
    partial class OyunEkrani
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
            ustBilgilerPanel = new Panel();
            oyuncuVariableLabel = new Label();
            seviyeVariableLabel = new Label();
            puanVariableLabel = new Label();
            kalanCanVariableLabel = new Label();
            gecenSureVariableLabel = new Label();
            oyuncuLabel = new Label();
            seviyeLabel = new Label();
            puanLabel = new Label();
            kalanCanLabel = new Label();
            gecenSureLabel = new Label();
            boardPanel = new Panel();
            ustBilgilerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ustBilgilerPanel
            // 
            ustBilgilerPanel.BackColor = Color.Silver;
            ustBilgilerPanel.Controls.Add(oyuncuVariableLabel);
            ustBilgilerPanel.Controls.Add(seviyeVariableLabel);
            ustBilgilerPanel.Controls.Add(puanVariableLabel);
            ustBilgilerPanel.Controls.Add(kalanCanVariableLabel);
            ustBilgilerPanel.Controls.Add(gecenSureVariableLabel);
            ustBilgilerPanel.Controls.Add(oyuncuLabel);
            ustBilgilerPanel.Controls.Add(seviyeLabel);
            ustBilgilerPanel.Controls.Add(puanLabel);
            ustBilgilerPanel.Controls.Add(kalanCanLabel);
            ustBilgilerPanel.Controls.Add(gecenSureLabel);
            ustBilgilerPanel.Location = new Point(3, 5);
            ustBilgilerPanel.Name = "ustBilgilerPanel";
            ustBilgilerPanel.Size = new Size(1096, 179);
            ustBilgilerPanel.TabIndex = 0;
            // 
            // oyuncuVariableLabel
            // 
            oyuncuVariableLabel.AutoSize = true;
            oyuncuVariableLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            oyuncuVariableLabel.Location = new Point(971, 60);
            oyuncuVariableLabel.Name = "oyuncuVariableLabel";
            oyuncuVariableLabel.Size = new Size(65, 28);
            oyuncuVariableLabel.TabIndex = 9;
            oyuncuVariableLabel.Text = "label5";
            // 
            // seviyeVariableLabel
            // 
            seviyeVariableLabel.AutoSize = true;
            seviyeVariableLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            seviyeVariableLabel.Location = new Point(637, 79);
            seviyeVariableLabel.Name = "seviyeVariableLabel";
            seviyeVariableLabel.Size = new Size(137, 54);
            seviyeVariableLabel.TabIndex = 8;
            seviyeVariableLabel.Text = "label4";
            // 
            // puanVariableLabel
            // 
            puanVariableLabel.AutoSize = true;
            puanVariableLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            puanVariableLabel.Location = new Point(435, 79);
            puanVariableLabel.Name = "puanVariableLabel";
            puanVariableLabel.Size = new Size(137, 54);
            puanVariableLabel.TabIndex = 7;
            puanVariableLabel.Text = "label3";
            // 
            // kalanCanVariableLabel
            // 
            kalanCanVariableLabel.AutoSize = true;
            kalanCanVariableLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kalanCanVariableLabel.Location = new Point(235, 79);
            kalanCanVariableLabel.Name = "kalanCanVariableLabel";
            kalanCanVariableLabel.Size = new Size(137, 54);
            kalanCanVariableLabel.TabIndex = 6;
            kalanCanVariableLabel.Text = "label2";
            // 
            // gecenSureVariableLabel
            // 
            gecenSureVariableLabel.AutoSize = true;
            gecenSureVariableLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gecenSureVariableLabel.Location = new Point(49, 79);
            gecenSureVariableLabel.Name = "gecenSureVariableLabel";
            gecenSureVariableLabel.Size = new Size(137, 54);
            gecenSureVariableLabel.TabIndex = 5;
            gecenSureVariableLabel.Text = "label1";
            // 
            // oyuncuLabel
            // 
            oyuncuLabel.AutoSize = true;
            oyuncuLabel.Location = new Point(971, 26);
            oyuncuLabel.Name = "oyuncuLabel";
            oyuncuLabel.Size = new Size(58, 20);
            oyuncuLabel.TabIndex = 4;
            oyuncuLabel.Text = "Oyuncu";
            // 
            // seviyeLabel
            // 
            seviyeLabel.AutoSize = true;
            seviyeLabel.Location = new Point(670, 26);
            seviyeLabel.Name = "seviyeLabel";
            seviyeLabel.Size = new Size(51, 20);
            seviyeLabel.TabIndex = 3;
            seviyeLabel.Text = "Seviye";
            // 
            // puanLabel
            // 
            puanLabel.AutoSize = true;
            puanLabel.Location = new Point(472, 26);
            puanLabel.Name = "puanLabel";
            puanLabel.Size = new Size(41, 20);
            puanLabel.TabIndex = 2;
            puanLabel.Text = "Puan";
            // 
            // kalanCanLabel
            // 
            kalanCanLabel.AutoSize = true;
            kalanCanLabel.Location = new Point(264, 26);
            kalanCanLabel.Name = "kalanCanLabel";
            kalanCanLabel.Size = new Size(75, 20);
            kalanCanLabel.TabIndex = 1;
            kalanCanLabel.Text = "Kalan Can";
            // 
            // gecenSureLabel
            // 
            gecenSureLabel.AutoSize = true;
            gecenSureLabel.Location = new Point(67, 22);
            gecenSureLabel.Name = "gecenSureLabel";
            gecenSureLabel.Size = new Size(83, 20);
            gecenSureLabel.TabIndex = 0;
            gecenSureLabel.Text = "Geçen Süre";
            // 
            // boardPanel
            // 
            boardPanel.Location = new Point(3, 217);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(1081, 433);
            boardPanel.TabIndex = 1;
            // 
            // OyunEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1096, 705);
            Controls.Add(boardPanel);
            Controls.Add(ustBilgilerPanel);
            ForeColor = Color.Black;
            Name = "OyunEkrani";
            Text = "OyunEkrani";
            Load += OyunEkrani_Load;
            ustBilgilerPanel.ResumeLayout(false);
            ustBilgilerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ustBilgilerPanel;
        private Label gecenSureLabel;
        private Label oyuncuLabel;
        private Label seviyeLabel;
        private Label puanLabel;
        private Label kalanCanLabel;
        private Label oyuncuVariableLabel;
        private Label seviyeVariableLabel;
        private Label puanVariableLabel;
        private Label kalanCanVariableLabel;
        private Label gecenSureVariableLabel;
        private Panel boardPanel;
    }
}