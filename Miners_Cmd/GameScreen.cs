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
using WMPLib;
using System.Media;


namespace Miners_Cmd
{
    public partial class GameScreen : UserControl
    {      
        //determines if keys are pressed
        Boolean ADown, DDown, fire, pDown;

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

        //ores image array
        static Image ore0 = Properties.Resources.rock;
        static Image ore1 = Properties.Resources.iron;
        static Image ore2 = Properties.Resources.gold;
        static Image ore3 = Properties.Resources.mythril;
        static Image ore4 = Properties.Resources.platinum;
        static Image ore5 = Properties.Resources.adamantite;
        static Image ore6 = Properties.Resources.crystal;
        static Image ore7 = Properties.Resources.diamond;
        static Image ore8 = Properties.Resources.goldheart;
        static Image ore9 = Properties.Resources.lightning;
        static Image ore10 = Properties.Resources.damage;
        static Image ore11 = Properties.Resources.diaBuff;
        static Image[] oreImg = {ore0, ore1, ore2, ore3, ore4, ore5, ore6, ore7, ore8, ore9, ore10, ore11};
        //changes images for firing
        int fireMode = 0;

        Player p;
        //damage variable for bullet
        int dmg = 1;

        //timer to spawn a new ore.
        int oreTime = 0;

        //int to determine new Ore
        int newOreType;

        //player health
        int health = 6;

        //buff active
        bool diamondBuff = false;

        //boolean for allowing bullets to be fired
        bool fireAccept = true;

        //score Variable
        public static int score = 0;

        //variable for the length that buffs last
        int buffTime = 0;

        //variable for the speed at which ores spawn. Lower value = faster.
        int gameSpeed = 40;
        int gameSpeedDrop = 0;

        //integers for displaying ore counts
        public static int IrockScore, IironScore, IgoldScore, ImythrilScore, IplatinumScore, IadamantiteScore, IcrystalScore, IdiamondScore = 0;
       
        //restriction on pause length
        int pauseLimit = 0;
        
        //mp3 Players for sounds
        WindowsMediaPlayer cannonPlayer;
        WindowsMediaPlayer dryPlayer;
        WindowsMediaPlayer hpDown;
        WindowsMediaPlayer oreBreak;

        public GameScreen()
        {
            InitializeComponent();

            //reset values
            score = 0;
            IrockScore = 0;
            IironScore = 0;
            IgoldScore = 0;
            ImythrilScore = 0;
            IplatinumScore = 0;
            IadamantiteScore = 0;
            IcrystalScore = 0;
            IdiamondScore = 0;
            buffTime = 0;
            activeEffectBox.BackgroundImage = null;
            this.DoubleBuffered = true;
        }
        
