namespace Proiect2
{
    partial class LoginP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            User = new TextBox();
            label3 = new Label();
            Parola = new TextBox();
            button1 = new Button();
            CloseB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(773, 188);
            label1.Name = "label1";
            label1.Size = new Size(178, 73);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(708, 325);
            label2.Name = "label2";
            label2.Size = new Size(57, 29);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // User
            // 
            User.Anchor = AnchorStyles.None;
            User.Location = new Point(792, 328);
            User.Name = "User";
            User.Size = new Size(208, 27);
            User.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(690, 395);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 4;
            label3.Text = "Parola";
            // 
            // Parola
            // 
            Parola.Anchor = AnchorStyles.None;
            Parola.Location = new Point(792, 398);
            Parola.Name = "Parola";
            Parola.Size = new Size(208, 27);
            Parola.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(792, 484);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 6;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CloseB
            // 
            CloseB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseB.BackColor = Color.FromArgb(215, 25, 25);
            CloseB.FlatAppearance.BorderSize = 0;
            CloseB.FlatStyle = FlatStyle.Flat;
            CloseB.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CloseB.Location = new Point(1667, 0);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(43, 43);
            CloseB.TabIndex = 9;
            CloseB.Text = "X";
            CloseB.UseVisualStyleBackColor = false;
            CloseB.Click += CloseB_Click;
            // 
            // LoginP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 917);
            Controls.Add(CloseB);
            Controls.Add(button1);
            Controls.Add(Parola);
            Controls.Add(label3);
            Controls.Add(User);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            WindowState = FormWindowState.Maximized;
            Load += LoginP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox User;
        private Label label3;
        private TextBox Parola;
        private Button button1;
        private Button CloseB;
    }
}