namespace Miners_Cmd
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.PictureBox();
            this.instructButton = new System.Windows.Forms.PictureBox();
            this.scoreButton = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.playButton;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Location = new System.Drawing.Point(357, 327);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(245, 93);
            this.playButton.TabIndex = 1;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructButton
            // 
            this.instructButton.BackColor = System.Drawing.Color.Transparent;
            this.instructButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.instructButton;
            this.instructButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instructButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructButton.Location = new System.Drawing.Point(703, 327);
            this.instructButton.Name = "instructButton";
            this.instructButton.Size = new System.Drawing.Size(245, 93);
            this.instructButton.TabIndex = 2;
            this.instructButton.TabStop = false;
            this.instructButton.Click += new System.EventHandler(this.instructButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.Transparent;
            this.scoreButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.scoreButton;
            this.scoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.Location = new System.Drawing.Point(357, 543);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(245, 93);
            this.scoreButton.TabIndex = 3;
            this.scoreButton.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.quitButton;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.Location = new System.Drawing.Point(703, 543);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(245, 93);
            this.quitButton.TabIndex = 4;
            this.quitButton.TabStop = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miners_Cmd.Properties.Resources.loadbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.instructButton);
            this.Controls.Add(this.playButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1366, 768);
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox instructButton;
        private System.Windows.Forms.PictureBox scoreButton;
        private System.Windows.Forms.PictureBox quitButton;
    }
}
