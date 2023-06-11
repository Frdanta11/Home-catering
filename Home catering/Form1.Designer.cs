namespace Home_catering
{
    partial class Form1
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
            LabelLogin = new Label();
            LabelEmail = new Label();
            LabelKataSandi = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLogin.Location = new Point(350, 32);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(104, 45);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "Login";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(339, 113);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(54, 25);
            LabelEmail.TabIndex = 1;
            LabelEmail.Text = "Email";
            // 
            // LabelKataSandi
            // 
            LabelKataSandi.AutoSize = true;
            LabelKataSandi.Location = new Point(316, 228);
            LabelKataSandi.Name = "LabelKataSandi";
            LabelKataSandi.Size = new Size(95, 25);
            LabelKataSandi.TabIndex = 2;
            LabelKataSandi.Text = "Kata Sandi";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(297, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(LabelKataSandi);
            Controls.Add(LabelEmail);
            Controls.Add(LabelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLogin;
        private Label LabelEmail;
        private Label LabelKataSandi;
        private TextBox textBox1;
    }
}