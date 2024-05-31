using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD
{
    public partial class DiffChoose : Form
    {
        public static int diffChoice;

        public DiffChoose()
        {
            InitializeComponent();
        }

        private void EasyDiff_Click(object sender, EventArgs e)
        {
            diffChoice = 1;
            gameVsBot play = new gameVsBot();
            this.Hide();
            play.Show();
        }

        private void MidDiff_Click(object sender, EventArgs e)
        {
            diffChoice = 2;
            gameVsBot play = new gameVsBot();
            this.Hide();
            play.Show();
        }

        private void HardDiff_Click(object sender, EventArgs e)
        {
            diffChoice = 3;
            gameVsBot play = new gameVsBot();
            this.Hide();
            play.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login signOut = new Login();
            signOut.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
