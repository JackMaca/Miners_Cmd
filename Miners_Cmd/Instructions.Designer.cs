namespace Miners_Cmd
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.oreLabel = new System.Windows.Forms.Label();
            this.pauseBox = new System.Windows.Forms.PictureBox();
            this.pauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Miners_Cmd.Properties.Resources.backButton;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(3, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(249, 100);
            this.backButton.TabIndex = 0;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // oreLabel
            // 
            this.oreLabel.AutoSize = true;
            this.oreLabel.BackColor = System.Drawing.Color.Transparent;
            this.oreLabel.Font = new System.Drawing.Font("Myriad Pro Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreLabel.ForeColor = System.Drawing.Color.White;
            this.oreLabel.Location = new System.Drawing.Point(12, 389);
            this.oreLabel.Name = "oreLabel";
            this.oreLabel.Size = new System.Drawing.Size(0, 27);
            this.oreLabel.TabIndex = 17;
            // 
            // pauseBox
            // 
            this.pauseBox.BackColor = System.Drawing.Color.Transparent;
            this.pauseBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseBox.BackgroundImage")));
            this.pauseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBox.Location = new System.Drawing.Point(1133, 34);
            this.pauseBox.Name = "pauseBox";
            this.pauseBox.Size = new System.Drawing.Size(68, 57);
            this.pauseBox.TabIndex = 18;
            this.pauseBox.TabStop = false;
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.ForeColor = System.Drawing.Color.White;
            this.pauseLabel.Location = new System.Drawing.Point(1207, 42);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(114, 39);
            this.pauseLabel.TabIndex = 19;
            this.pauseLabel.Text = "Pause";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miners_Cmd.Properties.Resources.Instructions_BGL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.pauseBox);
            this.Controls.Add(this.oreLabel);
            this.Controls.Add(this.backButton);
            this.Name = "Instructions";
            this.Size = new System.Drawing.Size(1366, 768);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label oreLabel;
        private System.Windows.Forms.PictureBox pauseBox;
        private System.Windows.Forms.Label pauseLabel;
    }
}
