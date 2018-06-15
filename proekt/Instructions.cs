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
    public partial class Instructions : Form
    {
        public bool buttonClicked;
        public Instructions(String s)
        {
            InitializeComponent();
            label1.Text = s;
            buttonClicked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            buttonClicked = true;
        }

       
        private void close(object sender, FormClosingEventArgs e)
        {
            
            buttonClicked = true;
        }
    }
}
