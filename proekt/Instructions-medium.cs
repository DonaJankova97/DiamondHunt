﻿using System;
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
        public Instructions(String s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Instructions_medium_Load(object sender, EventArgs e)
        {

        }
    }
}
