using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing_Game
{
    public partial class Form1 : Form
    {
        int roadSpeed = 15;
        int trafficSpeed = 15;
        int playerSpeed = 1;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();
        bool goLeft, goRight;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
            gameTimer.Stop();
            btnStart.Enabled = true;
        }
        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            pbWin.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            pbWin.Image = Properties.Resources.bronze;
            roadSpeed = 12;
            trafficSpeed = 15;
            Car1.Top = carPosition.Next(200, 500) * -1;
            Car1.Left = carPosition.Next(5, 200);
            Car2.Top = carPosition.Next(200, 500) * -1;
            Car2.Left = carPosition.Next(245, 320);
            gameTimer.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lbScore.Text = "Score : " + score;
            score++;

            if (goLeft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 310)
            {
                player.Left += playerSpeed;
            }
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }
            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            Car1.Top += trafficSpeed;
            Car2.Top += trafficSpeed;
            if (Car1.Top > 530)
            {
                ChangeACar(Car1);
            }
            if (Car2.Top > 530)
            {
                ChangeACar(Car2);
            }

            if (player.Bounds.IntersectsWith(Car1.Bounds) ||
                player.Bounds.IntersectsWith(Car2.Bounds))
            {
                GameOver();
            }
            if (score > 40 & score < 500)
            {
                pbWin.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 2000)
            {
                pbWin.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 2000)
            {
                pbWin.Image = Properties.Resources.gold;
                roadSpeed = 27;
                trafficSpeed = 25;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            pbWin.Visible = true;
            pbWin.BringToFront();
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            ResetGame();

        }

        private void ChangeACar(PictureBox tempCar)
        {
            carImage = rand.Next(1, 6);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.yellow;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.pink;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.red;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.green;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.whiteblue;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 320);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if ( dialog == DialogResult.No)
            {
                 e.Cancel = true;
            } 
        }
    }
}
