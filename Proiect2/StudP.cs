using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class StudP : Form
    {
        string connectionString = "Data Source=DESKTOP-ULPQA36\\SQLEXPRESS;Initial Catalog=Proiect2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public StudP()
        {
            InitializeComponent();
            NStud.TextChanged += NStud_TextChanged;
            PNStud.TextChanged += PNStud_TextChanged;
            Datan.TextChanged += Datan_TextChanged;
            An.TextChanged += An_TextChanged;
            Tel.TextChanged += Tel_TextChanged;
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
        private void NStud_TextChanged(object? sender, EventArgs e)
        {
            string input = NStud.Text;
            bool DoarCifre = Litere(input);
            bool Nume = Litere(input);
            if ((DoarCifre) & (Nume))
            {
                NStud.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                NStud.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void PNStud_TextChanged(object? sender, EventArgs e)
        {
            string input = PNStud.Text;
            bool DoarCifre = Litere(input);
            bool Prenume = Litere(input);
            if ((DoarCifre) & (Prenume))
            {
                PNStud.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                PNStud.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void Datan_TextChanged(object? sender, EventArgs e)
        {
            string input = Datan.Text;
            bool DoarCifre = Datanasterii(input);
            bool nastere = Datanasterii(input);
            if ((DoarCifre) & (nastere))
            {
                Datan.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                Datan.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void Tel_TextChanged(object? sender, EventArgs e)
        {
            string input = Tel.Text;
            bool DoarCifre = Cifre(input);
            bool nrtel = Cifre(input);
            if ((DoarCifre) & (nrtel))
            {
                Tel.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                Tel.ForeColor = System.Drawing.Color.Red;
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
        public static bool Datanasterii(string input)
        {
            string pattern = @"^\d{2}/\d{2}/\d{4}$";
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
                string filterquery = $"SELECT * FROM Studenti WHERE ((NumeStud LIKE '{NStud.Text}%') AND (PrenumeStud LIKE '{PNStud.Text}%') AND (NumeUni LIKE '{Uni.Text}%') AND (Spec LIKE'{Spec.Text}%') AND (EmailS LIKE'{Email.Text}%') AND (TelS LIKE'{Tel.Text}%') AND (DataNS LIKE'{Datan.Text}%') AND (An LIKE'{An.Text}%'))";
                SqlDataAdapter adapter = new SqlDataAdapter(filterquery, connCommand);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                StudTable.DataSource = dataTable;

                if ((NStud.Text == "") & (PNStud.Text == "") & (Uni.Text == "") & (Spec.Text == "") & (Email.Text == "") & (Tel.Text == "") & (Datan.Text == "") & (An.Text == ""))
                {
                    NStud.Text = StudTable.Rows[0].Cells[0].Value.ToString();
                    PNStud.Text = StudTable.Rows[0].Cells[1].Value.ToString();
                    Uni.Text = StudTable.Rows[0].Cells[2].Value.ToString();
                    Spec.Text = StudTable.Rows[0].Cells[3].Value.ToString();
                    Email.Text = StudTable.Rows[0].Cells[4].Value.ToString();
                    Tel.Text = StudTable.Rows[0].Cells[5].Value.ToString();
                    An.Text = StudTable.Rows[0].Cells[6].Value.ToString();
                }
            }
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            if ((NStud.Text != "") & (PNStud.Text != "") & (Uni.Text != "") & (Spec.Text != "") & (Datan.Text != "") & (Email.Text != "") & (Tel.Text != "") & (An.Text != ""))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string idspecquery = "SELECT IdSpec FROM Specializari WHERE (Spec = '" + Spec.Text + "')";
                    SqlCommand idspeccmd = new SqlCommand(idspecquery, conn);
                    string idspecs = idspeccmd.ExecuteScalar() as string;

                    string iduniquery = "SELECT IdUni FROM Universitati WHERE ((NumeUni = '" + Uni.Text + "'))";
                    SqlCommand idunicmd = new SqlCommand(iduniquery, conn);
                    string iduni = idunicmd.ExecuteScalar() as string;

                    int idspec = Convert.ToInt32(idspecs);
                    int idprof = Convert.ToInt32(iduni);

                    string insertquery = "INSERT INTO Studenti (NumeStud, PrenumeStud, DataNS, EmailS, TelS, IdUni, NumeUni, IdSpec, Spec, An) VALUES (@param1, @param2, @param3, @param4, @param5, '" + iduni + "', @param6, '" + idspec + "', @param7, @param8)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@param1", NStud.Text);
                        cmd.Parameters.AddWithValue("@param2", PNStud.Text);
                        cmd.Parameters.AddWithValue("@param3", Datan.Text);
                        cmd.Parameters.AddWithValue("@param4", Email.Text);
                        cmd.Parameters.AddWithValue("@param5", Tel.Text);
                        cmd.Parameters.AddWithValue("@param6", Uni.Text);
                        cmd.Parameters.AddWithValue("@param7", Spec.Text);
                        cmd.Parameters.AddWithValue("@param8", An.Text);

                        bool err = false;
                        if (NStud.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (PNStud.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (Datan.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (An.ForeColor == System.Drawing.Color.Red)
                        {
                            err = true;
                        }
                        if (Tel.ForeColor == System.Drawing.Color.Red)
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

        }

        private void DelB_Click(object sender, EventArgs e)
        {

        }
    }
}
