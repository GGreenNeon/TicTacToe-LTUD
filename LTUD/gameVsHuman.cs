using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LTUD.gameVsBot;

namespace LTUD
{
    public partial class gameVsHuman : Form
    {
        string player, X, O;
        List<Button> buttons;
        bool gameCheck = false;
        int usedButtonCount = 0;
        int Player1win = 0;
        int Player2win = 0;

        public gameVsHuman()
        {
            InitializeComponent();
            reset();
        }

        private void checkRound()
        {
            if (gameCheck == true)
            {
                X = "Player 1";
                O = "Player 2";
            }
            else
            {
                X = "Player 2";
                O = "Player 1";
            }
        }

        private void checkTurn()
        {
            if (usedButtonCount % 2 == 0)
            {
                player = "X";
            }
            else
            {
                player = "O";
            }
        }

        private void boardLoad()
        {
            gameCheck = !gameCheck;
            checkRound();
            usedButtonCount = 0;
            Announcement.Text = X + "'s Move!";
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void checkWin()
        {
            bool playerWon = false;

            if (button1.Text == player && button2.Text == player && button3.Text == player
                || button4.Text == player && button5.Text == player && button6.Text == player
                || button7.Text == player && button9.Text == player && button8.Text == player
                || button1.Text == player && button4.Text == player && button7.Text == player
                || button2.Text == player && button5.Text == player && button8.Text == player
                || button3.Text == player && button6.Text == player && button9.Text == player
                || button1.Text == player && button5.Text == player && button9.Text == player
                || button3.Text == player && button5.Text == player && button7.Text == player)
            {
                playerWon = true;
            }

            if (playerWon)
            {
                if (player == "X")
                {
                    Announcement.Text = X + " Wins!";
                    if (X == "Player 1")
                    {
                        Player1win++;
                        P1Score.Text = "Player 1's Score - " + Player1win;

                    }
                    else
                    {
                        Player2win++;
                        P2Score.Text = "Player 2's Score - " + Player2win;
                    }
                }
                else
                {
                    Announcement.Text = O + " Wins!";
                    if (O == "Player 1")
                    {
                        Player1win++;
                        P1Score.Text = "Player 1's Score - " + Player1win;

                    }
                    else
                    {
                        Player2win++;
                        P2Score.Text = "Player 2's Score - " + Player2win;
                    }
                }

                foreach (Button button in buttons)
                {
                    if (button.Tag == "play")
                    {
                        button.Enabled = false;
                    }
                }
            }
            else if (usedButtonCount == 9)
            {
                Announcement.Text = "It's A Draw!";
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            reset();
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void reset()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "?";
                    ((Button)X).BackColor = Color.LightGray;
                }
            }
            boardLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkTurn();
            button1.Text = player;
            if (player == "X")
            {
                button1.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button1.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            
            usedButtonCount++;
            button1.Enabled = false;
            checkWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkTurn();
            button2.Text = player;
            if (player == "X")
            {
                button2.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button2.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button2.Enabled = false;
            checkWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkTurn();
            button3.Text = player;
            if (player == "X")
            {
                button3.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button3.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button3.Enabled = false;
            checkWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkTurn();
            button4.Text = player;
            if (player == "X")
            {
                button4.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button4.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button4.Enabled = false;
            checkWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkTurn();
            button5.Text = player;
            if (player == "X")
            {
                button5.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button5.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button5.Enabled = false;
            checkWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkTurn();
            button6.Text = player;
            if (player == "X")
            {
                button6.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button6.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button6.Enabled = false;
            checkWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkTurn();
            button7.Text = player;
            if (player == "X")
            {
                button7.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button7.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button7.Enabled = false;
            checkWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkTurn();
            button8.Text = player;
            if (player == "X")
            {
                button8.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button8.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button8.Enabled = false;
            checkWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkTurn();
            button9.Text = player;
            if (player == "X")
            {
                button9.BackColor = Color.Red;
                Announcement.Text = O + "'s Move!";
            }
            else
            {
                button9.BackColor = Color.Cyan;
                Announcement.Text = X + "'s Move!";
            }
            usedButtonCount++;
            button9.Enabled = false;
            checkWin();
        }
    }
}
