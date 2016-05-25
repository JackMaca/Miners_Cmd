using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Miners_Cmd
{
    public partial class GameScreen : UserControl
    {
        //determines if keys are pressed
        Boolean ADown, DDown, fire;

        //create graphic objects
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        //direction variable for player
        int direction = 0;

        //ore and bullet list
        List<Ore> ores = new List<Ore>();
        List<Bullet> bullets = new List<Bullet>();

        //player image array for firing
        static Image player0 = Properties.Resources.cannon;
        static Image player1 = Properties.Resources.cannonfire;
        static Image[] player = {player0, player1};

        //changes images for firing
        int fireMode = 0;
        Player p;

        //damage variable for bullet
        int dmg = 1;

        //movement speed variable
        int plSpeed = 4;

        //timer to spawn a new ore.
        int oreTime = 0;
        
        //buff actives
        bool diamondBuff = false;
        bool speedBuff = false;
        bool dmgBuff = false;

        public GameScreen()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //set initial position
            p = new Player(638, 693, 75, plSpeed, 0, player);
            //enable countdown
            countDownTimer.Enabled = true;
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key has been pushed and set its KeyUp value to true if it has
            switch (e.KeyCode)
            {
                case Keys.A:
                    ADown = true;
                    break;
                case Keys.D:
                    DDown = true;
                    break;
                case Keys.Space:
                    fire = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.A:
                    ADown = false;
                    break;
                case Keys.D:
                    DDown = false;
                    break;
                case Keys.Space:
                    fire = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Key Booleans
            ////checks to see if any keys have been pressed and adjusts the X or Y value
            ////for the player appropriately
            if (ADown == true)
            {
                p.move(p, 0);
                direction = 0;
            }
            else if (DDown == true)
            {
                p.move(p, 2);
                direction = 2;
            }
            if (fire == true)
            {
                //max 3 bullets at once
                if (bullets.Count <= 2)
                {
                    Bullet b = new Bullet(p.x + 37, p.y + 37, 3, 20, dmg);
                    bullets.Add(b);
                }
                else
                {

                }

                fireMode = 1;
            }
            else if (fire == false)
            {
                fireMode = 0;
            }
                #endregion
                oreTime++;
            //after a time, sends out a new ore / powerup
            if (oreTime == 80)
            {
                #region random Ore
                int randType, randX, hp, oreScore;
                string newOreType;               
                // create a random number generator
                Random randNum = new Random();
                randType = randNum.Next(1, 101);
                randX = randNum.Next(206, 1089);

                //if diamond buff is false, give basic chance for ores
                if (diamondBuff == false)
                {
                    if (randType <= 25)
                    {
                        //25% chance for rock
                        newOreType = "rock";
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 26 && randType <= 50)
                    {
                        //25% chance for Iron
                        newOreType = "iron";
                        hp = 1;
                        oreScore = 3;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 51 && randType <= 65)
                    {
                        //15% chance for gold
                        newOreType = "gold";
                        hp = 1;
                        oreScore = 5;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 66 && randType <= 73)
                    {
                        //8% chance for mythril
                        newOreType = "mythril";
                        hp = 2;
                        oreScore = 8;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 74 && randType <= 80)
                    {
                        //6% chance for platinum
                        newOreType = "platinum";
                        hp = 2;
                        oreScore = 12;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 81 && randType <= 85)
                    {
                        //5% chance for adamantite
                        newOreType = "adamantite";
                        hp = 3;
                        oreScore = 15;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 86 && randType <= 95)
                    {
                        //10% chance for crystal
                        newOreType = "crystal";
                        hp = 1;
                        oreScore = 20;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 96)
                    {
                        //5% chance for diamond
                        newOreType = "diamond";
                        hp = 2;
                        oreScore = 35;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                }
                //if diamond buff is active, increase spawn rate for diamonds, decrease others.
                else if (diamondBuff == true)
                {
                    if (randType <= 5)
                    {
                        //5% chance for rock
                        newOreType = "rock";
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 6 && randType <= 10)
                    {
                        //5% chance for Iron
                        newOreType = "iron";
                        hp = 1;
                        oreScore = 3;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 11 && randType <= 14)
                    {
                        //4% chance for gold
                        newOreType = "gold";
                        hp = 1;
                        oreScore = 5;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 15 && randType <= 17)
                    {
                        //3% chance for mythril
                        newOreType = "mythril";
                        hp = 2;
                        oreScore = 8;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 18 && randType <= 19)
                    {
                        //2% chance for platinum
                        newOreType = "platinum";
                        hp = 2;
                        oreScore = 12;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType == 20)
                    {
                        //1% chance for adamantite
                        newOreType = "adamantite";
                        hp = 3;
                        oreScore = 15;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 21 && randType <= 24)
                    {
                        //4% chance for crystal
                        newOreType = "crystal";
                        hp = 1;
                        oreScore = 20;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                    else if (randType >= 25)
                    {
                        //75% chance for diamond
                        newOreType = "diamond";
                        hp = 2;
                        oreScore = 35;

                        Ore o = new Ore(newOreType, randX, -80, 70, 2, hp, oreScore);
                    }
                }
                #endregion               
            }
            //move bullets and ores in their directions.
            foreach (Bullet b in bullets)
            {
                b.y -= b.speed;
            }
            foreach (Ore o in ores)
            {
                o.y += o.speed;
            }


        }

        //int for countdown
        int cd = 6;
        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            //countdown until game starts    
            cd--;
            gameCountdown.Text = cd.ToString();            
            Refresh();
            if (cd == 0)
            {
                gameTimer.Enabled = true;
                gameCountdown.Visible = false;
                countDownTimer.Enabled = false;
            }
            else
            {
                gameTimer.Enabled = false;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw player
            DoubleBuffered = true;
            e.Graphics.DrawImage(player[fireMode], p.x, p.y, 64, 75);
        }
    }
}