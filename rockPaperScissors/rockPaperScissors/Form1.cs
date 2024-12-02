using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            String compHand = this.getComputerHand();
            this.judgementGame("Rock", compHand);
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            String compHand = this.getComputerHand();
            this.judgementGame("Scissors", compHand);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            String compHand = this.getComputerHand();
            this.judgementGame("Paper", compHand);
        }
        private string getComputerHand()
        {
            Random rand = new Random();
            int result = rand.Next(3);
            string resultString = "";

            switch (result)
            {
                case 0:
                    label1.Text = "Computer is Rock";
                    pictureBox1.ImageLocation = "Image/gu.png";
                    resultString = "Rock";
                    break;
                case 1:
                    label1.Text = "Computer is Scissors";
                    pictureBox1.ImageLocation = "Image/choki.png";
                    resultString = "Scissors";
                    break;
                case 2:
                    label1.Text = "Computer is Paper";
                    pictureBox1.ImageLocation = "Image/pa.png";
                    resultString = "Paper";
                    break;
            }
            return resultString;
        }
        private void judgementGame(string playerHand, string computerHand)
        {
            if (playerHand == computerHand)
            {
                label1.Text = "It's a draw!";
            }
            else if (playerHand == "Rock" && computerHand == "Scissors" || playerHand == "Scissors" && computerHand == "Paper" || playerHand == "Paper" && computerHand == "Rock")
            {
                label1.Text = "You win!";
            }
            else
            {
                label1.Text = "You lose!";

            }
        }
    }
}
