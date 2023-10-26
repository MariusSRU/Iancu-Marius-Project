namespace Proiect2
{
    partial class StudP
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
            StudTable = new DataGridView();
            DelB = new Button();
            InsertB = new Button();
            UpdateB = new Button();
            FilterB = new Button();
            label7 = new Label();
            Email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            PNStud = new TextBox();
            NStud = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Datan = new TextBox();
            Tel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            An = new TextBox();
            label8 = new Label();
            Uni = new ComboBox();
            Spec = new ComboBox();
            CloseB = new Button();
            ((System.ComponentModel.ISupportInitialize)StudTable).BeginInit();
            SuspendLayout();
            // 
            // StudTable
            // 
            StudTable.Anchor = AnchorStyles.None;
            StudTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudTable.Location = new Point(125, 12);
            StudTable.Name = "StudTable";
            StudTable.RowTemplate.Height = 25;
            StudTable.Size = new Size(1240, 424);
            StudTable.TabIndex = 1;
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(1284, 548);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 79;
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
            InsertB.TabIndex = 78;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            InsertB.Click += InsertB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(1284, 501);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 77;
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
            FilterB.TabIndex = 76;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(158, 534);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 74;
            label7.Text = "Universitate";
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(553, 460);
            Email.Name = "Email";
            Email.Size = new Size(175, 25);
            Email.TabIndex = 73;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(511, 464);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 71;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(156, 567);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 70;
            label6.Text = "Specializare";
            // 
            // PNStud
            // 
            PNStud.Anchor = AnchorStyles.None;
            PNStud.BorderStyle = BorderStyle.FixedSingle;
            PNStud.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNStud.Location = new Point(233, 495);
            PNStud.Name = "PNStud";
            PNStud.Size = new Size(175, 25);
            PNStud.TabIndex = 69;
            // 
            // NStud
            // 
            NStud.Anchor = AnchorStyles.None;
            NStud.BorderStyle = BorderStyle.FixedSingle;
            NStud.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NStud.Location = new Point(233, 460);
            NStud.Name = "NStud";
            NStud.Size = new Size(175, 25);
            NStud.TabIndex = 68;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(140, 464);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 67;
            label3.Text = "Nume Student";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(125, 499);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 66;
            label4.Text = "Prenume Student";
            // 
            // Datan
            // 
            Datan.Anchor = AnchorStyles.None;
            Datan.BorderStyle = BorderStyle.FixedSingle;
            Datan.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Datan.Location = new Point(553, 530);
            Datan.Name = "Datan";
            Datan.Size = new Size(175, 25);
            Datan.TabIndex = 65;
            // 
            // Tel
            // 
            Tel.Anchor = AnchorStyles.None;
            Tel.BorderStyle = BorderStyle.FixedSingle;
            Tel.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Tel.Location = new Point(553, 495);
            Tel.Name = "Tel";
            Tel.Size = new Size(175, 25);
            Tel.TabIndex = 64;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(457, 534);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 63;
            label2.Text = "Data de Nastere";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(504, 499);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 62;
            label1.Text = "Nr. Tel.";
            // 
            // An
            // 
            An.Anchor = AnchorStyles.None;
            An.BorderStyle = BorderStyle.FixedSingle;
            An.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            An.Location = new Point(553, 567);
            An.Name = "An";
            An.Size = new Size(175, 25);
            An.TabIndex = 81;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(525, 571);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 80;
            label8.Text = "An";
            // 
            // Uni
            // 
            Uni.Anchor = AnchorStyles.None;
            Uni.DropDownStyle = ComboBoxStyle.DropDownList;
            Uni.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Uni.FormattingEnabled = true;
            Uni.Items.AddRange(new object[] { "Lucian Blaga", "Ovidius", "Transilvania" });
            Uni.Location = new Point(233, 531);
            Uni.Name = "Uni";
            Uni.Size = new Size(175, 26);
            Uni.TabIndex = 82;
            // 
            // Spec
            // 
            Spec.Anchor = AnchorStyles.None;
            Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            Spec.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Spec.FormattingEnabled = true;
            Spec.Items.AddRange(new object[] { "Informatica", "Inginerie", "Litere", "Medicina", "Stiinte Economice" });
            Spec.Location = new Point(233, 562);
            Spec.Name = "Spec";
            Spec.Size = new Size(175, 26);
            Spec.TabIndex = 83;
            // 
            // CloseB
            // 
            CloseB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseB.BackColor = Color.Red;
            CloseB.FlatStyle = FlatStyle.Flat;
            CloseB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseB.Location = new Point(1454, -1);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(34, 31);
            CloseB.TabIndex = 84;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // StudP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 624);
            Controls.Add(CloseB);
            Controls.Add(Spec);
            Controls.Add(Uni);
            Controls.Add(An);
            Controls.Add(label8);
            Controls.Add(DelB);
            Controls.Add(InsertB);
            Controls.Add(UpdateB);
            Controls.Add(FilterB);
            Controls.Add(label7);
            Controls.Add(Email);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(PNStud);
            Controls.Add(NStud);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Datan);
            Controls.Add(Tel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StudTable);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 33);
            Name = "StudP";
            StartPosition = FormStartPosition.Manual;
            Text = "StudP";
            ((System.ComponentModel.ISupportInitialize)StudTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudTable;
        private Button DelB;
        private Button InsertB;
        private Button UpdateB;
        private Button FilterB;
        private Label label7;
        private TextBox Email;
        private Label label5;
        private Label label6;
        private TextBox PNStud;
        private TextBox NStud;
        private Label label3;
        private Label label4;
        private TextBox Datan;
        private TextBox Tel;
        private Label label2;
        private Label label1;
        private TextBox An;
        private Label label8;
        private ComboBox Uni;
        private ComboBox Spec;
        private Button CloseB;
    }
}