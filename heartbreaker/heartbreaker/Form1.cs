using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heartbreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Left = -pictureBox2.Width;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pictureBox1.Left = pictureBox1.Left - 5;
            if (e.KeyCode == Keys.Right) pictureBox1.Left = pictureBox1.Left + 5;
            if (e.KeyCode == Keys.Up) pictureBox1.Top = pictureBox1.Top - 5;
            if (e.KeyCode == Keys.Down) pictureBox1.Top = pictureBox1.Top + 5;
            if (e.KeyCode == Keys.Space)
            {
                pictureBox2.Left = pictureBox1.Left;
                pictureBox2.Top = pictureBox1.Top + pictureBox1.Height / 2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 20;
        }
        Random r = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top < this.Height)
            {
                pictureBox3.Top = pictureBox3.Top + 10;
                pictureBox3.Left = pictureBox3.Left + r.Next(-10, 10);
            }
            else
            {
                pictureBox3.Top = -pictureBox3.Height;
                pictureBox3.Left = r.Next(0, this.Width - pictureBox1.Width);
            }
            if(pictureBox2.Left>pictureBox3.Left
                &&pictureBox2.Left<pictureBox3.Left+pictureBox3.Width
                &&pictureBox2.Top>pictureBox3.Top
                &&pictureBox2.Top<pictureBox3.Top+pictureBox3.Height-pictureBox2.Height)
            {
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
                pictureBox3.Top = -pictureBox3.Height;
                pictureBox3.Left = r.Next(0, this.Width - pictureBox1.Width);
            }
        }

    }
}
