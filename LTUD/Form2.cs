using System.Data.SQLite;

namespace LTUD
{
    public partial class Login : Form
    {
        public static string user;
        public Login()
        {
            InitializeComponent();
        }
        SQLiteCommand cmd;
        SQLiteDataReader DatRedr;

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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection cn = getConnection())
            {
                if (PasswordTxt.Text != string.Empty || usernameTxt.Text != string.Empty)
                {

                    cmd = new SQLiteCommand("select * from Users where Username='" + usernameTxt.Text + "'", cn);
                    DatRedr = cmd.ExecuteReader();
                    if (DatRedr.Read())
                    {
                        DatRedr.Close();
                        user = usernameTxt.Text;
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        DatRedr.Close();
                        MessageBox.Show("Wrong username or password. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please fill out all boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister registration = new FormRegister();
            registration.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTxt.PasswordChar = '\0';
            }
            else
            {
                PasswordTxt.PasswordChar = '•';
            }
        }
    }
}
