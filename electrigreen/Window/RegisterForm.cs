using electrigreen.ComponentControls;
using electrigreen.Core;
using electrigreen.Models;
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

namespace electrigreen.Window
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Name string check character
        public static bool IsValidName(string nama)
        {
            Regex check = new Regex("^[a-zA-Z]+$");
            return check.IsMatch(nama);
        }

        // Email string check character
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|co\.id|ac\.id|org)$";
            Regex check = new Regex(pattern);
            return check.IsMatch(email);
        }

        public bool IsValidPassword(string password)
        {
            // Panjang password harus antara 8 hingga 15 karakter
            if (password.Length < 8 || password.Length > 15)
            {
                return false;
            }

            string pattern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*(),.?""':{}|<>]).{7,14}$";

            // Periksa apakah karakter pertama adalah huruf besar
            if (!char.IsUpper(password[0]))
            {
                return false;
            }

            // Gunakan Regex untuk memvalidasi sisa password
            return Regex.IsMatch(password.Substring(1), pattern);
        }

        private void loginLinkBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // Register Button action
        private void authButton1_Click(object sender, EventArgs e)
        {
            string nama = authTextBox1.Text;
            string email = authTextBox2.Text;
            string password = authTextBox3.Text;
            string passConfirm = authTextBox4.Text;

            // String validation
            if (!IsValidName(nama))
            {
                if (string.IsNullOrWhiteSpace(nama))
                {
                    label6.Text = "Nama tidak boleh kosong!";
                    authTextBox1.BorderColor = Color.Red;
                }
                else
                {
                    label6.Text = "Nama hanya terdiri dari huruf";
                    authTextBox1.BorderColor = Color.Red;
                }                   
            }
            else if (IsValidName(email))
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    label6.Text = "Email tidak boleh kosong!";
                    authTextBox2.BorderColor = Color.Red;
                }
                else
                {
                    label6.Text = "Format Email tidak valid";
                    authTextBox2.BorderColor = Color.Red;
                }
            }
            else if (password != passConfirm)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    label6.Text = "Password tidak boleh kosong!";
                    authTextBox3.BorderColor = Color.Red;
                }
                else
                {
                    label6.Text = "Periksa kembali password anda";
                    authTextBox3.BorderColor = Color.Red;
                    authTextBox4.BorderColor = Color.Red;
                }                   
            }
            else if (string.IsNullOrWhiteSpace(passConfirm))
            {
                label6.Text = "Konfirmasi Password tidak boleh kosong!";
                authTextBox4.BorderColor = Color.Red;
            }
            else if (!IsValidPassword(password))
            {
                label6.Text = "Password harus memiliki panjang 8-15 karakter," + "\ndiawali dengan huruf besar, dan mengandung huruf kecil," + "\nangka, serta simbol.!";
                authTextBox4.BorderColor = Color.Red;
            }
            else
            {
                string passHash = BCrypt.Net.BCrypt.HashPassword(password, 13); // Hashing password
                User createUser = new User { Nama = nama, Email = email, Password = passHash };
                AuthenticationMethod register = new AuthenticationMethod();
                register.RegisterAction(createUser);

                this.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
