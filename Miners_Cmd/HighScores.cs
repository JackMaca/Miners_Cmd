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
using System.Xml;

namespace Miners_Cmd
{
    public partial class HighScores : UserControl
    {
        public HighScores()
        {
            InitializeComponent();

            // Open the file to be read
            XmlDocument doc = new XmlDocument();
            doc.Load("Highscores.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            int Player = 1;
            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "Info")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "name")
                        {
                            switch (Player)
                            {
                                case 1:
                                    name1.Text = grandChild.Value;
                                    break;
                                case 2:
                                    name2.Text = grandChild.Value;
                                    break;
                                case 3:
                                    name3.Text = grandChild.Value;
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (grandChild.Name == "score")
                        {
                            switch (Player)
                            {
                                case 1:
                                    score1.Text = grandChild.Value;
                                    Player++;
                                    break;
                                case 2:
                                    score2.Text = grandChild.Value;
                                    Player++;
                                    break;
                                case 3:
                                    score3.Text = grandChild.Value;
                                    Player++;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            //click sound for buttons
            WindowsMediaPlayer click = new WindowsMediaPlayer();
            click.URL = "click.wav";
            click.controls.play();

            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
