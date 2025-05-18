using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Sliding_Puzzle: Form
    {
        //全域
        Image[] ans_imgs = new Image[9];
        Bitmap img = null;
        public Sliding_Puzzle()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "選擇圖片";
                openFileDialog1.Filter = "圖片檔 (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                Image original;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imgpath = openFileDialog1.FileName;
                    using (var fs = new FileStream(imgpath, FileMode.Open, FileAccess.Read))
                    {
                        original = Image.FromStream(fs);
                    }
                    img = new Bitmap(original, new Size(270, 270));
                    original.Dispose();//釋放圖資源
                    pictureBox10.Image = img;
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    for (int i = 0; i < 9; i++)
                    {
                        ans_imgs[i] = img.Clone(new Rectangle(i % 3 * 90, i / 3 * 90, 90, 90), img.PixelFormat);
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(img == null)
            {
                MessageBox.Show("請先選擇一張圖片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
