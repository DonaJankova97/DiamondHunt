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
    public partial class LoseGame : Form
    {
       
        public LoseGame()
        {
            InitializeComponent();
            
            losetext2.Text = "Your score is:";

           
        }
        public LoseGame(int value)
        {
            InitializeComponent();
            int score = value;
            losetext2.Text = "Your score is:" + value;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void LoseGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
