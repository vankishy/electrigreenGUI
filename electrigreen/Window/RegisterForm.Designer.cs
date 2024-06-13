namespace electrigreen.Window
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label5 = new Label();
            loginLinkBtn = new Label();
            label6 = new Label();
            authTextBox1 = new ComponentControls.AuthTextBox();
            authButton1 = new ComponentControls.AuthButton();
            authTextBox2 = new ComponentControls.AuthTextBox();
            authTextBox3 = new ComponentControls.AuthTextBox();
            authTextBox4 = new ComponentControls.AuthTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 657);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 9;
            label5.Text = "Sudah punya akun?";
            // 
            // loginLinkBtn
            // 
            loginLinkBtn.AutoSize = true;
            loginLinkBtn.BackColor = SystemColors.Control;
            loginLinkBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLinkBtn.ForeColor = Color.FromArgb(94, 143, 51);
            loginLinkBtn.Location = new Point(334, 657);
            loginLinkBtn.Name = "loginLinkBtn";
            loginLinkBtn.Size = new Size(48, 20);
            loginLinkBtn.TabIndex = 10;
            loginLinkBtn.Text = "Login";
            loginLinkBtn.Click += loginLinkBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(49, 504);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 11;
            // 
            // authTextBox1
            // 
            authTextBox1.BackColor = Color.Transparent;
            authTextBox1.BackColor1 = SystemColors.Control;
            authTextBox1.BorderColor = Color.Black;
            authTextBox1.BorderSize = 1.53D;
            authTextBox1.Cursor = Cursors.IBeam;
            authTextBox1.Font = new Font("Segoe UI", 9F);
            authTextBox1.Location = new Point(50, 143);
            authTextBox1.Name = "authTextBox1";
            authTextBox1.PasswordChar = '\0';
            authTextBox1.Radius = 20;
            authTextBox1.Size = new Size(490, 50);
            authTextBox1.TabIndex = 12;
            authTextBox1.Text = "John";
            authTextBox1.UseSystemPasswordChar = false;
            authTextBox1.WaterMark = "John";
            authTextBox1.WatermarkColor = Color.Gray;
            // 
            // authButton1
            // 
            authButton1.BackColor = Color.FromArgb(114, 199, 72);
            authButton1.FlatAppearance.BorderSize = 0;
            authButton1.FlatStyle = FlatStyle.Flat;
            authButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            authButton1.ForeColor = Color.White;
            authButton1.Location = new Point(50, 574);
            authButton1.Name = "authButton1";
            authButton1.Size = new Size(490, 50);
            authButton1.TabIndex = 13;
            authButton1.Text = "Register";
            authButton1.UseVisualStyleBackColor = false;
            authButton1.Click += authButton1_Click;
            // 
            // authTextBox2
            // 
            authTextBox2.BackColor = Color.Transparent;
            authTextBox2.BackColor1 = SystemColors.Control;
            authTextBox2.BorderColor = Color.Black;
            authTextBox2.BorderSize = 1.53D;
            authTextBox2.Cursor = Cursors.IBeam;
            authTextBox2.Font = new Font("Segoe UI", 9F);
            authTextBox2.Location = new Point(50, 245);
            authTextBox2.Name = "authTextBox2";
            authTextBox2.PasswordChar = '\0';
            authTextBox2.Radius = 20;
            authTextBox2.Size = new Size(490, 50);
            authTextBox2.TabIndex = 14;
            authTextBox2.Text = "contoh@xyz.com";
            authTextBox2.UseSystemPasswordChar = false;
            authTextBox2.WaterMark = "contoh@xyz.com";
            authTextBox2.WatermarkColor = Color.Gray;
            // 
            // authTextBox3
            // 
            authTextBox3.BackColor = Color.Transparent;
            authTextBox3.BackColor1 = SystemColors.Control;
            authTextBox3.BorderColor = Color.Black;
            authTextBox3.BorderSize = 1.53D;
            authTextBox3.Cursor = Cursors.IBeam;
            authTextBox3.Font = new Font("Segoe UI", 9F);
            authTextBox3.Location = new Point(50, 346);
            authTextBox3.Name = "authTextBox3";
            authTextBox3.PasswordChar = '●';
            authTextBox3.Radius = 20;
            authTextBox3.Size = new Size(490, 50);
            authTextBox3.TabIndex = 15;
            authTextBox3.Text = "Password";
            authTextBox3.UseSystemPasswordChar = false;
            authTextBox3.WaterMark = "Password";
            authTextBox3.WatermarkColor = Color.Gray;
            // 
            // authTextBox4
            // 
            authTextBox4.BackColor = Color.Transparent;
            authTextBox4.BackColor1 = SystemColors.Control;
            authTextBox4.BorderColor = Color.Black;
            authTextBox4.BorderSize = 1.53D;
            authTextBox4.Cursor = Cursors.IBeam;
            authTextBox4.Font = new Font("Segoe UI", 9F);
            authTextBox4.Location = new Point(50, 449);
            authTextBox4.Name = "authTextBox4";
            authTextBox4.PasswordChar = '●';
            authTextBox4.Radius = 20;
            authTextBox4.Size = new Size(490, 50);
            authTextBox4.TabIndex = 16;
            authTextBox4.Text = "Password";
            authTextBox4.UseSystemPasswordChar = false;
            authTextBox4.WaterMark = "Password";
            authTextBox4.WatermarkColor = Color.Gray;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(161, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 110);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 18;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 212);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 314);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 417);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 21;
            label4.Text = "Konfirmasi Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 710);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(authTextBox4);
            Controls.Add(authTextBox3);
            Controls.Add(authTextBox2);
            Controls.Add(authButton1);
            Controls.Add(authTextBox1);
            Controls.Add(label6);
            Controls.Add(loginLinkBtn);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electrigreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label loginLinkBtn;
        private Label label6;
        private ComponentControls.AuthButton registerBtn1;
        private ComponentControls.AuthButton registerBtn;
        private ComponentControls.AuthTextBox nameTextBox;
        private ComponentControls.AuthTextBox emailTextBox;
        private ComponentControls.AuthTextBox passTextBox;
        private ComponentControls.AuthTextBox confirmPassTextBox;
        private ComponentControls.AuthTextBox authTextBox1;
        private ComponentControls.AuthButton authButton1;
        private ComponentControls.AuthTextBox authTextBox2;
        private ComponentControls.AuthTextBox authTextBox3;
        private ComponentControls.AuthTextBox authTextBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}