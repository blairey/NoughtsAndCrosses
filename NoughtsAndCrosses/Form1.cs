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
    /// <summary>
    /// this class contains logic to play a game of noughts and crosses
    /// </summary>
    public partial class gamewindow : Form
    {
        bool turn = true;
        bool twoPlayer = false;
        int counter = 0;

        public gamewindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// shows a message with the developer's name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("created by Blaire McLeod", "About Noughts and Crosses");
        }

        /// <summary>
        /// exits on button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// handles button press assigns button x or o based on current player
        /// disables buttons after they are assigned a value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPress(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (turn)
            {
                butt.Text = "X";
                butt.Enabled = false;
                if (!twoPlayer && !isWinner())
                {
                    Button button = findFree();
                    if (button != null)
                    {
                        button.Text = "O";
                        button.Enabled = false;
                        turn = !turn;
                    }
                }
            }
            else
                butt.Text = "O";

            turn = !turn;
            butt.Enabled = false;
            counter++;

            winner();
        }

        protected Button findFree()
        {
            List<Button> buttons = new List<Button>();
            //todo
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        Button butt = (Button)c;
                        if (butt.Enabled)
                            buttons.Add(butt);
                    }
                }
                Random rnd = new Random();
                int selection = rnd.Next(0, buttons.Count);
                return buttons[selection];
            }
            catch 
            {
                return null;
            }
           
        }

        /// <summary>
        /// checks for win condition then displays the result of the game.
        /// </summary>
        private bool winner()
        {
            bool winner = false; //check winner

            winner = checkHorizontalWinner(winner);

            winner = checkVerticalWinner(winner);

            winner = checkDiagonalWinner(winner);

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
            return winner;
        }

        protected bool isWinner()
        {
            bool winner = false;
            winner |= checkDiagonalWinner(winner);
            winner |= checkVerticalWinner(winner);
            winner |= checkHorizontalWinner(winner);
            return winner;
        }

        /// <summary>
        /// checks for win condition diagonally.
        /// </summary>
        /// <param name="winner"></param>
        /// <returns></returns>
        protected virtual bool checkDiagonalWinner(bool winner)
        {
            if ((x3.Text == y2.Text) && (y2.Text == z1.Text) && (!x3.Enabled))// cross winner
                winner = true;
            if ((z3.Text == y2.Text) && (y2.Text == x1.Text) && (!z3.Enabled))
                winner = true;
            return winner;
        }

        /// <summary>
        /// checks for win condition vertically.
        /// </summary>
        /// <param name="winner"></param>
        /// <returns></returns>
        protected virtual bool checkVerticalWinner(bool winner)
        {
            if ((x1.Text == y1.Text) && (y1.Text == z1.Text) && (!x1.Enabled)) //line winners
                winner = true;
            if ((x2.Text == y2.Text) && (y2.Text == z2.Text) && (!x2.Enabled))
                winner = true;
            if ((x3.Text == y3.Text) && (y3.Text == z3.Text) && (!x3.Enabled))
                winner = true;
            return winner;
        }


        /// <summary>
        /// checks for win condition horizontally.
        /// </summary>
        /// <param name="winner"></param>
        /// <returns></returns>
        protected virtual bool checkHorizontalWinner(bool winner)
        {
            if ((x1.Text == x2.Text) && (x2.Text == x3.Text) && (!x1.Enabled)) //line winners across
                winner = true;
            if ((y1.Text == y2.Text) && (y2.Text == y3.Text) && (!y1.Enabled))
                winner = true;
            if ((z1.Text == z2.Text) && (z2.Text == z3.Text) && (!z1.Enabled))
                winner = true;
            return winner;
        }

        /// <summary>
        /// ends the game. sets all of the buttons to disabled.
        /// </summary>
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

        /// <summary>
        /// launches new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// toggles whether you are playing the computer or another player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            twoPlayer = !twoPlayer;
        }
    }
}
