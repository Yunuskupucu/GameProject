//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame
{
    partial class AnaMenu
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
            tusTakimiBilgisiLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            enYuksekSkorButton = new Button();
            oyuncuAdiTextBox = new TextBox();
            oyuncuAdiLabel = new Label();
            baslatButton = new Button();
            SuspendLayout();
            // 
            // tusTakimiBilgisiLabel
            // 
            tusTakimiBilgisiLabel.AutoSize = true;
            tusTakimiBilgisiLabel.ForeColor = Color.White;
            tusTakimiBilgisiLabel.Location = new Point(42, 373);
            tusTakimiBilgisiLabel.Name = "tusTakimiBilgisiLabel";
            tusTakimiBilgisiLabel.Size = new Size(121, 20);
            tusTakimiBilgisiLabel.TabIndex = 0;
            tusTakimiBilgisiLabel.Text = "Tuş Takımı Bilgisi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 416);
            label1.Name = "label1";
            label1.Size = new Size(402, 20);
            label1.TabIndex = 1;
            label1.Text = "Oyuncuyu hareket ettirmek için yön tuşlarını kullanabilirsiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 459);
            label2.Name = "label2";
            label2.Size = new Size(329, 20);
            label2.TabIndex = 2;
            label2.Text = "Oyunu duraklatmak için P tuşunu kullanabilirsiniz";
            // 
            // enYuksekSkorButton
            // 
            enYuksekSkorButton.Location = new Point(731, 459);
            enYuksekSkorButton.Name = "enYuksekSkorButton";
            enYuksekSkorButton.Size = new Size(200, 29);
            enYuksekSkorButton.TabIndex = 3;
            enYuksekSkorButton.Text = "En Yüksek Skorlar";
            enYuksekSkorButton.UseVisualStyleBackColor = true;
            enYuksekSkorButton.Click += enYuksekSkorButton_Click;
            // 
            // oyuncuAdiTextBox
            // 
            oyuncuAdiTextBox.Location = new Point(430, 117);
            oyuncuAdiTextBox.Name = "oyuncuAdiTextBox";
            oyuncuAdiTextBox.Size = new Size(249, 27);
            oyuncuAdiTextBox.TabIndex = 4;
            // 
            // oyuncuAdiLabel
            // 
            oyuncuAdiLabel.AutoSize = true;
            oyuncuAdiLabel.ForeColor = Color.White;
            oyuncuAdiLabel.Location = new Point(339, 124);
            oyuncuAdiLabel.Name = "oyuncuAdiLabel";
            oyuncuAdiLabel.Size = new Size(85, 20);
            oyuncuAdiLabel.TabIndex = 5;
            oyuncuAdiLabel.Text = "Oyuncu Adı";
            // 
            // baslatButton
            // 
            baslatButton.Location = new Point(585, 173);
            baslatButton.Name = "baslatButton";
            baslatButton.Size = new Size(94, 29);
            baslatButton.TabIndex = 6;
            baslatButton.Text = "Başlat";
            baslatButton.UseVisualStyleBackColor = true;
            baslatButton.Click += baslatButton_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(1021, 635);
            Controls.Add(baslatButton);
            Controls.Add(oyuncuAdiLabel);
            Controls.Add(oyuncuAdiTextBox);
            Controls.Add(enYuksekSkorButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tusTakimiBilgisiLabel);
            Name = "AnaMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tusTakimiBilgisiLabel;
        private Label label1;
        private Label label2;
        private Button enYuksekSkorButton;
        private TextBox oyuncuAdiTextBox;
        private Label oyuncuAdiLabel;
        private Button baslatButton;
    }
}