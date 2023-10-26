using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class SpecP : Form
    {
        string connectionString = "Data Source=DESKTOP-ULPQA36\\SQLEXPRESS;Initial Catalog=Proiect2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public SpecP()
        {
            InitializeComponent();
        }

        private void FilterB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connCommand = new SqlConnection(connectionString))
            {
                connCommand.Open();
                string filterquery = $"SELECT Spec FROM Specializaeri WHERE (Spec LIKE '{Spec.Text}%'))";
                SqlDataAdapter adapter = new SqlDataAdapter(filterquery, connCommand);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                SpecTable.DataSource = dataTable;

                if (Spec.Text == "")
                {
                    Spec.Text = SpecTable.Rows[0].Cells[1].Value.ToString();
                }
            }
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            if (Spec.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertquery = "INSERT INTO Specializari (Spec) VALUES (@param1)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@param1", Spec.Text);
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
                string @param1 = Spec.Text;
                string countquery = "SELECT COUNT(Spec) FROM Specializari WHERE (Spec = '" + @param1 + "')";
                using SqlCommand countCommand = new SqlCommand(countquery, conn);
                int x = Convert.ToInt32(countCommand.ExecuteScalar());
                if (x != 0)
                {
                    string queryupdate = "UPDATE Specializari SET Spec = '" + param1 + "' WHERE (Spec = '" + @param1 + "') ";
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
                string @param1 = Spec.Text;
                string deletequery = "DELETE FROM Specializari WHERE (Spec = '" + param1 + "')";
                DialogResult rezultat = MessageBox.Show("Sunteti sigur(a) ca vreti sa stergeti aceasta specializare? Toate datele legate de aceasta vor fi sterse!!!", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    using (SqlCommand deleteCommand = new SqlCommand(deletequery, conn))
                        deleteCommand.ExecuteNonQuery();
                }
                else { }

            }
        }

        private void SpecTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = SpecTable.Rows[e.RowIndex];
            Spec.Text = clickedRow.Cells[1].Value.ToString();

            if (e.RowIndex < 0 && e.ColumnIndex < 0)
            {
                Spec.Text = string.Empty;
            }
            SpecTable.ReadOnly = true;
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SpecP_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Specializari";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                SpecTable.DataSource = dataTable;
            }
        }

    }
}
