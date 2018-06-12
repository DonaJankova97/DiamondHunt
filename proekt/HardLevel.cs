using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class HardLevel : Form
    {
        bool jumping = false;
        int speed = 5;
        int gravity = 5;
        int score = 0;
     
        public HardLevel()
        {
            InitializeComponent();

            endtext1.Visible = false;
            endtext2.Visible = false;
            score1.Visible = true;
            Diamond.Visible = false;

        }
        private void HardLevel_Load(object sender, EventArgs e)
        {

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bottomwall.Left -= speed;
            topwall.Left -= speed;
            middlewall.Left -= speed;
            pinkpanther.Top += gravity;
            score1.Text = "" + score;
            diamond1.Left -= speed;
            diamond2.Left -= speed;
            diamond3.Left -= speed;
            spike1.Left -= speed;
            spike2.Left -= speed;


            if (diamond1.Visible && pinkpanther.Bounds.IntersectsWith(diamond1.Bounds))
            {

                diamond1.Visible = false;
                score++;

            }
            else if (diamond2.Visible && pinkpanther.Bounds.IntersectsWith(diamond2.Bounds))
            {
                score++;
                diamond2.Visible = false;

            }
            else if (diamond3.Visible && pinkpanther.Bounds.IntersectsWith(diamond3.Bounds))
            {
                score++;
                diamond3.Visible = false;

            }

            if (pinkpanther.Bounds.IntersectsWith(bottomwall.Bounds))
                end_game();
            else if (pinkpanther.Bounds.IntersectsWith(topwall.Bounds))
                end_game();
            else if (pinkpanther.Bounds.IntersectsWith(middlewall.Bounds))
                end_game();
            else if (pinkpanther.Bounds.IntersectsWith(floor.Bounds))
                end_game();
            else if (pinkpanther.Bounds.IntersectsWith(spike1.Bounds))
                end_game();
            else if (pinkpanther.Bounds.IntersectsWith(spike2.Bounds))
                end_game();

            if (bottomwall.Left < -40)
            {
                bottomwall.Left = 500;


            }
            else if (topwall.Left < -45)
            {
                topwall.Left = 600;


            }
            else if (middlewall.Left < -65)
            {
                middlewall.Left = 800;


            }

            if (diamond1.Left < -40)
            {
                diamond1.Visible = true;
                diamond1.Left = 600;

            }
            else if (diamond2.Left < -55)
            {
                diamond2.Visible = true;
                diamond2.Left = 700;


            }
            else if (diamond3.Left < -65)
            {
                diamond3.Visible = true;
                diamond3.Left = 900;
            }
            else if (spike1.Left < -75)
            {

                spike1.Left = 1000;
            }
            else if (spike2.Left < -95)
            {
                spike2.Left = 900;
            }

            if (score == 10)
            {
                Diamond.Visible = true;
                bottomwall.Visible = false;
                topwall.Visible = false;
                middlewall.Visible = false;
                diamond1.Visible = false;
                diamond2.Visible = false;
                spike1.Visible = false;
                spike2.Visible = false;
                Diamond.Left -= speed;
                if (pinkpanther.Bounds.IntersectsWith(Diamond.Bounds))
                {
                    end_game();
                   

                }
            }
        }


        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            jumping = false;
            gravity = 5;

        }
        private void end_game()
        {

            gameTimer.Stop();
            if (score == 10)
            {
                this.Close();
                WinGame w = new WinGame();
                w.Show();
            }
            else
            {
                endtext1.Text = "Game Over!";
                endtext2.Text = "Your score is:" + score;
                endtext1.Visible = true;
                endtext2.Visible = true;

            }
        }

        private void HardLevel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