        private void GameScreen_Load(object sender, EventArgs e)
        {
            //set initial position
            p = new Player(638, 693, 75, 10, 0, player);
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
                case Keys.P:
                    pDown = true;
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
                case Keys.P:
                    pDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //display score
            scoreLabel.Text = score.ToString();

            #region Key Booleans
            //checks to see if any keys have been pressed and adjusts the X or Y value
            //for the player appropriately            

            if (ADown == true)
            {
                if (p.x > 206)
                {
                    p.move(p, 0);
                    direction = 0;
                }
                else
                {

                }
            }
            else if (DDown == true)
            {
                if (p.x < 1089)
                {
                    p.move(p, 1);
                    direction = 1;
                }
                else
                {

                }
            }
            if (fire == true)
            {
                //fireAccept stops automatic firing. Each shot needs it's own user input
                if (fireAccept == true)
                {
                    //max 3 bullets at once
                    if (bullets.Count <= 2)
                    {
                        
                        Bullet b = new Bullet(p.x + 19, p.y + 5, 25, 15);
                        bullets.Add(b);

                        //cannonfire
                        cannonPlayer = new WindowsMediaPlayer();
                        cannonPlayer.URL = "cannonSound.mp3";
                    }
                    else
                    {
                        //cannon clicks if not allowed to shoot.
                        dryPlayer = new WindowsMediaPlayer();
                        dryPlayer.URL = "dryFire.mp3";
                    }                    
                }
                else
                {

                }

                fireAccept = false;
                fireMode = 1;
            }

            //pause menu
            if (pDown == true)
            {
                pauseLabel.Visible = true;
                pauseTimer.Enabled = true;               
                gameTimer.Enabled = false;
                Thread.Sleep(250);
            }
            else if (fire == false)
            {
                fireAccept = true;
                fireMode = 0;
            }
                #endregion
                oreTime++;            
            //after a time, sends out a new ore / powerup
            if (oreTime == gameSpeed)
            {
                #region random Ore
                int randType, randX, hp, oreScore, randPowerX, randPowerType, powerChance;            
                // create a random number generator
                Random randNum = new Random();
                randType = randNum.Next(1, 101);
                randX = randNum.Next(206, 1089);

                //powerup random
                powerChance = randNum.Next(1, 101);
                randPowerX = randNum.Next(206, 1089);
                randPowerType = randNum.Next(1, 101);
                /// ORE GUIDE
                /// 0 = rock
                /// 1 = iron
                /// 2 = gold
                /// 3 = mythril
                /// 4 = platinum
                /// 5 = adamantite
                /// 6 = crystal
                /// 7 = diamond

                ///POWERUP GUIDE 
                ///8 = goldheart
                ///9 = speed
                ///10 = damage
                ///11 = diamond buff

                //5% chance for a buff every (gameSpeed) ticks, 25% chance per buff
                if (powerChance >= 95)
                {
                    if (randPowerType <= 25)
                    {                                                
                        newOreType = 8;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randPowerX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randPowerType >= 26 && randPowerType <= 50)
                    {                                                
                        newOreType = 9;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randPowerX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randPowerType >= 51 && randPowerType <= 75)
                    {                                                
                        newOreType = 10;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randPowerX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else
                    {                                              
                        newOreType = 11;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randPowerX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                }
                else
                {

                }
                //if diamond buff is false, give basic chance for ores                
                if (diamondBuff == false)
                {
                    if (randType <= 25)
                    {
                        //25% chance for rock
                        newOreType = 0;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 26 && randType <= 50)
                    {
                        //25% chance for Iron
                        newOreType = 1;
                        hp = 1;
                        oreScore = 3;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 51 && randType <= 65)
                    {
                        //15% chance for gold
                        newOreType = 2;
                        hp = 1;
                        oreScore = 5;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 66 && randType <= 73)
                    {
                        //8% chance for mythril
                        newOreType = 3;
                        hp = 2;
                        oreScore = 8;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 74 && randType <= 80)
                    {
                        //6% chance for platinum
                        newOreType = 4;
                        hp = 2;
                        oreScore = 12;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 81 && randType <= 85)
                    {
                        //5% chance for adamantite
                        newOreType = 5;
                        hp = 3;
                        oreScore = 15;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 86 && randType <= 95)
                    {
                        //10% chance for crystal
                        newOreType = 6;
                        hp = 1;
                        oreScore = 20;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 96)
                    {
                        //5% chance for diamond
                        newOreType = 7;
                        hp = 2;
                        oreScore = 35;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    oreTime = 0;
                }
                //if diamond buff is active, increase spawn rate for diamonds, decrease others.
                else if (diamondBuff == true)
                {
                    if (randType <= 5)
                    {
                        //5% chance for rock
                        newOreType = 0;
                        hp = 1;
                        oreScore = 1;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 6 && randType <= 10)
                    {
                        //5% chance for Iron
                        newOreType = 1;
                        hp = 1;
                        oreScore = 3;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 11 && randType <= 14)
                    {
                        //4% chance for gold
                        newOreType = 2;
                        hp = 1;
                        oreScore = 5;   
                                            
                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 15 && randType <= 17)
                    {
                        //3% chance for mythril
                        newOreType = 3;
                        hp = 2;
                        oreScore = 8;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 18 && randType <= 19)
                    {
                        //2% chance for platinum
                        newOreType = 4;
                        hp = 2;
                        oreScore = 12;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType == 20)
                    {
                        //1% chance for adamantite
                        newOreType = 5;
                        hp = 3;
                        oreScore = 15;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 21 && randType <= 24)
                    {
                        //4% chance for crystal
                        newOreType = 6;
                        hp = 1;
                        oreScore = 20;

                        Ore o = new Ore(newOreType, randX, -80, 70, 8, hp, oreScore);
                        ores.Add(o);
                    }
                    else if (randType >= 25)
                    {
                        //75% chance for diamond
                        newOreType = 7;
                        hp = 2;
                        oreScore = 35;

                        Ore o = new Ore(newOreType, randX, -80, 70, 3, hp, oreScore);
                        ores.Add(o);
                    }
                    oreTime = 0;
                    gameSpeedDrop++;
                }
                #endregion               
            }
            //every 10 ores spawn, increase the speed. (exponential growth)
            if (gameSpeedDrop == 10)
            {
                gameSpeed--;
                gameSpeedDrop = 0;
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
            //remove ores that fall off the screen
            foreach (Ore o in ores)
            {
                if (o.y >= 800)
                {
                    //only lose health if its an ore, not a powerup
                    if (o.oreType <= 7)
                    {
                        health--;

                        //health lost sound
                        hpDown = new WindowsMediaPlayer();
                        hpDown.URL = "hpDown.mp3";
                    }
                    else if (o.oreType >= 8)
                    {
                        //no health lost
                    }
                    ores.RemoveAt(Convert.ToInt16(ores.IndexOf(o)));
                    break;
                }
                else
                {

                }
            }

            //bufftime ends, buffs turn off
            if (buffTime == 500)
            {
                diamondBuff = false;
                dmg = 1;
                p.speed = 10;
                buffTimer.Enabled = false;
                buffTime = 0;
                activeEffectBox.Visible = false;
                activeTimer.Text = "0/500";
            }
            ///Due to odd occurrence where timer passes 500 upon receiving multiple buffs in quick
            ///succession; when the label reaches 500 / 500, it will also reset
            if (activeTimer.Text == "500/500")
            {
                diamondBuff = false;
                dmg = 1;
                p.speed = 10;
                buffTime = 0;
                activeTimer.Text = "0/500";
                buffTimer.Enabled = false;
            }
            //COLLISION between bullets and ores
            foreach (Ore o in ores)
            {
                bool oreRemove = false;
                foreach (Bullet bl in bullets)
                {
                    if (o.bulletCollision(o, bl) == true)
                    {
                        //remove bullets that collide
                        bullets.RemoveAt(Convert.ToInt16(bullets.IndexOf(bl)));
                        //if ore will die from this hit
                        if (o.health <= 1)
                        {
                            //destroyed ore sound
                            oreBreak = new WindowsMediaPlayer();
                            oreBreak.URL = "oreBreak.mp3";
                            #region oreScores
                            //different scores based on ore type
                            if (o.oreType == 0)
                            {
                                //rock +1
                                score++;
                                IrockScore++;
                            }
                            else if (o.oreType == 1)
                            {
                                //iron +3
                                score = score + 3;
                                IironScore++;
                            }
                            else if (o.oreType == 2)
                            {
                                //gold + 5
                                score = score + 5;
                                IgoldScore++;
                            }
                            else if (o.oreType == 3)
                            {
                                //mythril + 8
                                score = score + 8;
                                ImythrilScore++;
                            }
                            else if (o.oreType == 4)
                            {
                                //platinum + 12
                                score = score + 12;
                                IplatinumScore++;
                            }
                            else if (o.oreType == 5)
                            {
                                //adamantite + 15
                                score = score + 12;
                                IadamantiteScore++;
                            }
                            else if (o.oreType == 6)
                            {
                                //crystal + 20
                                score = score + 20;
                                IcrystalScore++;
                            }
                            else if (o.oreType == 7)
                            {
                                //diamond + 35
                                score = score + 35;
                                IdiamondScore++;
                            }
                            else if (o.oreType == 8)
                            {
                                //gold heart
                                health++;

                                //turn off active effects
                                dmg = 1;
                                diamondBuff = false;
                                p.speed = 10;

                                ///gold heart is not an active effect, but in instant health increase
                                ///so it does not have an image, but cancels other active effects.
                                activeEffectBox.BackgroundImage = null;
                                activeEffectBox.Visible = true;
                            }
                            else if (o.oreType == 9)
                            {

                                //speed increased
                                p.speed = 20;
                                //reset other stats
                                dmg = 1;
                                diamondBuff = false;

                                activeEffectBox.BackgroundImage = Properties.Resources.lightning;
                                activeEffectBox.Visible = true;

                                buffTimer.Enabled = true;
                                buffTime = 0;
                            }
                            else if (o.oreType == 10)
                            {                                
                                //damage increased
                                dmg = 3;

                                //reset other stats
                                p.speed = 10;
                                diamondBuff = false;

                                activeEffectBox.BackgroundImage = Properties.Resources.damage;
                                activeEffectBox.Visible = true;

                                buffTimer.Enabled = true;
                                buffTime = 0;
                            }
                            else if (o.oreType == 11)
                            {                                
                                //diamond rate increased
                                diamondBuff = true;

                                //reset other stats
                                p.speed = 10;
                                dmg = 1;
                                activeEffectBox.BackgroundImage = Properties.Resources.diaBuff;
                                activeEffectBox.Visible = true;

                                buffTimer.Enabled = true;
                                buffTime = 0;
                            }
                            #endregion                                   
                            oreRemove = true;
                            break;                            
                        }
                        //if ore has more than 1 hp left
                        else
                        {
                            //subtract damage from ore
                            o.health = o.health - dmg;
                            break;
                        }                       
                    }
                    else
                    {

                    }
                }
                if (oreRemove == true)
                {
                    ores.RemoveAt(Convert.ToInt16(ores.IndexOf(o)));
                    break;
                }
            }
            //remove bullets that shoot off the screen
            foreach (Bullet b in bullets)
            {
                if (b.y <= -30)
                {
                    //**remove 1st bullet (highest bullet should be 1st bullet)
                    bullets.RemoveAt(Convert.ToInt16(bullets.IndexOf(b)));
                    break;                    
                }
                else
                {

                }
            }
            // max health at 6, if it exceeds 6 from a powerup, will return to 6
            if (health >= 6)
            {
                health = 6;
            }
            //run GameOver if health reaches 0
            if (health == 0)
            {
                Form f = this.FindForm();
                GameOver go = new GameOver();
                f.Controls.Add(go);
                go.BringToFront();
                go.Location = new Point((this.Width - go.Width) / 2, (this.Height - go.Height) / 2);
                gameTimer.Enabled = false;
            }

            //lower pause limit to allow more pause time for more play time.
            if (pauseLimit >= 1)
            {
                pauseLimit--;
            }
            //display ore counts on the screen
            rockScore.Text = IrockScore.ToString();
            ironScore.Text = IironScore.ToString();
            goldScore.Text = IgoldScore.ToString();
            mythrilScore.Text = ImythrilScore.ToString();
            platinumScore.Text = IplatinumScore.ToString();
            adamantiteScore.Text = IadamantiteScore.ToString();
            crystalScore.Text = IcrystalScore.ToString();
            diamondScore.Text = IdiamondScore.ToString();

            //timer displays time remaining on buffs
            activeTimer.Text = buffTime.ToString() + "/500";
            //refresh runs paint method
            Refresh();
        }

        //pauseTimer set to be able to set pause restrictions if pausing is abused.
        private void pauseTimer_Tick(object sender, EventArgs e)
        {           
            if (pDown == true)
            {
                pauseLabel.Visible = false;
                gameTimer.Enabled = true;
                pauseTimer.Enabled = false;                
                Thread.Sleep(250);
            }

            //uncomment code below to set a restriction on how long you can pause

            //pauseLimit++;
            //if (pauseLimit == 60)
            //{
            //    pauseLabel.Visible = false;
            //    gameTimer.Enabled = true;
            //    pauseTimer.Enabled = false;
            //    Thread.Sleep(250);
            //}
        }

        //int for countdown
        int cd = 6;

        private void buffTimer_Tick(object sender, EventArgs e)
        {
            buffTime++;
        }

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
            if (Form1.GameScreenBreak == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
            }
            //draw player
            DoubleBuffered = true;
            e.Graphics.DrawImage(player[fireMode], p.x, p.y, 64, 75);

            //draw all bullets as cannonball
            int i = 0;
            for (i = 0; i < bullets.Count; i++)
            {
                e.Graphics.DrawImage(Properties.Resources.cannonball, bullets[i].x, bullets[i].y, 25, 25);
            }

            //draw all ores
            foreach (Ore o in ores)
            {
                e.Graphics.DrawImage(oreImg[o.oreType], o.x, o.y, 70, 70);
            }

            //display lost health
            if (health == 6)
            {
                dh1.Visible = false;
            }
            else if (health == 5)
            {
                dh1.Visible = true;
                dh2.Visible = false;
                dh3.Visible = false;
                dh4.Visible = false;
                dh5.Visible = false;
            }
            else if (health == 4)
            {
                dh1.Visible = true;
                dh2.Visible = true;
                dh3.Visible = false;
                dh4.Visible = false;
                dh5.Visible = false;
            }
            else if (health == 3)
            {
                dh1.Visible = true;
                dh2.Visible = true;
                dh3.Visible = true;
                dh4.Visible = false;
                dh5.Visible = false;
            }
            else if (health == 2)
            {
                dh1.Visible = true;
                dh2.Visible = true;
                dh3.Visible = true;
                dh4.Visible = true;
                dh5.Visible = false;
            }
            else if (health == 1)
            {
                dh1.Visible = true;
                dh2.Visible = true;
                dh3.Visible = true;
                dh4.Visible = true;
                dh5.Visible = true;
            }
        }
    }
}