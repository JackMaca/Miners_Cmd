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
    public partial class MenuScreen : UserControl
    {      
        public MenuScreen()
        {
            InitializeComponent();                         
            this.DoubleBuffered = true;
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            //click sound for buttons
            WindowsMediaPlayer click = new WindowsMediaPlayer();
            click.URL = "click.wav";
            click.controls.play();

            ((Form)this.TopLevelControl).Close();
        }

        private void instructButton_Click(object sender, EventArgs e)
        {
            //click sound for buttons
            WindowsMediaPlayer click = new WindowsMediaPlayer();
            click.URL = "click.wav";
            click.controls.play();

            Form f = this.FindForm();
            Instructions ins = new Instructions();
            f.Controls.Add(ins);
            f.Controls.Remove(this);
            ins.Location = new Point((this.Width - ins.Width) / 2, (this.Height - ins.Height) / 2);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //click sound for buttons
            WindowsMediaPlayer click = new WindowsMediaPlayer();
            click.URL = "click.wav";
            click.controls.play();

            Form f = this.FindForm();
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            f.Controls.Remove(this);
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
        }
    }
}
