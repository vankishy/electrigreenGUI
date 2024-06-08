using electrigreen.Core;
using electrigreen.Models;
using LoginPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


//Author : Reinhard Situmeang
namespace electrigreen.Frame
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static bool isValidName(string nama)
        {
            Regex check = new Regex("^[a-zA-Z]+$");
            return check.IsMatch(nama);
        }

        public bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|co\.id|ac\.id|org)$";
            Regex check = new Regex(pattern);
            return check.IsMatch(email);
        }

        private void loginLinkBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string nama = nameBox.Text;
            string email = emailBox.Text;
            string password = passBox.Text;
            string passConfirm = passConfirmBox.Text;

            if (!isValidName(nama))
            {
                if (string.IsNullOrWhiteSpace(nama))
                {
                    label6.Text = "Nama tidak boleh kosong!";
                }
                else
                    label6.Text = "Nama hanya terdiri dari huruf";
            }
            else if (isValidName(email))
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    label6.Text = "Email tidak boleh kosong!";
                }
                else
                    label6.Text = "Format Email tidak valid";
            }
            else if (password != passConfirm)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    label6.Text = "Password tidak boleh kosong!";
                }
                else
                    label6.Text = "Periksa kembali password anda";
            }
            else if (string.IsNullOrWhiteSpace(passConfirm))
            {
                label6.Text = "Konfirmasi Password tidak boleh kosong!";
            }
            else
            {
                User createUser = new User { Nama = nama, Email = email, Password = password };
                Register register = new Register();
                register.registerAction(createUser);
                this.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
