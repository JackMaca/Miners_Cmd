using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace Miners_Cmd
{
    public partial class GameOver : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.click);

        public GameOver()
        {
            InitializeComponent();

            //fixes flickering
            DoubleBuffered = true;

            ////display final score
            scoreLabel.Text = "FINAL SCORE: " + GameScreen.score.ToString();

            //display ore counts
            rockCount.Text = GameScreen.IrockScore.ToString();
            ironCount.Text = GameScreen.IironScore.ToString();
            goldCount.Text = GameScreen.IgoldScore.ToString();
            mythrilCount.Text = GameScreen.ImythrilScore.ToString();
            platinumCount.Text = GameScreen.IplatinumScore.ToString();
            adamantiteCount.Text = GameScreen.IadamantiteScore.ToString();
            crystalCount.Text = GameScreen.IcrystalScore.ToString();
            diamondCount.Text = GameScreen.IdiamondScore.ToString();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //close game
            ((Form)this.TopLevelControl).Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            player.Play();
          
            //open menu
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
