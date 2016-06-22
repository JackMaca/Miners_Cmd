namespace Miners_Cmd
{
    partial class HighScores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(461, 323);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(323, 91);
            this.score1.TabIndex = 0;
            this.score1.Text = "SCORE";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(461, 478);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(323, 91);
            this.score2.TabIndex = 1;
            this.score2.Text = "SCORE";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3.Location = new System.Drawing.Point(461, 628);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(323, 91);
            this.score3.TabIndex = 2;
            this.score3.Text = "SCORE";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(1005, 323);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(270, 91);
            this.name1.TabIndex = 3;
            this.name1.Text = "NAME";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.Location = new System.Drawing.Point(1005, 478);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(270, 91);
            this.name2.TabIndex = 4;
            this.name2.Text = "NAME";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name3.Location = new System.Drawing.Point(1005, 628);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(270, 91);
            this.name3.TabIndex = 5;
            this.name3.Text = "NAME";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.backButton;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(232, 80);
            this.backButton.TabIndex = 6;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miners_Cmd.Properties.Resources.highscoresBG;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Name = "HighScores";
            this.Size = new System.Drawing.Size(1366, 768);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.PictureBox backButton;
    }
}
