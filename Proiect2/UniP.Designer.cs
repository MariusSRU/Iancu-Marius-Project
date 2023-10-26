namespace Proiect2
{
    partial class UniP
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
            UniTable = new DataGridView();
            CloseB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Oras = new TextBox();
            Adresa = new TextBox();
            Director = new TextBox();
            FilterB = new Button();
            UpdateB = new Button();
            InsertB = new Button();
            DelB = new Button();
            Uni = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)UniTable).BeginInit();
            SuspendLayout();
            // 
            // UniTable
            // 
            UniTable.Anchor = AnchorStyles.None;
            UniTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UniTable.Location = new Point(125, 12);
            UniTable.Name = "UniTable";
            UniTable.RowTemplate.Height = 25;
            UniTable.Size = new Size(1240, 424);
            UniTable.TabIndex = 0;
            UniTable.CellClick += UniTable_CellClick;
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
            CloseB.TabIndex = 1;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(125, 476);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Universitatea";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(169, 520);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Oras";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(447, 476);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Adresa";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(441, 520);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Director";
            // 
            // Oras
            // 
            Oras.Anchor = AnchorStyles.None;
            Oras.BorderStyle = BorderStyle.FixedSingle;
            Oras.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Oras.Location = new Point(206, 516);
            Oras.Name = "Oras";
            Oras.Size = new Size(175, 25);
            Oras.TabIndex = 7;
            Oras.Text = "3ret";
            // 
            // Adresa
            // 
            Adresa.Anchor = AnchorStyles.None;
            Adresa.BorderStyle = BorderStyle.FixedSingle;
            Adresa.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Adresa.Location = new Point(496, 473);
            Adresa.Name = "Adresa";
            Adresa.Size = new Size(175, 25);
            Adresa.TabIndex = 8;
            // 
            // Director
            // 
            Director.Anchor = AnchorStyles.None;
            Director.BorderStyle = BorderStyle.FixedSingle;
            Director.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Director.Location = new Point(496, 516);
            Director.Name = "Director";
            Director.Size = new Size(175, 25);
            Director.TabIndex = 9;
            // 
            // FilterB
            // 
            FilterB.Anchor = AnchorStyles.None;
            FilterB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FilterB.Location = new Point(738, 491);
            FilterB.Name = "FilterB";
            FilterB.Size = new Size(81, 30);
            FilterB.TabIndex = 10;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(1284, 505);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 11;
            UpdateB.Text = "Modifica";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // InsertB
            // 
            InsertB.Anchor = AnchorStyles.None;
            InsertB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InsertB.Location = new Point(1284, 469);
            InsertB.Name = "InsertB";
            InsertB.Size = new Size(81, 30);
            InsertB.TabIndex = 12;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            InsertB.Click += InsertB_Click;
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(1284, 541);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 13;
            DelB.Text = "Sterge";
            DelB.UseVisualStyleBackColor = true;
            DelB.Click += DelB_Click;
            // 
            // Uni
            // 
            Uni.Anchor = AnchorStyles.None;
            Uni.DropDownStyle = ComboBoxStyle.DropDownList;
            Uni.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Uni.FormattingEnabled = true;
            Uni.Items.AddRange(new object[] { "Lucian Blaga", "Ovidius", "Transilvania", "" });
            Uni.Location = new Point(206, 469);
            Uni.Name = "Uni";
            Uni.Size = new Size(175, 26);
            Uni.TabIndex = 83;
            // 
            // UniP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1488, 624);
            Controls.Add(Uni);
            Controls.Add(DelB);
            Controls.Add(InsertB);
            Controls.Add(UpdateB);
            Controls.Add(FilterB);
            Controls.Add(Director);
            Controls.Add(Adresa);
            Controls.Add(Oras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CloseB);
            Controls.Add(UniTable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UniP";
            StartPosition = FormStartPosition.Manual;
            Load += UniP_Load;
            ((System.ComponentModel.ISupportInitialize)UniTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UniTable;
        private Button CloseB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Oras;
        private TextBox Adresa;
        private TextBox Director;
        private Button FilterB;
        private Button UpdateB;
        private Button InsertB;
        private Button DelB;
        private ComboBox Uni;
    }
}