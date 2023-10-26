namespace Proiect2
{
    partial class NoteP
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
            Nota = new ComboBox();
            Mat = new ComboBox();
            DelB = new Button();
            InsertB = new Button();
            UpdateB = new Button();
            FilterB = new Button();
            label1 = new Label();
            label6 = new Label();
            PNProf = new TextBox();
            NProf = new TextBox();
            label3 = new Label();
            label4 = new Label();
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
            CloseB.Location = new Point(1454, 0);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(34, 31);
            CloseB.TabIndex = 85;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // Nota
            // 
            Nota.Anchor = AnchorStyles.None;
            Nota.DropDownStyle = ComboBoxStyle.DropDownList;
            Nota.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Nota.FormattingEnabled = true;
            Nota.Items.AddRange(new object[] { "Informatica", "Inginerie", "Litere", "Medicina", "Stiinte Economice" });
            Nota.Location = new Point(521, 490);
            Nota.Name = "Nota";
            Nota.Size = new Size(175, 26);
            Nota.TabIndex = 105;
            // 
            // Mat
            // 
            Mat.Anchor = AnchorStyles.None;
            Mat.DropDownStyle = ComboBoxStyle.DropDownList;
            Mat.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Mat.FormattingEnabled = true;
            Mat.Items.AddRange(new object[] { "Lucian Blaga", "Ovidius", "Transilvania" });
            Mat.Location = new Point(521, 454);
            Mat.Name = "Mat";
            Mat.Size = new Size(175, 26);
            Mat.TabIndex = 104;
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(1284, 544);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 101;
            DelB.Text = "Sterge";
            DelB.UseVisualStyleBackColor = true;
            DelB.Click += DelB_Click;
            // 
            // InsertB
            // 
            InsertB.Anchor = AnchorStyles.None;
            InsertB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InsertB.Location = new Point(1284, 451);
            InsertB.Name = "InsertB";
            InsertB.Size = new Size(81, 30);
            InsertB.TabIndex = 100;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            InsertB.Click += InsertB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(1284, 497);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 99;
            UpdateB.Text = "Modifica";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // FilterB
            // 
            FilterB.Anchor = AnchorStyles.None;
            FilterB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FilterB.Location = new Point(385, 544);
            FilterB.Name = "FilterB";
            FilterB.Size = new Size(81, 30);
            FilterB.TabIndex = 98;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(482, 495);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 97;
            label1.Text = "Nota";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(468, 460);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 94;
            label6.Text = "Materie";
            // 
            // PNProf
            // 
            PNProf.Anchor = AnchorStyles.None;
            PNProf.BorderStyle = BorderStyle.FixedSingle;
            PNProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNProf.Location = new Point(233, 491);
            PNProf.Name = "PNProf";
            PNProf.Size = new Size(175, 25);
            PNProf.TabIndex = 93;
            // 
            // NProf
            // 
            NProf.Anchor = AnchorStyles.None;
            NProf.BorderStyle = BorderStyle.FixedSingle;
            NProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NProf.Location = new Point(233, 456);
            NProf.Name = "NProf";
            NProf.Size = new Size(175, 25);
            NProf.TabIndex = 92;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(140, 460);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 91;
            label3.Text = "Nume Student";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(125, 495);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 90;
            label4.Text = "Prenume Student";
            // 
            // NoteP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 624);
            Controls.Add(Nota);
            Controls.Add(Mat);
            Controls.Add(DelB);
            Controls.Add(InsertB);
            Controls.Add(UpdateB);
            Controls.Add(FilterB);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(PNProf);
            Controls.Add(NProf);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(CloseB);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 33);
            Name = "NoteP";
            StartPosition = FormStartPosition.Manual;
            Text = "NoteP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button CloseB;
        private ComboBox Nota;
        private ComboBox Mat;
        private Button DelB;
        private Button InsertB;
        private Button UpdateB;
        private Button FilterB;
        private Label label1;
        private Label label6;
        private TextBox PNProf;
        private TextBox NProf;
        private Label label3;
        private Label label4;
    }
}