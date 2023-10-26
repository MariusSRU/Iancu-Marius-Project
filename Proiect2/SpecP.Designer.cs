namespace Proiect2
{
    partial class SpecP
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
            SpecTable = new DataGridView();
            InsertB = new Button();
            UpdateB = new Button();
            DelB = new Button();
            CloseB = new Button();
            label1 = new Label();
            FilterB = new Button();
            Spec = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SpecTable).BeginInit();
            SuspendLayout();
            // 
            // SpecTable
            // 
            SpecTable.Anchor = AnchorStyles.None;
            SpecTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpecTable.Location = new Point(125, 12);
            SpecTable.Name = "SpecTable";
            SpecTable.RowTemplate.Height = 25;
            SpecTable.Size = new Size(1240, 424);
            SpecTable.TabIndex = 1;
            SpecTable.CellClick += SpecTable_CellClick;
            // 
            // InsertB
            // 
            InsertB.Anchor = AnchorStyles.None;
            InsertB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InsertB.Location = new Point(634, 491);
            InsertB.Name = "InsertB";
            InsertB.Size = new Size(81, 30);
            InsertB.TabIndex = 2;
            InsertB.Text = "Insereaza";
            InsertB.UseVisualStyleBackColor = true;
            InsertB.Click += InsertB_Click;
            // 
            // UpdateB
            // 
            UpdateB.Anchor = AnchorStyles.None;
            UpdateB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateB.Location = new Point(715, 491);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(81, 30);
            UpdateB.TabIndex = 3;
            UpdateB.Text = "Modifica";
            UpdateB.UseVisualStyleBackColor = true;
            UpdateB.Click += UpdateB_Click;
            // 
            // DelB
            // 
            DelB.Anchor = AnchorStyles.None;
            DelB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DelB.Location = new Point(796, 491);
            DelB.Name = "DelB";
            DelB.Size = new Size(81, 30);
            DelB.TabIndex = 4;
            DelB.Text = "Sterge";
            DelB.UseVisualStyleBackColor = true;
            DelB.Click += DelB_Click;
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
            CloseB.TabIndex = 5;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(634, 468);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "Specializare";
            // 
            // FilterB
            // 
            FilterB.Anchor = AnchorStyles.None;
            FilterB.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FilterB.Location = new Point(715, 523);
            FilterB.Name = "FilterB";
            FilterB.Size = new Size(81, 30);
            FilterB.TabIndex = 8;
            FilterB.Text = "Filtreaza";
            FilterB.UseVisualStyleBackColor = true;
            FilterB.Click += FilterB_Click;
            // 
            // Spec
            // 
            Spec.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Spec.Location = new Point(708, 465);
            Spec.Name = "Spec";
            Spec.Size = new Size(169, 25);
            Spec.TabIndex = 9;
            // 
            // SpecP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 624);
            Controls.Add(Spec);
            Controls.Add(FilterB);
            Controls.Add(label1);
            Controls.Add(CloseB);
            Controls.Add(DelB);
            Controls.Add(UpdateB);
            Controls.Add(InsertB);
            Controls.Add(SpecTable);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 33);
            Name = "SpecP";
            StartPosition = FormStartPosition.Manual;
            Text = "SpecP";
            Load += SpecP_Load;
            ((System.ComponentModel.ISupportInitialize)SpecTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SpecTable;
        private Button InsertB;
        private Button UpdateB;
        private Button DelB;
        private Button CloseB;
        private Label label1;
        private Button FilterB;
        private TextBox Spec;
    }
}