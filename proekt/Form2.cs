using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace proekt
{
    public partial class Form2 : Form
    {
        Instructions easy, hard;
        EasyLevel d;
        HardLevel h;
        public Form2()
        {
            InitializeComponent();
            easy = new Instructions("");
            hard = new Instructions("");
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\Dona\proektVp\players.txt", true);
            s = String.Format("{0} - {1}", s, "Easy level");
            file.WriteLine(s);
            file.Close();
            d = new EasyLevel();
            this.Hide();
            d.Show();
            timer1.Start();
            easy = new Instructions("Collect the 3 diamonds in order to see the goal diamond.\nMove with keyboard arrows, and avoid everything else!");
            easy.Show();
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String s = textBox1.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\Dona\proektVp\players.txt", true);
            s = String.Format("{0} - {1}", s, "Medium level");
            file.WriteLine(s);
            file.Close();          
            MediumLevel m = new MediumLevel();
            this.Hide();
            m.Show();
            Instructions instructions = new Instructions("Go to the box\nthat's where you'll find further instructions.\nMove using keyboard arrows\nAnd remember, the goal is to get the diamond!");
            instructions.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            String s = textBox1.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\Dona\proektVp\players.txt", true);
            s=String.Format("{0} - {1}", s, "Hard level");
            file.WriteLine(s);
            file.Close();
            
            h = new HardLevel(textBox1.Text);
            this.Hide();
            h.Show();
            timer1.Start();
            hard = new Instructions("Collect 15 small diamonds, using the Space key and avoid the obstacles!");
            hard.Show();
        }
            
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            String s = textBox1.Text;
            if (s != "")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Invalid name");
                e.Cancel = true;
            }
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (easy.buttonClicked)
            {
                d.TimerStart();
                timer1.Stop();
            }
            else if(hard.buttonClicked)
            {
                h.timerStart();
                timer1.Stop();
            }
            
        }
    }
}
