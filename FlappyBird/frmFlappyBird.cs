using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird1
{
    public partial class frmFlappyBird : Form
    {
        public frmFlappyBird()
        {
            InitializeComponent();
        }

        readonly int Gravity = 5;
        int GravityNow;
        int Speed;
        int Score = 0;
        Random rn = new Random();
        List<PictureBox> PicBox;

        private void GameTimer_Tick(object sender, EventArgs e)
           {
            FlappyBird.Top += GravityNow;

            PcPipeDown.Left += Speed;
            PcPipeTop.Left += Speed;

            if (PcPipeTop.Left <= -100)
            {
                PcPipeTop.Left = 562 + rn.Next(75, 200);
                PcPipeTop.Height += rn.Next(0, 50);
                Score++;
                lblScore.Text = "Score:" + Score.ToString();
                Speed += -(Score / 10);
            }
            if (PcPipeDown.Left <= -100)
            {
                PcPipeDown.Left = 562 + rn.Next(75, 100);
                PcPipeDown.Height += rn.Next(0, 50);
                Score++;
                lblScore.Text = "Score:" + Score.ToString();
                Speed += -(Score / 10);
            }

            if (FlappyBird.Bounds.IntersectsWith(PcPipeDown.Bounds)
           || FlappyBird.Bounds.IntersectsWith(PcPipeTop.Bounds)
           || FlappyBird.Top < -34  
           || FlappyBird.Bounds.IntersectsWith(PcGround.Bounds))
            {
                EndGame();
            }
        }

        void EndGame()
        {
            GameTimer.Stop();
            if (MessageBox.Show($"Your score is :{Score}", "You Lose", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GravityNow = -Gravity;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GravityNow = Gravity;
            }
        }

        private void btnstart(object sender, EventArgs e)
        {
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
            GameTimer.Enabled = true;
            lblScore.Cursor = Cursors.Arrow;
            lblScore.Text = "Score: " + Score.ToString();
            GravityNow = Gravity;
            Speed = -8;
        }
    }
}
