using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miners_Cmd
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();

            //fixes flickering
            DoubleBuffered = true;
            GameScreen gs = new GameScreen();

            ////display final score
            scoreLabel.Text = "FINAL SCORE:" + gs.score.ToString();

            //display ore counts
            rockCount.Text = gs.IrockScore.ToString();
            ironCount.Text = gs.IironScore.ToString();
            goldCount.Text = gs.IgoldScore.ToString();
            mythrilCount.Text = gs.ImythrilScore.ToString();
            platinumCount.Text = gs.IplatinumScore.ToString();
            adamantiteCount.Text = gs.IadamantiteScore.ToString();
            crystalCount.Text = gs.IcrystalScore.ToString();
            diamondCount.Text = gs.IdiamondScore.ToString();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //close game
            ((Form)this.TopLevelControl).Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //open menu
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
