using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class MatP : Form
    {
        string connectionString = "Data Source=DESKTOP-ULPQA36\\SQLEXPRESS;Initial Catalog=Proiect2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public MatP()
        {
            InitializeComponent();
            Mat.TextChanged += Mat_TextChanged;
            NProf.TextChanged += NProf_TextChanged;
            PNProf.TextChanged += PNProf_TextChanged;
            An.TextChanged += An_TextChanged;
        }
        private void Mat_TextChanged(object? sender, EventArgs e)
        {
            string input = Mat.Text;
            bool DoarCifre = Litere(input);
            if (DoarCifre)
            {
                Mat.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                Mat.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void NProf_TextChanged(object? sender, EventArgs e)
        {
            string input = NProf.Text;
            bool DoarCifre = Litere(input);
            if (DoarCifre)
            {
                NProf.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                NProf.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void PNProf_TextChanged(object? sender, EventArgs e)
        {
            string input = PNProf.Text;
            bool DoarCifre = Litere(input);
            if (DoarCifre)
            {
                PNProf.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                PNProf.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void An_TextChanged(object? sender, EventArgs e)
        {
            string input = An.Text;
            bool DoarCifre = Cifre(input);
            bool AnStudiu = anstudiu(input);
            if ((DoarCifre) & (AnStudiu))
            {
                An.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                An.ForeColor = System.Drawing.Color.Red;
            }
        }

        public static bool Litere(string input)
        {
            string pattern = @"^[A-Za-z --]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public static bool anstudiu(string input)
        {
            string pattern = @"^[1-6]$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        public static bool Cifre(string input)
        {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private void FilterB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connCommand = new SqlConnection(connectionString))
            {
                connCommand.Open();
                string filterquery = $"SELECT * FROM Materii WHERE ((Materie LIKE '{Mat.Text}%') AND (Spec LIKE '{Spec.Text}%') AND (NumeProf LIKE '{NProf.Text}%') AND (PrenumeProf LIKE'{PNProf.Text}%') AND (AnStudiu LIKE'{An.Text}%'))";
                SqlDataAdapter adapter = new SqlDataAdapter(filterquery, connCommand);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                MatTable.DataSource = dataTable;

                if ((Mat.Text == "") & (Spec.Text == "") & (NProf.Text == "") & (PNProf.Text == "") & (An.Text == ""))
                {
                    Mat.Text = MatTable.Rows[0].Cells[0].Value.ToString();
                    Spec.Text = MatTable.Rows[0].Cells[1].Value.ToString();
                    NProf.Text = MatTable.Rows[0].Cells[2].Value.ToString();
                    PNProf.Text = MatTable.Rows[0].Cells[3].Value.ToString();
                    An.Text = MatTable.Rows[0].Cells[4].Value.ToString();
                }
            }
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            if ((Mat.Text != "") & (Spec.Text != "") & (NProf.Text != "") & (PNProf.Text != "") & (An.Text != ""))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {                   
                    conn.Open();
                    string idspecquery = "SELECT IdSpec FROM Specializari WHERE (Spec = '" + Spec.Text + "')";
                    SqlCommand idspeccmd = new SqlCommand(idspecquery, conn);
                    string idspecs = idspeccmd.ExecuteScalar() as string;

                    string idprofquery = "SELECT IdProf FROM Profesori WHERE ((NumeProf = '" + NProf.Text + "') AND (PrenumeProf = '" + PNProf.Text + "'))";
                    SqlCommand idprofcmd = new SqlCommand(idprofquery, conn);
                    string idprofs = idprofcmd.ExecuteScalar() as string;

                    int idspec = Convert.ToInt32(idspecs);
                    int idprof = Convert.ToInt32(idprofs);

                    string insertquery = "INSERT INTO Materii (Materie, IdSpec, Spec, IdProf, NumeProf, PrenumeProf, AnStudiu) VALUES (@param1, '"+ idspec +"', @param2, '"+ idprof +"', @param3, @param4, @param5)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@param1", Mat.Text);
                        cmd.Parameters.AddWithValue("@param2", Spec.Text);
                        cmd.Parameters.AddWithValue("@param3", NProf.Text);
                        cmd.Parameters.AddWithValue("@param4", PNProf.Text);
                        cmd.Parameters.AddWithValue("@param5", An.Text);

                        bool err = false;
                        if (Mat.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (NProf.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (PNProf.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (An.ForeColor == System.Drawing.Color.Red)
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
                string @param1 = Mat.Text;
                string @param2 = Spec.Text;
                string @param3 = NProf.Text;
                string @param4 = PNProf.Text;
                string @param5 = An.Text;
                string countquery = "SELECT COUNT(Materie) FROM Specializari WHERE ((Materie = '" + @param1 + "') AND (Spec = '" + param2 + "'))";
                using SqlCommand countCommand = new SqlCommand(countquery, conn);
                int x = Convert.ToInt32(countCommand.ExecuteScalar());
                if (x != 0)
                {
                    string queryupdate = "UPDATE Specializari SET NumeProf = '" + param3 + "' WHERE ((Materie = '" + @param1 + "') AND (Spec = '" + param2 + "')); " +
                                         "UPDATE Specializari SET PrenumeProf = '" + param4 + "' WHERE ((Materie = '" + @param1 + "') AND (Spec = '" + param2 + "')); " +
                                         "UPDATE Sepcializari SET An = '" + param5 + "' WHERE ((Materie = '" + @param1 + "') AND (Spec = '" + param2 + "')) ";
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
                string @param1 = Mat.Text;
                string deletequery = "DELETE FROM Materii WHERE (Materie = '" + param1 + "')";
                DialogResult rezultat = MessageBox.Show("Sunteti sigur(a) ca vreti sa stergeti aceasta materie? Toate datele legate de aceasta vor fi sterse!!!", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    using (SqlCommand deleteCommand = new SqlCommand(deletequery, conn))
                        deleteCommand.ExecuteNonQuery();
                }
                else { }

            }
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
