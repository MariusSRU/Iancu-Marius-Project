using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void TC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC.SelectedTab == UniPg)
            {
                UniP form1 = new UniP();
                form1.TopLevel = false;
                form1.Dock = DockStyle.Fill;
                UniPg.Controls.Add(form1);
                form1.Show();
            }
            if (TC.SelectedTab == SpecPg)
            {
                SpecP form2 = new SpecP();
                form2.TopLevel = false;
                form2.Dock = DockStyle.Fill;
                SpecPg.Controls.Add(form2);
                form2.Show();
            }
            if (TC.SelectedTab == MatPg)
            {
                MatP form3 = new MatP();
                form3.TopLevel = false;
                form3.Dock = DockStyle.Fill;
                MatPg.Controls.Add(form3);
                form3.Show();
            }
            if (TC.SelectedTab == ProfPg)
            {
                ProfP form4 = new ProfP();
                form4.TopLevel = false;
                form4.Dock = DockStyle.Fill;
                ProfPg.Controls.Add(form4);
                form4.Show();
            }
            if (TC.SelectedTab == StudPg)
            {
                StudP form5 = new StudP();
                form5.TopLevel = false;
                form5.Dock = DockStyle.Fill;
                StudPg.Controls.Add(form5);
                form5.Show();
            }
            if (TC.SelectedTab == NotePg)
            {
                NoteP form6 = new NoteP();
                form6.TopLevel = false;
                form6.Dock = DockStyle.Fill;
                NotePg.Controls.Add(form6);
                form6.Show();
            }
        }
    }
}
