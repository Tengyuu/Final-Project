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
    public partial class Sliding_Puzzle: Form
    {
        public Sliding_Puzzle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "選擇圖片";
            openFileDialog1.Filter = "圖片檔 (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Sliding_Puzzle_Load(object sender, EventArgs e)
        {
            PictureBox[] pbs = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            foreach(PictureBox pb in pbs)
            {
                if (pb != pbs[8]) pb.BackColor = Color.White;
                //pb.Click += Puzzle_Pb_Click;
            }
            panel1.Enabled = false;
        }
    }
}
