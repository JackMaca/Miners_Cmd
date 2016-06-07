namespace Miners_Cmd
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.activeEffectBox = new System.Windows.Forms.PictureBox();
            this.gameCountdown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.dh1 = new System.Windows.Forms.PictureBox();
            this.dh3 = new System.Windows.Forms.PictureBox();
            this.dh2 = new System.Windows.Forms.PictureBox();
            this.dh4 = new System.Windows.Forms.PictureBox();
            this.dh5 = new System.Windows.Forms.PictureBox();
            this.buffTimer = new System.Windows.Forms.Timer(this.components);
            this.activeTimer = new System.Windows.Forms.Label();
            this.rockScore = new System.Windows.Forms.Label();
            this.ironScore = new System.Windows.Forms.Label();
            this.goldScore = new System.Windows.Forms.Label();
            this.mythrilScore = new System.Windows.Forms.Label();
            this.platinumScore = new System.Windows.Forms.Label();
            this.adamantiteScore = new System.Windows.Forms.Label();
            this.crystalScore = new System.Windows.Forms.Label();
            this.diamondScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activeEffectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh5)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 32;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Green;
            this.scoreLabel.Location = new System.Drawing.Point(1226, 81);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(69, 26);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.Color.Red;
            this.highscoreLabel.Location = new System.Drawing.Point(1207, 212);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(110, 26);
            this.highscoreLabel.TabIndex = 1;
            this.highscoreLabel.Text = "Highscore";
            // 
            // activeEffectBox
            // 
            this.activeEffectBox.BackColor = System.Drawing.Color.Transparent;
            this.activeEffectBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeEffectBox.Location = new System.Drawing.Point(1182, 353);
            this.activeEffectBox.Name = "activeEffectBox";
            this.activeEffectBox.Size = new System.Drawing.Size(100, 100);
            this.activeEffectBox.TabIndex = 2;
            this.activeEffectBox.TabStop = false;
            // 
            // gameCountdown
            // 
            this.gameCountdown.AutoSize = true;
            this.gameCountdown.BackColor = System.Drawing.Color.Transparent;
            this.gameCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameCountdown.ForeColor = System.Drawing.Color.White;
            this.gameCountdown.Location = new System.Drawing.Point(571, 227);
            this.gameCountdown.Name = "gameCountdown";
            this.gameCountdown.Size = new System.Drawing.Size(206, 226);
            this.gameCountdown.TabIndex = 3;
            this.gameCountdown.Text = "5";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // dh1
            // 
            this.dh1.BackColor = System.Drawing.Color.Transparent;
            this.dh1.BackgroundImage = global::Miners_Cmd.Properties.Resources.deadheart;
            this.dh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dh1.Location = new System.Drawing.Point(1171, 496);
            this.dh1.Name = "dh1";
            this.dh1.Size = new System.Drawing.Size(84, 70);
            this.dh1.TabIndex = 6;
            this.dh1.TabStop = false;
            this.dh1.Visible = false;
            // 
            // dh3
            // 
            this.dh3.BackColor = System.Drawing.Color.Transparent;
            this.dh3.BackgroundImage = global::Miners_Cmd.Properties.Resources.deadheart;
            this.dh3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dh3.Location = new System.Drawing.Point(1171, 588);
            this.dh3.Name = "dh3";
            this.dh3.Size = new System.Drawing.Size(84, 70);
            this.dh3.TabIndex = 7;
            this.dh3.TabStop = false;
            this.dh3.Visible = false;
            // 
            // dh2
            // 
            this.dh2.BackColor = System.Drawing.Color.Transparent;
            this.dh2.BackgroundImage = global::Miners_Cmd.Properties.Resources.deadheart;
            this.dh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dh2.Location = new System.Drawing.Point(1274, 496);
            this.dh2.Name = "dh2";
            this.dh2.Size = new System.Drawing.Size(84, 70);
            this.dh2.TabIndex = 8;
            this.dh2.TabStop = false;
            this.dh2.Visible = false;
            // 
            // dh4
            // 
            this.dh4.BackColor = System.Drawing.Color.Transparent;
            this.dh4.BackgroundImage = global::Miners_Cmd.Properties.Resources.deadheart;
            this.dh4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dh4.Location = new System.Drawing.Point(1274, 588);
            this.dh4.Name = "dh4";
            this.dh4.Size = new System.Drawing.Size(84, 70);
            this.dh4.TabIndex = 9;
            this.dh4.TabStop = false;
            this.dh4.Visible = false;
            // 
            // dh5
            // 
            this.dh5.BackColor = System.Drawing.Color.Transparent;
            this.dh5.BackgroundImage = global::Miners_Cmd.Properties.Resources.deadheart;
            this.dh5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dh5.Location = new System.Drawing.Point(1171, 676);
            this.dh5.Name = "dh5";
            this.dh5.Size = new System.Drawing.Size(84, 70);
            this.dh5.TabIndex = 10;
            this.dh5.TabStop = false;
            this.dh5.Visible = false;
            // 
            // buffTimer
            // 
            this.buffTimer.Interval = 1;
            this.buffTimer.Tick += new System.EventHandler(this.buffTimer_Tick);
            // 
            // activeTimer
            // 
            this.activeTimer.AutoSize = true;
            this.activeTimer.BackColor = System.Drawing.Color.Transparent;
            this.activeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTimer.ForeColor = System.Drawing.Color.White;
            this.activeTimer.Location = new System.Drawing.Point(1284, 353);
            this.activeTimer.Name = "activeTimer";
            this.activeTimer.Size = new System.Drawing.Size(49, 20);
            this.activeTimer.TabIndex = 11;
            this.activeTimer.Text = "0/500";
            // 
            // rockScore
            // 
            this.rockScore.AutoSize = true;
            this.rockScore.BackColor = System.Drawing.Color.Transparent;
            this.rockScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockScore.ForeColor = System.Drawing.Color.White;
            this.rockScore.Location = new System.Drawing.Point(97, 42);
            this.rockScore.Name = "rockScore";
            this.rockScore.Size = new System.Drawing.Size(29, 31);
            this.rockScore.TabIndex = 12;
            this.rockScore.Text = "0";
            // 
            // ironScore
            // 
            this.ironScore.AutoSize = true;
            this.ironScore.BackColor = System.Drawing.Color.Transparent;
            this.ironScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ironScore.ForeColor = System.Drawing.Color.White;
            this.ironScore.Location = new System.Drawing.Point(97, 140);
            this.ironScore.Name = "ironScore";
            this.ironScore.Size = new System.Drawing.Size(29, 31);
            this.ironScore.TabIndex = 13;
            this.ironScore.Text = "0";
            // 
            // goldScore
            // 
            this.goldScore.AutoSize = true;
            this.goldScore.BackColor = System.Drawing.Color.Transparent;
            this.goldScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldScore.ForeColor = System.Drawing.Color.White;
            this.goldScore.Location = new System.Drawing.Point(97, 227);
            this.goldScore.Name = "goldScore";
            this.goldScore.Size = new System.Drawing.Size(29, 31);
            this.goldScore.TabIndex = 14;
            this.goldScore.Text = "0";
            // 
            // mythrilScore
            // 
            this.mythrilScore.AutoSize = true;
            this.mythrilScore.BackColor = System.Drawing.Color.Transparent;
            this.mythrilScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mythrilScore.ForeColor = System.Drawing.Color.White;
            this.mythrilScore.Location = new System.Drawing.Point(97, 326);
            this.mythrilScore.Name = "mythrilScore";
            this.mythrilScore.Size = new System.Drawing.Size(29, 31);
            this.mythrilScore.TabIndex = 15;
            this.mythrilScore.Text = "0";
            // 
            // platinumScore
            // 
            this.platinumScore.AutoSize = true;
            this.platinumScore.BackColor = System.Drawing.Color.Transparent;
            this.platinumScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platinumScore.ForeColor = System.Drawing.Color.White;
            this.platinumScore.Location = new System.Drawing.Point(97, 422);
            this.platinumScore.Name = "platinumScore";
            this.platinumScore.Size = new System.Drawing.Size(29, 31);
            this.platinumScore.TabIndex = 16;
            this.platinumScore.Text = "0";
            // 
            // adamantiteScore
            // 
            this.adamantiteScore.AutoSize = true;
            this.adamantiteScore.BackColor = System.Drawing.Color.Transparent;
            this.adamantiteScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adamantiteScore.ForeColor = System.Drawing.Color.White;
            this.adamantiteScore.Location = new System.Drawing.Point(97, 518);
            this.adamantiteScore.Name = "adamantiteScore";
            this.adamantiteScore.Size = new System.Drawing.Size(29, 31);
            this.adamantiteScore.TabIndex = 17;
            this.adamantiteScore.Text = "0";
            // 
            // crystalScore
            // 
            this.crystalScore.AutoSize = true;
            this.crystalScore.BackColor = System.Drawing.Color.Transparent;
            this.crystalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalScore.ForeColor = System.Drawing.Color.White;
            this.crystalScore.Location = new System.Drawing.Point(97, 611);
            this.crystalScore.Name = "crystalScore";
            this.crystalScore.Size = new System.Drawing.Size(29, 31);
            this.crystalScore.TabIndex = 18;
            this.crystalScore.Text = "0";
            // 
            // diamondScore
            // 
            this.diamondScore.AutoSize = true;
            this.diamondScore.BackColor = System.Drawing.Color.Transparent;
            this.diamondScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diamondScore.ForeColor = System.Drawing.Color.White;
            this.diamondScore.Location = new System.Drawing.Point(97, 697);
            this.diamondScore.Name = "diamondScore";
            this.diamondScore.Size = new System.Drawing.Size(29, 31);
            this.diamondScore.TabIndex = 19;
            this.diamondScore.Text = "0";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miners_Cmd.Properties.Resources.gameBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.diamondScore);
            this.Controls.Add(this.crystalScore);
            this.Controls.Add(this.adamantiteScore);
            this.Controls.Add(this.platinumScore);
            this.Controls.Add(this.mythrilScore);
            this.Controls.Add(this.goldScore);
            this.Controls.Add(this.ironScore);
            this.Controls.Add(this.rockScore);
            this.Controls.Add(this.activeTimer);
            this.Controls.Add(this.dh5);
            this.Controls.Add(this.dh4);
            this.Controls.Add(this.dh2);
            this.Controls.Add(this.dh3);
            this.Controls.Add(this.dh1);
            this.Controls.Add(this.gameCountdown);
            this.Controls.Add(this.activeEffectBox);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.activeEffectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dh5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.PictureBox activeEffectBox;
        private System.Windows.Forms.Label gameCountdown;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.PictureBox dh1;
        private System.Windows.Forms.PictureBox dh3;
        private System.Windows.Forms.PictureBox dh2;
        private System.Windows.Forms.PictureBox dh4;
        private System.Windows.Forms.PictureBox dh5;
        private System.Windows.Forms.Timer buffTimer;
        private System.Windows.Forms.Label activeTimer;
        private System.Windows.Forms.Label ironScore;
        private System.Windows.Forms.Label goldScore;
        private System.Windows.Forms.Label mythrilScore;
        private System.Windows.Forms.Label platinumScore;
        private System.Windows.Forms.Label adamantiteScore;
        private System.Windows.Forms.Label crystalScore;
        private System.Windows.Forms.Label rockScore;
        private System.Windows.Forms.Label diamondScore;
    }
}
