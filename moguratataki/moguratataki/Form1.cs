using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moguratataki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            int i = a.Next(1, 7);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;

            if (i == 1) {pictureBox1.Visible = true;pictureBox13.Visible = true;}
            if (i == 2) {pictureBox2.Visible = true;pictureBox14.Visible = true;}
            if (i == 3) {pictureBox3.Visible = true;pictureBox15.Visible = true;}
            if (i == 4) {pictureBox4.Visible = true;pictureBox16.Visible = true;}
            if (i == 5) {pictureBox5.Visible = true;pictureBox17.Visible = true;}
            if (i == 6) { pictureBox6.Visible = true; pictureBox18.Visible = true; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
            ((PictureBox)sender).Visible = false;

        }
    }
}
