namespace LatihanProjectRPL2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            AknBttn = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            loginBttn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(AknBttn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(493, -2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(499, 645);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // AknBttn
            // 
            AknBttn.BackColor = Color.SkyBlue;
            AknBttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AknBttn.ForeColor = SystemColors.ActiveCaptionText;
            AknBttn.Location = new Point(92, 355);
            AknBttn.Name = "AknBttn";
            AknBttn.Size = new Size(330, 59);
            AknBttn.TabIndex = 6;
            AknBttn.Text = "Belum Punya Akun";
            AknBttn.UseVisualStyleBackColor = false;
            AknBttn.Click += unknownBttn_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(110, 217);
            label4.Name = "label4";
            label4.Size = new Size(284, 102);
            label4.TabIndex = 4;
            label4.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            label4.TextAlign = ContentAlignment.BottomCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(92, 151);
            label3.Name = "label3";
            label3.Size = new Size(327, 52);
            label3.TabIndex = 3;
            label3.Text = "Selamat Datang!";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(167, 133);
            label1.Name = "label1";
            label1.Size = new Size(172, 72);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(156, 420);
            label2.Name = "label2";
            label2.Size = new Size(198, 30);
            label2.TabIndex = 2;
            label2.Text = "Silahkan Login Menggunakan Akun \r\nyang Telah Diberikan";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(85, 231);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(330, 40);
            txtUsername.TabIndex = 3;
            txtUsername.Tag = "";
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(85, 291);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(330, 40);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // loginBttn
            // 
            loginBttn.BackColor = Color.SteelBlue;
            loginBttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginBttn.ForeColor = SystemColors.ActiveCaptionText;
            loginBttn.Image = (Image)resources.GetObject("loginBttn.Image");
            loginBttn.ImageAlign = ContentAlignment.MiddleLeft;
            loginBttn.Location = new Point(85, 353);
            loginBttn.Name = "loginBttn";
            loginBttn.Size = new Size(330, 59);
            loginBttn.TabIndex = 5;
            loginBttn.Text = "Login";
            loginBttn.UseVisualStyleBackColor = false;
            loginBttn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 513);
            Controls.Add(loginBttn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form - SMKMart";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button loginBttn;
        private Label label4;
        private Button AknBttn;
    }
}
