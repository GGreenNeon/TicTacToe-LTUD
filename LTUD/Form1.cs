using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using System.Data.SQLite;

namespace LTUD
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public SQLiteConnection getConnection()
        {
            string connectionString = "Data Source=db.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return connection;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection cn = getConnection())
            {
                if (CfPassTxt.Text != string.Empty && PassTxt.Text != string.Empty && usernameTxt.Text != string.Empty)
                {
                    if (PassTxt.Text == CfPassTxt.Text)
                    {
                        cmd = new SQLiteCommand("select * from Users where Username='" + usernameTxt.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username already exists. Please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SQLiteCommand("insert into Users values(@Username,@Password)", cn);
                            cmd.Parameters.AddWithValue("Username", usernameTxt.Text);
                            cmd.Parameters.AddWithValue("Password", PassTxt.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password confirmation doesn't check out. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                PassTxt.PasswordChar = '\0';
                CfPassTxt.PasswordChar = '\0';
            }
            else
            {
                PassTxt.PasswordChar = '•';
                CfPassTxt.PasswordChar = '•';
            }
        }
    }
}
