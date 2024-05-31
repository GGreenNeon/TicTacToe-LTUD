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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void Comp_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiffChoose pick = new DiffChoose();
            pick.ShowDialog();
        }

        private void twoPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameVsHuman play = new gameVsHuman();
            play.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login signOut = new Login();
            signOut.ShowDialog();

        }
    }
}
