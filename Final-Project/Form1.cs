using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jigsaw_Puzzle f = new Jigsaw_Puzzle();
            this.Hide();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sliding_Puzzle f = new Sliding_Puzzle();
            this.Hide();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
        }
    }
}
