using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{
    public partial class gamewindow : Form
    {
        bool turn = true;
        int counter = 0;

        public gamewindow()
        {
            InitializeComponent();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("created by Blaire McLeod", "About Noughts and Crosses");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPress(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (turn)
                butt.Text = "X";
            else
                butt.Text = "O";

            turn = !turn;
            butt.Enabled = false;
            counter++;

            winner();
        }

        private void winner()
        {
            bool winner = false; //check winner

            if ((x1.Text == x2.Text) && (x2.Text == x3.Text) && (!x1.Enabled)) //line winners
                winner = true;
            if ((y1.Text == y2.Text) && (y2.Text == y3.Text) && (!y1.Enabled))
                winner = true;
            if ((z1.Text == z2.Text) && (z2.Text == z3.Text) && (!z1.Enabled))
                winner = true;

            if ((x1.Text == y1.Text) && (y1.Text == z1.Text) && (!x1.Enabled)) //line winners
                winner = true;
            if ((x2.Text == y2.Text) && (y2.Text == z2.Text) && (!x2.Enabled))
                winner = true;
            if ((x3.Text == y3.Text) && (y3.Text == z3.Text) && (!x3.Enabled))
                winner = true;

            if ((x3.Text == y2.Text) && (y2.Text == z1.Text) && (!x3.Enabled))// cross winner
                winner = true;
            if ((z3.Text == y2.Text) && (y2.Text == x1.Text) && (!z3.Enabled))
                winner = true;

            if (winner)
            {
                endGame();
                string win = "";
                if (turn)
                    win = "0";
                else
                    win = "X";

                MessageBox.Show(win + " has won", "end of game");
            }
            else 
            {
                if(counter == 9)
                    MessageBox.Show(" Draw ", "end of game");
            }
        }

        private void endGame()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button butt = (Button)c;
                    butt.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            counter = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button butt = (Button)c;
                    butt.Enabled = true;
                    butt.Text = "";
                }
            }
            catch { }
        }
    }
}
