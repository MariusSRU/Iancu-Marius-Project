namespace Proiect2
{
    partial class RED
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
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(205, 119);
            button1.Name = "button1";
            button1.Size = new Size(83, 26);
            button1.TabIndex = 5;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 8);
            label1.Name = "label1";
            label1.Size = new Size(298, 96);
            label1.TabIndex = 4;
            label1.Text = "Formatul anumitor campuri\r\n   este eronat. Va rugam sa\r\n     corectati si sa incercati               \r\n                  din nou";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 148);
            panel1.TabIndex = 6;
            // 
            // RED
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 150);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RED";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RED";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
    }
}