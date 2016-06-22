/// Miner's Command
/// Jack MacAlpine
/// ICS4U
/// Mr. T
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.Media;

namespace Miners_Cmd
{
    public partial class Form1 : Form
    {
        //new thread for background music
        Thread backMusicThread;
        WindowsMediaPlayer mp3Player;
        public Form1()
        {
            InitializeComponent();

            backMusicThread = new Thread(BackgroundMusic);
            backMusicThread.Start();
            KeyPreview = true;
        }

        public void BackgroundMusic()
        {
            int randType;
            Random randNum = new Random();
            randType = randNum.Next(1, 101);

            //10% chance to play different song
            if (randType <= 10)
            {
                mp3Player = new WindowsMediaPlayer();
                mp3Player.URL = "allstar.mp3";
            }
            else
            {
                mp3Player = new WindowsMediaPlayer();
                mp3Player.URL = "menuMusic.mp3";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            //opens MenuScreen user control
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            ms.Show();

            this.DoubleBuffered = true;
        }
    }
}
