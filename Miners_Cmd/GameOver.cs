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
using System.Xml;

namespace Miners_Cmd
{
    public partial class GameOver : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.click);

        public int score1, score2, score3;
        string name1, name2, name3 = "null";

        public GameOver()
        {
            InitializeComponent();

            // Open the file to be read
            XmlDocument doc = new XmlDocument();
            doc.Load("Highscores.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "Info")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "name")
                        {
                            highScoreLabel.Text = grandChild.Value;
                        }
                    }
                }
            }

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
          
            //open menu, close gameover and gamescreen user controls
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            f.Controls.Remove(this);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

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
                                    name1 = grandChild.Value;
                                    break;
                                case 2:                                   
                                    name2 = grandChild.Value;
                                    break;
                                case 3:                                    
                                    name3 = grandChild.Value;
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
                                    score1 = Convert.ToInt16(grandChild.Value);
                                    Player++;
                                    break;
                                case 2:
                                    score2 = Convert.ToInt16(grandChild.Value);
                                    Player++;
                                    break;
                                case 3:
                                    score3 = Convert.ToInt16(grandChild.Value);
                                    Player++;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            #region XML Saving
            //if higher than 1st score, write first, then rewrite previous 1st and 2nd scores in 2nd and 3rd
            if (GameScreen.score >= Convert.ToInt16(score1))
            {
                //only save scores if they are higher than any of the top 3
                XmlTextWriter writer = new XmlTextWriter("Highscores.xml", null);

                //Write the "Player" element
                writer.WriteStartElement("Player");

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", nameBox.Text);
                writer.WriteElementString("score", GameScreen.score.ToString());

                //End "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name1.ToString());
                writer.WriteElementString("score", score1.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name2.ToString());
                writer.WriteElementString("score", score2.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                // end the "Player" element
                writer.WriteEndElement();

                //Write the XML to file and close the writer
                writer.Close();

                savedLabel.Text = "SAVED!";
            }
            else if (GameScreen.score >= Convert.ToInt16(score2) && GameScreen.score <= Convert.ToInt16(score1))
            {
                //only save scores if they are higher than any of the top 3
                XmlTextWriter writer = new XmlTextWriter("Highscores.xml", null);

                //Write the "Player" element
                writer.WriteStartElement("Player");

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name1.ToString());
                writer.WriteElementString("score", score1.ToString());

                //End "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", nameBox.Text);
                writer.WriteElementString("score", GameScreen.score.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name2.ToString());
                writer.WriteElementString("score", score2.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                // end the "Player" element
                writer.WriteEndElement();

                //Write the XML to file and close the writer
                writer.Close();

                savedLabel.Text = "SAVED!";
            }
            else if (GameScreen.score >= Convert.ToInt16(score3) && GameScreen.score <= Convert.ToInt16(score2))
            {
                //only save scores if they are higher than any of the top 3
                XmlTextWriter writer = new XmlTextWriter("Highscores.xml", null);

                //Write the "Player" element
                writer.WriteStartElement("Player");

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name1.ToString());
                writer.WriteElementString("score", score1.ToString());

                //End "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name2.ToString());
                writer.WriteElementString("score",score2.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", nameBox.Text);
                writer.WriteElementString("score", GameScreen.score.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                // end the "Player" element
                writer.WriteEndElement();

                //Write the XML to file and close the writer
                writer.Close();

                savedLabel.Text = "SAVED!";
            }
            else if (GameScreen.score < Convert.ToInt16(score3))
            {
                savedLabel.Text = "Score Too Low to Save!";
                //only save scores if they are higher than any of the top 3
                XmlTextWriter writer = new XmlTextWriter("Highscores.xml", null);

                //Write the "Player" element
                writer.WriteStartElement("Player");

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name1.ToString());
                writer.WriteElementString("score", score1.ToString());

                //End "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name2.ToString());
                writer.WriteElementString("score", score2.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                //Start "Info" element
                writer.WriteStartElement("Info");

                writer.WriteElementString("name", name3.ToString());
                writer.WriteElementString("score", score2.ToString());

                // end the "Info" element
                writer.WriteEndElement();

                // end the "Player" element
                writer.WriteEndElement();

                //Write the XML to file and close the writer
                writer.Close();
            }
            #endregion
            //confirm save button was clicked
            saveButton.Visible = false;
            savedLabel.Visible = true;
        }
    }
}
