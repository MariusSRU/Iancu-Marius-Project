namespace Proiect2
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TC = new TabControl();
            UniPg = new TabPage();
            SpecPg = new TabPage();
            MatPg = new TabPage();
            ProfPg = new TabPage();
            StudPg = new TabPage();
            NotePg = new TabPage();
            TC.SuspendLayout();
            SuspendLayout();
            // 
            // TC
            // 
            TC.Controls.Add(UniPg);
            TC.Controls.Add(SpecPg);
            TC.Controls.Add(MatPg);
            TC.Controls.Add(ProfPg);
            TC.Controls.Add(StudPg);
            TC.Controls.Add(NotePg);
            TC.Dock = DockStyle.Fill;
            TC.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TC.Location = new Point(0, 0);
            TC.Name = "TC";
            TC.SelectedIndex = 0;
            TC.Size = new Size(1496, 688);
            TC.TabIndex = 2;
            TC.SelectedIndexChanged += TC_SelectedIndexChanged;
            // 
            // UniPg
            // 
            UniPg.AllowDrop = true;
            UniPg.Location = new Point(4, 27);
            UniPg.Name = "UniPg";
            UniPg.Padding = new Padding(3);
            UniPg.Size = new Size(1488, 657);
            UniPg.TabIndex = 0;
            UniPg.Text = "Universitati";
            UniPg.UseVisualStyleBackColor = true;
            // 
            // SpecPg
            // 
            SpecPg.Location = new Point(4, 27);
            SpecPg.Name = "SpecPg";
            SpecPg.Padding = new Padding(3);
            SpecPg.Size = new Size(1488, 657);
            SpecPg.TabIndex = 1;
            SpecPg.Text = "Specializari";
            SpecPg.UseVisualStyleBackColor = true;
            // 
            // MatPg
            // 
            MatPg.Location = new Point(4, 27);
            MatPg.Name = "MatPg";
            MatPg.Padding = new Padding(3);
            MatPg.Size = new Size(1488, 657);
            MatPg.TabIndex = 2;
            MatPg.Text = "Materii";
            MatPg.UseVisualStyleBackColor = true;
            // 
            // ProfPg
            // 
            ProfPg.Location = new Point(4, 27);
            ProfPg.Name = "ProfPg";
            ProfPg.Padding = new Padding(3);
            ProfPg.Size = new Size(1488, 657);
            ProfPg.TabIndex = 3;
            ProfPg.Text = "Profesori";
            ProfPg.UseVisualStyleBackColor = true;
            // 
            // StudPg
            // 
            StudPg.Location = new Point(4, 27);
            StudPg.Name = "StudPg";
            StudPg.Padding = new Padding(3);
            StudPg.Size = new Size(1488, 657);
            StudPg.TabIndex = 4;
            StudPg.Text = "Studenti";
            StudPg.UseVisualStyleBackColor = true;
            // 
            // NotePg
            // 
            NotePg.Location = new Point(4, 27);
            NotePg.Name = "NotePg";
            NotePg.Padding = new Padding(3);
            NotePg.Size = new Size(1488, 657);
            NotePg.TabIndex = 5;
            NotePg.Text = "Note";
            NotePg.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 688);
            Controls.Add(TC);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iancu Marius - Proiect";
            WindowState = FormWindowState.Maximized;
            Load += TC_SelectedIndexChanged;
            TC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl TC;
        private TabPage UniPg;
        private TabPage SpecPg;
        private TabPage MatPg;
        private TabPage ProfPg;
        private TabPage StudPg;
        private TabPage NotePg;
    }
}