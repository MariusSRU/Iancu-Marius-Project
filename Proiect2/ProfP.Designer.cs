namespace Proiect2
{
    partial class ProfP
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
            dataGridView1 = new DataGridView();
            CloseB = new Button();
            Datan = new TextBox();
            Tel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            PNProf = new TextBox();
            NProf = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DelB = new Button();
            InsertB = new Button();
            UpdateB = new Button();
            FilterB = new Button();
            Uni = new ComboBox();
            Mat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1240, 424);
            dataGridView1.TabIndex = 1;
            // 
            // CloseB
            // 
            CloseB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseB.BackColor = Color.Red;
            CloseB.FlatStyle = FlatStyle.Flat;
            CloseB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseB.Location = new Point(1455, 0);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(34, 31);
            CloseB.TabIndex = 29;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // Datan
            // 
            Datan.Anchor = AnchorStyles.None;
            Datan.BorderStyle = BorderStyle.FixedSingle;
            Datan.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Datan.Location = new Point(553, 530);
            Datan.Name = "Datan";
            Datan.Size = new Size(175, 25);
            Datan.TabIndex = 47;
            // 
            // Tel
            // 
            Tel.Anchor = AnchorStyles.None;
            Tel.BorderStyle = BorderStyle.FixedSingle;
            Tel.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Tel.Location = new Point(553, 495);
            Tel.Name = "Tel";
            Tel.Size = new Size(175, 25);
            Tel.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(457, 534);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 45;
            label2.Text = "Data de Nastere";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(504, 499);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 44;
            label1.Text = "Nr. Tel.";
            // 
            // PNProf
            // 
            PNProf.Anchor = AnchorStyles.None;
            PNProf.BorderStyle = BorderStyle.FixedSingle;
            PNProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNProf.Location = new Point(233, 495);
            PNProf.Name = "PNProf";
            PNProf.Size = new Size(175, 25);
            PNProf.TabIndex = 51;
            // 
            // NProf
            // 
            NProf.Anchor = AnchorStyles.None;
            NProf.BorderStyle = BorderStyle.FixedSingle;
            NProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NProf.Location = new Point(233, 460);
            NProf.Name = "NProf";
            NProf.Size = new Size(175, 25);
            NProf.TabIndex = 50;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(140, 464);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 49;
            label3.Text = "Nume Profesor";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(125, 499);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 48;
            label4.Text = "Prenume Profesor";
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(553, 460);
            Email.Name = "Email";
            Email.Size = new Size(175, 25);
            Email.TabIndex = 55;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(511, 464);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 53;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(180, 534);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 52;
            label6.Text = "Materie";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(158, 567);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 56;
            label7.Text = "Universitate";
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(1284, 548);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 61;
            DelB.Text = "Sterge";
            DelB.UseVisualStyleBackColor = true;
            DelB.Click += DelB_Click;
            // 
            // InsertB
            // 
            InsertB.Anchor = AnchorStyles.None;
            InsertB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InsertB.Location = new Point(1284, 455);
            InsertB.Name = "InsertB";
            InsertB.Size = new Size(81, 30);
            InsertB.TabIndex = 60;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(1284, 501);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 59;
            UpdateB.Text = "Modifica";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // FilterB
            // 
            FilterB.Anchor = AnchorStyles.None;
            FilterB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FilterB.Location = new Point(757, 510);
            FilterB.Name = "FilterB";
            FilterB.Size = new Size(81, 30);
            FilterB.TabIndex = 58;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // Uni
            // 
            Uni.Anchor = AnchorStyles.None;
            Uni.DropDownStyle = ComboBoxStyle.DropDownList;
            Uni.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Uni.FormattingEnabled = true;
            Uni.Items.AddRange(new object[] { "Lucian Blaga", "Ovidius", "Transilvania" });
            Uni.Location = new Point(233, 562);
            Uni.Name = "Uni";
            Uni.Size = new Size(175, 26);
            Uni.TabIndex = 83;
            // 
            // Mat
            // 
            Mat.Anchor = AnchorStyles.None;
            Mat.DropDownStyle = ComboBoxStyle.DropDownList;
            Mat.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Mat.FormattingEnabled = true;
            Mat.Items.AddRange(new object[] { "Lucian Blaga", "Ovidius", "Transilvania" });
            Mat.Location = new Point(233, 529);
            Mat.Name = "Mat";
            Mat.Size = new Size(175, 26);
            Mat.TabIndex = 84;
            // 
            // ProfP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 624);
            Controls.Add(Mat);
            Controls.Add(Uni);
            Controls.Add(DelB);
            Controls.Add(InsertB);
            Controls.Add(UpdateB);
            Controls.Add(FilterB);
            Controls.Add(label7);
            Controls.Add(Email);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(PNProf);
            Controls.Add(NProf);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Datan);
            Controls.Add(Tel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CloseB);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 33);
            Name = "ProfP";
            StartPosition = FormStartPosition.Manual;
            Text = "ProfP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button CloseB;
        private TextBox Datan;
        private TextBox Tel;
        private Label label2;
        private Label label1;
        private TextBox PNProf;
        private TextBox NProf;
        private Label label3;
        private Label label4;
        private TextBox Email;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button DelB;
        private Button InsertB;
        private Button UpdateB;
        private Button FilterB;
        private ComboBox Uni;
        private ComboBox Mat;
    }
}