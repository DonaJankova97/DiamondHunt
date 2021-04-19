using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proekt
{
    public partial class ViewPlayers : Form
    {
        public ViewPlayers()
        {
            InitializeComponent();
            StreamReader file = new StreamReader(@"players.txt", true);
            String s;
            while ((s=file.ReadLine())!=null)
            {
                //String s = file.ReadLine();
                listBox1.Items.Add(s);
            }
            file.Close();
        }
    }
}
