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
            ((System.ComponentModel.ISupportInitialize)(this.activeEffectBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
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
            this.activeEffectBox.Location = new System.Drawing.Point(1212, 353);
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miners_Cmd.Properties.Resources.gameBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gameCountdown);
            this.Controls.Add(this.activeEffectBox);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.activeEffectBox)).EndInit();
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
    }
}
