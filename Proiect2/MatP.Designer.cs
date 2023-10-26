namespace Proiect2
{
    partial class MatP
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
            MatTable = new DataGridView();
            DelB = new Button();
            InsertB = new Button();
            UpdateB = new Button();
            FilterB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Mat = new TextBox();
            An = new TextBox();
            PNProf = new TextBox();
            NProf = new TextBox();
            CloseB = new Button();
            Spec = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)MatTable).BeginInit();
            SuspendLayout();
            // 
            // MatTable
            // 
            MatTable.Anchor = AnchorStyles.None;
            MatTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatTable.Location = new Point(125, 12);
            MatTable.Name = "MatTable";
            MatTable.RowTemplate.Height = 25;
            MatTable.Size = new Size(1240, 424);
            MatTable.TabIndex = 1;
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(1284, 555);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 17;
            DelB.Text = "Sterge";
            DelB.UseVisualStyleBackColor = true;
            DelB.Click += DelB_Click;
            // 
            // InsertB
            // 
            InsertB.Anchor = AnchorStyles.None;
            InsertB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InsertB.Location = new Point(1284, 462);
            InsertB.Name = "InsertB";
            InsertB.Size = new Size(81, 30);
            InsertB.TabIndex = 16;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            InsertB.Click += InsertB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(1284, 508);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 15;
            UpdateB.Text = "Modifica";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // FilterB
            // 
            FilterB.Anchor = AnchorStyles.None;
            FilterB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FilterB.Location = new Point(451, 500);
            FilterB.Name = "FilterB";
            FilterB.Size = new Size(81, 30);
            FilterB.TabIndex = 14;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(180, 446);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 18;
            label1.Text = "Materie";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(140, 477);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 19;
            label2.Text = "Nume Profesor";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(125, 508);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 20;
            label3.Text = "Prenume Profesor";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(159, 539);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 21;
            label4.Text = "Specializare";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(152, 570);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 22;
            label5.Text = "An de Studiu";
            // 
            // Mat
            // 
            Mat.Anchor = AnchorStyles.None;
            Mat.BorderStyle = BorderStyle.FixedSingle;
            Mat.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Mat.Location = new Point(233, 442);
            Mat.Name = "Mat";
            Mat.Size = new Size(175, 25);
            Mat.TabIndex = 23;
            // 
            // An
            // 
            An.Anchor = AnchorStyles.None;
            An.BorderStyle = BorderStyle.FixedSingle;
            An.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            An.Location = new Point(233, 566);
            An.Name = "An";
            An.Size = new Size(175, 25);
            An.TabIndex = 24;
            // 
            // PNProf
            // 
            PNProf.Anchor = AnchorStyles.None;
            PNProf.BorderStyle = BorderStyle.FixedSingle;
            PNProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNProf.Location = new Point(233, 504);
            PNProf.Name = "PNProf";
            PNProf.Size = new Size(175, 25);
            PNProf.TabIndex = 26;
            // 
            // NProf
            // 
            NProf.Anchor = AnchorStyles.None;
            NProf.BorderStyle = BorderStyle.FixedSingle;
            NProf.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NProf.Location = new Point(233, 473);
            NProf.Name = "NProf";
            NProf.Size = new Size(175, 25);
            NProf.TabIndex = 27;
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
            CloseB.TabIndex = 28;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // Spec
            // 
            Spec.Anchor = AnchorStyles.None;
            Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            Spec.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Spec.FormattingEnabled = true;
            Spec.Items.AddRange(new object[] { "Informatica", "Inginerie", "Litere", "Medicina", "Stiinte Economice" });
            Spec.Location = new Point(233, 535);
            Spec.Name = "Spec";
            Spec.Size = new Size(175, 26);
            Spec.TabIndex = 84;
            // 
            // MatP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 624);
            Controls.Add(Spec);
            Controls.Add(CloseB);
            Controls.Add(NProf);
            Controls.Add(PNProf);
            Controls.Add(An);
            Controls.Add(Mat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DelB);
            Controls.Add(InsertB);
            Controls.Add(UpdateB);
            Controls.Add(FilterB);
            Controls.Add(MatTable);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 33);
            Name = "MatP";
            StartPosition = FormStartPosition.Manual;
            Text = "MatP";
            ((System.ComponentModel.ISupportInitialize)MatTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MatTable;
        private Button DelB;
        private Button InsertB;
        private Button UpdateB;
        private Button FilterB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Mat;
        private TextBox An;
        private TextBox PNProf;
        private TextBox NProf;
        private Button CloseB;
        private ComboBox Spec;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}