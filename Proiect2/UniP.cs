using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proiect2
{
    public partial class UniP : Form
    {
        string connectionString = "Data Source=DESKTOP-ULPQA36\\SQLEXPRESS;Initial Catalog=Proiect2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public UniP()
        {
            InitializeComponent();
            Oras.TextChanged += Oras_TextChanged;
            Director.TextChanged += Director_TextChanged;
        }
        private void Oras_TextChanged(object? sender, EventArgs e)
        {
            string input = Oras.Text;
            bool DoarCifre = Litere(input);
            if (DoarCifre)
            {
                Oras.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                Oras.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void Director_TextChanged(object? sender, EventArgs e)
        {
            string input = Director.Text;
            bool DoarCifre = Litere(input);
            if (DoarCifre)
            {
                Director.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                Director.ForeColor = System.Drawing.Color.Red;
            }
        }
        public static bool Litere(string input)
        {
            string pattern = @"^[A-Za-z --]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FilterB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connCommand = new SqlConnection(connectionString))
            {
                connCommand.Open();
                string filterquery = $"SELECT * FROM Universitati WHERE ((NumeUni LIKE '{Uni.Text}%') AND (Oras LIKE '{Oras.Text}%') AND (Adresa LIKE '{Adresa.Text}%') AND (Director LIKE'{Director.Text}%'))";
                SqlDataAdapter adapter = new SqlDataAdapter(filterquery, connCommand);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                UniTable.DataSource = dataTable;

                if ((Uni.Text == "") & (Oras.Text == "") & (Adresa.Text == "") & (Director.Text == ""))
                {
                    Uni.Text = UniTable.Rows[0].Cells[1].Value.ToString();
                    Oras.Text = UniTable.Rows[0].Cells[2].Value.ToString();
                    Adresa.Text = UniTable.Rows[0].Cells[3].Value.ToString();
                    Director.Text = UniTable.Rows[0].Cells[4].Value.ToString();
                }
            }
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            if ((Uni.Text != "") & (Oras.Text != "") & (Adresa.Text != "") & (Director.Text != ""))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertquery = "INSERT INTO Universitati (NumeUni, Oras, Adresa, Director) VALUES (@param1, @param2, @param3, @param4)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@param1", Uni.Text);
                        cmd.Parameters.AddWithValue("@param2", Oras.Text);
                        cmd.Parameters.AddWithValue("@param3", Adresa.Text);
                        cmd.Parameters.AddWithValue("@param4", Director.Text);

                        bool err = false;
                        if (Oras.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (Director.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (err == false)
                        {
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                SuccesMSGBOX form = new SuccesMSGBOX();
                                form.Show();
                            }
                            else
                            {
                                Error form = new Error();
                                form.Show();
                            }
                        }
                        else
                        {
                            RED form = new RED();
                            form.Show();
                        }
                    }

                }
            }
            else
            {
                Incomplete form = new Incomplete();
                form.Show();
            }
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string @param1 = Uni.Text;
                string @param2 = Oras.Text;
                string @param3 = Adresa.Text;
                string @param4 = Director.Text;
                string countquery = "SELECT COUNT(NumeUni) FROM Universitati WHERE (NumeUni = '" + @param1 + "')";
                using SqlCommand countCommand = new SqlCommand(countquery, conn);
                int x = Convert.ToInt32(countCommand.ExecuteScalar());
                if (x != 0)
                {
                    string queryupdate = "UPDATE Universitati SET Oras = '" + param2 + "' WHERE (NumeUni = '" + @param1 + "'); " +
                                         "UPDATE Universitati SET Adresa = '" + param3 + "' WHERE (NumeUni = '" + @param1 + "'); " +
                                         "UPDATE Universitati SET Director = '" + param4 + "' WHERE (NumeUni = '" + @param1 + "') ";
                    using SqlCommand updateCommand = new SqlCommand(queryupdate, conn);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        UPDATE form = new UPDATE();
                        form.Show();
                    }
                    else
                    {
                        Error form = new Error();
                        form.Show();
                    }
                }
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string @param1 = Uni.Text;
                string deletequery = "DELETE FROM Universitati WHERE (NumeUni = '" + param1 + "')";
                DialogResult rezultat = MessageBox.Show("Sunteti sigur(a) ca vreti sa stergeti aceasta universitate? Toate datele legate de aceasta vor fi sterse!!!", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    using (SqlCommand deleteCommand = new SqlCommand(deletequery, conn))
                        deleteCommand.ExecuteNonQuery();
                }
                else { }

            }
        }
        private void UniTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = UniTable.Rows[e.RowIndex];
            Uni.Text = clickedRow.Cells[1].Value.ToString();
            Oras.Text = clickedRow.Cells[2].Value.ToString();
            Adresa.Text = clickedRow.Cells[3].Value.ToString();
            Director.Text = clickedRow.Cells[4].Value.ToString();

            if (e.RowIndex < 0 && e.ColumnIndex < 0)
            {
                Uni.Text = string.Empty;
                Oras.Text = string.Empty;
                Adresa.Text = string.Empty;
                Director.Text = string.Empty;
            }
            UniTable.ReadOnly = true;
        }

        private void UniP_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Universitati";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                UniTable.DataSource = dataTable;
            }
        }
    }
}
