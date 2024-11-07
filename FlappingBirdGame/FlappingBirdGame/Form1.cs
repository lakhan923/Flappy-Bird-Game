using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FlappingBirdGame
{
    public partial class Form1 : Form
    {
        //variables start here
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        bool gameOver = false;
        Random rnd = new Random();
        SoundPlayer player = new SoundPlayer();

        //variables ends here

        public Form1()
        {
            InitializeComponent();
            // set the parent color of scoreText label
            ground.Controls.Add(scoreText);
            scoreText.Left = 20;
            scoreText.Top = 25;

            player.SoundLocation = "laserSound.wav";
            RestartGame();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + " " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = rnd.Next(750, 1300);
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = rnd.Next(850, 1500);
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            // this event is linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                //if space key is pressed then the gravity will be set to -15
                gravity = -15;
                player.Play();
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            // this event is linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                //if space key is released then the gravity is set back to 15
                gravity = 15;
                player.Play();
            }
            if (e.KeyCode == Keys.Enter && gameOver)
            {
                // rub the restart function
                RestartGame();
            }
        }

        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(130, 182);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score: 0 ";
            gameTimer.Start();
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!! Press Enter to restart.";
           // += is used to add the new string of text next to the score instaed of
           // overriding it.
            gameOver = true;
        }

    }
}
