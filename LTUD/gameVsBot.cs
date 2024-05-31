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

namespace LTUD
{
    public partial class gameVsBot : Form
    {
        string player;
        List<Button> buttons;
        bool goFirst = false;
        int usedButtonCount = 0;
        int diff = DiffChoose.diffChoice;
        int playerScore = 0;
        int botScore = 0;
        bool endgame = false;

        public gameVsBot()
        {
            InitializeComponent();
            reset();
        }

        private void Restart(object sender, EventArgs e)
        {
            reset();
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

            if (!goFirst)
            {
                player = "O";
                botMove();
            }
            else
            {
                player = "X";
            }
        }

        private void boardLoad()
        {
            goFirst = !goFirst;
            usedButtonCount = 0;
            endgame = false;
            Announcement.Text = "Good Luck!";
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();

        }

        private void checkWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            { 
                if (player == "X")
                {
                    Announcement.Text = "You Win!";
                    playerScore++;
                    PScore.Text = "Player's Score - " + playerScore;
                }
                else
                {
                    Announcement.Text = "You Lost!";
                    botScore++;
                    CScore.Text = "Computer's Score - " + botScore;
                }
                foreach (Button button in buttons)
                {
                    if (button.Tag == "play")
                    {
                        button.Enabled = false;
                    }
                }
                endgame = true;
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                if (player == "O")
                {
                    Announcement.Text = "You Win!";
                    playerScore++;
                    PScore.Text = "Player's Score - " + playerScore;
                }
                else
                {
                    Announcement.Text = "You Lost!";
                    botScore++;
                    CScore.Text = "Computer's Score - " + botScore;
                }
                foreach (Button button in buttons)
                {
                    if (button.Tag == "play")
                    {
                        button.Enabled = false;
                    }
                }
                endgame = true;
            }
            else if (usedButtonCount == 9)
            {
                Announcement.Text = "It's A Draw!";
                endgame = true;
            }
        }

        private void botMove()
        {
            if (endgame)
            {
                return;
            }
            else if (diff == 1)
            {
                easyBot();
            }
            else if (diff == 2)
            {
                mediumBot();
            }
            else if (diff == 3)
            {
                hardBot();
            }
        }

        private void easyBot()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            Random rand = new Random();
            int temp = rand.Next(9);
            while (buttons[temp].Enabled == false)
            {
                temp = rand.Next(9);
            }
            if (player == "X")
            {
                buttons[temp].Text = "O";
                buttons[temp].BackColor = Color.Cyan;
            }
            else
            {
                buttons[temp].Text = "X";
                buttons[temp].BackColor = Color.Red;
            }
            usedButtonCount++;
            buttons[temp].Enabled = false;
            checkWin();
        }

        private void mediumBot()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            int move = avoidLoss();
            if (move != -1)
            {
                if (player == "X")
                {
                    buttons[move].Text = "O";
                    buttons[move].BackColor = Color.Cyan;
                }
                else
                {
                    buttons[move].Text = "X";
                    buttons[move].BackColor = Color.Red;
                }
                usedButtonCount++;
                buttons[move].Enabled = false;
                checkWin();
            }
            else
            {
                easyBot();
            }
        }

        private int avoidLoss()
        {
            if (button1.Enabled == true && ((button2.Text == player && button3.Text == player) || (button4.Text == player && button7.Text == player) || (button5.Text == player && button9.Text == player)))
                return 0;
            else if (button2.Enabled == true && ((button1.Text == player && button3.Text == player) || (button5.Text == player && button8.Text == player)))
                return 1;
            else if (button3.Enabled == true && ((button1.Text == player && button2.Text == player) || (button6.Text == player && button9.Text == player) || (button5.Text == player && button7.Text == player)))
                return 2;
            else if (button4.Enabled == true && ((button1.Text == player && button7.Text == player) || (button5.Text == player && button6.Text == player)))
                return 3;
            else if (button5.Enabled == true && ((button1.Text == player && button9.Text == player) || (button3.Text == player && button7.Text == player) || (button2.Text == player && button8.Text == player) || (button4.Text == player && button6.Text == player)))
                return 4;
            else if (button6.Enabled == true && ((button3.Text == player && button9.Text == player) || (button4.Text == player && button5.Text == player)))
                return 5;
            else if (button7.Enabled == true && ((button1.Text == player && button4.Text == player) || (button8.Text == player && button9.Text == player) || (button3.Text == player && button5.Text == player)))
                return 6;
            else if (button8.Enabled == true && ((button2.Text == player && button5.Text == player) || (button7.Text == player && button9.Text == player)))
                return 7;
            else if (button9.Enabled == true && ((button3.Text == player && button6.Text == player) || (button7.Text == player && button8.Text == player) || (button1.Text == player && button5.Text == player)))
                return 8;
            else
                return -1;
        }

        private void hardBot()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            int move;
            if (player == "X")
            {
                player = "O";
                move = avoidLoss();
                player = "X";
            }
            else
            {
                player = "X";
                move = avoidLoss();
                player = "O";
            }
            if (move != -1)
            {
                if (player == "X")
                {
                    buttons[move].Text = "O";
                    buttons[move].BackColor = Color.Cyan;
                }
                else
                {
                    buttons[move].Text = "X";
                    buttons[move].BackColor = Color.Red;
                }
                usedButtonCount++;
                buttons[move].Enabled = false;
                checkWin();
            }
            else
            {
                mediumBot();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = player;
            if (player == "X")
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Cyan;
            }

            usedButtonCount++;
            button1.Enabled = false;
            checkWin();
            botMove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = player;
            if (player == "X")
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button2.Enabled = false;
            checkWin();
            botMove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = player;
            if (player == "X")
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button3.Enabled = false;
            checkWin();
            botMove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = player;
            if (player == "X")
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button4.Enabled = false;
            checkWin();
            botMove();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = player;
            if (player == "X")
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button5.Enabled = false;
            checkWin();
            botMove();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = player;
            if (player == "X")
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button6.Enabled = false;
            checkWin();
            botMove();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = player;
            if (player == "X")
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button7.Enabled = false;
            checkWin();
            botMove();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = player;
            if (player == "X")
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button8.Enabled = false;
            checkWin();
            botMove();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = player;
            if (player == "X")
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.Cyan;
            }
            usedButtonCount++;
            button9.Enabled = false;
            checkWin();
            botMove();
        }
    }
}
