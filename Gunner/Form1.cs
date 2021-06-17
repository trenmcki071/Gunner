using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Gunner
{
    public partial class gunnerForm : Form
    {
        Rectangle player1 = new Rectangle(10, 195, 40, 30);
        Rectangle player2 = new Rectangle(550, 195, 40, 30);
        Rectangle barrier = new Rectangle(295, 180, 10, 40);
        Rectangle rightSpeedBoost = new Rectangle(420, 95, 10, 10);
        Rectangle rightPelletBoost = new Rectangle(420, 295, 10, 10);
        Rectangle leftSpeedBoost = new Rectangle(170, 95, 10, 10);
        Rectangle leftPelletBoost = new Rectangle(170, 295, 10, 10);

        List<Rectangle> pellets = new List<Rectangle>();
        List<int> pelletSpeeds = new List<int>();

        Image arrowLeft = Properties.Resources.arrowLeft;
        Image arrowRight = Properties.Resources.arrowRight;

        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool rightArrowDown = false;
        bool leftArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftShootDown = false;
        bool rightShootDown = false;

        int player1Speed = 1;
        int player2Speed = 1;
        int player1PelletSpeed = 4;
        int player2PelletSpeed = -4;
        int barrierSpeed = 3;

        Pen whitePen = new Pen(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        String boost;

        Random rnd = new Random();

        int leftdelay1;
        int leftdelay2;
        int rightdelay1;
        int rightdelay2;

        int leftFireRate = 40;
        int rightFireRate = 40;

        int rightShotLag = 0;
        int leftShotLag = 0;

        int player1Score = 0;
        int player2Score = 0;
        public gunnerForm()
        {
            InitializeComponent();
        }

        private void gunnerForm_Paint(object sender, PaintEventArgs e)
        {
            //draw/fill the players, barriers, and boosts
            e.Graphics.DrawImage(arrowLeft, player1);
            e.Graphics.DrawImage(arrowRight, player2);
            e.Graphics.DrawRectangle(whitePen, barrier);
            e.Graphics.FillRectangle(yellowBrush, rightSpeedBoost);
            e.Graphics.FillRectangle(redBrush, rightPelletBoost);
            e.Graphics.FillRectangle(yellowBrush, leftSpeedBoost);
            e.Graphics.FillRectangle(redBrush, leftPelletBoost);

            //fill the pellets in the list
            for (int i = 0; i < pellets.Count(); i++) 
            {
                e.Graphics.FillRectangle(whiteBrush, pellets[i]);
            }

            e.Graphics.DrawLine(whitePen, 201, 0, 201, 400);
            e.Graphics.DrawLine(whitePen, 399, 0, 399, 400);
        }

        private void gunnerForm_KeyDown(object sender, KeyEventArgs e)
        {
            //detects the button pushes
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.D1:
                    leftShootDown = true;
                    break;
                case Keys.M:
                    rightShootDown = true;
                    break;
            }
        }

        private void gunnerForm_KeyUp(object sender, KeyEventArgs e)
        {
            //detects for the buttons not being pushed
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.M:
                    rightShootDown = false;
                    break;
                case Keys.D1:
                    leftShootDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //if a boost is activated, calls the method and lets it know which boost was activated
            if (player1.IntersectsWith(leftSpeedBoost))
            {
                boost = "leftSpeed";
                SpeedBoost();
            }

            if (player1.IntersectsWith(leftPelletBoost))
            {
                boost = "leftPellet";
                SpeedBoost();
            }

            if (player2.IntersectsWith(rightSpeedBoost))
            {
                boost = "rightSpeed";
                SpeedBoost();
            }

            if (player2.IntersectsWith(rightPelletBoost))
            {
                boost = "rightPellet";
                SpeedBoost();
            }

            //shooting pellets, the lag number increases and once it gets bigger than the fire rate, another shot can be fired
            rightShotLag++;
            if (rightShootDown == true && rightShotLag > rightFireRate)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.shot);
                player.Play();
                pellets.Add(new Rectangle(player2.X - 7, player2.Y + 14, 10, 3));
                pelletSpeeds.Add(player2PelletSpeed);
                rightShotLag = 0;
            }

            leftShotLag++;
            if (leftShootDown == true && leftShotLag > leftFireRate)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.shot);
                player.Play();
                pellets.Add(new Rectangle(player1.X + 37, player1.Y + 14, 10, 3));
                pelletSpeeds.Add(player1PelletSpeed);
                leftShotLag = 0;
            }

            //moving the pellets
            for (int i = 0; i < pellets.Count(); i++)
            {
                int x = pellets[i].X + pelletSpeeds[i];

                pellets[i] = new Rectangle(x, pellets[i].Y, 10, 3);
            }

            //check if a pellet had left the screen
            for (int i = 0; i < pellets.Count(); i++)
            {


                if (pellets[i].X > this.Width || pellets[i].X - 15 > this.Width)
                {
                    pellets.RemoveAt(i);
                    pelletSpeeds.RemoveAt(i);
                }
            }

            //if a player is hit by a pellet
            for (int i = 0; i < pellets.Count(); i++)
            {
                if (player1.IntersectsWith(pellets[i]))
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                    player.Play();
                    pellets.RemoveAt(i);
                    pelletSpeeds.RemoveAt(i);
                    player2Score++;
                    player2ScoreLabel.Text = $"{player2Score}";
                }

            }

            for (int i = 0; i < pellets.Count(); i++)
            {
                if (player2.IntersectsWith(pellets[i]))
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                    player.Play();
                    pellets.RemoveAt(i);
                    pelletSpeeds.RemoveAt(i);
                    player1Score++;
                    player1ScoreLabel.Text = $"{player1Score}";
                }

            }
            //checks for a game over
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                screen.Visible = true;
                screen.Text = "Player 1 Wins!!";
            }

            if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                screen.Visible = true;
                screen.Text = "Player 2 Wins!!";
            }

            //if a pellet hits the barrier
            for (int i = 0; i < pellets.Count(); i++)
            {
                if (barrier.IntersectsWith(pellets[i]))
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                    player.Play();
                    pellets.RemoveAt(i);
                    pelletSpeeds.RemoveAt(i);
                }

            }

            //movement
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width && player1.X < 200 - player1.Width)
            {
                player1.X += player1Speed;
            }

            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }

            if (leftArrowDown == true && player2.X > 0 && player2.X > 400)
            {
                player2.X -= player2Speed;
            }

            //if the boosts arent in their starting point, they slowly move towards it
            if (leftSpeedBoost.X > 170)
            {
                leftdelay1++;
                if (leftdelay1 > 15)
                {
                    leftSpeedBoost.X -= 1;
                    leftdelay1 = 1;
                }
            }

            if (leftPelletBoost.X > 170)
            {
                leftdelay2++;
                if (leftdelay2 > 5)
                {
                    leftPelletBoost.X -= 1;
                    leftdelay2 = 1;
                }
            }

            if (rightPelletBoost.X < 420)
            {
                rightdelay2++;
                if (rightdelay2 > 5)
                {
                    rightPelletBoost.X += 1;
                    rightdelay2 = 1;
                }
            }

            if (rightSpeedBoost.X < 420)
            {
                rightdelay1++;
                if (rightdelay1 > 15)
                {
                    rightSpeedBoost.X += 1;
                    rightdelay1 = 1;
                }
            }

            //if the barrier hits a wall it'll reverse direction
            barrier.Y += barrierSpeed;
            if (barrier.Y == 0 || barrier.Y == this.Height - barrier.Height)
            {
                barrierSpeed = -barrierSpeed;
            }

            Refresh();
        }

        //this method is called when a player gets a power-up
        public void SpeedBoost()
        {
            //a sound is played, and they are moved into the middle of the screen
            SoundPlayer player = new SoundPlayer(Properties.Resources.power_up);
            if (boost == "leftSpeed")
            {
                player.Play();
                leftSpeedBoost.X = 280;
                player1Speed++;
            }

            if (boost =="rightSpeed")
            {
                player.Play();
                rightSpeedBoost.X = 310;
                player2Speed++;
            }

            if (boost == "leftPellet")
            {
                player.Play();
                leftPelletBoost.X = 280;
                player1PelletSpeed++;
                leftFireRate = leftFireRate - 5;
            }

            if (boost == "rightPellet")
            {
                player.Play();
                rightPelletBoost.X = 310;
                player2PelletSpeed--;
                rightFireRate = rightFireRate - 5;
            }
        }

        //starts the game once the start button is pressed
        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            startButton.Enabled = false;
            screen.Visible = false;
            explinationLabel.Visible = false;
            explinationLabel1.Visible = false;
            explinationLabel2.Visible = false;
            explinationLabel3.Visible = false;
            explinationLabel4.Visible = false;
            explinationLabel5.Visible = false;
            boostLabel.Visible = false;
            boostLabel1.Visible = false;
            startButton.Visible = false;
        }
    }
}
