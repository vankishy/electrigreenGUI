namespace electrigreen.Window
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            authTextBox1 = new electrigreen.ComponentControls.AuthTextBox();
            authTextBox2 = new electrigreen.ComponentControls.AuthTextBox();
            authButton1 = new electrigreen.ComponentControls.AuthButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(161, 210);
            label2.Name = "label2";
            label2.Size = new Size(103, 34);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(161, 319);
            label3.Name = "label3";
            label3.Size = new Size(169, 34);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 574);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 7;
            label5.Text = "Belum punya akun bro? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(343, 574);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Register";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = electrigreen.Properties.Resources.Logo;
            pictureBox1.Location = new Point(161, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // authTextBox1
            // 
            authTextBox1.BackColor = Color.Transparent;
            authTextBox1.BackColor1 = SystemColors.Control;
            authTextBox1.BorderColor = Color.Black;
            authTextBox1.BorderSize = 1.5D;
            authTextBox1.Font = new Font("Segoe UI", 9F);
            authTextBox1.Location = new Point(163, 259);
            authTextBox1.Name = "authTextBox1";
            authTextBox1.PasswordChar = '\0';
            authTextBox1.Radius = 20;
            authTextBox1.Size = new Size(268, 45);
            authTextBox1.TabIndex = 19;
            authTextBox1.UseSystemPasswordChar = false;
            authTextBox1.WaterMark = "Your Email";
            authTextBox1.WatermarkColor = Color.Gray;
            // 
            // authTextBox2
            // 
            authTextBox2.BackColor = Color.Transparent;
            authTextBox2.BackColor1 = SystemColors.Control;
            authTextBox2.BorderColor = Color.Black;
            authTextBox2.BorderSize = 1.5D;
            authTextBox2.Font = new Font("Segoe UI", 9F);
            authTextBox2.Location = new Point(163, 356);
            authTextBox2.Name = "authTextBox2";
            authTextBox2.PasswordChar = '\0';
            authTextBox2.Radius = 20;
            authTextBox2.Size = new Size(268, 45);
            authTextBox2.TabIndex = 20;
            authTextBox2.UseSystemPasswordChar = false;
            authTextBox2.WaterMark = "Correct Password";
            authTextBox2.WatermarkColor = Color.Gray;
            // 
            // authButton1
            // 
            authButton1.BackColor = Color.FromArgb(114, 199, 72);
            authButton1.FlatAppearance.BorderSize = 0;
            authButton1.FlatStyle = FlatStyle.Flat;
            authButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            authButton1.ForeColor = Color.White;
            authButton1.Location = new Point(201, 491);
            authButton1.Name = "authButton1";
            authButton1.Size = new Size(188, 50);
            authButton1.TabIndex = 21;
            authButton1.Text = "Login";
            authButton1.UseVisualStyleBackColor = false;
            authButton1.Click += authButton1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(594, 710);
            Controls.Add(authButton1);
            Controls.Add(authTextBox2);
            Controls.Add(authTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electrigreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private electrigreen.ComponentControls.AuthTextBox authTextBox1;
        private electrigreen.ComponentControls.AuthTextBox authTextBox2;
        private electrigreen.ComponentControls.AuthButton authButton1;
    }
}
