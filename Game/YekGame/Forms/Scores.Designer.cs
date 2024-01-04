//Geliştirici: Yunus Emre KÜPÜCÜ
//Öğrenci No: b231200378
//Konu: Kaçış Oyunu

namespace YekGame.Forms
{
    partial class Scores
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
            scoresDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)scoresDataGridView).BeginInit();
            SuspendLayout();
            // 
            // scoresDataGridView
            // 
            scoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoresDataGridView.Location = new Point(12, 2);
            scoresDataGridView.Name = "scoresDataGridView";
            scoresDataGridView.RowHeadersWidth = 51;
            scoresDataGridView.Size = new Size(776, 447);
            scoresDataGridView.TabIndex = 0;
            // 
            // Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoresDataGridView);
            Name = "Scores";
            Text = "Scores";
            ((System.ComponentModel.ISupportInitialize)scoresDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView scoresDataGridView;
    }
}