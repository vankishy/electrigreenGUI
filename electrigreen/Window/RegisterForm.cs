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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string nama = nameBox.Text;
            string email = emailBox.Text;
            string password = passBox.Text;
            string passConfirm = passConfirmBox.Text;

            if (!isValidName(nama))
            {
                label6.Text = "Nama hanya terdiri dari huruf";
            }
            else if (isValidName(email))
            {
                label6.Text = "Format Email tidak valid";
            }
            else if (password != passConfirm)
            {
                label6.Text = "Password salah! Coba lagi.";
            } else
            {
                User createUser = new User { Nama = nama, Email = email, Password = password };
                Register register = new Register();
                register.registerAction(createUser);
            }

            Contract.Requires(!string.IsNullOrWhiteSpace(nama), "Nama tidak boleh kosong");
            Contract.Requires(!string.IsNullOrWhiteSpace(email), "Email tidak boleh kosong");
            Contract.Requires(!string.IsNullOrWhiteSpace(password), "Password tidak boleh kosong");
            Contract.Requires(!string.IsNullOrWhiteSpace(passConfirm), "Konfirmasi Password tidak boleh kosong");      
        }
    }
}
