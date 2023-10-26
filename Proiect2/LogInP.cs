using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect2
{
    public partial class LoginP : Form
    {
        string connectionString = "Data Source=DESKTOP-ULPQA36\\SQLEXPRESS;Initial Catalog=Proiect2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public LoginP()
        {
            InitializeComponent();
            User.TextChanged += User_TextChanged;
            Parola.TextChanged += Parola_TextChanged;
        }

        private void Parola_TextChanged(object? sender, EventArgs e)
        {
            Parola.UseSystemPasswordChar = true;
        }

        private void User_TextChanged(object? sender, EventArgs e)
        {
            User.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connCommand = new SqlConnection(connectionString))
            {
                connCommand.Open();
                string connect = "SELECT * FROM Conturi WHERE [User] = @param1 AND Parola = @param2";
                using (SqlCommand login = new SqlCommand(connect, connCommand))
                {
                    login.Parameters.AddWithValue("@param1", User.Text);
                    login.Parameters.AddWithValue("@param2", Parola.Text);
                    using (SqlDataReader reader = login.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Welcome form = new Welcome();
                            form.Show();
                            this.Hide();
                            form.WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            LoginFail form = new LoginFail();
                            form.Show();
                        }
                    }
                }
            }
        }

        private void LoginP_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}