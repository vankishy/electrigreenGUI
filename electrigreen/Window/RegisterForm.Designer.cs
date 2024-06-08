namespace electrigreen.Frame
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
            nameBox = new TextBox();
            emailBox = new TextBox();
            passBox = new TextBox();
            passConfirmBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            loginLinkBtn = new Label();
            label6 = new Label();
            registerBtn = new ComponentControls.AuthButton();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(50, 241);
            nameBox.Margin = new Padding(3, 4, 3, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(491, 27);
            nameBox.TabIndex = 0;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(50, 313);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(491, 27);
            emailBox.TabIndex = 1;
            // 
            // passBox
            // 
            passBox.Location = new Point(50, 389);
            passBox.Margin = new Padding(3, 4, 3, 4);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(491, 27);
            passBox.TabIndex = 2;
            // 
            // passConfirmBox
            // 
            passConfirmBox.Location = new Point(52, 472);
            passConfirmBox.Margin = new Padding(3, 4, 3, 4);
            passConfirmBox.Name = "passConfirmBox";
            passConfirmBox.PasswordChar = '*';
            passConfirmBox.Size = new Size(491, 27);
            passConfirmBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 208);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 282);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 358);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 440);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 7;
            label4.Text = "Konfirmasi Password";
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
            loginLinkBtn.Location = new Point(336, 657);
            loginLinkBtn.Name = "loginLinkBtn";
            loginLinkBtn.Size = new Size(46, 20);
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
            label6.Location = new Point(50, 514);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(114, 199, 72);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(52, 567);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(489, 50);
            registerBtn.TabIndex = 12;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 710);
            Controls.Add(registerBtn);
            Controls.Add(label6);
            Controls.Add(loginLinkBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passConfirmBox);
            Controls.Add(passBox);
            Controls.Add(emailBox);
            Controls.Add(nameBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox passBox;
        private TextBox passConfirmBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label loginLinkBtn;
        private Label label6;
        private ComponentControls.AuthButton registerBtn1;
        private ComponentControls.AuthButton registerBtn;
    }
}